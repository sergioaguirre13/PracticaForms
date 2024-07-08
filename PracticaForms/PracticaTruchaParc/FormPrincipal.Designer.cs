namespace PracticaTruchaParc
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
            dtgListaComputadora = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListaComputadora).BeginInit();
            SuspendLayout();
            // 
            // dtgListaComputadora
            // 
            dtgListaComputadora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListaComputadora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaComputadora.Location = new Point(31, 25);
            dtgListaComputadora.Name = "dtgListaComputadora";
            dtgListaComputadora.RowHeadersWidth = 51;
            dtgListaComputadora.Size = new Size(725, 349);
            dtgListaComputadora.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(336, 407);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 487);
            Controls.Add(btnAgregar);
            Controls.Add(dtgListaComputadora);
            Name = "FormPrincipal";
            Text = "Principal";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListaComputadora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgListaComputadora;
        private Button btnAgregar;
    }
}
