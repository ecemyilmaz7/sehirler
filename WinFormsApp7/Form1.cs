namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*listBox2.Items.Add("Cherry");
            listBox2.Items.Add("Bently");
            listBox2.Items.Add("Ford");

            string[] Cars = { "Fiat", "Porche", "Bugatti" };
            listBox2.Items.AddRange(Cars);*/
            /*List<string> list = new List<string> {"Mercedes", "Porche", "Ferrari" };
            listBox2.DataSource = list;*/
            Dictionary<int, string> iller = new Dictionary<int, string>();
            iller.Add(01, "Adana");
            iller.Add(02, "Adýyaman");
            iller.Add(03, "Afyonkarahisar");
            iller.Add(04, "Aðrý");
            iller.Add(05, "Amasya");
            iller.Add(06, "Ankara");
            iller.Add(07, "Antalya");
            iller.Add(08, "Artvin");
            iller.Add(09, "Aydýn");
            iller.Add(10, "Balýkesir");
            iller.Add(11, "Bilecik");
            iller.Add(12, "Bingöl");
            iller.Add(13, "Bitlis");
            iller.Add(14, "Bolu");
            iller.Add(15, "Burdur");
            iller.Add(16, "Bursa");
            iller.Add(17, "Çanakkale");
            iller.Add(18, "Çankýrý");
            iller.Add(19, "Çorum");
            iller.Add(20, "Denizli");

            foreach (KeyValuePair<int, string> il in iller)
            {
                listBox2.Items.Add($"{il.Key:D2} - {il.Value}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void Kaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text);
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                listBox2.Items.Add(textBox1.Text);
            }
        }
    }
}
