﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Wallet : DataEntity
    {
        private float balance;
        private List<Movement> purchasesMade;

        public Wallet() : this(0)
        { }

        public Wallet(float balance)
        {
            this.balance = balance;
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<Movement> PurchasesMade
        {
            get { return purchasesMade; }
            set { purchasesMade = value; }
        }
    }
}
