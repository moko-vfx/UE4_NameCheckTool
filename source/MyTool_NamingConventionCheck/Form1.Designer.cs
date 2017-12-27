namespace MyTool_NamingConventionCheck
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
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelPart = new System.Windows.Forms.Label();
			this.labelSkMesh = new System.Windows.Forms.Label();
			this.labelStMesh = new System.Windows.Forms.Label();
			this.labelMatInst = new System.Windows.Forms.Label();
			this.labelMatFunc = new System.Windows.Forms.Label();
			this.labelMat = new System.Windows.Forms.Label();
			this.labelTex = new System.Windows.Forms.Label();
			this.labelBP = new System.Windows.Forms.Label();
			this.labelLevel = new System.Windows.Forms.Label();
			this.labelCount1 = new System.Windows.Forms.Label();
			this.btn_Check = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.CLevelPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CBpPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CTexPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CMatPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CMatFuncPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CMatInstPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CStMeshPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CSkMeshPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPartPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_copy = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(20, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "リファレンス情報を貼り付けます";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(20, 40);
			this.textBox1.MaxLength = 0;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(220, 352);
			this.textBox1.TabIndex = 1;
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(515, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 21);
			this.label2.TabIndex = 12;
			this.label2.Text = "命名規則から外れたアセットを表示します";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.labelPart);
			this.panel1.Controls.Add(this.labelSkMesh);
			this.panel1.Controls.Add(this.labelStMesh);
			this.panel1.Controls.Add(this.labelMatInst);
			this.panel1.Controls.Add(this.labelMatFunc);
			this.panel1.Controls.Add(this.labelMat);
			this.panel1.Controls.Add(this.labelTex);
			this.panel1.Controls.Add(this.labelBP);
			this.panel1.Controls.Add(this.labelLevel);
			this.panel1.Controls.Add(this.labelCount1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 407);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(814, 30);
			this.panel1.TabIndex = 14;
			// 
			// labelPart
			// 
			this.labelPart.AutoSize = true;
			this.labelPart.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelPart.ForeColor = System.Drawing.Color.MintCream;
			this.labelPart.Location = new System.Drawing.Point(729, 5);
			this.labelPart.Name = "labelPart";
			this.labelPart.Size = new System.Drawing.Size(51, 21);
			this.labelPart.TabIndex = 1;
			this.labelPart.Text = "Part：";
			// 
			// labelSkMesh
			// 
			this.labelSkMesh.AutoSize = true;
			this.labelSkMesh.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelSkMesh.ForeColor = System.Drawing.Color.MintCream;
			this.labelSkMesh.Location = new System.Drawing.Point(661, 5);
			this.labelSkMesh.Name = "labelSkMesh";
			this.labelSkMesh.Size = new System.Drawing.Size(41, 21);
			this.labelSkMesh.TabIndex = 1;
			this.labelSkMesh.Text = "Sk：";
			// 
			// labelStMesh
			// 
			this.labelStMesh.AutoSize = true;
			this.labelStMesh.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelStMesh.ForeColor = System.Drawing.Color.MintCream;
			this.labelStMesh.Location = new System.Drawing.Point(594, 5);
			this.labelStMesh.Name = "labelStMesh";
			this.labelStMesh.Size = new System.Drawing.Size(38, 21);
			this.labelStMesh.TabIndex = 1;
			this.labelStMesh.Text = "St：";
			// 
			// labelMatInst
			// 
			this.labelMatInst.AutoSize = true;
			this.labelMatInst.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelMatInst.ForeColor = System.Drawing.Color.MintCream;
			this.labelMatInst.Location = new System.Drawing.Point(516, 5);
			this.labelMatInst.Name = "labelMatInst";
			this.labelMatInst.Size = new System.Drawing.Size(51, 21);
			this.labelMatInst.TabIndex = 1;
			this.labelMatInst.Text = "Inst：";
			// 
			// labelMatFunc
			// 
			this.labelMatFunc.AutoSize = true;
			this.labelMatFunc.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelMatFunc.ForeColor = System.Drawing.Color.MintCream;
			this.labelMatFunc.Location = new System.Drawing.Point(432, 5);
			this.labelMatFunc.Name = "labelMatFunc";
			this.labelMatFunc.Size = new System.Drawing.Size(57, 21);
			this.labelMatFunc.TabIndex = 1;
			this.labelMatFunc.Text = "Func：";
			// 
			// labelMat
			// 
			this.labelMat.AutoSize = true;
			this.labelMat.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelMat.ForeColor = System.Drawing.Color.MintCream;
			this.labelMat.Location = new System.Drawing.Point(355, 5);
			this.labelMat.Name = "labelMat";
			this.labelMat.Size = new System.Drawing.Size(49, 21);
			this.labelMat.TabIndex = 1;
			this.labelMat.Text = "Mat：";
			// 
			// labelTex
			// 
			this.labelTex.AutoSize = true;
			this.labelTex.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTex.ForeColor = System.Drawing.Color.MintCream;
			this.labelTex.Location = new System.Drawing.Point(279, 5);
			this.labelTex.Name = "labelTex";
			this.labelTex.Size = new System.Drawing.Size(48, 21);
			this.labelTex.TabIndex = 1;
			this.labelTex.Text = "Tex：";
			// 
			// labelBP
			// 
			this.labelBP.AutoSize = true;
			this.labelBP.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelBP.ForeColor = System.Drawing.Color.MintCream;
			this.labelBP.Location = new System.Drawing.Point(212, 5);
			this.labelBP.Name = "labelBP";
			this.labelBP.Size = new System.Drawing.Size(41, 21);
			this.labelBP.TabIndex = 1;
			this.labelBP.Text = "BP：";
			// 
			// labelLevel
			// 
			this.labelLevel.AutoSize = true;
			this.labelLevel.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelLevel.ForeColor = System.Drawing.Color.MintCream;
			this.labelLevel.Location = new System.Drawing.Point(125, 5);
			this.labelLevel.Name = "labelLevel";
			this.labelLevel.Size = new System.Drawing.Size(60, 21);
			this.labelLevel.TabIndex = 1;
			this.labelLevel.Text = "Level：";
			// 
			// labelCount1
			// 
			this.labelCount1.AutoSize = true;
			this.labelCount1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelCount1.ForeColor = System.Drawing.Color.MintCream;
			this.labelCount1.Location = new System.Drawing.Point(18, 5);
			this.labelCount1.Name = "labelCount1";
			this.labelCount1.Size = new System.Drawing.Size(52, 21);
			this.labelCount1.TabIndex = 0;
			this.labelCount1.Text = "行数：";
			// 
			// btn_Check
			// 
			this.btn_Check.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Check.Location = new System.Drawing.Point(257, 9);
			this.btn_Check.Name = "btn_Check";
			this.btn_Check.Size = new System.Drawing.Size(70, 26);
			this.btn_Check.TabIndex = 2;
			this.btn_Check.Text = "チェック";
			this.btn_Check.UseVisualStyleBackColor = true;
			this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLevelPass,
            this.CBpPass,
            this.CTexPass,
            this.CMatPass,
            this.CMatFuncPass,
            this.CMatInstPass,
            this.CStMeshPass,
            this.CSkMeshPass,
            this.CPartPass});
			this.dataGridView1.Location = new System.Drawing.Point(257, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(537, 354);
			this.dataGridView1.TabIndex = 15;
			// 
			// CLevelPass
			// 
			this.CLevelPass.HeaderText = "Level";
			this.CLevelPass.Name = "CLevelPass";
			this.CLevelPass.ReadOnly = true;
			// 
			// CBpPass
			// 
			this.CBpPass.HeaderText = "BP";
			this.CBpPass.Name = "CBpPass";
			this.CBpPass.ReadOnly = true;
			// 
			// CTexPass
			// 
			this.CTexPass.HeaderText = "Tex";
			this.CTexPass.Name = "CTexPass";
			this.CTexPass.ReadOnly = true;
			// 
			// CMatPass
			// 
			this.CMatPass.HeaderText = "Mat";
			this.CMatPass.Name = "CMatPass";
			this.CMatPass.ReadOnly = true;
			// 
			// CMatFuncPass
			// 
			this.CMatFuncPass.HeaderText = "MatFunc";
			this.CMatFuncPass.Name = "CMatFuncPass";
			this.CMatFuncPass.ReadOnly = true;
			// 
			// CMatInstPass
			// 
			this.CMatInstPass.HeaderText = "MatInst";
			this.CMatInstPass.Name = "CMatInstPass";
			this.CMatInstPass.ReadOnly = true;
			// 
			// CStMeshPass
			// 
			this.CStMeshPass.HeaderText = "StMesh";
			this.CStMeshPass.Name = "CStMeshPass";
			this.CStMeshPass.ReadOnly = true;
			// 
			// CSkMeshPass
			// 
			this.CSkMeshPass.HeaderText = "SkMesh";
			this.CSkMeshPass.Name = "CSkMeshPass";
			this.CSkMeshPass.ReadOnly = true;
			// 
			// CPartPass
			// 
			this.CPartPass.HeaderText = "Particle";
			this.CPartPass.Name = "CPartPass";
			this.CPartPass.ReadOnly = true;
			// 
			// btn_copy
			// 
			this.btn_copy.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_copy.Location = new System.Drawing.Point(344, 9);
			this.btn_copy.Name = "btn_copy";
			this.btn_copy.Size = new System.Drawing.Size(145, 26);
			this.btn_copy.TabIndex = 2;
			this.btn_copy.Text = "クリップボードへコピー";
			this.btn_copy.UseVisualStyleBackColor = true;
			this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 437);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_copy);
			this.Controls.Add(this.btn_Check);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimumSize = new System.Drawing.Size(830, 475);
			this.Name = "Form1";
			this.Text = "UE4 アセットの命名規則チェックツール ver.3.0";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelLevel;
		private System.Windows.Forms.Label labelCount1;
		private System.Windows.Forms.Button btn_Check;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CLevelPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CBpPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CTexPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CMatPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CMatFuncPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CMatInstPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CStMeshPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CSkMeshPass;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPartPass;
		private System.Windows.Forms.Label labelPart;
		private System.Windows.Forms.Label labelSkMesh;
		private System.Windows.Forms.Label labelStMesh;
		private System.Windows.Forms.Label labelMatInst;
		private System.Windows.Forms.Label labelMatFunc;
		private System.Windows.Forms.Label labelMat;
		private System.Windows.Forms.Label labelTex;
		private System.Windows.Forms.Label labelBP;
		private System.Windows.Forms.Button btn_copy;
	}
}

