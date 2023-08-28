namespace LoginForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == "" || textBox2.Text == "")
            MessageBox.Show("Username atau Password tidak boleh kosong");
        else
        if (textBox1.Text == "admin" && textBox2.Text == "12345678")
            MessageBox.Show("Anda berhasil Login");
        else
            MessageBox.Show("Username atau Password salah");
    }
}
