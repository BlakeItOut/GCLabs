using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab28Framework.Models
{

    public class Draw
    {
        public bool Success { get; set; }
        public Card[] Cards { get; set; }
        public string Deck_id { get; set; }
        public int Remaining { get; set; }
    }

    public class Card : IComparable<Card>
    {
        public string Image { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
        public Images Images { get; set; }
        public string Code { get; set; }

        public int CompareTo(Card other)
        {
            if (!int.TryParse(other.Value, out int otherNumber))
            {
                switch (other.Value)
                {
                    case "JACK":
                        otherNumber = 11;
                        break;
                    case "QUEEN":
                        otherNumber = 12;
                        break;
                    case "KING":
                        otherNumber = 13;
                        break;
                    case "ACE":
                        otherNumber = 14;
                        break;
                    default:
                        break;
                }
            }
            if (!int.TryParse(this.Value, out int thisNumber))
            {
                switch (this.Value)
                {
                    case "JACK":
                        thisNumber = 11;
                        break;
                    case "QUEEN":
                        thisNumber = 12;
                        break;
                    case "KING":
                        thisNumber = 13;
                        break;
                    case "ACE":
                        thisNumber = 14;
                        break;
                    default:
                        break;
                }
            }

            return thisNumber.CompareTo(otherNumber);
            
        }
    }

    public class Images
    {
        public string Svg { get; set; }
        public string Png { get; set; }
    }
}