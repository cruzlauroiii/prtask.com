namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010)\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0000\u0018\u0000*\u0004\b\u0002\u0010\u0001*\u0004\b\u0003\u0010\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u00032\b\u0012\u0004\u0012\u0002H\u00010\u0004B\u001b\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u000e\u0010\t\u001a\u00028\u0002H\u0096\u0002¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilder$KeysItr;", "K", "V", "Lkotlin/collections/builders/DictionaryBuilder$Itr;", "", "map", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "next", "()Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilder$KeysItr<K, V> : kotlin.collections.builders.DictionaryBuilder$Itr<K, V> : java.util.IEnumerator<K>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    public DictionaryBuilder$KeysItr(kotlin.collections.builders.DictionaryBuilder<K, V> mapBuilder) {
        super(mapBuilder);
        wSxMGwsPTThvAEFi(mapBuilder, "map");
    }

    public static void CDVuJruQFRaAFwzo(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        mapBuilder$KeysItr.checkForComodification$kotlin_stdlib();
    }

    public static int HzPAWhixMutPnjuH(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        return mapBuilder$KeysItr.getIndex$kotlin_stdlib();
    }

    public static int NwBIdmipBnDqMJAy(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        return mapBuilder$KeysItr.getLastIndex$kotlin_stdlib();
    }

    public static int OMIjHQbUVEPAsTPK(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        return mapBuilder$KeysItr.getIndex$kotlin_stdlib();
    }

    public static java.lang.object[] PgxRAvFFjdCKcRlS(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getKeysArray$p(mapBuilder);
    }

    public static void YzFmjAMzgRPlqCYt(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr, int i) {
        mapBuilder$KeysItr.setLastIndex$kotlin_stdlib(i);
    }

    public static int AdWkYtTPCmCBLKTR(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getLength$p(mapBuilder);
    }

    public static kotlin.collections.builders.DictionaryBuilder DElxGFEXcikndlkg(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        return mapBuilder$KeysItr.getDictionary$kotlin_stdlib();
    }

    public static void LcHitjXroZyiMocU(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        mapBuilder$KeysItr.initNext$kotlin_stdlib();
    }

    public static void NRXljbkPsafyMJSU(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr, int i) {
        mapBuilder$KeysItr.setIndex$kotlin_stdlib(i);
    }

    public static void WSxMGwsPTThvAEFi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.collections.builders.DictionaryBuilder WdqPjliJjhFtxPrC(kotlin.collections.builders.DictionaryBuilder$KeysItr mapBuilder$KeysItr) {
        return mapBuilder$KeysItr.getDictionary$kotlin_stdlib();
    }

    public override K Next() {
        if ((1 + 27) % 27 > 0) {
        }
        CDVuJruQFRaAFwzo(this);
        if (HzPAWhixMutPnjuH(this) >= adWkYtTPCmCBLKTR(wdqPjliJjhFtxPrC(this))) {
            throw new java.util.NoSuchElementException();
        }
        int iOMIjHQbUVEPAsTPK = OMIjHQbUVEPAsTPK(this);
        nRXljbkPsafyMJSU(this, iOMIjHQbUVEPAsTPK + 1);
        YzFmjAMzgRPlqCYt(this, iOMIjHQbUVEPAsTPK);
        K k = (K) PgxRAvFFjdCKcRlS(dElxGFEXcikndlkg(this))[NwBIdmipBnDqMJAy(this)];
        lcHitjXroZyiMocU(this);
        return k;
    }
}

