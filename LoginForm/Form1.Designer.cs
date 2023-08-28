namespace LoginForm;

partial class Form1
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
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.Username = new System.Windows.Forms.Label();
        this.Password = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // textBox1
        //
        this.textBox1.Modified = true;
        this.textBox1.Location = new System.Drawing.Point(156, 84);
        this.textBox1.Size = new System.Drawing.Size(240, 23);
        //
        // Label1
        //
        this.Label1.AutoSize = true;
        this.Label1.Text = "Silahkan Login";
        this.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.Label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.Label1.Location = new System.Drawing.Point(152, 24);
        this.Label1.Size = new System.Drawing.Size(159, 30);
        this.Label1.TabIndex = 1;
        //
        // textBox2
        //
        this.textBox2.Location = new System.Drawing.Point(156, 116);
        this.textBox2.Size = new System.Drawing.Size(240, 23);
        this.textBox2.TabIndex = 2;
        //
        // Username
        //
        this.Username.AutoSize = true;
        this.Username.Text = "Username";
        this.Username.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.Username.Location = new System.Drawing.Point(76, 88);
        this.Username.Size = new System.Drawing.Size(60, 15);
        this.Username.TabIndex = 4;
        //
        // Password
        //
        this.Password.AutoSize = true;
        this.Password.Text = "Password";
        this.Password.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.Password.Location = new System.Drawing.Point(76, 120);
        this.Password.Size = new System.Drawing.Size(57, 15);
        this.Password.TabIndex = 5;
        //
        // button1
        //
        this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
        this.button1.Text = "Login";
        this.button1.Location = new System.Drawing.Point(156, 152);
        this.button1.TabIndex = 6;
        this.button1.Click += new System.EventHandler(this.button1_Click);

        //
        // form
        //
        this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.Size = new System.Drawing.Size(480, 248);
        this.Text = "Form1";
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.Username);
        this.Controls.Add(this.Password);
        this.Controls.Add(this.button1);
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label Label1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label Username;
    private System.Windows.Forms.Label Password;
    private System.Windows.Forms.Button button1;
}
