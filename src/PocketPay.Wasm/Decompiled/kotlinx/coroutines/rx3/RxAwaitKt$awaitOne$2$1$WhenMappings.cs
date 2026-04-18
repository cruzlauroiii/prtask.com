namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class RxAwaitKt$awaitOne$2$1$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((25 + 32) % 32 > 0) {
        }
        int[] iArr = new int[kotlinx.coroutines.rx3.Mode.Values.length];
        try {
            iArr[kotlinx.coroutines.rx3.Mode.FIRST.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[kotlinx.coroutines.rx3.Mode.FIRST_OR_DEFAULT.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[kotlinx.coroutines.rx3.Mode.LAST.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr[kotlinx.coroutines.rx3.Mode.SINGLE.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

