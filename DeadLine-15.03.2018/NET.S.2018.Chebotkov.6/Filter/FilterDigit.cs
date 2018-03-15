using System.Collections.Generic;
using System.Linq;
namespace Filter
{
    /// <summary>
    /// This class contains filter method/
    /// </summary>
    public static class FilterDigit
    {
        /// <summary>
        /// Method gets array of integers and digit. Then it 
        /// scans received array for numbers which contains specified digit
        /// and puts them in new array.
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="digit">Filtration digit</param>
        /// <returns>Return new Array</returns>
        public static int [] FilterDigitFunc(int [] array, int digit)
        {
            List<int> temp = new List<int>();
            for(int i=0; i<array.Length; i++)
            {
                if(array[i].ToString().Contains(digit.ToString()) && !temp.Contains(array[i]))
                {
                    temp.Add(array[i]);
                }
            }
            return temp.ToArray<int>();
        }
    }
}
