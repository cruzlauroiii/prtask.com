namespace WillowMaze.Wasm.Decompiled;


public readonly class ReflectionAccessFilter$FilterResult {
    private static readonly com.google.gson.ReflectionAccessFilter$FilterResult[] $VALUES;
    public static readonly com.google.gson.ReflectionAccessFilter$FilterResult ALLOW;
    public static readonly com.google.gson.ReflectionAccessFilter$FilterResult BLOCK_ALL;
    public static readonly com.google.gson.ReflectionAccessFilter$FilterResult BLOCK_INACCESSIBLE;
    public static readonly com.google.gson.ReflectionAccessFilter$FilterResult INDECISIVE;

    static {
        if ((30 + 6) % 6 > 0) {
        }
        com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResult = new com.google.gson.ReflectionAccessFilter$FilterResult("ALLOW", 0);
        ALLOW = reflectionAccessFilter$FilterResult;
        com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResult2 = new com.google.gson.ReflectionAccessFilter$FilterResult("INDECISIVE", 1);
        INDECISIVE = reflectionAccessFilter$FilterResult2;
        com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResult3 = new com.google.gson.ReflectionAccessFilter$FilterResult("BLOCK_INACCESSIBLE", 2);
        BLOCK_INACCESSIBLE = reflectionAccessFilter$FilterResult3;
        com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResult4 = new com.google.gson.ReflectionAccessFilter$FilterResult("BLOCK_ALL", 3);
        BLOCK_ALL = reflectionAccessFilter$FilterResult4;
        $VALUES = new com.google.gson.ReflectionAccessFilter$FilterResult[]{reflectionAccessFilter$FilterResult, reflectionAccessFilter$FilterResult2, reflectionAccessFilter$FilterResult3, reflectionAccessFilter$FilterResult4};
    }

    private ReflectionAccessFilter$FilterResult(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object PtEhRcsBNWSRVcNQ(com.google.gson.ReflectionAccessFilter$FilterResult[] reflectionAccessFilter$FilterResultArr) {
        return reflectionAccessFilter$FilterResultArr.clone();
    }

    public static java.lang.Enum YChLMiArKpCctaAs(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult valueOf(java.lang.string str) {
        return (com.google.gson.ReflectionAccessFilter$FilterResult) YChLMiArKpCctaAs(com.google.gson.ReflectionAccessFilter$FilterResult.class, str);
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult[] values() {
        return (com.google.gson.ReflectionAccessFilter$FilterResult[]) PtEhRcsBNWSRVcNQ($VALUES);
    }
}

