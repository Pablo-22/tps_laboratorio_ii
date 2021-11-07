using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entities
{
    [Serializable]
    [XmlInclude(typeof(Movement))]
    [XmlInclude(typeof(User))]
    [XmlInclude(typeof(Wallet))]

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
        public DataEntity()
        {
            this.id = Core.GenerateId();
            textInfo = null;
        }
    }
}
