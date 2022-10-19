using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17._6._4
{
    public class Caclulator : CalculateInterestBank
    {
        public void CalculateInterest(Account account)
        {

            Console.WriteLine($"расчет для процентной стави для аккаунтов{account.Name} равен {account.Interest}");
          
        }

    }
}
