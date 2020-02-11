using System;


namespace R5T.Stavanger
{
    public class DefaultShortcutPathConventions : IShortcutPathConventions
    {
        public const string LinkSuffixExtension = "lnk";
        public const string LinkSuffixExtensionSeparator = ".";


        public string GetLinkSuffixExtension()
        {
            return DefaultShortcutPathConventions.LinkSuffixExtension;
        }

        public string GetLinkSuffixExtensionSeparator()
        {
            return DefaultShortcutPathConventions.LinkSuffixExtensionSeparator;
        }
    }
}
