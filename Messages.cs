using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Messages
    {
        List<string> data = new List<string>();        //chat data storage             
        public void DisplayChat()                                 
        {
            foreach (string lo in data)
            {
                Console.WriteLine(lo);
            }
        }
        private long phono;               
        private string name;
        Messages() { }
        public Messages(long phono, string name)         //constructor call receiving from server class    
        {
            this.phono = phono;
            this.name = name;
        }

        public void MessageRecieve(string Chat)
        {
            data.Add(Chat);             //receiving message stored in data list                 
            Console.WriteLine("Send Reply Yes or No");   
            string gg = Console.ReadLine();
            if (gg == "Yes")
            {
                SendReturnMessage();
            }
        }
        public void SendReturnMessage()         //sending return message and storing in data list       
        {
            Console.WriteLine("Enter Message");
            string ll = "--------------------------------" + Console.ReadLine();
            data.Add(ll);
            DisplayChat();
        }
    }
}


