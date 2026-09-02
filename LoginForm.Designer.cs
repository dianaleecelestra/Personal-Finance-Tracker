namespace Personal_Finance_Tracker;

partial class LoginForm
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
        passwordTextBox = new TextBox();
        loginButton = new Button();
        registerButton = new Button();
        
        SuspendLayout();
        
        // usernameTextBox
        usernameTextBox.Location = new Point(100, 50);
        usernameTextBox.Name = "usernameTextBox";
        usernameTextBox.Size = new Size(200, 23);
        usernameTextBox.TabIndex = 0;
        
        // passwordTextBox
        passwordTextBox.Location = new Point(100, 100);
        passwordTextBox.Name = "passwordTextBox";
        passwordTextBox.PasswordChar = '*';
        passwordTextBox.Size = new Size(200, 23);
        passwordTextBox.TabIndex = 1;
        
        // loginButton
        loginButton.Location = new Point(100, 150);
        loginButton.Name = "loginButton";
        loginButton.Size = new Size(100, 30);
        loginButton.TabIndex = 2;
        loginButton.Text = "Login";
        loginButton.UseVisualStyleBackColor = true;
        loginButton.Click += loginButton_Click;
        
        // registerButton
        registerButton.Location = new Point(210, 150);
        registerButton.Name = "registerButton";
        registerButton.Size = new Size(100, 30);
        registerButton.TabIndex = 3;
        registerButton.Text = "Register";
        registerButton.UseVisualStyleBackColor = true;
        registerButton.Click += registerButton_Click;
        
        // LoginForm
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 250);
        Controls.Add(usernameTextBox);
        Controls.Add(passwordTextBox);
        Controls.Add(loginButton);
        Controls.Add(registerButton);
        Name = "LoginForm";
        Text = "Login";
        
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox usernameTextBox;
    private TextBox passwordTextBox;
    private Button loginButton;
    private Button registerButton;
}
