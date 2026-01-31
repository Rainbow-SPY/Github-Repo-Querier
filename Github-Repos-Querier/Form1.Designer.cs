namespace GithubReposQuerier
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AntdUI.HyperlinkLabel.LinkAppearance linkAppearance3 = new AntdUI.HyperlinkLabel.LinkAppearance();
            AntdUI.HyperlinkLabel.LinkAppearance linkAppearance4 = new AntdUI.HyperlinkLabel.LinkAppearance();
            this.pageHeader1 = new AntdUI.PageHeader();
            this.button1 = new AntdUI.Button();
            this.divider1 = new AntdUI.Divider();
            this.IInput = new AntdUI.Input();
            this.IAccountCreatedStr = new AntdUI.Input();
            this.IHelp = new AntdUI.Input();
            this.IUpdated = new AntdUI.Input();
            this.ICreate = new AntdUI.Input();
            this.ILastPullTime = new AntdUI.Input();
            this.ITopics = new AntdUI.Input();
            this.IHomePage = new AntdUI.Input();
            this.IReposName = new AntdUI.Input();
            this.label8 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.LReposName = new AntdUI.Label();
            this.ADefaultBranch = new AntdUI.Alert();
            this.AVisibility = new AntdUI.Alert();
            this.AArchived = new AntdUI.Alert();
            this.ADisabled = new AntdUI.Alert();
            this.HyDisabledWhy = new AntdUI.HyperlinkLabel();
            this.CDIsabledWhy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AForked = new AntdUI.Alert();
            this.AMainLanguage = new AntdUI.Alert();
            this.ALicence = new AntdUI.Alert();
            this.AStar = new AntdUI.Alert();
            this.ADisabled.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageHeader1
            // 
            this.pageHeader1.DividerShow = true;
            this.pageHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.pageHeader1.Location = new System.Drawing.Point(0, 0);
            this.pageHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.pageHeader1.Name = "pageHeader1";
            this.pageHeader1.ShowButton = true;
            this.pageHeader1.ShowIcon = true;
            this.pageHeader1.Size = new System.Drawing.Size(767, 32);
            this.pageHeader1.TabIndex = 32;
            this.pageHeader1.Text = "Github 仓库查询 - v1.0.26131";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(550, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 34);
            this.button1.TabIndex = 39;
            this.button1.Text = "Go";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // divider1
            // 
            this.divider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divider1.BackColor = System.Drawing.Color.Transparent;
            this.divider1.ColorSplit = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.divider1.Location = new System.Drawing.Point(0, 69);
            this.divider1.Name = "divider1";
            this.divider1.OrientationMargin = 0F;
            this.divider1.Size = new System.Drawing.Size(767, 23);
            this.divider1.TabIndex = 38;
            this.divider1.Text = "";
            this.divider1.Thickness = 1F;
            // 
            // IInput
            // 
            this.IInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IInput.BorderActive = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.IInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.IInput.BorderHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IInput.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IInput.Location = new System.Drawing.Point(187, 39);
            this.IInput.Name = "IInput";
            this.IInput.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(100)))), ((int)(((byte)(127)))));
            this.IInput.PlaceholderText = "请输入要查询的所有者+仓库(owner/repo)";
            this.IInput.Size = new System.Drawing.Size(357, 34);
            this.IInput.SuffixText = "";
            this.IInput.TabIndex = 37;
            // 
            // IAccountCreatedStr
            // 
            this.IAccountCreatedStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IAccountCreatedStr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IAccountCreatedStr.Location = new System.Drawing.Point(126, 289);
            this.IAccountCreatedStr.Name = "IAccountCreatedStr";
            this.IAccountCreatedStr.ReadOnly = true;
            this.IAccountCreatedStr.Size = new System.Drawing.Size(388, 33);
            this.IAccountCreatedStr.SuffixFore = System.Drawing.SystemColors.ActiveCaptionText;
            this.IAccountCreatedStr.SuffixSvg = "";
            this.IAccountCreatedStr.SuffixText = "";
            this.IAccountCreatedStr.TabIndex = 48;
            // 
            // IHelp
            // 
            this.IHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IHelp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IHelp.Location = new System.Drawing.Point(127, 262);
            this.IHelp.Name = "IHelp";
            this.IHelp.ReadOnly = true;
            this.IHelp.Size = new System.Drawing.Size(388, 33);
            this.IHelp.TabIndex = 49;
            // 
            // IUpdated
            // 
            this.IUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IUpdated.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IUpdated.Location = new System.Drawing.Point(127, 234);
            this.IUpdated.Name = "IUpdated";
            this.IUpdated.ReadOnly = true;
            this.IUpdated.Size = new System.Drawing.Size(388, 33);
            this.IUpdated.TabIndex = 50;
            // 
            // ICreate
            // 
            this.ICreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ICreate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ICreate.Location = new System.Drawing.Point(127, 206);
            this.ICreate.Name = "ICreate";
            this.ICreate.ReadOnly = true;
            this.ICreate.Size = new System.Drawing.Size(388, 33);
            this.ICreate.TabIndex = 51;
            // 
            // ILastPullTime
            // 
            this.ILastPullTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ILastPullTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ILastPullTime.Location = new System.Drawing.Point(127, 178);
            this.ILastPullTime.Name = "ILastPullTime";
            this.ILastPullTime.ReadOnly = true;
            this.ILastPullTime.Size = new System.Drawing.Size(388, 33);
            this.ILastPullTime.TabIndex = 52;
            // 
            // ITopics
            // 
            this.ITopics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITopics.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ITopics.Location = new System.Drawing.Point(127, 150);
            this.ITopics.Name = "ITopics";
            this.ITopics.ReadOnly = true;
            this.ITopics.Size = new System.Drawing.Size(388, 33);
            this.ITopics.TabIndex = 53;
            // 
            // IHomePage
            // 
            this.IHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IHomePage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IHomePage.Location = new System.Drawing.Point(127, 122);
            this.IHomePage.Name = "IHomePage";
            this.IHomePage.ReadOnly = true;
            this.IHomePage.Size = new System.Drawing.Size(388, 33);
            this.IHomePage.TabIndex = 54;
            // 
            // IReposName
            // 
            this.IReposName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IReposName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IReposName.Location = new System.Drawing.Point(127, 94);
            this.IReposName.Name = "IReposName";
            this.IReposName.ReadOnly = true;
            this.IReposName.Size = new System.Drawing.Size(388, 33);
            this.IReposName.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(11, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 40;
            this.label8.Text = "账号创建时间";
            // 
            // label7
            // 
            this.label7.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "仓库协作者";
            // 
            // label6
            // 
            this.label6.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "仓库变动的时间";
            // 
            // label5
            // 
            this.label5.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "创建仓库的时间";
            // 
            // label4
            // 
            this.label4.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "最后推送时间";
            // 
            // label3
            // 
            this.label3.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "话题";
            // 
            // label2
            // 
            this.label2.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "主页链接";
            // 
            // LReposName
            // 
            this.LReposName.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.LReposName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LReposName.Location = new System.Drawing.Point(12, 98);
            this.LReposName.Name = "LReposName";
            this.LReposName.Size = new System.Drawing.Size(48, 22);
            this.LReposName.TabIndex = 47;
            this.LReposName.Text = "仓库名";
            // 
            // ADefaultBranch
            // 
            this.ADefaultBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ADefaultBranch.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ADefaultBranch.Icon = AntdUI.TType.Info;
            this.ADefaultBranch.Location = new System.Drawing.Point(550, 98);
            this.ADefaultBranch.Name = "ADefaultBranch";
            this.ADefaultBranch.Size = new System.Drawing.Size(205, 37);
            this.ADefaultBranch.TabIndex = 56;
            this.ADefaultBranch.Text = "$branch";
            this.ADefaultBranch.TextTitle = "";
            // 
            // AVisibility
            // 
            this.AVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AVisibility.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AVisibility.Icon = AntdUI.TType.Info;
            this.AVisibility.Location = new System.Drawing.Point(550, 141);
            this.AVisibility.Name = "AVisibility";
            this.AVisibility.Size = new System.Drawing.Size(205, 37);
            this.AVisibility.TabIndex = 56;
            this.AVisibility.Text = "$visibility";
            this.AVisibility.TextTitle = "";
            // 
            // AArchived
            // 
            this.AArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AArchived.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AArchived.Icon = AntdUI.TType.Warn;
            this.AArchived.Location = new System.Drawing.Point(550, 313);
            this.AArchived.Name = "AArchived";
            this.AArchived.Size = new System.Drawing.Size(205, 37);
            this.AArchived.TabIndex = 56;
            this.AArchived.Text = "该仓库已归档";
            this.AArchived.TextTitle = "";
            // 
            // ADisabled
            // 
            this.ADisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ADisabled.Controls.Add(this.HyDisabledWhy);
            this.ADisabled.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ADisabled.Icon = AntdUI.TType.Warn;
            this.ADisabled.Location = new System.Drawing.Point(550, 356);
            this.ADisabled.LoopInfinite = false;
            this.ADisabled.Name = "ADisabled";
            this.ADisabled.Size = new System.Drawing.Size(205, 37);
            this.ADisabled.TabIndex = 56;
            this.ADisabled.Text = "该仓库已经被禁用";
            this.ADisabled.TextTitle = "";
            // 
            // HyDisabledWhy
            // 
            this.HyDisabledWhy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(230)))));
            this.HyDisabledWhy.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HyDisabledWhy.HoverStyle = linkAppearance3;
            this.HyDisabledWhy.LinkAutoNavigation = true;
            this.HyDisabledWhy.Location = new System.Drawing.Point(142, 8);
            this.HyDisabledWhy.Name = "HyDisabledWhy";
            linkAppearance4.LinkColor = System.Drawing.Color.Blue;
            linkAppearance4.UnderlineColor = System.Drawing.Color.Gray;
            this.HyDisabledWhy.NormalStyle = linkAppearance4;
            this.HyDisabledWhy.Size = new System.Drawing.Size(75, 23);
            this.HyDisabledWhy.TabIndex = 57;
            this.HyDisabledWhy.Text = "<a href=\"https://docs.github.com/zh/site-policy/content-removal-policies/submitti" +
    "ng-content-removal-requests\">为什么?</a>";
            // 
            // CDIsabledWhy
            // 
            this.CDIsabledWhy.Name = "CDIsabledWhy";
            this.CDIsabledWhy.Size = new System.Drawing.Size(61, 4);
            // 
            // AForked
            // 
            this.AForked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AForked.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AForked.Icon = AntdUI.TType.Warn;
            this.AForked.Location = new System.Drawing.Point(550, 399);
            this.AForked.Name = "AForked";
            this.AForked.Size = new System.Drawing.Size(205, 37);
            this.AForked.TabIndex = 56;
            this.AForked.Text = "该仓库为Forked";
            this.AForked.TextTitle = "";
            // 
            // AMainLanguage
            // 
            this.AMainLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AMainLanguage.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AMainLanguage.Icon = AntdUI.TType.Success;
            this.AMainLanguage.Location = new System.Drawing.Point(550, 227);
            this.AMainLanguage.Name = "AMainLanguage";
            this.AMainLanguage.Size = new System.Drawing.Size(205, 37);
            this.AMainLanguage.TabIndex = 56;
            this.AMainLanguage.Text = "主要代码语言:";
            this.AMainLanguage.TextTitle = "";
            // 
            // ALicence
            // 
            this.ALicence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ALicence.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ALicence.Icon = AntdUI.TType.Success;
            this.ALicence.Location = new System.Drawing.Point(550, 270);
            this.ALicence.Name = "ALicence";
            this.ALicence.Size = new System.Drawing.Size(205, 37);
            this.ALicence.TabIndex = 56;
            this.ALicence.Text = "";
            this.ALicence.TextTitle = "";
            // 
            // AStar
            // 
            this.AStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AStar.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AStar.Icon = AntdUI.TType.Success;
            this.AStar.Location = new System.Drawing.Point(550, 184);
            this.AStar.Name = "AStar";
            this.AStar.Size = new System.Drawing.Size(205, 37);
            this.AStar.TabIndex = 56;
            this.AStar.Text = "";
            this.AStar.TextTitle = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 507);
            this.Controls.Add(this.AArchived);
            this.Controls.Add(this.ADisabled);
            this.Controls.Add(this.AStar);
            this.Controls.Add(this.AMainLanguage);
            this.Controls.Add(this.ALicence);
            this.Controls.Add(this.AForked);
            this.Controls.Add(this.AVisibility);
            this.Controls.Add(this.ADefaultBranch);
            this.Controls.Add(this.IAccountCreatedStr);
            this.Controls.Add(this.IHelp);
            this.Controls.Add(this.IUpdated);
            this.Controls.Add(this.ICreate);
            this.Controls.Add(this.ILastPullTime);
            this.Controls.Add(this.ITopics);
            this.Controls.Add(this.IHomePage);
            this.Controls.Add(this.IReposName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LReposName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.IInput);
            this.Controls.Add(this.pageHeader1);
            this.MinimumSize = new System.Drawing.Size(767, 507);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ADisabled.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AntdUI.PageHeader pageHeader1;
        private AntdUI.Button button1;
        private AntdUI.Divider divider1;
        private AntdUI.Input IInput;
        private AntdUI.Input IAccountCreatedStr;
        private AntdUI.Input IHelp;
        private AntdUI.Input IUpdated;
        private AntdUI.Input ICreate;
        private AntdUI.Input ILastPullTime;
        private AntdUI.Input ITopics;
        private AntdUI.Input IHomePage;
        private AntdUI.Input IReposName;
        private AntdUI.Label label8;
        private AntdUI.Label label7;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label LReposName;
        private AntdUI.Alert ADefaultBranch;
        private AntdUI.Alert AVisibility;
        private AntdUI.Alert AArchived;
        private AntdUI.Alert ADisabled;
        private System.Windows.Forms.ContextMenuStrip CDIsabledWhy;
        private AntdUI.HyperlinkLabel HyDisabledWhy;
        private AntdUI.Alert AForked;
        private AntdUI.Alert AMainLanguage;
        private AntdUI.Alert ALicence;
        private AntdUI.Alert AStar;
    }
}

