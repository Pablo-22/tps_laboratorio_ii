using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using Entities.SystemCore;
using Entities.InputOutput;

namespace Entities.WalletEntities
{
    public class Movement : DataEntity
    {
        private float amount;
        private int idWallet;
        private DateTime purchaseDate;
        private eType type;
        private string category;

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Category
        {
            get { return category; }
            set
            {
                category = setCategory(value);
            }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }


        public int IdWallet
        {
            get { return idWallet; }
            set { idWallet = value; }
        }
        public eType Type
        {
            get { return type; }
            set { type = value; }
        }
        public Movement(float amount, int idWallet, DateTime purchaseDate, eType isExpense, string category) : base()
        {
            this.amount = amount;
            this.idWallet = idWallet;
            this.purchaseDate = purchaseDate;
            this.type = isExpense;
            this.category = category;

        }

        public Movement(float amount, int idWallet, eType type) : this(amount, idWallet, DateTime.Now, type, "Varios")
        { }

        public Movement() : this(0, -1, DateTime.Now, eType.Gasto, "Varios")
        { }

        public enum eType
        {
            Gasto,
            Ingreso
        }


        public override string ToString()
        {
            StringBuilder movementInfo = new StringBuilder();
            movementInfo.Append(this.Id + " - ");
            movementInfo.Append(this.Amount + " - ");
            movementInfo.Append(this.PurchaseDate.ToString("d") + " - ");
            movementInfo.Append("Wallet ID: " + this.idWallet);

            return movementInfo.ToString();
        }

        public string setCategory(string category)
        {
            string categoryToReturn = "Varios";
            if (this.Type == eType.Gasto)
            {
                Bank.ExpensesCategories.ForEach(cat =>
                {
                    if (cat == category)
                    {
                        categoryToReturn = category;
                    }
                });
            }
            else
            {
                Bank.IncomesCategories.ForEach(cat =>
                {
                    if (cat == category)
                    {
                        categoryToReturn = category;
                    }
                });
            }
            return categoryToReturn;
        }
    }
}
