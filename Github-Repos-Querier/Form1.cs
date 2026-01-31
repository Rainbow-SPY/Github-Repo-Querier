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
        internal static readonly System.Drawing.Point Forked_points = new System.Drawing.Point(550, 402);
        internal static readonly System.Drawing.Point Disabled_points = new System.Drawing.Point(550, 359);
        internal static readonly System.Drawing.Point Archived_points = new System.Drawing.Point(550, 316);
        internal static readonly System.Drawing.Point Licence_points = new System.Drawing.Point(550, 273);
        internal Stopwatch _stopwatch = Stopwatch.StartNew();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            if (!Regex.IsMatch(IInput.Text ?? "", "^[a-zA-Z0-9-/]+$"))
            {
                WriteLog.Error("用户名或仓库名不能包含特殊字符!");
                MessageBox_I.Error("用户名或仓库名不能包含特殊字符!", _ERROR);
                return;
            }

            if (IInput.Text?.Count(c => c == '/') >= 2)
            {
                WriteLog.Error("仓库路径不能包含两个以上的斜杠!");
                MessageBox_I.Error("仓库路径不能包含两个以上的斜杠!", _ERROR);
                return;
            }
            _stopwatch.Reset();
            _stopwatch.Start();
            if (string.IsNullOrEmpty(IInput.Text))
            {
                WriteLog.Error("请输入要查询的用户名+仓库名!");
                MessageBox_I.Error("请输入要查询的用户名+仓库名!", _ERROR);
                return;
            }
            SetDefaultValues();
            var result = await UAPI.github.GetReposData(IInput.Text);
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
            AArchived.Location = Archived_points;
            ADisabled.Visible = false;
            ADisabled.Location = Disabled_points;
            AForked.Visible = false;
            AForked.Location = Forked_points;
            AMainLanguage.Visible = false;
            AMainLanguage.Text = "主要代码语言: ";
            AMainLanguage.Icon = TType.Info;
            ALicence.Visible = false;
            ALicence.Text = "";
            ALicence.Icon = TType.Info;
            AStar.Visible = false;
            AStar.Text = "";
            ILastPullTime.Clear();
            ICreate.Clear();
            IUpdated.Clear();
            IHelp.Clear();
        }
        private void SetProperties(UAPI.github.ReposType Type)
        {
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
              $"话题: {Type.topics}\n" +
              $"许可证: {Type.license}\n" +
              $"Star 数量: {Type.stargazers}\n" +
              $"Fork 的数量: {Type.forks}\n" +
              $"打开的Issue: {Type.open_issues}\n" +
              $"关注人数: {Type.watchers}\n" +
              $"推送时间: {Type.pushed_at_str}\n" +
              $"创建仓库时间: {Type.created_at_str}\n" +
              $"更新时间: {Type.updated_at_str}\n" +
              $"代码语言: {Type.languages}\n" +
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
            IHomePage.Text = Type.homepage;
            ADefaultBranch.Text = string.IsNullOrEmpty(Type.default_branch) ? "获取失败" : Type.default_branch;
            ADefaultBranch.Visible = true;
            AVisibility.Icon = Type.visibility == "public" ? AntdUI.TType.Success : AntdUI.TType.Warn;
            AVisibility.Text = Type.visibility == "public" ? "公开" : "私有";
            AVisibility.Visible = true;
            AArchived.Visible = Type.archived;
            ADisabled.Location = (!Type.archived && Type.disabled) ? Archived_points : Disabled_points;
            AForked.Visible = Type.fork;
            AForked.Location = AArchived.Visible ? (ADisabled.Visible ? Forked_points : Disabled_points) : Archived_points;
            AMainLanguage.Text += string.IsNullOrEmpty(Type.language) ? "未知" : Type.language;
            AMainLanguage.Visible = !string.IsNullOrEmpty(Type.language);
            AMainLanguage.Icon = string.IsNullOrEmpty(Type.language) ? TType.Error : TType.Success;
            foreach (string a in Type.topics)
                ITopics.Text += a;
            ALicence.Text = string.IsNullOrEmpty(Type.license) ? "无许可证" : $"许可证: {Type.license}";
            ALicence.Visible = !string.IsNullOrEmpty(Type.license);
            ALicence.Icon = string.IsNullOrEmpty(Type.license) ? TType.Info : TType.Success;
            AStar.Text = $"Star 数量: {Type.stargazers}";
            AStar.Visible = true;
            ILastPullTime.Text = Type.pushed_at_str ?? "未知";
            ICreate.Text = Type.created_at_str ?? "未知";
            IUpdated.Text = Type.updated_at_str ?? "未知";
            IHelp.Text = Type.collaborators?.ToString();
        }
    }
}
