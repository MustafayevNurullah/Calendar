using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> vs = new List<int>();
                vs.Add(31);
                vs.Add(28);
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
                int day1 = Convert.ToInt32(date1.Substring(0, 2));
                int day2 = Convert.ToInt32(date2.Substring(0, 2));
                int month1 = Convert.ToInt32(date1.Substring(2, 2));
                int month2 = Convert.ToInt32(date2.Substring(2, 2));

                int year1 = Convert.ToInt32(date1.Substring(4));
                int year2 = Convert.ToInt32(date2.Substring(4));
                int okday = 0;
                void yearsChange()
                {
                    if(year1==year2 & month1<month2)
                    {
                        int tmp;
                        tmp = month2;
                        month2 = month1;
                        month1 = tmp;

                        tmp = day2;
                        day2 = day1;
                        day1 = tmp;
                    }
                   
                    if (year1 < year2)
                    {
                        int tmp;
                        tmp=year2;
                        year2 = year1;
                        year1 = tmp;

                        tmp = month2;
                        month2 = month1;
                        month1 = tmp;

                        tmp = day2;
                        day2 = day1;
                        day1 = tmp;


                    }

                }
                yearsChange();
                cal();
                DaysCalculated();
                ok();
               void cal()
                {
                    if(year2+1==year1 & month1>month2)
                    {
                        MonthCalculted();
                        okday += 365;
                    }
                    if (year2 + 1 == year1 & month1 < month2)
                    {
                        MonthCalcultted2();
                        
                    }
                    if (year2 + 1 == year1 & month1 == month2)
                        okday += 365;

                    if(year1-year2>=2 )
                    {
                        if (month1 == month2)
                        {
                            int tmp = year1 - year2;
                            okday += tmp * 365;
                        }
                        if (month1 < month2)
                        {
                            MonthCalcultted2();
                           //modify
                            year2++;
                           int tmp = year1 - year2;
                            year2--;
                            okday += tmp * 365;
                        }
                       if(month1>month2)
                        {
                            MonthCalculted();
                            //modify
                            int tmp = year1 - year2;
                            okday += tmp* 365;
                        }

                    }

                    //03/01/2020
                    //04/02/2020
                    if (year1==year2)
                    {
                        MonthCalculted();
                    }

                }
                void MonthCalculted()
                {
                    for (int i = month2; i < month1; i++)
                    {
                        okday += vs[i - 1];
                    }
                }

                void MonthCalcultted2()
                {
                    int tmp = 12;
                    for (int i = month2; i <= tmp; i++)
                    {
                        okday += vs[i - 1];
                        if (i == 12)
                        {
                            i = 1;
                            tmp = month1;
                        }
                    }
                }
                Console.WriteLine("Result day");
                Console.WriteLine(okday.ToString());
                void ok()
                {
                        if(month1>2)
                        {
                            year1++;
                        }
                    if (year1 != year2)
                    {
                        if (month2 <= 2)
                        {
                            year2--;
                        }
                    }
                    okday+= ((year1 ) / 4 - (year1 ) / 100 + (year1 ) / 400) - ((year2 ) / 4 - (year2) / 100 + (year2 ) / 400);
                }
                void DaysCalculated()
                {
                    if (day1 > day2)
                    {
                        okday += day1 - day2;
                    }
                    else
                    {
                        okday -= day2 - day1;
                    }
                }
            }

             }
         }
    }

