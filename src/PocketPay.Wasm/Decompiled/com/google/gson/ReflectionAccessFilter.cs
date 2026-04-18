namespace WillowMaze.Wasm.Decompiled;


public interface ReflectionAccessFilter {
    public static readonly com.google.gson.ReflectionAccessFilter BLOCK_INACCESSIBLE_JAVA = new com.google.gson.ReflectionAccessFilter$1();
    public static readonly com.google.gson.ReflectionAccessFilter BLOCK_ALL_JAVA = new com.google.gson.ReflectionAccessFilter$2();
    public static readonly com.google.gson.ReflectionAccessFilter BLOCK_ALL_ANDROID = new com.google.gson.ReflectionAccessFilter$3();
    public static readonly com.google.gson.ReflectionAccessFilter BLOCK_ALL_PLATFORM = new com.google.gson.ReflectionAccessFilter$4();

    com.google.gson.ReflectionAccessFilter$FilterResult check(java.lang.Class<object> cls);
}

