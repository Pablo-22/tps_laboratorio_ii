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

        public Movement(float amount, int idWallet, DateTime purchaseDate) : base()
        {
            this.amount = amount;
            this.idWallet = idWallet;
            this.purchaseDate = purchaseDate;
        }

        public Movement(float amount, int idWallet) : this(amount, idWallet, DateTime.Now)
        { }

        public Movement() : this(0, -1, DateTime.Now)
        { }
    }
}
