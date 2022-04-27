using System;using R5T.T0064;


namespace R5T.Stavanger
{[ServiceDefinitionMarker]
    public interface IShortcutPathConventions:IServiceDefinition
    {
        string GetLinkSuffixExtensionSeparator();
        string GetLinkSuffixExtension();
    }
}
