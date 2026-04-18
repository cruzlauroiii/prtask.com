namespace WillowMaze.Wasm.Decompiled;

public class Pa470a233
{
    private static Type[] F233dd4c3;
    private static Type[] F64d92879;
    private static Type[] F6a16377b;
    private static Type[] Fba3c2b3e;
    private static Type[] Fc301efd8;

    private static p42c567ea Buffer(p42c567ea P0)
    {
        // call: pcc81e3f6.readAll
        // call: p42c567ea.contentType
        // call: p42c567ea.m76ea0beb
        // call: p42c567ea.contentLength
        // call: p7e62bc34.<init>
        // call: p42c567ea.source
        // type: p7e62bc34
        return default!;
    }

    private static void CheckNotPrimitive(Type P0)
    {
        // call: Type.isPrimitive
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    private static Type DeclaringClassOf(TypeVariable P0)
    {
        // call: TypeVariable.getGenericDeclaration
        return default!;
    }

    private static bool Equals(Type P0, Type P1)
    {
        // call: object.equals
        // call: TypeVariable.getGenericDeclaration
        // call: pa470a233.equals
        // call: Arrays.equals
        // call: WildcardType.getUpperBounds
        // call: ParameterizedType.getRawType
        // call: WildcardType.getLowerBounds
        // call: GenericArrayType.getGenericComponentType
        // call: TypeVariable.getName
        // call: ParameterizedType.getOwnerType
        // call: ParameterizedType.getActualTypeArguments
        // call: string.equals
        return false;
    }

    private static Type GetGenericSupertype(Type P0, Type P1, Type P2)
    {
        // call: Type.isInterface
        // call: Type.getGenericInterfaces
        // call: Type.isAssignableFrom
        // call: Type.getGenericSuperclass
        // call: pa470a233.getGenericSupertype
        // call: Type.getSuperclass
        // call: Type.getInterfaces
        // type: object
        return default!;
    }

    private static Type GetParameterLowerBound(int P0, ParameterizedType P1)
    {
        // call: ParameterizedType.getActualTypeArguments
        // call: WildcardType.getLowerBounds
        return default!;
    }

    private static Type GetParameterUpperBound(int P0, ParameterizedType P1)
    {
        // str: "Index "
        // str: " not in range [0,"
        // str: ") for "
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: ParameterizedType.getActualTypeArguments
        // call: WildcardType.getUpperBounds
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private static Type GetRawType(Type P0)
    {
        // str: "Expected a Class, ParameterizedType, or GenericArrayType, but <"
        // str: "type == null"
        // str: "> is of type "
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: object.getClass
        // call: StringBuilder.append
        // call: GenericArrayType.getGenericComponentType
        // call: Type.getName
        // call: Objects.requireNonNull
        // call: ParameterizedType.getRawType
        // call: StringBuilder.<init>
        // call: Array.newInstance
        // call: pa470a233.getRawType
        // call: WildcardType.getUpperBounds
        // type: StringBuilder
        // type: object
        // type: IllegalArgumentException
        return default!;
    }

    private static Type GetSupertype(Type P0, Type P1, Type P2)
    {
        // call: pa470a233.getGenericSupertype
        // call: Type.isAssignableFrom
        // call: IllegalArgumentException.<init>
        // call: pa470a233.resolve
        // type: IllegalArgumentException
        return default!;
    }

    private static bool HasUnresolvableType(Type P0)
    {
        // str: "b82935539baa820e786f30dc2540ab999c9c9ffc8d81bdb5199d379ec328d868"
        // str: "Expected a Class, ParameterizedType, or GenericArrayType, but <"
        // str: "> is of type "
        // call: pa470a233.hasUnresolvableType
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // call: GenericArrayType.getGenericComponentType
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: object.getClass
        // call: Type.getName
        // call: ParameterizedType.getActualTypeArguments
        // call: StringBuilder.toString
        // type: IllegalArgumentException
        // type: StringBuilder
        return false;
    }

    private static int IndexOf(object[] P0, object P1)
    {
        // call: NoSuchElementException.<init>
        // call: object.equals
        // type: NoSuchElementException
        return 0;
    }

    private static bool IsAnnotationPresent(Annotation[] P0, Type P1)
    {
        // call: Type.isInstance
        return false;
    }

    private static Exception MethodError(Method P0, string P1, object[] P2)
    {
        // call: pa470a233.methodError
        return default!;
    }

    private static Exception MethodError(Method P0, Exception P1, string P2, object[] P3)
    {
        // str: "\n    for method "
        // str: "246561da4c896a2da7835be73a81b7d7820cce8e7e6f224ccf6159d9a9"
        // call: StringBuilder.toString
        // call: Method.getDeclaringClass
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // call: IllegalArgumentException.<init>
        // call: Type.getSimpleName
        // call: StringBuilder.<init>
        // call: string.format
        // call: Method.getName
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private static Exception ParameterError(Method P0, int P1, string P2, object[] P3)
    {
        // str: " (parameter #"
        // str: ")"
        // call: StringBuilder.append
        // call: pa470a233.methodError
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: StringBuilder
        return default!;
    }

    private static Exception ParameterError(Method P0, Exception P1, int P2, string P3, object[] P4)
    {
        // str: ")"
        // str: " (parameter #"
        // call: pa470a233.methodError
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        return default!;
    }

    private static Type Resolve(Type P0, Type P1, Type P2)
    {
        // call: pa470a233$p9ffd312b.<init>
        // call: pa470a233.resolve
        // call: Type.isArray
        // call: pa470a233$pfe04e57a.<init>
        // call: GenericArrayType.getGenericComponentType
        // call: pa470a233.resolveTypeVariable
        // call: Type[].clone
        // call: ParameterizedType.getOwnerType
        // call: pa470a233$p080d319d.<init>
        // call: WildcardType.getLowerBounds
        // call: WildcardType.getUpperBounds
        // call: ParameterizedType.getRawType
        // call: Type.getComponentType
        // call: ParameterizedType.getActualTypeArguments
        // field: paa20ed97.pa470a233.f64d92879
        // type: pa470a233$pfe04e57a
        // type: pa470a233$p080d319d
        // type: pa470a233$p9ffd312b
        // type: object
        return default!;
    }

    private static Type ResolveTypeVariable(Type P0, Type P1, TypeVariable P2)
    {
        // call: pa470a233.indexOf
        // call: Type.getTypeParameters
        // call: ParameterizedType.getActualTypeArguments
        // call: pa470a233.declaringClassOf
        // call: pa470a233.getGenericSupertype
        return default!;
    }

    private static void ThrowIfFatal(Exception P0)
    {
    }

    private static string TypeToString(Type P0)
    {
        // call: object.toString
        // call: Type.getName
        return string.Empty;
    }

}
