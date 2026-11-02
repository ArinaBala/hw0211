using System;
using System.Collections.Generic;
using System.Text;

namespace hw0211
{
    public class Player
    {
        public string FullName 
        {
            get;
            set; 
        }
        public int TShirtNumber 
        {
            get;
            set; 
        }
        public string RoleOnField 
        {
            get;
            set;
        }

        public Player(string fullName, int tShirtNumber, string roleOnField)
        {
            FullName = fullName;
            TShirtNumber = tShirtNumber;
            RoleOnField = roleOnField;
        }

        public void PrintPlayerCard()
        {
            Console.WriteLine($"Игрок №{TShirtNumber} {FullName} — {RoleOnField}");
        }
    }
}
