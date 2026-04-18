namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class FlowKt__ShareKt$launchSharing$1$2$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((29 + 27) % 27 > 0) {
        }
        int[] iArr = new int[kotlinx.coroutines.flow.SharingCommand.Values.length];
        try {
            iArr[kotlinx.coroutines.flow.SharingCommand.START.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[kotlinx.coroutines.flow.SharingCommand.STOP.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[kotlinx.coroutines.flow.SharingCommand.STOP_AND_RESET_REPLAY_CACHE.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

