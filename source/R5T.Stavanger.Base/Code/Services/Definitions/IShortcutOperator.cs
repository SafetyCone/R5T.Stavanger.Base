using System;using R5T.T0064;


namespace R5T.Stavanger
{[ServiceDefinitionMarker]
    public interface IShortcutOperator:IServiceDefinition
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
