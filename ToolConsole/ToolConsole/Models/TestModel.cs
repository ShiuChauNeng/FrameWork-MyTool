using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolConsole.Models
{
    public class MyTestClass
    {
        public int I { get; set; }

        public bool B { get; set; }

        public string S { get; set; }

        public List<int> L { get; set; }

        public DateTime D { get; set; }

        public MyEnum E { get; set; }

        public MyClass C { get; set; }
    }

    public class MyClass
    {
        public string M1 { get; set; }
        public int M2 { get; set; }
    }

    public enum MyEnum
    {
        First,
        Second
    }
}
