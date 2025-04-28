namespace ManejoDetencionesEstudiantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.navPanel = new System.Windows.Forms.Panel();
            this.reportesBtn = new FontAwesome.Sharp.IconButton();
            this.detencionesBtn = new FontAwesome.Sharp.IconButton();
            this.estudiantesBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.icon1 = new FontAwesome.Sharp.IconButton();
            this.navPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANEJO DE ESTUDIANES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.navPanel.Controls.Add(this.reportesBtn);
            this.navPanel.Controls.Add(this.detencionesBtn);
            this.navPanel.Controls.Add(this.estudiantesBtn);
            this.navPanel.Controls.Add(this.label2);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(200, 818);
            this.navPanel.TabIndex = 1;
            // 
            // reportesBtn
            // 
            this.reportesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reportesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.reportesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.reportesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportesBtn.ForeColor = System.Drawing.Color.Red;
            this.reportesBtn.IconChar = FontAwesome.Sharp.IconChar.File;
            this.reportesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.reportesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportesBtn.Location = new System.Drawing.Point(6, 331);
            this.reportesBtn.Name = "reportesBtn";
            this.reportesBtn.Size = new System.Drawing.Size(196, 63);
            this.reportesBtn.TabIndex = 3;
            this.reportesBtn.Text = "Reportes";
            this.reportesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportesBtn.UseVisualStyleBackColor = false;
            this.reportesBtn.Click += new System.EventHandler(this.reportesBtn_Click);
            // 
            // detencionesBtn
            // 
            this.detencionesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.detencionesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.detencionesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.detencionesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detencionesBtn.ForeColor = System.Drawing.Color.Red;
            this.detencionesBtn.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
            this.detencionesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.detencionesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detencionesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detencionesBtn.Location = new System.Drawing.Point(3, 245);
            this.detencionesBtn.Name = "detencionesBtn";
            this.detencionesBtn.Size = new System.Drawing.Size(199, 68);
            this.detencionesBtn.TabIndex = 2;
            this.detencionesBtn.Text = "Detenciones";
            this.detencionesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detencionesBtn.UseVisualStyleBackColor = false;
            this.detencionesBtn.Click += new System.EventHandler(this.detencionesBtn_Click);
            // 
            // estudiantesBtn
            // 
            this.estudiantesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.estudiantesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.estudiantesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.estudiantesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estudiantesBtn.ForeColor = System.Drawing.Color.Red;
            this.estudiantesBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.estudiantesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.estudiantesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.estudiantesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.estudiantesBtn.Location = new System.Drawing.Point(3, 167);
            this.estudiantesBtn.Name = "estudiantesBtn";
            this.estudiantesBtn.Size = new System.Drawing.Size(199, 63);
            this.estudiantesBtn.TabIndex = 1;
            this.estudiantesBtn.Text = "Estudiantes";
            this.estudiantesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.estudiantesBtn.UseVisualStyleBackColor = false;
            this.estudiantesBtn.Click += new System.EventHandler(this.estudiantesBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 17F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema";
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.icon1);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(200, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1048, 818);
            this.formPanel.TabIndex = 2;
            // 
            // icon1
            // 
            this.icon1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon1.BackColor = System.Drawing.Color.Transparent;
            this.icon1.FlatAppearance.BorderSize = 0;
            this.icon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon1.ForeColor = System.Drawing.Color.Transparent;
            this.icon1.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.icon1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.icon1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon1.IconSize = 142;
            this.icon1.Location = new System.Drawing.Point(410, 245);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(221, 191);
            this.icon1.TabIndex = 1;
            this.icon1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1248, 818);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.navPanel);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Principal";
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton icon1;
        private FontAwesome.Sharp.IconButton reportesBtn;
        private FontAwesome.Sharp.IconButton detencionesBtn;
        private FontAwesome.Sharp.IconButton estudiantesBtn;
    }
}

