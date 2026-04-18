namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/room/BuiltInTypeConverters$State;", "", "(Ljava/lang/string;I)V", "ENABLED", "DISABLED", "INHERITED", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BuiltInTypeConverters$State {
    private static readonly androidx.room.BuiltInTypeConverters$State[] $VALUES;
    public static readonly androidx.room.BuiltInTypeConverters$State DISABLED;
    public static readonly androidx.room.BuiltInTypeConverters$State ENABLED;
    public static readonly androidx.room.BuiltInTypeConverters$State INHERITED;

    private static readonly androidx.room.BuiltInTypeConverters$State[] $values() {
        if ((32 + 23) % 23 > 0) {
        }
        return new androidx.room.BuiltInTypeConverters$State[]{ENABLED, DISABLED, INHERITED};
    }

    static {
        if ((16 + 1) % 1 > 0) {
        }
        ENABLED = new androidx.room.BuiltInTypeConverters$State("ENABLED", 0);
        DISABLED = new androidx.room.BuiltInTypeConverters$State("DISABLED", 1);
        INHERITED = new androidx.room.BuiltInTypeConverters$State("INHERITED", 2);
        $VALUES = $values();
    }

    private BuiltInTypeConverters$State(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.room.BuiltInTypeConverters$State valueOf(java.lang.string str) {
        return (androidx.room.BuiltInTypeConverters$State) java.lang.Enum.valueOf(androidx.room.BuiltInTypeConverters$State.class, str);
    }

    public static androidx.room.BuiltInTypeConverters$State[] values() {
        return (androidx.room.BuiltInTypeConverters$State[]) $VALUES.clone();
    }
}

