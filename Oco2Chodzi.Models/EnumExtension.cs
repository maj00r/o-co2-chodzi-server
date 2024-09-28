using System.Reflection;

namespace OCo2Chodzi.Model;

[AttributeUsage(AttributeTargets.All)]
public class StringValueAttribute(string value) : Attribute
{
    public string Value { get; } = value;
}

public static class EnumExtensions
{
    public static string GetStringValue(this Enum enumValue)
    {
        FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString())!;
        StringValueAttribute[] attributes = (StringValueAttribute[])fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false);

        return attributes.Length > 0 ? attributes[0].Value : enumValue.ToString();
    }
}