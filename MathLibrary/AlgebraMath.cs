using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathLibrary
{
    public class AlgebraMath
    {
        public static  int Add(int x, int y)
        {
            return x + y;
        }

        public int Multipy(int x, int y)
        {
            return x*y;
        }
    }

    public class TestAlgebra
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(2, AlgebraMath.Add(1,1));
        }
    }
}
