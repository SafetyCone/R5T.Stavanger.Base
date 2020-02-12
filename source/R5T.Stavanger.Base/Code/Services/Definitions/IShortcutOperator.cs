using System;


namespace R5T.Stavanger
{
    public interface IShortcutOperator
    {
        string GetShortcutTargetPath(string shortcutFilePath);

        void SetShortcutTargetPath(string shortcutFilePath, string shortcutTargetPath);

        /// <summary>
        /// Outputs the adjusted shortcut file path (perhaps including the ".lnk" suffix).
        /// </summary>
        string CreateShortcut(string shortcutFilePath, string shortcutTargetPath, string description);

        string GetShortcutDescription(string shortcutFilePath);

        void SetShortcutDescription(string shortcutFilePath, string description);
    }
}
