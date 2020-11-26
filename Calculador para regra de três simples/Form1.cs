using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mat2Forms
{
  public partial class Form1 : Form
  {
    int n1, n2, n3, res;
    string n1S, n2S, n3S;
    bool n1B = false, n2B = false, n3B = false, inv = false;

    private void Btn_2_Click(object sender, EventArgs e)
    {
      setNums("2");
    }

    private void Btn_3_Click(object sender, EventArgs e)
    {
      setNums("3");
    }

    private void Btn_4_Click(object sender, EventArgs e)
    {
      setNums("4");
    }

    private void Btn_5_Click(object sender, EventArgs e)
    {
      setNums("5");
    }

    private void Btn_6_Click(object sender, EventArgs e)
    {
      setNums("6");
    }

    private void Btn_7_Click(object sender, EventArgs e)
    {
      setNums("7");
    }

    private void Btn_8_Click(object sender, EventArgs e)
    {
      setNums("8");
    }

    private void Btn_9_Click(object sender, EventArgs e)
    {
      setNums("9");
    }

    private void Btn_0_Click(object sender, EventArgs e)
    {
      setNums("0");
    }

    private void Btn_Inverse_Click(object sender, EventArgs e)
    {
      if (!inv) inv = true;
      else inv = false;
      n1 = Convert.ToInt32(n1S);
      n2 = Convert.ToInt32(n2S);
      n3 = Convert.ToInt32(n3S);
      if (inv) res = n1 * n2 / n3;
      else res = n2 * n3 / n1;
      Btn_Result.Text = Convert.ToString(res);
    }

    private void Btn_Result_Click(object sender, EventArgs e)
    {
      n1 = Convert.ToInt32(n1S);
      n2 = Convert.ToInt32(n2S);
      n3 = Convert.ToInt32(n3S);
      if (inv) res = n1 * n2 / n3;
      else res = n2 * n3 / n1;
      Btn_Result.Text = Convert.ToString(res);
    }

    private void Btn_1_Click(object sender, EventArgs e)
    {
      setNums("1");
    }

    private void Btn_N3_Click(object sender, EventArgs e)
    {
      if (n3B)
      {
        n3S = "";
      }
      n1B = false; n2B = false; n3B = true;
      Btn_N3.Text = n3S;
    }

    private void Btn_N2_Click(object sender, EventArgs e)
    {
      if (n2B)
      {
        n2S = "";
      }
      n1B = false; n2B = true; n3B = false;
      Btn_N2.Text = n2S;
    }

    private void Btn_N1_Click(object sender, EventArgs e)
    {
      if (n1B)
      {
        n1S = "";
      }
      n1B = true; n2B = false; n3B = false;
      Btn_N1.Text = n2S;
    }

    public Form1()
    {
      InitializeComponent();
    }

    private void Btn_Close_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void setNums(string numV)
    {
      if (n1B)
      {
        n1S += numV;
        Btn_N1.Text = n1S;
      }
      if (n2B)
      {
        n2S += numV;
        Btn_N2.Text = n2S;
      }
      if (n3B)
      {
        n3S += numV;
        Btn_N3.Text = n3S;
      }
    }
  }
}
