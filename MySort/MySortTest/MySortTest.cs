using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySortTest
{
    [TestClass]
    public class MySortTest
    {
        [TestMethod]
        public static void MagicTest()
        {
            //arrange
            int i;
            int s=0;
            int len = 9;
            int[] mas = { 4, 5, 9, 8, 6, 1, 3, 2, 7 };
            int[] res = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] fin = new int[len];

            //act
            MySortConsole.Program j = new  MySortConsole.Program();
            fin = j.Magic(mas, len);

            //assert
            for (i = 0; i < 10; i++)
            {
                if (res[i] == fin[i]) s++; 
            }
            Assert.AreEqual(s, len);
        }
    }
}
