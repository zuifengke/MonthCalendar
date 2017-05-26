namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateItem1 = new Pabo.Calendar.DateItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.monthCalendar3 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar1 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar2 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar4 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar5 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar6 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar7 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar8 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar9 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar10 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar11 = new Pabo.Calendar.MonthCalendar();
            this.monthCalendar12 = new Pabo.Calendar.MonthCalendar();
            this.SuspendLayout();
            // 
            // dateItem1
            // 
            this.dateItem1.BackColor1 = System.Drawing.Color.Empty;
            this.dateItem1.BackColor2 = System.Drawing.Color.White;
            this.dateItem1.BackgroundImage = null;
            this.dateItem1.BoldedDate = false;
            this.dateItem1.Date = new System.DateTime(2017, 5, 27, 0, 0, 0, 0);
            this.dateItem1.DateColor = System.Drawing.Color.Empty;
            this.dateItem1.Enabled = true;
            this.dateItem1.GradientMode = Pabo.Calendar.mcGradientMode.None;
            this.dateItem1.Image = null;
            this.dateItem1.ImageListIndex = -1;
            this.dateItem1.Pattern = Pabo.Calendar.mcDayInfoRecurrence.None;
            this.dateItem1.Range = new System.DateTime(2017, 5, 27, 0, 0, 0, 0);
            this.dateItem1.Tag = null;
            this.dateItem1.Text = "";
            this.dateItem1.TextColor = System.Drawing.Color.Empty;
            this.dateItem1.Weekend = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "holiday.png");
            this.imageList1.Images.SetKeyName(1, "holiday2.png");
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.ActiveMonth.Month = 1;
            this.monthCalendar3.ActiveMonth.Year = 2017;
            this.monthCalendar3.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar3.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar3.Footer.ShowToday = false;
            this.monthCalendar3.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar3.Header.MonthSelectors = false;
            this.monthCalendar3.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar3.ImageList = null;
            this.monthCalendar3.Location = new System.Drawing.Point(12, 3);
            this.monthCalendar3.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar3.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar3.Month.BackgroundImage = null;
            this.monthCalendar3.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar3.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.SelectTrailingDates = false;
            this.monthCalendar3.ShowTrailingDates = false;
            this.monthCalendar3.Size = new System.Drawing.Size(233, 166);
            this.monthCalendar3.TabIndex = 1;
            this.monthCalendar3.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar3.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar3.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar1_DayClick);
            this.monthCalendar3.DayDoubleClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar1_DayDoubleClick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ActiveMonth.Month = 2;
            this.monthCalendar1.ActiveMonth.Year = 2017;
            this.monthCalendar1.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar1.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Footer.ShowToday = false;
            this.monthCalendar1.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar1.Header.MonthSelectors = false;
            this.monthCalendar1.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar1.ImageList = this.imageList1;
            this.monthCalendar1.Location = new System.Drawing.Point(242, 3);
            this.monthCalendar1.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar1.Month.BackgroundImage = null;
            this.monthCalendar1.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectTrailingDates = false;
            this.monthCalendar1.ShowTrailingDates = false;
            this.monthCalendar1.Size = new System.Drawing.Size(233, 166);
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar1.DayClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar1_DayClick);
            this.monthCalendar1.DayDoubleClick += new Pabo.Calendar.DayClickEventHandler(this.monthCalendar1_DayDoubleClick);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.ActiveMonth.Month = 3;
            this.monthCalendar2.ActiveMonth.Year = 2017;
            this.monthCalendar2.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar2.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar2.Footer.ShowToday = false;
            this.monthCalendar2.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar2.Header.MonthSelectors = false;
            this.monthCalendar2.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar2.ImageList = null;
            this.monthCalendar2.Location = new System.Drawing.Point(471, 3);
            this.monthCalendar2.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar2.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar2.Month.BackgroundImage = null;
            this.monthCalendar2.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.SelectTrailingDates = false;
            this.monthCalendar2.ShowTrailingDates = false;
            this.monthCalendar2.Size = new System.Drawing.Size(233, 166);
            this.monthCalendar2.TabIndex = 3;
            this.monthCalendar2.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar4
            // 
            this.monthCalendar4.ActiveMonth.Month = 4;
            this.monthCalendar4.ActiveMonth.Year = 2017;
            this.monthCalendar4.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar4.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar4.Footer.ShowToday = false;
            this.monthCalendar4.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar4.Header.MonthSelectors = false;
            this.monthCalendar4.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar4.ImageList = null;
            this.monthCalendar4.Location = new System.Drawing.Point(703, 3);
            this.monthCalendar4.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar4.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar4.Month.BackgroundImage = null;
            this.monthCalendar4.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar4.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar4.Name = "monthCalendar4";
            this.monthCalendar4.SelectTrailingDates = false;
            this.monthCalendar4.ShowTrailingDates = false;
            this.monthCalendar4.Size = new System.Drawing.Size(233, 166);
            this.monthCalendar4.TabIndex = 4;
            this.monthCalendar4.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar4.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar5
            // 
            this.monthCalendar5.ActiveMonth.Month = 6;
            this.monthCalendar5.ActiveMonth.Year = 2017;
            this.monthCalendar5.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar5.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar5.Footer.ShowToday = false;
            this.monthCalendar5.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar5.Header.MonthSelectors = false;
            this.monthCalendar5.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar5.ImageList = null;
            this.monthCalendar5.Location = new System.Drawing.Point(703, 158);
            this.monthCalendar5.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar5.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar5.Month.BackgroundImage = null;
            this.monthCalendar5.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar5.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar5.Name = "monthCalendar5";
            this.monthCalendar5.SelectTrailingDates = false;
            this.monthCalendar5.ShowTrailingDates = false;
            this.monthCalendar5.Size = new System.Drawing.Size(233, 171);
            this.monthCalendar5.TabIndex = 8;
            this.monthCalendar5.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar5.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar6
            // 
            this.monthCalendar6.ActiveMonth.Month = 6;
            this.monthCalendar6.ActiveMonth.Year = 2017;
            this.monthCalendar6.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar6.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar6.Footer.ShowToday = false;
            this.monthCalendar6.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar6.Header.MonthSelectors = false;
            this.monthCalendar6.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar6.ImageList = null;
            this.monthCalendar6.Location = new System.Drawing.Point(471, 158);
            this.monthCalendar6.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar6.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar6.Month.BackgroundImage = null;
            this.monthCalendar6.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar6.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar6.Name = "monthCalendar6";
            this.monthCalendar6.SelectTrailingDates = false;
            this.monthCalendar6.ShowTrailingDates = false;
            this.monthCalendar6.Size = new System.Drawing.Size(233, 171);
            this.monthCalendar6.TabIndex = 7;
            this.monthCalendar6.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar6.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar7
            // 
            this.monthCalendar7.ActiveMonth.Month = 6;
            this.monthCalendar7.ActiveMonth.Year = 2017;
            this.monthCalendar7.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar7.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar7.Footer.ShowToday = false;
            this.monthCalendar7.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar7.Header.MonthSelectors = false;
            this.monthCalendar7.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar7.ImageList = null;
            this.monthCalendar7.Location = new System.Drawing.Point(242, 158);
            this.monthCalendar7.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar7.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar7.Month.BackgroundImage = null;
            this.monthCalendar7.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar7.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar7.Name = "monthCalendar7";
            this.monthCalendar7.SelectTrailingDates = false;
            this.monthCalendar7.ShowTrailingDates = false;
            this.monthCalendar7.Size = new System.Drawing.Size(233, 171);
            this.monthCalendar7.TabIndex = 6;
            this.monthCalendar7.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar7.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar8
            // 
            this.monthCalendar8.ActiveMonth.Month = 6;
            this.monthCalendar8.ActiveMonth.Year = 2017;
            this.monthCalendar8.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar8.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar8.Footer.ShowToday = false;
            this.monthCalendar8.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar8.Header.MonthSelectors = false;
            this.monthCalendar8.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar8.ImageList = null;
            this.monthCalendar8.Location = new System.Drawing.Point(12, 158);
            this.monthCalendar8.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar8.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar8.Month.BackgroundImage = null;
            this.monthCalendar8.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar8.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar8.Name = "monthCalendar8";
            this.monthCalendar8.SelectTrailingDates = false;
            this.monthCalendar8.ShowTrailingDates = false;
            this.monthCalendar8.Size = new System.Drawing.Size(233, 171);
            this.monthCalendar8.TabIndex = 5;
            this.monthCalendar8.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar8.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar9
            // 
            this.monthCalendar9.ActiveMonth.Month = 6;
            this.monthCalendar9.ActiveMonth.Year = 2017;
            this.monthCalendar9.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar9.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar9.Footer.ShowToday = false;
            this.monthCalendar9.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar9.Header.MonthSelectors = false;
            this.monthCalendar9.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar9.ImageList = null;
            this.monthCalendar9.Location = new System.Drawing.Point(703, 319);
            this.monthCalendar9.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar9.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar9.Month.BackgroundImage = null;
            this.monthCalendar9.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar9.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar9.Name = "monthCalendar9";
            this.monthCalendar9.SelectTrailingDates = false;
            this.monthCalendar9.ShowTrailingDates = false;
            this.monthCalendar9.Size = new System.Drawing.Size(233, 156);
            this.monthCalendar9.TabIndex = 12;
            this.monthCalendar9.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar9.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar10
            // 
            this.monthCalendar10.ActiveMonth.Month = 6;
            this.monthCalendar10.ActiveMonth.Year = 2017;
            this.monthCalendar10.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar10.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar10.Footer.ShowToday = false;
            this.monthCalendar10.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar10.Header.MonthSelectors = false;
            this.monthCalendar10.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar10.ImageList = null;
            this.monthCalendar10.Location = new System.Drawing.Point(471, 319);
            this.monthCalendar10.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar10.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar10.Month.BackgroundImage = null;
            this.monthCalendar10.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar10.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar10.Name = "monthCalendar10";
            this.monthCalendar10.SelectTrailingDates = false;
            this.monthCalendar10.ShowTrailingDates = false;
            this.monthCalendar10.Size = new System.Drawing.Size(233, 156);
            this.monthCalendar10.TabIndex = 11;
            this.monthCalendar10.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar10.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar11
            // 
            this.monthCalendar11.ActiveMonth.Month = 6;
            this.monthCalendar11.ActiveMonth.Year = 2017;
            this.monthCalendar11.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar11.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar11.Footer.ShowToday = false;
            this.monthCalendar11.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar11.Header.MonthSelectors = false;
            this.monthCalendar11.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar11.ImageList = null;
            this.monthCalendar11.Location = new System.Drawing.Point(242, 319);
            this.monthCalendar11.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar11.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar11.Month.BackgroundImage = null;
            this.monthCalendar11.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar11.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar11.Name = "monthCalendar11";
            this.monthCalendar11.SelectTrailingDates = false;
            this.monthCalendar11.ShowTrailingDates = false;
            this.monthCalendar11.Size = new System.Drawing.Size(233, 156);
            this.monthCalendar11.TabIndex = 10;
            this.monthCalendar11.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar11.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // monthCalendar12
            // 
            this.monthCalendar12.ActiveMonth.Month = 6;
            this.monthCalendar12.ActiveMonth.Year = 2017;
            this.monthCalendar12.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.monthCalendar12.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar12.Footer.ShowToday = false;
            this.monthCalendar12.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar12.Header.MonthSelectors = false;
            this.monthCalendar12.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar12.ImageList = null;
            this.monthCalendar12.Location = new System.Drawing.Point(12, 319);
            this.monthCalendar12.MaxDate = new System.DateTime(2027, 6, 30, 0, 0, 0, 0);
            this.monthCalendar12.MinDate = new System.DateTime(2007, 6, 1, 0, 0, 0, 0);
            this.monthCalendar12.Month.BackgroundImage = null;
            this.monthCalendar12.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar12.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar12.Name = "monthCalendar12";
            this.monthCalendar12.SelectTrailingDates = false;
            this.monthCalendar12.ShowTrailingDates = false;
            this.monthCalendar12.Size = new System.Drawing.Size(233, 156);
            this.monthCalendar12.TabIndex = 9;
            this.monthCalendar12.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar12.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 512);
            this.Controls.Add(this.monthCalendar9);
            this.Controls.Add(this.monthCalendar10);
            this.Controls.Add(this.monthCalendar11);
            this.Controls.Add(this.monthCalendar12);
            this.Controls.Add(this.monthCalendar5);
            this.Controls.Add(this.monthCalendar6);
            this.Controls.Add(this.monthCalendar7);
            this.Controls.Add(this.monthCalendar8);
            this.Controls.Add(this.monthCalendar4);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.monthCalendar3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Pabo.Calendar.DateItem dateItem1;
        private System.Windows.Forms.ImageList imageList1;
        private Pabo.Calendar.MonthCalendar monthCalendar3;
        private Pabo.Calendar.MonthCalendar monthCalendar1;
        private Pabo.Calendar.MonthCalendar monthCalendar2;
        private Pabo.Calendar.MonthCalendar monthCalendar4;
        private Pabo.Calendar.MonthCalendar monthCalendar5;
        private Pabo.Calendar.MonthCalendar monthCalendar6;
        private Pabo.Calendar.MonthCalendar monthCalendar7;
        private Pabo.Calendar.MonthCalendar monthCalendar8;
        private Pabo.Calendar.MonthCalendar monthCalendar9;
        private Pabo.Calendar.MonthCalendar monthCalendar10;
        private Pabo.Calendar.MonthCalendar monthCalendar11;
        private Pabo.Calendar.MonthCalendar monthCalendar12;
    }
}

