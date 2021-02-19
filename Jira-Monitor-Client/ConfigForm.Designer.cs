namespace Jira_Monitor_Client
{
  partial class ConfigForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnOk = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.btnCancelar);
      this.panel2.Controls.Add(this.btnOk);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 117);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(379, 59);
      this.panel2.TabIndex = 0;
      // 
      // btnCancelar
      // 
      this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(292, 19);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 1;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOk.Location = new System.Drawing.Point(211, 19);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "&Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Usuário do Jira";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Senha";
      // 
      // txtPassword
      // 
      this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Jira_Monitor_Client.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtPassword.Location = new System.Drawing.Point(16, 76);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(202, 20);
      this.txtPassword.TabIndex = 4;
      this.txtPassword.Text = global::Jira_Monitor_Client.Properties.Settings.Default.Password;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // txtUsername
      // 
      this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Jira_Monitor_Client.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtUsername.Location = new System.Drawing.Point(16, 30);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(202, 20);
      this.txtUsername.TabIndex = 2;
      this.txtUsername.Text = global::Jira_Monitor_Client.Properties.Settings.Default.UserName;
      // 
      // ConfigForm
      // 
      this.AcceptButton = this.btnOk;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(379, 176);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel2);
      this.Name = "ConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPassword;
  }
}