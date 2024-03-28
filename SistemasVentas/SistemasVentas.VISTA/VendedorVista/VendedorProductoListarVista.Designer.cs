namespace SistemasVentas.VISTA.VendedorVista
{
    partial class VendedorProductoListarVista
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
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 90);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 22);
            label2.Name = "label2";
            label2.Size = new Size(367, 45);
            label2.TabIndex = 13;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 364);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(371, 266);
            dataGridView1.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(56, 299);
            button3.Name = "button3";
            button3.Size = new Size(97, 34);
            button3.TabIndex = 18;
            button3.Text = "GUARDAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(205, 299);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 19;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // VendedorProductoListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "VendedorProductoListarVista";
            Text = "VendedorProductoListarVista";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
    }
}