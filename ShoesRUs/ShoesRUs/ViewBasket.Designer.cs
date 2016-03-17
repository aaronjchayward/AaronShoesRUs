namespace ShoesRUs
{
    partial class ViewBasket
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
            this.grpShoeImage = new System.Windows.Forms.GroupBox();
            this.pctShoePicture = new System.Windows.Forms.PictureBox();
            this.lstBasket = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnClearBasket = new System.Windows.Forms.Button();
            this.grpShoeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctShoePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShoeImage
            // 
            this.grpShoeImage.Controls.Add(this.pctShoePicture);
            this.grpShoeImage.Location = new System.Drawing.Point(12, 21);
            this.grpShoeImage.Name = "grpShoeImage";
            this.grpShoeImage.Size = new System.Drawing.Size(204, 121);
            this.grpShoeImage.TabIndex = 0;
            this.grpShoeImage.TabStop = false;
            this.grpShoeImage.Text = "groupBox1";
            // 
            // pctShoePicture
            // 
            this.pctShoePicture.Location = new System.Drawing.Point(16, 19);
            this.pctShoePicture.Name = "pctShoePicture";
            this.pctShoePicture.Size = new System.Drawing.Size(173, 96);
            this.pctShoePicture.TabIndex = 1;
            this.pctShoePicture.TabStop = false;
            // 
            // lstBasket
            // 
            this.lstBasket.FormattingEnabled = true;
            this.lstBasket.Location = new System.Drawing.Point(233, 21);
            this.lstBasket.Name = "lstBasket";
            this.lstBasket.Size = new System.Drawing.Size(171, 121);
            this.lstBasket.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(384, 238);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(93, 166);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(92, 55);
            this.btnClearItem.TabIndex = 3;
            this.btnClearItem.Text = "Clear Item";
            this.btnClearItem.UseVisualStyleBackColor = true;
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.Location = new System.Drawing.Point(207, 166);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.Size = new System.Drawing.Size(98, 55);
            this.btnClearBasket.TabIndex = 4;
            this.btnClearBasket.Text = "Clear Basket";
            this.btnClearBasket.UseVisualStyleBackColor = true;
            // 
            // ViewBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 262);
            this.Controls.Add(this.btnClearBasket);
            this.Controls.Add(this.btnClearItem);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstBasket);
            this.Controls.Add(this.grpShoeImage);
            this.Name = "ViewBasket";
            this.Text = "ViewBasket";
            this.Load += new System.EventHandler(this.ViewBasket_Load);
            this.grpShoeImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctShoePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShoeImage;
        private System.Windows.Forms.PictureBox pctShoePicture;
        private System.Windows.Forms.ListBox lstBasket;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnClearBasket;
    }
}