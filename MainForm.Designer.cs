namespace Translator
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
            this.txtPrev = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.cboLang2 = new System.Windows.Forms.ComboBox();
            this.txtNext = new System.Windows.Forms.TextBox();
            this.labTrans = new System.Windows.Forms.Label();
            this.labLength = new System.Windows.Forms.Label();
            this.labLength2 = new System.Windows.Forms.Label();
            this.picSpeaker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeaker)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrev
            // 
            this.txtPrev.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrev.Location = new System.Drawing.Point(12, 51);
            this.txtPrev.Multiline = true;
            this.txtPrev.Name = "txtPrev";
            this.txtPrev.Size = new System.Drawing.Size(300, 300);
            this.txtPrev.TabIndex = 0;
            this.txtPrev.TextChanged += new System.EventHandler(this.txtPrev_TextChanged);
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTrans.Location = new System.Drawing.Point(237, 25);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 2;
            this.btnTrans.Text = "번역하기";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // cboLang
            // 
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(12, 25);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(121, 20);
            this.cboLang.TabIndex = 3;
            this.cboLang.SelectedIndexChanged += new System.EventHandler(this.cboLang_SelectedIndexChanged);
            // 
            // cboLang2
            // 
            this.cboLang2.FormattingEnabled = true;
            this.cboLang2.Location = new System.Drawing.Point(372, 25);
            this.cboLang2.Name = "cboLang2";
            this.cboLang2.Size = new System.Drawing.Size(121, 20);
            this.cboLang2.TabIndex = 4;
            this.cboLang2.SelectedIndexChanged += new System.EventHandler(this.cboLang2_SelectedIndexChanged);
            // 
            // txtNext
            // 
            this.txtNext.BackColor = System.Drawing.Color.White;
            this.txtNext.Location = new System.Drawing.Point(372, 51);
            this.txtNext.Multiline = true;
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(300, 300);
            this.txtNext.TabIndex = 6;
            // 
            // labTrans
            // 
            this.labTrans.AutoSize = true;
            this.labTrans.Location = new System.Drawing.Point(333, 173);
            this.labTrans.Name = "labTrans";
            this.labTrans.Size = new System.Drawing.Size(17, 12);
            this.labTrans.TabIndex = 7;
            this.labTrans.Text = "→";
            // 
            // labLength
            // 
            this.labLength.AutoSize = true;
            this.labLength.BackColor = System.Drawing.Color.White;
            this.labLength.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labLength.Location = new System.Drawing.Point(235, 330);
            this.labLength.Name = "labLength";
            this.labLength.Size = new System.Drawing.Size(11, 12);
            this.labLength.TabIndex = 8;
            this.labLength.Text = "0";
            // 
            // labLength2
            // 
            this.labLength2.AutoSize = true;
            this.labLength2.BackColor = System.Drawing.Color.White;
            this.labLength2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labLength2.Location = new System.Drawing.Point(262, 330);
            this.labLength2.Name = "labLength2";
            this.labLength2.Size = new System.Drawing.Size(39, 12);
            this.labLength2.TabIndex = 9;
            this.labLength2.Text = "/ 5000";
            // 
            // picSpeaker
            // 
            this.picSpeaker.Location = new System.Drawing.Point(633, 312);
            this.picSpeaker.Name = "picSpeaker";
            this.picSpeaker.Size = new System.Drawing.Size(30, 30);
            this.picSpeaker.TabIndex = 11;
            this.picSpeaker.TabStop = false;
            this.picSpeaker.Click += new System.EventHandler(this.picSpeaker_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.picSpeaker);
            this.Controls.Add(this.labLength2);
            this.Controls.Add(this.labLength);
            this.Controls.Add(this.labTrans);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.cboLang2);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.txtPrev);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MainForm";
            this.Text = "Translator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpeaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrev;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.ComboBox cboLang2;
        private System.Windows.Forms.TextBox txtNext;
        private System.Windows.Forms.Label labTrans;
        private System.Windows.Forms.Label labLength;
        private System.Windows.Forms.Label labLength2;
        private System.Windows.Forms.PictureBox picSpeaker;
    }
}

