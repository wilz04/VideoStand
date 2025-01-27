using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace VideoStand {

	public class FMain : System.Windows.Forms.Form {
    private System.Windows.Forms.Button bClose;
    private System.Windows.Forms.TextBox tbId;
    private System.Windows.Forms.TextBox tbPwd;
    private System.Windows.Forms.Label lId;
    private System.Windows.Forms.Label lPwd;
    private System.Windows.Forms.GroupBox gbLogin;
    private System.Windows.Forms.Button bSubmit;

		private System.ComponentModel.Container components = null;

		public FMain() {
			InitializeComponent();
		}

		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeComponent() {
      System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FMain));
      this.tbId = new System.Windows.Forms.TextBox();
      this.tbPwd = new System.Windows.Forms.TextBox();
      this.lId = new System.Windows.Forms.Label();
      this.lPwd = new System.Windows.Forms.Label();
      this.gbLogin = new System.Windows.Forms.GroupBox();
      this.bClose = new System.Windows.Forms.Button();
      this.bSubmit = new System.Windows.Forms.Button();
      this.gbLogin.SuspendLayout();
      this.SuspendLayout();

      this.tbId.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(198)), ((System.Byte)(209)), ((System.Byte)(220)));
      this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbId.Location = new System.Drawing.Point(80, 32);
      this.tbId.Name = "tbId";
      this.tbId.Size = new System.Drawing.Size(144, 21);
      this.tbId.TabIndex = 0;
      this.tbId.Text = "";

      this.tbPwd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(198)), ((System.Byte)(209)), ((System.Byte)(220)));
      this.tbPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbPwd.Location = new System.Drawing.Point(80, 64);
      this.tbPwd.Name = "tbPwd";
      this.tbPwd.Size = new System.Drawing.Size(144, 21);
      this.tbPwd.TabIndex = 1;
      this.tbPwd.Text = "";

      this.lId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lId.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(140)), ((System.Byte)(163)), ((System.Byte)(185)));
      this.lId.Location = new System.Drawing.Point(8, 32);
      this.lId.Name = "lId";
      this.lId.Size = new System.Drawing.Size(64, 23);
      this.lId.TabIndex = 2;
      this.lId.Text = "Id:";

      this.lPwd.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(140)), ((System.Byte)(163)), ((System.Byte)(185)));
      this.lPwd.Location = new System.Drawing.Point(8, 64);
      this.lPwd.Name = "lPwd";
      this.lPwd.Size = new System.Drawing.Size(64, 23);
      this.lPwd.TabIndex = 3;
      this.lPwd.Text = "Password:";

      this.gbLogin.Controls.Add(this.tbPwd);
      this.gbLogin.Controls.Add(this.tbId);
      this.gbLogin.Controls.Add(this.lPwd);
      this.gbLogin.Controls.Add(this.lId);
      this.gbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.gbLogin.Location = new System.Drawing.Point(24, 24);
      this.gbLogin.Name = "gbLogin";
      this.gbLogin.Size = new System.Drawing.Size(240, 100);
      this.gbLogin.TabIndex = 4;
      this.gbLogin.TabStop = false;
      this.gbLogin.Text = "Login";

      this.bClose.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(63)), ((System.Byte)(84)), ((System.Byte)(104)));
      this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bClose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.bClose.ForeColor = System.Drawing.Color.Crimson;
      this.bClose.Location = new System.Drawing.Point(264, 0);
      this.bClose.Name = "bClose";
      this.bClose.Size = new System.Drawing.Size(24, 23);
      this.bClose.TabIndex = 5;
      this.bClose.Text = "x";
      this.bClose.Click += new System.EventHandler(this.bClose_Click);

      this.bSubmit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(63)), ((System.Byte)(84)), ((System.Byte)(104)));
      this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.bSubmit.Location = new System.Drawing.Point(107, 136);
      this.bSubmit.Name = "bSubmit";
      this.bSubmit.TabIndex = 6;
      this.bSubmit.Text = "Enviar";
      this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);

      this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
      this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(53)), ((System.Byte)(70)), ((System.Byte)(87)));
      this.ClientSize = new System.Drawing.Size(288, 176);
      this.Controls.Add(this.bSubmit);
      this.Controls.Add(this.bClose);
      this.Controls.Add(this.gbLogin);
      this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "VideoStand";
      this.gbLogin.ResumeLayout(false);
      this.ResumeLayout(false);
    }

		
    public static void Main() {
			Application.Run(new FMain());
		}

    private void bClose_Click(object sender, System.EventArgs e) {
      Close();
    }

    private void bSubmit_Click(object sender, System.EventArgs e) {
      FExa fExa = new FExa();
      fExa.Show();
      Hide();
    }

	}

}
