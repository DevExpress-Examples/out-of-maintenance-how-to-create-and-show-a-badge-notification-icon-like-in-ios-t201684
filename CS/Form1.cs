using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Internal;
using DevExpress.XtraEditors;
using WindowsFormsApplication516.Properties;

namespace WindowsFormsApplication516 {

    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        MyDXLayeredWindow layeredWindow;
        MyBarDXLayeredWindow layeredWindow1;
        public Form1() {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            layeredWindow = new MyDXLayeredWindow(simpleButton1, Resources.mail_16x16);
            layeredWindow.Show();

            layeredWindow1 = new MyBarDXLayeredWindow(barButtonItem1, Resources.mail_16x16);
            layeredWindow1.Show();

        }
    }
}
