using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entities.InputOutput;
using Entities.WalletEntities;
using Entities.SystemCore;
using Entities.DataBaseActions;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestXmlSerializationHappyPath()
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

        [TestMethod]
        public void TestExtensionMethod()
        {
            Person newPerson = new Person();
            newPerson.TextInfo = "Soy un Unit Testing personificado";

            bool result = newPerson.SearchStringOnEntity("Testing", newPerson =>
            {
                return newPerson.TextInfo;
            });

            bool result2 = newPerson.SearchStringOnEntity("****", newPerson =>
            {
                return newPerson.TextInfo;
            });

            Assert.IsTrue(result);
            Assert.IsFalse(result2);
        }
    }
}
