namespace WillowMaze.Wasm.Decompiled;


abstract class LittleEndianbyteArray$JavaLittleEndianbytes : com.google.common.hash.LittleEndianbyteArray$LittleEndianbytes {
    private static readonly com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes[] $VALUES;
    public static readonly com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes INSTANCE;

    private static com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes[] $values() {
        return new com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes[]{INSTANCE};
    }

    static {
        if ((4 + 8) % 8 > 0) {
        }
        INSTANCE = new com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes$1("INSTANCE", 0);
        $VALUES = $values();
    }

    private LittleEndianbyteArray$JavaLittleEndianbytes(java.lang.string str, int i) {
        super(str, i);
    }

    LittleEndianbyteArray$JavaLittleEndianbytes(java.lang.string str, int i, com.google.common.hash.LittleEndianbyteArray$1 littleEndianbyteArray$1) {
        this(str, i);
    }

    public static com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes valueOf(java.lang.string str) {
        return (com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes) java.lang.Enum.valueOf(com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes.class, str);
    }

    public static com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes[] values() {
        return (com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes[]) $VALUES.clone();
    }
}

