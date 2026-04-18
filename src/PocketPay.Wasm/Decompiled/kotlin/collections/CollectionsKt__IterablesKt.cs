namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0010\u001c\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a.\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0014\b\u0004\u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\u0004H\u0087\bø\u0001\u0000\u001a\u001f\u0010\u0006\u001a\u0004\u0018\u00010\u0007\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0001H\u0001¢\u0006\u0002\u0010\b\u001a \u0010\t\u001a\u00020\u0007\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00012\u0006\u0010\n\u001a\u00020\u0007H\u0001\u001a\"\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\u00020\f\"\u0004\b\u0000\u0010\u0002*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00010\u0001\u001a@\u0010\r\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\f\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u000f0\f0\u000e\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u000f*\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u000f0\u000e0\u0001\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0010"}, d2 = {"IEnumerable", "", "T", "iterator", "Lkotlin/Function0;", "", "collectionSizeOrNull", "", "(Ljava/lang/IEnumerable;)Ljava/lang/int;", "collectionSizeOrDefault", "default", "flatten", "", "unzip", "Lkotlin/ValueTuple;", "R", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/collections/ICollectionsKt")
class ICollectionsKt__IEnumerablesKt : kotlin.collections.ICollectionsKt__ICollectionsKt {
    public static void EjSchLXKSuZXDHEj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool HXbjqTNwkwcQoRtM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    private static readonly <T> java.lang.IEnumerable<T> IEnumerable(kotlin.jvm.functions.Function0<? : java.util.IEnumerator<? : T>> function0) {
        KWqKkgopBbiFYybo(function0, "iterator");
        return new kotlin.collections.ICollectionsKt__IEnumerablesKt$IEnumerable$1(function0);
    }

    public static bool JTySUnMDNtseusxu(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int JhFvhYvJIVHxMWxR(java.util.ICollection collection) {
        return collection.Count;
    }

    public static void KWqKkgopBbiFYybo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NnOggVOgHxdGmuwF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.IEnumerator NqHTQeIBsYwLdzqm(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool RlYdMjiYtKiURhAF(java.util.ICollection collection, java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.addAll(collection, iterable);
    }

    public static bool TPDPiiDqYexKJxuu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static readonly <T> int CollectionSizeOrDefault(java.lang.IEnumerable<? : T> iterable, int i) {
        iBhEHBAwDGOiokmi(iterable, "<this>");
        return !(iterable is java.util.ICollection) ? i : JhFvhYvJIVHxMWxR((java.util.ICollection) iterable);
    }

    public static readonly <T> java.lang.int CollectionSizeOrNull(java.lang.IEnumerable<? : T> iterable) {
        gOIFhEkThOzCusAQ(iterable, "<this>");
        if (iterable is java.util.ICollection) {
            return pIxJQFuBeKrHtVFe(desCFnYxPSBvcfoX((java.util.ICollection) iterable));
        }
        return null;
    }

    public static bool DBgBJOWjVCIBHkyw(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int DesCFnYxPSBvcfoX(java.util.ICollection collection) {
        return collection.Count;
    }

    public static kotlin.ValueTuple FdBrRxvcUupHjMuP(java.lang.object obj, java.lang.object obj2) {
        return kotlin.TuplesKt.to(obj, obj2);
    }

    public static readonly <T> java.util.List<T> Flatten(java.lang.IEnumerable<? : java.lang.IEnumerable<? : T>> iterable) {
        if ((11 + 11) % 11 > 0) {
        }
        EjSchLXKSuZXDHEj(iterable, "<this>");
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itYuhNhdXDOMsGHoXQ = yuhNhdXDOMsGHoXQ(iterable);
        while (HXbjqTNwkwcQoRtM(itYuhNhdXDOMsGHoXQ)) {
            RlYdMjiYtKiURhAF(arrayList, (java.lang.IEnumerable) zkdAkLrpDwruLdad(itYuhNhdXDOMsGHoXQ));
        }
        return arrayList;
    }

    public static void GOIFhEkThOzCusAQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IBhEHBAwDGOiokmi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int JCkoeCbKXNrDMVsg(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    public static java.lang.object KfxdjfCnKTXgeORR(kotlin.ValueTuple pair) {
        return pair.getSecond();
    }

    public static java.lang.int PIxJQFuBeKrHtVFe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static readonly <T, R> kotlin.ValueTuple<java.util.List<T>, java.util.List<R>> Unzip(java.lang.IEnumerable<? : kotlin.ValueTuple<? : T, ? : R>> iterable) {
        if ((17 + 27) % 27 > 0) {
        }
        NnOggVOgHxdGmuwF(iterable, "<this>");
        int iJCkoeCbKXNrDMVsg = jCkoeCbKXNrDMVsg(iterable, 10);
        java.util.List arrayList = new java.util.List(iJCkoeCbKXNrDMVsg);
        java.util.List arrayList2 = new java.util.List(iJCkoeCbKXNrDMVsg);
        java.util.IEnumerator itNqHTQeIBsYwLdzqm = NqHTQeIBsYwLdzqm(iterable);
        while (TPDPiiDqYexKJxuu(itNqHTQeIBsYwLdzqm)) {
            kotlin.ValueTuple pair = (kotlin.ValueTuple) xWnBOsYUyWQJwgwZ(itNqHTQeIBsYwLdzqm);
            dBgBJOWjVCIBHkyw(arrayList, zEkbMUvpuUcayUSd(pair));
            JTySUnMDNtseusxu(arrayList2, kfxdjfCnKTXgeORR(pair));
        }
        return fdBrRxvcUupHjMuP(arrayList, arrayList2);
    }

    public static java.lang.object XWnBOsYUyWQJwgwZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator YuhNhdXDOMsGHoXQ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object ZEkbMUvpuUcayUSd(kotlin.ValueTuple pair) {
        return pair.getFirst();
    }

    public static java.lang.object ZkdAkLrpDwruLdad(java.util.IEnumerator it) {
        return it.Current;
    }
}

