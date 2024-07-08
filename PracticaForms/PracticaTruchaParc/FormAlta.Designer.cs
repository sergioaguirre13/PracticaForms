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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            gbxHardware.Location = new Point(74, 37);
            gbxHardware.Margin = new Padding(3, 2, 3, 2);
            gbxHardware.Name = "gbxHardware";
            gbxHardware.Padding = new Padding(3, 2, 3, 2);
            gbxHardware.Size = new Size(280, 283);
            gbxHardware.TabIndex = 0;
            gbxHardware.TabStop = false;
            gbxHardware.Text = "Hardware";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 162);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Disco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 112);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Memoria ram";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 63);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Procesador";
            // 
            // numericDisco
            // 
            numericDisco.Location = new Point(106, 160);
            numericDisco.Margin = new Padding(3, 2, 3, 2);
            numericDisco.Name = "numericDisco";
            numericDisco.Size = new Size(131, 23);
            numericDisco.TabIndex = 2;
            // 
            // numericRam
            // 
            numericRam.Location = new Point(106, 111);
            numericRam.Margin = new Padding(3, 2, 3, 2);
            numericRam.Name = "numericRam";
            numericRam.Size = new Size(131, 23);
            numericRam.TabIndex = 1;
            // 
            // cbxProcesador
            // 
            cbxProcesador.FormattingEnabled = true;
            cbxProcesador.Location = new Point(105, 61);
            cbxProcesador.Margin = new Padding(3, 2, 3, 2);
            cbxProcesador.Name = "cbxProcesador";
            cbxProcesador.Size = new Size(133, 23);
            cbxProcesador.TabIndex = 0;
            // 
            // gbxSistemaOperativo
            // 
            gbxSistemaOperativo.Controls.Add(rdbMacOs);
            gbxSistemaOperativo.Controls.Add(rdbLinux);
            gbxSistemaOperativo.Controls.Add(rdbWindows);
            gbxSistemaOperativo.Location = new Point(389, 37);
            gbxSistemaOperativo.Margin = new Padding(3, 2, 3, 2);
            gbxSistemaOperativo.Name = "gbxSistemaOperativo";
            gbxSistemaOperativo.Padding = new Padding(3, 2, 3, 2);
            gbxSistemaOperativo.Size = new Size(168, 130);
            gbxSistemaOperativo.TabIndex = 1;
            gbxSistemaOperativo.TabStop = false;
            gbxSistemaOperativo.Text = "Sistema operativo";
            // 
            // rdbMacOs
            // 
            rdbMacOs.AutoSize = true;
            rdbMacOs.Location = new Point(49, 98);
            rdbMacOs.Margin = new Padding(3, 2, 3, 2);
            rdbMacOs.Name = "rdbMacOs";
            rdbMacOs.Size = new Size(63, 19);
            rdbMacOs.TabIndex = 2;
            rdbMacOs.TabStop = true;
            rdbMacOs.Text = "MacOS";
            rdbMacOs.UseVisualStyleBackColor = true;
            // 
            // rdbLinux
            // 
            rdbLinux.AutoSize = true;
            rdbLinux.Location = new Point(49, 64);
            rdbLinux.Margin = new Padding(3, 2, 3, 2);
            rdbLinux.Name = "rdbLinux";
            rdbLinux.Size = new Size(54, 19);
            rdbLinux.TabIndex = 1;
            rdbLinux.TabStop = true;
            rdbLinux.Text = "Linux";
            rdbLinux.UseVisualStyleBackColor = true;
            // 
            // rdbWindows
            // 
            rdbWindows.AutoSize = true;
            rdbWindows.Location = new Point(49, 31);
            rdbWindows.Margin = new Padding(3, 2, 3, 2);
            rdbWindows.Name = "rdbWindows";
            rdbWindows.Size = new Size(74, 19);
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
            gbxProgramas.Location = new Point(389, 171);
            gbxProgramas.Margin = new Padding(3, 2, 3, 2);
            gbxProgramas.Name = "gbxProgramas";
            gbxProgramas.Padding = new Padding(3, 2, 3, 2);
            gbxProgramas.Size = new Size(168, 149);
            gbxProgramas.TabIndex = 1;
            gbxProgramas.TabStop = false;
            gbxProgramas.Text = "Programas";
            // 
            // chbxAvast
            // 
            chbxAvast.AutoSize = true;
            chbxAvast.Location = new Point(51, 112);
            chbxAvast.Margin = new Padding(3, 2, 3, 2);
            chbxAvast.Name = "chbxAvast";
            chbxAvast.Size = new Size(55, 19);
            chbxAvast.TabIndex = 4;
            chbxAvast.Text = "Avast";
            chbxAvast.UseVisualStyleBackColor = true;
            // 
            // chbxDropbox
            // 
            chbxDropbox.AutoSize = true;
            chbxDropbox.Location = new Point(51, 89);
            chbxDropbox.Margin = new Padding(3, 2, 3, 2);
            chbxDropbox.Name = "chbxDropbox";
            chbxDropbox.Size = new Size(72, 19);
            chbxDropbox.TabIndex = 3;
            chbxDropbox.Text = "Dropbox";
            chbxDropbox.UseVisualStyleBackColor = true;
            // 
            // chbxWinrar
            // 
            chbxWinrar.AutoSize = true;
            chbxWinrar.Location = new Point(51, 67);
            chbxWinrar.Margin = new Padding(3, 2, 3, 2);
            chbxWinrar.Name = "chbxWinrar";
            chbxWinrar.Size = new Size(61, 19);
            chbxWinrar.TabIndex = 2;
            chbxWinrar.Text = "Winrar";
            chbxWinrar.UseVisualStyleBackColor = true;
            // 
            // chbxReader
            // 
            chbxReader.AutoSize = true;
            chbxReader.Location = new Point(51, 45);
            chbxReader.Margin = new Padding(3, 2, 3, 2);
            chbxReader.Name = "chbxReader";
            chbxReader.Size = new Size(97, 19);
            chbxReader.TabIndex = 1;
            chbxReader.Text = "Adobe reader";
            chbxReader.UseVisualStyleBackColor = true;
            // 
            // chbxOffice
            // 
            chbxOffice.AutoSize = true;
            chbxOffice.Location = new Point(51, 22);
            chbxOffice.Margin = new Padding(3, 2, 3, 2);
            chbxOffice.Name = "chbxOffice";
            chbxOffice.Size = new Size(58, 19);
            chbxOffice.TabIndex = 0;
            chbxOffice.Text = "Office";
            chbxOffice.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(234, 351);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 351);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 396);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(gbxSistemaOperativo);
            Controls.Add(gbxProgramas);
            Controls.Add(gbxHardware);
            Margin = new Padding(3, 2, 3, 2);
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