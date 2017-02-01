using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Componentes
{
    public class CaixaTexto : TextBox
    {
        public TipoTextBox Tipo { get; set; }
        public string Entidade { get; set; }
        public string Campo { get; set; }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch (Tipo)
            {
                case TipoTextBox.Inteira:
                    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                    {
                        e.Handled = true;
                    }
                    break;
                case TipoTextBox.Decimal:
                    if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
                    {
                        e.Handled = true;
                    }
                    break;
                case TipoTextBox.Monetaria:
                    if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
                    {
                        e.Handled = true;
                    }
                    break;
                case TipoTextBox.Texto:
                    break;
                default:
                    break;
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            switch (Tipo)
            {
                case TipoTextBox.Inteira:
                    this.Text = Convert.ToInt64("0" + this.Text).ToString();
                    break;
                case TipoTextBox.Decimal:
                    this.Text = Convert.ToInt64("0" + this.Text).ToString("0.00#,##");
                    break;
                case TipoTextBox.Monetaria:
                    this.Text = Convert.ToInt64("0" + this.Text).ToString("0.00#,##");
                    break;
                case TipoTextBox.Texto:
                    break;
                default:
                    break;
            }
        }
    }

    public enum TipoTextBox
    {
        Inteira,
        Decimal,
        Monetaria,
        Texto
    }
}


