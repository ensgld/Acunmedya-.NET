namespace WindowsFormHomework
{
    public partial class WindowsFormHomework : Form
    {
       
        public WindowsFormHomework()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bilgilerGoster_Click(object sender, EventArgs e)
        {

            string markaAraba = markaTextBox.Text;
            string modelAraba = modelTextBox.Text;
            string renkAraba = renkTextBox.Text;
            string kapıAraba = kapıTextBox.Text;
            string pencereAraba = pencereTextBox.Text;
            string yakıtAraba = yakıtTextBox.Text;
            string totalStr = "Marka:" + markaAraba + "\nModel:" + modelAraba + "\nRenk:" + renkAraba + "\nKapı Sayısı:" + kapıAraba + "\nPencere Sayısı:" + pencereAraba + "\nYakıt Tüketimi:" + yakıtAraba;
            MessageBox.Show(totalStr, "-Araba Bilgileri-");


        }
    }
}
