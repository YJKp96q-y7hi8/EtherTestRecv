namespace EtherTestRecv
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_RecvData = new System.Windows.Forms.TextBox();
            this.btn_SendStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_RecvData
            // 
            this.tbx_RecvData.Location = new System.Drawing.Point(12, 89);
            this.tbx_RecvData.Multiline = true;
            this.tbx_RecvData.Name = "tbx_RecvData";
            this.tbx_RecvData.Size = new System.Drawing.Size(372, 275);
            this.tbx_RecvData.TabIndex = 0;
            // 
            // btn_SendStart
            // 
            this.btn_SendStart.Location = new System.Drawing.Point(12, 12);
            this.btn_SendStart.Name = "btn_SendStart";
            this.btn_SendStart.Size = new System.Drawing.Size(124, 23);
            this.btn_SendStart.TabIndex = 1;
            this.btn_SendStart.Text = "送信開始";
            this.btn_SendStart.UseVisualStyleBackColor = true;
            this.btn_SendStart.Click += new System.EventHandler(this.btn_SendStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 376);
            this.Controls.Add(this.btn_SendStart);
            this.Controls.Add(this.tbx_RecvData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_RecvData;
        private System.Windows.Forms.Button btn_SendStart;
    }
}

