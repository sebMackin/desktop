namespace M_160601_CSharpWindowsForms
{
    partial class displayForm
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
            this.returnButton = new System.Windows.Forms.Button();
            this.gvUserDetails = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDescending = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(287, 226);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // gvUserDetails
            // 
            this.gvUserDetails.AllowUserToAddRows = false;
            this.gvUserDetails.AllowUserToDeleteRows = false;
            this.gvUserDetails.AllowUserToResizeColumns = false;
            this.gvUserDetails.AllowUserToResizeRows = false;
            this.gvUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserDetails.Location = new System.Drawing.Point(12, 12);
            this.gvUserDetails.Name = "gvUserDetails";
            this.gvUserDetails.ReadOnly = true;
            this.gvUserDetails.Size = new System.Drawing.Size(350, 180);
            this.gvUserDetails.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDescending
            // 
            this.btnDescending.Location = new System.Drawing.Point(125, 226);
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(75, 23);
            this.btnDescending.TabIndex = 5;
            this.btnDescending.Text = "Desc Sort";
            this.btnDescending.UseVisualStyleBackColor = true;
            this.btnDescending.Click += new System.EventHandler(this.btnDescending_Click);
            // 
            // displayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.btnDescending);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gvUserDetails);
            this.Controls.Add(this.returnButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "displayForm";
            this.Text = "Display Form";
            this.Load += new System.EventHandler(this.displayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.DataGridView gvUserDetails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDescending;
    }
}