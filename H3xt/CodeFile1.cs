using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModoEscuro 
{
    public static class ControladorDarkMode
    {
        public static Color corfonte;
        public static Color corfundo;
        public static Color corpanel;

        public static bool ligado = false;

        public static void TrocarModo()
        {

            if (ligado)
            {
                modoclaro();
            }
            else
            {
                modoescur();
            }



        }

        private static void modoescur()
        {
            corfundo = Color.Black;
            corfundo = Color.FromArgb(242, 247, 247);
            corpanel = Color.FromArgb(191, 191, 191);

            ligado = true;
        }

        private static void modoclaro()
        {
            corfonte = Color.White;
            corfundo = Color.FromArgb(51, 51, 51);
            corfundo = Color.FromArgb(38, 38, 38);

            ligado = false;
        }
    }
            
         


}