using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Wallet : DataEntity
    {
        private float balance;
        private List<Movement> moneyMovements;
        private int idOwner;

        public Wallet() : this(0)
        { }

        public Wallet(float balance)
        {
            moneyMovements = new List<Movement>();
            this.balance = balance;
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<Movement> MoneyMovements
        {
            get { return moneyMovements; }
            set { moneyMovements = value; }
        }
    }
}
