using Microsoft.EntityFrameworkCore;
using Server;
using System.Net;
using System.Net.Sockets;
using System.Text;

const int port = 2008;
IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
socket.Bind(endPoint);
socket.Listen();

char ch = '0';

do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Server work\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1.Watch client activity\n2.Close server");
    ch = char.Parse(Console.ReadLine());
    if(ch == '1')
    {
        Console.Clear();
        Console.WriteLine("Id\t\tClient's IP\t\tActivity\t\tDate");
        using(MyDBContext context = new MyDBContext())
            foreach(Note note in context.Notes)
                Console.WriteLine(note.ToString());
        Console.ReadLine();
    }
} while (ch != '2');
Console.Clear();
socket.Close();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Server close");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadLine();