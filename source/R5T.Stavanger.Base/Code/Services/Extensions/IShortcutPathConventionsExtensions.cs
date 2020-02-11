using System;


namespace R5T.Stavanger
{
    public static class IShortcutPathConventionsExtensions
    {
        /// <summary>
        /// Adds the link suffix to the file path.
        /// </summary>
        /// <remarks>
        /// A link will only display its file name and file extension in Windows Explorer, not the invisible link suffix. This means that to actually get the path of a link file, you have to add the invisible link suffix.
        /// </remarks>
        public static string MakeFilePathIntoLinkFilePath(this IShortcutPathConventions shortcutPathConventions, string filePath)
        {
            var linkSuffixExtensionSeparator = shortcutPathConventions.GetLinkSuffixExtensionSeparator();
            var linkSuffixExtension = shortcutPathConventions.GetLinkSuffixExtension();

            string output = $"{filePath}{linkSuffixExtensionSeparator}{linkSuffixExtension}";
            return output;
        }
    }
}
