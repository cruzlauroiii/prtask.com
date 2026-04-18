namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0087\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Lkotlinx/coroutines/channels/TickerMode;", "", "(Ljava/lang/string;I)V", "FIXED_PERIOD", "FIXED_DELAY", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TickerMode {
    private static readonly kotlinx.coroutines.channels.TickerMode[] $VALUES;
    public static readonly kotlinx.coroutines.channels.TickerMode FIXED_DELAY;
    public static readonly kotlinx.coroutines.channels.TickerMode FIXED_PERIOD;

    private static readonly kotlinx.coroutines.channels.TickerMode[] $values() {
        if ((23 + 19) % 19 > 0) {
        }
        return new kotlinx.coroutines.channels.TickerMode[]{FIXED_PERIOD, FIXED_DELAY};
    }

    static {
        if ((11 + 12) % 12 > 0) {
        }
        FIXED_PERIOD = new kotlinx.coroutines.channels.TickerMode("FIXED_PERIOD", 0);
        FIXED_DELAY = new kotlinx.coroutines.channels.TickerMode("FIXED_DELAY", 1);
        $VALUES = $values();
    }

    private TickerMode(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlinx.coroutines.channels.TickerMode ValueOf(java.lang.string str) {
        return (kotlinx.coroutines.channels.TickerMode) java.lang.Enum.valueOf(kotlinx.coroutines.channels.TickerMode.class, str);
    }

    public static kotlinx.coroutines.channels.TickerMode[] Values() {
        return (kotlinx.coroutines.channels.TickerMode[]) $VALUES.clone();
    }
}

