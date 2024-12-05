using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View;

public partial class AboutForm : Form
{
    private string _gitHubLink = "https://github.com/";

    private string _iconsLink = "https://icons8.com/";

    public AboutForm()
    {
        InitializeComponent();
    }

    private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = _gitHubLink,
            UseShellExecute = true
        };
        Process.Start(processStartInfo);
    }

    private void IconsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = _iconsLink,
            UseShellExecute = true
        };
        Process.Start(processStartInfo);
    }

    private void OKButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void LicenseTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void NameLabel_Click(object sender, EventArgs e)
    {

    }

    private void FormPanel_Paint(object sender, PaintEventArgs e)
    {

    }

    private void LicenseTextBox_TextChanged(object sender, EventArgs e)
    {

    }
}
