using System.Windows.Forms;

namespace People_sRestaurant
{
    partial class FindTablesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindTablesPage));
            location = new ComboBox();
            dataGridView1 = new DataGridView();
            pickTime = new DateTimePicker();
            label1 = new Label();
            from = new TextBox();
            label2 = new Label();
            to = new TextBox();
            results = new Button();
            capacity = new ComboBox();
            welcomeGreeting = new Label();
            label3 = new Label();
            label4 = new Label();
            clearButton = new Button();
            reservationsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // location
            // 
            location.Cursor = Cursors.Hand;
            location.FormattingEnabled = true;
            location.Items.AddRange(new object[] { "first floor", "second floor", "balcony", "garden", "smokers' area" });
            location.Location = new Point(12, 202);
            location.Margin = new Padding(3, 4, 3, 4);
            location.Name = "location";
            location.Size = new Size(138, 28);
            location.TabIndex = 1;
            location.Text = "Location";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 254);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(888, 399);
            dataGridView1.TabIndex = 3;
            // 
            // pickTime
            // 
            pickTime.Cursor = Cursors.Hand;
            pickTime.Location = new Point(173, 203);
            pickTime.Margin = new Padding(3, 4, 3, 4);
            pickTime.Name = "pickTime";
            pickTime.Size = new Size(241, 27);
            pickTime.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(429, 205);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "From";
            // 
            // from
            // 
            from.Cursor = Cursors.Hand;
            from.Location = new Point(478, 202);
            from.Margin = new Padding(3, 4, 3, 4);
            from.Name = "from";
            from.Size = new Size(114, 27);
            from.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(598, 207);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 7;
            label2.Text = "to";
            // 
            // to
            // 
            to.Cursor = Cursors.Hand;
            to.Location = new Point(627, 202);
            to.Margin = new Padding(3, 4, 3, 4);
            to.Name = "to";
            to.Size = new Size(114, 27);
            to.TabIndex = 8;
            // 
            // results
            // 
            results.Cursor = Cursors.Hand;
            results.Location = new Point(12, 674);
            results.Margin = new Padding(3, 4, 3, 4);
            results.Name = "results";
            results.Size = new Size(138, 31);
            results.TabIndex = 9;
            results.Text = "Show results";
            results.UseVisualStyleBackColor = true;
            results.Click += results_Click;
            // 
            // capacity
            // 
            capacity.Cursor = Cursors.Hand;
            capacity.FormattingEnabled = true;
            capacity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            capacity.Location = new Point(760, 201);
            capacity.Margin = new Padding(3, 4, 3, 4);
            capacity.Name = "capacity";
            capacity.Size = new Size(140, 28);
            capacity.TabIndex = 10;
            capacity.Text = "Capacity";
            // 
            // welcomeGreeting
            // 
            welcomeGreeting.AutoSize = true;
            welcomeGreeting.BackColor = Color.Transparent;
            welcomeGreeting.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeGreeting.ForeColor = SystemColors.ButtonHighlight;
            welcomeGreeting.Location = new Point(12, 148);
            welcomeGreeting.Name = "welcomeGreeting";
            welcomeGreeting.Size = new Size(547, 29);
            welcomeGreeting.TabIndex = 11;
            welcomeGreeting.Text = "Welcome, Emir. Make your reservation here:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(370, 22);
            label3.Name = "label3";
            label3.Size = new Size(189, 40);
            label3.TabIndex = 12;
            label3.Text = "Restaurant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(370, 62);
            label4.Name = "label4";
            label4.Size = new Size(198, 59);
            label4.TabIndex = 13;
            label4.Text = "GROSH";
            // 
            // clearButton
            // 
            clearButton.Cursor = Cursors.Hand;
            clearButton.Location = new Point(385, 674);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(138, 31);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // reservationsButton
            // 
            reservationsButton.Cursor = Cursors.Hand;
            reservationsButton.Location = new Point(760, 674);
            reservationsButton.Margin = new Padding(3, 4, 3, 4);
            reservationsButton.Name = "reservationsButton";
            reservationsButton.Size = new Size(138, 31);
            reservationsButton.TabIndex = 15;
            reservationsButton.Text = "My reservations";
            reservationsButton.UseVisualStyleBackColor = true;
            reservationsButton.Click += reservationsButton_Click;
            // 
            // FindTablesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(912, 753);
            Controls.Add(reservationsButton);
            Controls.Add(clearButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(welcomeGreeting);
            Controls.Add(capacity);
            Controls.Add(results);
            Controls.Add(to);
            Controls.Add(label2);
            Controls.Add(from);
            Controls.Add(label1);
            Controls.Add(pickTime);
            Controls.Add(dataGridView1);
            Controls.Add(location);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FindTablesPage";
            Text = "Find Tables";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox location;
        private DataGridView dataGridView1;
        private DateTimePicker pickTime;
        private Label label1;
        private TextBox from;
        private Label label2;
        private TextBox to;
        private Button results;
        private ComboBox capacity;
        private Label welcomeGreeting;
        private Label label3;
        private Label label4;
        private Button clearButton;
        private Button reservationsButton;
    }
}