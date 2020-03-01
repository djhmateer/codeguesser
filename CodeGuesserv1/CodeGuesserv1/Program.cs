using System;
using System.Diagnostics;

namespace CodeGuesserv1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Stopwatch.StartNew();
            string secretString = "davedav";
            string tryString;
            char iChar;
            char jChar;
            char kChar;
            char lChar;
            char mChar;
            char nChar;
            char oChar;
            char pChar;
            string iString;
            string jString;
            string kString;
            string lString;
            string mString;
            string nString;
            string oString;
            string pString;
            ulong counter = 0;
            Console.WriteLine();

            //loop 1
            for (int i = 97; i < 123; i++)
            {
                iChar = (char)i;
                iString = iChar.ToString();
                //loop 2
                for (int j = 97; j < 123; j++)
                {
                    jChar = (char)j;
                    jString = jChar.ToString();
                    //loop3
                    for (int k = 97; k < 123; k++)
                    {
                        kChar = (char)k;
                        kString = kChar.ToString();
                        //loop4
                        for (int l = 97; l < 123; l++)
                        {
                            lChar = (char)l;
                            lString = lChar.ToString();
                            //loop5
                            for (int m = 97; m < 123; m++)
                            {
                                mChar = (char)m;
                                mString = mChar.ToString();
                                //loop6
                                for (int n = 97; n < 123; n++)
                                {
                                    nChar = (char)n;
                                    nString = nChar.ToString();
                                    //loop7
                                    for (int o = 97; o < 123; o++)
                                    {
                                        oChar = (char)o;
                                        oString = oChar.ToString();

                                        //loop8
                                        /*for (int p = 97; p < 123; p++)
                                                                               {
                                                                                   pChar = (char)p;
                                                                                   pString = pChar.ToString();
                                                                               }*///end loop8
                                        counter++;
                                        tryString = iString + jString + kString + lString + mString + nString + oString;

                                        if (tryString == secretString)
                                        {
                                            Console.WriteLine($"Found secret which is {tryString} after {counter} matches");
                                            Console.WriteLine($"time taken is {s.Elapsed.TotalSeconds} s");
                                            break;
                                        }// End if
                                    }//end loop7
                                }//loop6
                            }//end loop5  
                        }//end loop4
                    }//end loop3
                }//end loop2
            }//end loop1
            Console.ReadLine();
        }
    }
}
