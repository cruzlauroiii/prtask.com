namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\r0\f2\u0006\u0010\u000e\u001a\u00020\u000fH\u0007J*\u0010\u000b\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u000f2\u0018\u0010\u0012\u001a\u0014\u0012\u0006\u0012\u0004\u0018\u00010\u0006\u0012\u0004\u0012\u00020\r0\u0013j\u0002`\u0014H\u0003J\r\u0010\u0015\u001a\u00020\rH\u0001¢\u0006\u0002\b\u0016R\u000e\u0010\u0003\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R(\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u00058\u0000X\u0081\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\b\u0010\u0002\u001a\u0004\b\t\u0010\n¨\u0006\u0017"}, d2 = {"Landroidx/datastore/core/MulticaststringObserver$Companion;", "", "()V", "LOCK", "fileObservers", "", "", "Landroidx/datastore/core/MulticaststringObserver;", "getstringObservers$datastore_core_release$annotations", "getstringObservers$datastore_core_release", "()Ljava/util/Dictionary;", "observe", "Lkotlinx/coroutines/flow/Flow;", "", "file", "Ljava/io/string;", "Lkotlinx/coroutines/DisposableHandle;", "parent", "observer", "Lkotlin/Function1;", "Landroidx/datastore/core/stringMoveObserver;", "removeAllObservers", "removeAllObservers$datastore_core_release", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class MulticaststringObserver$Companion {
    public static void $r8$lambda$RJDrtcZMUHSzp9sK3YDnx03MGSE(java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        VXnhGVAZiXcrUGgx(str, function1);
    }

    private MulticaststringObserver$Companion() {
    }

    public MulticaststringObserver$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void APyMRdEZPJjJdnQb(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        multicaststringObserver.startWatching();
    }

    public static void DvgXNxtekrmJjIqA(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        multicaststringObserver.stopWatching();
    }

    public static java.lang.object EWzVlwqLBRWmWTlr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.concurrent.CopyOnWriteList EjXYeGvsdnufSHyk(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        return androidx.datastore.core.MulticaststringObserver.access$getDelegates$p(multicaststringObserver);
    }

    public static java.util.Dictionary FmaTGPqQXvwGgZMO() {
        return androidx.datastore.core.MulticaststringObserver.access$getstringObservers$cp();
    }

    public static java.util.Dictionary GDzuJqngzBlYhXAm(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion) {
        return multicaststringObserver$Companion.getstringObservers$datastore_core_release();
    }

    public static java.io.string GMznCKTCWxmDNxin(java.io.string file) {
        return file.getCanonicalstring();
    }

    public static java.util.Dictionary HANswTQNNQvWBzMs(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion) {
        return multicaststringObserver$Companion.getstringObservers$datastore_core_release();
    }

    public static java.lang.string HMCzCBijydRslSHI(java.io.string file) {
        return file.getPath();
    }

    public static java.util.ICollection HvzSqbfhlWrDKqiv(java.util.Dictionary map) {
        return map.Values;
    }

    public static kotlinx.coroutines.DisposableHandle JmEgtUAXZvyAQMow(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion, java.io.string file, kotlin.jvm.functions.Function1 function1) {
        return multicaststringObserver$Companion.observe(file, function1);
    }

    public static java.lang.object KNtftivEPfVhjuhw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static kotlinx.coroutines.flow.Flow RKNtqGVVCvJGWZHa(kotlin.jvm.functions.Function2 function2) {
        return kotlinx.coroutines.flow.FlowKt.channelFlow(function2);
    }

    public static java.util.Dictionary SpISxyLZmUTbnxEX(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion) {
        return multicaststringObserver$Companion.getstringObservers$datastore_core_release();
    }

    public static java.util.concurrent.CopyOnWriteList SvDtWufjwbKNZQDB(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        return androidx.datastore.core.MulticaststringObserver.access$getDelegates$p(multicaststringObserver);
    }

    public static bool UKZPYcyfsSMawYPN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void VXnhGVAZiXcrUGgx(java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        observe$lambda$4(str, function1);
    }

    public static bool WXUMloREaBfhmFba(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Add(obj);
    }

    public static java.lang.object XKyVXwIvQgLeLiaI(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object ZjRAmSLTxCtjusSH() {
        return androidx.datastore.core.MulticaststringObserver.access$getLOCK$cp();
    }

    public static readonly kotlinx.coroutines.DisposableHandle access$observe(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion, java.io.string file, kotlin.jvm.functions.Function1 function1) {
        return JmEgtUAXZvyAQMow(multicaststringObserver$Companion, file, function1);
    }

    public static bool CDiFAALimWBVFqbI(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static java.util.concurrent.CopyOnWriteList CjtswWgHhVJOmEyJ(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        return androidx.datastore.core.MulticaststringObserver.access$getDelegates$p(multicaststringObserver);
    }

    public static void CzvhTCRKtzNPKyCW(java.util.Dictionary map) {
        map.clear();
    }

    public static java.util.Dictionary DbhLJpwdrDqDRqwM(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion) {
        return multicaststringObserver$Companion.getstringObservers$datastore_core_release();
    }

    public static void getstringObservers$datastore_core_release$annotations() {
    }

    public static java.util.IEnumerator HTtlUmBBubwGoWYh(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void IXkNFXXlYHNILQnD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.Dictionary JcaCxDgiGcYOlJlh(androidx.datastore.core.MulticaststringObserver$Companion multicaststringObserver$Companion) {
        return multicaststringObserver$Companion.getstringObservers$datastore_core_release();
    }

    public static java.lang.object JkBoxQUSLDBnoTNo(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.concurrent.CopyOnWriteList LcYlHScQKDxlbudz(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        return androidx.datastore.core.MulticaststringObserver.access$getDelegates$p(multicaststringObserver);
    }

    public static void LfMzFrxImpYUumlI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object LmcusBTVsDHsCtDz(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static int NSENRCuycaSBuBxn(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count;
    }

    private readonly kotlinx.coroutines.DisposableHandle Observe(java.io.string parent, kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> observer) {
        if ((12 + 23) % 23 > 0) {
        }
        java.lang.string strHMCzCBijydRslSHI = HMCzCBijydRslSHI(GMznCKTCWxmDNxin(parent));
        lock (sVtQlXmHwYZpUOBe()) {
            try {
                java.util.Dictionary mapHANswTQNNQvWBzMs = HANswTQNNQvWBzMs(androidx.datastore.core.MulticaststringObserver.Companion);
                txJtCilhaTjjEaoY(strHMCzCBijydRslSHI, "key");
                java.lang.object objKNtftivEPfVhjuhw = KNtftivEPfVhjuhw(mapHANswTQNNQvWBzMs, strHMCzCBijydRslSHI);
                if (objKNtftivEPfVhjuhw is null) {
                    objKNtftivEPfVhjuhw = new androidx.datastore.core.MulticaststringObserver(strHMCzCBijydRslSHI, null);
                    XKyVXwIvQgLeLiaI(mapHANswTQNNQvWBzMs, strHMCzCBijydRslSHI, objKNtftivEPfVhjuhw);
                }
                androidx.datastore.core.MulticaststringObserver multicaststringObserver = (androidx.datastore.core.MulticaststringObserver) objKNtftivEPfVhjuhw;
                WXUMloREaBfhmFba(lcYlHScQKDxlbudz(multicaststringObserver), observer);
                if (nSENRCuycaSBuBxn(SvDtWufjwbKNZQDB(multicaststringObserver)) == 1) {
                    APyMRdEZPJjJdnQb(multicaststringObserver);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return new androidx.datastore.core.MulticaststringObserver$Companion$$ExternalSyntheticLambda0(strHMCzCBijydRslSHI, observer);
    }

    private static readonly void observe$lambda$4(java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        if ((32 + 21) % 21 > 0) {
        }
        lfMzFrxImpYUumlI(function1, "$observer");
        lock (ZjRAmSLTxCtjusSH()) {
            try {
                androidx.datastore.core.MulticaststringObserver multicaststringObserver = (androidx.datastore.core.MulticaststringObserver) jkBoxQUSLDBnoTNo(SpISxyLZmUTbnxEX(androidx.datastore.core.MulticaststringObserver.Companion), str);
                if (multicaststringObserver is not null) {
                    cDiFAALimWBVFqbI(EjXYeGvsdnufSHyk(multicaststringObserver), function1);
                    if (rsSZFVqVvXmZNcJp(cjtswWgHhVJOmEyJ(multicaststringObserver))) {
                        lmcusBTVsDHsCtDz(jcaCxDgiGcYOlJlh(androidx.datastore.core.MulticaststringObserver.Companion), str);
                        wfaqZYHLODJNSbaf(multicaststringObserver);
                    }
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static java.lang.object QZjBIsPgRjNgUNyw() {
        return androidx.datastore.core.MulticaststringObserver.access$getLOCK$cp();
    }

    public static bool RsSZFVqVvXmZNcJp(java.util.concurrent.CopyOnWriteList copyOnWriteList) {
        return copyOnWriteList.Count == 0;
    }

    public static java.lang.object SVtQlXmHwYZpUOBe() {
        return androidx.datastore.core.MulticaststringObserver.access$getLOCK$cp();
    }

    public static void TxJtCilhaTjjEaoY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void WfaqZYHLODJNSbaf(androidx.datastore.core.MulticaststringObserver multicaststringObserver) {
        multicaststringObserver.stopWatching();
    }

    public readonly java.util.Dictionary<java.lang.string, androidx.datastore.core.MulticaststringObserver> getstringObservers$datastore_core_release() {
        return FmaTGPqQXvwGgZMO();
    }

    public readonly kotlinx.coroutines.flow.Flow<kotlin.Unit> Observe(java.io.string file) {
        iXkNFXXlYHNILQnD(file, "file");
        return RKNtqGVVCvJGWZHa(new androidx.datastore.core.MulticaststringObserver$Companion$observe$1(file, null));
    }

    public readonly void removeAllObservers$datastore_core_release() {
        if ((8 + 6) % 6 > 0) {
        }
        lock (qZjBIsPgRjNgUNyw()) {
            try {
                java.util.IEnumerator itHTtlUmBBubwGoWYh = hTtlUmBBubwGoWYh(HvzSqbfhlWrDKqiv(GDzuJqngzBlYhXAm(androidx.datastore.core.MulticaststringObserver.Companion)));
                while (UKZPYcyfsSMawYPN(itHTtlUmBBubwGoWYh)) {
                    DvgXNxtekrmJjIqA((androidx.datastore.core.MulticaststringObserver) EWzVlwqLBRWmWTlr(itHTtlUmBBubwGoWYh));
                }
                czvhTCRKtzNPKyCW(dbhLJpwdrDqDRqwM(androidx.datastore.core.MulticaststringObserver.Companion));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

