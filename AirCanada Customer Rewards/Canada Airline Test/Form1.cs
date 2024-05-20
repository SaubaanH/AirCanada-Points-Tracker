namespace Canada_Airline_Test
{
    public partial class Form1 : Form
    {
        List<Passenger> passengerList = new List<Passenger>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            passengerList.Add(new Passenger(firstNameTextbox.Text, lastNameTextbox.Text, Convert.ToInt32(weekTextbox1.Text), Convert.ToInt32(weekTextbox2.Text), Convert.ToInt32(weekTextbox3.Text), Convert.ToInt32(weekTextbox4.Text)));
            firstNameTextbox.Clear();
            lastNameTextbox.Clear();
            weekTextbox1.Clear();
            weekTextbox2.Clear();
            weekTextbox3.Clear();
            weekTextbox4.Clear();

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            displayTextbox.Clear();
            foreach (Passenger x in passengerList)
            {

                int sum = x.week1 + x.week2 + x.week3 + x.week4;
                displayTextbox.AppendText("Name: " + x.firstName + " " + x.lastName);
                displayTextbox.AppendText(Environment.NewLine);
                displayTextbox.AppendText("Total Points: " + sum.ToString());
                displayTextbox.AppendText(Environment.NewLine);
                if (sum >= 7000)
                {
                    displayTextbox.AppendText("Eligible for Extra Points");

                }
                else
                {
                    displayTextbox.AppendText("No Extra Points");
                }
                displayTextbox.AppendText(Environment.NewLine);
                displayTextbox.AppendText("");
                displayTextbox.AppendText(Environment.NewLine);
            }

        }
    }
}