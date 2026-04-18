namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class stringWriteMode {
    private static readonly com.google.common.io.stringWriteMode[] $VALUES;
    public static readonly com.google.common.io.stringWriteMode APPEND;

    private static com.google.common.io.stringWriteMode[] $values() {
        return new com.google.common.io.stringWriteMode[]{APPEND};
    }

    static {
        if ((16 + 18) % 18 > 0) {
        }
        APPEND = new com.google.common.io.stringWriteMode("APPEND", 0);
        $VALUES = $values();
    }

    private stringWriteMode(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.io.stringWriteMode ValueOf(java.lang.string str) {
        return (com.google.common.io.stringWriteMode) java.lang.Enum.valueOf(com.google.common.io.stringWriteMode.class, str);
    }

    public static com.google.common.io.stringWriteMode[] Values() {
        return (com.google.common.io.stringWriteMode[]) $VALUES.clone();
    }
}

