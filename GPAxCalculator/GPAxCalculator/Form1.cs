namespace GPAxCalculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPACal = new GPACalculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getMax();
            textBoxGPAx.Text = gpax.ToString();

            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = max.ToString();
            string maxname = oGPACal.getMaxName();
            textBoxMaxName.Text = maxname.ToString();

            double min = oGPACal.getMin();
            textBoxMinGPA.Text = min.ToString();
            string minname = oGPACal.getMinName();
            textBoxMinName.Text = minname.ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = "";
            textBoxAllData.Text = oGPACal.getAllData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxAllData.Text = "";
            textBoxMinName.Text = "";
            textBoxMaxName.Text = "";
        }
    }
}