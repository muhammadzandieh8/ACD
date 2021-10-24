using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace wfp_acd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Variable
        double A, C, a_up, a_down, c_up, c_down, p1h, p1l, w, x, y, p3h, p3l;
        double ophigh, oplow, low1, high1, close1, low3, high3, atr;
        string advice;
        #endregion
        #region Limit TextBox
        private void input(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;

            }
        }
        private void txtbox_atr_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_high3_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_low3_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_close1_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_high1_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_low1_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_oplow_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        private void txtbox_ophigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            input(e);
        }
        #endregion
        #region Button Clear
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbox_ophigh.Text = "";
            txtbox_oplow.Text = "";
            txtbox_low1.Text = "";
            txtbox_high1.Text = "";
            txtbox_close1.Text = "";
            txtbox_low3.Text = "";
            txtbox_high3.Text = "";
            txtbox_atr.Text = "";
        }
        #endregion
        #region Button Calculate
        private void btn_calculate_Click(object sender, EventArgs e)
        {

            if (txtbox_ophigh.Text != "" && txtbox_oplow.Text != "" && txtbox_low1.Text != "" && txtbox_high1.Text != "" && txtbox_close1.Text != "" && txtbox_high3.Text != "" && txtbox_atr.Text != "")
            {
                #region Get Value from TextBox
                ophigh = Convert.ToDouble(txtbox_ophigh.Text);
                oplow = Convert.ToDouble(txtbox_oplow.Text);
                low1 = Convert.ToDouble(txtbox_low1.Text);
                high1 = Convert.ToDouble(txtbox_high1.Text);
                close1 = Convert.ToDouble(txtbox_close1.Text);
                low3 = Convert.ToDouble(txtbox_low3.Text);
                high3 = Convert.ToDouble(txtbox_high3.Text);
                atr = Convert.ToDouble(txtbox_atr.Text);
                #endregion
                #region A UP & Down
                A = (int)(atr * 10 / 100);
                a_up = ophigh + A;
                a_down = oplow - A;
                #endregion
                #region C UP & Down
                C = (int)(atr * 15 / 100);
                c_up = ophigh + C;
                c_down = oplow - C;
                #endregion
                #region P1H & P1L
                x = (int)((low1 + high1 + close1) / 3);
                y = (int)((high1 + low1) / 2);
                w = x - y;
                p1h = x + w;
                p1l = x - w;
                #endregion
                #region P3H & P3L
                x = (int)((low3 + high3 + close1) / 3);
                y = (int)((high3 + low3) / 2);
                w = x - y;
                p3h = x + w;
                p3l = x - w;
                #endregion
                string message = " Is half the opening candle in range  " + a_up.ToString() + "traded?";
                string tittle = "Question";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, tittle, buttons);
                if (result == DialogResult.Yes)
                {
                    #region A up valid 
                    advice = " We are looking for a high profit (buying position), we can consider the profit limit as much as 3 times the first candle of the day ";
                    advice += (ophigh + (ophigh - oplow) * 3).ToString();
                    advice += " If the market shows resistance to  ";
                    advice += a_up.ToString();
                    advice += " , it is down again and may come down to    ";
                    advice += a_down.ToString();
                    advice += "(sell position) ";
                    #endregion
                }
                else
                {
                    message = "Is half the opening candle in range" + a_down.ToString() + "  traded?";
                    tittle = "Question";
                    result = MessageBox.Show(message, tittle, buttons);
                    if (result == DialogResult.Yes)
                    {
                        #region A down valid 
                        advice += "The market trend is downward, it may show support up to ";
                        advice += (oplow - (ophigh - oplow) * 3).ToString();
                        advice += " . If the market is supported, ";
                        advice += "  it is bullish again and may come up to  ";
                        advice += a_up.ToString();
                        advice += " high (buy position) ";
                        #endregion
                    }
                    else
                    {
                        #region rouber bound
                        advice += "The market is highly volatile. The best thing to do is set a profit margin ";
                        advice += a_up.ToString();
                        advice += "Loss limit";
                        advice += a_down.ToString();
                        advice += "Buy position ";
                        advice += " And for a situation where the market is declining, the selling position can be taken as a profit margin ";
                        advice += a_down.ToString();
                        advice += "Loss limit";
                        advice += a_up.ToString();
                        #endregion
                    }
                }
                #region Pivot Point
                advice += "Do not trade in the Pivot Point ";
                advice = advice + p1h.ToString() + " , " + p1l.ToString() + ", range";
                advice += "In the area of pivot points, the market can show good support and resistance, but if it loses support or resistance, it will create a lot of chat.";
                #endregion
                #region Show Result
                message = advice;
                tittle = "Analysis";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(message, tittle, buttons);
                #endregion
            }
            else
            {
                MessageBox.Show("Please Enter Value...", "Error");
            }
            #endregion
        }
    }
}
