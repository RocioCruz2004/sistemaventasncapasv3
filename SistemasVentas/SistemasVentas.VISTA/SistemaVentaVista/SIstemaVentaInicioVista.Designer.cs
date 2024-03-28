namespace SistemasVentas.VISTA.SistemaVentaVista
{
    partial class SistemaVentaInicioVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaVentaInicioVista));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            txtusername = new TextBox();
            txtcontra = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lemon Friday", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(350, 18);
            label2.Name = "label2";
            label2.Size = new Size(254, 48);
            label2.TabIndex = 10;
            label2.Text = "INICIAR SESIÓN";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSalmon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lemon Friday", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(570, 236);
            button1.Name = "button1";
            button1.Size = new Size(82, 57);
            button1.TabIndex = 15;
            button1.Text = "IR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(371, 94);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(245, 32);
            txtusername.TabIndex = 16;
            txtusername.Text = "Username";
            // 
            // txtcontra
            // 
            txtcontra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcontra.Location = new Point(374, 182);
            txtcontra.Name = "txtcontra";
            txtcontra.PasswordChar = '*';
            txtcontra.Size = new Size(245, 35);
            txtcontra.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(313, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(319, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Trebuchet MS", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Cajero", "Supervisor" });
            comboBox1.Location = new Point(313, 250);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 35);
            comboBox1.TabIndex = 22;
            comboBox1.Text = "Rol";
            // 
            // SistemaVentaInicioVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(681, 319);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtcontra);
            Controls.Add(txtusername);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "SistemaVentaInicioVista";
            Text = "SistemaVentaInicioVista";
            Load += SistemaVentaInicioVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private TextBox txtusername;
        private TextBox txtcontra;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
    }
}