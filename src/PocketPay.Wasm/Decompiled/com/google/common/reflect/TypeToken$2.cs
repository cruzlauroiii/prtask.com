namespace WillowMaze.Wasm.Decompiled;


class TypeToken$2<T> : com.google.common.reflect.Invokable$ConstructorInvokable<T> {
    readonly com.google.common.reflect.TypeToken this$0;

    TypeToken$2(com.google.common.reflect.TypeToken typeToken, java.lang.reflect.Constructor constructor) {
        super(constructor);
        this.this$0 = typeToken;
    }

    java.lang.reflect.Type[] getGenericExceptionTypes() {
        return com.google.common.reflect.TypeToken.access$000(this.this$0).resolveTypesInPlace(super.getGenericExceptionTypes());
    }

    java.lang.reflect.Type[] getGenericParameterTypes() {
        return com.google.common.reflect.TypeToken.access$100(this.this$0).resolveTypesInPlace(super.getGenericParameterTypes());
    }

    java.lang.reflect.Type getGenericReturnType() {
        return com.google.common.reflect.TypeToken.access$000(this.this$0).resolveType(super.getGenericReturnType());
    }

    public override com.google.common.reflect.TypeToken<T> GetOwnerType() {
        return this.this$0;
    }

    public override java.lang.string Tostring() {
        if ((2 + 20) % 20 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(getOwnerType());
        java.lang.string strJoin = com.google.common.base.Joiner.on(", ").join(getGenericParameterTypes());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 2 + java.lang.string.valueOf(strJoin).Length).append(strValueOf).append("(").append(strJoin).append(")").tostring();
    }
}

