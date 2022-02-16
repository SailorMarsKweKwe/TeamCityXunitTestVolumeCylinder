using System;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1.2, 2, 9.047786842338605)]
        [InlineData(3, 1, 28.274333882308138)]
        [InlineData(5, 2, 157.07963267948966)]
        [InlineData(19, 26, 29486.988646593796)]
        [InlineData(7, 1, 153.93804002589985)]
        [InlineData(6, 2, 226.1946710584651)]
        [InlineData(0, 0, 0)]
        [InlineData(10, 3, 942.4777960769379)]
        [InlineData(2, 1, 12.566370614359172)]
        [InlineData(3.23, 8.23, 269.74583802409217)]
        [InlineData(2.2, 6.6, 100.35503572627236)]
        [InlineData(6, 0, 0)]
        [InlineData(1, 1, 3.141592653589793)]
        [InlineData(6, 6, 678.5840131753953)]
        [InlineData(56, 78695, 775305859.8296441)]
        [InlineData(3, 2, 56.548667764616276)]
        [InlineData(0, 1, 0)]
        [InlineData(4.56, 7, 457.275147011793)]
        [InlineData(4, 7, 351.85837720205683)]
        [InlineData(0.456456, 6.5646, 4.296907269660276)]

        public void VolumCylinderTest(double r, double h, double expected)
        {

            double actual = Method.VolumCylinder(r, h);

            Assert.Equal(expected, actual);
        }
    }
}