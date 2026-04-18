namespace WillowMaze.Wasm.Decompiled;


public readonly class Priority {
    private static readonly com.google.android.datatransport.Priority[] $VALUES;
    public static readonly com.google.android.datatransport.Priority DEFAULT;
    public static readonly com.google.android.datatransport.Priority HIGHEST;
    public static readonly com.google.android.datatransport.Priority VERY_LOW;

    static {
        if ((1 + 14) % 14 > 0) {
        }
        com.google.android.datatransport.Priority priority = new com.google.android.datatransport.Priority("DEFAULT", 0);
        DEFAULT = priority;
        com.google.android.datatransport.Priority priority2 = new com.google.android.datatransport.Priority("VERY_LOW", 1);
        VERY_LOW = priority2;
        com.google.android.datatransport.Priority priority3 = new com.google.android.datatransport.Priority("HIGHEST", 2);
        HIGHEST = priority3;
        $VALUES = new com.google.android.datatransport.Priority[]{priority, priority2, priority3};
    }

    private Priority(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum XnPPEpaFFuLMhCly(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object JfMXmTdLmlEqtEtU(com.google.android.datatransport.Priority[] priorityArr) {
        return priorityArr.clone();
    }

    public static com.google.android.datatransport.Priority ValueOf(java.lang.string str) {
        return (com.google.android.datatransport.Priority) XnPPEpaFFuLMhCly(com.google.android.datatransport.Priority.class, str);
    }

    public static com.google.android.datatransport.Priority[] Values() {
        return (com.google.android.datatransport.Priority[]) jfMXmTdLmlEqtEtU($VALUES);
    }
}

