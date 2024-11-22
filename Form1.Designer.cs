namespace WinFormsTablaDatos
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
            panel1 = new Panel();
            grilla = new DataGridView();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 255, 196);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(grilla);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // grilla
            // 
            grilla.BackgroundColor = Color.FromArgb(198, 226, 233);
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(76, 197);
            grilla.Name = "grilla";
            grilla.Size = new Size(661, 215);
            grilla.TabIndex = 6;
            grilla.CellContentClick += grilla_CellContentClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 202, 175);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Lucida Sans", 9F, FontStyle.Italic);
            btnLimpiar.Location = new Point(609, 63);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(128, 79);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 202, 175);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnGuardar.FlatAppearance.BorderSize = 3;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Lucida Sans", 9F, FontStyle.Italic);
            btnGuardar.Location = new Point(453, 63);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 79);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Lucida Sans", 9F, FontStyle.Italic);
            txtEdad.Location = new Point(200, 117);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(105, 22);
            txtEdad.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Lucida Sans", 9F, FontStyle.Italic);
            txtNombre.Location = new Point(200, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 22);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 9F, FontStyle.Italic);
            label2.Location = new Point(150, 125);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Italic);
            label1.Location = new Point(132, 63);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 7;
            label3.Text = "Jetzan Azael Esquivel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private DataGridView grilla;
        private Button btnLimpiar;
        private Button btnGuardar;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label label3;
    }
}
