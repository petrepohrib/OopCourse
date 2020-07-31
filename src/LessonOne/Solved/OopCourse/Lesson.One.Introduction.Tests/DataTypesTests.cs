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
        }

        [Fact]
        public void DeclareIntegerTest()
        {
            var result = DataTypes.DeclareInteger();

            Assert.NotEqual(default, result);
        }

        [Fact]
        public void DeclareLongTest()
        {
            var result = DataTypes.DeclareLong();

            Assert.NotEqual(default, result);
        }

        [Fact]
        public void DeclareDoubleTest()
        {
            var result = DataTypes.DeclareDouble();

            Assert.NotEqual(default, result);
        }

        [Fact]
        public void DeclareIntArrayTest()
        {
            var result = DataTypes.DeclareIntArray();

            Assert.NotEqual(default, result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void DeclareJaggedArrayTest()
        {
            var result = DataTypes.DeclareJaggedArray();

            Assert.NotEqual(default, result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void DeclareMultiDimensionalArrayTest()
        {
            var result = DataTypes.DeclareMultiDimensionalArray();

            Assert.NotEqual(default, result);
            Assert.NotEmpty(result);
        }
    }
}
