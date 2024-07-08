namespace PracticaTruchaParc
{
    partial class FormAlta
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
            gbxHardware = new GroupBox();
            numericDisco = new NumericUpDown();
            numericRam = new NumericUpDown();
            cbxProcesador = new ComboBox();
            gbxSistemaOperativo = new GroupBox();
            rdbMacOs = new RadioButton();
            rdbLinux = new RadioButton();
            rdbWindows = new RadioButton();
            gbxProgramas = new GroupBox();
            chbxAvast = new CheckBox();
            chbxDropbox = new CheckBox();
            chbxWinrar = new CheckBox();
            chbxReader = new CheckBox();
            chbxOffice = new CheckBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gbxHardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDisco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRam).BeginInit();
            gbxSistemaOperativo.SuspendLayout();
            gbxProgramas.SuspendLayout();
            SuspendLayout();
            // 
            // gbxHardware
            // 
            gbxHardware.Controls.Add(label3);
            gbxHardware.Controls.Add(label2);
            gbxHardware.Controls.Add(label1);
            gbxHardware.Controls.Add(numericDisco);
            gbxHardware.Controls.Add(numericRam);
            gbxHardware.Controls.Add(cbxProcesador);
            gbxHardware.Location = new Point(85, 49);
            gbxHardware.Name = "gbxHardware";
            gbxHardware.Size = new Size(277, 292);
            gbxHardware.TabIndex = 0;
            gbxHardware.TabStop = false;
            gbxHardware.Text = "Hardware";
            // 
            // numericDisco
            // 
            numericDisco.Location = new Point(121, 214);
            numericDisco.Name = "numericDisco";
            numericDisco.Size = new Size(150, 27);
            numericDisco.TabIndex = 2;
            // 
            // numericRam
            // 
            numericRam.Location = new Point(121, 148);
            numericRam.Name = "numericRam";
            numericRam.Size = new Size(150, 27);
            numericRam.TabIndex = 1;
            // 
            // cbxProcesador
            // 
            cbxProcesador.FormattingEnabled = true;
            cbxProcesador.Location = new Point(120, 81);
            cbxProcesador.Name = "cbxProcesador";
            cbxProcesador.Size = new Size(151, 28);
            cbxProcesador.TabIndex = 0;
            // 
            // gbxSistemaOperativo
            // 
            gbxSistemaOperativo.Controls.Add(rdbMacOs);
            gbxSistemaOperativo.Controls.Add(rdbLinux);
            gbxSistemaOperativo.Controls.Add(rdbWindows);
            gbxSistemaOperativo.Location = new Point(445, 49);
            gbxSistemaOperativo.Name = "gbxSistemaOperativo";
            gbxSistemaOperativo.Size = new Size(192, 173);
            gbxSistemaOperativo.TabIndex = 1;
            gbxSistemaOperativo.TabStop = false;
            gbxSistemaOperativo.Text = "Sistema operativo";
            // 
            // rdbMacOs
            // 
            rdbMacOs.AutoSize = true;
            rdbMacOs.Location = new Point(58, 116);
            rdbMacOs.Name = "rdbMacOs";
            rdbMacOs.Size = new Size(77, 24);
            rdbMacOs.TabIndex = 2;
            rdbMacOs.TabStop = true;
            rdbMacOs.Text = "MacOS";
            rdbMacOs.UseVisualStyleBackColor = true;
            // 
            // rdbLinux
            // 
            rdbLinux.AutoSize = true;
            rdbLinux.Location = new Point(58, 71);
            rdbLinux.Name = "rdbLinux";
            rdbLinux.Size = new Size(64, 24);
            rdbLinux.TabIndex = 1;
            rdbLinux.TabStop = true;
            rdbLinux.Text = "Linux";
            rdbLinux.UseVisualStyleBackColor = true;
            // 
            // rdbWindows
            // 
            rdbWindows.AutoSize = true;
            rdbWindows.Location = new Point(58, 26);
            rdbWindows.Name = "rdbWindows";
            rdbWindows.Size = new Size(91, 24);
            rdbWindows.TabIndex = 0;
            rdbWindows.TabStop = true;
            rdbWindows.Text = "Windows";
            rdbWindows.UseVisualStyleBackColor = true;
            // 
            // gbxProgramas
            // 
            gbxProgramas.Controls.Add(chbxAvast);
            gbxProgramas.Controls.Add(chbxDropbox);
            gbxProgramas.Controls.Add(chbxWinrar);
            gbxProgramas.Controls.Add(chbxReader);
            gbxProgramas.Controls.Add(chbxOffice);
            gbxProgramas.Location = new Point(445, 228);
            gbxProgramas.Name = "gbxProgramas";
            gbxProgramas.Size = new Size(192, 199);
            gbxProgramas.TabIndex = 1;
            gbxProgramas.TabStop = false;
            gbxProgramas.Text = "Programas";
            // 
            // chbxAvast
            // 
            chbxAvast.AutoSize = true;
            chbxAvast.Location = new Point(58, 149);
            chbxAvast.Name = "chbxAvast";
            chbxAvast.Size = new Size(67, 24);
            chbxAvast.TabIndex = 4;
            chbxAvast.Text = "Avast";
            chbxAvast.UseVisualStyleBackColor = true;
            // 
            // chbxDropbox
            // 
            chbxDropbox.AutoSize = true;
            chbxDropbox.Location = new Point(58, 119);
            chbxDropbox.Name = "chbxDropbox";
            chbxDropbox.Size = new Size(90, 24);
            chbxDropbox.TabIndex = 3;
            chbxDropbox.Text = "Dropbox";
            chbxDropbox.UseVisualStyleBackColor = true;
            // 
            // chbxWinrar
            // 
            chbxWinrar.AutoSize = true;
            chbxWinrar.Location = new Point(58, 89);
            chbxWinrar.Name = "chbxWinrar";
            chbxWinrar.Size = new Size(75, 24);
            chbxWinrar.TabIndex = 2;
            chbxWinrar.Text = "Winrar";
            chbxWinrar.UseVisualStyleBackColor = true;
            // 
            // chbxReader
            // 
            chbxReader.AutoSize = true;
            chbxReader.Location = new Point(58, 60);
            chbxReader.Name = "chbxReader";
            chbxReader.Size = new Size(123, 24);
            chbxReader.TabIndex = 1;
            chbxReader.Text = "Adobe reader";
            chbxReader.UseVisualStyleBackColor = true;
            // 
            // chbxOffice
            // 
            chbxOffice.AutoSize = true;
            chbxOffice.Location = new Point(58, 30);
            chbxOffice.Name = "chbxOffice";
            chbxOffice.Size = new Size(71, 24);
            chbxOffice.TabIndex = 0;
            chbxOffice.Text = "Office";
            chbxOffice.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(268, 468);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(480, 468);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 84);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Procesador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 150);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Memoria ram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 216);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Disco";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 528);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(gbxSistemaOperativo);
            Controls.Add(gbxProgramas);
            Controls.Add(gbxHardware);
            Name = "FormAlta";
            Text = "FormAlta";
            gbxHardware.ResumeLayout(false);
            gbxHardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDisco).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRam).EndInit();
            gbxSistemaOperativo.ResumeLayout(false);
            gbxSistemaOperativo.PerformLayout();
            gbxProgramas.ResumeLayout(false);
            gbxProgramas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxHardware;
        private GroupBox gbxSistemaOperativo;
        private GroupBox gbxProgramas;
        private Button btnAgregar;
        private Button btnCancelar;
        private RadioButton rdbMacOs;
        private RadioButton rdbLinux;
        private RadioButton rdbWindows;
        private CheckBox chbxAvast;
        private CheckBox chbxDropbox;
        private CheckBox chbxWinrar;
        private CheckBox chbxReader;
        private CheckBox chbxOffice;
        private NumericUpDown numericDisco;
        private NumericUpDown numericRam;
        private ComboBox cbxProcesador;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}