using System.Collections.Specialized;

namespace Quartz
{
    /// <summary>
    /// Configuration interface that allows hooking strongly typed helpers for configuration.
    /// </summary>
    public interface IPropertyConfigurer : IPropertySetter
    {
        NameValueCollection Properties { get; }
    }

    /// <summary>
    /// Configuration interface that allows hooking strongly typed helpers for configuration.
    /// </summary>
    public interface IPropertySetter
    {
        void SetProperty(string name, string value);
    }
}