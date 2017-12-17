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

		// 定数の定義：命名規則を保存したテキストファイル名
		private const string chkTextLevel = "NameChk_Level.txt";		// レベル
		private const string chkTextBP = "NameChk_BP.txt";				// ブループリント
		private const string chkTextTex = "NameChk_Tex.txt";			// テクスチャ
		private const string chkTextMat = "NameChk_Mat.txt";			// マテリアル
		private const string chkTextMatFunc = "NameChk_MatFunc.txt";	// マテリアル関数
		private const string chkTextMatInst = "NameChk_MatInst.txt";    // マテリアルインスタンス
		private const string chkTextStMesh = "NameChk_StMesh.txt";		// スタティックメッシュ
		private const string chkTextSkMesh = "NameChk_SkMesh.txt";		// スケルタルメッシュ
		private const string chkTextPart = "NameChk_Part.txt";			// パーティクル
		private const string chkTextDA = "NameChk_DA.txt";              // データアセット
		// 定数の定義：UE4のアセットタイプ情報
		private const string typeLevel = "World";						// レベル
		private const string typeBP = "Blueprint";                      // ブループリント
		private const string typeTex = "Texture2D";                     // テクスチャ
		private const string typeMat = "Material";                      // マテリアル
		private const string typeMatFunc = "MaterialFunction";          // マテリアル関数
		private const string typeMatInst = "MaterialInstanceConstant";  // マテリアルインスタンス
		private const string typeStMesh = "StaticMesh";                 // スタティックメッシュ
		private const string typeSkMesh = "SkeletalMesh";               // スケルタルメッシュ
		private const string typePart = "ParticleSystem";               // パーティクル
		private const string typeDA = "";                               // データアセット

		// 変数の定義
		private bool exist = false; // 正規表現の定義ファイルが存在するかの判定用

		// Listの定義
		List<string> listRule = new List<string>();			// マッチさせたい正規表現のリスト
		List<string> listPass = new List<string>();			// パス部分だけ抽出したリスト
		List<string> listName = new List<string>();			// 名前部分だけ抽出したリスト
		List<string> listOutput = new List<string>();		// 出力する結果のリスト

		// 関数：命名規則の定義ファイルを読み込んでListに代入
		private List<string> getNamingRule(string txt)
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
				// 判定をFalseにする
				exist = false;

				MessageBox.Show("命名規則の定義ファイル " + txt +" がありません");
				return null;
			}
		}

		// 関数：TextBox1のアセット参照情報をパスと名前別々にListに格納
		private void getRefelence(string assetType)
		{
			// 正規表現の定義ファイルがある判定の時だけ実行
			if (exist == true)
			{
				// パスと名前を取り出す正規表現を定義(UE4のリファレンス情報専用の処理)
				Regex reg = new Regex(assetType + "'/Game/(?<pass>(.*?/)*)(?<name>[^.]+)",
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

				// TextBox1内に全く見つからない場合はメッセージを出す
				if (listPass.Count == 0)
				{
					MessageBox.Show("対応する種類のアセットが見つかりません");
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

				// 結果の数をラベルに表示
				labelCount2.Text = "結果の数： " + listOutput.Count.ToString();

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

		// ボタン：Level チェック
		private void btn_Level_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextLevel);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeLevel);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Blueprint チェック
		private void btn_BP_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextBP);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeBP);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Texture チェック
		private void btn_Tex_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextTex);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeTex);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Material チェック
		private void btn_Mat_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextMat);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeMat);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Material Function チェック
		private void btn_MatFunc_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextMatFunc);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeMatFunc);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Material Instance チェック
		private void btn_MatInst_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextMatInst);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeMatInst);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Static Mesh チェック
		private void btn_StMesh_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextStMesh);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeStMesh);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Skeletal Mesh チェック
		private void btn_SkMesh_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextSkMesh);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typeSkMesh);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Particle チェック
		private void btn_Part_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextPart);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(typePart);
			// 命名規則に引っ掛かるアセットをリストアップ
			doRegex();
		}
		// ボタン：Data Asset チェック
		private void btn_DA_Click(object sender, EventArgs e)
		{
			// 命名規則の定義ファイルを読み込んでListに代入
			listRule = getNamingRule(chkTextDA);
			// TextBox1の中身をパスと名前別々にListに格納
			getRefelence(".*?");
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
	}
}
