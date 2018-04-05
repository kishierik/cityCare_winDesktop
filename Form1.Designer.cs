namespace Proyecto_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeIncidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeImágenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorDeIncidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiasDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarIncidenciasAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarUsuariosAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarIncidenciasResueltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem1,
            this.heToolStripMenuItem,
            this.incidenciasToolStripMenuItem,
            this.copiasDeSeguridadToolStripMenuItem,
            this.históricoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúPrincipalToolStripMenuItem1
            // 
            this.menúPrincipalToolStripMenuItem1.Name = "menúPrincipalToolStripMenuItem1";
            this.menúPrincipalToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.menúPrincipalToolStripMenuItem1.Text = "Menú principal";
            this.menúPrincipalToolStripMenuItem1.Click += new System.EventHandler(this.menúPrincipalToolStripMenuItem1_Click);
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem,
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestiónDeIncidenciasToolStripMenuItem,
            this.gestiónDeImágenesToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem1});
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.heToolStripMenuItem.Text = "Usuarios";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            this.menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            this.menúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.menúPrincipalToolStripMenuItem.Text = "Ver usuarios";
            this.menúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menúPrincipalToolStripMenuItem_Click);
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Eliminar usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestiónDeIncidenciasToolStripMenuItem
            // 
            this.gestiónDeIncidenciasToolStripMenuItem.Name = "gestiónDeIncidenciasToolStripMenuItem";
            this.gestiónDeIncidenciasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gestiónDeIncidenciasToolStripMenuItem.Text = "Añadir usuarios";
            this.gestiónDeIncidenciasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeIncidenciasToolStripMenuItem_Click);
            // 
            // gestiónDeImágenesToolStripMenuItem
            // 
            this.gestiónDeImágenesToolStripMenuItem.Name = "gestiónDeImágenesToolStripMenuItem";
            this.gestiónDeImágenesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gestiónDeImágenesToolStripMenuItem.Text = "Lista negra";
            this.gestiónDeImágenesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeImágenesToolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem1
            // 
            this.editarUsuarioToolStripMenuItem1.Name = "editarUsuarioToolStripMenuItem1";
            this.editarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.editarUsuarioToolStripMenuItem1.Text = "Editar usuario";
            this.editarUsuarioToolStripMenuItem1.Visible = false;
            this.editarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem1_Click);
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscadorDeIncidenciasToolStripMenuItem});
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            // 
            // buscadorDeIncidenciasToolStripMenuItem
            // 
            this.buscadorDeIncidenciasToolStripMenuItem.Name = "buscadorDeIncidenciasToolStripMenuItem";
            this.buscadorDeIncidenciasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.buscadorDeIncidenciasToolStripMenuItem.Text = "Buscador de incidencias";
            this.buscadorDeIncidenciasToolStripMenuItem.Click += new System.EventHandler(this.buscadorDeIncidenciasToolStripMenuItem_Click);
            // 
            // copiasDeSeguridadToolStripMenuItem
            // 
            this.copiasDeSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarIncidenciasAExcelToolStripMenuItem,
            this.exportarUsuariosAExcelToolStripMenuItem});
            this.copiasDeSeguridadToolStripMenuItem.Name = "copiasDeSeguridadToolStripMenuItem";
            this.copiasDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.copiasDeSeguridadToolStripMenuItem.Text = "Copias de seguridad";
            // 
            // exportarIncidenciasAExcelToolStripMenuItem
            // 
            this.exportarIncidenciasAExcelToolStripMenuItem.Name = "exportarIncidenciasAExcelToolStripMenuItem";
            this.exportarIncidenciasAExcelToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exportarIncidenciasAExcelToolStripMenuItem.Text = "Exportar incidencias a Excel";
            this.exportarIncidenciasAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarIncidenciasAExcelToolStripMenuItem_Click);
            // 
            // exportarUsuariosAExcelToolStripMenuItem
            // 
            this.exportarUsuariosAExcelToolStripMenuItem.Name = "exportarUsuariosAExcelToolStripMenuItem";
            this.exportarUsuariosAExcelToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exportarUsuariosAExcelToolStripMenuItem.Text = "Exportar usuarios a Excel";
            this.exportarUsuariosAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarUsuariosAExcelToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarIncidenciasResueltasToolStripMenuItem});
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.históricoToolStripMenuItem.Text = "Histórico";
            // 
            // eliminarIncidenciasResueltasToolStripMenuItem
            // 
            this.eliminarIncidenciasResueltasToolStripMenuItem.Name = "eliminarIncidenciasResueltasToolStripMenuItem";
            this.eliminarIncidenciasResueltasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.eliminarIncidenciasResueltasToolStripMenuItem.Text = "Eliminar incidencias resueltas";
            this.eliminarIncidenciasResueltasToolStripMenuItem.Click += new System.EventHandler(this.eliminarIncidenciasResueltasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 447);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(726, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Incidencias - CityCare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeIncidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeImágenesToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúPrincipalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorDeIncidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiasDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarIncidenciasAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarUsuariosAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarIncidenciasResueltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

