namespace ManejoDetencionesEstudiantes.Detentions
{
    partial class UpdateDetentionForm
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.plateErrMsg = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detentionDate = new System.Windows.Forms.DateTimePicker();
            this.detentionAmount = new System.Windows.Forms.NumericUpDown();
            this.matriculaBox = new System.Windows.Forms.ComboBox();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.typeDetentionBox = new System.Windows.Forms.ComboBox();
            this.detentionReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.estudianteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detentionAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.formPanel.Controls.Add(this.plateErrMsg);
            this.formPanel.Controls.Add(this.gradeBox);
            this.formPanel.Controls.Add(this.label5);
            this.formPanel.Controls.Add(this.detentionDate);
            this.formPanel.Controls.Add(this.detentionAmount);
            this.formPanel.Controls.Add(this.matriculaBox);
            this.formPanel.Controls.Add(this.stateBox);
            this.formPanel.Controls.Add(this.typeDetentionBox);
            this.formPanel.Controls.Add(this.detentionReason);
            this.formPanel.Controls.Add(this.label4);
            this.formPanel.Controls.Add(this.addBtn);
            this.formPanel.Controls.Add(this.label9);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.label6);
            this.formPanel.Controls.Add(this.label10);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label11);
            this.formPanel.Controls.Add(this.estudianteBox);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(962, 742);
            this.formPanel.TabIndex = 7;
            // 
            // plateErrMsg
            // 
            this.plateErrMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plateErrMsg.AutoSize = true;
            this.plateErrMsg.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plateErrMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.plateErrMsg.Location = new System.Drawing.Point(647, 258);
            this.plateErrMsg.Name = "plateErrMsg";
            this.plateErrMsg.Size = new System.Drawing.Size(0, 18);
            this.plateErrMsg.TabIndex = 43;
            // 
            // gradeBox
            // 
            this.gradeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.gradeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradeBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.gradeBox.ForeColor = System.Drawing.Color.White;
            this.gradeBox.FormattingEnabled = true;
            this.gradeBox.Items.AddRange(new object[] {
            "5to grado (16-17 años)",
            "4to grado (15-16 años)",
            "6to grado (17-18 años)"});
            this.gradeBox.Location = new System.Drawing.Point(536, 488);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(322, 26);
            this.gradeBox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(532, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 41;
            this.label5.Text = "Curso:";
            // 
            // detentionDate
            // 
            this.detentionDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detentionDate.CalendarForeColor = System.Drawing.Color.White;
            this.detentionDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.detentionDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.detentionDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.detentionDate.Location = new System.Drawing.Point(536, 402);
            this.detentionDate.Name = "detentionDate";
            this.detentionDate.Size = new System.Drawing.Size(323, 26);
            this.detentionDate.TabIndex = 40;
            // 
            // detentionAmount
            // 
            this.detentionAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detentionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.detentionAmount.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.detentionAmount.ForeColor = System.Drawing.Color.White;
            this.detentionAmount.Location = new System.Drawing.Point(142, 409);
            this.detentionAmount.Name = "detentionAmount";
            this.detentionAmount.Size = new System.Drawing.Size(321, 26);
            this.detentionAmount.TabIndex = 39;
            // 
            // matriculaBox
            // 
            this.matriculaBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matriculaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.matriculaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matriculaBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.matriculaBox.ForeColor = System.Drawing.Color.White;
            this.matriculaBox.FormattingEnabled = true;
            this.matriculaBox.Location = new System.Drawing.Point(537, 302);
            this.matriculaBox.Name = "matriculaBox";
            this.matriculaBox.Size = new System.Drawing.Size(322, 26);
            this.matriculaBox.TabIndex = 38;
            // 
            // stateBox
            // 
            this.stateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.stateBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.stateBox.ForeColor = System.Drawing.Color.White;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Items.AddRange(new object[] {
            "Abierto",
            "Cerrado"});
            this.stateBox.Location = new System.Drawing.Point(142, 302);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(322, 26);
            this.stateBox.TabIndex = 37;
            this.stateBox.Text = "Abierto";
            // 
            // typeDetentionBox
            // 
            this.typeDetentionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeDetentionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.typeDetentionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeDetentionBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F);
            this.typeDetentionBox.ForeColor = System.Drawing.Color.White;
            this.typeDetentionBox.FormattingEnabled = true;
            this.typeDetentionBox.Items.AddRange(new object[] {
            "Detención durante el recreo",
            "Carta a los padres",
            "Tarea adicional",
            "Escribir un ensayo reflexivo",
            "Otro"});
            this.typeDetentionBox.Location = new System.Drawing.Point(537, 193);
            this.typeDetentionBox.Name = "typeDetentionBox";
            this.typeDetentionBox.Size = new System.Drawing.Size(322, 26);
            this.typeDetentionBox.TabIndex = 36;
            // 
            // detentionReason
            // 
            this.detentionReason.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detentionReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.detentionReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detentionReason.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detentionReason.ForeColor = System.Drawing.Color.White;
            this.detentionReason.Location = new System.Drawing.Point(142, 542);
            this.detentionReason.Multiline = true;
            this.detentionReason.Name = "detentionReason";
            this.detentionReason.Size = new System.Drawing.Size(717, 59);
            this.detentionReason.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(137, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Motivo:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Red;
            this.addBtn.Location = new System.Drawing.Point(142, 651);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(717, 50);
            this.addBtn.TabIndex = 33;
            this.addBtn.Text = "Modificar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(532, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(103, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 70);
            this.label1.TabIndex = 25;
            this.label1.Text = "DETENCIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(137, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estudiante:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(532, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 27);
            this.label10.TabIndex = 30;
            this.label10.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(137, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(532, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 27);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tipo de Detencion:";
            // 
            // estudianteBox
            // 
            this.estudianteBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estudianteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.estudianteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estudianteBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudianteBox.ForeColor = System.Drawing.Color.White;
            this.estudianteBox.Location = new System.Drawing.Point(142, 194);
            this.estudianteBox.Name = "estudianteBox";
            this.estudianteBox.Size = new System.Drawing.Size(322, 26);
            this.estudianteBox.TabIndex = 29;
            this.estudianteBox.TextChanged += new System.EventHandler(this.estudianteBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 12.8F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(137, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cantidad de Detenciones:";
            // 
            // UpdateDetentionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 742);
            this.Controls.Add(this.formPanel);
            this.Name = "UpdateDetentionForm";
            this.Text = "UpdateDetentionForm";
            this.Load += new System.EventHandler(this.UpdateDetentionForm_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detentionAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.ComboBox gradeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker detentionDate;
        private System.Windows.Forms.NumericUpDown detentionAmount;
        private System.Windows.Forms.ComboBox matriculaBox;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.ComboBox typeDetentionBox;
        private System.Windows.Forms.TextBox detentionReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox estudianteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plateErrMsg;
    }
}