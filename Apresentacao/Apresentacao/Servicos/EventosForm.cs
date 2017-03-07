using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Servicos
{
    public static class EventosForm
    {
        private static void HabilitarForm(IEnumerable controles, bool habilitar)
        {
            foreach (Control control in controles)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == "3")
                    {
                        goto PularControle;
                    }
                }
                //Habilitar ou Desabilitar Controles de acordo com seu TIPO
                var lista = new List<Type>
                {
                    typeof (TextBox),
                    typeof (ComboBox),
                    typeof (MaskedTextBox),
                    typeof (RadioButton),
                    typeof (CheckBox)
                };
                if (lista.Contains(control.GetType()))
                {
                    //Habilitar ou desabilitar controle
                    control.Enabled = habilitar;
                    //No caso de habilitar o formulário, Focalizar controle de TAG 0
                    if (control.Tag != null && habilitar)
                    {
                        if (control.Tag.ToString() == "0")
                        {
                            control.Focus();
                        }
                    }
                }
                else if (control.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)control).ReadOnly = !habilitar;
                }
                else if (control.GetType() == typeof(CheckedListBox))
                {
                    ((CheckedListBox)control).Enabled = !habilitar;
                }
                //Em caso do controle ser TabControl, Selecionar a primeira TabPage
                else if (control.GetType() == typeof(TabControl))
                {
                    ((TabControl)control).SelectedTab = ((TabControl)control).TabPages[0];
                }
            PularControle:
                HabilitarForm(control.Controls, habilitar);
            }
        }
        /// <summary>
        /// Limpar todos os controle. Tag=3 ignora controle. Tag=0 joga o foco padrão.
        /// </summary>
        /// <param name="form">Controle do tipo Container que irá limpar</param>
        public static void HabilitarForm(Form form)
        {
            HabilitarForm(form.Controls, true);
        }
        /// <summary>
        /// Limpar todos os controle. Tag=3 ignora controle. Tag=0 joga o foco padrão.
        /// </summary>
        /// <param name="form">Controle do tipo Container que irá limpar</param>

        public static void HabilitarComandos(Form form)
        {
            HabilitarControles(form.Controls, true);
        }
        /// <summary>
        /// Limpar todos os controle. Tag=3 ignora controle, Tag=0 habilita e joga o foco padrão, Tag=1 habilita, Tag=3 desabilita.
        /// </summary>
        /// <param name="form">Controle do tipo Container que irá limpar</param>
        public static void DesabilitarComandos(Form form)
        {
            HabilitarControles(form.Controls, false);
        }

        /// <summary>
        /// Limpar todos os controle. Tag=3 ignora controle. Tag=1 marca checked=true por padrão.
        /// </summary>
        /// <param name="form">Formulario que ira limpar</param>
        public static void LimparForm(Form form)
        {
            LimparControles(form.Controls);
        }
        private static void HabilitarControles(IEnumerable controles, bool habilitar)
        {
            foreach (Control control in controles)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Tag == null)
                    {
                    }
                    else switch (((Button)control).Tag.ToString())
                        {
                            case "0":
                                control.Enabled = habilitar;
                                control.Focus();
                                break;
                            case "1":
                                control.Enabled = habilitar;
                                break;
                            case "2":
                                control.Enabled = !habilitar;
                                break;
                        }
                }
                HabilitarControles(control.Controls, habilitar);
            }
        }
        /// <summary>
        /// Limpar todos os controle. Tag=3 ignora controle, Tag=0 habilita e joga o foco padrão, Tag=1 habilita, Tag=3 desabilita.
        /// </summary>
        /// <param name="form">Controle do tipo Container que irá limpar</param>
        private static void LimparControles(IEnumerable controles)
        {
            foreach (Control control in controles)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString() == "3")
                    {
                        goto PularControle;
                    }
                }
                if (control.GetType() == typeof(TextBox))
                {
                    if (control.Text != "")
                    {
                        if (IsInt32(control.Text))
                        {
                            control.Text = "";//"0" Estava colocando 0 em campos que não poderiam ter.
                        }
                        else if (IsDouble(control.Text))
                        {
                            control.Text = "0,00";
                        }
                        else
                        {
                            control.Text = "";
                        }
                    }
                }
                else if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).DataSource != null)
                    {
                        ((ComboBox)control).SelectedIndex = -1;
                    }
                    else
                    {
                        ((ComboBox)control).Text = "";
                    }
                }
                else if (control.GetType() == typeof(ListBox))
                {
                    if (((ListBox)control).DataSource != null)
                    {
                        ((ListBox)control).SelectedIndex = -1;
                    }
                    else
                    {
                        ((ListBox)control).Text = "";
                    }
                }
                else if (control.GetType() == typeof(MaskedTextBox))
                {
                    control.Text = "";
                }
                else if (control.GetType() == typeof(RadioButton))
                {
                    if (control.Tag == null)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                    else if (control.Tag.ToString() == "1")
                    {
                        ((RadioButton)control).Checked = true;
                    }
                }
                else if (control.GetType() == typeof(CheckBox))
                {
                    if (control.Tag == null)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                    else if (control.Tag.ToString() == "1")
                    {
                        ((CheckBox)control).Checked = true;
                    }
                }
                else if (control.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)control).Rows.Clear();
                }
                else if (control.GetType() == typeof(CheckedListBox))
                {
                    ((CheckedListBox)control).Items.Clear();
                }
            PularControle:
                LimparControles(control.Controls);
            }
        }
        /// <summary>
        /// Limpar todos os controle. Tag=3 ignora controle. Tag=1 marca checked=true por padrão.
        /// </summary>
        /// <param name="form">Formulario que ira limpar</param>
        /// 
        #region ValidarTipoDeDados
        /// <summary>
        /// Verifica se a string informada contem valor DateTime válido.
        /// </summary>
        public static bool IsDateTime(string dataTimeValor)
        {
            try
            {
                Convert.ToDateTime(dataTimeValor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se a string informada contem valor Int32 válido.
        /// </summary>
        public static bool IsInt32(string int32Valor)
        {
            try
            {
                Convert.ToInt32(int32Valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se a string informada contem valor numérico válido independente do tamanho dele.
        /// </summary>
        public static bool IsNumeric(string valor)
        {
            if (valor.Trim() == "") return false;
            var digitos = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            return valor.All(caracter => digitos.Contains(caracter.ToString()));
        }

        /// <summary>
        /// Verifica se a string informada contem valor Double válido.
        /// </summary>
        public static bool IsDouble(string doubleValor)
        {
            try
            {
                Convert.ToDouble(doubleValor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se a string informada contem valor Decimal válido.
        /// </summary>
        public static bool IsDecimal(string decimalValor)
        {
            try
            {
                Convert.ToDecimal(decimalValor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se a string informada contem valor Single válido.
        /// </summary>
        public static bool IsSingle(string singleValor)
        {
            try
            {
                Convert.ToSingle(singleValor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool NuloOuVazio(object obj)
        {
            if (obj == null)
            {
                return true;
            }
            return obj.ToString() == "";
        }
        #endregion
    }
}
