namespace TPWinForm_Aguirre_Amarillo
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArtículoToolStripMenuItem,
            this.modificarArtículoToolStripMenuItem,
            this.eliminarArtículoToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeArtículosToolStripMenuItem,
            this.detalleDeArtículoToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // listaDeArtículosToolStripMenuItem
            // 
            this.listaDeArtículosToolStripMenuItem.Name = "listaDeArtículosToolStripMenuItem";
            this.listaDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listaDeArtículosToolStripMenuItem.Text = "Lista de artículos";
            // 
            // detalleDeArtículoToolStripMenuItem
            // 
            this.detalleDeArtículoToolStripMenuItem.Name = "detalleDeArtículoToolStripMenuItem";
            this.detalleDeArtículoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.detalleDeArtículoToolStripMenuItem.Text = "Detalle de artículo";
            // 
            // agregarArtículoToolStripMenuItem
            // 
            this.agregarArtículoToolStripMenuItem.Name = "agregarArtículoToolStripMenuItem";
            this.agregarArtículoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarArtículoToolStripMenuItem.Text = "Agregar artículo";
            this.agregarArtículoToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículoToolStripMenuItem_Click);
            // 
            // modificarArtículoToolStripMenuItem
            // 
            this.modificarArtículoToolStripMenuItem.Name = "modificarArtículoToolStripMenuItem";
            this.modificarArtículoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modificarArtículoToolStripMenuItem.Text = "Modificar artículo";
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarArtículoToolStripMenuItem.Text = "Eliminar artículo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeArtículoToolStripMenuItem;
    }
}