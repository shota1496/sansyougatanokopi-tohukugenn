using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
        Console.WriteLine("Hello world!");

        string s ="init";
        a a1 = new a(){s=s};
        a a1Copy = new a(a1);
        Console.WriteLine(a1==a1Copy);
        Console.WriteLine(a1.s);
        a1.s = "change";
        Console.WriteLine(a1.s);
  
        a1 = a1Copy;
        Console.WriteLine(a1==a1Copåy);
        Console.WriteLine(a1.s);
        }

       
    }

    public class a{
        public a(){}
        public a(a _a){
            s = _a.s;
        }
        public string s;
    }

    
}

