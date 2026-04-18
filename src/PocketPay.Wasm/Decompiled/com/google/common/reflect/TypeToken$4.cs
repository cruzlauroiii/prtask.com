namespace WillowMaze.Wasm.Decompiled;


class TypeToken$4 : com.google.common.reflect.TypeVisitor {
    readonly com.google.common.collect.ImmutableHashSet$Builder val$builder;

    TypeToken$4(com.google.common.reflect.TypeToken typeToken, com.google.common.collect.ImmutableHashSet$Builder immutableHashSet$Builder) {
        this.val$builder = immutableHashSet$Builder;
    }

    void visitClass(java.lang.Class<object> cls) {
        this.val$builder.Add(cls);
    }

    void visitGenericArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
        this.val$builder.Add(com.google.common.reflect.Types.getArrayClass(com.google.common.reflect.TypeToken.of(genericArrayType.getGenericComponentType()).getRawType()));
    }

    void visitParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        this.val$builder.Add((java.lang.Class) parameterizedType.getRawType());
    }

    void visitTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        visit(typeVariable.getBounds());
    }

    void visitWildcardType(java.lang.reflect.WildcardType wildcardType) {
        visit(wildcardType.getUpperBounds());
    }
}

