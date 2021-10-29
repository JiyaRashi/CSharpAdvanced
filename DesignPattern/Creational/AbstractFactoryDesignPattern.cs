using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern
{
     public class AbstractFactoryDesignPattern
    {
        public void AbsFactoryPattern()
        {
            CreditcardFactory creditCardfactory = CreditcardFactory.CreditCard("Visa");
            ICreditCard creditCard = creditCardfactory.MakeProduct("IOB");
            ICreditCard creditCard_1 = creditCardfactory.MakeProduct("HSBC");
            Console.WriteLine($"======================{creditCard_1.GetName()}");
        }
    }


    public interface ICreditCard
    {
        string GetName();
    }

    public abstract class CreditcardFactory
    {
        public abstract ICreditCard MakeProduct(string Type);

        public static CreditcardFactory CreditCard(string Type)
        {
            if (Type == "Visa")
                return new VisaFactory();
            else if (Type == "Master")
                return new MasterFactory();
            else
                return null;

        }
    }


    public class VisaFactory : CreditcardFactory
    {
        public override ICreditCard MakeProduct(string Type)
        {
            ICreditCard creditCard = null;
            if (Type == "IOB")
                creditCard = new IobCreditCard();
            if (Type == "Punjab")
                creditCard = new PunjabCreditCard();
            if (Type == "HSBC")
                creditCard = new HSBCCreditCard();
            return creditCard;
        }
    }

    public class MasterFactory : CreditcardFactory
    {
        public override ICreditCard MakeProduct(string Type)
        {
            ICreditCard creditCard = null;
            if (Type == "ICICI")
                creditCard = new ICICICreditCard();
            if (Type == "SBI")
                creditCard = new SBICreditCard();
            return creditCard;
        }
    }
    public class PunjabCreditCard : ICreditCard
    {
        public string GetName()
        {
            return "PunjabCreditCard";
        }
    }

    public class IobCreditCard : ICreditCard
    {
        public string GetName()
        {
            return "IobCreditCard";
        }
    }

    public class ICICICreditCard : ICreditCard
    {
        public string GetName()
        {
            return "ICICICreditCard";
        }
    }

    public class SBICreditCard : ICreditCard
    {
        public string GetName()
        {
            return "SBICreditCard";
        }
    }

    public class HSBCCreditCard : ICreditCard
    {
        public string GetName()
        {
            return "HSBCCreditCard";
        }
    }
}
