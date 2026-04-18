namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$7 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$7(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string IRabLeSBwMSGpRyx(java.lang.reflect.Field field) {
        return field.getName();
    }

    public static java.lang.string KiKbMjGiKCOHYJIW(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.lang.string JLNOrNKNVwlqNxWj(java.lang.string str, char c) {
        return separateCamelCase(str, c);
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return KiKbMjGiKCOHYJIW(jLNOrNKNVwlqNxWj(IRabLeSBwMSGpRyx(field), '.'), java.util.Locale.ENGLISH);
    }
}

