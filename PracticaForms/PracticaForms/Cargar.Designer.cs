namespace PracticaForms
{
    partial class Cargar
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
            gbxDatosPrincipales = new GroupBox();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            cbxCarrera = new ComboBox();
            gbxTurno = new GroupBox();
            rdbManiana = new RadioButton();
            rdbTarde = new RadioButton();
            rdbVespertino = new RadioButton();
            groupBox1 = new GroupBox();
            check_CSharp = new CheckBox();
            check_JavaScript = new CheckBox();
            check_Cobol = new CheckBox();
            check_Android = new CheckBox();
            check_Cplusplus = new CheckBox();
            check_Python = new CheckBox();
            gbxDatosPrincipales.SuspendLayout();
            gbxTurno.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosPrincipales
            // 
            gbxDatosPrincipales.Controls.Add(cbxCarrera);
            gbxDatosPrincipales.Controls.Add(txbApellido);
            gbxDatosPrincipales.Controls.Add(txbNombre);
            gbxDatosPrincipales.Location = new Point(12, 38);
            gbxDatosPrincipales.Name = "gbxDatosPrincipales";
            gbxDatosPrincipales.Size = new Size(161, 160);
            gbxDatosPrincipales.TabIndex = 0;
            gbxDatosPrincipales.TabStop = false;
            gbxDatosPrincipales.Text = "Datos principales";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(32, 37);
            txbNombre.Name = "txbNombre";
            txbNombre.PlaceholderText = "nombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            txbApellido.Location = new Point(32, 76);
            txbApellido.Name = "txbApellido";
            txbApellido.PlaceholderText = "apellido";
            txbApellido.Size = new Size(100, 23);
            txbApellido.TabIndex = 1;
            // 
            // cbxCarrera
            // 
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Location = new Point(32, 122);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(100, 23);
            cbxCarrera.TabIndex = 2;
            // 
            // gbxTurno
            // 
            gbxTurno.Controls.Add(rdbVespertino);
            gbxTurno.Controls.Add(rdbTarde);
            gbxTurno.Controls.Add(rdbManiana);
            gbxTurno.Location = new Point(215, 38);
            gbxTurno.Name = "gbxTurno";
            gbxTurno.Size = new Size(109, 160);
            gbxTurno.TabIndex = 1;
            gbxTurno.TabStop = false;
            gbxTurno.Text = "Turno";
            // 
            // rdbManiana
            // 
            rdbManiana.AutoSize = true;
            rdbManiana.Location = new Point(6, 37);
            rdbManiana.Name = "rdbManiana";
            rdbManiana.Size = new Size(68, 19);
            rdbManiana.TabIndex = 2;
            rdbManiana.TabStop = true;
            rdbManiana.Text = "Mañana";
            rdbManiana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(6, 80);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(53, 19);
            rdbTarde.TabIndex = 3;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "Tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            rdbVespertino.AutoSize = true;
            rdbVespertino.Location = new Point(6, 126);
            rdbVespertino.Name = "rdbVespertino";
            rdbVespertino.Size = new Size(80, 19);
            rdbVespertino.TabIndex = 4;
            rdbVespertino.TabStop = true;
            rdbVespertino.Text = "Vespertino";
            rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(check_Python);
            groupBox1.Controls.Add(check_Cplusplus);
            groupBox1.Controls.Add(check_Android);
            groupBox1.Controls.Add(check_Cobol);
            groupBox1.Controls.Add(check_JavaScript);
            groupBox1.Controls.Add(check_CSharp);
            groupBox1.Location = new Point(12, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 103);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Materias";
            // 
            // check_CSharp
            // 
            check_CSharp.AutoSize = true;
            check_CSharp.Location = new Point(32, 22);
            check_CSharp.Name = "check_CSharp";
            check_CSharp.Size = new Size(41, 19);
            check_CSharp.TabIndex = 0;
            check_CSharp.Text = "C#";
            check_CSharp.UseVisualStyleBackColor = true;
            // 
            // check_JavaScript
            // 
            check_JavaScript.AutoSize = true;
            check_JavaScript.Location = new Point(32, 61);
            check_JavaScript.Name = "check_JavaScript";
            check_JavaScript.Size = new Size(78, 19);
            check_JavaScript.TabIndex = 1;
            check_JavaScript.Text = "JavaScript";
            check_JavaScript.UseVisualStyleBackColor = true;
            // 
            // check_Cobol
            // 
            check_Cobol.AutoSize = true;
            check_Cobol.Location = new Point(121, 22);
            check_Cobol.Name = "check_Cobol";
            check_Cobol.Size = new Size(58, 19);
            check_Cobol.TabIndex = 2;
            check_Cobol.Text = "Cobol";
            check_Cobol.UseVisualStyleBackColor = true;
            // 
            // check_Android
            // 
            check_Android.AutoSize = true;
            check_Android.Location = new Point(121, 61);
            check_Android.Name = "check_Android";
            check_Android.Size = new Size(69, 19);
            check_Android.TabIndex = 3;
            check_Android.Text = "Android";
            check_Android.UseVisualStyleBackColor = true;
            // 
            // check_Cplusplus
            // 
            check_Cplusplus.AutoSize = true;
            check_Cplusplus.Location = new Point(209, 22);
            check_Cplusplus.Name = "check_Cplusplus";
            check_Cplusplus.Size = new Size(50, 19);
            check_Cplusplus.TabIndex = 4;
            check_Cplusplus.Text = "C++";
            check_Cplusplus.UseVisualStyleBackColor = true;
            // 
            // check_Python
            // 
            check_Python.AutoSize = true;
            check_Python.Location = new Point(209, 61);
            check_Python.Name = "check_Python";
            check_Python.Size = new Size(64, 19);
            check_Python.TabIndex = 5;
            check_Python.Text = "Python";
            check_Python.UseVisualStyleBackColor = true;
            // 
            // Cargar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(354, 357);
            Controls.Add(groupBox1);
            Controls.Add(gbxTurno);
            Controls.Add(gbxDatosPrincipales);
            Name = "Cargar";
            Text = "Cargar";
            gbxDatosPrincipales.ResumeLayout(false);
            gbxDatosPrincipales.PerformLayout();
            gbxTurno.ResumeLayout(false);
            gbxTurno.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatosPrincipales;
        private ComboBox cbxCarrera;
        private TextBox txbApellido;
        private TextBox txbNombre;
        private GroupBox gbxTurno;
        private RadioButton rdbVespertino;
        private RadioButton rdbTarde;
        private RadioButton rdbManiana;
        private GroupBox groupBox1;
        private CheckBox check_Python;
        private CheckBox check_Cplusplus;
        private CheckBox check_Android;
        private CheckBox check_Cobol;
        private CheckBox check_JavaScript;
        private CheckBox check_CSharp;
    }
}