using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
namespace Client {
    class Program {
        static void Main(string[] args) {
            //Util util = new Util.UtilBuilder().UseGetLink("This comes from settings: {0}");
            Util util = Util.UtilBuilder.New.UseGetLink("This comes from settings: {0}");
            Console.WriteLine(util.GetFormatedGetLink("parameter One"));
            Console.ReadLine();
        }
    }
}
