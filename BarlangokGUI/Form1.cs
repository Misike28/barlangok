namespace BarlangokGUI
{
    public partial class Form1 : Form
    {
        int azonosito;
        List<Barlang> list = new List<Barlang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btsave.Enabled = false;
            FileStream fs = new FileStream("..\\..\\..\\src\\barlangok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Barlang b = new Barlang(sr.ReadLine());
                list.Add(b);
            }

            sr.Close();
            fs.Close();
        }

        private void btsrc_Click(object sender, EventArgs e)
        {
            bool van = false;
            foreach (Barlang b in list)
            {
                if (Convert.ToInt32(txid.Text) == b.Azon)
                {
                    van = true;
                    lbnev.Text = lbnev.Text + b.Nev;
                    txhossz.Text = Convert.ToString(b.Hossz);
                    txmely.Text = Convert.ToString(b.Melyseg);
                    btsave.Enabled = true;
                    azonosito = b.Azon;
                }
            }
            if (van == false)
            {
                MessageBox.Show("Ezzel az azonos�t�val nem l�tezik m�g barlang!");
                btsave.Enabled=false;
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (list[azonosito].Hossz > Convert.ToInt32(txhossz.Text))
            {
                MessageBox.Show("A hossz�s�g nem lehet kissebb a kor�bbi �rt�kn�l!");
            }
            else if (list[azonosito].Melyseg > Convert.ToInt32(txmely.Text))
            {
                MessageBox.Show("A m�lys�g nem lehet kissebb a kor�bbi �rt�kn�l!");
            }
            else
            {
                list[azonosito].Hossz = Convert.ToInt32(txhossz.Text);
                list[azonosito].Melyseg = Convert.ToInt32(txmely.Text);
            }
            txid.Clear();
            lbnev.Text = "Barlang neve: ";
            txhossz.Clear();
            txmely.Clear();
        }
    }
}
