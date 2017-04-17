using System;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Find_in_Files
{
    public partial class FrmMain : Form
    {
        string sFind = "";
        EllipseStyle ellipseStyle = new EllipseStyle();
        private TextStyle hightlightStyle = new TextStyle(Brushes.OrangeRed, Brushes.Green, FontStyle.Regular);

        public FrmMain()
        {
            InitializeComponent();
        }

        string GetFileContent(string sFile) => File.ReadAllText(sFile);

        bool IsFileHidden(string filePath)
        {
            if (Path.GetFileName(filePath).StartsWith(".")) return true;
            return (File.GetAttributes(filePath) & FileAttributes.Hidden) == FileAttributes.Hidden;
        }

        bool IsFolderHidden(string dir)
        {
            if (Path.GetFileName(dir).StartsWith(".")) return true;
            return (new DirectoryInfo(dir).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden;
        }

        void DirSearch(string sDir, string sFilter)
        {
            try
            {
                if (ChkExcludeHidden.Checked && IsFolderHidden(sDir))
                    return;

                LblMsg.Text = sDir + "...";
                Application.DoEvents();
                foreach (string f in Directory.GetFiles(sDir, sFilter)) //todo: multiple filters
                {
                    if (ChkExcludeHidden.Checked && IsFileHidden(f))
                        continue;
                    FindInFile(f);
                }
                if (!ChkSubFolder.Checked) return;
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d, sFilter);
                }
            }
            catch (Exception ex)
            {
                LblMsg.Text = ex.Message;
            }
        }

        void FindInFile(string sFile)
        {
            var Content = GetFileContent(sFile);
            //if (!Content.Contains(sFind)) return;
            var strCompare = !ChkMatchCase.Checked ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
            if (Content.IndexOf(sFind, strCompare) < 0) return;

            string[] itmA = new string[2];
            itmA[0] = Path.GetFileName(sFile);
            itmA[1] = Path.GetDirectoryName(sFile);
            var lvwItem = new ListViewItem(itmA);
            LvwResult.Items.Add(lvwItem);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            //todo: Validation
            //todo: Auto remove duplicate folder

            Cursor = Cursors.WaitCursor;
            LvwResult.Items.Clear();
            TxtFile.Text = "";

            sFind = TxtFind.Text;
            var sFilter = CboFilter.Text;

            foreach (var sDir in TxtFolders.Text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (!Directory.Exists(sDir)) continue;
                DirSearch(sDir, sFilter);
            }
            LblMsg.Text = "Completed.";
            Cursor = Cursors.Default;
        }

        private void LblAddFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            var sDir = ofd.SelectedPath;
            //todo: if already added
            TxtFolders.Text = TxtFolders.Text.Trim().Length == 0 ? sDir : TxtFolders.Text + Environment.NewLine + sDir;
        }

        private void LvwResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvwResult.SelectedItems.Count == 0) return;
            var sFile = Path.Combine(LvwResult.SelectedItems[0].SubItems[1].Text, LvwResult.SelectedItems[0].Text);

            // Open file and hightlight
            var lang = Language.Custom;
            var ext = Path.GetExtension(sFile).ToLower();
            switch (ext)
            {
                case ".sql":
                    lang = Language.SQL;
                    break;
                case ".xml":
                case ".jrxml":
                    lang = Language.XML;
                    break;
                case ".php":
                    lang = Language.PHP;
                    break;
                default:
                    lang = Language.Custom;
                    break;
            }
            TxtFile.Language = lang;
            TxtFile.OpenFile(sFile);
        }

        private void TxtFile_TextChanged(object sender, TextChangedEventArgs e)
        {
            //clear old styles of chars
            e.ChangedRange.ClearStyle(ellipseStyle);
            //append style for word 'Babylon'
            e.ChangedRange.SetStyle(ellipseStyle, TxtFind.Text, !ChkMatchCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None); //RegexOptions.IgnoreCase
        }
    }

    /// <summary>
    /// This style will drawing ellipse around of the word
    /// </summary>
    class EllipseStyle : Style
    {
        public override void Draw(Graphics gr, Point position, Range range)
        {
            //get size of rectangle
            Size size = GetSizeOfRange(range);
            //create rectangle
            Rectangle rect = new Rectangle(position, size);
            //inflate it
            rect.Inflate(2, 2);

            //get rounded rectangle
            var path = GetRoundedRectangle(rect, 7);
            //draw rounded rectangle
            gr.DrawPath(Pens.Red, path);
        }
    }
}
