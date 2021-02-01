using System;
using System.Threading.Tasks;

namespace fake_hacked
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "CART APP HACKED"; Console.ForegroundColor = ConsoleColor.Green;//isim yazı rengi

            Console.WriteLine("\n Hacked'a hoşgeldiniz sanal dünyaya girmek ve karanlık ağada en iyisi olmak ister misin?\n Eğer istersen 'evet' yazınız  console ekrınıda 'help' yazarak komutlara ulaş\n İstemezsen hayır yazını.");
            string karar; karar=Convert.ToString( karar=Console.ReadLine());//Bilgilendirme ve kullanıcıdan veri isteme
            /*--------------------------------Devam Kararı Verme--------------------------------------------------*/
            if (karar =="evet")
            {
                Console.WriteLine("Güzel doğuştan bir hackersın.");
                int oppen=0;
                /*--------------------------------Ort Kayan Yaz--------------------------------------------------*/
                for (int i = 0; i <30; i++)
                {
                        Console.WriteLine("HACKED AÇILIYOR");
                }

                /*--------------------------------Devam Kararı Verme--------------------------------------------------*/

                /*--------------------------------Art text görünümü ve girdisi--------------------------------------------------*/

                Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
                string title = @"
 ██████╗ █████╗ ██████╗ ████████╗     █████╗ ██████╗ ██████╗     ██╗  ██╗ █████╗  ██████╗██╗  ██╗███████╗██████╗ 
██╔════╝██╔══██╗██╔══██╗╚══██╔══╝    ██╔══██╗██╔══██╗██╔══██╗    ██║  ██║██╔══██╗██╔════╝██║ ██╔╝██╔════╝██╔══██╗
██║     ███████║██████╔╝   ██║       ███████║██████╔╝██████╔╝    ███████║███████║██║     █████╔╝ █████╗  ██║  ██║
██║     ██╔══██║██╔══██╗   ██║       ██╔══██║██╔═══╝ ██╔═══╝     ██╔══██║██╔══██║██║     ██╔═██╗ ██╔══╝  ██║  ██║
╚██████╗██║  ██║██║  ██║   ██║       ██║  ██║██║     ██║         ██║  ██║██║  ██║╚██████╗██║  ██╗███████╗██████╔╝
 ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚═╝  ╚═╝╚═╝     ╚═╝         ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝ 
                                                                                                                                           
                                                                 ";Console.WriteLine(title);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("");Console.Write(""); //Sonra silin UNUTMA

                /*--------------------------------Art text görünüm bitiş--------------------------------------------------*/
                /*--------------------------------HAck komut isteme--------------------------------------------------*/
                Console.WriteLine("Komutları görmek isterseniz 'command' yazınız.");
                string hacked; hacked = Convert.ToString(Console.ReadLine());
                if (hacked== "command")
                {
                    Console.WriteLine("\n 1-İNDEX ÇALICI\n 2-DDOS ATIM\n 3-İP BULUCU\n 4-AKLIMA GELMEYEN HACK OLAYLARI VS :-) ");
                    
                }
                else
                {
                    Console.WriteLine("Yanlış yazdın sanırım reis");
                    
                }
                /*--------------------------------HAck Komut İsteme bitiş--------------------------------------------------*/

                /*--------------------------------Devam Kararı Verme--------------------------------------------------*/
            }
            else 
            {
                Console.WriteLine("Seni cesur sanmıştım...."); Console.ReadKey();

            }
			Console.ReadKey();
        }
    }
}
