using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample2
{
    public class Server        //server class
    {
        private long ph;
        private string k;

        public Server(long ph, string k)
        {
            this.ph = ph;
            this.k = k;
        }

        public void Message(long phno, string name)   //call receive from user to chat and sending phone no and name
        {
            bool l = true;
            while (l)
            {
                Console.WriteLine("1. Send Message");
                Console.WriteLine("2. Exit");
                int pp = Convert.ToInt32(Console.ReadLine());
                if (pp == 1)
                {
                    Messages client = new Messages(phno, name);
                    Console.WriteLine("Enter Message");
                    string abc = Console.ReadLine();

                    client.MessageRecieve(abc);  //sending message to user wanted number /calling msg methods

                }

                else if (pp == 2)
                {
                    l = false;
                }

            }
            Dictionary<long, string> ServerAccount = new Dictionary<long, string>()   //Server Data
        {
            {6308749890,"Teja" },
            {9387499997,"Vinod" },
            {7893199199,"Deexith" },
            {9937488923,"Karthik" },
            {9087600233,"Umesh" },
            {9897323889,"Nisanth" },
            {7685727829,"Baba" },
            {8976840980,"Nikhil" }
        };


        }

    }
}
