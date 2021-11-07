using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Entities
{
    [Serializable]
    public class Wallet : DataEntity
    {
        private float balance;
        private List<Movement> moneyMovements;

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

        public bool SaveNewMovement(float amount, DateTime movementDate, Movement.eType isExpense)
        {
            Movement newMovement = new Movement(amount,this.Id, movementDate, isExpense);
            this.MoneyMovements.Add(newMovement);
            setBalance(newMovement);

            return true;
        }

        private void setBalance(Movement movement)
        {
            if (movement.Type == Movement.eType.Gasto)
            {
                if (this.Balance - movement.Amount >= 0)
                {
                    this.Balance -= movement.Amount;
                }
            }
            else
            {
                this.Balance += movement.Amount;
            }
        }
    }
}
