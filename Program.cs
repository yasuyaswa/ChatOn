using System;
using System.Collections.Generic;                             
using System.Linq;                                              
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using sample2;

namespace ConsoleApp3
{
    internal class Client1:Client   //interface implemented
    {
        Dictionary<long, string> account = new Dictionary<long, string>()
        {
            {9948378357,"vamsi" },
        };

        public void deletecontact(long phno)
        {
            account.Remove(phno);
            Console.WriteLine("Contact deleted successfully.");
        }

        public void addContact(long phno, string name)
        {
            account[phno] = name;
            Console.WriteLine("Contact added successfully.");
        }

        public void createGroup(long phno, string name)
        {
            Dictionary<long, string> Group = new Dictionary<long, string>()
            {

            };
            Group[phno] = name;
            Console.WriteLine("Group Created.");
        }

        static void Main(string[] args)
        {
            bool status = false;
            Dictionary<long, string> account = new Dictionary<long, string>()
            {
                {9889862556,"nikil" },
                {6965456978, "deexith"}
            };
            Console.WriteLine("Press '1' for Signup and '2' Signin");   //signup and signin options
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 2)            //signin 
            {
                Console.Write("Enter Phone No: ");
                long phno = Convert.ToInt64(Console.ReadLine());
                foreach (long x in account.Keys)
                {
                    if (x == phno) //phone number checking for signin
                    {
                        Console.Write("Enter Password   : ");
                        string n = Console.ReadLine();
                        if (n == account[x])   //password checking
                        {
                            Console.WriteLine("Account login successfully");
                            status = true;
                        }
                        else
                        {                       //if password not match
                            Console.WriteLine("You have entered incorrect password, Please try again with correct password.");
                        }
                    }
                }
                if (status == false)   //if number not matched
                {
                    Console.WriteLine("Account not registerd yet,try again with Signup.");
                }
            }
            else if (response == 1)    //signup
            {
                bool kk = true;
                Console.Write("Enter Phone No: ");
                long phno = Convert.ToInt64(Console.ReadLine());
                foreach (long x in account.Keys)
                {
                    if (x == phno)   //phone number check if already registered or not
                    {
                        Console.WriteLine("Account Already exist.");
                        kk = false;
                    }
                }
                if (kk == true)
                {
                    Console.Write("Enter Password   : ");
                    string passw = Console.ReadLine();
                    account.Add(phno, passw);
                    Console.WriteLine("Your are successfully signed up!");
                    status = true;
                }
            }

            if (status == true)
            {
                Console.WriteLine("Successfully logined next steps");
                bool l = true;
                Client1 cl = new Client1();
                while (l)
                {
                    Console.WriteLine("1. Add contact");   //choices like options
                    Console.WriteLine("2. Delete Contact");
                    Console.WriteLine("3. Create New Group");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("5. Message");
                    Console.WriteLine("6. Logout");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        Console.Write("Enter phoneNo : ");
                        long ph = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter Name : ");
                        string k = Console.ReadLine();
                        cl.addContact(ph, k);
                    }
                    else if (option == 2)
                    {
                        Console.WriteLine("Enter PhoneNo : ");
                        long pk = Convert.ToInt64(Console.ReadLine());
                        cl.deletecontact(pk);
                    }
                    else if (option == 3)
                    {

                        Console.WriteLine("Enter phoneNo:");
                        long pk = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        string ll = Console.ReadLine();
                        Client1 c1 = new Client1();
                        c1.createGroup(pk, ll);
                    }
                    else if (option == 4)
                    {
                        l = false;
                        Console.WriteLine("App closed.");
                    }
                    else if (option == 5)
                    {
                        Console.WriteLine("Enter friend number and Name to chat....");
                        long ph = Convert.ToInt64(Console.ReadLine());
                        string k = Console.ReadLine();
                        Server az = new Server(ph, k);
                        az.Message(ph, k);
                    }
                    else if(option == 6)
                    {
                        Console.WriteLine("Enter Registerd Number");
                        long lo = Convert.ToInt64(Console.ReadLine());
                        account.Remove(lo);
                        //status = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter correct number : ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


