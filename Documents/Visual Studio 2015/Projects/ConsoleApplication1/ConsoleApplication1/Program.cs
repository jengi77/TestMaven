using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string gugu = "dog2go_group=" + "test_user" + "_group;";
            Console.Write(gugu.Substring(gugu.IndexOf("=", StringComparison.CurrentCulture)+1, gugu.IndexOf("_group;", StringComparison.CurrentCulture) -( gugu.IndexOf("=", StringComparison.CurrentCulture) +1)));
            Console.ReadKey();
        }
    }
}
