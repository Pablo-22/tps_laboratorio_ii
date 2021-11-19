using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using System.Xml;
using Entities.SystemCore;
using Entities.InputOutput;

namespace Entities.WalletEntities
{    public class Wallet : DataEntity
    {
        private float balance;
        private List<Movement> moneyMovements;

        public Wallet() : base()
        {
            this.balance = 0;
        }

        public Wallet(float balance) : this(0, new List<Movement>())
        {
            this.balance = balance;
        }

        public Wallet(float balance, List<Movement> moneyMovements) : base()
        {
            this.balance = balance;
            this.moneyMovements = moneyMovements;
        }

        public Wallet(float balance, List<Movement> moneyMovements, int id) : base(id)
        {
            this.balance = balance;
            this.moneyMovements = moneyMovements;
        }

        public Wallet(int id, float balance) : base(id)
        {
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

        public bool SaveNewMovement(float amount, DateTime movementDate, Movement.eType isExpense, string category)
        {
            Movement newMovement = new Movement(amount,this.Id, movementDate, isExpense, category);
            this.MoneyMovements.Add(newMovement);
            setBalance(newMovement);
            this.SortMovementsByMoreRecentDate();

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

        public void SortMovementsByMoreRecentDate()
        {
            this.moneyMovements.Sort((movementA, movementB) => movementB.PurchaseDate.CompareTo(movementA.PurchaseDate));
        }

        public float getMonthTotal(DateTime date, Movement.eType type, string category)
        {
            float totalIncomes = 0;

            this.moneyMovements.ForEach(movement =>
            {
                if (movement.Type == type
                    && movement.PurchaseDate.Year == date.Year
                    && movement.PurchaseDate.Month == date.Month)
                {
                    if (string.IsNullOrEmpty(category) || movement.Category == category)
                    {
                        totalIncomes += movement.Amount;
                    }
                }
            });
            return totalIncomes;
        }


        /// <summary>
        /// Compara los gastos o ingresos de dos meses diferentes 
        /// y devuelve el porcentaje de diferencia
        /// y un boolean que determina si el monto de la fecha 
        /// actual fue mayor o menor al previo.
        /// </summary>
        /// 
        /// <param name="nowDate"></param> Fecha más nueva
        /// <param name="previousDate"></param> Fecha anterior a comparar
        /// <param name="type"></param> Gasto o Ingreso
        /// <param name="nowIsMore"></param> True si el monto en actualDate es mayor a previousDate. Caso contrario False
        /// <returns>Porcentaje de diferencia entre una fecha y otra.</returns>
        public float CompareDatesAmount(DateTime nowDate, DateTime previousDate, Movement.eType type, string category, out bool initialValueIsNull)
        {
            float nowDateAmount = getMonthTotal(nowDate, type, category);
            float previousMonthAmount = getMonthTotal(previousDate, type, category);
            float percentage = 0;

            if (previousMonthAmount > 0)
            {
                initialValueIsNull = true;
                percentage = (nowDateAmount - previousMonthAmount) / previousMonthAmount * 100;
            }
            else
            {
                percentage = nowDateAmount;
                initialValueIsNull = false;
            }

            return percentage;
        }

        public float CompareNowWithPreviousMonth(Movement.eType type, string category, out bool nowIsMore, out bool initialValueIsNull)
        {
            nowIsMore = true;
            float percentage = CompareDatesAmount(DateTime.Now, DateTime.Now.AddMonths(-1), type, category, out initialValueIsNull);
            if (percentage < 0)
            {
                nowIsMore = false;
                percentage *= -1;
            }
            return percentage;
        }
    }
}
