namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for, while, do while
            #region for Fizz Buzz
            /*
             * FizzBuzz o'yini:
                1 dan 100 gacha bo'lgan sonlar ketma-ketligini chiqaring. 
            Agar son 3 ga, 5 ga yoki 3 va 5 ga ham bo'lsa, u o'rniga "Fizz", "Buzz" yoki "FizzBuzz" deb yozing.
             */
            /*
            Console.WriteLine("FizzBuzz o'yini.\n Boshlandi...");

            for(int i=1; i<=100; i++)
            {
                if(i%3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{i} - FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i} - Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i} - Buzz");
                }

            }
            Console.ResetColor();

            Console.WriteLine("Dastur tugadi.");

            */
            #endregion 

            #region while Fibonachi sonlar
            /*
             * Fibonachchi ketma-ketligi:*/
            // dastlabki n ta fibonachi sonni topish
            /*
            Console.Write("Son kiriting:");
            int n = int.Parse(Console.ReadLine());
            
            int birinchiSon=0, ikkinchiSon=1, keyingiSon;
            Console.WriteLine($"{birinchiSon}\n{ikkinchiSon}");
            int i = 2;
            while (i <= n)
            {
                keyingiSon = birinchiSon + ikkinchiSon;
                Console.WriteLine(keyingiSon);
                birinchiSon = ikkinchiSon;
                ikkinchiSon = keyingiSon;
                i++;   
            }
            */

            #endregion

            #region do while Uylangan sonni topish
            //Kompyuter uylagan sonni topish necha marta uringanini ham
            /*
            Console.WriteLine("==========Kompyuter uylagan sonni topish uyini==========");
            Random rd = new Random();
            int randomNumber = rd.Next(1,100);
            //Console.WriteLine(randomNumber); cheating😂
            int userNumber, counter=0;
            do
            {
                counter++;
                Console.Write("Son kiriting:");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber == randomNumber)
                {
                    Console.WriteLine($"Tasodifiy son topildi {randomNumber}!!!");
                    break;
                }
                else if(userNumber > randomNumber)
                {
                    Console.WriteLine("Qayta Kichikroq son kiriting!!!");
                }
                else
                {
                    Console.WriteLine("Qayta Kattaroq son kiriting!!!");
                }

            } while(true);

            if(counter <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ajoyib natija Siz {counter} marta urinishda Tasodifiy sonni topdingiz.");
            }
            else if(counter > 3 && counter <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Yaxshi natija Siz {counter} marta urinishda Tasodifiy sonni topdingiz.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Yomon natija Siz {counter} marta urinishda Tasodifiy sonni topdingiz.");
            }

            Console.ResetColor();
            */

            #endregion 
        }
    }
}
