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

        public Wallet(float balance) : this(balance, new List<Movement>())
        {
            DbService.InsertWallet(this);
            this.Id = DbService.getBiggestIdWallet();
        }

        public Wallet(float balance, List<Movement> moneyMovements)
        {
            this.balance = balance;
            this.moneyMovements = moneyMovements;
        }

        public Wallet(float balance, List<Movement> moneyMovements, int id) : base(id)
        {
            this.balance = balance;
            this.moneyMovements = moneyMovements;
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

        /// <summary>
        /// Recibe los datos de un movimiento y lo añade a la wallet.
        /// Finalmente ordena los movimientos por fecha.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="movementDate"></param>
        /// <param name="isExpense"></param>
        /// <param name="category"></param>
        public void SaveNewMovement(float amount, DateTime movementDate, Movement.eType isExpense, string category)
        {
            Movement newMovement = new Movement(amount,this.Id, movementDate, isExpense, category);
            this.MoneyMovements.Add(newMovement);
            setBalance(newMovement);
            this.SortMovementsByMoreRecentDate();
        }

        /// <summary>
        /// Recibe un movimiento y lo resta o lo suma al balance según corresponda.
        /// </summary>
        /// <param name="movement"></param>
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

        /// <summary>
        /// Ordena los movimientos por fecha. De más reciente a más antiguo.
        /// </summary>
        public void SortMovementsByMoreRecentDate()
        {
            this.moneyMovements.Sort((movementA, movementB) => movementB.PurchaseDate.CompareTo(movementA.PurchaseDate));
        }

        /// <summary>
        /// Obtiene el monto total de movimientos de una categoría 
        /// en específico en el mes pasado como parámetro.
        /// Pueden ser gastos o ingresos, según el tipo pasado como parámetro.
        /// </summary>
        /// <param name="date"></param> Mes del que se quiere conocer el total
        /// <param name="type"></param> Gasto o ingreso.
        /// <param name="category"></param> Categoría específica a evaluar. Si es null, se considerarán todas las categorías.
        /// <returns>Devuelve la suma del monto de todos los movimientos</returns>
        public float getMonthTotal(DateTime date, Movement.eType type, string category)
        {
            float totalAmount = 0;

            this.moneyMovements.ForEach(movement =>
            {
                if (movement.Type == type
                    && movement.PurchaseDate.Year == date.Year
                    && movement.PurchaseDate.Month == date.Month)
                {
                    if (string.IsNullOrEmpty(category) || movement.Category == category)
                    {
                        totalAmount += movement.Amount;
                    }
                }
            });
            return totalAmount;
        }


        /// <summary>
        /// Compara los gastos o ingresos de dos meses diferentes 
        /// y devuelve el porcentaje de diferencia
        /// y un boolean que determina si el monto de la fecha más antigua
        /// es 0
        /// </summary>
        /// 
        /// <param name="nowDate"></param> Fecha más nueva
        /// <param name="previousDate"></param> Fecha anterior a comparar
        /// <param name="type"></param> Gasto o Ingreso
        /// <param name="initialValueIsNotNull"></param> True si el monto en previousData no es 0. Caso contrario False
        /// <returns>Porcentaje de diferencia entre una fecha y otra.</returns>
        public float CompareDatesAmount(DateTime nowDate, DateTime previousDate, Movement.eType type, string category, out bool initialValueIsNotNull)
        {
            float nowDateAmount = getMonthTotal(nowDate, type, category);
            float previousMonthAmount = getMonthTotal(previousDate, type, category);
            float percentage = 0;

            if (previousMonthAmount > 0)
            {
                initialValueIsNotNull = true;
                percentage = (nowDateAmount - previousMonthAmount) / previousMonthAmount * 100;
            }
            else
            {
                percentage = nowDateAmount;
                initialValueIsNotNull = false;
            }

            return percentage;
        }

        /// <summary>
        /// Compara el total del mes actual con el mes anterior, de la categoría pasada como parámetro.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="category"></param>
        /// <param name="nowIsMore"></param> Indica si el valor actual supera al anterior (true)
        /// <param name="initialValueIsNotNull"></param> Indica que el valor anterior no es 0
        /// <returns></returns>
        public float CompareNowWithPreviousMonth(Movement.eType type, string category, out bool nowIsMore, out bool initialValueIsNotNull)
        {
            nowIsMore = true;
            float percentage = CompareDatesAmount(DateTime.Now, DateTime.Now.AddMonths(-1), type, category, out initialValueIsNotNull);
            if (percentage < 0)
            {
                nowIsMore = false;
                percentage *= -1;
            }
            return percentage;
        }
    }
}
