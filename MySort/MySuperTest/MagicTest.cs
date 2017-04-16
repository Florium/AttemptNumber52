using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySuperTest
{
    [TestClass]
    public class MagicTest
    {
        [TestMethod]
        public void Ultra()
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
            for (i = 0; i < len; i++)           //checking the array for correctness
            {
                if (res[i] == fin[i]) s++; 
            }
            Assert.AreEqual(len, s);
        }
    }
}
