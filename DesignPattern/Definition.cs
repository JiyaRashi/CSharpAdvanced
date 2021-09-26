using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpAdvanced.DesignPattern.FactoryClass;

namespace CSharpAdvanced.DesignPattern
{
    class Definition
    {
    }


    public class MoneyBackFactory: CreditcardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new MoneyBack();
            return creditCard;
        }
    }

    public class TitaniumFactory : CreditcardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Titanium();
            return creditCard;
        }
    }

    public class PlatinumFactory : CreditcardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new Platinum();
            return creditCard;
        }
    }
    class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }

    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 25000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }

    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        public int GetCreditLimit()
        {
            return 35000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}
