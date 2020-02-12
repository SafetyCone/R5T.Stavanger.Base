using System;


namespace R5T.Stavanger
{
    public static class IShortcutOperatorExtensions
    {
        public static string CreateShortcut(this IShortcutOperator shortcutOperator, string shortcutFilePath, string shortcutTargetPath)
        {
            var description = String.Empty;

            var shortcutLinkFilePath = shortcutOperator.CreateShortcut(shortcutFilePath, shortcutTargetPath, description);
            return shortcutLinkFilePath;
        }
    }
}
