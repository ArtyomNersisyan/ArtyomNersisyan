using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class BaseClass
    {
        public string publifield = "public field";
        private string privatefield = "private field";
        protected string protectedfield = "potected fild";
        public void Show()
        {
            Console.WriteLine(privatefield);
        }
    }
}
