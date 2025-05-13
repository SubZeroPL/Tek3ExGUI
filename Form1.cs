using System.Diagnostics;

namespace Tek3ExGUI;

public partial class Form1 : Form
{
    private const string Tek3Ex = "Tek3Ex.exe";
    private const string UnpackCmd = "{0} {1} {2}";
    private const string PackCmd = "-p {0} {1} {2}";

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (ofdBns.ShowDialog() == DialogResult.OK)
        {
            textBns.Text = ofdBns.FileName;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (ofdExe.ShowDialog() == DialogResult.OK)
        {
            textExe.Text = ofdExe.FileName;
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (fbdOutput.ShowDialog() != DialogResult.OK) return;
        textOutput.Text = fbdOutput.SelectedPath;
        if (string.IsNullOrEmpty(textInput.Text))
        {
            textInput.Text = fbdOutput.SelectedPath;
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (fbdInput.ShowDialog() != DialogResult.OK) return;
        textInput.Text = fbdInput.SelectedPath;
        if (string.IsNullOrEmpty(textOutput.Text))
        {
            textOutput.Text = fbdOutput.SelectedPath;
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        var text = tabControl1.SelectedIndex switch
        {
            0 when string.IsNullOrEmpty(textOutput.Text) || string.IsNullOrEmpty(textBns.Text) ||
                   string.IsNullOrEmpty(textExe.Text) => "output",
            1 when string.IsNullOrEmpty(textInput.Text) || string.IsNullOrEmpty(textBns.Text) ||
                   string.IsNullOrEmpty(textExe.Text) => "input",
            _ => ""
        };

        if (!string.IsNullOrEmpty(text))
        {
            MessageBox.Show($@"Please select {text} folder, bns file and executable", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var process = new Process();
        process.StartInfo = new ProcessStartInfo
        {
            FileName = Tek3Ex,
            Arguments = tabControl1.SelectedIndex == 0
                ? string.Format(UnpackCmd, textBns.Text, textExe.Text, textOutput.Text)
                : string.Format(PackCmd, textInput.Text, textExe.Text, textBns.Text),
            CreateNoWindow = true,
            UseShellExecute = false
        };
        process.EnableRaisingEvents = true;
        process.Exited += (_, _) =>
        {
            MessageBox.Show(@"Done!", @"Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        };
        process.Start();
    }
}