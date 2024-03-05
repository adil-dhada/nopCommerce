namespace Nop.Web.Framework.Localization;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public class LocalizedModelAttribute: Attribute
{
    public LocalizedModelAttribute(string localizationPrefix)
    {
        LocalizationPrefix = localizationPrefix;
    }

    public LocalizedModelAttribute(Type modelType)
    {
        var prefix = modelType.Namespace?.Contains("Areas.Admin", StringComparison.InvariantCultureIgnoreCase) ?? false ? "Admin.Catalog." : string.Empty;
        LocalizationPrefix = $"{prefix}{modelType.Name}.Fields.";
    }

    public string LocalizationPrefix { get; set; }
}
