using System;

namespace DataTypesPt2Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class Methods
    {
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            var ageAt=0;
           
            if (birthDate > date)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            else
            {
                var dateDiff = date - birthDate;
                 ageAt = (int)(dateDiff.Days / 365.25);
            }            
            return ageAt;
        }

        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }


        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        public static string Fortune(Suit suit)
        {
            string message = "";

            switch (suit)
            {
                case Suit.HEARTS:
                    message = "You've broken my heart";
                    break;
                case Suit.CLUBS:
                    message = "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.DIAMONDS:
                    message = "Diamonds are a girls best friend";
                    break;
                case Suit.SPADES:
                    message = "Bucket and spade";
                    break;
            }
            return message;           
        }
    }
}
    