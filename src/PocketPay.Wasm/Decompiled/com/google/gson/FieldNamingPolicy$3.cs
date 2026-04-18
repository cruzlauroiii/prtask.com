namespace WillowMaze.Wasm.Decompiled;


readonly enum FieldNamingPolicy$3 : com.google.gson.FieldNamingPolicy {
    FieldNamingPolicy$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.string HljjZnPxUSdlMjjH(java.lang.string str, char c) {
        return separateCamelCase(str, c);
    }

    public static java.lang.string ADYVoOveqZkxcbxT(java.lang.string str) {
        return upperCaseFirstLetter(str);
    }

    public static java.lang.string XubmucYjpLUQRIJj(java.lang.reflect.Field field) {
        return field.getName();
    }

    public override java.lang.string TranslateName(java.lang.reflect.Field field) {
        return aDYVoOveqZkxcbxT(HljjZnPxUSdlMjjH(xubmucYjpLUQRIJj(field), ' '));
    }
}

