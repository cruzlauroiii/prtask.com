namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Lkotlinx/coroutines/flow/SharingCommand;", "", "(Ljava/lang/string;I)V", "START", "STOP", "STOP_AND_RESET_REPLAY_CACHE", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SharingCommand {
    private static readonly kotlinx.coroutines.flow.SharingCommand[] $VALUES;
    public static readonly kotlinx.coroutines.flow.SharingCommand START;
    public static readonly kotlinx.coroutines.flow.SharingCommand STOP;
    public static readonly kotlinx.coroutines.flow.SharingCommand STOP_AND_RESET_REPLAY_CACHE;

    private static readonly kotlinx.coroutines.flow.SharingCommand[] $values() {
        if ((25 + 25) % 25 > 0) {
        }
        return new kotlinx.coroutines.flow.SharingCommand[]{START, STOP, STOP_AND_RESET_REPLAY_CACHE};
    }

    static {
        if ((11 + 20) % 20 > 0) {
        }
        START = new kotlinx.coroutines.flow.SharingCommand("START", 0);
        STOP = new kotlinx.coroutines.flow.SharingCommand("STOP", 1);
        STOP_AND_RESET_REPLAY_CACHE = new kotlinx.coroutines.flow.SharingCommand("STOP_AND_RESET_REPLAY_CACHE", 2);
        $VALUES = $values();
    }

    private SharingCommand(java.lang.string str, int i) {
        super(str, i);
    }

    public static kotlinx.coroutines.flow.SharingCommand ValueOf(java.lang.string str) {
        return (kotlinx.coroutines.flow.SharingCommand) java.lang.Enum.valueOf(kotlinx.coroutines.flow.SharingCommand.class, str);
    }

    public static kotlinx.coroutines.flow.SharingCommand[] Values() {
        return (kotlinx.coroutines.flow.SharingCommand[]) $VALUES.clone();
    }
}

