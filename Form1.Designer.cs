
namespace gui_noelDOM
{
    partial class GUI
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_load_porst = new System.Windows.Forms.Button();
            this.Btn_conect = new System.Windows.Forms.Button();
            this.Text_box_send_data = new System.Windows.Forms.TextBox();
            this.btn_send_data = new System.Windows.Forms.Button();
            this.Track_Bar_Servo = new System.Windows.Forms.TrackBar();
            this.Label_pos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Servo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200",
            "230400",
            "1382400"});
            this.comboBox2.Location = new System.Drawing.Point(131, 63);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 23);
            this.comboBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // Btn_load_porst
            // 
            this.Btn_load_porst.Location = new System.Drawing.Point(12, 28);
            this.Btn_load_porst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_load_porst.Name = "Btn_load_porst";
            this.Btn_load_porst.Size = new System.Drawing.Size(87, 34);
            this.Btn_load_porst.TabIndex = 13;
            this.Btn_load_porst.Text = "Load Ports";
            this.Btn_load_porst.UseVisualStyleBackColor = true;
            this.Btn_load_porst.Click += new System.EventHandler(this.Btn_load_porst_Click);
            // 
            // Btn_conect
            // 
            this.Btn_conect.Location = new System.Drawing.Point(12, 67);
            this.Btn_conect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_conect.Name = "Btn_conect";
            this.Btn_conect.Size = new System.Drawing.Size(87, 31);
            this.Btn_conect.TabIndex = 12;
            this.Btn_conect.Text = "Connect";
            this.Btn_conect.UseVisualStyleBackColor = true;
            this.Btn_conect.Click += new System.EventHandler(this.Btn_conect_Click);
            // 
            // Text_box_send_data
            // 
            this.Text_box_send_data.Location = new System.Drawing.Point(105, 191);
            this.Text_box_send_data.Name = "Text_box_send_data";
            this.Text_box_send_data.Size = new System.Drawing.Size(86, 23);
            this.Text_box_send_data.TabIndex = 16;
            // 
            // btn_send_data
            // 
            this.btn_send_data.Location = new System.Drawing.Point(12, 186);
            this.btn_send_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_send_data.Name = "btn_send_data";
            this.btn_send_data.Size = new System.Drawing.Size(87, 31);
            this.btn_send_data.TabIndex = 17;
            this.btn_send_data.Text = "Sen data";
            this.btn_send_data.UseVisualStyleBackColor = true;
            this.btn_send_data.Click += new System.EventHandler(this.btn_send_data_Click);
            // 
            // Track_Bar_Servo
            // 
            this.Track_Bar_Servo.Location = new System.Drawing.Point(12, 124);
            this.Track_Bar_Servo.Maximum = 180;
            this.Track_Bar_Servo.Name = "Track_Bar_Servo";
            this.Track_Bar_Servo.Size = new System.Drawing.Size(299, 45);
            this.Track_Bar_Servo.SmallChange = 10;
            this.Track_Bar_Servo.TabIndex = 18;
            this.Track_Bar_Servo.ValueChanged += new System.EventHandler(this.Track_Bar_Servo_ValueChanged);
            // 
            // Label_pos
            // 
            this.Label_pos.AutoSize = true;
            this.Label_pos.Location = new System.Drawing.Point(262, 154);
            this.Label_pos.Name = "Label_pos";
            this.Label_pos.Size = new System.Drawing.Size(13, 15);
            this.Label_pos.TabIndex = 19;
            this.Label_pos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Servo GUI";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_pos);
            this.Controls.Add(this.Track_Bar_Servo);
            this.Controls.Add(this.btn_send_data);
            this.Controls.Add(this.Text_box_send_data);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btn_load_porst);
            this.Controls.Add(this.Btn_conect);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Track_Bar_Servo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_load_porst;
        private System.Windows.Forms.Button Btn_conect;
        private System.Windows.Forms.TextBox Text_box_send_data;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_send_data;
        private System.Windows.Forms.TrackBar Track_Bar_Servo;
        private System.Windows.Forms.Label Label_pos;
        private System.Windows.Forms.Label label1;
    }
}

