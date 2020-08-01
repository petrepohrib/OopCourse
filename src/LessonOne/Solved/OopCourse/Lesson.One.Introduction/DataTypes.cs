namespace Lesson.One.Introduction
{
    public static class DataTypes
    {
        /// <summary>
        /// Declare a string variable and initialize it with <c>Hello!</c>
        /// </summary>
        /// <returns><c>Hello!</c></returns>
        public static string DeclareString()
        {
            // string myVariable = new string(new char[] { 'H', 'e', 'l', 'l', 'o', '!' });
            // string myVariable = "Hello!";
            var myVariable = "Hello!";
            return myVariable;
        }

        /// <summary>
        /// Declare an integer variable and initialize it with <c>1994</c>
        /// </summary>
        /// <returns><c>1994</c></returns>
        public static int DeclareInteger()
        {
            const int integer = 1994;
            return integer;
        }


        /// <summary>
        /// Declare a long variable and initialize it with <c>4587l</c>
        /// </summary>
        /// <returns><c>4587l</c></returns>
        public static long DeclareLong()
        {
            const long myLong = 4587L;
            return myLong;
        }

        /// <summary>
        /// Declare a double variable and initialize it with <c>1856.54</c>
        /// </summary>
        /// <returns><c>1856.54</c></returns>
        public static double DeclareDouble()
        {
            const double myDouble = 1856.54;
            return myDouble;
        }

        /// <summary>
        /// Declare a int array variable and initialize it with <c>1, 2, 3, 4</c>
        /// </summary>
        /// <returns><c>[1, 2, 3, 4]</c></returns>
        public static int[] DeclareIntArray()
        {
            //int[] myArray = new int[10];
            var myArray = new int[] { 1, 2, 3, 4 };
            return myArray;
        }

        /// <summary>
        /// Declare a jagged array of type int that looks like bellow
        /// [
        ///     [ 1, 2, 3 ],
        ///     [ 1, 2 ],
        ///     [ 4, 5, 8, 9 ]
        /// ]
        /// </summary>
        /// <returns>A bi-dimensional array.</returns>
        public static int[][] DeclareJaggedArray()
        {
            int[][] jaggedArray = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2 },
                new int[] { 4, 5, 8, 9 }
            };

            return jaggedArray;
        }

        /// <summary>
        /// Declare a multi dimensional array of type int that looks like bellow
        /// [
        ///     [ 1, 2 ],
        ///     [ 3, 4 ],
        ///     [ 5, 6 ],
        ///     [ 7, 8 ]
        /// ]
        /// </summary>
        /// <returns>A bi-dimensional array.</returns>
        public static int[,] DeclareMultiDimensionalArray()
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            return matrix;
        }
    }
}
