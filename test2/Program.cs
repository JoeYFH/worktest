using System;

namespace test2
{
    class Progam
    {


        class Member
        {
            private string name = "黃義豐";
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

        static void Main()
        {
            Member a = new Member();
            Console.WriteLine("新進員工名稱:{0}", a.Name);
        }

        
    }
}
