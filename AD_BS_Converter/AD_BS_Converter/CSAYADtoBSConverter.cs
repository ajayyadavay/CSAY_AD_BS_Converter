using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_BS_Converter
{
    internal class CSAYADtoBSConverter
    {
        private string Add_days_to_BS_Date(string BaseDateBS, int days2add, int No_of_Month_in_List, string[] days_of_each_Month_in_List)
        {
            string newDate = "";

            int year1, month1, days1, year2 = 0, month2 = 0, days2 = 0;
            string[] temp_date1 = BaseDateBS.Split('-');

            /*int[] monthdays = new int[]
            {
                31,28,31,30,31,30,31,31,30,31,30,31
            };*/

            year1 = Convert.ToInt32(temp_date1[0]);
            month1 = Convert.ToInt32(temp_date1[1]);
            days1 = Convert.ToInt32(temp_date1[2]);



            //int n_mnths_DB = Convert.ToInt32(TxtMonthsinListbox.Text);
            int n_mnths_DB = No_of_Month_in_List;
            //string[] days_of_Month_BS = TxtDayslistbox.Text.Split(',');//days_of_each_Month_in_List
            string[] days_of_Month_BS = days_of_each_Month_in_List;
            int[] IntDays = new int[n_mnths_DB];

            //convert no. of days in each month from string to integer
            for (int i = 0; i < n_mnths_DB; i++)
            {
                IntDays[i] = Convert.ToInt32(days_of_Month_BS[i]);
            }

            int rem_days = 0;
            //rem_days = Convert.ToInt32(TxtN_Days.Text);
            rem_days = days2add;
            for (int i = 0; i < n_mnths_DB; i++)
            {
                if (IntDays[i] <= rem_days)
                {
                    year2 = year1;
                    month2 = month1 + 1;
                    days2 = days1;

                    if (month2 > 12)
                    {
                        year2++;
                        month2 -= 12;
                    }

                    rem_days -= IntDays[i];
                    year1 = year2;
                    month1 = month2;
                    days1 = days2;
                }
                else if (IntDays[i] > rem_days)
                {
                    year2 = year1;
                    month2 = month1;
                    days2 = days1 + rem_days;

                    if (month2 > 12)
                    {
                        year2++;
                        month2 -= 12;
                    }

                    rem_days = 0;
                    break;
                }
            }

            //TxtNewDateBS.Text = year2.ToString() + "-" + month2.ToString() + "-" + days2.ToString();
            newDate = year2.ToString() + "-" + month2.ToString() + "-" + days2.ToString();

            return newDate;
        }

        private string NewDateAFterAddingDays_and_Months(int DaysToAdd, int MonthsToAdd, string OldDate)
        {
            try
            {
                //Date should be in format YYYY-MM-DD e.g. 2022-02-23
                int year1, month1, days1, year2, month2, days2;
                string[] temp_date1 = OldDate.Split('-');

                year1 = Convert.ToInt32(temp_date1[0]);
                month1 = Convert.ToInt32(temp_date1[1]);
                days1 = Convert.ToInt32(temp_date1[2]);

                DateTime start = new DateTime(year1, month1, days1);
                DateTime somedate = start.AddDays(DaysToAdd);
                somedate = somedate.AddMonths(MonthsToAdd);

                year2 = somedate.Year;
                month2 = somedate.Month;
                days2 = somedate.Day;

                OldDate = year2 + "-" + month2 + "-" + days2;

                return OldDate;
            }
            catch
            {
                return "";
            }
        }

        private int DifferenceInDate(string StartDate, string EndDate)
        {
            try
            {
                //Date should be in format YYYY-MM-DD e.g. 2022-02-23
                int year1, month1, days1, year2, month2, days2;
                string[] temp_date1 = StartDate.Split('-');
                string[] temp_date2 = EndDate.Split('-');

                /*int[] monthdays = new int[]
                {
                    31,28,31,30,31,30,31,31,30,31,30,31
                };*/

                year1 = Convert.ToInt32(temp_date1[0]);
                month1 = Convert.ToInt32(temp_date1[1]);
                days1 = Convert.ToInt32(temp_date1[2]);

                year2 = Convert.ToInt32(temp_date2[0]);
                month2 = Convert.ToInt32(temp_date2[1]);
                days2 = Convert.ToInt32(temp_date2[2]);

                DateTime start = new DateTime(year1, month1, days1);
                DateTime end = new DateTime(year2, month2, days2);

                TimeSpan difference = end - start; //create TimeSpan object

                return difference.Days;


            }
            catch
            {
                return 0;
            }

        }


    }
}
