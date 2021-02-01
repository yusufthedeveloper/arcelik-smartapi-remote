using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Inter_ctive_tv_remote
{
    class InteractiveAPI
    {
        public static string urlbtn;
        public static string tvip;
        public static string response;
        public static void tempapi()
        {
            var request = WebRequest.Create(urlbtn);
            request.Method = "GET";
            try
            {
                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();

                Console.WriteLine(data);
            }
            catch (Exception e)
            {
               response = e.Message;
            }

        }
        public static void Power()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=-2544&keysymbol=-4081";
            tempapi();
        }
        public static void K1()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63004&keysymbol=49";
            tempapi();
        }
        public static void K2()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63005&keysymbol=50";
            tempapi();
        }
        public static void K3()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63006&keysymbol=51";
            tempapi();
        }
        public static void K4()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63007&keysymbol=52";
            tempapi();
        }
        public static void K5()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63008&keysymbol=53";
            tempapi();
        }
        public static void K6()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63009&keysymbol=54";
            tempapi();
        }
        public static void K7()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63010&keysymbol=55";
            tempapi();
        }
        public static void K8()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63011&keysymbol=56";
            tempapi();
        }
        public static void K9()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63012&keysymbol=57";
            tempapi();
        }
        public static void K0()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63003&keysymbol=48";
            tempapi();
        }
        public static void Fav()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63018&keysymbol=61560";
            tempapi();
        }
        public static void Txt()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=keyid=62993&keysymbol=61546";
            tempapi();
        }
        public static void Orta()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63046&keysymbol=13";
            tempapi();

        }
        public static void Sol()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63041&keysymbol=61440";
            tempapi();
        }
        public static void Sag()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63042&keysymbol=61441";
            tempapi();
        }
        public static void Menu()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62989&keysymbol=61458";
            tempapi();
        }
        public static void Exit()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63002&keysymbol=61538";
            tempapi();
        }
        public static void Yukari()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63043&keysymbol=61442";
            tempapi();
        }
        public static void Asagi()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63044&keysymbol=61443";
            tempapi();
        }
        public static void Tools()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63030&keysymbol=61457";
            tempapi();
        }
        public static void Veksi()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63060&keysymbol=61517";
            tempapi();
        }
        public static void Varti()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63061&keysymbol=61516";
            tempapi();
        }
        public static void Peksi()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63071&keysymbol=61511";
            tempapi();
        }
        public static void Parti()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63072&keysymbol=61510";
            tempapi();
        }
        public static void Mute()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62997&keysymbol=61518";
            tempapi();
        }
        public static void Back()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62994&keysymbol=61557";
            tempapi();
        }
        public static void SoruIsaret()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62985&keysymbol=61460";
            tempapi();
        }
        public static void Kirmizi()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63013&keysymbol=61506";
            tempapi();
        }
        public static void Yesil()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63014&keysymbol=61507";
            tempapi();
        }
        public static void Sari()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63015&keysymbol=61508";
            tempapi();
        }
        public static void Mavi()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63016&keysymbol=61509";
            tempapi();
        }
        public static void OncekiVid()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62998&keysymbol=61531";
            tempapi();
        }
        public static void SonrakiVid()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62990&keysymbol=61532";
            tempapi();
        }
        public static void Duraklat()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63056&keysymbol=61450";
            tempapi();
        }
        public static void Oynat()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62988&keysymbol=61521";
            tempapi();
        }
        public static void IleriSar()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62981&keysymbol=61513";
            tempapi();
        }
        public static void GeriSar()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62978&keysymbol=61559";
            tempapi();
        }
        public static void Internet()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63002&keysymbol=61549";
            tempapi();
        }
        public static void Guide()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63000&keysymbol=61467";
            tempapi();
        }
        public static void Source()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62995&keysymbol=61544";
            tempapi();
        }
        public static void Kaydet()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62976&keysymbol=61526";
            tempapi();
        }
        public static void Durdur()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63003&keysymbol=61522";
            tempapi();
        }
        public static void Sub()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=63029&keysymbol=61473";
            tempapi();
        }
        public static void Dub()
        {
            urlbtn = tvip + ":8085/sendrcpackage?keyid=62987&keysymbol=61552";
            tempapi();
        }
    }
}
