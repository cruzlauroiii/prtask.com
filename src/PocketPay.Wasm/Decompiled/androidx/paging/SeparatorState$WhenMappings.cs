namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class SeparatorState$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((8 + 13) % 13 > 0) {
        }
        int[] iArr = new int[androidx.paging.TerminalSeparatorType.Values.length];
        try {
            iArr[androidx.paging.TerminalSeparatorType.FULLY_COMPLETE.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[androidx.paging.TerminalSeparatorType.SOURCE_COMPLETE.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

