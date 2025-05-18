namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbListar = new System.Windows.Forms.ToolStripButton();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCAE = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grbContatos = new System.Windows.Forms.GroupBox();
            this.radEmpresas = new System.Windows.Forms.RadioButton();
            this.radParticulares = new System.Windows.Forms.RadioButton();
            this.mtxtCAE = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtContribuinte = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.grbContatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbGuardar,
            this.tsbListar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(461, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(40, 35);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNovo.ToolTipText = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(57, 35);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.ToolTipText = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(53, 35);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbGuardar.ToolTipText = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbListar
            // 
            this.tsbListar.Image = ((System.Drawing.Image)(resources.GetObject("tsbListar.Image")));
            this.tsbListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbListar.Name = "tsbListar";
            this.tsbListar.Size = new System.Drawing.Size(39, 35);
            this.tsbListar.Text = "Listar";
            this.tsbListar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbListar.ToolTipText = "Listar";
            this.tsbListar.Click += new System.EventHandler(this.tsbListar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(46, 235);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Morada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código postal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Contribuinte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Localidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // lblCAE
            // 
            this.lblCAE.AutoSize = true;
            this.lblCAE.Location = new System.Drawing.Point(253, 405);
            this.lblCAE.Name = "lblCAE";
            this.lblCAE.Size = new System.Drawing.Size(28, 13);
            this.lblCAE.TabIndex = 8;
            this.lblCAE.Text = "CAE";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 235);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(125, 275);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(324, 20);
            this.txtMorada.TabIndex = 11;
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(294, 331);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(155, 20);
            this.txtLocalidade.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(294, 366);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // grbContatos
            // 
            this.grbContatos.Controls.Add(this.radEmpresas);
            this.grbContatos.Controls.Add(this.radParticulares);
            this.grbContatos.Location = new System.Drawing.Point(29, 132);
            this.grbContatos.Name = "grbContatos";
            this.grbContatos.Size = new System.Drawing.Size(315, 58);
            this.grbContatos.TabIndex = 18;
            this.grbContatos.TabStop = false;
            this.grbContatos.Text = "Contatos";
            // 
            // radEmpresas
            // 
            this.radEmpresas.AutoSize = true;
            this.radEmpresas.Location = new System.Drawing.Point(126, 35);
            this.radEmpresas.Name = "radEmpresas";
            this.radEmpresas.Size = new System.Drawing.Size(71, 17);
            this.radEmpresas.TabIndex = 1;
            this.radEmpresas.TabStop = true;
            this.radEmpresas.Text = "Empresas";
            this.radEmpresas.UseVisualStyleBackColor = true;
            // 
            // radParticulares
            // 
            this.radParticulares.AutoSize = true;
            this.radParticulares.Location = new System.Drawing.Point(20, 35);
            this.radParticulares.Name = "radParticulares";
            this.radParticulares.Size = new System.Drawing.Size(80, 17);
            this.radParticulares.TabIndex = 0;
            this.radParticulares.TabStop = true;
            this.radParticulares.Text = "Particulares";
            this.radParticulares.UseVisualStyleBackColor = true;
            // 
            // mtxtCAE
            // 
            this.mtxtCAE.Location = new System.Drawing.Point(294, 402);
            this.mtxtCAE.Name = "mtxtCAE";
            this.mtxtCAE.Size = new System.Drawing.Size(155, 20);
            this.mtxtCAE.TabIndex = 19;
            // 
            // mtxtCP
            // 
            this.mtxtCP.Location = new System.Drawing.Point(125, 331);
            this.mtxtCP.Name = "mtxtCP";
            this.mtxtCP.Size = new System.Drawing.Size(100, 20);
            this.mtxtCP.TabIndex = 20;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(125, 366);
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefone.TabIndex = 21;
            // 
            // mtxtContribuinte
            // 
            this.mtxtContribuinte.Location = new System.Drawing.Point(125, 398);
            this.mtxtContribuinte.Name = "mtxtContribuinte";
            this.mtxtContribuinte.Size = new System.Drawing.Size(100, 20);
            this.mtxtContribuinte.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.mtxtContribuinte);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtCP);
            this.Controls.Add(this.mtxtCAE);
            this.Controls.Add(this.grbContatos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLocalidade);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCAE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Agenda";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbContatos.ResumeLayout(false);
            this.grbContatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbListar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCAE;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grbContatos;
        private System.Windows.Forms.RadioButton radEmpresas;
        private System.Windows.Forms.RadioButton radParticulares;
        private System.Windows.Forms.MaskedTextBox mtxtCAE;
        private System.Windows.Forms.MaskedTextBox mtxtCP;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtContribuinte;
    }
}

