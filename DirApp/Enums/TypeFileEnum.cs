using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirApp.Enums
{
    public class TypeFileEnum
    {
        private const string Directory = "Папка/Directory";
        private const string Archive = "Архив/Archive";
        private const string Image = "Картинка/Image";
        private const string Application = "Приложение/Application";
        private const string Label = "Ярлык/Label";
        private const string AndroidAPK = "Андройд приложение/Application Android";
        private const string File = "Файл/File";
        private const string Icon = "Иконка/Icon";
        private const string Libraries = "Библиотека/Libraries";
        private const string DataBase = "База данных/DataBase";        
        private const string CSharp = "C#";
        private const string CPlusPlus = "C++";
        private const string Java = "Java";
        private const string Python = "Python";
        private const string PHP = "PHP";
        private const string UML = "UML";
        private const string SQL = "SQL";
        private const string HTML = "HTML";
        private const string CSS = "CSS";
        private const string Pascal = "Pascal";
        private const string Delphi = "Delphi";
        private const string JavaScript = "JavaScript";
        private const string FileXML = "Файл XML";
        private const string NoteBook = "Блокнот/NoteBook";
        private const string Word = "Word";
        private const string Music = "Музыка/Music";
        private const string Video = "Видео/Video";
        private const string AdobePdf = "Adobe PDF";
        private const string PowerPoint = "Power Point";
        private const string Excel = "Excel";
        private const string Blender = "Blender";
        private const string VS = "Visual Studio";
        private const string Max3D = "3D Max";


        public string GetMimeType(string type)
        {
            switch (type)
            {
                case ".exe":
                    return Application;
                case ".apk":
                    return AndroidAPK;
                case ".lnk":
                    return Label;
                case ".zip":
                    return Archive;
                case ".rar":
                    return Archive;
                case ".7z":
                    return Archive;
                case ".jpeg":
                    return Image;
                case ".jpg":
                    return Image;
                case ".JPG":
                    return Image;
                case ".raw":
                    return Image;
                case ".png":
                    return Image;
                case ".ifif":
                    return Image;
                case ".ico":
                    return Icon;
                case "":
                    return Directory;
                case ".dll":
                    return Libraries;
                case ".ldf":
                    return DataBase;
                case ".mdf":
                    return DataBase;
                case ".cs":
                    return CSharp;
                case ".cpp":
                    return CPlusPlus;
                case ".java":
                    return Java;
                case ".py":
                    return Python;
                case ".p":
                    return Pascal;
                case ".dpr":
                    return Delphi;
                case ".uml":
                    return UML;
                case ".php":
                    return PHP;
                case ".sql":
                    return SQL;
                case ".html":
                    return HTML;
                case ".css":
                    return CSS;
                case ".js":
                    return JavaScript;
                case ".txt":
                    return NoteBook;
                case ".xml":
                    return FileXML;
                case ".pdf":
                    return AdobePdf;
                case ".doc":
                    return Word;
                case ".docx":
                    return Word;
                case ".rtf":
                    return Word;
                case ".xlsx":
                    return Excel;
                case ".pptx":
                    return PowerPoint;
                case ".mp3":
                    return Music;
                case ".mp4":
                    return Video;
                case ".MP4":
                    return Video;
                case ".avi":
                    return Video;
                case ".MOV":
                    return Video;
                case ".mov":
                    return Video;
                case ".sln":
                    return VS;
                case ".vs":
                    return VS;
                case ".blend":
                    return Blender;
                case ".max":
                    return Max3D;
                default:
                    return File;
            }
        }
    }
}
