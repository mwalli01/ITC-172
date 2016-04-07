using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        GetBdayTime();
    }

    protected void GetBdayTime()
    {
        DateTime bDay;
        if (Calendar1.SelectedDate == null)
        {
            bDay = DateTime.Now;
        }
        else
        { 
            bDay = Calendar1.SelectedDate;
            string bDayFormatted = bDay.ToShortTimeString();
        }
        string userName = TextBox1.Text;
        TimeSpan daysUntil = bDay.Subtract(DateTime.Now);
        ResultLabel.Text = "Days until birthday" + Math.Abs(daysUntil.TotalDays).ToString() +
                            " hours " + Math.Abs(daysUntil.TotalHours).ToString();
    }
}
