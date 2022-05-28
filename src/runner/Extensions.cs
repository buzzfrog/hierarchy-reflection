using models;
using System.Reflection;

public static class Extensions
{
    public static (string Name, string Description, IEnumerable<BaseModel> Children) Info(this BaseModel baseModel)
    {
        TypeInfo? typeInfo = baseModel.GetType().GetTypeInfo();
        PropertyInfo? childrenproperty = (from property in typeInfo.GetProperties()
                                          from attribute in property.GetCustomAttributes(true)
                                          where attribute.GetType() == typeof(ChildrenAttribute)
                                          select property).FirstOrDefault();

        if (childrenproperty != null)
        {
            return (typeInfo.Name, typeInfo.ToString(), (IEnumerable<BaseModel>)(childrenproperty.GetValue(baseModel) ?? System.Linq.Enumerable.Empty<BaseModel>()));
        }
        else
        {
            return (typeInfo.Name, typeInfo.ToString(), System.Linq.Enumerable.Empty<BaseModel>());
        }
    }
}