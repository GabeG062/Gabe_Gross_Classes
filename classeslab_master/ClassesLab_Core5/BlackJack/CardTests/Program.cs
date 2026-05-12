using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c1 = new Card(1, 4);
            Card c2 = new Card(2, 3);
            Card c3 = new Card(0, 0);
            TestCardMatcher(c1, c2);
            Console.WriteLine("Card 1 is " + c1);
            Console.WriteLine("Card 2 is " + c2);
            Console.WriteLine("Card 3 is a face card." );
            Console.WriteLine("Checking if card 1 is an Ace: " + c1.IsAce());
            Console.WriteLine("Checking if card 1 is a Club: " + c1.isClub());
            Console.WriteLine("Checking if card 1 is a Diamond: " + c1.isDiamond());
            Console.WriteLine("Checking if card 1 is a Heart: " + c1.isHeart());
            Console.WriteLine("Checking if card 1 is a Spade: " + c1.isSpade());
            Console.WriteLine("Checking if card 1 is Red: " + c1.isRed());
            Console.WriteLine("Checking if card 1 is Black: " + c1.isBlack());
            Console.WriteLine("Checking if card 1 is a Face Card: " + c1.isFaceCard());
            Console.WriteLine("Checking if card 2 is an Ace: " + c2.IsAce());
            Console.WriteLine("Checking if card 2 is a Club: " + c2.isClub());
            Console.WriteLine("Checking if card 2 is a Diamond: " + c2.isDiamond());
            Console.WriteLine("Checking if card 2 is a Heart: " + c2.isHeart());
            Console.WriteLine("Checking if card 2 is a Spade: " + c2.isSpade());
            Console.WriteLine("Checking if card 2 is Red: " + c2.isRed());
            Console.WriteLine("Checking if card 2 is Black: " + c2.isBlack());
            Console.WriteLine("Checking if card 2 is a Face Card: " + c2.isFaceCard());
            Console.WriteLine("Checking if card 3 is a Face Card: " + c3.isFaceCard());
        }

        static void TestCardMatcher(Card current, Card next)
        {
            Console.WriteLine($"testing if {current} matches {next} in value. " + current.HasMatchingValue(next));
            Console.WriteLine($"testing if {current} matches {next} in suit. " + current.HasMatchingSuit(next));
        }
    }
}
