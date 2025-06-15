namespace Pruebasv2
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
            curp1 = new CurpLibrery.Curp();
            SuspendLayout();
            // 
            // curp1
            // 
            curp1.CurpGenerada = null;
            curp1.Estado = "";
            curp1.FechaNacimiento = new DateTime(2025, 6, 14, 19, 41, 53, 39);
            curp1.Genero = "";
            curp1.Location = new Point(72, 45);
            curp1.Name = "curp1";
            curp1.Nombre = "";
            curp1.PrimerApellido = "";
            curp1.SegundoApellido = "";
            curp1.Size = new Size(1095, 1125);
            curp1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 837);
            Controls.Add(curp1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CurpLibrery.Curp curp1;
    }
}
