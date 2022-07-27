namespace InterfazGrafica
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvEscrtitorio = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escritorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escritorioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escritorioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escritorioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvMonitor = new System.Windows.Forms.DataGridView();
            this.LblEscritorio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvMouse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEscrtitorio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEscrtitorio
            // 
            this.DgvEscrtitorio.AllowUserToAddRows = false;
            this.DgvEscrtitorio.AllowUserToDeleteRows = false;
            this.DgvEscrtitorio.BackgroundColor = System.Drawing.Color.Teal;
            this.DgvEscrtitorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEscrtitorio.Location = new System.Drawing.Point(12, 57);
            this.DgvEscrtitorio.Name = "DgvEscrtitorio";
            this.DgvEscrtitorio.ReadOnly = true;
            this.DgvEscrtitorio.RowHeadersVisible = false;
            this.DgvEscrtitorio.RowHeadersWidth = 51;
            this.DgvEscrtitorio.RowTemplate.Height = 29;
            this.DgvEscrtitorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEscrtitorio.Size = new System.Drawing.Size(243, 269);
            this.DgvEscrtitorio.TabIndex = 0;
            this.DgvEscrtitorio.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvEscrtitorio_DataError);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.enviarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escritorioToolStripMenuItem,
            this.monitorToolStripMenuItem,
            this.mouseToolStripMenuItem});
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // escritorioToolStripMenuItem
            // 
            this.escritorioToolStripMenuItem.Name = "escritorioToolStripMenuItem";
            this.escritorioToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.escritorioToolStripMenuItem.Text = "Escritorio";
            this.escritorioToolStripMenuItem.Click += new System.EventHandler(this.escritorioToolStripMenuItem_Click);
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.monitorToolStripMenuItem.Text = "Monitor";
            this.monitorToolStripMenuItem.Click += new System.EventHandler(this.monitorToolStripMenuItem_Click);
            // 
            // mouseToolStripMenuItem
            // 
            this.mouseToolStripMenuItem.Name = "mouseToolStripMenuItem";
            this.mouseToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.mouseToolStripMenuItem.Text = "Mouse";
            this.mouseToolStripMenuItem.Click += new System.EventHandler(this.mouseToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escritorioToolStripMenuItem1,
            this.monitorToolStripMenuItem1,
            this.mouseToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // escritorioToolStripMenuItem1
            // 
            this.escritorioToolStripMenuItem1.Name = "escritorioToolStripMenuItem1";
            this.escritorioToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.escritorioToolStripMenuItem1.Text = "Escritorio";
            this.escritorioToolStripMenuItem1.Click += new System.EventHandler(this.escritorioToolStripMenuItem1_Click);
            // 
            // monitorToolStripMenuItem1
            // 
            this.monitorToolStripMenuItem1.Name = "monitorToolStripMenuItem1";
            this.monitorToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.monitorToolStripMenuItem1.Text = "Monitor";
            this.monitorToolStripMenuItem1.Click += new System.EventHandler(this.monitorToolStripMenuItem1_Click);
            // 
            // mouseToolStripMenuItem1
            // 
            this.mouseToolStripMenuItem1.Name = "mouseToolStripMenuItem1";
            this.mouseToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.mouseToolStripMenuItem1.Text = "Mouse";
            this.mouseToolStripMenuItem1.Click += new System.EventHandler(this.mouseToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escritorioToolStripMenuItem2,
            this.monitorToolStripMenuItem2,
            this.mouseToolStripMenuItem2});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // escritorioToolStripMenuItem2
            // 
            this.escritorioToolStripMenuItem2.Name = "escritorioToolStripMenuItem2";
            this.escritorioToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.escritorioToolStripMenuItem2.Text = "Escritorio";
            this.escritorioToolStripMenuItem2.Click += new System.EventHandler(this.escritorioToolStripMenuItem2_Click);
            // 
            // monitorToolStripMenuItem2
            // 
            this.monitorToolStripMenuItem2.Name = "monitorToolStripMenuItem2";
            this.monitorToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.monitorToolStripMenuItem2.Text = "Monitor";
            this.monitorToolStripMenuItem2.Click += new System.EventHandler(this.monitorToolStripMenuItem2_Click);
            // 
            // mouseToolStripMenuItem2
            // 
            this.mouseToolStripMenuItem2.Name = "mouseToolStripMenuItem2";
            this.mouseToolStripMenuItem2.Size = new System.Drawing.Size(154, 26);
            this.mouseToolStripMenuItem2.Text = "Mouse";
            this.mouseToolStripMenuItem2.Click += new System.EventHandler(this.mouseToolStripMenuItem2_Click);
            // 
            // enviarToolStripMenuItem
            // 
            this.enviarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escritorioToolStripMenuItem3,
            this.monitorToolStripMenuItem3,
            this.mouseToolStripMenuItem3});
            this.enviarToolStripMenuItem.Name = "enviarToolStripMenuItem";
            this.enviarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.enviarToolStripMenuItem.Text = "Enviar";
            // 
            // escritorioToolStripMenuItem3
            // 
            this.escritorioToolStripMenuItem3.Name = "escritorioToolStripMenuItem3";
            this.escritorioToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.escritorioToolStripMenuItem3.Text = "Escritorio";
            this.escritorioToolStripMenuItem3.Click += new System.EventHandler(this.escritorioToolStripMenuItem3_Click);
            // 
            // monitorToolStripMenuItem3
            // 
            this.monitorToolStripMenuItem3.Name = "monitorToolStripMenuItem3";
            this.monitorToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.monitorToolStripMenuItem3.Text = "Monitor";
            this.monitorToolStripMenuItem3.Click += new System.EventHandler(this.monitorToolStripMenuItem3_Click);
            // 
            // mouseToolStripMenuItem3
            // 
            this.mouseToolStripMenuItem3.Name = "mouseToolStripMenuItem3";
            this.mouseToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.mouseToolStripMenuItem3.Text = "Mouse";
            this.mouseToolStripMenuItem3.Click += new System.EventHandler(this.mouseToolStripMenuItem3_Click);
            // 
            // DgvMonitor
            // 
            this.DgvMonitor.AllowUserToAddRows = false;
            this.DgvMonitor.AllowUserToDeleteRows = false;
            this.DgvMonitor.BackgroundColor = System.Drawing.Color.Teal;
            this.DgvMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMonitor.Location = new System.Drawing.Point(265, 57);
            this.DgvMonitor.Name = "DgvMonitor";
            this.DgvMonitor.ReadOnly = true;
            this.DgvMonitor.RowHeadersVisible = false;
            this.DgvMonitor.RowHeadersWidth = 51;
            this.DgvMonitor.RowTemplate.Height = 29;
            this.DgvMonitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMonitor.Size = new System.Drawing.Size(243, 269);
            this.DgvMonitor.TabIndex = 2;
            this.DgvMonitor.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvMonitor_DataError);
            // 
            // LblEscritorio
            // 
            this.LblEscritorio.AutoSize = true;
            this.LblEscritorio.Location = new System.Drawing.Point(12, 34);
            this.LblEscritorio.Name = "LblEscritorio";
            this.LblEscritorio.Size = new System.Drawing.Size(71, 20);
            this.LblEscritorio.TabIndex = 4;
            this.LblEscritorio.Text = "Escritorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mouse";
            // 
            // DgvMouse
            // 
            this.DgvMouse.AllowUserToAddRows = false;
            this.DgvMouse.AllowUserToDeleteRows = false;
            this.DgvMouse.BackgroundColor = System.Drawing.Color.Teal;
            this.DgvMouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMouse.Location = new System.Drawing.Point(514, 57);
            this.DgvMouse.Name = "DgvMouse";
            this.DgvMouse.ReadOnly = true;
            this.DgvMouse.RowHeadersVisible = false;
            this.DgvMouse.RowHeadersWidth = 51;
            this.DgvMouse.RowTemplate.Height = 29;
            this.DgvMouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMouse.Size = new System.Drawing.Size(243, 269);
            this.DgvMouse.TabIndex = 7;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(769, 342);
            this.Controls.Add(this.DgvMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblEscritorio);
            this.Controls.Add(this.DgvMonitor);
            this.Controls.Add(this.DgvEscrtitorio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEscrtitorio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEscrtitorio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escritorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvMonitor;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escritorioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escritorioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem enviarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escritorioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mouseToolStripMenuItem3;
        private System.Windows.Forms.Label LblEscritorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvMouse;
    }
}
