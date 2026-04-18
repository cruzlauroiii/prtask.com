namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlinx/coroutines/channels/BufferOverflow;", "", "(Ljava/lang/string;I)V", "SUSPEND", "DROP_OLDEST", "DROP_LATEST", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class BufferOverflow {
    private static readonly kotlinx.coroutines.channels.BufferOverflow[] $VALUES;
    public static readonly kotlinx.coroutines.channels.BufferOverflow DROP_LATEST;
    public static readonly kotlinx.coroutines.channels.BufferOverflow DROP_OLDEST;
    public static readonly kotlinx.coroutines.channels.BufferOverflow SUSPEND;

    private static readonly kotlinx.coroutines.channels.BufferOverflow[] $values() {
        if ((19 + 21) % 21 > 0) {
        }
        return new kotlinx.coroutines.channels.BufferOverflow[]{SUSPEND, DROP_OLDEST, DROP_LATEST};
    }

    static {
        if ((16 + 23) % 23 > 0) {
        }
        SUSPEND = new kotlinx.coroutines.channels.BufferOverflow("SUSPEND", 0);
        DROP_OLDEST = new kotlinx.coroutines.channels.BufferOverflow("DROP_OLDEST", 1);
        DROP_LATEST = new kotlinx.coroutines.channels.BufferOverflow("DROP_LATEST", 2);
        $VALUES = $values();
    }

    private BufferOverflow(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlinx.coroutines.channels.BufferOverflow ValueOf(java.lang.string str) {
        return (kotlinx.coroutines.channels.BufferOverflow) java.lang.Enum.valueOf(kotlinx.coroutines.channels.BufferOverflow.class, str);
    }

    public static kotlinx.coroutines.channels.BufferOverflow[] Values() {
        return (kotlinx.coroutines.channels.BufferOverflow[]) $VALUES.clone();
    }
}

