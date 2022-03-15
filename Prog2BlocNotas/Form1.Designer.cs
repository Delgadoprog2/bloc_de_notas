namespace Prog2BlocNotas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUARDARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUARDARCOMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDELANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPIARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECTODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARTODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMATOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLORFONDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.fORMATOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.aBRIRToolStripMenuItem,
            this.gUARDARToolStripMenuItem,
            this.gUARDARCOMOToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            this.aBRIRToolStripMenuItem.Click += new System.EventHandler(this.aBRIRToolStripMenuItem_Click);
            // 
            // gUARDARToolStripMenuItem
            // 
            this.gUARDARToolStripMenuItem.Name = "gUARDARToolStripMenuItem";
            this.gUARDARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gUARDARToolStripMenuItem.Text = "GUARDAR";
            this.gUARDARToolStripMenuItem.Click += new System.EventHandler(this.gUARDARToolStripMenuItem_Click);
            // 
            // gUARDARCOMOToolStripMenuItem
            // 
            this.gUARDARCOMOToolStripMenuItem.Name = "gUARDARCOMOToolStripMenuItem";
            this.gUARDARCOMOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gUARDARCOMOToolStripMenuItem.Text = "GUARDAR COMO";
            this.gUARDARCOMOToolStripMenuItem.Click += new System.EventHandler(this.gUARDARCOMOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTRASToolStripMenuItem,
            this.aDELANTEToolStripMenuItem,
            this.cOPIARToolStripMenuItem,
            this.pEGARToolStripMenuItem,
            this.sELECTODOToolStripMenuItem,
            this.bORRARTODOToolStripMenuItem});
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            // 
            // aTRASToolStripMenuItem
            // 
            this.aTRASToolStripMenuItem.Name = "aTRASToolStripMenuItem";
            this.aTRASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aTRASToolStripMenuItem.Text = "ATRAS";
            this.aTRASToolStripMenuItem.Click += new System.EventHandler(this.aTRASToolStripMenuItem_Click);
            // 
            // aDELANTEToolStripMenuItem
            // 
            this.aDELANTEToolStripMenuItem.Name = "aDELANTEToolStripMenuItem";
            this.aDELANTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDELANTEToolStripMenuItem.Text = "ADELANTE";
            this.aDELANTEToolStripMenuItem.Click += new System.EventHandler(this.aDELANTEToolStripMenuItem_Click);
            // 
            // cOPIARToolStripMenuItem
            // 
            this.cOPIARToolStripMenuItem.Name = "cOPIARToolStripMenuItem";
            this.cOPIARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOPIARToolStripMenuItem.Text = "COPIAR";
            this.cOPIARToolStripMenuItem.Click += new System.EventHandler(this.cOPIARToolStripMenuItem_Click);
            // 
            // pEGARToolStripMenuItem
            // 
            this.pEGARToolStripMenuItem.Name = "pEGARToolStripMenuItem";
            this.pEGARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pEGARToolStripMenuItem.Text = "PEGAR";
            this.pEGARToolStripMenuItem.Click += new System.EventHandler(this.pEGARToolStripMenuItem_Click);
            // 
            // sELECTODOToolStripMenuItem
            // 
            this.sELECTODOToolStripMenuItem.Name = "sELECTODOToolStripMenuItem";
            this.sELECTODOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sELECTODOToolStripMenuItem.Text = "SELEC. TODO";
            this.sELECTODOToolStripMenuItem.Click += new System.EventHandler(this.sELECTODOToolStripMenuItem_Click);
            // 
            // bORRARTODOToolStripMenuItem
            // 
            this.bORRARTODOToolStripMenuItem.Name = "bORRARTODOToolStripMenuItem";
            this.bORRARTODOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bORRARTODOToolStripMenuItem.Text = "BORRAR TODO";
            this.bORRARTODOToolStripMenuItem.Click += new System.EventHandler(this.bORRARTODOToolStripMenuItem_Click);
            // 
            // fORMATOToolStripMenuItem
            // 
            this.fORMATOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOLORToolStripMenuItem,
            this.fUENTEToolStripMenuItem,
            this.cOLORFONDOToolStripMenuItem});
            this.fORMATOToolStripMenuItem.Name = "fORMATOToolStripMenuItem";
            this.fORMATOToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fORMATOToolStripMenuItem.Text = "FORMATO";
            // 
            // cOLORToolStripMenuItem
            // 
            this.cOLORToolStripMenuItem.Name = "cOLORToolStripMenuItem";
            this.cOLORToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOLORToolStripMenuItem.Text = "COLOR";
            this.cOLORToolStripMenuItem.Click += new System.EventHandler(this.cOLORToolStripMenuItem_Click);
            // 
            // fUENTEToolStripMenuItem
            // 
            this.fUENTEToolStripMenuItem.Name = "fUENTEToolStripMenuItem";
            this.fUENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fUENTEToolStripMenuItem.Text = "FUENTE";
            this.fUENTEToolStripMenuItem.Click += new System.EventHandler(this.fUENTEToolStripMenuItem_Click);
            // 
            // cOLORFONDOToolStripMenuItem
            // 
            this.cOLORFONDOToolStripMenuItem.Name = "cOLORFONDOToolStripMenuItem";
            this.cOLORFONDOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOLORFONDOToolStripMenuItem.Text = "COLOR FONDO";
            this.cOLORFONDOToolStripMenuItem.Click += new System.EventHandler(this.cOLORFONDOToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Programacion 2 Bloc notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nUEVOToolStripMenuItem;
        private ToolStripMenuItem aBRIRToolStripMenuItem;
        private ToolStripMenuItem gUARDARToolStripMenuItem;
        private ToolStripMenuItem gUARDARCOMOToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private ToolStripMenuItem eDITARToolStripMenuItem;
        private ToolStripMenuItem aTRASToolStripMenuItem;
        private ToolStripMenuItem aDELANTEToolStripMenuItem;
        private ToolStripMenuItem cOPIARToolStripMenuItem;
        private ToolStripMenuItem pEGARToolStripMenuItem;
        private ToolStripMenuItem sELECTODOToolStripMenuItem;
        private ToolStripMenuItem bORRARTODOToolStripMenuItem;
        private ToolStripMenuItem fORMATOToolStripMenuItem;
        private ToolStripMenuItem cOLORToolStripMenuItem;
        private ToolStripMenuItem fUENTEToolStripMenuItem;
        private ToolStripMenuItem cOLORFONDOToolStripMenuItem;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
    }
}