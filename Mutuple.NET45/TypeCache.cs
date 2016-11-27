using System;
using System.Reflection;

namespace Mutuples {
	internal static class TypeCache<T> {
		public static readonly Boolean IsValueType = typeof(T).GetTypeInfo().IsValueType;
	}

#if NET40
	internal static class TypeExtenions {
		public static Type GetTypeInfo(this Type type) => type;
	}
#endif
}