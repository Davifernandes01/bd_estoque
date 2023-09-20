namespace WinFormsApp1
{
    partial class FormLiSTAProdutos
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
            label_nome = new Label();
            label2_desc = new Label();
            label_quant = new Label();
            label_precoUni = new Label();
            label_data_entrada = new Label();
            label_data_saida = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1_atualizar = new Button();
            button_deletar = new Button();
            button_sair = new Button();
            list_produtos = new ListView();
            label1 = new Label();
            button_listar = new Button();
            SuspendLayout();
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Location = new Point(19, 115);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(40, 15);
            label_nome.TabIndex = 1;
            label_nome.Text = "Nome";
            // 
            // label2_desc
            // 
            label2_desc.AutoSize = true;
            label2_desc.Location = new Point(19, 152);
            label2_desc.Name = "label2_desc";
            label2_desc.Size = new Size(58, 15);
            label2_desc.TabIndex = 2;
            label2_desc.Text = "Descrição";
            // 
            // label_quant
            // 
            label_quant.AutoSize = true;
            label_quant.Location = new Point(19, 191);
            label_quant.Name = "label_quant";
            label_quant.Size = new Size(69, 15);
            label_quant.TabIndex = 3;
            label_quant.Text = "Quantidade";
            // 
            // label_precoUni
            // 
            label_precoUni.AutoSize = true;
            label_precoUni.Location = new Point(19, 225);
            label_precoUni.Name = "label_precoUni";
            label_precoUni.Size = new Size(63, 15);
            label_precoUni.TabIndex = 4;
            label_precoUni.Text = "Preço_unit";
            // 
            // label_data_entrada
            // 
            label_data_entrada.AutoSize = true;
            label_data_entrada.Location = new Point(19, 258);
            label_data_entrada.Name = "label_data_entrada";
            label_data_entrada.Size = new Size(76, 15);
            label_data_entrada.TabIndex = 5;
            label_data_entrada.Text = "Data_entrada";
            // 
            // label_data_saida
            // 
            label_data_saida.AutoSize = true;
            label_data_saida.Location = new Point(19, 287);
            label_data_saida.Name = "label_data_saida";
            label_data_saida.Size = new Size(63, 15);
            label_data_saida.TabIndex = 6;
            label_data_saida.Text = "Data_saida";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(98, 287);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(128, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // button1_atualizar
            // 
            button1_atualizar.Location = new Point(2, 407);
            button1_atualizar.Name = "button1_atualizar";
            button1_atualizar.Size = new Size(75, 23);
            button1_atualizar.TabIndex = 13;
            button1_atualizar.Text = "Atualizar";
            button1_atualizar.UseVisualStyleBackColor = true;
            // 
            // button_deletar
            // 
            button_deletar.Location = new Point(83, 407);
            button_deletar.Name = "button_deletar";
            button_deletar.Size = new Size(75, 23);
            button_deletar.TabIndex = 14;
            button_deletar.Text = "Deletar";
            button_deletar.UseVisualStyleBackColor = true;
            // 
            // button_sair
            // 
            button_sair.Location = new Point(164, 407);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(75, 23);
            button_sair.TabIndex = 15;
            button_sair.Text = "Sair";
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += button_sair_Click;
            // 
            // list_produtos
            // 
            list_produtos.Location = new Point(257, 75);
            list_produtos.Name = "list_produtos";
            list_produtos.Size = new Size(631, 334);
            list_produtos.TabIndex = 16;
            list_produtos.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 17;
            label1.Text = "Lista de produtos";
            // 
            // button_listar
            // 
            button_listar.Location = new Point(804, 35);
            button_listar.Name = "button_listar";
            button_listar.Size = new Size(75, 23);
            button_listar.TabIndex = 18;
            button_listar.Text = "buscar";
            button_listar.UseVisualStyleBackColor = true;
            button_listar.Click += button_listar_Click;
            // 
            // FormLiSTAProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(button_listar);
            Controls.Add(label1);
            Controls.Add(list_produtos);
            Controls.Add(button_sair);
            Controls.Add(button_deletar);
            Controls.Add(button1_atualizar);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_data_saida);
            Controls.Add(label_data_entrada);
            Controls.Add(label_precoUni);
            Controls.Add(label_quant);
            Controls.Add(label2_desc);
            Controls.Add(label_nome);
            Name = "FormLiSTAProdutos";
            Text = "Lista de produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_nome;
        private Label label2_desc;
        private Label label_quant;
        private Label label_precoUni;
        private Label label_data_entrada;
        private Label label_data_saida;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1_atualizar;
        private Button button_deletar;
        private Button button_sair;
        private ListView list_produtos;
        private Label label1;
        private Button button_listar;
    }
}