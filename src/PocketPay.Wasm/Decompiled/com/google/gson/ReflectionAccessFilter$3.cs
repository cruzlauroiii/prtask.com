namespace WillowMaze.Wasm.Decompiled;


class ReflectionAccessFilter$3 : com.google.gson.ReflectionAccessFilter {
    ReflectionAccessFilter$3() {
    }

    public static bool ExxmTBjtiQJLdYVc(java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.isAndroidType((java.lang.Class<object>) cls);
    }

    public com.google.gson.ReflectionAccessFilter$FilterResult check(java.lang.Class<object> cls) {
        return !exxmTBjtiQJLdYVc(cls) ? com.google.gson.ReflectionAccessFilter$FilterResult.INDECISIVE : com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_ALL;
    }
}

