namespace Proyecto_Final____Sistema_de_Gestión_de_Clínica_Veterinaria
{
    partial class Sistema_de_Gestión_Veterinaria_JOSE_PARDO
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
            btnPacientes = new Button();
            panel1 = new Panel();
            titulosistema = new Label();
            btnCitas = new Button();
            btnTratamientos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.SkyBlue;
            btnPacientes.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientes.Location = new Point(103, 287);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(340, 150);
            btnPacientes.TabIndex = 0;
            btnPacientes.Text = "PACIENTES";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(titulosistema);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 90);
            panel1.TabIndex = 1;
            // 
            // titulosistema
            // 
            titulosistema.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            titulosistema.ForeColor = SystemColors.ButtonHighlight;
            titulosistema.Location = new Point(28, 24);
            titulosistema.Name = "titulosistema";
            titulosistema.Size = new Size(1200, 38);
            titulosistema.TabIndex = 2;
            titulosistema.Text = "SISTEMA DE GESTION VETERINARIA";
            titulosistema.TextAlign = ContentAlignment.TopCenter;
            titulosistema.Click += label1_Click;
            // 
            // btnCitas
            // 
            btnCitas.Anchor = AnchorStyles.Top;
            btnCitas.BackColor = Color.SkyBlue;
            btnCitas.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCitas.Location = new Point(464, 287);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(340, 150);
            btnCitas.TabIndex = 2;
            btnCitas.Text = "CITAS";
            btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnTratamientos
            // 
            btnTratamientos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTratamientos.BackColor = Color.SkyBlue;
            btnTratamientos.Font = new Font("Montserrat", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTratamientos.Location = new Point(823, 287);
            btnTratamientos.Name = "btnTratamientos";
            btnTratamientos.Size = new Size(340, 150);
            btnTratamientos.TabIndex = 3;
            btnTratamientos.Text = "TRATAMIENTOS";
            btnTratamientos.UseVisualStyleBackColor = false;
            // 
            // Sistema_de_Gestión_Veterinaria_JOSE_PARDO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnTratamientos);
            Controls.Add(btnCitas);
            Controls.Add(panel1);
            Controls.Add(btnPacientes);
            Name = "Sistema_de_Gestión_Veterinaria_JOSE_PARDO";
            Text = "Sistema de Gestión Veterinaria JOSE PARDO";
            Load += Sistema_de_Gestión_Veterinaria_JOSE_PARDO_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPacientes;
        private Panel panel1;
        private Label titulosistema;
        private Button btnCitas;
        private Button btnTratamientos;
    }
}
