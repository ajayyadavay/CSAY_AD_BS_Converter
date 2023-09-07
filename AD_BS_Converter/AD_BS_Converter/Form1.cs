using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AD_BS_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Find_No_of_Months_BS();
            SumofDaysinList();
            CalcLastDate();
        }

        private void CalcLastDate()
        {
            try
            {
                int days = Convert.ToInt32(TxtTotalDays.Text);
                string oldDate = TxtBaseDateAD.Text;
                string lastdate = NewDateAFterAddingDays_and_Months(days, 0, oldDate);
                TxtLastDateAD.Text = lastdate;

                string olddate = TxtBaseDateBS.Text;
                int days2add = Convert.ToInt32(TxtTotalDays.Text);
                string newdate = Add_days_to_BS_Date(olddate, days2add);
                TxtLastDateBS.Text = newdate;
            }
            catch
            {

            }
            
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

        private void Remarks()
        {
            int n_days, totaldays;
            n_days = Convert.ToInt32(TxtN_Days.Text);
            totaldays = Convert.ToInt32(TxtTotalDays.Text);

            if(n_days >=0 && n_days <= totaldays)
            {
                LblRemarks.Text = "OK. Click convert AD to BS";
                LblRemarks.ForeColor = Color.ForestGreen;
            }
            else
            {
                LblRemarks.Text = "Not OK. New AD date is out of range";
                LblRemarks.ForeColor = Color.Red;
            }
        }

        private void SumofDaysinList()
        {
            try
            {
                int n_mnths_DB = Convert.ToInt32(TxtMonthsinListbox.Text);
                string[] days_of_Month_BS = TxtDayslistbox.Text.Split(',');
                int[] IntDays = new int[n_mnths_DB];

                int sum = 0;

                for (int i = 0; i < n_mnths_DB; i++)
                {
                    IntDays[i] = Convert.ToInt32(days_of_Month_BS[i]);
                    sum += IntDays[i];
                }

                TxtTotalDays.Text = sum.ToString();
            }
            catch
            {

            }
            
        }

        private void Find_No_of_Months_BS()
        {
            try
            {
                int len = TxtDayslistbox.Text.Split(',').Length;
                TxtMonthsinListbox.Text = len.ToString();
            }
            catch
            {

            }

        }

        private void Find_No_of_days_AD()
        {
            try
            {
                int n_days = DifferenceInDate(TxtBaseDateAD.Text, TxtNewDateAD.Text);
                TxtN_Days.Text = n_days.ToString();
            }
            catch
            {

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

        private void TxtBaseDateAD_TextChanged(object sender, EventArgs e)
        {
            Find_No_of_days_AD();
            CalcLastDate();
        }

        private void TxtNewDateAD_TextChanged(object sender, EventArgs e)
        {
            Find_No_of_days_AD();
            Remarks();
        }

        private void TxtDayslistbox_TextChanged(object sender, EventArgs e)
        {
            Find_No_of_Months_BS();
            SumofDaysinList();
            CalcLastDate();
        }

        private string Add_days_to_BS_Date(string BaseDateBS, int days2add)
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



            int n_mnths_DB = Convert.ToInt32(TxtMonthsinListbox.Text);
            string[] days_of_Month_BS = TxtDayslistbox.Text.Split(',');
            int[] IntDays = new int[n_mnths_DB];

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

        private void BtnADtoBS_Click(object sender, EventArgs e)
        {
            string olddate = TxtBaseDateBS.Text;
            int days2add = Convert.ToInt32(TxtN_Days.Text);
            string newdate = Add_days_to_BS_Date(olddate, days2add);
            TxtNewDateBS.Text = newdate;

            //int year1, month1, days1, year2=0, month2=0, days2=0;
            //string[] temp_date1 = TxtBaseDateBS.Text.Split('-');

            /*int[] monthdays = new int[]
            {
                31,28,31,30,31,30,31,31,30,31,30,31
            };*/

            /*year1 = Convert.ToInt32(temp_date1[0]);
            month1 = Convert.ToInt32(temp_date1[1]);
            days1 = Convert.ToInt32(temp_date1[2]);

            

            int n_mnths_DB = Convert.ToInt32(TxtMonthsinListbox.Text);
            string[] days_of_Month_BS = TxtDayslistbox.Text.Split(',');
            int[] IntDays = new int[n_mnths_DB];

            for(int i = 0; i < n_mnths_DB; i++)
            {
                IntDays[i] = Convert.ToInt32(days_of_Month_BS[i]);
            }

            int rem_days = 0;
            rem_days = Convert.ToInt32(TxtN_Days.Text);
            for (int i = 0; i < n_mnths_DB; i++)
            {
                if (IntDays[i] <= rem_days)
                {
                    year2 = year1;
                    month2 = month1 + 1;
                    days2 = days1;

                    if(month2 > 12)
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

            TxtNewDateBS.Text = year2.ToString() + "-" + month2.ToString() + "-" + days2.ToString();*/
        }

        private void TxtBaseDateBS_TextChanged(object sender, EventArgs e)
        {
            CalcLastDate();
        }
    }
}
