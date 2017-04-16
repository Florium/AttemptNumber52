using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySuperTest
{
    [TestClass]
    public class MagicTest2
    {
        [TestMethod]
        public void Mega()
        {
            //arrange
            int i;
            int s = 0;
            int len = 31;
            int[] mas = { 10, 29, 4, 11, 30, 12, 16, 12, 28, 5, 14, 13, 9, 24, 8, 25, 27, 15, 17, 18, 6, 23, 26, 1, 19, 3, 2, 21, 20, 7, 22 };
            int[] res = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] fin = new int[len];

            //act
            MySortConsole.Program j = new MySortConsole.Program();
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
