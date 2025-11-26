namespace Projek_akhir_Danu_X_PPLG_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Kaos", "150.000");
            dataGridView1.Rows.Add("Kemaja", "160.000");
            dataGridView1.Rows.Add("Hoodie", "300.00");
            dataGridView1.Rows.Add("Celana", "200.000");
            dataGridView1.Rows.Add("Sepatu", "500.000");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pakaian = comboBox2.SelectedItem?.ToString();
            string jumlah = comboBox1.SelectedItem?.ToString();
            string tanggal = dateTimePicker1.Text;
            int harga = 0;
            /*
             Kaos
Kemeja
Hoodie
Celana
Sepatu*/
            if (pakaian == "Kaos") harga = 150000 * Convert.ToInt32(jumlah);
            if (pakaian == "Kemeja") harga = 160000 * Convert.ToInt32(jumlah);
            if (pakaian == "Hoodie") harga = 300000 * Convert.ToInt32(jumlah);
            if (pakaian == "Celana") harga = 200000 * Convert.ToInt32(jumlah);
            if (pakaian == "Sepatu") harga = 500000 * Convert.ToInt32(jumlah);
            dataGridView2.Rows.Add(pakaian, jumlah, harga, tanggal);
            int total_harga = harga;

            txtTotal.Text = $"{Convert.ToInt32(txtTotal.Text) + harga}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            else
                MessageBox.Show("Silahkan Masukan Barang yang Anda Beli !!!");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Menghitung Uang kembalian
            if (!string.IsNullOrEmpty(txtBayar.Text))
            {
                if (Convert.ToDouble(txtBayar.Text) < Convert.ToDouble(txtTotal.Text))
                {
                    MessageBox.Show("Uangnya Kurang!!!");
                    return;
                }

                double Kembalian = Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text);
                label2.Text = $"Kembalian: {Kembalian}";
            }
            else MessageBox.Show("Total Bayar tidak dapat tedefinisikan");
            return;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
