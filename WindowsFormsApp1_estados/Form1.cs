using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_estados
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void v_Load(object sender, EventArgs e)
        {
           
        }

       private void bnttodos_Click(object sender, EventArgs e)
        {
            lbltodos.Text = cbTodos.Items.Count.ToString();
            if (cbTodos.SelectedIndex != -1)
           {
               string estado = cbTodos.SelectedItem.ToString();


               
                if(estado == "Acre" || estado == "Amazonas" || estado == "Pará" || estado == "Rondônia" || estado == "Roraima" || estado == "Tocantins" || estado == "Amapá")
                {
                    cbNorte.Items.Add(estado);
                    cbTodos.Items.Remove(cbTodos.SelectedItem);
                    lblnorte.Text = cbNorte.Items.Count.ToString();
                    lbltodos.Text = cbTodos.Items.Count.ToString();
                }
                else if (estado == "Alagoas" || estado == "Bahia" || estado == "Ceará" || estado == "Maranhão" || estado == "Paraíba" || estado == "Pernambuco" || estado == "Piauí" || estado == "Rio Grande do Norte" || estado == "Sergipe")
                {
                    cbnordeste.Items.Add(estado);
                    cbTodos.Items.Remove(cbTodos.SelectedItem);
                    lblnordeste.Text = cbnordeste.Items.Count.ToString();
                    lbltodos.Text = cbTodos.Items.Count.ToString();
                }
                else if (estado == "Goiás" || estado == "Mato Grosso" || estado == "Mato Grosso do Sul" || estado == "Distrito Federal")
                {
                    cbcentro.Items.Add(estado);
                    cbTodos.Items.Remove(cbTodos.SelectedItem);
                    lblcentro.Text = cbcentro.Items.Count.ToString();
                    lbltodos.Text = cbTodos.Items.Count.ToString();

                }
                else if (estado == "Espírito Santo" || estado == "Minas Gerais" || estado == "Rio de Janeiro" || estado == "São Paulo")
                {
                    cbsudeste.Items.Add(estado);
                    cbTodos.Items.Remove(cbTodos.SelectedItem);
                    lblsudeste.Text = cbsudeste.Items.Count.ToString();
                    lbltodos.Text = cbTodos.Items.Count.ToString();

                }
                else if (estado == "Paraná" || estado == "Rio Grande do Sul" || estado == "Santa Catarina")
                {
                    cbsul.Items.Add(estado);
                    cbTodos.Items.Remove(cbTodos.SelectedItem);
                    lblsul.Text = cbsul.Items.Count.ToString();
                    lbltodos.Text = cbTodos.Items.Count.ToString();
                }



            }
        }

        private void bntnorte_Click(object sender, EventArgs e)
        {
            if (cbNorte.SelectedIndex != -1)
            {
                string estado = cbNorte.SelectedItem.ToString();
                cbTodos.Items.Add(estado);
                cbNorte.Items.Remove(cbNorte.SelectedItem);
                lbltodos.Text = cbTodos.Items.Count.ToString();
                lblnorte.Text = cbNorte.Items.Count.ToString();
                
                cbNorte.ResetText();
            }
       }

        private void bntnordeste_Click(object sender, EventArgs e)
        {
            if (cbnordeste.SelectedIndex != -1)
            {
                string estado = cbnordeste.SelectedItem.ToString();
                cbTodos.Items.Add(estado);
                cbnordeste.Items.Remove(cbnordeste.SelectedItem);
                lblnordeste.Text = cbnordeste.Items.Count.ToString();
                lbltodos.Text = cbTodos.Items.Count.ToString();
                cbnordeste.ResetText();
            }
        }

        private void bntcentro_Click(object sender, EventArgs e)
        {
             if (cbcentro.SelectedIndex != -1)
            { string estado = cbcentro.SelectedItem.ToString();
                cbTodos.Items.Add(estado);
                cbcentro.Items.Remove(cbcentro.SelectedItem);
                lblcentro.Text = cbcentro.Items.Count.ToString();
                lbltodos.Text = cbTodos.Items.Count.ToString();
                cbcentro.ResetText();
            }
        }

        private void bntsudeste_Click(object sender, EventArgs e)
        {
            if (cbsudeste.SelectedIndex != -1)
            {
                string estado = cbsudeste.SelectedItem.ToString();
                cbTodos.Items.Add(estado);
                cbsudeste.Items.Remove(cbsudeste.SelectedItem);
                lblnordeste.Text = cbnordeste.Items.Count.ToString();
                lbltodos.Text = cbTodos.Items.Count.ToString();
                cbsudeste.ResetText();
            }
        }

        private void bntsul_Click(object sender, EventArgs e)
        {
            if (cbsul.SelectedIndex != -1)
            { string estado = cbsul.SelectedItem.ToString();
                cbTodos.Items.Add(estado);
                cbsul.Items.Remove(cbsul.SelectedItem);
                lblsul.Text = cbsul.Items.Count.ToString();
                lbltodos.Text = cbTodos.Items.Count.ToString();
                cbsul.ResetText();  
            }
        }
    }

       


    }

