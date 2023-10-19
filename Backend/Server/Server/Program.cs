using Microsoft.EntityFrameworkCore;
using Server;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

const int port = 2008;
IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
socket.Bind(endPoint);
socket.Listen();

Socket clientSocket = socket.Accept(); ;
char ch = '0';
bool serverWork = true;
Thread th1 = new Thread(funcThread);
th1.Start();
do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Server work\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1.Watch client activity\n2.Close server");
    ch = char.Parse(Console.ReadLine());
    if (ch == '1')
    {
        Console.Clear();
        Console.WriteLine("Id\t\tClient's IP\t\tActivity\t\tDate");
        using (MyDBContext context = new MyDBContext())
            foreach (ClientActivitie note in context.ClientActivities)
                Console.WriteLine(note.ToString());
        Console.ReadLine();
    }
} while (ch != '2');
serverWork = false;

void funcThread()
{
    while (serverWork)
    {
        byte[] buffer = new byte[1024];
        int data = 0;

        do
        {
            data = clientSocket.Receive(buffer);
            ActionInformation action = JsonSerializer.Deserialize<ActionInformation>(Encoding.Unicode.GetString(buffer, 0, data));
            PerformAnAction(action);
        } while (clientSocket.Available > 0);
    }
    clientSocket.Close();
    socket.Close();
}

void PerformAnAction(ActionInformation action)
{
    if (action.nameAction == "Add")
        using (MyDBContext context = new MyDBContext())
        {
            context.Notes.Add(action.note);
            context.SaveChanges();
        }
    if (action.nameAction == "Remove")
        using (MyDBContext context = new MyDBContext())
        {
            context.Notes.Remove(action.note);
            context.SaveChanges();
        }
    if (action.nameAction == "Update")
        using (MyDBContext context = new MyDBContext())
        {
            context.Notes.Update(action.note);
            context.SaveChanges();
        }
    if (action.nameAction == "Select")
    {
        List<Note> myNotes = new List<Note>();
        using (MyDBContext context = new MyDBContext())
        {
            foreach (Note item in context.Notes)
            {
                myNotes.Add(item);
            }
            byte[] data1 = Encoding.Unicode.GetBytes(JsonSerializer.Serialize<List<Note>>(myNotes));
            clientSocket.Send(data1);
        }
    }
}
