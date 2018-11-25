using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void LoadMap_Click(object sender, EventArgs e)
        {
            BMap1.Navigate("file:///C:/Users/nxxhu/Desktop/js_practice/CSharpCode_JS/Bmap1.0.html");
            LoadMap.Visible = false;
        }
    }
}
