namespace INF_UE_Mondlandung
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbRocket = new PictureBox();
            btStart = new Button();
            tiTimer1 = new System.Windows.Forms.Timer(components);
            btBreak90 = new Button();
            btBreak30 = new Button();
            btBreak10 = new Button();
            lblResult = new Label();
            btReset = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbRocket).BeginInit();
            SuspendLayout();
            // 
            // pbRocket
            // 
            pbRocket.Image = (Image)resources.GetObject("pbRocket.Image");
            pbRocket.Location = new Point(504, 12);
            pbRocket.Name = "pbRocket";
            pbRocket.Size = new Size(119, 140);
            pbRocket.TabIndex = 0;
            pbRocket.TabStop = false;
            // 
            // btStart
            // 
            btStart.Location = new Point(961, 26);
            btStart.Name = "btStart";
            btStart.Size = new Size(150, 46);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // tiTimer1
            // 
            tiTimer1.Interval = 250;
            tiTimer1.Tick += tiTimer1_Tick;
            // 
            // btBreak90
            // 
            btBreak90.Location = new Point(961, 210);
            btBreak90.Name = "btBreak90";
            btBreak90.Size = new Size(150, 46);
            btBreak90.TabIndex = 2;
            btBreak90.Text = "Break 90";
            btBreak90.UseVisualStyleBackColor = true;
            btBreak90.Click += btBreak90_Click;
            // 
            // btBreak30
            // 
            btBreak30.Location = new Point(961, 158);
            btBreak30.Name = "btBreak30";
            btBreak30.Size = new Size(150, 46);
            btBreak30.TabIndex = 3;
            btBreak30.Text = "Break 30";
            btBreak30.UseVisualStyleBackColor = true;
            btBreak30.Click += btBreak30_Click;
            // 
            // btBreak10
            // 
            btBreak10.Location = new Point(961, 106);
            btBreak10.Name = "btBreak10";
            btBreak10.Size = new Size(150, 46);
            btBreak10.TabIndex = 4;
            btBreak10.Text = "Break 10";
            btBreak10.UseVisualStyleBackColor = true;
            btBreak10.Click += btBreak10_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(85, 44);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 50);
            lblResult.TabIndex = 5;
            lblResult.Text = "? ";
            // 
            // btReset
            // 
            btReset.Location = new Point(973, 800);
            btReset.Name = "btReset";
            btReset.Size = new Size(150, 46);
            btReset.TabIndex = 6;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 1098);
            label1.Name = "label1";
            label1.Size = new Size(1172, 36);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 1132);
            Controls.Add(label1);
            Controls.Add(btReset);
            Controls.Add(lblResult);
            Controls.Add(btBreak10);
            Controls.Add(btBreak30);
            Controls.Add(btBreak90);
            Controls.Add(btStart);
            Controls.Add(pbRocket);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbRocket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbRocket;
        private Button btStart;
        private System.Windows.Forms.Timer tiTimer1;
        private Button btBreak90;
        private Button btBreak30;
        private Button btBreak10;
        private Label lblResult;
        private Button btReset;
        private Label label1;
    }
}
