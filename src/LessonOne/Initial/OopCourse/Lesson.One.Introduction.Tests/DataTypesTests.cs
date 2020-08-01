using Xunit;

namespace Lesson.One.Introduction.Tests
{
    public class DataTypesTests
    {
        [Fact]
        public void DeclareStringTest()
        {
            var result = DataTypes.DeclareString();

            Assert.NotNull(result);
            Assert.Equal("Hello!", result);
        }

        [Fact]
        public void DeclareIntegerTest()
        {
            var result = DataTypes.DeclareInteger();

            Assert.Equal(1994, result);
        }

        [Fact]
        public void DeclareLongTest()
        {
            var result = DataTypes.DeclareLong();

            Assert.Equal(4587L, result);
        }

        [Fact]
        public void DeclareDoubleTest()
        {
            var result = DataTypes.DeclareDouble();

            Assert.Equal(1856.54, result);
        }

        [Fact]
        public void DeclareIntArrayTest()
        {
            var result = DataTypes.DeclareIntArray();

            Assert.NotEqual(default, result);
            Assert.Equal(new int[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void DeclareJaggedArrayTest()
        {
            var expected = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2 },
                new int[] { 4, 5, 8, 9 }
            };

            var result = DataTypes.DeclareJaggedArray();

            Assert.NotEqual(default, result);
            Assert.NotEmpty(result);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DeclareMultiDimensionalArrayTest()
        {
            var expected = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            var result = DataTypes.DeclareMultiDimensionalArray();

            Assert.NotEqual(default, result);
            Assert.NotEmpty(result);
            Assert.Equal(expected, result);
        }
    }
}
