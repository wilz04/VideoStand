using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace VideoStand {

	public class FExa : System.Windows.Forms.Form {

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
		private System.ComponentModel.Container components = null;

		public FExa() {
			InitializeComponent();
		}

		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();

      this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(76)), ((System.Byte)(76)), ((System.Byte)(76)));
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(32, 80);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 24);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";

      this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(167)), ((System.Byte)(167)), ((System.Byte)(167)));
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Location = new System.Drawing.Point(32, 32);
      this.textBox1.Name = "textBox1";
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "textBox1";

      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(56)), ((System.Byte)(56)), ((System.Byte)(56)));
      this.ClientSize = new System.Drawing.Size(542, 370);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FExa";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "fExa";
      this.ResumeLayout(false);
    }

	}

}
