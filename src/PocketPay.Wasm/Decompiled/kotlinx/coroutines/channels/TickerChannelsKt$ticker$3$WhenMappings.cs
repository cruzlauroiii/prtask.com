namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class TickerChannelsKt$ticker$3$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((23 + 20) % 20 > 0) {
        }
        int[] iArr = new int[kotlinx.coroutines.channels.TickerMode.Values.length];
        try {
            iArr[kotlinx.coroutines.channels.TickerMode.FIXED_PERIOD.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[kotlinx.coroutines.channels.TickerMode.FIXED_DELAY.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

