
namespace DotnetCoreGravarDadosWMySQLWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list_contatos = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(13, 32);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(245, 23);
            this.textNome.TabIndex = 3;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(14, 76);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(245, 23);
            this.textTelefone.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 120);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(245, 23);
            this.textEmail.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_contatos
            // 
            this.list_contatos.ContextMenuStrip = this.contextMenuStrip1;
            this.list_contatos.HideSelection = false;
            this.list_contatos.Location = new System.Drawing.Point(265, 32);
            this.list_contatos.MultiSelect = false;
            this.list_contatos.Name = "list_contatos";
            this.list_contatos.Size = new System.Drawing.Size(584, 470);
            this.list_contatos.TabIndex = 7;
            this.list_contatos.UseCompatibleStateImageBehavior = false;
            this.list_contatos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.list_contatos_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleDescription = "Excluir Item";
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem1.Text = "Excluir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar na tabela";
            // 
            // textBusca
            // 
            this.textBusca.Location = new System.Drawing.Point(364, 5);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(369, 23);
            this.textBusca.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(245, 37);
            this.button4.TabIndex = 12;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 514);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBusca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_contatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tabela de Colaboradores";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView list_contatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button4;
    }
}

