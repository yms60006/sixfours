namespace YoutubeCrawler
{
  partial class Form1
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
      this.YoutubeSearch_Btn = new System.Windows.Forms.Button();
      this.Recommand_Btn = new System.Windows.Forms.Button();
      this.label20 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.pictureBox6 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.ProcessKill_Btn = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
      this.SuspendLayout();
      // 
      // YoutubeSearch_Btn
      // 
      this.YoutubeSearch_Btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.YoutubeSearch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.YoutubeSearch_Btn.Font = new System.Drawing.Font("DX경필명조B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.YoutubeSearch_Btn.Location = new System.Drawing.Point(12, 573);
      this.YoutubeSearch_Btn.Name = "YoutubeSearch_Btn";
      this.YoutubeSearch_Btn.Size = new System.Drawing.Size(345, 54);
      this.YoutubeSearch_Btn.TabIndex = 0;
      this.YoutubeSearch_Btn.Text = "Youtube 검색";
      this.YoutubeSearch_Btn.UseVisualStyleBackColor = false;
      this.YoutubeSearch_Btn.Click += new System.EventHandler(this.YoutubeSearch_Btn_Click);
      // 
      // Recommand_Btn
      // 
      this.Recommand_Btn.BackColor = System.Drawing.Color.PaleTurquoise;
      this.Recommand_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.Recommand_Btn.Font = new System.Drawing.Font("DX경필명조B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.Recommand_Btn.Location = new System.Drawing.Point(12, 22);
      this.Recommand_Btn.Name = "Recommand_Btn";
      this.Recommand_Btn.Size = new System.Drawing.Size(345, 56);
      this.Recommand_Btn.TabIndex = 1;
      this.Recommand_Btn.Text = "Youtube 맞춤동영상";
      this.Recommand_Btn.UseVisualStyleBackColor = false;
      this.Recommand_Btn.Click += new System.EventHandler(this.Recommand_Btn_Click);
      // 
      // label20
      // 
      this.label20.BackColor = System.Drawing.Color.LemonChiffon;
      this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label20.Font = new System.Drawing.Font("DX경필명조B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label20.Location = new System.Drawing.Point(12, 441);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(345, 53);
      this.label20.TabIndex = 2;
      this.label20.Text = "검색어 입력";
      this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("DX경필명조B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.textBox1.Location = new System.Drawing.Point(12, 509);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(345, 41);
      this.textBox1.TabIndex = 3;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox2.Location = new System.Drawing.Point(643, 22);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(221, 141);
      this.pictureBox2.TabIndex = 32;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox3.Location = new System.Drawing.Point(900, 22);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(219, 141);
      this.pictureBox3.TabIndex = 33;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox4
      // 
      this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox4.Location = new System.Drawing.Point(1155, 22);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(220, 141);
      this.pictureBox4.TabIndex = 34;
      this.pictureBox4.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Location = new System.Drawing.Point(388, 22);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(221, 141);
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox5
      // 
      this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox5.Location = new System.Drawing.Point(388, 226);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new System.Drawing.Size(221, 139);
      this.pictureBox5.TabIndex = 38;
      this.pictureBox5.TabStop = false;
      // 
      // pictureBox6
      // 
      this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox6.Location = new System.Drawing.Point(388, 432);
      this.pictureBox6.Name = "pictureBox6";
      this.pictureBox6.Size = new System.Drawing.Size(221, 149);
      this.pictureBox6.TabIndex = 39;
      this.pictureBox6.TabStop = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.button1.Font = new System.Drawing.Font("DX경필명조B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(388, 169);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(221, 39);
      this.button1.TabIndex = 54;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
      this.button2.Font = new System.Drawing.Font("DX경필명조B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button2.Location = new System.Drawing.Point(643, 169);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(221, 39);
      this.button2.TabIndex = 55;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
      this.button3.Font = new System.Drawing.Font("DX경필명조B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button3.Location = new System.Drawing.Point(900, 169);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(219, 39);
      this.button3.TabIndex = 56;
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
      this.button4.Font = new System.Drawing.Font("DX경필명조B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button4.Location = new System.Drawing.Point(1155, 169);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(220, 39);
      this.button4.TabIndex = 57;
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // ProcessKill_Btn
      // 
      this.ProcessKill_Btn.BackColor = System.Drawing.Color.MistyRose;
      this.ProcessKill_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.ProcessKill_Btn.Font = new System.Drawing.Font("DX경필명조B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ProcessKill_Btn.Location = new System.Drawing.Point(12, 748);
      this.ProcessKill_Btn.Name = "ProcessKill_Btn";
      this.ProcessKill_Btn.Size = new System.Drawing.Size(345, 66);
      this.ProcessKill_Btn.TabIndex = 62;
      this.ProcessKill_Btn.Text = "창 닫기";
      this.ProcessKill_Btn.UseVisualStyleBackColor = false;
      this.ProcessKill_Btn.Click += new System.EventHandler(this.ProcessKill_Btn_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
      this.button5.Font = new System.Drawing.Font("DX경필명조B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button5.Location = new System.Drawing.Point(388, 371);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(221, 40);
      this.button5.TabIndex = 71;
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
      this.button6.Font = new System.Drawing.Font("DX경필명조B", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button6.Location = new System.Drawing.Point(388, 587);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(221, 40);
      this.button6.TabIndex = 72;
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("DX경필명조B", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(12, 90);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(345, 319);
      this.listBox1.TabIndex = 75;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Location = new System.Drawing.Point(643, 226);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(732, 588);
      this.panel1.TabIndex = 76;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(1404, 839);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.ProcessKill_Btn);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox6);
      this.Controls.Add(this.pictureBox5);
      this.Controls.Add(this.pictureBox4);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label20);
      this.Controls.Add(this.Recommand_Btn);
      this.Controls.Add(this.YoutubeSearch_Btn);
      this.Name = "Form1";
      this.Text = "유튜브 크롤러 (Create by Trekker / inwoox@gmail.com) / Font Ref : 기프트명장";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button YoutubeSearch_Btn;
    private System.Windows.Forms.Button Recommand_Btn;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.PictureBox pictureBox6;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button ProcessKill_Btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

