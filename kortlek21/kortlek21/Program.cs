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
                           new Card(){ number = 1, colour = "Ace of hearts" },
                           new Card(){ number = 2, colour = "Two of hearts" },
                           new Card(){ number = 3, colour = "Three of hearts" },
                           new Card(){ number = 4, colour = "Four of hearts" },
                           new Card(){ number = 5, colour = "Five of hearts" },
                           new Card(){ number = 6, colour = "Six of hearts" },
                           new Card(){ number = 7, colour = "Seven of hearts" },
                           new Card(){ number = 8, colour = "Eight of hearts" },
                           new Card(){ number = 9, colour = "Nive of hearts" },
                           new Card(){ number = 10, colour = "Ten of hearts" },
                           new Card(){ number = 10, colour = "Knight of hearts" },
                           new Card(){ number = 10, colour = "Queen of hearts" },
                           new Card(){ number = 10, colour = "King of hearts" },
                           new Card(){ number = 1, colour = "Ace of Spades" },
                           new Card(){ number = 2, colour = "Two of Spades" },
                           new Card(){ number = 3, colour = "Three of Spades" },
                           new Card(){ number = 4, colour = "Four of Spades" },
                           new Card(){ number = 5, colour = "Five of Spades" },
                           new Card(){ number = 6, colour = "Six of Spades" },
                           new Card(){ number = 7, colour = "Seven of Spades" },
                           new Card(){ number = 8, colour = "Eight of Spades" },
                           new Card(){ number = 9, colour = "Nine of Spades" },
                           new Card(){ number = 10, colour = "Ten of Spades" },
                           new Card(){ number = 10, colour = "Knigt of Spades" },
                           new Card(){ number = 10, colour = "Queen of Spades" },
                           new Card(){ number = 10, colour = "King of Spades" },
                           new Card(){ number = 1, colour = "Ace of diamonds" },
                           new Card(){ number = 2, colour = "Two of diamonds" },
                           new Card(){ number = 3, colour = "Three of diamonds" },
                           new Card(){ number = 4, colour = "Four of diamonds" },
                           new Card(){ number = 5, colour = "Five of diamonds" },
                           new Card(){ number = 6, colour = "Six of diamonds" },
                           new Card(){ number = 7, colour = "Seven of diamonds" },
                           new Card(){ number = 8, colour = "Eight of diamonds" },
                           new Card(){ number = 9, colour = "Nine of diamonds" },
                           new Card(){ number = 10, colour = "Ten of diamonds" },
                           new Card(){ number = 10, colour = "Knight of diamonds" },
                           new Card(){ number = 10, colour = "Queen of diamonds" },
                           new Card(){ number = 10, colour = "King of diamonds" },
                           new Card(){ number = 1, colour = "Ace of clubs" },
                           new Card(){ number = 2, colour = "Two of clubs" },
                           new Card(){ number = 3, colour = "Three of clubs" },
                           new Card(){ number = 4, colour = "Four of clubs" },
                           new Card(){ number = 5, colour = "Five of clubs" },
                           new Card(){ number = 6, colour = "Six of clubs" },
                           new Card(){ number = 7, colour = "Seven of clubs" },
                           new Card(){ number = 8, colour = "Eight of clubs" },
                           new Card(){ number = 9, colour = "Nine of clubs" },
                           new Card(){ number = 10, colour = "Ten of clubs" },
                           new Card(){ number = 10, colour = "Knight of clubs" },
                           new Card(){ number = 10, colour = "Thot of clubs" },
                           new Card(){ number = 10, colour = "King of clubs" },

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
                                            Console.WriteLine("\nCONGRATZ YOU GOT 21\nYOU WON\nClaim your starfighter ...(=0=)...");
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
