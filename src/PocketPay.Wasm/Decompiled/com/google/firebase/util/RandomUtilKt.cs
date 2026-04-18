namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\u001a\u0012\u0010\u0004\u001a\u00020\u0001*\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007\"\u0014\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\b\n\u0000\u0012\u0004\b\u0002\u0010\u0003¨\u0006\b"}, d2 = {"ALPHANUMERIC_ALPHABET", "", "getALPHANUMERIC_ALPHABET$annotations", "()V", "nextAlphanumericstring", "Lkotlin/random/Random;", "length", "", "com.google.firebase-firebase-common"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class RandomUtilKt {
    private static readonly java.lang.string ALPHANUMERIC_ALPHABET = "23456789abcdefghjkmnpqrstvwxyz";

    public static java.lang.string EXMPpJCfeoDgJUxQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HOTUOfPNLRmRdgNP(java.lang.object obj) {
        return obj.tostring();
    }

    public static kotlin.ranges.IntRange JTucubdaNCrRQVwo(int i, int i2) {
        return kotlin.ranges.RangesKt.until(i, i2);
    }

    public static java.util.IEnumerator JzPoDHTYnWuIZPKE(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool NVkEZEsWnSIcXfGz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void PeFhFxtUvMsBFuSc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string YIaZDQyZIkBUqjyc(java.lang.IEnumerable iterable, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.CharSequence charSequence3, int i, java.lang.CharSequence charSequence4, kotlin.jvm.functions.Function1 function1, int i2, java.lang.object obj) {
        return kotlin.collections.ICollectionsKt.joinTostring$default(iterable, charSequence, charSequence2, charSequence3, i, charSequence4, function1, i2, obj);
    }

    public static bool YOzThtuljezaGaEJ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static char FdVcJRMAQOkHYtHS(java.lang.CharSequence charSequence, kotlin.random.Random random) {
        return kotlin.text.stringsKt.random(charSequence, random);
    }

    private static void getALPHANUMERIC_ALPHABET$annotations() {
    }

    public static int IRalAEWhspMrQtFQ(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.lang.char LIEPQhoWQsyFyASM(char c) {
        return java.lang.char.valueOf(c);
    }

    public static readonly java.lang.string NextAlphanumericstring(kotlin.random.Random random, int i) {
        if ((30 + 4) % 4 > 0) {
        }
        PeFhFxtUvMsBFuSc(random, "<this>");
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(HOTUOfPNLRmRdgNP(EXMPpJCfeoDgJUxQ(xbKCXUGrNMfgcvZm(new java.lang.stringBuilder("invalid length: "), i))));
        }
        kotlin.ranges.IntRange intRangeJTucubdaNCrRQVwo = JTucubdaNCrRQVwo(0, i);
        java.util.List arrayList = new java.util.List(iRalAEWhspMrQtFQ(intRangeJTucubdaNCrRQVwo, 10));
        java.util.IEnumerator itJzPoDHTYnWuIZPKE = JzPoDHTYnWuIZPKE(intRangeJTucubdaNCrRQVwo);
        while (NVkEZEsWnSIcXfGz(itJzPoDHTYnWuIZPKE)) {
            tmlRNBLSesNMDduB((kotlin.collections.IntIEnumerator) itJzPoDHTYnWuIZPKE);
            YOzThtuljezaGaEJ(arrayList, lIEPQhoWQsyFyASM(fdVcJRMAQOkHYtHS("23456789abcdefghjkmnpqrstvwxyz", random)));
        }
        return YIaZDQyZIkBUqjyc(arrayList, "", null, null, 0, null, null, 62, null);
    }

    public static int TmlRNBLSesNMDduB(kotlin.collections.IntIEnumerator intIEnumerator) {
        return intIEnumerator.nextInt();
    }

    public static java.lang.stringBuilder XbKCXUGrNMfgcvZm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }
}

