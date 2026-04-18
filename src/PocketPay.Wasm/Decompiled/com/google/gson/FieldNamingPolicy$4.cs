namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$4 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$4(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string PEQXnjGIaLDqEniM(java.lang.reflect.Field field) {
        return field.getName();
    }

    public static java.lang.string UZfyqWpVdWrbxsAe(java.lang.string str, java.util.Locale locale) {
        return str.toUpperCase(locale);
    }

    public static java.lang.string FxkLqSQvXIkyzDiW(java.lang.string str, char c) {
        return separateCamelCase(str, c);
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return UZfyqWpVdWrbxsAe(fxkLqSQvXIkyzDiW(PEQXnjGIaLDqEniM(field), '_'), java.util.Locale.ENGLISH);
    }
}

