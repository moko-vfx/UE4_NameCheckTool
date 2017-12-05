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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_Particle = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelCount2 = new System.Windows.Forms.Label();
			this.labelCount1 = new System.Windows.Forms.Label();
			this.btn_Mat = new System.Windows.Forms.Button();
			this.btn_MatFunc = new System.Windows.Forms.Button();
			this.btn_MatInst = new System.Windows.Forms.Button();
			this.btn_SMesh = new System.Windows.Forms.Button();
			this.btn_BP = new System.Windows.Forms.Button();
			this.btn_Tex = new System.Windows.Forms.Button();
			this.btn_DA = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(20, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(318, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "UE4のリファレンス情報をペーストしてください";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(20, 40);
			this.textBox1.MaxLength = 0;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(318, 419);
			this.textBox1.TabIndex = 1;
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// btn_Particle
			// 
			this.btn_Particle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Particle.Location = new System.Drawing.Point(364, 40);
			this.btn_Particle.Name = "btn_Particle";
			this.btn_Particle.Size = new System.Drawing.Size(155, 41);
			this.btn_Particle.TabIndex = 2;
			this.btn_Particle.Text = "パーティクル";
			this.btn_Particle.UseVisualStyleBackColor = true;
			this.btn_Particle.Click += new System.EventHandler(this.btn_Particle_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(545, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 21);
			this.label2.TabIndex = 10;
			this.label2.Text = "命名規則から外れたアセットを表示";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panel1.Controls.Add(this.labelCount2);
			this.panel1.Controls.Add(this.labelCount1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 475);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(974, 30);
			this.panel1.TabIndex = 12;
			// 
			// labelCount2
			// 
			this.labelCount2.AutoSize = true;
			this.labelCount2.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelCount2.ForeColor = System.Drawing.Color.MintCream;
			this.labelCount2.Location = new System.Drawing.Point(545, 5);
			this.labelCount2.Name = "labelCount2";
			this.labelCount2.Size = new System.Drawing.Size(52, 21);
			this.labelCount2.TabIndex = 1;
			this.labelCount2.Text = "行数：";
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
			// btn_Mat
			// 
			this.btn_Mat.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Mat.Location = new System.Drawing.Point(364, 94);
			this.btn_Mat.Name = "btn_Mat";
			this.btn_Mat.Size = new System.Drawing.Size(155, 41);
			this.btn_Mat.TabIndex = 3;
			this.btn_Mat.Text = "マテリアル";
			this.btn_Mat.UseVisualStyleBackColor = true;
			this.btn_Mat.Click += new System.EventHandler(this.btn_Mat_Click);
			// 
			// btn_MatFunc
			// 
			this.btn_MatFunc.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_MatFunc.Location = new System.Drawing.Point(364, 148);
			this.btn_MatFunc.Name = "btn_MatFunc";
			this.btn_MatFunc.Size = new System.Drawing.Size(155, 41);
			this.btn_MatFunc.TabIndex = 4;
			this.btn_MatFunc.Text = "マテリアル関数";
			this.btn_MatFunc.UseVisualStyleBackColor = true;
			this.btn_MatFunc.Click += new System.EventHandler(this.btn_MatFunc_Click);
			// 
			// btn_MatInst
			// 
			this.btn_MatInst.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_MatInst.Location = new System.Drawing.Point(364, 202);
			this.btn_MatInst.Name = "btn_MatInst";
			this.btn_MatInst.Size = new System.Drawing.Size(155, 41);
			this.btn_MatInst.TabIndex = 5;
			this.btn_MatInst.Text = "マテリアルインスタンス";
			this.btn_MatInst.UseVisualStyleBackColor = true;
			this.btn_MatInst.Click += new System.EventHandler(this.btn_MatInst_Click);
			// 
			// btn_SMesh
			// 
			this.btn_SMesh.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_SMesh.Location = new System.Drawing.Point(364, 256);
			this.btn_SMesh.Name = "btn_SMesh";
			this.btn_SMesh.Size = new System.Drawing.Size(155, 41);
			this.btn_SMesh.TabIndex = 6;
			this.btn_SMesh.Text = "スタティックメッシュ";
			this.btn_SMesh.UseVisualStyleBackColor = true;
			this.btn_SMesh.Click += new System.EventHandler(this.btn_SMesh_Click);
			// 
			// btn_BP
			// 
			this.btn_BP.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_BP.Location = new System.Drawing.Point(364, 364);
			this.btn_BP.Name = "btn_BP";
			this.btn_BP.Size = new System.Drawing.Size(155, 41);
			this.btn_BP.TabIndex = 8;
			this.btn_BP.Text = "BP";
			this.btn_BP.UseVisualStyleBackColor = true;
			this.btn_BP.Click += new System.EventHandler(this.btn_BP_Click);
			// 
			// btn_Tex
			// 
			this.btn_Tex.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Tex.Location = new System.Drawing.Point(364, 310);
			this.btn_Tex.Name = "btn_Tex";
			this.btn_Tex.Size = new System.Drawing.Size(155, 41);
			this.btn_Tex.TabIndex = 7;
			this.btn_Tex.Text = "テクスチャ";
			this.btn_Tex.UseVisualStyleBackColor = true;
			this.btn_Tex.Click += new System.EventHandler(this.btn_Tex_Click);
			// 
			// btn_DA
			// 
			this.btn_DA.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_DA.Location = new System.Drawing.Point(364, 418);
			this.btn_DA.Name = "btn_DA";
			this.btn_DA.Size = new System.Drawing.Size(155, 41);
			this.btn_DA.TabIndex = 9;
			this.btn_DA.Text = "データアセット";
			this.btn_DA.UseVisualStyleBackColor = true;
			this.btn_DA.Click += new System.EventHandler(this.btn_DA_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox2.Location = new System.Drawing.Point(544, 40);
			this.textBox2.MaxLength = 0;
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox2.Size = new System.Drawing.Size(412, 419);
			this.textBox2.TabIndex = 11;
			this.textBox2.WordWrap = false;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 505);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_DA);
			this.Controls.Add(this.btn_MatInst);
			this.Controls.Add(this.btn_Tex);
			this.Controls.Add(this.btn_Mat);
			this.Controls.Add(this.btn_BP);
			this.Controls.Add(this.btn_MatFunc);
			this.Controls.Add(this.btn_SMesh);
			this.Controls.Add(this.btn_Particle);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "アセットの命名規則チェックツール";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_Particle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelCount2;
		private System.Windows.Forms.Label labelCount1;
		private System.Windows.Forms.Button btn_Mat;
		private System.Windows.Forms.Button btn_MatFunc;
		private System.Windows.Forms.Button btn_MatInst;
		private System.Windows.Forms.Button btn_SMesh;
		private System.Windows.Forms.Button btn_BP;
		private System.Windows.Forms.Button btn_Tex;
		private System.Windows.Forms.Button btn_DA;
		private System.Windows.Forms.TextBox textBox2;
	}
}

