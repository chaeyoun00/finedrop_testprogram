
namespace FineDropTestProgram
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HOST = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.FNTabControl = new System.Windows.Forms.TabControl();
            this.FD = new System.Windows.Forms.TabPage();
            this.FDInterval = new System.Windows.Forms.Label();
            this.FDCount = new System.Windows.Forms.Label();
            this.FDBattery = new System.Windows.Forms.Label();
            this.FDStartAt = new System.Windows.Forms.Label();
            this.FDSerial = new System.Windows.Forms.Label();
            this.FDTitle = new System.Windows.Forms.Label();
            this.FDListView = new System.Windows.Forms.ListView();
            this.FDCheckBox = new System.Windows.Forms.CheckBox();
            this.FDpanel = new System.Windows.Forms.Panel();
            this.FDradioBattery3 = new System.Windows.Forms.RadioButton();
            this.FDradioBattery2 = new System.Windows.Forms.RadioButton();
            this.FDradioBattery1 = new System.Windows.Forms.RadioButton();
            this.FDradioBattery0 = new System.Windows.Forms.RadioButton();
            this.FDIntervalBar = new System.Windows.Forms.TrackBar();
            this.FDStartAtBox = new System.Windows.Forms.TextBox();
            this.FDCountBox = new System.Windows.Forms.TextBox();
            this.FDIntervalValueBox = new System.Windows.Forms.TextBox();
            this.FDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FDOff = new System.Windows.Forms.Button();
            this.FDOn = new System.Windows.Forms.Button();
            this.FDEditButton = new System.Windows.Forms.Button();
            this.FDCreateButton = new System.Windows.Forms.Button();
            this.FDBlock = new System.Windows.Forms.Button();
            this.FDFullDrop = new System.Windows.Forms.Button();
            this.FDRandomButton = new System.Windows.Forms.Button();
            this.FDSerialBox = new System.Windows.Forms.TextBox();
            this.FU = new System.Windows.Forms.TabPage();
            this.FT = new System.Windows.Forms.TabPage();
            this.Connect = new System.Windows.Forms.Button();
            this.TimerStartAt = new System.Windows.Forms.Timer(this.components);
            this.HostLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PWLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FNTabControl.SuspendLayout();
            this.FD.SuspendLayout();
            this.FDpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FDIntervalBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // HOST
            // 
            this.HOST.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HOST.Location = new System.Drawing.Point(268, 48);
            this.HOST.Margin = new System.Windows.Forms.Padding(4);
            this.HOST.Name = "HOST";
            this.HOST.Size = new System.Drawing.Size(127, 27);
            this.HOST.TabIndex = 0;
            this.HOST.Text = "192.168.50.100";
            // 
            // PORT
            // 
            this.PORT.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PORT.Location = new System.Drawing.Point(528, 48);
            this.PORT.Margin = new System.Windows.Forms.Padding(4);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(127, 27);
            this.PORT.TabIndex = 1;
            this.PORT.Text = "1883";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID.Location = new System.Drawing.Point(268, 87);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(127, 27);
            this.ID.TabIndex = 2;
            // 
            // PW
            // 
            this.PW.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW.Location = new System.Drawing.Point(528, 87);
            this.PW.Margin = new System.Windows.Forms.Padding(4);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(127, 27);
            this.PW.TabIndex = 3;
            // 
            // FNTabControl
            // 
            this.FNTabControl.Controls.Add(this.FD);
            this.FNTabControl.Controls.Add(this.FU);
            this.FNTabControl.Controls.Add(this.FT);
            this.FNTabControl.ItemSize = new System.Drawing.Size(54, 25);
            this.FNTabControl.Location = new System.Drawing.Point(12, 145);
            this.FNTabControl.Name = "FNTabControl";
            this.FNTabControl.SelectedIndex = 0;
            this.FNTabControl.Size = new System.Drawing.Size(912, 515);
            this.FNTabControl.TabIndex = 4;
            // 
            // FD
            // 
            this.FD.BackColor = System.Drawing.SystemColors.Control;
            this.FD.Controls.Add(this.FDInterval);
            this.FD.Controls.Add(this.FDCount);
            this.FD.Controls.Add(this.FDBattery);
            this.FD.Controls.Add(this.FDStartAt);
            this.FD.Controls.Add(this.FDSerial);
            this.FD.Controls.Add(this.FDTitle);
            this.FD.Controls.Add(this.FDListView);
            this.FD.Controls.Add(this.FDCheckBox);
            this.FD.Controls.Add(this.FDpanel);
            this.FD.Controls.Add(this.FDIntervalBar);
            this.FD.Controls.Add(this.FDStartAtBox);
            this.FD.Controls.Add(this.FDCountBox);
            this.FD.Controls.Add(this.FDIntervalValueBox);
            this.FD.Controls.Add(this.FDnumericUpDown);
            this.FD.Controls.Add(this.FDOff);
            this.FD.Controls.Add(this.FDOn);
            this.FD.Controls.Add(this.FDEditButton);
            this.FD.Controls.Add(this.FDCreateButton);
            this.FD.Controls.Add(this.FDBlock);
            this.FD.Controls.Add(this.FDFullDrop);
            this.FD.Controls.Add(this.FDRandomButton);
            this.FD.Controls.Add(this.FDSerialBox);
            this.FD.Location = new System.Drawing.Point(4, 29);
            this.FD.Name = "FD";
            this.FD.Padding = new System.Windows.Forms.Padding(3);
            this.FD.Size = new System.Drawing.Size(904, 482);
            this.FD.TabIndex = 0;
            this.FD.Text = "FD";
            // 
            // FDInterval
            // 
            this.FDInterval.AutoSize = true;
            this.FDInterval.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDInterval.Location = new System.Drawing.Point(12, 192);
            this.FDInterval.Name = "FDInterval";
            this.FDInterval.Size = new System.Drawing.Size(94, 32);
            this.FDInterval.TabIndex = 22;
            this.FDInterval.Text = "Interval";
            // 
            // FDCount
            // 
            this.FDCount.AutoSize = true;
            this.FDCount.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDCount.Location = new System.Drawing.Point(14, 264);
            this.FDCount.Name = "FDCount";
            this.FDCount.Size = new System.Drawing.Size(80, 32);
            this.FDCount.TabIndex = 21;
            this.FDCount.Text = "Count";
            // 
            // FDBattery
            // 
            this.FDBattery.AutoSize = true;
            this.FDBattery.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDBattery.Location = new System.Drawing.Point(12, 312);
            this.FDBattery.Name = "FDBattery";
            this.FDBattery.Size = new System.Drawing.Size(90, 32);
            this.FDBattery.TabIndex = 20;
            this.FDBattery.Text = "Battery";
            // 
            // FDStartAt
            // 
            this.FDStartAt.AutoSize = true;
            this.FDStartAt.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDStartAt.Location = new System.Drawing.Point(12, 360);
            this.FDStartAt.Name = "FDStartAt";
            this.FDStartAt.Size = new System.Drawing.Size(88, 32);
            this.FDStartAt.TabIndex = 19;
            this.FDStartAt.Text = "StartAt";
            // 
            // FDSerial
            // 
            this.FDSerial.AutoSize = true;
            this.FDSerial.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDSerial.Location = new System.Drawing.Point(12, 108);
            this.FDSerial.Name = "FDSerial";
            this.FDSerial.Size = new System.Drawing.Size(73, 32);
            this.FDSerial.TabIndex = 18;
            this.FDSerial.Text = "Serial";
            // 
            // FDTitle
            // 
            this.FDTitle.AutoSize = true;
            this.FDTitle.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDTitle.Location = new System.Drawing.Point(12, 12);
            this.FDTitle.Name = "FDTitle";
            this.FDTitle.Size = new System.Drawing.Size(197, 54);
            this.FDTitle.TabIndex = 9;
            this.FDTitle.Text = "FineDrop";
            // 
            // FDListView
            // 
            this.FDListView.CheckBoxes = true;
            this.FDListView.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDListView.HideSelection = false;
            this.FDListView.Location = new System.Drawing.Point(636, 48);
            this.FDListView.Name = "FDListView";
            this.FDListView.Size = new System.Drawing.Size(252, 360);
            this.FDListView.TabIndex = 17;
            this.FDListView.UseCompatibleStateImageBehavior = false;
            this.FDListView.View = System.Windows.Forms.View.List;
            this.FDListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.FDListView_ItemChecked);
            this.FDListView.SelectedIndexChanged += new System.EventHandler(this.FDListView_SelectedIndexChanged);
            // 
            // FDCheckBox
            // 
            this.FDCheckBox.AutoSize = true;
            this.FDCheckBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDCheckBox.Location = new System.Drawing.Point(636, 24);
            this.FDCheckBox.Name = "FDCheckBox";
            this.FDCheckBox.Size = new System.Drawing.Size(91, 24);
            this.FDCheckBox.TabIndex = 4;
            this.FDCheckBox.Text = "전체선택";
            this.FDCheckBox.UseVisualStyleBackColor = true;
            this.FDCheckBox.CheckedChanged += new System.EventHandler(this.FDCheckBox_CheckedChanged);
            // 
            // FDpanel
            // 
            this.FDpanel.Controls.Add(this.FDradioBattery3);
            this.FDpanel.Controls.Add(this.FDradioBattery2);
            this.FDpanel.Controls.Add(this.FDradioBattery1);
            this.FDpanel.Controls.Add(this.FDradioBattery0);
            this.FDpanel.Location = new System.Drawing.Point(120, 312);
            this.FDpanel.Margin = new System.Windows.Forms.Padding(4);
            this.FDpanel.Name = "FDpanel";
            this.FDpanel.Size = new System.Drawing.Size(266, 32);
            this.FDpanel.TabIndex = 16;
            // 
            // FDradioBattery3
            // 
            this.FDradioBattery3.AutoSize = true;
            this.FDradioBattery3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDradioBattery3.Location = new System.Drawing.Point(170, 3);
            this.FDradioBattery3.Margin = new System.Windows.Forms.Padding(4);
            this.FDradioBattery3.Name = "FDradioBattery3";
            this.FDradioBattery3.Size = new System.Drawing.Size(38, 24);
            this.FDradioBattery3.TabIndex = 3;
            this.FDradioBattery3.TabStop = true;
            this.FDradioBattery3.Text = "3";
            this.FDradioBattery3.UseVisualStyleBackColor = true;
            // 
            // FDradioBattery2
            // 
            this.FDradioBattery2.AutoSize = true;
            this.FDradioBattery2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDradioBattery2.Location = new System.Drawing.Point(114, 3);
            this.FDradioBattery2.Margin = new System.Windows.Forms.Padding(4);
            this.FDradioBattery2.Name = "FDradioBattery2";
            this.FDradioBattery2.Size = new System.Drawing.Size(38, 24);
            this.FDradioBattery2.TabIndex = 2;
            this.FDradioBattery2.TabStop = true;
            this.FDradioBattery2.Text = "2";
            this.FDradioBattery2.UseVisualStyleBackColor = true;
            // 
            // FDradioBattery1
            // 
            this.FDradioBattery1.AutoSize = true;
            this.FDradioBattery1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDradioBattery1.Location = new System.Drawing.Point(59, 3);
            this.FDradioBattery1.Margin = new System.Windows.Forms.Padding(4);
            this.FDradioBattery1.Name = "FDradioBattery1";
            this.FDradioBattery1.Size = new System.Drawing.Size(38, 24);
            this.FDradioBattery1.TabIndex = 1;
            this.FDradioBattery1.TabStop = true;
            this.FDradioBattery1.Text = "1";
            this.FDradioBattery1.UseVisualStyleBackColor = true;
            // 
            // FDradioBattery0
            // 
            this.FDradioBattery0.AutoSize = true;
            this.FDradioBattery0.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDradioBattery0.Location = new System.Drawing.Point(4, 3);
            this.FDradioBattery0.Margin = new System.Windows.Forms.Padding(4);
            this.FDradioBattery0.Name = "FDradioBattery0";
            this.FDradioBattery0.Size = new System.Drawing.Size(38, 24);
            this.FDradioBattery0.TabIndex = 0;
            this.FDradioBattery0.TabStop = true;
            this.FDradioBattery0.Text = "0";
            this.FDradioBattery0.UseVisualStyleBackColor = true;
            // 
            // FDIntervalBar
            // 
            this.FDIntervalBar.Location = new System.Drawing.Point(118, 188);
            this.FDIntervalBar.Margin = new System.Windows.Forms.Padding(4);
            this.FDIntervalBar.Maximum = 65536;
            this.FDIntervalBar.Name = "FDIntervalBar";
            this.FDIntervalBar.Size = new System.Drawing.Size(134, 56);
            this.FDIntervalBar.TabIndex = 5;
            this.FDIntervalBar.Scroll += new System.EventHandler(this.FDIntervalBar_Scroll);
            // 
            // FDStartAtBox
            // 
            this.FDStartAtBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDStartAtBox.Location = new System.Drawing.Point(120, 360);
            this.FDStartAtBox.Margin = new System.Windows.Forms.Padding(4);
            this.FDStartAtBox.Name = "FDStartAtBox";
            this.FDStartAtBox.ReadOnly = true;
            this.FDStartAtBox.Size = new System.Drawing.Size(265, 27);
            this.FDStartAtBox.TabIndex = 15;
            // 
            // FDCountBox
            // 
            this.FDCountBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDCountBox.Location = new System.Drawing.Point(120, 264);
            this.FDCountBox.Margin = new System.Windows.Forms.Padding(4);
            this.FDCountBox.Name = "FDCountBox";
            this.FDCountBox.ReadOnly = true;
            this.FDCountBox.Size = new System.Drawing.Size(132, 27);
            this.FDCountBox.TabIndex = 14;
            // 
            // FDIntervalValueBox
            // 
            this.FDIntervalValueBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDIntervalValueBox.Location = new System.Drawing.Point(288, 194);
            this.FDIntervalValueBox.Margin = new System.Windows.Forms.Padding(4);
            this.FDIntervalValueBox.Name = "FDIntervalValueBox";
            this.FDIntervalValueBox.ReadOnly = true;
            this.FDIntervalValueBox.Size = new System.Drawing.Size(96, 27);
            this.FDIntervalValueBox.TabIndex = 13;
            // 
            // FDnumericUpDown
            // 
            this.FDnumericUpDown.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDnumericUpDown.Location = new System.Drawing.Point(120, 144);
            this.FDnumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.FDnumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FDnumericUpDown.Name = "FDnumericUpDown";
            this.FDnumericUpDown.Size = new System.Drawing.Size(132, 27);
            this.FDnumericUpDown.TabIndex = 12;
            // 
            // FDOff
            // 
            this.FDOff.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDOff.Location = new System.Drawing.Point(768, 420);
            this.FDOff.Name = "FDOff";
            this.FDOff.Size = new System.Drawing.Size(120, 35);
            this.FDOff.TabIndex = 11;
            this.FDOff.Text = "OFF";
            this.FDOff.UseVisualStyleBackColor = true;
            this.FDOff.Click += new System.EventHandler(this.FDOff_Click);
            // 
            // FDOn
            // 
            this.FDOn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDOn.Location = new System.Drawing.Point(636, 420);
            this.FDOn.Name = "FDOn";
            this.FDOn.Size = new System.Drawing.Size(120, 35);
            this.FDOn.TabIndex = 10;
            this.FDOn.Text = "ON";
            this.FDOn.UseVisualStyleBackColor = true;
            this.FDOn.Click += new System.EventHandler(this.FDOn_Click);
            // 
            // FDEditButton
            // 
            this.FDEditButton.Enabled = false;
            this.FDEditButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDEditButton.Location = new System.Drawing.Point(252, 420);
            this.FDEditButton.Name = "FDEditButton";
            this.FDEditButton.Size = new System.Drawing.Size(129, 35);
            this.FDEditButton.TabIndex = 9;
            this.FDEditButton.Text = "EDIT";
            this.FDEditButton.UseVisualStyleBackColor = true;
            this.FDEditButton.Click += new System.EventHandler(this.FDEditButton_Click);
            // 
            // FDCreateButton
            // 
            this.FDCreateButton.Enabled = false;
            this.FDCreateButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDCreateButton.Location = new System.Drawing.Point(120, 420);
            this.FDCreateButton.Name = "FDCreateButton";
            this.FDCreateButton.Size = new System.Drawing.Size(129, 35);
            this.FDCreateButton.TabIndex = 8;
            this.FDCreateButton.Text = "CREATE";
            this.FDCreateButton.UseVisualStyleBackColor = true;
            this.FDCreateButton.Click += new System.EventHandler(this.FDCreateButton_Click);
            // 
            // FDBlock
            // 
            this.FDBlock.Enabled = false;
            this.FDBlock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDBlock.Location = new System.Drawing.Point(396, 228);
            this.FDBlock.Name = "FDBlock";
            this.FDBlock.Size = new System.Drawing.Size(96, 31);
            this.FDBlock.TabIndex = 7;
            this.FDBlock.Text = "Block";
            this.FDBlock.UseVisualStyleBackColor = true;
            this.FDBlock.Click += new System.EventHandler(this.FDBlock_Click);
            // 
            // FDFullDrop
            // 
            this.FDFullDrop.Enabled = false;
            this.FDFullDrop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDFullDrop.Location = new System.Drawing.Point(396, 192);
            this.FDFullDrop.Name = "FDFullDrop";
            this.FDFullDrop.Size = new System.Drawing.Size(96, 31);
            this.FDFullDrop.TabIndex = 6;
            this.FDFullDrop.Text = "Full Drop";
            this.FDFullDrop.UseVisualStyleBackColor = true;
            this.FDFullDrop.Click += new System.EventHandler(this.FDFullDrop_Click);
            // 
            // FDRandomButton
            // 
            this.FDRandomButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDRandomButton.Location = new System.Drawing.Point(288, 108);
            this.FDRandomButton.Name = "FDRandomButton";
            this.FDRandomButton.Size = new System.Drawing.Size(96, 31);
            this.FDRandomButton.TabIndex = 5;
            this.FDRandomButton.Text = "random";
            this.FDRandomButton.UseVisualStyleBackColor = true;
            this.FDRandomButton.Click += new System.EventHandler(this.FDRandomButton_Click);
            // 
            // FDSerialBox
            // 
            this.FDSerialBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FDSerialBox.Location = new System.Drawing.Point(120, 108);
            this.FDSerialBox.Margin = new System.Windows.Forms.Padding(4);
            this.FDSerialBox.Name = "FDSerialBox";
            this.FDSerialBox.Size = new System.Drawing.Size(132, 27);
            this.FDSerialBox.TabIndex = 3;
            // 
            // FU
            // 
            this.FU.BackColor = System.Drawing.SystemColors.Control;
            this.FU.Location = new System.Drawing.Point(4, 29);
            this.FU.Name = "FU";
            this.FU.Padding = new System.Windows.Forms.Padding(3);
            this.FU.Size = new System.Drawing.Size(904, 482);
            this.FU.TabIndex = 1;
            this.FU.Text = "FU";
            // 
            // FT
            // 
            this.FT.BackColor = System.Drawing.SystemColors.Control;
            this.FT.Location = new System.Drawing.Point(4, 29);
            this.FT.Name = "FT";
            this.FT.Size = new System.Drawing.Size(904, 482);
            this.FT.TabIndex = 2;
            this.FT.Text = "FT";
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Connect.Location = new System.Drawing.Point(746, 66);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(96, 31);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TimerStartAt
            // 
            this.TimerStartAt.Interval = 1000;
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HostLabel.Location = new System.Drawing.Point(174, 52);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(48, 20);
            this.HostLabel.TabIndex = 5;
            this.HostLabel.Text = "HOST";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PortLabel.Location = new System.Drawing.Point(436, 52);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(47, 20);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "PORT";
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PWLabel.Location = new System.Drawing.Point(436, 91);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(32, 20);
            this.PWLabel.TabIndex = 7;
            this.PWLabel.Text = "PW";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDLabel.Location = new System.Drawing.Point(174, 91);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 20);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 674);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.PWLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.HostLabel);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.FNTabControl);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.HOST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.FNTabControl.ResumeLayout(false);
            this.FD.ResumeLayout(false);
            this.FD.PerformLayout();
            this.FDpanel.ResumeLayout(false);
            this.FDpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FDIntervalBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HOST;
        private System.Windows.Forms.TextBox PORT;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.TabControl FNTabControl;
        private System.Windows.Forms.TabPage FD;
        private System.Windows.Forms.Button FDRandomButton;
        private System.Windows.Forms.TextBox FDSerialBox;
        private System.Windows.Forms.TabPage FU;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button FDOff;
        private System.Windows.Forms.Button FDOn;
        private System.Windows.Forms.Button FDEditButton;
        private System.Windows.Forms.Button FDCreateButton;
        private System.Windows.Forms.Button FDBlock;
        private System.Windows.Forms.Button FDFullDrop;
        private System.Windows.Forms.TabPage FT;
        private System.Windows.Forms.TextBox FDStartAtBox;
        private System.Windows.Forms.TextBox FDCountBox;
        private System.Windows.Forms.TextBox FDIntervalValueBox;
        private System.Windows.Forms.NumericUpDown FDnumericUpDown;
        private System.Windows.Forms.Timer TimerStartAt;
        private System.Windows.Forms.ListView FDListView;
        private System.Windows.Forms.CheckBox FDCheckBox;
        private System.Windows.Forms.Panel FDpanel;
        private System.Windows.Forms.RadioButton FDradioBattery3;
        private System.Windows.Forms.RadioButton FDradioBattery2;
        private System.Windows.Forms.RadioButton FDradioBattery1;
        private System.Windows.Forms.RadioButton FDradioBattery0;
        private System.Windows.Forms.TrackBar FDIntervalBar;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label PWLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label FDTitle;
        private System.Windows.Forms.Label FDInterval;
        private System.Windows.Forms.Label FDCount;
        private System.Windows.Forms.Label FDBattery;
        private System.Windows.Forms.Label FDStartAt;
        private System.Windows.Forms.Label FDSerial;
    }
}

