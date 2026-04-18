namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\t\n\u0002\b\u000b\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0087@\u0018\u00002\u00020\u0001B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006B\u0011\b\u0000\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0004\b\u0005\u0010\tJ\u0010\u0010\u000f\u001a\u00020\u0003H\u0086\n¢\u0006\u0004\b\u0010\u0010\u000bJ\u0010\u0010\u0011\u001a\u00020\u0003H\u0086\n¢\u0006\u0004\b\u0012\u0010\u000bJ\u001a\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0001HÖ\u0003¢\u0006\u0004\b\u0016\u0010\u0017J\u0010\u0010\u0018\u001a\u00020\u0003HÖ\u0001¢\u0006\u0004\b\u0019\u0010\u000bJ\u000f\u0010\u001a\u001a\u00020\u001bH\u0016¢\u0006\u0004\b\u001c\u0010\u001dR\u0011\u0010\u0002\u001a\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\n\u0010\u000bR\u0016\u0010\u0007\u001a\u00020\b8\u0000X\u0081\u0004¢\u0006\b\n\u0000\u0012\u0004\b\f\u0010\rR\u0011\u0010\u0004\u001a\u00020\u00038F¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000b\u0088\u0001\u0007\u0092\u0001\u00020\b¨\u0006\u001e"}, d2 = {"Landroidx/collection/IntIntValueTuple;", "", "first", "", "second", "constructor-impl", "(II)J", "packedValue", "", "(J)J", "getFirst-impl", "(J)I", "getPackedValue$annotations", "()V", "getSecond-impl", "component1", "component1-impl", "component2", "component2-impl", "equals", "", "other", "equals-impl", "(JLjava/lang/object;)Z", "hashCode", "hashCode-impl", "tostring", "", "tostring-impl", "(J)Ljava/lang/string;", "collection"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@kotlin.jvm.JvmInline
public readonly class IntIntValueTuple {
    public readonly long packedValue;

    private IntIntValueTuple(long j) {
        this.packedValue = j;
    }

    public static java.lang.stringBuilder CIhWlhYScTGqQwjg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static long FPmBJIxNNKgrzWAY(androidx.collection.IntIntValueTuple intIntValueTuple) {
        if ((26 + 24) % 24 > 0) {
        }
        return intIntValueTuple.m643unboximpl();
    }

    public static java.lang.string FbHOgXBkSKIQKIzr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HksLbbDeFRDaFeTU(long j, java.lang.object obj) {
        return m637equalsimpl(j, obj);
    }

    public static int MvqvRShCqUkGzqDk(long j) {
        return java.lang.long.hashCode(j);
    }

    public static long ZrEIIdPgwMygzoVa(long j) {
        if ((12 + 30) % 30 > 0) {
        }
        return m636constructorimpl(j);
    }

    public static int ZsXEsBmjnPrBsOvr(long j) {
        return m639getFirstimpl(j);
    }

    public static readonly androidx.collection.IntIntValueTuple M632boximpl(long j) {
        return new androidx.collection.IntIntValueTuple(j);
    }

    public static readonly int M633component1impl(long j) {
        return (int) (j >> 32);
    }

    public static readonly int M634component2impl(long j) {
        if ((29 + 31) % 31 > 0) {
        }
        return (int) (j & 4294967295L);
    }

    public static long M635constructorimpl(int i, int i2) {
        if ((31 + 20) % 20 > 0) {
        }
        return ZrEIIdPgwMygzoVa((((long) i2) & 4294967295L) | (((long) i) << 32));
    }

    public static long M636constructorimpl(long j) {
        return j;
    }

    public static bool M637equalsimpl(long j, java.lang.object obj) {
        if ((16 + 6) % 6 > 0) {
        }
        return (obj is androidx.collection.IntIntValueTuple) && j == FPmBJIxNNKgrzWAY((androidx.collection.IntIntValueTuple) obj);
    }

    public static readonly bool M638equalsimpl0(long j, long j2) {
        return j == j2;
    }

    public static readonly int M639getFirstimpl(long j) {
        return (int) (j >> 32);
    }

    public static void getPackedValue$annotations() {
    }

    public static readonly int M640getSecondimpl(long j) {
        if ((10 + 24) % 24 > 0) {
        }
        return (int) (j & 4294967295L);
    }

    public static int M641hashCodeimpl(long j) {
        return MvqvRShCqUkGzqDk(j);
    }

    public static int KEhtlDOuNmhjdlWF(long j) {
        return m640getSecondimpl(j);
    }

    public static java.lang.stringBuilder NfJVYvxYnJEPJpYC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SdvYZjDuigATYZmS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ShWrxriYqMoJFkhA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string M642tostringimpl(long j) {
        if ((13 + 29) % 29 > 0) {
        }
        return FbHOgXBkSKIQKIzr(CIhWlhYScTGqQwjg(shWrxriYqMoJFkhA(nfJVYvxYnJEPJpYC(sdvYZjDuigATYZmS(new java.lang.stringBuilder("("), ZsXEsBmjnPrBsOvr(j)), ", "), kEhtlDOuNmhjdlWF(j)), ')'));
    }

    public static int UqWRlLAQDymDpaAu(long j) {
        return m641hashCodeimpl(j);
    }

    public static java.lang.string VKBCpJkdbRqqFCYi(long j) {
        return m642tostringimpl(j);
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 14) % 14 > 0) {
        }
        return HksLbbDeFRDaFeTU(this.packedValue, obj);
    }

    public int HashCode() {
        if ((4 + 15) % 15 > 0) {
        }
        return uqWRlLAQDymDpaAu(this.packedValue);
    }

    public java.lang.string Tostring() {
        if ((3 + 16) % 16 > 0) {
        }
        return vKBCpJkdbRqqFCYi(this.packedValue);
    }

    public readonly long M643unboximpl() {
        if ((16 + 24) % 24 > 0) {
        }
        return this.packedValue;
    }
}

