using System;


namespace R5T.Stavanger
{
    public interface IShortcutOperator
    {
        string GetShortcutTargetPath(string shortcutFilePath);
        /// <summary>
        /// Outputs the adjusted shortcut file path (perhaps including the ".lnk" suffix).
        /// </summary>
        string CreateShortcut(string shortcutFilePath, string shortcutTargetPath);
    }
}
