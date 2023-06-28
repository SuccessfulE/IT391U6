using System.Text.RegularExpressions;

namespace IT391U6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaring variables for input boxes
            string ageString = textBox1.Text;
            int age;
            string email = textBox2.Text;

            //Email validation
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            //Making sure the text boxes have something in them
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please enter an Age and Email address.");
            }
            //Identifying if the age is numbers
            else if (!int.TryParse(ageString, out age))
            {
                MessageBox.Show("Please enter a number for your age.");
            }
            //Identifying if the age is lower than 5 or higher than 18
            else if ((age < 5) || (age > 18))
            {
                MessageBox.Show("Please enter an appropriate age.");
            }
            //Using regex to confirm if the email is valid or not.
            else if (!Regex.IsMatch(email, regex))
            {
                MessageBox.Show("Email is invalid please enter a valid Email.");
            }
            else
            {
                //Confirming data validation successful by displaying message
                MessageBox.Show("Submission Successful");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This closes the form
            this.Close();
        }
    }
}