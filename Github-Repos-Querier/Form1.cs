using AntdUI;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using static Rox.Runtimes.LocalizedString;
using static Rox.Runtimes.LogLibraries;
namespace GithubReposQuerier
{
    public partial class Form1 : Window
    {
        internal static readonly int Forked_OffsetToStar = 172;
        internal static readonly int Disabled_OffsetToStar = 129;
        internal static readonly int Archived_OffsetToStar = 86;
        internal static readonly int MainLanguage_OffsetToStar = 43;
        internal Stopwatch _stopwatch = Stopwatch.StartNew();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(IInput.Text))
            {
                WriteLog.Error("请输入要查询的用户名+仓库名!");
                MessageBox_I.Error("请输入要查询的用户名+仓库名!", _ERROR);
                return;
            }
            var _p = IInput.Text;
            if (IInput.Text.StartsWith("https://github.com/"))
                _p = IInput.Text.Substring(19);
            else if (IInput.Text.StartsWith("http://github.com/"))
                _p = IInput.Text.Substring(18);
            else if (IInput.Text.StartsWith("github.com/"))
                _p = IInput.Text.Substring(12);
            WriteLog.Info($"查询仓库: {_p}");
            if (!Regex.IsMatch(_p ?? "", "^[a-zA-Z0-9-/]+$"))
            {
                WriteLog.Error("用户名或仓库名不能包含特殊字符!");
                MessageBox_I.Error("用户名或仓库名不能包含特殊字符!", _ERROR);
                return;
            }

            if (_p?.Count(c => c == '/') >= 2)
            {
                WriteLog.Error("仓库路径不能包含两个以上的斜杠!");
                MessageBox_I.Error("仓库路径不能包含两个以上的斜杠!", _ERROR);
                return;
            }
            _stopwatch.Reset();
            _stopwatch.Start();
            SetDefaultValues();
            var result = await UAPI.github.GetReposData(_p);
            if (result == null)
            {
                WriteLog.Error("查询失败，请检查用户名+仓库名是否正确!");
                MessageBox_I.Error("查询失败，请检查用户名+仓库名是否正确!", _ERROR);
                return;
            }
            WriteLog.Info($"查询成功!");
            SetProperties(result);
        }
        private void SetDefaultValues()
        {
            IReposName.Clear();
            IHomePage.Clear();
            ADefaultBranch.Text = "";
            ADefaultBranch.Visible = false;
            AVisibility.Text = "";
            AVisibility.Icon = AntdUI.TType.Info;
            AVisibility.Visible = false;
            AArchived.Visible = false;
            ADisabled.Visible = false;
            AForked.Visible = false;
            AMainLanguage.Visible = false;
            AMainLanguage.Text = "主要代码语言: ";
            AMainLanguage.Icon = TType.Info;
            ALicense.Visible = false;
            ALicense.Text = "";
            ALicense.Icon = TType.Info;
            AStar.Visible = false;
            AStar.Text = "";
            ITopics.Clear();
            ILastPullTime.Clear();
            ICreate.Clear();
            IUpdated.Clear();
            ILicense.Clear();
            IHelp.Clear();
        }
        private void SetProperties(UAPI.github.ReposType Type)
        {
            int Offset_X = AStar.Location.X;
            int Offset_Y = AStar.Location.Y;
            var Forked_points = new System.Drawing.Point(Offset_X, Offset_Y + Forked_OffsetToStar);
            var Disabled_points = new System.Drawing.Point(Offset_X, Offset_Y + Disabled_OffsetToStar);
            var Archived_points = new System.Drawing.Point(Offset_X, Offset_Y + Archived_OffsetToStar);
            var MainLanguage_points = new System.Drawing.Point(Offset_X, Offset_Y + MainLanguage_OffsetToStar);

            string _topics = "";
            for (int i = 0; i < Type.topics.Count; i++)
                _topics += $"{(i == 0 ? "" : ",")}{Type.topics[i]}";
            string _language = "";
            foreach (var v in Type.languages)
                _language += $"{(v.Equals(Type.languages.First()) ? "\n" : "")}\t{v.Key}: {v.Value} 行代码\n";

            WriteLog.Info($"完整名称: {Type.full_name}\n" +
              $"描述: {Type.description}\n" +
              $"主页: {Type.homepage}\n" +
              $"默认分支: {Type.default_branch}\n" +
              $"默认分支SHA值: {Type.default_branch_sha}\n" +
              $"主要分支: {Type.primary_branch}\n" +
              $"可见性: {Type.visibility}\n" +
              $"是否为存档: {Type.archived}\n" +
              $"是否禁用: {Type.disabled}\n" +
              $"是否为Fork的仓库: {Type.fork}\n" +
              $"主要代码语言: {Type.language}\n" +
              $"话题: {_topics}\n" +
              $"许可证: {Type.license}\n" +
              $"Star 数量: {Type.stargazers}\n" +
              $"Fork 的数量: {Type.forks}\n" +
              $"打开的Issue: {Type.open_issues}\n" +
              $"关注人数: {Type.watchers}\n" +
              $"推送时间: {Type.pushed_at_str}\n" +
              $"创建仓库时间: {Type.created_at_str}\n" +
              $"更新时间: {Type.updated_at_str}\n" +
              $"代码语言: {_language}\n" +
              $"仓库协作者: {Type.collaborators}\n");
            foreach (var t in Type.maintainers)
            {
                WriteLog.Info($"协作者: {t.login}\n" +
                              $"名称: {t.name}\n" +
                              $"邮箱: {t.email}\n" +
                              $"个人主页: {t.url}\n\n");
            }
            WriteLog.Info($"请求完毕, 共用时 {_stopwatch.Elapsed.TotalSeconds} 秒");

            IReposName.Text = Type.full_name;
            IHomePage.Text = string.IsNullOrEmpty(Type.homepage) ? "无" : Type.homepage;
            ADefaultBranch.Text = string.IsNullOrEmpty(Type.default_branch) ? "分支获取失败" : $"默认分支: {Type.default_branch}";
            ADefaultBranch.Visible = true;
            AVisibility.Icon = Type.visibility == "public" ? AntdUI.TType.Success : AntdUI.TType.Warn;
            AVisibility.Text = Type.visibility == "public" ? "公开" : "私有";
            AVisibility.Visible = true;
            AMainLanguage.Text += string.IsNullOrEmpty(Type.language) ? "未知" : Type.language;
            AMainLanguage.Visible = !string.IsNullOrEmpty(Type.language);
            AMainLanguage.Icon = string.IsNullOrEmpty(Type.language) ? TType.Error : TType.Success;
            AArchived.Visible = Type.archived;
            AArchived.Location = string.IsNullOrEmpty(Type.language)
                ? MainLanguage_points
                : Archived_points;
            ADisabled.Location = string.IsNullOrEmpty(Type.language)
                ? (Type.archived
                    ? Archived_points
                    : MainLanguage_points)
                : (Type.archived
                    ? Disabled_points
                    : Archived_points);
            AForked.Visible = Type.fork;
            AForked.Location = string.IsNullOrEmpty(Type.language)
                ? (Type.archived
                    ? (Type.disabled
                        ? Disabled_points
                        : Archived_points)
                    : (Type.disabled
                        ? Archived_points
                        : MainLanguage_points))
                : (Type.archived
                    ? (Type.disabled
                        ? Forked_points
                        : Disabled_points)
                    : (Type.disabled
                        ? Disabled_points
                        : Archived_points));
            ITopics.Text = _topics;
            ILicense.Text = string.IsNullOrEmpty(Type.license) ? "无许可证" : Type.license;
            AStar.Text = $"Star 数量: {Type.stargazers}";
            AStar.Visible = true;
            ILastPullTime.Text = Type.pushed_at_str ?? "未知";
            ICreate.Text = Type.created_at_str ?? "未知";
            IUpdated.Text = Type.updated_at_str ?? "未知";
            IHelp.Text = string.IsNullOrEmpty(Type.collaborators?.ToString()) ? "无" : Type.collaborators?.ToString();
        }
    }
}
