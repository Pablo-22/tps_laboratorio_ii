using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Movement : DataEntity
    {
        private float amount;
        private int idWallet;
        private DateTime purchaseDate;
        private eType type;

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
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
        public Movement(float amount, int idWallet, DateTime purchaseDate, eType isExpense) : base()
        {
            this.amount = amount;
            this.idWallet = idWallet;
            this.purchaseDate = purchaseDate;
            this.type = isExpense;

        }

        public Movement(float amount, int idWallet, eType isExpense) : this(amount, idWallet, DateTime.Now, isExpense)
        { }

        public Movement() : this(0, -1, DateTime.Now, eType.Gasto)
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
            movementInfo.Append("Wallet ID: " + this.idWallet);

            return movementInfo.ToString();
        }
    }
}
