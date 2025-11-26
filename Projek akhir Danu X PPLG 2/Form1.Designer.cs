
namespace Projek_akhir_Danu_X_PPLG_2
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            P = new DataGridViewTextBoxColumn();
            H = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            PK = new DataGridViewTextBoxColumn();
            JM = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            tgl = new DataGridViewTextBoxColumn();
            txtBayar = new TextBox();
            label9 = new Label();
            txtTotal = new TextBox();
            label8 = new Label();
            button3 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(487, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 26);
            label1.TabIndex = 0;
            label1.Text = "PRE ORDER PAKAIAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(27, 108);
            label4.Name = "label4";
            label4.Size = new Size(95, 22);
            label4.TabIndex = 3;
            label4.Text = "PAKAIAN";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(18, 153);
            label5.Name = "label5";
            label5.Size = new Size(98, 22);
            label5.TabIndex = 4;
            label5.Text = "JUMLAH :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(18, 206);
            label7.Name = "label7";
            label7.Size = new Size(101, 22);
            label7.TabIndex = 6;
            label7.Text = "TANGGAL";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(27, 253);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "PESAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(217, 253);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "BATAL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kaos", "Kemeja", "Hoodie", "Celana", "Sepatu" });
            comboBox2.Location = new Point(217, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(217, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(217, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { P, H });
            dataGridView1.Location = new Point(18, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // P
            // 
            P.HeaderText = "Pakaian";
            P.MinimumWidth = 8;
            P.Name = "P";
            P.ReadOnly = true;
            P.Width = 150;
            // 
            // H
            // 
            H.HeaderText = "Harga";
            H.MinimumWidth = 8;
            H.Name = "H";
            H.ReadOnly = true;
            H.Width = 150;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.DarkGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { PK, JM, harga, tgl });
            dataGridView2.Location = new Point(487, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(669, 130);
            dataGridView2.TabIndex = 24;
            // 
            // PK
            // 
            PK.HeaderText = "Pakaian";
            PK.MinimumWidth = 8;
            PK.Name = "PK";
            PK.ReadOnly = true;
            PK.Width = 150;
            // 
            // JM
            // 
            JM.HeaderText = "Jumlah Barang";
            JM.MinimumWidth = 8;
            JM.Name = "JM";
            JM.ReadOnly = true;
            JM.Width = 150;
            // 
            // harga
            // 
            harga.HeaderText = "Harga";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            harga.ReadOnly = true;
            harga.Width = 150;
            // 
            // tgl
            // 
            tgl.HeaderText = "Tanggal";
            tgl.MinimumWidth = 8;
            tgl.Name = "tgl";
            tgl.ReadOnly = true;
            tgl.Width = 150;
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(250, 143);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(150, 31);
            txtBayar.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(259, 103);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 8;
            label9.Text = "Uang Pelanggan";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(244, 55);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 31);
            txtTotal.TabIndex = 16;
            txtTotal.Text = "0";
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(299, 27);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 7;
            label8.Text = "Total";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 0);
            button3.Location = new Point(6, 185);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 25;
            button3.Text = "Bayar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(190, 194);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 26;
            label2.Text = "Kembalian";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBayar);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(664, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 278);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pembayaran!!!";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1158, 607);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException( ); 
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button1;
        private Button button2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn P;
        private DataGridViewTextBoxColumn H;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn PK;
        private DataGridViewTextBoxColumn JM;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn tgl;
        private TextBox txtBayar;
        private Label label9;
        private TextBox txtTotal;
        private Label label8;
        private Button button3;
        private Label label2;
        private GroupBox groupBox1;
    }
}
