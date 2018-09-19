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
                        Console.WriteLine("\nWould you like a card?\nYes  /  NO \n");
                        String answer = Console.ReadLine();
                        String answerLow = answer.ToLower();

                        if(answerLow == "yes")
                        {

                            //Shuffles the list.

                            RNGCryptoServiceProvider providerTwo = new RNGCryptoServiceProvider();
                            int m = cardDeck.Count;
                            while (m > 1)
                            {
                                byte[] box = new byte[1];
                                do providerTwo.GetBytes(box);
                                while (!(box[0] < m * (Byte.MaxValue / m)));
                                int k = (box[0] % m);
                                m--;
                                Card value = cardDeck[k];
                                cardDeck[k] = cardDeck[m];
                                cardDeck[m] = value;
                            }

                            

                            Console.WriteLine("You pulled {0} and your score is {1}\n" ,cardDeck[0].colour, cardDeck[0].number);


                        }
                        else if(answerLow == "no")
                        {
                            Console.WriteLine("\nOkay");
                        }
                        else
                        {
                            Console.WriteLine("\nCan not compute\n Please try again\n");
                        }




                        start = 1;
                        break;

                    case 'c':

                        //gör en for sats som gör så att man kan dra kort om och om eller en while sats
                        Console.WriteLine("\nWelcome to BlackJack ala Drohan\nStart playing\n YES  /  NO \n");
                        String answerTwo = Console.ReadLine();
                        String answerTwoLow = answerTwo.ToLower();

                        if (answerTwoLow == "yes")
                        {
                            //shuffle list (cardDeck)
                            RNGCryptoServiceProvider providerTwo = new RNGCryptoServiceProvider();
                            int v = cardDeck.Count;
                            while (v > 1)
                                {
                                    byte[] box = new byte[1];
                                    do providerTwo.GetBytes(box);
                                    while (!(box[0] < v * (Byte.MaxValue / v)));
                                    int k = (box[0] % v);
                                    v--;
                                    Card value = cardDeck[k];
                                    cardDeck[k] = cardDeck[v];
                                    cardDeck[v] = value;
                                }

                            Console.WriteLine("\nDraw a card?\n YES  /  NO\n");
                            String answerThree = Console.ReadLine();
                            String answerThreeLow = answerTwo.ToLower();
                            int points = 0;
                            int i = 0;

                            if (answerThreeLow == "yes")
                                {
                                    //int count = 1;

                                    while(points < 21)
                                    {

                                   
                                        points = points + cardDeck[i].number;
                                    
                                        Console.WriteLine("\nYou pulled {0} your current score is {1}", cardDeck[i].colour, points);                                       
                                        Console.WriteLine("Draw again?\n YES  /  NO\n");                                                                                         

                                        String answerFour = Console.ReadLine();
                                        String answerFourLow = answerFour.ToLower();
                                        i++;   



                                        if (answerFourLow == "yes")
                                        {
                                            //count = 1;
                                        }
                                        else if (answerFourLow == "no")
                                        {
                                            Console.WriteLine("\nThanks for playing\n");
                                        //count = 0;
                                        break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nSorry can not compute\n");
                                        //count = 0;
                                        break;
                                        }

                                        if (points > 21)
                                        {
                                            Console.WriteLine("\nBad luck you got {0} better luck next time\n", points);
                                        //count = 0;
                                        break;
                                        }
                                        else if (points < 21)
                                        {
                                            //count = 1;
                                        }
                                        else if (points == 21)
                                        {
                                            Console.WriteLine("\nCONGRATZ YOU GOT 21\nYOU WON\nClaim your starfighter (=0=)");
                                        //count = 1;
                                        break;
                                        }

                                    }

                                

                                }
                        }

                        else if (answerTwoLow == "no")
                        {
                            Console.WriteLine("\nOkay");
                        }

                        else
                        {
                            Console.WriteLine("\nCan not compute\nPlease try again\n");
                        }

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

    // decide what a card should contain.
    public class Card
    {
        public int number { get; set; }
        public string colour { get; set; }

    }


}
