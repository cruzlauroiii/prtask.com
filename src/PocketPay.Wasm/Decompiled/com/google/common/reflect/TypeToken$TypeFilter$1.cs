namespace WillowMaze.Wasm.Decompiled;


readonly enum TypeToken$TypeFilter$1 : com.google.common.reflect.TypeToken$TypeFilter {
    TypeToken$TypeFilter$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public bool Apply2(com.google.common.reflect.TypeToken<object> typeToken) {
        return ((com.google.common.reflect.TypeToken.access$500(typeToken) instanceof java.lang.reflect.TypeVariable) || (com.google.common.reflect.TypeToken.access$500(typeToken) instanceof java.lang.reflect.WildcardType)) ? false : true;
    }

    public override bool Apply(com.google.common.reflect.TypeToken<object> typeToken) {
        return apply2(typeToken);
    }
}

