using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    //--Author's name:Wen Xu
    //--Author’s student number:301098127,
    //--Date last Modified:16,July,2020,
    //--Program description:1.0.0 version is to randomly picks lottery numbers from 649 lotto and Max lotto.
    //The program has four classes and one interfaces.The output should display 6 tickets with 6 non-repeat random numbers
    // if user chooses 649 lotto or 7 tickets with 7 non-repeat random number if user chooses Max Lotto. 
    //--Revision History:1.0.0

    /**
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     */
    public class Program
    {
        // Instantiate lotto649 object
        static Lotto649 lotto649 = new Lotto649();
        // Instantiate lottoMax object
        static LottoMax lottoMax = new LottoMax();

        /**
         * @static
         * @method Main
         * @returns {void}
         */
        public static void Main(string[] args)
        {     
            // Call the Menu
            LottoMenu();
        }

        /**
         * <summary>
         * This utility method creates a console menu that allows the user to choose
         * a Lotto game to execute.
         * </summary>
         * 
         * @static
         * @method LottoMenu
         * @returns {void}
         */
        public static void LottoMenu()
        {
            // declare a variable to record if menu is active
            bool menuActive = true;

            // While the menu is active...loop
            while(menuActive)
            {
                // show options in the console menu
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine(" Please make your selection");
                Console.WriteLine(" 1. Lotto 6/49");
                Console.WriteLine(" 2. Lotto Max");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key - Select Lotto 6 / 49
                        Console.Clear();
                        Console.WriteLine("+ Lotto 6/49 +++++++++++++++++++");
                        lotto649.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key - Select Lotto Max
                        Console.Clear();
                        Console.WriteLine("+ Lotto MAX ++++++++++++++++++++");
                        lottoMax.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3: // The "3" Key - Exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }         
        }
    }
}
