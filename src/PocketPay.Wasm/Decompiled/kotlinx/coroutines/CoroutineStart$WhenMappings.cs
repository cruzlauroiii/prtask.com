namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class CoroutineStart$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((7 + 2) % 2 > 0) {
        }
        int[] iArr = new int[kotlinx.coroutines.CoroutineStart.Values.length];
        try {
            iArr[kotlinx.coroutines.CoroutineStart.DEFAULT.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[kotlinx.coroutines.CoroutineStart.ATOMIC.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[kotlinx.coroutines.CoroutineStart.UNDISPATCHED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[kotlinx.coroutines.CoroutineStart.LAZY.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

