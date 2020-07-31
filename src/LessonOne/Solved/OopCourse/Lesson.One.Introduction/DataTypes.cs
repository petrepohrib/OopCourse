namespace Lesson.One.Introduction
{
    public static class DataTypes
    {
        public static string DeclareString()
        {
            // string myVariable = new string(new char[] { 'H', 'e', 'l', 'l', 'o', '!' });
            // string myVariable = "Hello!";
            var myVariable = "Hello!";
            return myVariable;
        }

        public static int DeclareInteger()
        {
            const int integer = 12;
            return integer;
        }

        public static long DeclareLong()
        {
            const long myLong = 123L;
            return myLong;
        }

        public static double DeclareDouble()
        {
            const double myDouble = 123d;
            return myDouble;
        }

        public static int[] DeclareIntArray()
        {
            //int[] myArray = new int[10];
            var myArray = new int[] { 1, 2, 3, 4 };
            return myArray;
        }

        public static int[][] DeclareJaggedArray()
        {
            //int[][] jaggedArray = new int[3][];
            //for (var i = 0; i < jaggedArray.Length; i++)
            //{
            //    jaggedArray[i] = new int[4];
            //}

            int[][] jaggedArray = new int[3][]
            {
                new int[2],
                new int[3],
                new int[4]
            };

            return jaggedArray;
        }

        public static int[,] DeclareMultiDimensionalArray()
        {
            //int[,] matrix = new int[3, 4];
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            return matrix;
        }
    }
}
