namespace WinFormsApp1
{
    partial class FormVendas
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox_vendas = new ComboBox();
            button_voltar = new Button();
            button_vendas = new Button();
            monthCalendar1 = new MonthCalendar();
            dateTime_vendas = new DateTimePicker();
            textBox3 = new TextBox();
            label_date = new Label();
            label_valor = new Label();
            label_produto = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox_vendas);
            groupBox1.Controls.Add(button_voltar);
            groupBox1.Controls.Add(button_vendas);
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Controls.Add(dateTime_vendas);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label_date);
            groupBox1.Controls.Add(label_valor);
            groupBox1.Controls.Add(label_produto);
            groupBox1.Location = new Point(26, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vendas dos produtos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 120);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 12;
            label1.Text = "Quantidade a vender";
            // 
            // comboBox_vendas
            // 
            comboBox_vendas.FormattingEnabled = true;
            comboBox_vendas.Location = new Point(151, 74);
            comboBox_vendas.Name = "comboBox_vendas";
            comboBox_vendas.Size = new Size(121, 23);
            comboBox_vendas.TabIndex = 11;
            comboBox_vendas.SelectedIndexChanged += comboBox_vendas_SelectedIndexChanged;
            // 
            // button_voltar
            // 
            button_voltar.Location = new Point(219, 315);
            button_voltar.Name = "button_voltar";
            button_voltar.Size = new Size(75, 23);
            button_voltar.TabIndex = 10;
            button_voltar.Text = "Voltar";
            button_voltar.UseVisualStyleBackColor = true;
            button_voltar.Click += button_voltar_Click;
            // 
            // button_vendas
            // 
            button_vendas.Location = new Point(42, 315);
            button_vendas.Name = "button_vendas";
            button_vendas.Size = new Size(75, 23);
            button_vendas.TabIndex = 9;
            button_vendas.Text = "Vender";
            button_vendas.UseVisualStyleBackColor = true;
            button_vendas.Click += button_vendas_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(432, 28);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // dateTime_vendas
            // 
            dateTime_vendas.Location = new Point(151, 190);
            dateTime_vendas.Name = "dateTime_vendas";
            dateTime_vendas.Size = new Size(200, 23);
            dateTime_vendas.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(21, 199);
            label_date.Name = "label_date";
            label_date.Size = new Size(31, 15);
            label_date.TabIndex = 3;
            label_date.Text = "Data";
            // 
            // label_valor
            // 
            label_valor.AutoSize = true;
            label_valor.Location = new Point(21, 160);
            label_valor.Name = "label_valor";
            label_valor.Size = new Size(33, 15);
            label_valor.TabIndex = 2;
            label_valor.Text = "Valor";
            // 
            // label_produto
            // 
            label_produto.AutoSize = true;
            label_produto.Location = new Point(19, 82);
            label_produto.Name = "label_produto";
            label_produto.Size = new Size(50, 15);
            label_produto.TabIndex = 0;
            label_produto.Text = "Produto";
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque - Retirada";
            Load += FormVendas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label_date;
        private Label label_valor;
        private Label label_produto;
        private TextBox textBox3;
        private Button button_voltar;
        private Button button_vendas;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTime_vendas;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox_vendas;
        private TextBox textBox1;
        private Label label1;
    }
}