﻿
namespace FINAL_project_LibraryProgram_1234
{
    partial class Normal_Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Normal_Board));
            this.picture_support = new System.Windows.Forms.PictureBox();
            this.picture_logout = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbox_notice_body = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_notice_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_notice = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_free_body = new System.Windows.Forms.TextBox();
            this.txtbox_free_who = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_free_title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdobtn_free_new = new System.Windows.Forms.RadioButton();
            this.rdobtn_free_readonly = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.data_free = new System.Windows.Forms.DataGridView();
            this.btn_main_click = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_support)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logout)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_notice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_free)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_support
            // 
            this.picture_support.Image = ((System.Drawing.Image)(resources.GetObject("picture_support.Image")));
            this.picture_support.Location = new System.Drawing.Point(679, 9);
            this.picture_support.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picture_support.Name = "picture_support";
            this.picture_support.Size = new System.Drawing.Size(47, 56);
            this.picture_support.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_support.TabIndex = 34;
            this.picture_support.TabStop = false;
            this.picture_support.Click += new System.EventHandler(this.picture_support_Click);
            // 
            // picture_logout
            // 
            this.picture_logout.Image = ((System.Drawing.Image)(resources.GetObject("picture_logout.Image")));
            this.picture_logout.Location = new System.Drawing.Point(749, 9);
            this.picture_logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picture_logout.Name = "picture_logout";
            this.picture_logout.Size = new System.Drawing.Size(42, 56);
            this.picture_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logout.TabIndex = 33;
            this.picture_logout.TabStop = false;
            this.picture_logout.Click += new System.EventHandler(this.picture_logout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(254, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 40);
            this.label5.TabIndex = 32;
            this.label5.Text = "일이삼사 도서관";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_notice_body);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbox_notice_title);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.data_notice);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 204);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // txtbox_notice_body
            // 
            this.txtbox_notice_body.Location = new System.Drawing.Point(494, 50);
            this.txtbox_notice_body.Multiline = true;
            this.txtbox_notice_body.Name = "txtbox_notice_body";
            this.txtbox_notice_body.ReadOnly = true;
            this.txtbox_notice_body.Size = new System.Drawing.Size(278, 143);
            this.txtbox_notice_body.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "내용";
            // 
            // txtbox_notice_title
            // 
            this.txtbox_notice_title.Location = new System.Drawing.Point(494, 22);
            this.txtbox_notice_title.Name = "txtbox_notice_title";
            this.txtbox_notice_title.ReadOnly = true;
            this.txtbox_notice_title.Size = new System.Drawing.Size(278, 22);
            this.txtbox_notice_title.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "우리 도서관 공지사항";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_notice
            // 
            this.data_notice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_notice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.data_notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_notice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.data_notice.Location = new System.Drawing.Point(6, 22);
            this.data_notice.MultiSelect = false;
            this.data_notice.Name = "data_notice";
            this.data_notice.ReadOnly = true;
            this.data_notice.RowHeadersWidth = 51;
            this.data_notice.RowTemplate.Height = 25;
            this.data_notice.Size = new System.Drawing.Size(445, 171);
            this.data_notice.TabIndex = 40;
            this.data_notice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_notice_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbox_free_body);
            this.groupBox1.Controls.Add(this.txtbox_free_who);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbox_free_title);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.data_free);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 245);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(493, 207);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(279, 35);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "등록";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "내용";
            // 
            // txtbox_free_body
            // 
            this.txtbox_free_body.Location = new System.Drawing.Point(494, 123);
            this.txtbox_free_body.MaxLength = 200;
            this.txtbox_free_body.Multiline = true;
            this.txtbox_free_body.Name = "txtbox_free_body";
            this.txtbox_free_body.ReadOnly = true;
            this.txtbox_free_body.Size = new System.Drawing.Size(278, 78);
            this.txtbox_free_body.TabIndex = 46;
            // 
            // txtbox_free_who
            // 
            this.txtbox_free_who.Location = new System.Drawing.Point(494, 95);
            this.txtbox_free_who.MaxLength = 5;
            this.txtbox_free_who.Name = "txtbox_free_who";
            this.txtbox_free_who.ReadOnly = true;
            this.txtbox_free_who.Size = new System.Drawing.Size(278, 22);
            this.txtbox_free_who.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "작성자";
            // 
            // txtbox_free_title
            // 
            this.txtbox_free_title.Location = new System.Drawing.Point(494, 67);
            this.txtbox_free_title.MaxLength = 20;
            this.txtbox_free_title.Name = "txtbox_free_title";
            this.txtbox_free_title.ReadOnly = true;
            this.txtbox_free_title.Size = new System.Drawing.Size(278, 22);
            this.txtbox_free_title.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "제목";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rdobtn_free_new);
            this.groupBox3.Controls.Add(this.rdobtn_free_readonly);
            this.groupBox3.Location = new System.Drawing.Point(457, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 46);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // rdobtn_free_new
            // 
            this.rdobtn_free_new.AutoSize = true;
            this.rdobtn_free_new.Location = new System.Drawing.Point(162, 16);
            this.rdobtn_free_new.Name = "rdobtn_free_new";
            this.rdobtn_free_new.Size = new System.Drawing.Size(73, 19);
            this.rdobtn_free_new.TabIndex = 1;
            this.rdobtn_free_new.Text = "신규작성";
            this.rdobtn_free_new.UseVisualStyleBackColor = true;
            this.rdobtn_free_new.CheckedChanged += new System.EventHandler(this.rdobtn_free_new_CheckedChanged);
            // 
            // rdobtn_free_readonly
            // 
            this.rdobtn_free_readonly.AutoSize = true;
            this.rdobtn_free_readonly.Checked = true;
            this.rdobtn_free_readonly.Location = new System.Drawing.Point(74, 16);
            this.rdobtn_free_readonly.Name = "rdobtn_free_readonly";
            this.rdobtn_free_readonly.Size = new System.Drawing.Size(73, 19);
            this.rdobtn_free_readonly.TabIndex = 0;
            this.rdobtn_free_readonly.TabStop = true;
            this.rdobtn_free_readonly.Text = "열람모드";
            this.rdobtn_free_readonly.UseVisualStyleBackColor = true;
            this.rdobtn_free_readonly.CheckedChanged += new System.EventHandler(this.rdobtn_free_readonly_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "우리 도서관 자유 게시판";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_free
            // 
            this.data_free.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_free.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.data_free.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_free.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.data_free.Location = new System.Drawing.Point(6, 22);
            this.data_free.MultiSelect = false;
            this.data_free.Name = "data_free";
            this.data_free.ReadOnly = true;
            this.data_free.RowHeadersWidth = 51;
            this.data_free.RowTemplate.Height = 25;
            this.data_free.Size = new System.Drawing.Size(445, 217);
            this.data_free.TabIndex = 40;
            this.data_free.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_free_CellClick);
            // 
            // btn_main_click
            // 
            this.btn_main_click.ForeColor = System.Drawing.Color.Green;
            this.btn_main_click.Location = new System.Drawing.Point(18, 6);
            this.btn_main_click.Name = "btn_main_click";
            this.btn_main_click.Size = new System.Drawing.Size(112, 59);
            this.btn_main_click.TabIndex = 43;
            this.btn_main_click.Text = "이전화면";
            this.btn_main_click.UseVisualStyleBackColor = true;
            this.btn_main_click.Click += new System.EventHandler(this.btn_main_click_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 532);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(778, 35);
            this.btn_load.TabIndex = 52;
            this.btn_load.Text = "재조회";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Normal_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 579);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_main_click);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picture_support);
            this.Controls.Add(this.picture_logout);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Normal_Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normal_Board";
            this.Load += new System.EventHandler(this.Normal_Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_support)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_notice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_free)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_support;
        private System.Windows.Forms.PictureBox picture_logout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_notice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_free;
        private System.Windows.Forms.TextBox txtbox_notice_body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_notice_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_free_body;
        private System.Windows.Forms.TextBox txtbox_free_who;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_free_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdobtn_free_new;
        private System.Windows.Forms.RadioButton rdobtn_free_readonly;
        private System.Windows.Forms.Button btn_main_click;
        private System.Windows.Forms.Button btn_load;
    }
}