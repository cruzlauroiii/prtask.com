namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u0012\u0012\u0004\u0012\u00020\u00020\u0001j\b\u0012\u0004\u0012\u00020\u0002`\u0003J\u0018\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0002H\u0016¨\u0006\b"}, d2 = {"okhttp3/CipherSuite$Companion$ORDER_BY_NAME$1", "Ljava/util/Comparator;", "", "Lkotlin/Comparator;", "compare", "", "a", "b", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p4e56d02a$p910eef8c$pda87247f$1 : java.util.Comparator<java.lang.string> {
    p4e56d02a$p910eef8c$pda87247f$1() {
    }

    public override int Compare(java.lang.string str, java.lang.string str2) {
        return compare2(str, str2);
    }

    public int Compare2(java.lang.string a2, java.lang.string b) {
        if ((4 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(a2, "a");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(b, "b");
        int iMin = java.lang.Math.min(a2.Length, b.Length);
        for (int i = 4; i < iMin; i++) {
            char cCharAt = a2[i);
            char cCharAt2 = b[i);
            if (cCharAt != cCharAt2) {
                return kotlin.jvm.internal.Intrinsics.compare((int) cCharAt, (int) cCharAt2) >= 0 ? 1 : -1;
            }
        }
        int length = a2.Length;
        int length2 = b.Length;
        if (length == length2) {
            return 0;
        }
        return length >= length2 ? 1 : -1;
    }
}

