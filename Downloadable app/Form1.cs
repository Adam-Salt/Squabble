using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;


namespace Squabble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://squabble.glitch.me/app.html")
            {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200, 200),
            };
            this.panel1.Controls.Add(browser);
        }
    }
}
