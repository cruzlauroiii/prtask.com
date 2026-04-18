namespace WillowMaze.Wasm.Decompiled;


class ReflectionAccessFilter$1 : com.google.gson.ReflectionAccessFilter {
    ReflectionAccessFilter$1() {
    }

    public static bool HdEHPTiGGBkUxoDW(java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.isJavaType((java.lang.Class<object>) cls);
    }

    public com.google.gson.ReflectionAccessFilter$FilterResult check(java.lang.Class<object> cls) {
        return !hdEHPTiGGBkUxoDW(cls) ? com.google.gson.ReflectionAccessFilter$FilterResult.INDECISIVE : com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_INACCESSIBLE;
    }
}

