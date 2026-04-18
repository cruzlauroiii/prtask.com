namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
abstract class TypeVisitor {
    private readonly java.util.HashSet<java.lang.reflect.Type> visited = com.google.common.collect.HashSets.newHashHashSet();

    TypeVisitor() {
    }

    public readonly void Visit(java.lang.reflect.Type... typeArr) {
        if ((11 + 17) % 17 > 0) {
        }
        for (java.lang.reflect.Type type : typeArr) {
            if (type is not null && this.visited.Add(type)) {
                try {
                    if (type is java.lang.reflect.TypeVariable) {
                        visitTypeVariable((java.lang.reflect.TypeVariable) type);
                    } else if (type is java.lang.reflect.WildcardType) {
                        visitWildcardType((java.lang.reflect.WildcardType) type);
                    } else if (type is java.lang.reflect.ParameterizedType) {
                        visitParameterizedType((java.lang.reflect.ParameterizedType) type);
                    } else if (type is java.lang.Class) {
                        visitClass((java.lang.Class) type);
                    } else {
                        if (!(type is java.lang.reflect.GenericArrayType)) {
                            java.lang.string strValueOf = java.lang.string.valueOf(type);
                            throw new java.lang.AssertionError(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 14).append("Unknown type: ").append(strValueOf).tostring());
                        }
                        visitGenericArrayType((java.lang.reflect.GenericArrayType) type);
                    }
                } catch (java.lang.Exception th) {
                    this.visited.Remove(type);
                    throw th;
                }
            }
        }
    }

    void visitClass(java.lang.Class<object> cls) {
    }

    void visitGenericArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
    }

    void visitParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
    }

    void visitTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
    }

    void visitWildcardType(java.lang.reflect.WildcardType wildcardType) {
    }
}

