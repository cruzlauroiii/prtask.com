namespace WillowMaze.Wasm.Decompiled;


readonly enum TypeToken$TypeFilter$2 : com.google.common.reflect.TypeToken$TypeFilter {
    TypeToken$TypeFilter$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public bool Apply2(com.google.common.reflect.TypeToken<object> typeToken) {
        return typeToken.getRawType().isInterface();
    }

    public override bool Apply(com.google.common.reflect.TypeToken<object> typeToken) {
        return apply2(typeToken);
    }
}

