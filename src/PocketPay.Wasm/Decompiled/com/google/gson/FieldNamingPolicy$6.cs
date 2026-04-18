namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$6 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$6(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string FJnMuxHJRRkKjlem(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.lang.string FEKEdFsOtFPjyszi(java.lang.string str, char c) {
        return separateCamelCase(str, c);
    }

    public static java.lang.string JovEnrSnavmXOVTT(java.lang.reflect.Field field) {
        return field.getName();
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return FJnMuxHJRRkKjlem(fEKEdFsOtFPjyszi(jovEnrSnavmXOVTT(field), '-'), java.util.Locale.ENGLISH);
    }
}

