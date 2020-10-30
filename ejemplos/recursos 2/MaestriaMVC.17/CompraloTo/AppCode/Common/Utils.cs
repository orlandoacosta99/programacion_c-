using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo
{
    public class Utils
    {

        public static bool InProduction
        {
            get
            {
                bool inProduction = true;
#if DEBUG
                inProduction = false;
#endif
                return inProduction;
            }
        }


        public static string AssemblyVersion
        {
            get
            {
                System.Reflection.AssemblyName asmN = System.Reflection.Assembly.GetExecutingAssembly().GetName();
                return asmN.Version.Build.ToString() + asmN.Version.Revision.ToString();
            }
        }



    }
}