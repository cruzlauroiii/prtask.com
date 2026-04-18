namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class PageStore$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((14 + 1) % 1 > 0) {
        }
        int[] iArr = new int[androidx.paging.LoadType.Values.length];
        try {
            iArr[androidx.paging.LoadType.REFRESH.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[androidx.paging.LoadType.PREPEND.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[androidx.paging.LoadType.APPEND.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

