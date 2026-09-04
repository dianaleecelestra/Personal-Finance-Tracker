namespace Personal_Finance_Tracker;

partial class RegistrationForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        usernameTextBox = new TextBox();
        emailTextBox = new TextBox();
        passwordTextBox = new TextBox();
        confirmPasswordTextBox = new TextBox();
        registerButton = new Button();
        backButton = new Button();
        
        SuspendLayout();
        
        // usernameTextBox
        usernameTextBox.Location = new Point(100, 50);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(200, 23);
        usernameTextBox.TabIndex = 0;
        usernameTextBox.PlaceholderText = "Username";
        
        // emailTextBox
        emailTextBox.Location = new Point(100, 100);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new Size(200, 23);
        emailTextBox.TabIndex = 1;
        emailTextBox.PlaceholderText = "Email";
        
        // passwordTextBox
        passwordTextBox.Location = new Point(100, 150);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.Size = new Size(200, 23);
        passwordTextBox.TabIndex = 2;
        passwordTextBox.PlaceholderText = "Password";
        
        // confirmPasswordTextBox
        confirmPasswordTextBox.Location = new Point(100, 200);
        confirmPasswordTextBox.Name = "confirmPasswordTextBox";
        confirmPasswordTextBox.PasswordChar = '*';
        confirmPasswordTextBox.Size = new Size(200, 23);
        confirmPasswordTextBox.TabIndex = 3;
        confirmPasswordTextBox.PlaceholderText = "Confirm Password";
        
        // registerButton
        registerButton.Location = new Point(100, 250);
        registerButton.Name = "registerButton";
        registerButton.Size = new Size(100, 30);
        registerButton.TabIndex = 4;
        registerButton.Text = "Register";
        registerButton.UseVisualStyleBackColor = true;
        registerButton.Click += registerButton_Click;
        
        // backButton
        backButton.Location = new Point(210, 250);
        backButton.Name = "backButton";
        backButton.Size = new Size(100, 30);
        backButton.TabIndex = 5;
        backButton.Text = "Back";
        backButton.UseVisualStyleBackColor = true;
        backButton.Click += backButton_Click;
        
        // RegistrationForm
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 350);
        Controls.Add(usernameTextBox);
        Controls.Add(emailTextBox);
        Controls.Add(passwordTextBox);
        Controls.Add(confirmPasswordTextBox);
        Controls.Add(registerButton);
        Controls.Add(backButton);
        Name = "RegistrationForm";
        Text = "Registration";
        
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox usernameTextBox;
    private TextBox emailTextBox;
    private TextBox passwordTextBox;
    private TextBox confirmPasswordTextBox;
    private Button registerButton;
    private Button backButton;
}
