using System;
namespace Example
{
    public delegate string demoDelegate(string str1, string str2);
    class MyEvents
    {
        event demoDelegate myEvent;
        public MyEvents()
        {
            this.myEvent += new demoDelegate(this.Display);
        }
        public string Display(string studentname, string subject)
        {
            return "Mentorul meu: " + studentname + "\nStatutul: " + subject;
        }
        static void Main(string[] args)
        {
            MyEvents e = new MyEvents();
            string res = e.myEvent("Paul", "Maestrul");
            Console.WriteLine("REZULTATUL Studiului...\n" + res);
        }
    }
}