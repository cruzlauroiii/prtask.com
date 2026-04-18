namespace WillowMaze.Wasm.Decompiled;


class ReflectionAccessFilter$4 : com.google.gson.ReflectionAccessFilter {
    ReflectionAccessFilter$4() {
    }

    public static bool UMHNrhLuQpVFasqD(java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.isAnyPlatformType(cls);
    }

    public com.google.gson.ReflectionAccessFilter$FilterResult check(java.lang.Class<object> cls) {
        return !UMHNrhLuQpVFasqD(cls) ? com.google.gson.ReflectionAccessFilter$FilterResult.INDECISIVE : com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_ALL;
    }
}

