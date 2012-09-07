using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Schedule(1)

        }
        public static void Schedule(int courseId, out string name, out DateTime scheduledTime)
        {
            name = "something";
            scheduledTime = DateTime.Now;
        }
    }
}
