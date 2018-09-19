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


                        Console.WriteLine("\nHere is your deck in a random order\n");

                        //Creates a Deck of cards.

                        IList<Card> cardDeck = new List<Card>()
                        {
                           new Card(){ number = 1, colour = "H_A" },
                           new Card(){ number = 2, colour = "H_2" },
                           new Card(){ number = 3, colour = "H_3" },
                           new Card(){ number = 4, colour = "H_4" },
                           new Card(){ number = 5, colour = "H_5" },
                           new Card(){ number = 6, colour = "H_6" },
                           new Card(){ number = 7, colour = "H_7" },
                           new Card(){ number = 8, colour = "H_8" },
                           new Card(){ number = 9, colour = "H_9" },
                           new Card(){ number = 10, colour = "H_10" },
                           new Card(){ number = 11, colour = "H_J" },
                           new Card(){ number = 12, colour = "H_Q" },
                           new Card(){ number = 13, colour = "H_K" },
                           new Card(){ number = 1, colour = "S_A" },
                           new Card(){ number = 2, colour = "S_2" },
                           new Card(){ number = 3, colour = "S_3" },
                           new Card(){ number = 4, colour = "S_4" },
                           new Card(){ number = 5, colour = "S_5" },
                           new Card(){ number = 6, colour = "S_6" },
                           new Card(){ number = 7, colour = "S_7" },
                           new Card(){ number = 8, colour = "S_8" },
                           new Card(){ number = 9, colour = "S_9" },
                           new Card(){ number = 10, colour = "S_10" },
                           new Card(){ number = 11, colour = "S_J" },
                           new Card(){ number = 12, colour = "S_Q" },
                           new Card(){ number = 13, colour = "S_K" },
                           new Card(){ number = 1, colour = "D_A" },
                           new Card(){ number = 2, colour = "D_2" },
                           new Card(){ number = 3, colour = "D_3" },
                           new Card(){ number = 4, colour = "D_4" },
                           new Card(){ number = 5, colour = "D_5" },
                           new Card(){ number = 6, colour = "D_6" },
                           new Card(){ number = 7, colour = "D_7" },
                           new Card(){ number = 8, colour = "D_8" },
                           new Card(){ number = 9, colour = "D_9" },
                           new Card(){ number = 10, colour = "D_10" },
                           new Card(){ number = 11, colour = "D_J" },
                           new Card(){ number = 12, colour = "D_Q" },
                           new Card(){ number = 13, colour = "D_K" },
                           new Card(){ number = 1, colour = "C_A" },
                           new Card(){ number = 2, colour = "C_2" },
                           new Card(){ number = 3, colour = "C_3" },
                           new Card(){ number = 4, colour = "C_4" },
                           new Card(){ number = 5, colour = "C_5" },
                           new Card(){ number = 6, colour = "C_6" },
                           new Card(){ number = 7, colour = "C_7" },
                           new Card(){ number = 8, colour = "C_8" },
                           new Card(){ number = 9, colour = "C_9" },
                           new Card(){ number = 10, colour = "C_10" },
                           new Card(){ number = 11, colour = "C_J" },
                           new Card(){ number = 12, colour = "C_Q" },
                           new Card(){ number = 13, colour = "C_K" },

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
                                Card value = cardDeck[k];
                                cardDeck[k] = cardDeck[n];
                                cardDeck[n] = value;
                            }

                        //Prints out the carddeck.

                        foreach(var card in cardDeck)
                        {
                            
                            Console.WriteLine(card.colour);
                        
                        }




                        start = 1;
                        break;

                    case 'b':
                        // note to future johan
                        //create a dictonary to assign vaules to the list 
                        //split korten, [s_5] = [s_/5] , ge sedan 5 = int 5.
                        // något åt det hållet, from johan in da past






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
    public class Card
    {
        public int number { get; set; }
        public string colour { get; set; }

    }


}
