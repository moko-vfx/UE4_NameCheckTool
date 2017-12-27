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

		// 変数の定義
		private bool exist = false; // 正規表現の定義ファイルが存在するかの判定用
		private int maxRows = 0;	// Listの最大の行数を保持する

		// Listの定義
		List<string> listRule = new List<string>();			// マッチさせたい正規表現のリスト
		List<string> listPass = new List<string>();			// パス部分だけ抽出したリスト
		List<string> listName = new List<string>();         // 名前部分だけ抽出したリスト
		List<string> listResult = new List<string>();		// 結果のリスト

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
			// Listをクリア
			listPass.Clear();
			listName.Clear();
			listResult.Clear();

			// 正規表現の定義ファイルがある判定の時だけ実行
			if (exist == true)
			{
				// パスと名前を取り出す正規表現を定義(UE4のリファレンス情報専用の処理)
				Regex reg = new Regex(assetType + "'/Game/(?<pass>(.*?/)*)(?<name>[^.]+)",
					RegexOptions.IgnoreCase | RegexOptions.Multiline);

				// パスと名前を別々にListに格納
				for (Match m = reg.Match(textBox1.Text); m.Success; m = m.NextMatch())
				{
					string pass = m.Groups["pass"].Value;
					string name = m.Groups["name"].Value;
					listPass.Add(pass);
					listName.Add(name);
					listResult.Add(pass + name);
				}

				/*
				// TextBox1内に全く見つからない場合はメッセージを出す
				if (listPass.Count == 0)
				{
					MessageBox.Show("対応する種類のアセットが見つかりません");
				}
				*/
			}
		}

		// 関数：命名規則に引っ掛かるアセットをリストアップ
		private void doRegex()
		{
			// 正規表現の定義ファイルがある判定の時だけ実行
			if (exist == true)
			{
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
							listResult.RemoveAt(i2);
						}
					}
				}
			}
		}

		// ボタン：Level チェック
		private void btn_Check_Click(object sender, EventArgs e)
		{
			// DataGridViewをクリア
			dataGridView1.Rows.Clear();

			// アセットタイプごとにリストアップ
			listRule = getNamingRule(chkTextLevel);
			getRefelence(typeLevel);
			doRegex();
			List<string> listLevel = new List<string>(listResult);

			listRule = getNamingRule(chkTextBP);
			getRefelence(typeBP);
			doRegex();
			List<string> listBP = new List<string>(listResult);

			listRule = getNamingRule(chkTextTex);
			getRefelence(typeTex);
			doRegex();
			List<string> listTex = new List<string>(listResult);

			listRule = getNamingRule(chkTextMat);
			getRefelence(typeMat);
			doRegex();
			List<string> listMat = new List<string>(listResult);

			listRule = getNamingRule(chkTextMatFunc);
			getRefelence(typeMatFunc);
			doRegex();
			List<string> listMatFunc = new List<string>(listResult);

			listRule = getNamingRule(chkTextMatInst);
			getRefelence(typeMatInst);
			doRegex();
			List<string> listMatInst = new List<string>(listResult);

			listRule = getNamingRule(chkTextStMesh);
			getRefelence(typeStMesh);
			doRegex();
			List<string> listStMesh = new List<string>(listResult);

			listRule = getNamingRule(chkTextSkMesh);
			getRefelence(typeSkMesh);
			doRegex();
			List<string> listSkMesh = new List<string>(listResult);

			listRule = getNamingRule(chkTextPart);
			getRefelence(typePart);
			doRegex();
			List<string> listPart = new List<string>(listResult);

			//Listの最大格納数を割り出す
			maxRows = new List<int> {
				listLevel.Count,
				listBP.Count,
				listTex.Count,
				listMat.Count,
				listMatFunc.Count,
				listMatInst.Count,
				listStMesh.Count,
				listSkMesh.Count,
				listPart.Count }.Max();

			//Listの最大格納数だけ行を追加
			for (int i = 0; i < maxRows; i++)
			{
				dataGridView1.Rows.Add();
			}

			// DataGridViewの各列にデータを入力
			for (int i = 0; i < listLevel.Count; i++)
			{
				dataGridView1.Rows[i].Cells[0].Value = listLevel[i];
			}
			for (int i = 0; i < listBP.Count; i++)
			{
				dataGridView1.Rows[i].Cells[1].Value = listBP[i];
			}
			for (int i = 0; i < listTex.Count; i++)
			{
				dataGridView1.Rows[i].Cells[2].Value = listTex[i];
			}
			for (int i = 0; i < listMat.Count; i++)
			{
				dataGridView1.Rows[i].Cells[3].Value = listMat[i];
			}
			for (int i = 0; i < listMatFunc.Count; i++)
			{
				dataGridView1.Rows[i].Cells[4].Value = listMatFunc[i];
			}
			for (int i = 0; i < listMatInst.Count; i++)
			{
				dataGridView1.Rows[i].Cells[5].Value = listMatInst[i];
			}
			for (int i = 0; i < listStMesh.Count; i++)
			{
				dataGridView1.Rows[i].Cells[6].Value = listStMesh[i];
			}
			for (int i = 0; i < listSkMesh.Count; i++)
			{
				dataGridView1.Rows[i].Cells[7].Value = listSkMesh[i];
			}
			for (int i = 0; i < listPart.Count; i++)
			{
				dataGridView1.Rows[i].Cells[8].Value = listPart[i];
			}

			// ラベルを更新
			labelLevel.Text = "Level：" + listLevel.Count.ToString();
			labelBP.Text = "BP：" + listBP.Count.ToString();
			labelTex.Text = "Tex：" + listTex.Count.ToString();
			labelMat.Text = "Mat：" + listMat.Count.ToString();
			labelMatFunc.Text = "Func：" + listMatFunc.Count.ToString();
			labelMatInst.Text = "Inst：" + listMatInst.Count.ToString();
			labelStMesh.Text = "St：" + listStMesh.Count.ToString();
			labelSkMesh.Text = "Sk：" + listSkMesh.Count.ToString();
			labelPart.Text = "Part：" + listPart.Count.ToString();

			// 最大行の変数をクリア
			maxRows = 0;
		}

		// ボタン：DataGridViewの内容をクリップボードにTSV形式でコピー
		private void btn_copy_Click(object sender, EventArgs e)
		{
			// 全選択
			dataGridView1.SelectAll();
			// 内容をクリップボードへコピー
			dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			Clipboard.SetDataObject(dataGridView1.GetClipboardContent());
			// クリップボードから取得してコピーし直す（Exelにペースト時に折り返さない対策）
			Clipboard.SetText(Clipboard.GetText());
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

		// TextBoxの内容に変更があれば行数表示を更新する
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			labelCount1.Text = "行数： " + textBox1.Lines.Length.ToString();
		}
	}
}
