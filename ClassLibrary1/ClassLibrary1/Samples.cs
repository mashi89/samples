using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Samples
    {
        /// Get Mean with a sum function
        public int GetMean(int[] inputVar)
        {
            // Initialize variables
            var result = 0;
            var sum = 0;

            sum = inputVar.Sum();

            // Divide by number of input elements
            result = sum / inputVar.Length;

            return result;
        }

        /// Get Mean with a for loop
        public int GetMeanFor(int[] inputVar)
        {
            // Initialize variables
            var result = 0;
            var sum = 0;

            // Sum input elements
            for (int i = 1; i < inputVar.Length; i++)
            {
                sum = sum + inputVar[i];
            }

            // Divide by number of input elements
            result = sum / inputVar.Length;

            return result;
        }

        ///Assign bytes to bits, returns true if successful
        public bool BytesToBits(Byte[] inputByte, bool[] outputBits)
        {
            bool[] outputBitss;

            // Check if bytes and bits match in amount
            if (!(outputBits.Length == ( inputByte.Length * 8 )))
            {
                return false;
            }

            // Handle input elements
            for (int i = 1; i < inputByte.Length; i++)
            {
                for (int y = 1; y < 8; y++)
                {
                    //outputBitss[i * y] = inputByte[i].;
                }
            }

            // Successful
            return true;
        }
    }
}
