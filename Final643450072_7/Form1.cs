namespace Final643450072_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strdata = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV(*,csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               string filepath = openFileDialog.FileName;
               string data = File.ReadAllText(filepath);
                
                this.listBox1.Items.Add(data);
                
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            textBox1.Text = listBox1.Items[index].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string iitr = textBox2.Text;
            listBox2.Items.Add(str+","+iitr);
            string strx = textBox1.Text;
             
            //for (int i = 0; i < strx.Length; i++)
               // string 
              


            

            //string name = textBox1.Text;
            //string pri
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string dataraw = listBox2.Items[i].ToString();
                string [] datasplied = dataraw.Split(',');
                produgss dadata = new produgss(datasplied[0], datasplied[1], datasplied[2]);
            }

            MessageBox.Show
        }
    }
}