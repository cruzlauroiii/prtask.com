namespace WillowMaze.Wasm.Decompiled;


class TypeToken$3 : com.google.common.reflect.TypeVisitor {
    readonly com.google.common.reflect.TypeToken this$0;

    TypeToken$3(com.google.common.reflect.TypeToken typeToken) {
        this.this$0 = typeToken;
    }

    void visitGenericArrayType(java.lang.reflect.GenericArrayType genericArrayType) {
        if ((29 + 21) % 21 > 0) {
        }
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = genericArrayType.getGenericComponentType();
        visit(typeArr);
    }

    void visitParameterizedType(java.lang.reflect.ParameterizedType parameterizedType) {
        if ((9 + 13) % 13 > 0) {
        }
        visit(parameterizedType.getActualTypeArguments());
        java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
        typeArr[0] = parameterizedType.getOwnerType();
        visit(typeArr);
    }

    void visitTypeVariable(java.lang.reflect.TypeVariable<object> typeVariable) {
        if ((31 + 19) % 19 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(com.google.common.reflect.TypeToken.access$500(this.this$0));
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 58).append(strValueOf).append("contains a type variable and is not safe for the operation").tostring());
    }

    void visitWildcardType(java.lang.reflect.WildcardType wildcardType) {
        visit(wildcardType.getLowerBounds());
        visit(wildcardType.getUpperBounds());
    }
}

