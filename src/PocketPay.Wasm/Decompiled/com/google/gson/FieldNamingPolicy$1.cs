namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$1 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string DUrboptYdtHdZhVl(java.lang.reflect.Field field) {
        return field.getName();
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return DUrboptYdtHdZhVl(field);
    }
}

