using DirApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirApp
{
    public partial class Form1 : Form
    {
        private List<TreeListModel> _directoryList = new List<TreeListModel>();
        public Form1()
        {
            InitializeComponent();

            treeList.KeyFieldName = nameof(TreeListModel.Id);
            treeList.ParentFieldName = nameof(TreeListModel.ParentId);

            columnId.FieldName = nameof(TreeListModel.Id);
            columnName.FieldName = nameof(TreeListModel.Name);
            columnType.FieldName = nameof(TreeListModel.Type);
            columnParentId.FieldName = nameof(TreeListModel.ParentId);
            columnPath.FieldName = nameof(TreeListModel.Path);
        }

        private List<TreeListModel> GetRecursFiles(string start_path, Guid parentId)
        {
            var ls = new List<TreeListModel>();
            try
            {
                var folders = Directory.GetDirectories(start_path);
                foreach (var folder in folders)
                {
                    var infoDir = new DirectoryInfo(folder);

                    var folderId = Guid.NewGuid();

                    ls.Add(new TreeListModel()
                    {
                        Id = folderId,
                        Name = infoDir.Name,
                        Path = infoDir.FullName,
                        Type = "Папка",
                        ParentId = parentId
                    });
                    ls.AddRange(GetRecursFiles(folder, folderId));
                }

                string[] files = Directory.GetFiles(start_path);
                foreach (string filename in files)
                {
                    var infoFile = new DirectoryInfo(filename);

                    ls.Add(new TreeListModel()
                    {
                        Id = Guid.NewGuid(),
                        Name = infoFile.Name,
                        Path = infoFile.FullName,
                        Type = "Файл",
                        ParentId = parentId
                    });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ls;
        }

        private async void showBtn_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            if (Directory.Exists(path))
            {
                _directoryList = await Task.Run(() => GetRecursFiles(path, Guid.NewGuid()));

                treeList.DataSource = _directoryList;
            }

        }

        private void treeList_DoubleClick(object sender, EventArgs e)
        {
            var row = treeList.FocusedNode;

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = treeList.FocusedNode.GetValue(columnId);
        }
    }
}
