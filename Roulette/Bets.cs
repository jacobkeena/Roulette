using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Bets
    {

        public int[] RedNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public int[] BlackNumbers = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public int[] AllNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

        public void IndividualNumberBet(int n)
        {
            if (n <= 37 && n >= 0)
            {
                Console.WriteLine($"Bets placed on {n} win 35:1");
            }
        }
        public bool CheckZeros(int n)
        {
            if (n == 0 || n == 37)
            {
                if (n == 0)
                {
                    Console.WriteLine("Number was 0. No other table bets win.");
                    IndividualNumberBet(n);
                    return true;
                }
                else
                    Console.WriteLine("Number was 00. No other table bets win.");
                IndividualNumberBet(n);

                return true;
            }
            else
                return false;
        }
        public void EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"Even bets win 1:1");
                return;
            }
            else
                Console.WriteLine("Odd bets win 1:1");
        }
        public void RedOrBlack(int n, int[] RedArray, int[] BlackArray)
        {
            for (int i = 0; i < 18; i++)
            {
                if (RedArray[i] == n)
                {
                    Console.WriteLine("Bets made on red win 1:1");
                }
                if (BlackArray[i] == n)
                {
                    Console.WriteLine("Bets made on black win 1:1");
                }

            }
        }
        public void LowOrHigh(int n)
        {
            if(n<19 && n > 0)
            {
                Console.WriteLine("Bets made on Low (1 to 18) win 1:1");
            }
            if (n > 18 && n < 37)
            {
                Console.WriteLine("Bets made on High (19 to 36) win 1:1");
            }
        }
        public void Dozens(int n)
        {
            if (n >0 && n < 13)
            {
                Console.WriteLine("Bets made on 1st 12 win 2:1");
            }
            if(n >12 && n < 25)
            {
                Console.WriteLine("Bets made on 2nd 12 win 2:1");
            }
            if(n >24 && n < 37)
            {
                Console.WriteLine("Bets made on 3rd 12 win 2:1");
            }
        }
        public void Columns(int n)
        {
            int ColumnValue = FindColumnValue(n);
            if (ColumnValue == 1)
            {
                Console.WriteLine("Column bets made on column 1 (top 1, bottom 34) win 2:1");
            }
            if (ColumnValue == 2)
            {
                Console.WriteLine("Column bets made on column 2 (top 2, bottom 35) win 2:1");
            }
            if (ColumnValue == 3)
            {
                Console.WriteLine("Column bets made on column 3 (top 3, bottom 36) win 2:1");
            }
        }
        public void Street(int n)
        {
            if (n < 37)
            {
                if (n < 34)
                {
                    if (n < 31)
                    {
                        if (n < 28)
                        {
                            if (n < 25)
                            {
                                if (n < 22)
                                {
                                    if (n < 19)
                                    {
                                        if (n < 16)
                                        {
                                            if (n < 13)
                                            {
                                                if(n < 10)
                                                {
                                                    if (n < 7)
                                                    {
                                                        if (n< 4)
                                                        {
                                                            Console.WriteLine("Bets made on street 1, 2, 3 win 11:1");
                                                            return;
                                                        }
                                                        Console.WriteLine("Bets made on street 4, 5, 6 win 11:1");
                                                        return;
                                                    }
                                                    Console.WriteLine("Bets made on street 7, 8, 9 win 11:1");
                                                    return;
                                                }
                                                Console.WriteLine("Bets made on street 10, 11, 12 win 11:1");
                                                return;
                                            }
                                            Console.WriteLine("Bets made on street 13, 14, 15 win 11:1");
                                            return;
                                        }
                                        Console.WriteLine("Bets made on street 16, 17, 18 win 11:1");
                                        return;
                                    }
                                    Console.WriteLine("Bets made on street 19, 20, 21 win 11:1");
                                    return;
                                }
                                Console.WriteLine("Bets made on street 22, 23, 24 win 11:1");
                                return;
                            }
                            Console.WriteLine("Bets made on street 25, 26, 27 win 11:1");
                            return;
                        }
                        Console.WriteLine("Bets made on street 28, 29, 30 win 11:1");
                        return;
                    }
                    Console.WriteLine("Bets made on street 31, 32, 33 win 11:1");
                    return;
                }
                Console.WriteLine("Bets made on street 34, 35, 36 win 11:1");
                return;
            }

        }
        public void DoubleStreet(int n)
        {
            if (n < 37)
            {
                if (n < 34)
                {
                    if (n < 31)
                    {
                        if (n < 28)
                        {
                            if (n < 25)
                            {
                                if (n < 22)
                                {
                                    if (n < 19)
                                    {
                                        if (n < 16)
                                        {
                                            if (n < 13)
                                            {
                                                if (n < 10)
                                                {
                                                    if (n < 7)
                                                    {
                                                        if (n < 4)
                                                        {
                                                            Console.WriteLine("Double Street bets made between 1/4 win 5:1");
                                                            return;
                                                        }
                                                        Console.WriteLine("Double Street bets made between 1/4 and 4/7  win 5:1");
                                                        return;
                                                    }
                                                    Console.WriteLine("Double Street bets made between 4/7 and 7/10 win 5:1");
                                                    return;
                                                }
                                                Console.WriteLine("Double Street bets made between 7/10 and 10/13  win 5:1");
                                                return;
                                            }
                                            Console.WriteLine("Double Street bets made between 10/13 and 13/16  win 5:1");
                                            return;
                                        }
                                        Console.WriteLine("Double Street bets made between 13/16 and 16/19  win 5:1");
                                        return;
                                    }
                                    Console.WriteLine("Double Street bets made between 16/19 and 19/22  win 5:1");
                                    return;
                                }
                                Console.WriteLine("Double Street bets made between 19/22 and 22/25  win 5:1");
                                return;
                            }
                            Console.WriteLine("Double Street bets made between 22/25 and 25/28  win 5:1");
                            return;
                        }
                        Console.WriteLine("Double Street bets made between 25/28 and 28/31   win 5:1");
                        return;
                    }
                    Console.WriteLine("Double Street bets made between 28/31 and 31/34  win 5:1");
                    return;
                }
                Console.WriteLine("Double Street bets made between 31/34  win 5:1");
                return;
            }

        }

        public void Split(int n)
        {
            int ColumnValue = FindColumnValue(n);
            int split1, split2, split3, split4;
            if (ColumnValue == 1)
            {
                if (n != 1 && n != 34)
                {
                    split1 = n - 3;
                    split2 = n + 1;
                    split3 = n + 3;
                    Console.WriteLine($"Split bets between {n}:{split1}, {n}:{split2}, and {n}:{split3} win 17:1");
                }
                if (n == 1)
                {
                    split2 = n + 1;
                    split3 = n + 3;
                    Console.WriteLine($"Split bets between {n}:{split2} and {n}:{split3} win 17:1");

                }
                if (n == 34)
                {
                    split1 = n - 3;
                    split2 = n + 1;
                    Console.WriteLine($"Split bets between {n}:{split1} and {n}:{split2} win 17:1");
                }
            }
            if (ColumnValue == 2)
            {
                if (n != 2 && n != 35)
                {
                    split1 = n - 3;
                    split2 = n - 1;
                    split3 = n + 1;
                    split4 = n + 3;
                    Console.WriteLine($"Split bets between {n}:{split1}, {n}:{split2}, {n}:{split3}, and {n}:{split4} win 17:1");
                }
                if (n == 2)
                {
                    split2 = n - 1;
                    split3 = n + 1;
                    split4 = n + 3;
                    Console.WriteLine($"Split bets between {n}:{split2}, {n}:{split3}, and {n}:{split4} win 17:1");
                }
                if (n == 35)
                {
                    split1 = n - 3;
                    split2 = n - 1;
                    split3 = n + 1;
                    Console.WriteLine($"Split bets between {n}:{split1}, {n}:{split2}, and {n}:{split3} win 17:1");
                }
            }
            if (ColumnValue == 3)
            {
                if (n != 3 && n != 36)
                {
                    split1 = n - 3;
                    split2 = n - 1;
                    split3 = n + 3;
                    Console.WriteLine($"Split bets between {n}:{split1}, {n}:{split2}, and {n}:{split3} win 17:1");
                }
                if (n == 3)
                {
                    split2 = n - 1;
                    split3 = n + 3;
                    Console.WriteLine($"Split bets between {n}:{split2}, and {n}:{split3} win 17:1");
                }
                if (n == 36)
                {
                    split1 = n - 3;
                    split2 = n - 1;
                    Console.WriteLine($"Split bets between {n}:{split1} and {n}:{split2} win 17:1");
                }
            }
        }

        public void Corner(int n)
        {
            int ColumnValue = FindColumnValue(n);
            int corner1a, corner2a, corner3a, corner1b, corner2b, corner3b, corner1c, corner2c, corner3c, corner1d, corner2d, corner3d;
            if (ColumnValue == 1)
            {
                if (n != 1 && n!=34)
                {
                    //first set of corner values
                    corner1a = n - 3;
                    corner2a = n - 2;
                    corner3a = n + 1;
                    //second set of corner values
                    corner1b = n + 3;
                    corner2b = n + 4;
                    corner3b = n + 1;
                    Console.WriteLine($"Corner bets placed between {corner1a}/{corner2a}/{n}/{corner3a} and {n}/{corner3b}/{corner1b}/{corner2b} win 8:1");
                }
                if (n == 1)
                {
                    //second set of corner values
                    corner1b = n + 3;
                    corner2b = n + 4;
                    corner3b = n + 1;
                    Console.WriteLine($"Corner bets placed between {n}/{corner3b}/{corner1b}/{corner2b} win 8:1");
                }
                if (n == 34)
                {
                    //first set of corner values
                    corner1a = n - 3;
                    corner2a = n - 2;
                    corner3a = n + 1;
                    Console.WriteLine($"Corner bets placed between {corner1a}/{corner2a}/{n}/{corner3a} win 8:1");
                }

            }
            if (ColumnValue == 2)
            {
                if (n != 2 && n != 35)
                {
                    //first set of corner values
                    corner1a = n - 4;
                    corner2a = n - 3;
                    corner3a = n - 1;
                    //second set of corner values
                    corner1b = n - 3;
                    corner2b = n - 2;
                    corner3b = n + 1;
                    //third set of corner values
                    corner1c = n - 1;
                    corner2c = n + 2;
                    corner3c = n + 3;
                    //fourth set of corner values
                    corner1d = n + 3;
                    corner2d = n + 4;
                    corner3d = n + 1;
                    Console.WriteLine($"Corner bets placed between {corner1a}/{corner2a}/{corner3a}/{n}, {corner1b}/{corner2b}/{n}/{corner3b}, {corner1c}/{n}/{corner2c}/{corner3c}, and  " +
                        $"{n}/{corner1d}/{corner2d}/{corner3d}  win 8:1");
                }
                if (n == 2)
                {
                    //third set of corner values
                    corner1c = n - 1;
                    corner2c = n + 2;
                    corner3c = n + 3;
                    //fourth set of corner values
                    corner1d = n + 3;
                    corner2d = n + 4;
                    corner3d = n + 1;
                    Console.WriteLine($"Corner bets placed between {corner1c}/{n}/{corner2c}/{corner3c} and  " +
    $"{n}/{corner1d}/{corner2d}/{corner3d}  win 8:1");

                }
                if (n == 35)
                {
                    //first set of corner values
                    corner1a = n - 4;
                    corner2a = n - 3;
                    corner3a = n - 1;
                    //second set of corner values
                    corner1b = n - 3;
                    corner2b = n - 2;
                    corner3b = n + 1;
                    Console.WriteLine($"Corner bets placed between {corner1a}/{corner2a}/{corner3a}/{n} and {corner1b}/{corner2b}/{n}/{corner3b} win 8:1");
                }

            }
            if (ColumnValue == 3)
            {
                if (n != 3 && n != 36)
                {
                    //first set of corner values
                    corner1a = n - 4;
                    corner2a = n - 3;
                    corner3a = n - 1;
                    //second set of corner values
                    corner1b = n - 1;
                    corner2b = n + 2;
                    corner3b = n + 3;
                    Console.WriteLine($"Corner bets placed between {corner1a}/{corner2a}/{corner3a}/{n} and {corner3b}/{n}/{corner1b}/{corner3b} win 8:1");
                }
                if (n == 3)
                {
                    //second set of corner values
                    corner1b = n - 1;
                    corner2b = n + 2;
                    corner3b = n + 3;
                    Console.WriteLine($"Corner bets placed between {corner3b}/{n}/{corner1b}/{corner3b} win 8:1");
                }
                if (n == 36)
                {
                    //first set of corner values
                    corner1a = n - 4;
                    corner2a = n - 3;
                    corner3a = n - 1;
                    Console.WriteLine($"Corner bets placed between {corner1a}/{corner2a}/{corner3a}/{n} win 8:1");
                }

            }
            

        }

        public int FindColumnValue(int n)
        {
            //Calculates total of numbers in each column to determine whether its column 1 2 or 3.

            int index = n - 1;
            int ColumnValue = 0;
            for (int i = index; i >= 0; i--)
            {
                ColumnValue += AllNumbers[i];
                i--;
                i--;
            }
            index += 3;
            for (int i = index; i < AllNumbers.Length; i++)
            {
                ColumnValue += AllNumbers[i];
                i++;
                i++;
            }
            if (ColumnValue == 210) 
            {
                ColumnValue = 1;
            }
            if (ColumnValue == 222) 
            {
                ColumnValue = 2;
            }
            if (ColumnValue == 234) 
            {
                ColumnValue = 3;
            }
            return ColumnValue;

        }


    }
}
