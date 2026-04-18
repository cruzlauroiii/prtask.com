namespace WillowMaze.Wasm.Decompiled;


class ReflectionAccessFilter$2 : com.google.gson.ReflectionAccessFilter {
    ReflectionAccessFilter$2() {
    }

    public static bool LnNVolwTUtivfFFq(java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.isJavaType((java.lang.Class<object>) cls);
    }

    public com.google.gson.ReflectionAccessFilter$FilterResult check(java.lang.Class<object> cls) {
        return !lnNVolwTUtivfFFq(cls) ? com.google.gson.ReflectionAccessFilter$FilterResult.INDECISIVE : com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_ALL;
    }
}

