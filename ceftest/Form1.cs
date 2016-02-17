using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp.WinForms.Internals;

namespace ceftest
{
    public partial class Form1 : Form
    {
        //static Form1() {
        //    var settings = new CefSettings { RemoteDebuggingPort = 8088 };
        //    CefSharp.Cef.Initialize(settings);
        //}
        public Form1()
        {
            InitializeComponent();
            
            
            var c = new CefSharp.WinForms.ChromiumWebBrowser("http://google.com");

            c.TitleChanged += C_TitleChanged;
            splitContainer1.Panel2.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            
    }

        private void C_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = e.Title);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
