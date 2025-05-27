using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listaParticulares.Clear();
            listaEmpresas.Clear();

            if (!File.Exists("clientes.txt"))
                return;

            foreach (var line in File.ReadAllLines("clientes.txt"))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 8)
                    continue;

                if (parts[0] == "P" && parts.Length == 8)
                {
                    var particular = new Particular
                    {
                        nome = parts[1],
                        morada = parts[2],
                        cp = parts[3],
                        localidade = parts[4],
                        telefone = int.Parse(parts[5]),
                        email = parts[6],
                        contribuinte = int.Parse(parts[7])
                    };
                    listaParticulares.Add(particular);
                }
                else if (parts[0] == "E" && parts.Length == 9)
                {
                    var empresa = new Empresa
                    {
                        nome = parts[1],
                        morada = parts[2],
                        cp = parts[3],
                        localidade = parts[4],
                        telefone = int.Parse(parts[5]),
                        email = parts[6],
                        contribuinte = int.Parse(parts[7]),
                        cae = int.TryParse(parts[8], out int caeVal) ? caeVal : 0
                    };
                    listaEmpresas.Add(empresa);
                }
            }
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
            Novo();
        }

        private void Novo()
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
            AtivarControlos(false);
            BarraMenu(true);
            grbContatos.Enabled = true;
            Limpar();
            lblCAE.Visible = radEmpresas.Checked;
            mtxtCAE.Visible = radEmpresas.Checked;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            GuardarEmFicheiro();
        }

        private void GuardarEmFicheiro()
        {
            using (StreamWriter sw = new StreamWriter("clientes.txt"))
            {
                // Gravar Particulares
                foreach (var cliente in listaParticulares)
                {
                    sw.WriteLine(
                        $"P;{cliente.nome};{cliente.morada};{cliente.cp};" +
                        $"{cliente.localidade};{cliente.telefone};{cliente.email};" +
                        $"{cliente.contribuinte}"
                    );
                }

                // Gravar Empresas
                foreach (var cliente in listaEmpresas)
                {
                    sw.WriteLine(
                        $"E;{cliente.nome};{cliente.morada};{cliente.cp};" +
                        $"{cliente.localidade};{cliente.telefone};{cliente.email};" +
                        $"{cliente.contribuinte};{cliente.cae}"
                    );
                }
            }
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
