namespace GeometryFigures
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_gen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.but_price = new System.Windows.Forms.Button();
            this.but_pricekg = new System.Windows.Forms.Button();
            this.but_den = new System.Windows.Forms.Button();
            this.but_more = new System.Windows.Forms.Button();
            this.but_less = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_id = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_gen
            // 
            this.button_gen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_gen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_gen.BackgroundImage")));
            this.button_gen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_gen.FlatAppearance.BorderSize = 0;
            this.button_gen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_gen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_gen.Location = new System.Drawing.Point(9, 427);
            this.button_gen.Name = "button_gen";
            this.button_gen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_gen.Size = new System.Drawing.Size(126, 38);
            this.button_gen.TabIndex = 1;
            this.button_gen.UseVisualStyleBackColor = true;
            this.button_gen.Click += new System.EventHandler(this.button_gen_Click);
            this.button_gen.MouseEnter += new System.EventHandler(this.button_gen_MouseEnter);
            this.button_gen.MouseLeave += new System.EventHandler(this.button_gen_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Упорядочить по:";
            // 
            // but_price
            // 
            this.but_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_price.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_price.BackgroundImage")));
            this.but_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_price.FlatAppearance.BorderSize = 0;
            this.but_price.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_price.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_price.Location = new System.Drawing.Point(380, 427);
            this.but_price.Name = "but_price";
            this.but_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_price.Size = new System.Drawing.Size(77, 38);
            this.but_price.TabIndex = 4;
            this.but_price.UseVisualStyleBackColor = true;
            this.but_price.Click += new System.EventHandler(this.button_sort_price_Click);
            this.but_price.MouseEnter += new System.EventHandler(this.button_sort_price_MouseEnter);
            this.but_price.MouseLeave += new System.EventHandler(this.button_sort_price_MouseLeave);
            // 
            // but_pricekg
            // 
            this.but_pricekg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_pricekg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_pricekg.BackgroundImage")));
            this.but_pricekg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_pricekg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_pricekg.FlatAppearance.BorderSize = 0;
            this.but_pricekg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_pricekg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_pricekg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_pricekg.Location = new System.Drawing.Point(467, 427);
            this.but_pricekg.Name = "but_pricekg";
            this.but_pricekg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_pricekg.Size = new System.Drawing.Size(128, 38);
            this.but_pricekg.TabIndex = 5;
            this.but_pricekg.UseVisualStyleBackColor = true;
            this.but_pricekg.Click += new System.EventHandler(this.but_pricekg_Click);
            this.but_pricekg.MouseEnter += new System.EventHandler(this.but_pricekg_MouseEnter);
            this.but_pricekg.MouseLeave += new System.EventHandler(this.but_pricekg_MouseLeave);
            // 
            // but_den
            // 
            this.but_den.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_den.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_den.BackgroundImage")));
            this.but_den.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_den.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_den.FlatAppearance.BorderSize = 0;
            this.but_den.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_den.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_den.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_den.Location = new System.Drawing.Point(605, 427);
            this.but_den.Name = "but_den";
            this.but_den.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_den.Size = new System.Drawing.Size(128, 38);
            this.but_den.TabIndex = 6;
            this.but_den.UseVisualStyleBackColor = true;
            this.but_den.Click += new System.EventHandler(this.but_den_Click);
            this.but_den.MouseEnter += new System.EventHandler(this.but_den_MouseEnter);
            this.but_den.MouseLeave += new System.EventHandler(this.but_den_MouseLeave);
            // 
            // but_more
            // 
            this.but_more.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_more.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_more.BackgroundImage")));
            this.but_more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_more.FlatAppearance.BorderSize = 0;
            this.but_more.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_more.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_more.Location = new System.Drawing.Point(758, 427);
            this.but_more.Name = "but_more";
            this.but_more.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_more.Size = new System.Drawing.Size(38, 38);
            this.but_more.TabIndex = 8;
            this.but_more.UseVisualStyleBackColor = true;
            this.but_more.Click += new System.EventHandler(this.but_more_Click);
            this.but_more.MouseEnter += new System.EventHandler(this.but_more_MouseEnter);
            this.but_more.MouseLeave += new System.EventHandler(this.but_more_MouseLeave);
            // 
            // but_less
            // 
            this.but_less.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_less.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_less.BackgroundImage")));
            this.but_less.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_less.FlatAppearance.BorderSize = 0;
            this.but_less.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_less.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_less.Location = new System.Drawing.Point(807, 427);
            this.but_less.Name = "but_less";
            this.but_less.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_less.Size = new System.Drawing.Size(38, 38);
            this.but_less.TabIndex = 9;
            this.but_less.UseVisualStyleBackColor = true;
            this.but_less.Click += new System.EventHandler(this.but_less_Click);
            this.but_less.MouseEnter += new System.EventHandler(this.but_less_MouseEnter);
            this.but_less.MouseLeave += new System.EventHandler(this.but_less_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(744, 427);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 38);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(836, 410);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // but_id
            // 
            this.but_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_id.BackgroundImage")));
            this.but_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_id.FlatAppearance.BorderSize = 0;
            this.but_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.but_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.but_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_id.Location = new System.Drawing.Point(320, 427);
            this.but_id.Name = "but_id";
            this.but_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.but_id.Size = new System.Drawing.Size(50, 38);
            this.but_id.TabIndex = 12;
            this.but_id.UseVisualStyleBackColor = true;
            this.but_id.Click += new System.EventHandler(this.but_id_Click);
            this.but_id.MouseEnter += new System.EventHandler(this.but_id_MouseEnter);
            this.but_id.MouseLeave += new System.EventHandler(this.but_id_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(854, 473);
            this.Controls.Add(this.but_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.but_less);
            this.Controls.Add(this.but_more);
            this.Controls.Add(this.but_den);
            this.Controls.Add(this.but_pricekg);
            this.Controls.Add(this.but_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_gen);
            this.MinimumSize = new System.Drawing.Size(870, 512);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_gen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_price;
        private System.Windows.Forms.Button but_pricekg;
        private System.Windows.Forms.Button but_den;
        private System.Windows.Forms.Button but_more;
        private System.Windows.Forms.Button but_less;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_id;
    }
}

