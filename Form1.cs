using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PortProxyManager;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Log(string message)
    {
        File.AppendAllText("log.txt", $"{DateTime.Now}: {message}{Environment.NewLine}");
    }

    private string RunNetsh(string args)
    {
        Log($"Executing: netsh {args}");
        var psi = new ProcessStartInfo
        {
            FileName = "netsh",
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(psi);
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();
        process.WaitForExit();

        string result = string.IsNullOrEmpty(error) ? output : error;
        Log($"Output: {result}");
        return result;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtListen.Text, out int listenPort) || listenPort < 1 || listenPort > 65535)
        {
            MessageBox.Show("Please enter a valid listen port (1-65535).");
            Log($"Invalid listen port entered: {txtListen.Text}");
            return;
        }

        if (!int.TryParse(txtTargetPort.Text, out int targetPort) || targetPort < 1 || targetPort > 65535)
        {
            MessageBox.Show("Please enter a valid target port (1-65535).");
            Log($"Invalid target port entered: {txtTargetPort.Text}");
            return;
        }

        if (!Regex.IsMatch(txtTargetIP.Text, @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$"))
        {
            MessageBox.Show("Please enter a valid target IP address.");
            Log($"Invalid target IP entered: {txtTargetIP.Text}");
            return;
        }
        
        string existingRules = RunNetsh("interface portproxy show all");
        if (existingRules.Contains($"v4tov4 {new string(' ', 15)} {listenPort}"))
        {
            MessageBox.Show($"Error: A proxy rule for listen port {listenPort} already exists.");
            Log($"Attempted to add a duplicate rule for port {listenPort}.");
            return;
        }

        string cmd = $"interface portproxy add v4tov4 listenport={txtListen.Text} listenaddress=0.0.0.0 connectport={txtTargetPort.Text} connectaddress={txtTargetIP.Text}";
        MessageBox.Show(RunNetsh(cmd));
        btnList_Click(sender, e); // Refresh list
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtListen.Text, out int listenPort) || listenPort < 1 || listenPort > 65535)
        {
            MessageBox.Show("Please enter a valid listen port (1-65535) to delete.");
            Log($"Invalid listen port for deletion: {txtListen.Text}");
            return;
        }

        string cmd = $"interface portproxy delete v4tov4 listenport={txtListen.Text} listenaddress=0.0.0.0";
        MessageBox.Show(RunNetsh(cmd));
        btnList_Click(sender, e); // Refresh list
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        Log("Listing all port proxy rules.");
        string result = RunNetsh("interface portproxy show all");
        txtOutput.Text = result;
    }

    private void btnFirewall_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtListen.Text, out int listenPort) || listenPort < 1 || listenPort > 65535)
        {
            MessageBox.Show("Please enter a valid listen port (1-65535) to create a firewall rule.");
            Log($"Invalid listen port for firewall rule: {txtListen.Text}");
            return;
        }

        string ruleName = $"PortProxyManager Port {listenPort}";
        string cmd = $"advfirewall firewall add rule name=\"{ruleName}\" dir=in action=allow protocol=TCP localport={listenPort}";
        MessageBox.Show(RunNetsh(cmd));
    }
}
