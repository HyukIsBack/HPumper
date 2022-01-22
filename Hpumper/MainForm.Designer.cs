namespace Hpumper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.path = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.sizecombo = new System.Windows.Forms.ComboBox();
            this.pumpbutton = new System.Windows.Forms.Button();
            this.pumpSizebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(27, 12);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(500, 42);
            this.path.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(542, 12);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(120, 56);
            this.browse.TabIndex = 1;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // sizecombo
            // 
            this.sizecombo.FormattingEnabled = true;
            this.sizecombo.Items.AddRange(new object[] {
            "kb",
            "mb",
            "gb"});
            this.sizecombo.Location = new System.Drawing.Point(177, 80);
            this.sizecombo.Name = "sizecombo";
            this.sizecombo.Size = new System.Drawing.Size(485, 38);
            this.sizecombo.TabIndex = 6;
            // 
            // pumpbutton
            // 
            this.pumpbutton.Location = new System.Drawing.Point(218, 143);
            this.pumpbutton.Name = "pumpbutton";
            this.pumpbutton.Size = new System.Drawing.Size(237, 86);
            this.pumpbutton.TabIndex = 7;
            this.pumpbutton.Text = "Pump!";
            this.pumpbutton.UseVisualStyleBackColor = true;
            this.pumpbutton.Click += new System.EventHandler(this.pumpbutton_Click);
            // 
            // pumpSizebox
            // 
            this.pumpSizebox.Location = new System.Drawing.Point(27, 76);
            this.pumpSizebox.Name = "pumpSizebox";
            this.pumpSizebox.Size = new System.Drawing.Size(125, 42);
            this.pumpSizebox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 252);
            this.Controls.Add(this.pumpSizebox);
            this.Controls.Add(this.pumpbutton);
            this.Controls.Add(this.sizecombo);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.path);
            this.Name = "MainForm";
            this.Text = "HPumper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.ComboBox sizecombo;
        private System.Windows.Forms.Button pumpbutton;
        private System.Windows.Forms.TextBox pumpSizebox;
    }
}

