﻿namespace FormPrincipal
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
            dgv_principal = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_principal).BeginInit();
            SuspendLayout();
            // 
            // dgv_principal
            // 
            dgv_principal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_principal.Location = new Point(12, 12);
            dgv_principal.Name = "dgv_principal";
            dgv_principal.Size = new Size(776, 377);
            dgv_principal.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(358, 415);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_principal);
            Name = "FormPrincipal";
            Text = "Formulario Principal";
            ((System.ComponentModel.ISupportInitialize)dgv_principal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_principal;
        private Button btn_agregar;
    }
}