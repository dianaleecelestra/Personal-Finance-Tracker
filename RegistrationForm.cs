namespace Personal_Finance_Tracker;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void registerButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string email = emailTextBox.Text;
        string password = passwordTextBox.Text;
        string confirmPassword = confirmPasswordTextBox.Text;

        // Validation
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please fill in all fields!");
            return;
        }

        if (password != confirmPassword)
        {
            MessageBox.Show("Passwords do not match!");
            return;
        }

        // TODO: Add user to database
        MessageBox.Show("Registration successful!");
        
        LoginForm loginForm = new LoginForm();
        loginForm.Show();
        this.Hide();
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        loginForm.Show();
        this.Hide();
    }
}