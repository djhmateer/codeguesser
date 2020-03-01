using System;
using System.Diagnostics;
using System.Text;

namespace CodeGuesser
{
    class Program
    {
        static void Main()
        {
            var s = Stopwatch.StartNew();
            var counter = 0;
            Console.WriteLine("Starting...");

            // array of bytes (can be 0 to 255) eg 100, 97, 118, 101, 100, 97, 118
            byte[] secretBytes = Encoding.UTF8.GetBytes("davedav");
            var comparisonBytes = new byte[secretBytes.Length];

            // loop 1
            for (byte i = 97; i < 123; i++)
            {
                comparisonBytes[0] = i;
                //loop2
                for (byte j = 97; j < 123; j++)
                {
                    comparisonBytes[1] = j;
                    //loop 3
                    for (byte k = 97; k < 123; k++)
                    {
                        comparisonBytes[2] = k;
                        //loop4
                        for (byte l = 97; l < 123; l++)
                        {
                            comparisonBytes[3] = l;
                            //loop 5
                            for (byte m = 97; m < 123; m++)
                            {
                                comparisonBytes[4] = m;
                                //loop6
                                for (byte n = 97; n < 123; n++)
                                {
                                    comparisonBytes[5] = n;
                                    //loop7
                                    for (byte o = 97; o < 123; o++)
                                    {
                                        comparisonBytes[6] = o;
                                        //loop8
                                        //for (byte p = 97; p < 123; p++)
                                        //{
                                        //   comparisonBytes[7] = p;

                                        counter++;

                                        // compare to
                                        if (CompareByteArrays(comparisonBytes, secretBytes))
                                        {
                                            var comparisonString = Encoding.UTF8.GetString(comparisonBytes);
                                            Console.WriteLine("Found secret which is {0} after {1} pattern matches", comparisonString, $"{counter:n0}");
                                            Console.WriteLine("Timespan: {0}s", s.Elapsed.TotalSeconds);
                                            Console.WriteLine("Throughput: {0}comparisons/sec", $"{counter / (long)s.Elapsed.TotalSeconds:n0}");
                                            goto End;
                                        }
                                        //} //end loop 8
                                    }//end loop 7
                                } // end loop 6
                            }// end loop 5
                        } //end loop 4
                    } // end loop 3
                }// end loop 2
            }//end 1
            Console.WriteLine("Got to end and didn't find");
        End:
            Console.ReadLine();
        }
        public static bool CompareByteArrays(byte[] comparison, byte[] secret)
        {
            // compare each byte
            for (var i = 0; i < 7; i++)
            {
                if (comparison[i] != secret[i]) return false;
            }

            return true;
        }
    }
}
