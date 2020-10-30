using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroLinq
{
    public static class TestActionTT
    {

        public static void Test(Action<string> action)
        {
            action("hola Action");
            action("hola Action de nuevo");
            action("hola que hase");
        }

    }
}
