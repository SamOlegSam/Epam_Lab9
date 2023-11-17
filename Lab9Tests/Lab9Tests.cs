using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab9;
using Microsoft.Win32;

namespace Lab9Tests
{
    [TestClass]
    public class Lab9Tests
    {
        
        [TestMethod]
        public void TestOpenFile()
        {
            string str = "sss ddd fff zzz xxx";
            Assert.AreEqual(str.Trim(), TextFile.OpenFile("D://1234567.txt").Trim());

        }
        

    }
}
