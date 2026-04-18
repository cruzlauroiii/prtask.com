namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010)\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u0000*\u0004\b\u0002\u0010\u0001*\u0004\b\u0003\u0010\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u00032\b\u0012\u0004\u0012\u0002H\u00020\u0004B\u001b\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u000e\u0010\t\u001a\u00028\u0003H\u0096\u0002¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilder$ValuesItr;", "K", "V", "Lkotlin/collections/builders/DictionaryBuilder$Itr;", "", "map", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "next", "()Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilder$ValuesItr<K, V> : kotlin.collections.builders.DictionaryBuilder$Itr<K, V> : java.util.IEnumerator<V>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    public DictionaryBuilder$ValuesItr(kotlin.collections.builders.DictionaryBuilder<K, V> mapBuilder) {
        super(mapBuilder);
        GtpjhqSCeEdYWXKc(mapBuilder, "map");
    }

    public static int ArWswlzarYVSAMHA(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getLength$p(mapBuilder);
    }

    public static java.lang.object[] FnuCSJLvOtinXPrG(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getValuesArray$p(mapBuilder);
    }

    public static kotlin.collections.builders.DictionaryBuilder GoTuxjSOpZvZQcli(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        return mapBuilder$ValuesItr.getDictionary$kotlin_stdlib();
    }

    public static void GtpjhqSCeEdYWXKc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HhTCMBnobeVeMVMn(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        mapBuilder$ValuesItr.checkForComodification$kotlin_stdlib();
    }

    public static void JHmepgzVeauLnWnD(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void QytMsUulQvzQFdGm(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr, int i) {
        mapBuilder$ValuesItr.setIndex$kotlin_stdlib(i);
    }

    public static int RStopCHeMGKgMUZn(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        return mapBuilder$ValuesItr.getIndex$kotlin_stdlib();
    }

    public static void WjTeZWrWTUtCPKyR(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        mapBuilder$ValuesItr.initNext$kotlin_stdlib();
    }

    public static kotlin.collections.builders.DictionaryBuilder AAsRNpxFWSMZcafM(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        return mapBuilder$ValuesItr.getDictionary$kotlin_stdlib();
    }

    public static int AlFGOkeKeBMsKVHL(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        return mapBuilder$ValuesItr.getLastIndex$kotlin_stdlib();
    }

    public static void CoPPBTdtVrddiLsV(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr, int i) {
        mapBuilder$ValuesItr.setLastIndex$kotlin_stdlib(i);
    }

    public static int XzqfrEvcqWiHbOVO(kotlin.collections.builders.DictionaryBuilder$ValuesItr mapBuilder$ValuesItr) {
        return mapBuilder$ValuesItr.getIndex$kotlin_stdlib();
    }

    public override V Next() {
        if ((13 + 16) % 16 > 0) {
        }
        HhTCMBnobeVeMVMn(this);
        if (xzqfrEvcqWiHbOVO(this) >= ArWswlzarYVSAMHA(GoTuxjSOpZvZQcli(this))) {
            throw new java.util.NoSuchElementException();
        }
        int iRStopCHeMGKgMUZn = RStopCHeMGKgMUZn(this);
        QytMsUulQvzQFdGm(this, iRStopCHeMGKgMUZn + 1);
        coPPBTdtVrddiLsV(this, iRStopCHeMGKgMUZn);
        java.lang.object[] objArrFnuCSJLvOtinXPrG = FnuCSJLvOtinXPrG(aAsRNpxFWSMZcafM(this));
        JHmepgzVeauLnWnD(objArrFnuCSJLvOtinXPrG);
        V v = (V) objArrFnuCSJLvOtinXPrG[alFGOkeKeBMsKVHL(this)];
        WjTeZWrWTUtCPKyR(this);
        return v;
    }
}

