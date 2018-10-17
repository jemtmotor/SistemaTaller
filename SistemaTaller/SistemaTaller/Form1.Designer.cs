namespace SistemaTaller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.respuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUnTipoExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridProx = new System.Windows.Forms.DataGridView();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gridAtras = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDia)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProx)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.servicioToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.respuestoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasPendientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            resources.ApplyResources(this.aToolStripMenuItem, "aToolStripMenuItem");
            // 
            // tareasPendientesToolStripMenuItem
            // 
            this.tareasPendientesToolStripMenuItem.Name = "tareasPendientesToolStripMenuItem";
            resources.ApplyResources(this.tareasPendientesToolStripMenuItem, "tareasPendientesToolStripMenuItem");
            this.tareasPendientesToolStripMenuItem.Click += new System.EventHandler(this.tareasPendientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // servicioToolStripMenuItem
            // 
            this.servicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.servicioToolStripMenuItem.Name = "servicioToolStripMenuItem";
            resources.ApplyResources(this.servicioToolStripMenuItem, "servicioToolStripMenuItem");
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequeoToolStripMenuItem,
            this.reparacionToolStripMenuItem});
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            resources.ApplyResources(this.cargarToolStripMenuItem, "cargarToolStripMenuItem");
            // 
            // chequeoToolStripMenuItem
            // 
            this.chequeoToolStripMenuItem.Name = "chequeoToolStripMenuItem";
            resources.ApplyResources(this.chequeoToolStripMenuItem, "chequeoToolStripMenuItem");
            this.chequeoToolStripMenuItem.Click += new System.EventHandler(this.chequeoToolStripMenuItem_Click);
            // 
            // reparacionToolStripMenuItem
            // 
            this.reparacionToolStripMenuItem.Name = "reparacionToolStripMenuItem";
            resources.ApplyResources(this.reparacionToolStripMenuItem, "reparacionToolStripMenuItem");
            this.reparacionToolStripMenuItem.Click += new System.EventHandler(this.reparacionToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            resources.ApplyResources(this.listadoToolStripMenuItem, "listadoToolStripMenuItem");
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem1,
            this.modificarEliminarToolStripMenuItem1,
            this.listadoToolStripMenuItem1});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            resources.ApplyResources(this.empleadoToolStripMenuItem, "empleadoToolStripMenuItem");
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem1
            // 
            this.cargarToolStripMenuItem1.Name = "cargarToolStripMenuItem1";
            resources.ApplyResources(this.cargarToolStripMenuItem1, "cargarToolStripMenuItem1");
            this.cargarToolStripMenuItem1.Click += new System.EventHandler(this.cargarToolStripMenuItem1_Click);
            // 
            // modificarEliminarToolStripMenuItem1
            // 
            this.modificarEliminarToolStripMenuItem1.Name = "modificarEliminarToolStripMenuItem1";
            resources.ApplyResources(this.modificarEliminarToolStripMenuItem1, "modificarEliminarToolStripMenuItem1");
            this.modificarEliminarToolStripMenuItem1.Click += new System.EventHandler(this.modificarEliminarToolStripMenuItem1_Click);
            // 
            // listadoToolStripMenuItem1
            // 
            this.listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            resources.ApplyResources(this.listadoToolStripMenuItem1, "listadoToolStripMenuItem1");
            this.listadoToolStripMenuItem1.Click += new System.EventHandler(this.listadoToolStripMenuItem1_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem2,
            this.modificarEliminarToolStripMenuItem2,
            this.listadoToolStripMenuItem2});
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            resources.ApplyResources(this.vehiculoToolStripMenuItem, "vehiculoToolStripMenuItem");
            // 
            // cargarToolStripMenuItem2
            // 
            this.cargarToolStripMenuItem2.Name = "cargarToolStripMenuItem2";
            resources.ApplyResources(this.cargarToolStripMenuItem2, "cargarToolStripMenuItem2");
            this.cargarToolStripMenuItem2.Click += new System.EventHandler(this.cargarToolStripMenuItem2_Click);
            // 
            // modificarEliminarToolStripMenuItem2
            // 
            this.modificarEliminarToolStripMenuItem2.Name = "modificarEliminarToolStripMenuItem2";
            resources.ApplyResources(this.modificarEliminarToolStripMenuItem2, "modificarEliminarToolStripMenuItem2");
            this.modificarEliminarToolStripMenuItem2.Click += new System.EventHandler(this.modificarEliminarToolStripMenuItem2_Click);
            // 
            // listadoToolStripMenuItem2
            // 
            this.listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            resources.ApplyResources(this.listadoToolStripMenuItem2, "listadoToolStripMenuItem2");
            // 
            // respuestoToolStripMenuItem
            // 
            this.respuestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem3,
            this.modificarEliminarToolStripMenuItem3,
            this.listadoToolStripMenuItem3});
            this.respuestoToolStripMenuItem.Name = "respuestoToolStripMenuItem";
            resources.ApplyResources(this.respuestoToolStripMenuItem, "respuestoToolStripMenuItem");
            this.respuestoToolStripMenuItem.Click += new System.EventHandler(this.respuestoToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem3
            // 
            this.cargarToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarUnTipoExistenteToolStripMenuItem,
            this.agregarNuevoTipoToolStripMenuItem});
            this.cargarToolStripMenuItem3.Name = "cargarToolStripMenuItem3";
            resources.ApplyResources(this.cargarToolStripMenuItem3, "cargarToolStripMenuItem3");
            // 
            // cargarUnTipoExistenteToolStripMenuItem
            // 
            this.cargarUnTipoExistenteToolStripMenuItem.Name = "cargarUnTipoExistenteToolStripMenuItem";
            resources.ApplyResources(this.cargarUnTipoExistenteToolStripMenuItem, "cargarUnTipoExistenteToolStripMenuItem");
            this.cargarUnTipoExistenteToolStripMenuItem.Click += new System.EventHandler(this.cargarUnTipoExistenteToolStripMenuItem_Click);
            // 
            // agregarNuevoTipoToolStripMenuItem
            // 
            this.agregarNuevoTipoToolStripMenuItem.Name = "agregarNuevoTipoToolStripMenuItem";
            resources.ApplyResources(this.agregarNuevoTipoToolStripMenuItem, "agregarNuevoTipoToolStripMenuItem");
            this.agregarNuevoTipoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoTipoToolStripMenuItem_Click);
            // 
            // modificarEliminarToolStripMenuItem3
            // 
            this.modificarEliminarToolStripMenuItem3.Name = "modificarEliminarToolStripMenuItem3";
            resources.ApplyResources(this.modificarEliminarToolStripMenuItem3, "modificarEliminarToolStripMenuItem3");
            this.modificarEliminarToolStripMenuItem3.Click += new System.EventHandler(this.modificarEliminarToolStripMenuItem3_Click);
            // 
            // listadoToolStripMenuItem3
            // 
            this.listadoToolStripMenuItem3.Name = "listadoToolStripMenuItem3";
            resources.ApplyResources(this.listadoToolStripMenuItem3, "listadoToolStripMenuItem3");
            this.listadoToolStripMenuItem3.Click += new System.EventHandler(this.listadoToolStripMenuItem3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gridDia);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gridDia
            // 
            this.gridDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridDia, "gridDia");
            this.gridDia.Name = "gridDia";
            this.gridDia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDia_CellContentClick);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gridProx);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // gridProx
            // 
            this.gridProx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridProx, "gridProx");
            this.gridProx.Name = "gridProx";
            this.gridProx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProx_CellContentClick);
            // 
            // button17
            // 
            resources.ApplyResources(this.button17, "button17");
            this.button17.Name = "button17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.gridAtras);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // gridAtras
            // 
            this.gridAtras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridAtras, "gridAtras");
            this.gridAtras.Name = "gridAtras";
            this.gridAtras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAtras_CellContentClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProx)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem respuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cargarUnTipoExistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridDia;
        private System.Windows.Forms.DataGridView gridProx;
        private System.Windows.Forms.DataGridView gridAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

