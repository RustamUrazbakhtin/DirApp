
namespace DirApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.columnId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.columnParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(5, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Путь/Path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(96, 6);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(615, 23);
            this.pathTextBox.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.showBtn);
            this.panelControl1.Controls.Add(this.pathTextBox);
            this.panelControl1.Controls.Add(this.label);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(816, 35);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.treeList);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 35);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(816, 726);
            this.panelControl2.TabIndex = 6;
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.columnId,
            this.columnName,
            this.columnType,
            this.columnParentId,
            this.columnPath});
            this.treeList.ContextMenuStrip = this.contextMenuStrip;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(2, 2);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.ReadOnly = true;
            this.treeList.OptionsMenu.EnableColumnMenu = false;
            this.treeList.OptionsMenu.EnableFooterMenu = false;
            this.treeList.OptionsMenu.EnableNodeMenu = false;
            this.treeList.Size = new System.Drawing.Size(812, 722);
            this.treeList.TabIndex = 6;
            this.treeList.DoubleClick += new System.EventHandler(this.treeList_DoubleClick);
            // 
            // columnId
            // 
            this.columnId.Caption = "Id";
            this.columnId.FieldName = "Id";
            this.columnId.Name = "columnId";
            // 
            // columnName
            // 
            this.columnName.Caption = "Наименование";
            this.columnName.FieldName = "Наименование";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 0;
            // 
            // columnType
            // 
            this.columnType.Caption = "Тип";
            this.columnType.FieldName = "Тип";
            this.columnType.Name = "columnType";
            this.columnType.Visible = true;
            this.columnType.VisibleIndex = 1;
            // 
            // showBtn
            // 
            this.showBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showBtn.Location = new System.Drawing.Point(717, 2);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(94, 29);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Просмотр";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // columnParentId
            // 
            this.columnParentId.Caption = "parentId";
            this.columnParentId.FieldName = "parentId";
            this.columnParentId.Name = "columnParentId";
            // 
            // columnPath
            // 
            this.columnPath.Caption = "Путь/Path";
            this.columnPath.FieldName = "Путь/Path";
            this.columnPath.Name = "columnPath";
            this.columnPath.Visible = true;
            this.columnPath.VisibleIndex = 2;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 28);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 761);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Directory";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox pathTextBox;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnType;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    }
}

