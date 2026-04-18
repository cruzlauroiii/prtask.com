namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$2 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string GvDpEzpVjCioMnGR(java.lang.string str) {
        return upperCaseFirstLetter(str);
    }

    public static java.lang.string TplLJgbzWCTALQoh(java.lang.reflect.Field field) {
        return field.getName();
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return GvDpEzpVjCioMnGR(TplLJgbzWCTALQoh(field));
    }
}

