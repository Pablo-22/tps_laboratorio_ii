using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Entities.DataBaseActions;
using System.Xml.Serialization;
using Entities.SystemCore;
using Entities.InputOutput;

namespace Entities.WalletEntities
{
    public abstract class DataEntity
    {
        private int id;
        private string textInfo;

        public string TextInfo
        {
            get { return textInfo; }
            set { textInfo = value; }
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DataEntity() : this(Core.GenerateId())
        {
            textInfo = null;
        }

        public DataEntity(int id)
        {
            this.id = id;
        }
    }
}
