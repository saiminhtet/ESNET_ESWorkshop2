using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace esnet_efworkshop02
{
    class Program
    {
        static void Main()
        {
            int input;
            startofprog:
            Explorer ex = new Explorer();
            ex.ListClasses(ex.Nspace());

            Console.Write("Choose an integer option (e.g. 2): ");
            bool parseStatus = Int32.TryParse(Console.ReadLine(), out input);
            Console.WriteLine();
            if (parseStatus == false) goto endofprog;
            else
            {
                try { ex.CallMethod(input - 1); }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error.\n" + e.ToString());
                }
            }

            endofprog:
            if (!ex.ExitCheck()) goto startofprog;
        }
    }
    public class Explorer
    {
        private string myMethod = "TestMethod"; //USER-DEFINED
        private string classIdentifier = "Test"; //USER-DEFINED
        private string[] excludeClasses = { "<>c", "Program", "Explorer" }; //USER-DEFINED
        private Type[] myClasses;

        public void ListClasses(string callerNspace)
        {
            var q = from t in Assembly.GetCallingAssembly().GetTypes()
                    where t.Namespace == callerNspace && t.IsClass &&
                          t.Name.ToString().IndexOf(classIdentifier) >= 0 &&
                          Array.IndexOf(excludeClasses, t.Name) == -1
                    orderby t.Name ascending
                    select t;
            myClasses = new Type[q.Count()];
            myClasses = q.ToArray();
            Console.WriteLine("Please choose an index: ");
            DisplayClasses(myClasses);
        }
        public void DisplayClasses(Type[] myArr)
        {
            for (int i = 1; i <= myArr.Length; i++)
            { Console.WriteLine($"[{i}]:\t{myArr[i - 1].Name}"); }
            Console.WriteLine();
        }
        public void CallMethod(int input)
        {
            myClasses[input].InvokeMember(myMethod,
                BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static,
                null, null, null);
        }
        public bool ExitCheck()
        {
            Console.WriteLine(
                "\nPress any key to continue." +
                "\nPress Spacebar to exit.\n" +
                "\n------------------------------\n");
            if (Console.ReadKey(true).Key != ConsoleKey.Spacebar) return false;
            else { Console.WriteLine("Thank you for using the program."); return true; }
        }

        public string Nspace()
        { return Assembly.GetCallingAssembly().EntryPoint.DeclaringType.Namespace; }

        public Explorer() { }
    }
}
