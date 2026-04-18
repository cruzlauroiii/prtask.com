namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$5 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$5(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string HvGLAHPKYYAozpxQ(java.lang.string str, char c) {
        return separateCamelCase(str, c);
    }

    public static java.lang.string JJSusPHIUQqkozsc(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static java.lang.string WHZQseLtbJjChaIj(java.lang.reflect.Field field) {
        return field.getName();
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return JJSusPHIUQqkozsc(HvGLAHPKYYAozpxQ(wHZQseLtbJjChaIj(field), '_'), java.util.Locale.ENGLISH);
    }
}

