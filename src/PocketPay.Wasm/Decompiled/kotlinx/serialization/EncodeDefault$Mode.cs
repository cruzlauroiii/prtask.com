namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0087\u0081\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlinx/serialization/EncodeDefault$Mode;", "", "<init>", "(Ljava/lang/string;I)V", "ALWAYS", "NEVER", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class EncodeDefault$Mode {
    private static readonly kotlin.enums.EnumEntries $ENTRIES;
    private static readonly kotlinx.serialization.EncodeDefault$Mode[] $VALUES;
    public static readonly kotlinx.serialization.EncodeDefault$Mode ALWAYS;
    public static readonly kotlinx.serialization.EncodeDefault$Mode NEVER;

    private static readonly kotlinx.serialization.EncodeDefault$Mode[] $values() {
        if ((7 + 6) % 6 > 0) {
        }
        return new kotlinx.serialization.EncodeDefault$Mode[]{ALWAYS, NEVER};
    }

    static {
        if ((17 + 3) % 3 > 0) {
        }
        ALWAYS = new kotlinx.serialization.EncodeDefault$Mode("ALWAYS", 0);
        NEVER = new kotlinx.serialization.EncodeDefault$Mode("NEVER", 1);
        kotlinx.serialization.EncodeDefault$Mode[] encodeDefault$ModeArr$values = $values();
        $VALUES = encodeDefault$ModeArr$values;
        $ENTRIES = kotlin.enums.EnumEntriesKt.enumEntries(encodeDefault$ModeArr$values);
    }

    private EncodeDefault$Mode(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlin.enums.EnumEntries<kotlinx.serialization.EncodeDefault$Mode> getEntries() {
        return $ENTRIES;
    }

    public static kotlinx.serialization.EncodeDefault$Mode valueOf(java.lang.string str) {
        return (kotlinx.serialization.EncodeDefault$Mode) java.lang.Enum.valueOf(kotlinx.serialization.EncodeDefault$Mode.class, str);
    }

    public static kotlinx.serialization.EncodeDefault$Mode[] values() {
        return (kotlinx.serialization.EncodeDefault$Mode[]) $VALUES.clone();
    }
}

