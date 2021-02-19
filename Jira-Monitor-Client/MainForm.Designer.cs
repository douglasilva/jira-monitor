namespace Jira_Monitor_Client
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.alertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnNotify = new System.Windows.Forms.Button();
      this.btnConfig = new System.Windows.Forms.Button();
      this.btnFechar = new System.Windows.Forms.Button();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idFiltroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TituloNotificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Dashboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Icone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.alertaBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
      this.bindingNavigator1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.idFiltroDataGridViewTextBoxColumn,
            this.TituloNotificacao,
            this.Dashboard,
            this.Sala,
            this.Icone});
      this.dataGridView1.DataSource = this.alertaBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 25);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(1147, 619);
      this.dataGridView1.TabIndex = 0;
      // 
      // alertaBindingSource
      // 
      this.alertaBindingSource.DataSource = typeof(Library.Alerta);
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigator1
      // 
      this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bindingNavigator1.BindingSource = this.alertaBindingSource;
      this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
      this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator1.Name = "bindingNavigator1";
      this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigator1.Size = new System.Drawing.Size(1271, 25);
      this.bindingNavigator1.TabIndex = 1;
      this.bindingNavigator1.Text = "bindingNavigator1";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Save";
      this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // helpToolStripButton
      // 
      this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
      this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.helpToolStripButton.Name = "helpToolStripButton";
      this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.helpToolStripButton.Text = "He&lp";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnNotify);
      this.panel1.Controls.Add(this.btnConfig);
      this.panel1.Controls.Add(this.btnFechar);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(1147, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(124, 619);
      this.panel1.TabIndex = 2;
      // 
      // btnNotify
      // 
      this.btnNotify.Location = new System.Drawing.Point(14, 15);
      this.btnNotify.Name = "btnNotify";
      this.btnNotify.Size = new System.Drawing.Size(93, 59);
      this.btnNotify.TabIndex = 2;
      this.btnNotify.Text = "Verificar Alertas";
      this.btnNotify.UseVisualStyleBackColor = true;
      this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
      // 
      // btnConfig
      // 
      this.btnConfig.Location = new System.Drawing.Point(14, 80);
      this.btnConfig.Name = "btnConfig";
      this.btnConfig.Size = new System.Drawing.Size(93, 23);
      this.btnConfig.TabIndex = 1;
      this.btnConfig.Text = "Configurações";
      this.btnConfig.UseVisualStyleBackColor = true;
      this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
      // 
      // btnFechar
      // 
      this.btnFechar.Location = new System.Drawing.Point(14, 109);
      this.btnFechar.Name = "btnFechar";
      this.btnFechar.Size = new System.Drawing.Size(93, 23);
      this.btnFechar.TabIndex = 0;
      this.btnFechar.Text = "Fechar";
      this.btnFechar.UseVisualStyleBackColor = true;
      this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
      // 
      // Nome
      // 
      this.Nome.DataPropertyName = "Nome";
      this.Nome.HeaderText = "Nome do alerta";
      this.Nome.Name = "Nome";
      this.Nome.Width = 200;
      // 
      // idFiltroDataGridViewTextBoxColumn
      // 
      this.idFiltroDataGridViewTextBoxColumn.DataPropertyName = "NomeFiltro";
      this.idFiltroDataGridViewTextBoxColumn.HeaderText = "Nome Filtro Favorito no Jira";
      this.idFiltroDataGridViewTextBoxColumn.MinimumWidth = 100;
      this.idFiltroDataGridViewTextBoxColumn.Name = "idFiltroDataGridViewTextBoxColumn";
      this.idFiltroDataGridViewTextBoxColumn.Width = 300;
      // 
      // TituloNotificacao
      // 
      this.TituloNotificacao.DataPropertyName = "TituloNotificacao";
      this.TituloNotificacao.HeaderText = "Título Notificação";
      this.TituloNotificacao.Name = "TituloNotificacao";
      this.TituloNotificacao.Width = 300;
      // 
      // Dashboard
      // 
      this.Dashboard.DataPropertyName = "Dashboard";
      this.Dashboard.HeaderText = "URL Dashboard";
      this.Dashboard.Name = "Dashboard";
      this.Dashboard.Width = 400;
      // 
      // Sala
      // 
      this.Sala.DataPropertyName = "Sala";
      this.Sala.HeaderText = "URL Sala (WebHook)";
      this.Sala.Name = "Sala";
      this.Sala.Width = 400;
      // 
      // Icone
      // 
      this.Icone.DataPropertyName = "Icone";
      this.Icone.HeaderText = "URL Ícone";
      this.Icone.Name = "Icone";
      this.Icone.Width = 400;
      // 
      // MainForm
      // 
      this.AcceptButton = this.btnNotify;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1271, 644);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.bindingNavigator1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Jira Monitor - Client";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.alertaBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
      this.bindingNavigator1.ResumeLayout(false);
      this.bindingNavigator1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idFiltroJiraDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn webHookDataGridViewTextBoxColumn;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.BindingNavigator bindingNavigator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton helpToolStripButton;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnConfig;
    private System.Windows.Forms.Button btnFechar;
    private System.Windows.Forms.Button btnNotify;
    private System.Windows.Forms.BindingSource alertaBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    private System.Windows.Forms.DataGridViewTextBoxColumn idFiltroDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn TituloNotificacao;
    private System.Windows.Forms.DataGridViewTextBoxColumn Dashboard;
    private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    private System.Windows.Forms.DataGridViewTextBoxColumn Icone;
  }
}