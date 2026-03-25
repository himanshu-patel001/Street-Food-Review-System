namespace StreetFoodReview
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtComment = new TextBox();
            txtLocation = new TextBox();
            txtFood = new TextBox();
            cmbRating = new ComboBox();
            btnSubmit = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(586, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 56);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Food Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 103);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Location";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 145);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 4;
            label4.Text = "Rating";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 187);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Comment";
            // 
            // txtComment
            // 
            txtComment.Location = new Point(166, 180);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(586, 27);
            txtComment.TabIndex = 6;
            txtComment.TextChanged += txtComment_TextChanged;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(166, 100);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(586, 27);
            txtLocation.TabIndex = 7;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(166, 53);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(586, 27);
            txtFood.TabIndex = 8;
            // 
            // cmbRating
            // 
            cmbRating.FormattingEnabled = true;
            cmbRating.Location = new Point(166, 142);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(586, 28);
            cmbRating.TabIndex = 9;
            cmbRating.SelectedIndexChanged += cmbRating_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(354, 230);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 148);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSubmit);
            Controls.Add(cmbRating);
            Controls.Add(txtFood);
            Controls.Add(txtLocation);
            Controls.Add(txtComment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtComment;
        private TextBox txtLocation;
        private TextBox txtFood;
        private ComboBox cmbRating;
        private Button btnSubmit;
        private DataGridView dataGridView1;
    }
}
