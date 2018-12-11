using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drills
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            Cards cardOne = new Cards();
            cardOne.Face = "two";
            cardOne.Suit = "hearts";
            Cards.Add(cardOne);


        }
        public List<Card> Cards { get; set; }
    }
}
