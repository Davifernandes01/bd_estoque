namespace WinFormsApp1
{
    partial class Form2Fornecedores
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
            groupBox1 = new GroupBox();
            label1_cont = new Label();
            button_fornece_salv = new Button();
            label_contato = new Label();
            textBox_nome_forne = new TextBox();
            textBox_contato = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            button2_att = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2_att);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox_contato);
            groupBox1.Controls.Add(textBox_nome_forne);
            groupBox1.Controls.Add(label_contato);
            groupBox1.Controls.Add(button_fornece_salv);
            groupBox1.Controls.Add(label1_cont);
            groupBox1.Location = new Point(28, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 345);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar fornecedores";
            // 
            // label1_cont
            // 
            label1_cont.AutoSize = true;
            label1_cont.Location = new Point(25, 63);
            label1_cont.Name = "label1_cont";
            label1_cont.Size = new Size(40, 15);
            label1_cont.TabIndex = 0;
            label1_cont.Text = "Nome";
            label1_cont.Click += label1_Click;
            // 
            // button_fornece_salv
            // 
            button_fornece_salv.Location = new Point(25, 278);
            button_fornece_salv.Name = "button_fornece_salv";
            button_fornece_salv.Size = new Size(75, 23);
            button_fornece_salv.TabIndex = 1;
            button_fornece_salv.Text = "Salvar";
            button_fornece_salv.UseVisualStyleBackColor = true;
            // 
            // label_contato
            // 
            label_contato.AutoSize = true;
            label_contato.Location = new Point(25, 105);
            label_contato.Name = "label_contato";
            label_contato.Size = new Size(50, 15);
            label_contato.TabIndex = 2;
            label_contato.Text = "Contato";
            // 
            // textBox_nome_forne
            // 
            textBox_nome_forne.Location = new Point(89, 55);
            textBox_nome_forne.Name = "textBox_nome_forne";
            textBox_nome_forne.Size = new Size(100, 23);
            textBox_nome_forne.TabIndex = 3;
            // 
            // textBox_contato
            // 
            textBox_contato.Location = new Point(89, 97);
            textBox_contato.Name = "textBox_contato";
            textBox_contato.Size = new Size(100, 23);
            textBox_contato.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(152, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Contato });
            dataGridView1.Location = new Point(410, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(239, 317);
            dataGridView1.TabIndex = 6;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Contato
            // 
            Contato.HeaderText = "Contato";
            Contato.Name = "Contato";
            // 
            // button2_att
            // 
            button2_att.Location = new Point(272, 278);
            button2_att.Name = "button2_att";
            button2_att.Size = new Size(75, 23);
            button2_att.TabIndex = 7;
            button2_att.Text = "Atualizar";
            button2_att.UseVisualStyleBackColor = true;
            // 
            // Form2Fornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2Fornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1_cont;
        private Label label_contato;
        private Button button_fornece_salv;
        private TextBox textBox_contato;
        private TextBox textBox_nome_forne;
        private Button button2_att;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Contato;
        private Button button1;
    }
}