using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace kortlek21
{
    class Program
    {

        static void Main(string[] args)
        {
           
            int start = 1;
            do
            {

                //Switch case meny.

                char ch;
                Console.WriteLine("\nSelect a Program \n A , B , C \nPress Q then enter to exit");
                ch = Convert.ToChar(Console.ReadLine());

                switch (char.ToLower(ch))
                {
                    case 'a':

                        //Creates a Deck of cards.

                        List<string> cardDeck = new List<string>
                        {
                            "[S_A]",
                            "[S_2]",
                            "[S_3]",
                            "[S_4]",
                            "[S_5]",
                            "[S_6]",
                            "[S_7]",
                            "[S_8]",
                            "[S_9]",
                            "[S_10]",
                            "[S_J]",
                            "[S_Q]",
                            "[S_K]",
                            "[H_A]",
                            "[H_2]",
                            "[H_3]",
                            "[H_4]",
                            "[H_5]",
                            "[H_6]",
                            "[H_7]",
                            "[H_8]",
                            "[H_9]",
                            "[H_10]",
                            "[H_J]",
                            "[H_Q]",
                            "[H_K]",
                            "[C_A]",
                            "[C_2]",
                            "[C_3]",
                            "[C_4]",
                            "[C_5]",
                            "[C_6]",
                            "[C_7]",
                            "[C_8]",
                            "[C_9]",
                            "[C_10]",
                            "[C_J]",
                            "[C_Q]",
                            "[C_K]",
                            "[D_A]",
                            "[D_2]",
                            "[D_3]",
                            "[D_4]",
                            "[D_5]",
                            "[D_6]",
                            "[D_7]",
                            "[D_8]",
                            "[D_9]",
                            "[D_10]",
                            "[D_J]",
                            "[D_Q]",
                            "[D_K]"
                        };


                        //Shuffles the list.
                        
                        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                        int n = cardDeck.Count;
                        while (n > 1)
                        {
                            byte[] box = new byte[1];
                            do provider.GetBytes(box);
                            while (!(box[0] < n * (Byte.MaxValue / n)));
                            int k = (box[0] % n);
                            n--;
                            String value = cardDeck[k];
                            cardDeck[k] = cardDeck[n];
                            cardDeck[n] = value;
                        }
                        //Prints out the carddeck.

                        foreach(var card in cardDeck)
                        {
                            
                            Console.WriteLine(card);
                        
                        }




                        start = 1;
                        break;

                    case 'b':

                        start = 1;
                        break;

                    case 'c':


                        start = 1;
                        break;

                    case 'q':
                        start = 0;
                        break;

                    default:
                        Console.WriteLine("\nTry again\n");
                        start = 1;
                        break;

                }

            }
            while (start != 0);

        }
    }
}
