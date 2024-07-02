namespace PracticaForms
{
    partial class FormPrincipal
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
            dgvListaEstudiantes = new DataGridView();
            btnAgregar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // dgvListaEstudiantes
            // 
            dgvListaEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaEstudiantes.Location = new Point(12, 26);
            dgvListaEstudiantes.Name = "dgvListaEstudiantes";
            dgvListaEstudiantes.Size = new Size(474, 272);
            dgvListaEstudiantes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(91, 332);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.ForeColor = Color.Red;
            btnBorrar.Location = new Point(279, 332);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(106, 33);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(498, 409);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvListaEstudiantes);
            Name = "FormPrincipal";
            Text = "Principal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaEstudiantes;
        private Button btnAgregar;
        private Button btnBorrar;
    }
}
