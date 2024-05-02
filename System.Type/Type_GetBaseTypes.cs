namespace TWI.Extensions
{
    using System;
    using System.Collections.Generic;

    public static class Type_GetBaseTypes
    {
        public static IEnumerable<Type> GetBaseTypes(this Type? type)
        {
            while (type != null)
            {
                yield return type;
                type = type.BaseType;
            }
        }
    }
}
