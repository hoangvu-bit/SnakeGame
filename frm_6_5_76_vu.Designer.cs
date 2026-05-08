namespace snakesgame_76_vu
{
    partial class frm_6_5_76_vu
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
            this.components = new System.ComponentModel.Container();
            this.lbDiemBatDau_76_vu = new System.Windows.Forms.Label();
            this.lbDiemThang_76_vu = new System.Windows.Forms.Label();
            this.timeGame_76_vu = new System.Windows.Forms.Timer(this.components);
            this.grb_76_vu = new System.Windows.Forms.GroupBox();
            this.btnSnap_76_vu = new System.Windows.Forms.Button();
            this.pn_layout_76_vu = new System.Windows.Forms.Panel();
            this.btThoatGame_76_vu = new System.Windows.Forms.Button();
            this.lbDiemThang_65_vu = new System.Windows.Forms.Label();
            this.lbDiem_76_vu = new System.Windows.Forms.Label();
            this.btnBatDauLai_76_vu = new System.Windows.Forms.Button();
            this.picbLayout_76_vu = new System.Windows.Forms.PictureBox();
            this.pnlMenu_76_vu = new System.Windows.Forms.Panel();
            this.btnStart_76_vu = new System.Windows.Forms.Button();
            this.picb_76_vu = new System.Windows.Forms.PictureBox();
            this.grb_76_vu.SuspendLayout();
            this.pn_layout_76_vu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLayout_76_vu)).BeginInit();
            this.pnlMenu_76_vu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_76_vu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDiemBatDau_76_vu
            // 
            this.lbDiemBatDau_76_vu.AutoSize = true;
            this.lbDiemBatDau_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemBatDau_76_vu.Location = new System.Drawing.Point(6, 74);
            this.lbDiemBatDau_76_vu.Name = "lbDiemBatDau_76_vu";
            this.lbDiemBatDau_76_vu.Size = new System.Drawing.Size(168, 24);
            this.lbDiemBatDau_76_vu.TabIndex = 3;
            this.lbDiemBatDau_76_vu.Text = "Điểm của bạn : 0";
            // 
            // lbDiemThang_76_vu
            // 
            this.lbDiemThang_76_vu.AutoSize = true;
            this.lbDiemThang_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemThang_76_vu.Location = new System.Drawing.Point(10, 129);
            this.lbDiemThang_76_vu.Name = "lbDiemThang_76_vu";
            this.lbDiemThang_76_vu.Size = new System.Drawing.Size(145, 24);
            this.lbDiemThang_76_vu.TabIndex = 4;
            this.lbDiemThang_76_vu.Text = "Điểm thắng : 9";
            // 
            // timeGame_76_vu
            // 
            this.timeGame_76_vu.Tick += new System.EventHandler(this.GamerTimeEvent_76_vu);
            // 
            // grb_76_vu
            // 
            this.grb_76_vu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.grb_76_vu.Controls.Add(this.lbDiemBatDau_76_vu);
            this.grb_76_vu.Controls.Add(this.lbDiemThang_76_vu);
            this.grb_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_76_vu.Location = new System.Drawing.Point(1035, 264);
            this.grb_76_vu.Name = "grb_76_vu";
            this.grb_76_vu.Size = new System.Drawing.Size(10, 10);
            this.grb_76_vu.TabIndex = 9;
            this.grb_76_vu.TabStop = false;
            this.grb_76_vu.Text = "Bảng Điểm";
            // 
            // btnSnap_76_vu
            // 
            this.btnSnap_76_vu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSnap_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnap_76_vu.Location = new System.Drawing.Point(625, 625);
            this.btnSnap_76_vu.Name = "btnSnap_76_vu";
            this.btnSnap_76_vu.Size = new System.Drawing.Size(138, 51);
            this.btnSnap_76_vu.TabIndex = 1;
            this.btnSnap_76_vu.Text = "Chụp ảnh ";
            this.btnSnap_76_vu.UseVisualStyleBackColor = false;
            this.btnSnap_76_vu.Click += new System.EventHandler(this.TakeSnapShot_76_vu);
            // 
            // pn_layout_76_vu
            // 
            this.pn_layout_76_vu.Controls.Add(this.btThoatGame_76_vu);
            this.pn_layout_76_vu.Controls.Add(this.lbDiemThang_65_vu);
            this.pn_layout_76_vu.Controls.Add(this.lbDiem_76_vu);
            this.pn_layout_76_vu.Controls.Add(this.btnSnap_76_vu);
            this.pn_layout_76_vu.Controls.Add(this.btnBatDauLai_76_vu);
            this.pn_layout_76_vu.Controls.Add(this.picbLayout_76_vu);
            this.pn_layout_76_vu.Location = new System.Drawing.Point(66, 1);
            this.pn_layout_76_vu.Name = "pn_layout_76_vu";
            this.pn_layout_76_vu.Size = new System.Drawing.Size(973, 724);
            this.pn_layout_76_vu.TabIndex = 11;
            this.pn_layout_76_vu.Visible = false;
            // 
            // btThoatGame_76_vu
            // 
            this.btThoatGame_76_vu.BackColor = System.Drawing.Color.DarkViolet;
            this.btThoatGame_76_vu.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btThoatGame_76_vu.FlatAppearance.BorderSize = 3;
            this.btThoatGame_76_vu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btThoatGame_76_vu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btThoatGame_76_vu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoatGame_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoatGame_76_vu.ForeColor = System.Drawing.Color.Black;
            this.btThoatGame_76_vu.Location = new System.Drawing.Point(221, 628);
            this.btThoatGame_76_vu.Name = "btThoatGame_76_vu";
            this.btThoatGame_76_vu.Size = new System.Drawing.Size(158, 48);
            this.btThoatGame_76_vu.TabIndex = 9;
            this.btThoatGame_76_vu.Text = "Thoát Game";
            this.btThoatGame_76_vu.UseVisualStyleBackColor = false;
            this.btThoatGame_76_vu.Click += new System.EventHandler(this.btThoatGame_76_vu_Click);
            // 
            // lbDiemThang_65_vu
            // 
            this.lbDiemThang_65_vu.AutoSize = true;
            this.lbDiemThang_65_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemThang_65_vu.Location = new System.Drawing.Point(577, 427);
            this.lbDiemThang_65_vu.Name = "lbDiemThang_65_vu";
            this.lbDiemThang_65_vu.Size = new System.Drawing.Size(30, 31);
            this.lbDiemThang_65_vu.TabIndex = 8;
            this.lbDiemThang_65_vu.Text = "9";
            // 
            // lbDiem_76_vu
            // 
            this.lbDiem_76_vu.AutoSize = true;
            this.lbDiem_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem_76_vu.Location = new System.Drawing.Point(607, 337);
            this.lbDiem_76_vu.Name = "lbDiem_76_vu";
            this.lbDiem_76_vu.Size = new System.Drawing.Size(0, 29);
            this.lbDiem_76_vu.TabIndex = 7;
            // 
            // btnBatDauLai_76_vu
            // 
            this.btnBatDauLai_76_vu.BackColor = System.Drawing.Color.DarkViolet;
            this.btnBatDauLai_76_vu.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnBatDauLai_76_vu.FlatAppearance.BorderSize = 3;
            this.btnBatDauLai_76_vu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBatDauLai_76_vu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBatDauLai_76_vu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatDauLai_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDauLai_76_vu.ForeColor = System.Drawing.Color.Black;
            this.btnBatDauLai_76_vu.Location = new System.Drawing.Point(425, 628);
            this.btnBatDauLai_76_vu.Name = "btnBatDauLai_76_vu";
            this.btnBatDauLai_76_vu.Size = new System.Drawing.Size(138, 48);
            this.btnBatDauLai_76_vu.TabIndex = 6;
            this.btnBatDauLai_76_vu.Text = "Chơi Lại";
            this.btnBatDauLai_76_vu.UseVisualStyleBackColor = false;
            this.btnBatDauLai_76_vu.Click += new System.EventHandler(this.btnBatDauLai_76_vu_Click);
            // 
            // picbLayout_76_vu
            // 
            this.picbLayout_76_vu.Image = global::snakesgame_76_vu.Properties.Resources._77f2aef1_f37d_472e_bdeb_def99aa05dc3;
            this.picbLayout_76_vu.Location = new System.Drawing.Point(3, 8);
            this.picbLayout_76_vu.Name = "picbLayout_76_vu";
            this.picbLayout_76_vu.Size = new System.Drawing.Size(976, 702);
            this.picbLayout_76_vu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLayout_76_vu.TabIndex = 1;
            this.picbLayout_76_vu.TabStop = false;
            // 
            // pnlMenu_76_vu
            // 
            this.pnlMenu_76_vu.BackgroundImage = global::snakesgame_76_vu.Properties.Resources._903e7c6b_482b_4b35_891c_54f2b9c80dea;
            this.pnlMenu_76_vu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu_76_vu.Controls.Add(this.btnStart_76_vu);
            this.pnlMenu_76_vu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMenu_76_vu.Location = new System.Drawing.Point(67, 7);
            this.pnlMenu_76_vu.Name = "pnlMenu_76_vu";
            this.pnlMenu_76_vu.Size = new System.Drawing.Size(950, 692);
            this.pnlMenu_76_vu.TabIndex = 10;
            this.pnlMenu_76_vu.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphic_76_vu);
            // 
            // btnStart_76_vu
            // 
            this.btnStart_76_vu.BackColor = System.Drawing.Color.Transparent;
            this.btnStart_76_vu.FlatAppearance.BorderSize = 0;
            this.btnStart_76_vu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart_76_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart_76_vu.ForeColor = System.Drawing.Color.White;
            this.btnStart_76_vu.Location = new System.Drawing.Point(372, 514);
            this.btnStart_76_vu.Name = "btnStart_76_vu";
            this.btnStart_76_vu.Size = new System.Drawing.Size(169, 104);
            this.btnStart_76_vu.TabIndex = 6;
            this.btnStart_76_vu.Text = "Bắt Đầu";
            this.btnStart_76_vu.UseVisualStyleBackColor = false;
            this.btnStart_76_vu.Click += new System.EventHandler(this.btnStart_76_vu_Click);
            // 
            // picb_76_vu
            // 
            this.picb_76_vu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picb_76_vu.Image = global::snakesgame_76_vu.Properties.Resources.istockphoto_525986013_170667a;
            this.picb_76_vu.Location = new System.Drawing.Point(79, 19);
            this.picb_76_vu.Name = "picb_76_vu";
            this.picb_76_vu.Size = new System.Drawing.Size(950, 692);
            this.picb_76_vu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_76_vu.TabIndex = 8;
            this.picb_76_vu.TabStop = false;
            this.picb_76_vu.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphic_76_vu);
            // 
            // frm_6_5_76_vu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 759);
            this.Controls.Add(this.pnlMenu_76_vu);
            this.Controls.Add(this.grb_76_vu);
            this.Controls.Add(this.pn_layout_76_vu);
            this.Controls.Add(this.picb_76_vu);
            this.KeyPreview = true;
            this.Name = "frm_6_5_76_vu";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown_76_vu);
            this.grb_76_vu.ResumeLayout(false);
            this.grb_76_vu.PerformLayout();
            this.pn_layout_76_vu.ResumeLayout(false);
            this.pn_layout_76_vu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLayout_76_vu)).EndInit();
            this.pnlMenu_76_vu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_76_vu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu_76_vu;
        private System.Windows.Forms.Button btnStart_76_vu;
        private System.Windows.Forms.Label lbDiemBatDau_76_vu;
        private System.Windows.Forms.Label lbDiemThang_76_vu;
        private System.Windows.Forms.Timer timeGame_76_vu;
        private System.Windows.Forms.GroupBox grb_76_vu;
        private System.Windows.Forms.Button btnSnap_76_vu;
        private System.Windows.Forms.Panel pn_layout_76_vu;
        private System.Windows.Forms.Button btThoatGame_76_vu;
        private System.Windows.Forms.Label lbDiemThang_65_vu;
        private System.Windows.Forms.Label lbDiem_76_vu;
        private System.Windows.Forms.Button btnBatDauLai_76_vu;
        private System.Windows.Forms.PictureBox picbLayout_76_vu;
        private System.Windows.Forms.PictureBox picb_76_vu;
    }
}