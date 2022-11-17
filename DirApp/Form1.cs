using DirApp.Models;
using DirApp.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DirApp
{
    public partial class Form1 : Form
    {
        private TypeFileEnum typeFileEnum = new TypeFileEnum();
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
            сolumnMimeType.FieldName = nameof(TreeListModel.MimeType);
            columnSize.FieldName = nameof(TreeListModel.SizeFile);
            columnCreateDate.FieldName = nameof(TreeListModel.CreateDate);
        }

       

        public static double DirSize(DirectoryInfo d)
        {
            double Size = 0;

            var fis = d.GetFiles();

            foreach (FileInfo fi in fis)
            {
                try
                {
                    Size += fi.Length;
                }

                catch (UnauthorizedAccessException)
                {
                    ;
                }
            }
            
            var dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                try
                {
                    Size += DirSize(di);
                }
                catch (UnauthorizedAccessException)
                {
                    ;
                }
            }
            return (Size);
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
                        Type = typeFileEnum.GetMimeType(infoDir.Extension),
                        ParentId = parentId,
                        SizeFile = Math.Round((double)DirSize(infoDir), 3) / 1024 / 1024 + " МБ",
                        MimeType = infoDir.Extension,
                        CreateDate = infoDir.CreationTime
                    }) ;

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
                        Type = typeFileEnum.GetMimeType(infoFile.Extension),
                        ParentId = parentId,
                        SizeFile = Math.Round((double)new FileInfo(infoFile.FullName).Length, 3) / 1024 / 1024 + " МБ",
                        MimeType = infoFile.Extension,
                        CreateDate = infoFile.CreationTime
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
            var mimeTypeFile = treeList.FocusedNode.GetValue(сolumnMimeType);

            if (mimeTypeFile != "")
            {
                var x64 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                var x86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

                var isExecuted = false;
                foreach (var rootPath in new[] { x64, x86 })
                {
                    var path = Path.Combine(rootPath, treeList.FocusedNode.GetValue(columnPath).ToString());
                    if (File.Exists(path))
                    {
                        Process.Start(path);
                        isExecuted = true;
                        break;
                    }
                }

                if (!isExecuted)
                {
                    MessageBox.Show("Ошибка файл не найден \"rc.exe\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
