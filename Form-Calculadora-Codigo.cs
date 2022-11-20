using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        private void Um_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void Ponto_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
                txtResultado.Text += ".";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;            
            }
            txtResultado.Text = Convert.ToString(Resultado);

        }

        private void Divisão_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text += "/";
        }

        private void Adição_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text += "+";
        }

        private void Subtração_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text += "-";
        }

        private void Multiplicação_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text += "x";
        }

        private void DesligaLiga_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

    }
}
