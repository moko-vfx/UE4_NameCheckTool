using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool_NamingConventionCheck
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// 定数の定義
		private const string txtChkPart = "NameChkPart.txt";		// パーティクル
		private const string txtChkMat = "NameChkMat.txt";			// マテリアル
		private const string txtChkMatFunc = "NameChkMatFunc.txt";	// マテリアル関数
		private const string txtChkMatInst = "NameChkMatInst.txt";	// マテリアルインスタンス
		private const string txtChkSMesh = "NameChkSMesh.txt";		// スタティックメッシュ
		private const string txtChkTex = "NameChkTex.txt";			// テクスチャ
		private const string txtChkBP = "NameChkBP.txt";			// ブループリント
		private const string txtChkDA = "NameChkDA.txt";			// データアセット

		// 変数の定義
		private bool exist = false; // 正規表現の定義ファイルが存在するかの判定用

		// Listの定義
		List<string> listRule = new List<string>();		// マッチさせたい正規表現のリスト
		List<string> listPass = new List<string>();		// パス部分だけ抽出したリスト
		List<string> listName = new List<string>();     // 名前部分だけ抽出したリスト
		List<string> listOutput = new List<string>();	// 出力する結果のリスト

		// 関数：命名規則の定義ファイルを読み込んでListに代入
		private List<string> txtRead(string txt)
		{
			// 指定ファイルがある場合
			if (File.Exists(txt))
			{
				// 判定をTrueにする
				exist = true;

				// Listを定義
				var list = new List<string>();

				// テキストファイルをShift-JISコードとして開く
				StreamReader sr = new StreamReader(
					txt,
					Encoding.GetEncoding("shift_jis"));
				// 内容を一行ずつListに読み込む
				while (sr.EndOfStream == false)
				{
					string line = sr.ReadLine();
					list.Add(@line);
				}
				// 閉じる
				sr.Close();

				return list;
			}
			// 指定ファイルが無い場合
			else
			{
				// 判定をTrueにする
				exist = false;

				MessageBox.Show("命名規則の定義ファイル " + txt +" がありません");
				return null;
			}
		}

		// 関数：TextBox1の中身をパスと名前別々にListに格納
		private void getText ()
		{
			// 正規表現の定義ファイルがある判定の時だけ実行
			if (exist == true)
			{
				// パスと名前を取り出す正規表現を定義(UE4のリファレンス情報専用の処理)
				Regex reg = new Regex(".*?'/Game/(?<pass>(.*?/)*)(?<name>[^.]+)",
					RegexOptions.IgnoreCase | RegexOptions.Multiline);

				// パスと名前別々にListに格納
				for (Match m = reg.Match(textBox1.Text); m.Success; m = m.NextMatch())
				{
					string pass = m.Groups["pass"].Value;
					string name = m.Groups["name"].Value;
					listPass.Add(pass);
					listName.Add(name);
					listOutput.Add(pass + "\t" + name);
				}
			}
		}

		// 関数：命名規則に引っ掛かるアセットをリストアップ
		private void doRegex()
		{
			// 正規表現の定義ファイルがある判定の時だけ実行
			if (exist == true)
			{
				// TextBox2をクリア
				textBox2.ResetText();
				// 桁表示をクリア
				labelCount2.Text = "行数： " + "0";

				// チェック文字列(正規表現)1つずつチェック
				for (int i = 0; i < listRule.Count; i++)
				{
					// 1行ずつチェックして守られているものはListから除外
					// Listから除外するために最後尾から回す
					for (int i2 = listName.Count - 1; i2 >= 0; i2--)
					{
						// 正規表現とマッチした場合
						if (Regex.IsMatch(listName[i2], listRule[i], RegexOptions.IgnoreCase))
						{
							// Listから該当要素を削除する
							listPass.RemoveAt(i2);
							listName.RemoveAt(i2);
							listOutput.RemoveAt(i2);
						}
					}
				}

				// 結果をTextBox2に表示
				foreach (string s in listOutput)
				{
					textBox2.AppendText(s + "\r\n");
				}

				// Listを全てクリア
				listRule.Clear();
				listPass.Clear();
				listName.Clear();
				listOutput.Clear();
			}
		}

		// ボタン：Particle チェック
		private void btn_Particle_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkPart);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Material チェック
		private void btn_Mat_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkMat);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Material Function チェック
		private void btn_MatFunc_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkMatFunc);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Material Instance チェック
		private void btn_MatInst_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkMatInst);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Static Mesh チェック
		private void btn_SMesh_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkSMesh);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Texture チェック
		private void btn_Tex_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkTex);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Blueprint チェック
		private void btn_BP_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkBP);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Data Asset チェック
		private void btn_DA_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = txtRead(txtChkDA);
			// TextBox1の中身をパスと名前別々にListに格納
			getText();
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}

		// キー：テキスト全選択
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				textBox1.SelectAll();
				e.SuppressKeyPress = true;
			}
		}
		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				textBox2.SelectAll();
				e.SuppressKeyPress = true;
			}
		}

		// TextBoxの内容に変更があれば行数表示を更新する
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			labelCount1.Text = "行数： " + textBox1.Lines.Length.ToString();
		}
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			labelCount2.Text = "行数： " + textBox2.Lines.Length.ToString();
		}
	}
}
