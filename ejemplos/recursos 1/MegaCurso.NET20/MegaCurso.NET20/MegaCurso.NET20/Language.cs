using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCurso.Net20Res;

namespace MegaCurso.NET20
{
    public static class Language
    {

        public static string GetErrorMessage(int errorCode)
        {
            return Resources.ResourceManager.GetString("err" + errorCode);
        }


        public static string Salutation
        {
            get
            {
                return Resources.ResourceManager.GetString("lblSalutation");
                //return Resources.lblSalutation;
            }
        }

        public static Image Flag
        {
            get
            {
                return (Image)Resources.imgFlag;
            }
        }

    }
}
