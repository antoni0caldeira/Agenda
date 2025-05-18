using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        List<Particular> listaParticulares = new List<Particular>();
        List<Empresa> listaEmpresas = new List<Empresa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerControlos(true);
            BarraMenu(true);
            AtivarControlos(false);
            LerDoFicheiro();
        }

        private void LerDoFicheiro()
        {
            throw new NotImplementedException();
        }

        public void AtivarControlos(bool estado)
        {
            txtNome.Enabled = estado;
            txtMorada.Enabled = estado;
            mtxtCP.Enabled = estado;
            txtLocalidade.Enabled = estado;
            mtxtTelefone.Enabled = estado;
            txtEmail.Enabled = estado;
            mtxtContribuinte.Enabled = estado;
            mtxtCAE.Enabled = estado;
        }

        public void Limpar()
        {
            txtNome.ResetText();
            txtMorada.ResetText();
            mtxtCP.ResetText();
            txtLocalidade.ResetText();
            mtxtTelefone.ResetText();
            txtEmail.ResetText();
            mtxtContribuinte.ResetText();
            mtxtCAE.ResetText();
        }



        private void BarraMenu(bool estado)
        {
            tsbNovo.Enabled = estado;
            tsbCancelar.Enabled = !estado;
            tsbGuardar.Enabled = !estado;
            tsbListar.Enabled = estado;

        }

        private void VerControlos(bool estado)
        {
            lblCAE.Visible = estado;
            lblCAE.Visible = estado;
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            AtivarControlos(true);
            BarraMenu(false);
            grbContatos.Enabled = false;
            lblCAE.Visible = radEmpresas.Checked;
            mtxtCAE.Visible = radEmpresas.Checked;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            throw new NotImplementedException();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            throw new NotImplementedException();
        }

        private void tsbListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            throw new NotImplementedException();
        }
    }
}
