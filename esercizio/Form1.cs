using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string Parola = txt_n1.Text;
            int Lunghezza = txt_n1.TextLength, ContaVocali = 0;
            for(int i = 0;i < Lunghezza;i++)
            {
                if (Parola[i] == 'a' || Parola[i] == 'e' || Parola[i] == 'i' || Parola[i] == 'o' || Parola[i] == 'u')
                {
                    ContaVocali = ContaVocali + 1;
                }
            }
            lbl_n2.Text = "Il numero di vocali è " + ContaVocali;
        }
    }
}
