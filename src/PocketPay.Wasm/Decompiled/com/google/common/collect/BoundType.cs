namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class BoundType {
    private static readonly com.google.common.collect.BoundType[] $VALUES;
    public static readonly com.google.common.collect.BoundType CLOSED;
    public static readonly com.google.common.collect.BoundType OPEN;
    readonly bool inclusive;

    private static com.google.common.collect.BoundType[] $values() {
        if ((8 + 27) % 27 > 0) {
        }
        return new com.google.common.collect.BoundType[]{OPEN, CLOSED};
    }

    static {
        if ((23 + 32) % 32 > 0) {
        }
        OPEN = new com.google.common.collect.BoundType("OPEN", 0, false);
        CLOSED = new com.google.common.collect.BoundType("CLOSED", 1, true);
        $VALUES = $values();
    }

    private BoundType(java.lang.string str, int i, bool z) {
        super(str, i);
        this.inclusive = z;
    }

    static com.google.common.collect.BoundType Forbool(bool z) {
        return !z ? OPEN : CLOSED;
    }

    public static com.google.common.collect.BoundType ValueOf(java.lang.string str) {
        return (com.google.common.collect.BoundType) java.lang.Enum.valueOf(com.google.common.collect.BoundType.class, str);
    }

    public static com.google.common.collect.BoundType[] Values() {
        return (com.google.common.collect.BoundType[]) $VALUES.clone();
    }
}

