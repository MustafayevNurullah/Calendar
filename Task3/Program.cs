using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
                List<int> vs = new List<int>();
                vs.Add(31);
                vs.Add(29);
                vs.Add(31);
                vs.Add(30);
                vs.Add(31);
                vs.Add(30);
                vs.Add(31);
                vs.Add(31);
                vs.Add(30);
                vs.Add(31);
                vs.Add(30);
                vs.Add(31);
                Console.WriteLine("Enter Date");
                string date1 = Console.ReadLine();
                Console.WriteLine("Enter Date2");
                string date2 = Console.ReadLine();
                int day1 =
                  DayConvert1(date1.Substring(0, 2));
                int day2 =

                DayConvert2(date2.Substring(0, 2));
                int month1 =
                   MonthConvert1(date1.Substring(2, 2));
                int month2 =
                MonthConvert2(date2.Substring(2, 2));
                int year1 = Convert.ToInt32(date1.Substring(4));
                int year2 = Convert.ToInt32(date2.Substring(4));
                int okday = 0;


                DaysCalculated();
                void cal()
                {

                    #region 1year               
                    int ab = 0;
                    if (year1 + 1 == year2)
                    {
                        ab = 12;

                        for (int i = month1; i <= ab; i++)
                        {
                            okday += vs[i - 1];
                            if (i == 12)
                            {
                                i = 0;
                                ab = month2 - 1;
                            }
                        }

                    }

                    if (year2 + 1 == year1)
                    {

                        ab = 12;

                        for (int i = month2; i <= ab; i++)
                        {
                            okday += vs[i - 1];
                            if (i == 12)
                            {
                                i = 0;
                                ab = month1 - 1;
                            }
                        }



                    }
                    #endregion

                    if (year1 == year2)
                    {
                        if (month1 > month2)
                        {
                            for (int i = month2; i < month1; i++)
                            {
                                okday += vs[i];

                            }
                        }
                        else
                        {
                            for (int i = month1; i < month2; i++)
                            {
                                okday += vs[i];

                            }
                        }
                    }

                    if (year1 + 1 != year2 & year2 + 1 != year1 & year1 != year2)
                    {
                        if (month1 != month2)
                        {
                            if (year1 > year2)
                            {


                                year2++;

                                for (int i = month2; i < 12; i++)
                                {
                                    okday += vs[i - 1];

                                }
                                for (int i = year2; i <= year1; i++)
                                {
                                    okday += 365;
                                }

                            }
                            else
                            {
                                for (int i = month1; i < 12; i++)
                                {
                                    okday += vs[i - 1];
                                   

                                }
                                year1++;
                                for (int i = year1; i <= year2; i++)
                                {
                                    okday += 365;
                                }
                                //kod
                            }
                        }
                        else
                        {
                            if (year1 > year2)
                            {
                                year1 += 1;

                                for (int i = year2; i <= year1; i++)
                                {
                                    okday += 365;
                                }
                            }
                            else
                            {
                                year1 += 1;
                                for (int i = year1; i <= year2; i++)
                                {
                                    okday += 365;
                                }
                            }
                        }

                    }

                }           
          
                cal();
                Console.WriteLine("Result day");
                Console.WriteLine(okday.ToString());
  
                int DayConvert1(string tmp)
                {
                    if (Convert.ToInt32(tmp.Substring(0, 1)) == 0)
                    {
                        return Convert.ToInt32(tmp.Substring(1, 1));
                    }
                    else
                    {
                        return Convert.ToInt32(tmp);
                    }
                }
                int DayConvert2(string tmp)
                {
                    if (Convert.ToInt32(tmp.Substring(0, 1)) == 0)
                    {
                        return Convert.ToInt32(tmp.Substring(1, 1));
                    }
                    else
                    {
                        return Convert.ToInt32(tmp);
                    }
                }
                int MonthConvert1(string tmp)
                {
                    if (Convert.ToInt32(tmp.Substring(0, 1)) == 0)
                    {
                        return Convert.ToInt32(tmp.Substring(1, 1));
                    }
                    else
                    {
                        return Convert.ToInt32(tmp);
                    }



                }
                int MonthConvert2(string tmp)
                {
                    if (Convert.ToInt32(tmp.Substring(0, 1)) == 0)
                    {
                        return Convert.ToInt32(tmp.Substring(1, 1));
                    }
                    else
                    {
                        return Convert.ToInt32(tmp);
                    }



                }
                void DaysCalculated()
                {
                   

                    if (year1 > year2)
                    {
                        okday -= day2 - 1;
                        okday += day1 - 1;
                    }
                    else
                    {
                        okday -= day1 - 1;
                        okday += day2 - 1;
                    }

                }
                void MonthCalculated()
                {
                    if (year1 != year2 & year1 > year2)
                    {

                        int a = 12;
                        for (int i = month2; i <= a; i++)
                        {
                            okday += vs[i - 1];
                            if (i == 12)
                            {
                                i = 0;
                                a = month1 - 1;

                            }

                        }
                    }
                    else
                    {
                        int a = 12;
                        for (int i = month1; i <= a; i++)
                        {
                            okday += vs[i - 1];
                            if (i == 12)
                            {
                                i = 0;
                                a = month2 - 1;

                            }

                        }
                    }
                }

            }
        

        
        }
    }

