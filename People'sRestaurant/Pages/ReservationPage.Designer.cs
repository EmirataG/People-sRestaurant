namespace People_sRestaurant.Pages
{
    partial class ReservationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationPage));
            dataGridView = new DataGridView();
            welcomeGreeting = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 122);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(863, 247);
            dataGridView.TabIndex = 0;
            // 
            // welcomeGreeting
            // 
            welcomeGreeting.AutoSize = true;
            welcomeGreeting.BackColor = Color.Transparent;
            welcomeGreeting.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeGreeting.ForeColor = SystemColors.ButtonHighlight;
            welcomeGreeting.Location = new Point(89, 62);
            welcomeGreeting.Name = "welcomeGreeting";
            welcomeGreeting.Size = new Size(738, 26);
            welcomeGreeting.TabIndex = 12;
            welcomeGreeting.Text = "Welcome, Emir. These are all the reservations made from you profile:";
            // 
            // backButton
            // 
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(350, 403);
            backButton.Name = "backButton";
            backButton.Size = new Size(219, 29);
            backButton.TabIndex = 13;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ReservationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(913, 506);
            Controls.Add(backButton);
            Controls.Add(welcomeGreeting);
            Controls.Add(dataGridView);
            Name = "ReservationPage";
            Text = "ReservationPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label welcomeGreeting;
        private Button backButton;
    }
}