using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern.FactoryDesignPattern
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetAnnualCharge();
        int GetCreditLimit();
    }
    class FactoryDesignPattern
    {
        public void FDPattern()
        {
            //Type 1
            ICreditCard CreditCardDeatils = new TitanumFactory().CreditCard();
            Console.WriteLine($"Type 1---------------{CreditCardDeatils.GetCardType()}");
            Console.WriteLine($"Type 1---------------{CreditCardDeatils.GetAnnualCharge()}");
            Console.WriteLine($"Type 1---------------{CreditCardDeatils.GetCreditLimit()}");
            Console.WriteLine("-------------------------------------------------------------------------");

            //Type 2
            ICreditCard CardDeatils = FactoryCalss.GetCreditCard("MoneyBack");
            Console.WriteLine($"Type 2---------------{CardDeatils.GetCardType()}");
            Console.WriteLine($"Type 2---------------{CardDeatils.GetAnnualCharge()}");
            Console.WriteLine($"Type 2---------------{CardDeatils.GetCreditLimit()}");

        }

    }

    public class FactoryCalss
    {
        public static ICreditCard GetCreditCard(string type)
        {
             ICreditCard creditCard = null;
            if(type =="MoneyBack")
            {
               creditCard = new MoneyBack();
            }
            if (type == "Titanium")
            {
                creditCard = new Titanium();
            }

            return creditCard;
        }
    }
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreditCard()
        {
            return this.MakeProduct();
        }
    }

    public abstract class AbstractCreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreditCard(string type)
        {
            return this.MakeProduct();
        }
    }

    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditcard = new MoneyBack();
            return creditcard;
        }
    }

    public class TitanumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditcard = new Titanium();
            return creditcard;
        }
    }

    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Moenyback";
        }

        public int GetCreditLimit()
        {
            return 40000;
        }
    }

    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 90000;
        }
    }
}
