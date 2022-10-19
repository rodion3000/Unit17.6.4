using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit17._6._4
{
    public class Account
    {
        public Account(string name, string type, double balance)
        {
            Name = name;
            Type = type;
            Balance = balance;
           
           
        }
        public string Name { get; set; }
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }
       
        // процентная ставка
        public double Interest { get; set; }
        


    }
}
