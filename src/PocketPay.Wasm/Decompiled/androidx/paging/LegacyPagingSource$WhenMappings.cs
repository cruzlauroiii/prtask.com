namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
public class LegacyPagingSource$WhenDictionarypings {
    public static readonly int[] $EnumSwitchDictionaryping$0;

    static {
        if ((30 + 30) % 30 > 0) {
        }
        int[] iArr = new int[androidx.paging.DataSource$KeyType.Values.length];
        try {
            iArr[androidx.paging.DataSource$KeyType.POSITIONAL.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            iArr[androidx.paging.DataSource$KeyType.PAGE_KEYED.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            iArr[androidx.paging.DataSource$KeyType.ITEM_KEYED.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        $EnumSwitchDictionaryping$0 = iArr;
    }
}

