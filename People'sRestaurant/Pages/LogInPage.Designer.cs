namespace People_sRestaurant
{
    partial class LogInPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            usernameField = new TextBox();
            passwordField = new TextBox();
            label1 = new Label();
            passworLabel = new Label();
            LNButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameField.Location = new Point(176, 356);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(125, 26);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordField.Location = new Point(344, 356);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(125, 26);
            passwordField.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(176, 333);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // passworLabel
            // 
            passworLabel.AutoSize = true;
            passworLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passworLabel.Location = new Point(344, 333);
            passworLabel.Name = "passworLabel";
            passworLabel.Size = new Size(79, 20);
            passworLabel.TabIndex = 7;
            passworLabel.Text = "Password";
            // 
            // LNButton
            // 
            LNButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LNButton.Location = new Point(520, 354);
            LNButton.Name = "LNButton";
            LNButton.Size = new Size(94, 29);
            LNButton.TabIndex = 8;
            LNButton.Text = "Log in";
            LNButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            LNButton.UseVisualStyleBackColor = true;
            LNButton.Click += LNButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(115, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 259);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(LNButton);
            Controls.Add(passworLabel);
            Controls.Add(label1);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Name = "LogInPage";
            Text = "LogInPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameField;
        private TextBox passwordField;
        private Label label1;
        private Label passworLabel;
        private Button LNButton;
        private PictureBox pictureBox1;
    }
}