namespace Aplicacion_estudiantes
{
    partial class Form1
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
            this.lblcarnet = new System.Windows.Forms.Label();
            this.txtbcarnet = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtbnombre = new System.Windows.Forms.TextBox();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerrorcarnet = new System.Windows.Forms.Label();
            this.lblerrorname = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnListado = new System.Windows.Forms.Button();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblcarnet.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcarnet.Location = new System.Drawing.Point(86, 61);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(95, 37);
            this.lblcarnet.TabIndex = 0;
            this.lblcarnet.Text = "Carné ";
            // 
            // txtbcarnet
            // 
            this.txtbcarnet.Location = new System.Drawing.Point(226, 75);
            this.txtbcarnet.Name = "txtbcarnet";
            this.txtbcarnet.Size = new System.Drawing.Size(237, 23);
            this.txtbcarnet.TabIndex = 1;
            this.txtbcarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCarnet_key);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblnombre.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnombre.Location = new System.Drawing.Point(91, 156);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(118, 37);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // txtbnombre
            // 
            this.txtbnombre.Location = new System.Drawing.Point(226, 170);
            this.txtbnombre.Name = "txtbnombre";
            this.txtbnombre.Size = new System.Drawing.Size(237, 23);
            this.txtbnombre.TabIndex = 3;
            this.txtbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNombre_key);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.buttonguardar.Location = new System.Drawing.Point(350, 315);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(155, 49);
            this.buttonguardar.TabIndex = 4;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblerror.ForeColor = System.Drawing.Color.IndianRed;
            this.lblerror.Location = new System.Drawing.Point(98, 258);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(42, 13);
            this.lblerror.TabIndex = 5;
            this.lblerror.Text = "Error";
            this.lblerror.Visible = false;
            // 
            // lblerrorcarnet
            // 
            this.lblerrorcarnet.AutoSize = true;
            this.lblerrorcarnet.ForeColor = System.Drawing.Color.Tomato;
            this.lblerrorcarnet.Location = new System.Drawing.Point(235, 109);
            this.lblerrorcarnet.Name = "lblerrorcarnet";
            this.lblerrorcarnet.Size = new System.Drawing.Size(32, 15);
            this.lblerrorcarnet.TabIndex = 6;
            this.lblerrorcarnet.Text = "Error";
            this.lblerrorcarnet.Visible = false;
            // 
            // lblerrorname
            // 
            this.lblerrorname.AutoSize = true;
            this.lblerrorname.ForeColor = System.Drawing.Color.Red;
            this.lblerrorname.Location = new System.Drawing.Point(236, 204);
            this.lblerrorname.Name = "lblerrorname";
            this.lblerrorname.Size = new System.Drawing.Size(32, 15);
            this.lblerrorname.TabIndex = 7;
            this.lblerrorname.Text = "Error";
            this.lblerrorname.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUNotas});
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // MNUNotas
            // 
            this.MNUNotas.Name = "MNUNotas";
            this.MNUNotas.Size = new System.Drawing.Size(105, 22);
            this.MNUNotas.Text = "Notas";
            this.MNUNotas.Click += new System.EventHandler(this.MNUNotas_Click);
            // 
            // bttnListado
            // 
            this.bttnListado.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bttnListado.Location = new System.Drawing.Point(118, 320);
            this.bttnListado.Name = "bttnListado";
            this.bttnListado.Size = new System.Drawing.Size(118, 43);
            this.bttnListado.TabIndex = 9;
            this.bttnListado.Text = "Listado";
            this.bttnListado.UseVisualStyleBackColor = true;
            this.bttnListado.Click += new System.EventHandler(this.bttnListado_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 415);
            this.Controls.Add(this.bttnListado);
            this.Controls.Add(this.lblerrorname);
            this.Controls.Add(this.lblerrorcarnet);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.txtbnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtbcarnet);
            this.Controls.Add(this.lblcarnet);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcarnet;
        private TextBox txtbcarnet;
        private Label lblnombre;
        private TextBox txtbnombre;
        private Button buttonguardar;
        private Label lblerror;
        private Label lblerrorcarnet;
        private Label lblerrorname;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem estudianteToolStripMenuItem;
        private ToolStripMenuItem MNUNotas;
        private Button bttnListado;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}