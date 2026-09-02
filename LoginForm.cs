namespace Personal_Finance_Tracker;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;

        // Add validation and authentication logic here
        if (ValidateCredentials(username, password))
        {
            MessageBox.Show("Login successful!");
            // Open main form
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Invalid username or password!");
        }
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        RegistrationForm registrationForm = new RegistrationForm();
        registrationForm.Show();
        this.Hide();
    }

    private bool ValidateCredentials(string username, string password)
    {
        // TODO: Add database validation logic
        return true;
    }
}