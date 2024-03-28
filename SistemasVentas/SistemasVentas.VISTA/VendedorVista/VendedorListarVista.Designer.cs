namespace SistemasVentas.VISTA.VendedorVista
{
    partial class VendedorListarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendedorListarVista));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button15 = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 65);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(710, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 8);
            label2.Name = "label2";
            label2.Size = new Size(349, 45);
            label2.TabIndex = 12;
            label2.Text = "SISTEMA DE VENTAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(2, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 343);
            panel2.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(438, 296);
            button5.Name = "button5";
            button5.Size = new Size(149, 34);
            button5.TabIndex = 19;
            button5.Text = "CANCELAR";
            button5.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.MenuHighlight;
            button15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ControlLightLight;
            button15.Location = new Point(182, 296);
            button15.Name = "button15";
            button15.Size = new Size(149, 34);
            button15.TabIndex = 18;
            button15.Text = "VENDER";
            button15.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(772, 261);
            dataGridView1.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 255);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(2, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 49);
            panel3.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.CadetBlue;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(588, 13);
            button4.Name = "button4";
            button4.Size = new Size(113, 23);
            button4.TabIndex = 17;
            button4.Text = "DETALLE INGRESO";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(395, 13);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 16;
            button3.Text = "VENTA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(218, 13);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 15;
            button2.Text = "PRODUCTO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(41, 13);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 14;
            button1.Text = "CLIENTE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // VendedorListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VendedorListarVista";
            Text = "VendedorListarVista";
            Load += VendedorListarVista_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button15;
    }
}