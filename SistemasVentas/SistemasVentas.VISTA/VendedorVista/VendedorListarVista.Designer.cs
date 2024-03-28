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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(772, 261);
            dataGridView1.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Beige;
            button2.Font = new Font("Franklin Gothic Heavy", 18F);
            button2.ForeColor = Color.FromArgb(0, 64, 64);
            button2.Location = new Point(416, 388);
            button2.Name = "button2";
            button2.Size = new Size(166, 58);
            button2.TabIndex = 15;
            button2.Text = "Editar Venta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.Font = new Font("Franklin Gothic Heavy", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(631, 372);
            button1.Name = "button1";
            button1.Size = new Size(146, 86);
            button1.TabIndex = 14;
            button1.Text = "NUEVA VENTA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lemon Friday", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(244, 4);
            label2.Name = "label2";
            label2.Size = new Size(283, 48);
            label2.TabIndex = 18;
            label2.Text = "SUPERMERCADO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(644, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lemon Friday", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(306, 52);
            label1.Name = "label1";
            label1.Size = new Size(168, 48);
            label1.TabIndex = 20;
            label1.Text = "\"AHISITO\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 372);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 21;
            label3.Text = "Cajero/a:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Trebuchet MS", 15.75F);
            textBox1.Location = new Point(19, 401);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(207, 45);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // VendedorListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 194, 180);
            ClientSize = new Size(800, 468);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "VendedorListarVista";
            Text = "VendedorListarVista";
            Load += VendedorListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
    }
}