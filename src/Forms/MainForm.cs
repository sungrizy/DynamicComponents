namespace DynamicComponents.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void MainButton_Click(object sender, EventArgs e)
    {
        var newLabel= new Label();
       /* newLabel.Size = new Size(50, 30);*/
        newLabel.Text = DateTime.Now.Microsecond.ToString();
        newLabel.Location = new Point(10, 100);
            

        Controls.Add(newLabel);
    }
}
