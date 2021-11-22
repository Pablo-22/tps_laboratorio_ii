using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities.InputOutput;
using Entities.WalletEntities;
using Entities.SystemCore;


namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestXmlSerialization()
        {
            Person newPerson = new Person("Soy un Unit Testing personificado");
            Xml<Person> xml = new Xml<Person>();
            string path = PathsGenerator.xmlGeneratePath("XmlSerializationUnitTest");

            Person destinationPerson = new Person();

            xml.Export(path, newPerson);
            xml.Import(path, ref destinationPerson);

            Assert.AreEqual(newPerson.Name, destinationPerson.Name);
        }

        [TestMethod]
        public void TestTxtSerialization()
        {
            Person newPerson = new Person();
            newPerson.TextInfo = "Soy un Unit Testing personificado";
            Txt<Person> txt = new Txt<Person>();
            string path = PathsGenerator.txtGeneratePath("TextSerializationUnitTest");

            Person destinationPerson = new Person();

            txt.Export(path, newPerson);
            txt.Import(path, ref destinationPerson);

            Assert.AreEqual(newPerson.TextInfo, destinationPerson.TextInfo);
        }
    }
}
