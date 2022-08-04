using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp {

    internal static class Program {
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Form1 : Form {
        private System.ComponentModel.IContainer components = null!;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        private void InitializeComponent() {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load!);
            this.ResumeLayout(false);
        }

        public Form1() { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var hr = CoInitializeSecurity(IntPtr.Zero, -1, IntPtr.Zero, IntPtr.Zero, 0, 3, IntPtr.Zero, 0x20, IntPtr.Zero);
            if (hr != 0) {
                MessageBox.Show($"Cannot Complete CoInitializeSecurity. - {new System.ComponentModel.Win32Exception(hr).Message}");
            } else {
                MessageBox.Show($"CoInitializeSecurity worked just fine");
            }
        }

        [DllImport("ole32.dll", CharSet = CharSet.Unicode)]
        public static extern int CoInitializeSecurity(IntPtr pVoid, int cAuthSvc, IntPtr asAuthSvc, IntPtr pReserved1, uint level, uint impers, IntPtr pAuthList, uint dwCapabilities, IntPtr pReserved3);
    }

}
