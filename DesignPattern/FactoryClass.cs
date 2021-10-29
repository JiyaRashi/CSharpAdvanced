using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern
{
     public class FactoryClass
    {

        // Factory Design Pattern
        public static ICreditCard GetCreditCard (string cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            return cardDetails;
        }

        // Factory Method Design Pattern

        public abstract class CreditcardFactory
        {
            protected abstract ICreditCard MakeProduct();

            public ICreditCard CreditCard()
            {
                return this.MakeProduct();
            }
        }

        public interface ICreditCard
        {
            string GetCardType();
            int GetCreditLimit();
            int GetAnnualCharge();
        }
    }
}
