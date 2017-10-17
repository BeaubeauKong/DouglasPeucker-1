namespace 道格拉斯_普克法
{
    partial class DouglasPeucker
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(522, 28);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(132, 29);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(364, 22);
            this.txtFile.TabIndex = 1;
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(522, 78);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 25);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(40, 29);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(73, 20);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "File path";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(40, 78);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(18, 20);
            this.lblE.TabIndex = 4;
            this.lblE.Text = "e";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(132, 78);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(364, 22);
            this.txtE.TabIndex = 5;
            // 
            // DouglasPeucker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 137);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DouglasPeucker";
            this.Text = "Douglas-Peucker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtE;
    }
}

