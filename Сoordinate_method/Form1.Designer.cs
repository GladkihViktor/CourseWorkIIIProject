namespace Сoordinate_method
{
    partial class fMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1.1 Найти число K");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1.2 Найти координаты вектора");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("1.3 Найти разложение вектора по координатным векторам i и j");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1.4 Найти координаты вектора a+b или a-b");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("1.5 Найти попарно коллинеарные векторы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("1.6 Найти x и y");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("1. Разложение вектора...", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("2.1 Найти координаты вершин прямоугольника");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("2.2 Найти координаты вершины D параллелограмма ABCD");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("2.3.1 Найти координаты начала вектора");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2.3.2 Найти координаты конца вектора");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("2.3 Найти координаты вектора AB", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("2.4.1 Найти x если известна длина вектора");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("2.4.2 Найти y если известна длина вектора");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("2.4 Найти длину вектора по заданным координатам", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("2.5.1 Найти координаты точки");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("2.5 Найти координаты середины отрезка", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("2.6.1 Найти (x)");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("2.6.2 Найти (y)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("2.6 Найти расстояние между точками", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("2.7 Найти периметр треугольника");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("2. Простейшие задачи в координатах...", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode12,
            treeNode15,
            treeNode17,
            treeNode20,
            treeNode21});
            this.MainPanel = new System.Windows.Forms.Panel();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разложениеВектораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиЧислоKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиКоординатыВекторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиРазложениеВектораПоВекторамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиКоординатыВекторовAbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.простейшиеЗадачиВКоординатахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найдитеКоординатыТочекCИDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиКоординатыТочкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.найдитеxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.MainStatus.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.axAcroPDF1);
            this.MainPanel.Controls.Add(this.treeView1);
            this.MainPanel.Controls.Add(this.MainStatus);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(716, 382);
            this.MainPanel.TabIndex = 0;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(374, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(338, 356);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел2";
            treeNode1.Text = "1.1 Найти число K";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "1.2 Найти координаты вектора";
            treeNode3.Name = "Узел5";
            treeNode3.Text = "1.3 Найти разложение вектора по координатным векторам i и j";
            treeNode4.Name = "Узел7";
            treeNode4.Text = "1.4 Найти координаты вектора a+b или a-b";
            treeNode5.Name = "Узел8";
            treeNode5.Text = "1.5 Найти попарно коллинеарные векторы";
            treeNode6.Name = "Узел9";
            treeNode6.Text = "1.6 Найти x и y";
            treeNode7.Name = "Узел0";
            treeNode7.Text = "1. Разложение вектора...";
            treeNode8.Name = "Узел10";
            treeNode8.Text = "2.1 Найти координаты вершин прямоугольника";
            treeNode9.Name = "Узел11";
            treeNode9.Text = "2.2 Найти координаты вершины D параллелограмма ABCD";
            treeNode10.Name = "Узел18";
            treeNode10.Text = "2.3.1 Найти координаты начала вектора";
            treeNode11.Name = "Узел19";
            treeNode11.Text = "2.3.2 Найти координаты конца вектора";
            treeNode12.Name = "Узел17";
            treeNode12.Text = "2.3 Найти координаты вектора AB";
            treeNode13.Name = "Узел22";
            treeNode13.Text = "2.4.1 Найти x если известна длина вектора";
            treeNode14.Name = "Узел23";
            treeNode14.Text = "2.4.2 Найти y если известна длина вектора";
            treeNode15.Name = "Узел21";
            treeNode15.Text = "2.4 Найти длину вектора по заданным координатам";
            treeNode16.Name = "Узел25";
            treeNode16.Text = "2.5.1 Найти координаты точки";
            treeNode17.Name = "Узел24";
            treeNode17.Text = "2.5 Найти координаты середины отрезка";
            treeNode18.Name = "Узел27";
            treeNode18.Text = "2.6.1 Найти (x)";
            treeNode19.Name = "Узел28";
            treeNode19.Text = "2.6.2 Найти (y)";
            treeNode20.Name = "Узел26";
            treeNode20.Text = "2.6 Найти расстояние между точками";
            treeNode21.Name = "Узел29";
            treeNode21.Text = "2.7 Найти периметр треугольника";
            treeNode22.Name = "Узел1";
            treeNode22.Text = "2. Простейшие задачи в координатах...";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(374, 356);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainStatus
            // 
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatusLabel2});
            this.MainStatus.Location = new System.Drawing.Point(0, 356);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Size = new System.Drawing.Size(712, 22);
            this.MainStatus.TabIndex = 0;
            this.MainStatus.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(103, 17);
            this.StatusLabel1.Text = "Метод координат";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачиToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(716, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разложениеВектораToolStripMenuItem,
            this.простейшиеЗадачиВКоординатахToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            this.задачиToolStripMenuItem.Click += new System.EventHandler(this.задачиToolStripMenuItem_Click);
            // 
            // разложениеВектораToolStripMenuItem
            // 
            this.разложениеВектораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиЧислоKToolStripMenuItem,
            this.найтиКоординатыВекторToolStripMenuItem,
            this.найтиРазложениеВектораПоВекторамToolStripMenuItem,
            this.найтиКоординатыВекторовAbToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.разложениеВектораToolStripMenuItem.Name = "разложениеВектораToolStripMenuItem";
            this.разложениеВектораToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.разложениеВектораToolStripMenuItem.Text = "1. Разложение вектора...";
            // 
            // найтиЧислоKToolStripMenuItem
            // 
            this.найтиЧислоKToolStripMenuItem.Name = "найтиЧислоKToolStripMenuItem";
            this.найтиЧислоKToolStripMenuItem.Size = new System.Drawing.Size(422, 22);
            this.найтиЧислоKToolStripMenuItem.Text = "1.1 Найти число K";
            this.найтиЧислоKToolStripMenuItem.Click += new System.EventHandler(this.найтиЧислоKToolStripMenuItem_Click);
            // 
            // найтиКоординатыВекторToolStripMenuItem
            // 
            this.найтиКоординатыВекторToolStripMenuItem.Name = "найтиКоординатыВекторToolStripMenuItem";
            this.найтиКоординатыВекторToolStripMenuItem.Size = new System.Drawing.Size(422, 22);
            this.найтиКоординатыВекторToolStripMenuItem.Text = "1.2 Найти координаты вектора";
            this.найтиКоординатыВекторToolStripMenuItem.Click += new System.EventHandler(this.найтиКоординатыВекторToolStripMenuItem_Click);
            // 
            // найтиРазложениеВектораПоВекторамToolStripMenuItem
            // 
            this.найтиРазложениеВектораПоВекторамToolStripMenuItem.Name = "найтиРазложениеВектораПоВекторамToolStripMenuItem";
            this.найтиРазложениеВектораПоВекторамToolStripMenuItem.Size = new System.Drawing.Size(422, 22);
            this.найтиРазложениеВектораПоВекторамToolStripMenuItem.Text = "1.3 Найти разложение вектора по координатным векторам i и j";
            this.найтиРазложениеВектораПоВекторамToolStripMenuItem.Click += new System.EventHandler(this.найтиРазложениеВектораПоВекторамToolStripMenuItem_Click);
            // 
            // найтиКоординатыВекторовAbToolStripMenuItem
            // 
            this.найтиКоординатыВекторовAbToolStripMenuItem.Name = "найтиКоординатыВекторовAbToolStripMenuItem";
            this.найтиКоординатыВекторовAbToolStripMenuItem.Size = new System.Drawing.Size(422, 22);
            this.найтиКоординатыВекторовAbToolStripMenuItem.Text = "1.4 Найти координаты вектора a+b или a-b ";
            this.найтиКоординатыВекторовAbToolStripMenuItem.Click += new System.EventHandler(this.найтиКоординатыВекторовAbToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(422, 22);
            this.toolStripMenuItem4.Text = "1.5 Найти попарно коллинеарные векторы";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(422, 22);
            this.toolStripMenuItem5.Text = "1.6 Найти x и y";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // простейшиеЗадачиВКоординатахToolStripMenuItem
            // 
            this.простейшиеЗадачиВКоординатахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem,
            this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem,
            this.toolStripMenuItem3,
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem,
            this.найдитеКоординатыТочекCИDToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.простейшиеЗадачиВКоординатахToolStripMenuItem.Name = "простейшиеЗадачиВКоординатахToolStripMenuItem";
            this.простейшиеЗадачиВКоординатахToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.простейшиеЗадачиВКоординатахToolStripMenuItem.Text = "2. Простейшие задачи в координатах...";
            // 
            // найтиКоординатыВершинПрямоугольникаToolStripMenuItem
            // 
            this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem.Name = "найтиКоординатыВершинПрямоугольникаToolStripMenuItem";
            this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem.Text = "2.1 Найти координаты вершин прямоугольника";
            this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem.Click += new System.EventHandler(this.найтиКоординатыВершинПрямоугольникаToolStripMenuItem_Click);
            // 
            // найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem
            // 
            this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem.Name = "найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem";
            this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem.Text = "2.2 Найти координаты вершины D параллелограмма ABCD";
            this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem.Click += new System.EventHandler(this.найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(402, 22);
            this.toolStripMenuItem3.Text = "2.3 Найти координаты вектора AB";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(293, 22);
            this.toolStripMenuItem9.Text = "2.3.1 Найти координаты начала вектора";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click_1);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(293, 22);
            this.toolStripMenuItem10.Text = "2.3.2 Найти координаты конца вектора";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click_1);
            // 
            // найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem
            // 
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem,
            this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem});
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem.Name = "найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem";
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem.Text = "2.4 Найти длину вектора по заданным координатам";
            this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem.Click += new System.EventHandler(this.найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem_Click);
            // 
            // найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem
            // 
            this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem.Name = "найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem";
            this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem.Text = "2.4.1 Найти x если известна длина вектора";
            this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem.Click += new System.EventHandler(this.найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem_Click);
            // 
            // найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem
            // 
            this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem.Name = "найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem";
            this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem.Text = "2.4.2 Найти y если известна длина вектора";
            this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem.Click += new System.EventHandler(this.найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem_Click);
            // 
            // найдитеКоординатыТочекCИDToolStripMenuItem
            // 
            this.найдитеКоординатыТочекCИDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиКоординатыТочкиToolStripMenuItem});
            this.найдитеКоординатыТочекCИDToolStripMenuItem.Name = "найдитеКоординатыТочекCИDToolStripMenuItem";
            this.найдитеКоординатыТочекCИDToolStripMenuItem.Size = new System.Drawing.Size(402, 22);
            this.найдитеКоординатыТочекCИDToolStripMenuItem.Text = "2.5 Найти координаты середины отрезка";
            this.найдитеКоординатыТочекCИDToolStripMenuItem.Click += new System.EventHandler(this.найдитеКоординатыТочекCИDToolStripMenuItem_Click);
            // 
            // найтиКоординатыТочкиToolStripMenuItem
            // 
            this.найтиКоординатыТочкиToolStripMenuItem.Name = "найтиКоординатыТочкиToolStripMenuItem";
            this.найтиКоординатыТочкиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.найтиКоординатыТочкиToolStripMenuItem.Text = "2.5.1 Найти координаты точки";
            this.найтиКоординатыТочкиToolStripMenuItem.Click += new System.EventHandler(this.найтиКоординатыТочкиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найдитеxToolStripMenuItem,
            this.найтиxToolStripMenuItem});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(402, 22);
            this.toolStripMenuItem7.Text = "2.6 Найти расстояние между точками";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // найдитеxToolStripMenuItem
            // 
            this.найдитеxToolStripMenuItem.Name = "найдитеxToolStripMenuItem";
            this.найдитеxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.найдитеxToolStripMenuItem.Text = "2.6.1 Найти (x)";
            this.найдитеxToolStripMenuItem.Click += new System.EventHandler(this.найдитеxToolStripMenuItem_Click);
            // 
            // найтиxToolStripMenuItem
            // 
            this.найтиxToolStripMenuItem.Name = "найтиxToolStripMenuItem";
            this.найтиxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.найтиxToolStripMenuItem.Text = "2.6.2 Найти (y)";
            this.найтиxToolStripMenuItem.Click += new System.EventHandler(this.найтиxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(402, 22);
            this.toolStripMenuItem8.Text = "2.7 Найти периметр треугольника";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 406);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(473, 279);
            this.Name = "fMain";
            this.Text = "Метод координат";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.StatusStrip MainStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разложениеВектораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиЧислоKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиКоординатыВекторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиРазложениеВектораПоВекторамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиКоординатыВекторовAbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem простейшиеЗадачиВКоординатахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиКоординатыВершинПрямоугольникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найдитеКоординатыВершиныDПараллелограммаABCDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem найтиДлинуВектораПоЗаданнымКоординатамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найдитеКоординатыТочекCИDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem найдитеxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиКоординатыТочкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem найтиXЕслиИзвестнаДлинаВектораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиYЕслиИзвестнаДлинаВектораToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}

