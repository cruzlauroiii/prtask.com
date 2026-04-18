namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class SharedFlowImpl$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((11 + 29) % 29 > 0) {
        }
        int[] iArr = new int[kotlinx.coroutines.channels.BufferOverflow.Values.length];
        try {
            iArr[kotlinx.coroutines.channels.BufferOverflow.SUSPEND.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[kotlinx.coroutines.channels.BufferOverflow.DROP_LATEST.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[kotlinx.coroutines.channels.BufferOverflow.DROP_OLDEST.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

