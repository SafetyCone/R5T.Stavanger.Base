using System;


namespace R5T.Stavanger
{
    public interface IShortcutOperator
    {
        string GetShortcutTargetPath(string shortcutFilePath);
        void CreateShortcut(string shortcutFilePath, string shortcutTargetPath);
    }
}
