namespace People_sRestaurant.Pages
{
    partial class BookingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingPage));
            label = new Label();
            tableLabel = new Label();
            telBox = new TextBox();
            telephoneLabel = new Label();
            nameBox = new TextBox();
            nameLabel = new Label();
            detailsLabel = new Label();
            bookButton = new Button();
            fromLabel = new Label();
            toLabel = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(48, 50);
            label.Name = "label";
            label.Size = new Size(188, 22);
            label.TabIndex = 17;
            label.Text = "Reservation Details:";
            // 
            // tableLabel
            // 
            tableLabel.AutoSize = true;
            tableLabel.BackColor = Color.Transparent;
            tableLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tableLabel.ForeColor = SystemColors.ButtonHighlight;
            tableLabel.Location = new Point(48, 101);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(141, 22);
            tableLabel.TabIndex = 16;
            tableLabel.Text = "Table number:";
            // 
            // telBox
            // 
            telBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            telBox.Location = new Point(48, 357);
            telBox.Name = "telBox";
            telBox.Size = new Size(186, 30);
            telBox.TabIndex = 15;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.BackColor = Color.Transparent;
            telephoneLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            telephoneLabel.ForeColor = SystemColors.ButtonHighlight;
            telephoneLabel.Location = new Point(48, 334);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new Size(190, 22);
            telephoneLabel.TabIndex = 14;
            telephoneLabel.Text = "Telephone Number:";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(48, 285);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(186, 30);
            nameBox.TabIndex = 13;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(48, 263);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(71, 22);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.BackColor = Color.Transparent;
            detailsLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            detailsLabel.ForeColor = SystemColors.ButtonHighlight;
            detailsLabel.Location = new Point(48, 147);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(186, 22);
            detailsLabel.TabIndex = 18;
            detailsLabel.Text = "Reservation Period:";
            // 
            // bookButton
            // 
            bookButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bookButton.ForeColor = Color.Black;
            bookButton.Location = new Point(511, 50);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(324, 245);
            bookButton.TabIndex = 19;
            bookButton.Text = "BOOK NOW";
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.BackColor = Color.Transparent;
            fromLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fromLabel.ForeColor = SystemColors.ButtonHighlight;
            fromLabel.Location = new Point(71, 180);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(54, 22);
            fromLabel.TabIndex = 20;
            fromLabel.Text = "From";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.BackColor = Color.Transparent;
            toLabel.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            toLabel.ForeColor = SystemColors.ButtonHighlight;
            toLabel.Location = new Point(71, 212);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(30, 22);
            toLabel.TabIndex = 21;
            toLabel.Text = "To";
            // 
            // BookingPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(900, 450);
            Controls.Add(toLabel);
            Controls.Add(fromLabel);
            Controls.Add(bookButton);
            Controls.Add(detailsLabel);
            Controls.Add(label);
            Controls.Add(tableLabel);
            Controls.Add(telBox);
            Controls.Add(telephoneLabel);
            Controls.Add(nameBox);
            Controls.Add(nameLabel);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "BookingPage";
            Text = "BookingPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label tableLabel;
        private TextBox telBox;
        private Label telephoneLabel;
        private TextBox nameBox;
        private Label nameLabel;
        private Label detailsLabel;
        private Button bookButton;
        private Label fromLabel;
        private Label toLabel;
    }
}