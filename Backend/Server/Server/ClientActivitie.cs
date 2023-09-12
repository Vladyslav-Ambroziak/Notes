using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientActivitie
    {
        public int Id { get; set; }
        public string IPClient { get; set; }
        public string Activity { get; set; }
        public DateTime Date { get; set; }

        public ClientActivitie() { }
        public override string ToString() => $"{Id})\t{IPClient}\t{Activity}\t{Date}";
    }
}
