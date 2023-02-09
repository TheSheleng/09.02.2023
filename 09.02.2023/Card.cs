using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02._2023
{
    internal class Card
    {
        int id;
        string bio;
        int cvc;
        DateTime date;
        public int CardId { get => id; }
        public string BIO { get => bio; }
        public int CVC { get => cvc; }
        public DateTime Date { get => date; }
        public void Input()
        {
            string buffer;

            Console.Write("Card id: ");
            buffer = Console.ReadLine();
            if (buffer.Length != 16) throw new Exception("Id must be 16 digits.");
            id = Convert.ToInt32(buffer);

            Console.Write("BIO: ");
            buffer = Console.ReadLine();
            if (buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length != 3)
                throw new Exception("You must enter your first name, last name and patronymic");
            bio = buffer;

            Console.Write("CVC: ");
            buffer = Console.ReadLine();
            if (buffer.Length != 3) throw new Exception("CVC must be three digits.");
            cvc = Convert.ToInt32(buffer);

            Console.Write("Date: ");
            buffer = Console.ReadLine();
            date = Convert.ToDateTime(buffer);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Card Id: {CardId}");
            sb.Append($"BIOL: {BIO}");
            sb.Append($"CVC: {CVC}");
            sb.Append($"Date: {Date.Month}/{Date.Year}");
            
            return sb.ToString();
        }
    }
}
