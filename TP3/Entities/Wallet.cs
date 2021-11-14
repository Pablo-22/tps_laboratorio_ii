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

        public float getMonthTotal(DateTime date, Movement.eType type)
        {
            float totalIncomes = 0;

            this.moneyMovements.ForEach(movement =>
            {
                if (movement.Type == type
                    && movement.PurchaseDate.Year == date.Year
                    && movement.PurchaseDate.Month == date.Month)
                {
                    totalIncomes += movement.Amount;
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
        public float CompareDatesAmount(DateTime nowDate, DateTime previousDate, Movement.eType type, out bool nowIsMore)
        {
            float nowDateAmount = getMonthTotal(nowDate, type);
            float previousMonthAmount = getMonthTotal(previousDate, type);
            float percentage = 0;
            nowIsMore = true;

            if (nowDateAmount == 0)
            {
                nowIsMore = false;
                percentage = previousMonthAmount;
            } else if (previousMonthAmount == 0)
            {
                percentage = nowDateAmount;   
            } else if (nowDateAmount > previousMonthAmount )
            {
                percentage = (nowDateAmount * 100) / previousMonthAmount;
            }
            else
            {
                nowIsMore = false;
                percentage = (previousMonthAmount * 100) / nowDateAmount;
            }
            return percentage;
        }

        public float CompareNowWithPreviousMonth(Movement.eType type, out bool nowIsMore)
        {
            nowIsMore = default;
            float percentage = CompareDatesAmount(DateTime.Now, DateTime.Now.AddMonths(-1), type, out nowIsMore);
            return percentage;
        }
    }
}
