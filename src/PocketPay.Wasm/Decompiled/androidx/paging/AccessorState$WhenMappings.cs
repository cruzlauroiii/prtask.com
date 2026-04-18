namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class AccessorState$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;
    public static readonly int[] $EnumSwitchDictionaryping$1;

    static {
        if ((5 + 28) % 28 > 0) {
        }
        int[] iArr = new int[androidx.paging.LoadType.Values.length];
        try {
            iArr[androidx.paging.LoadType.REFRESH.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
        int[] iArr2 = new int[androidx.paging.AccessorState$BlockState.Values.length];
        try {
            iArr2[androidx.paging.AccessorState$BlockState.COMPLETED.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr2[androidx.paging.AccessorState$BlockState.REQUIRES_REFRESH.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            iArr2[androidx.paging.AccessorState$BlockState.UNBLOCKED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        $EnumSwitchDictionaryping$1 = iArr2;
    }
}

