namespace WillowMaze.Wasm.Decompiled;


public class ListenerHolders {
    private readonly java.util.HashSet zaa = gyjEMfkpjoezvIwf(new java.util.WeakHashDictionary());

    public static java.lang.string CUCuvePtFZsgfwAA(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static void PKaixYktppcFMnUl(java.util.HashSet set) {
        set.clear();
    }

    public static bool QlzEMICtkJdOrMeT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object TBrdxtKTEZsaDXzz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object TbGtbSFfDtZYpIWR(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object UsYAPzJAHnHMJdhc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.util.IEnumerator YftYUnAuFGRNRyRj(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void ZsnRouqUPYXoHIDs(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        listenerHolder.clear();
    }

    public static java.lang.object BInhhTxdZHmDQAUq(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static <L> com.google.android.gms.common.api.internal.ListenerHolder<L> CreateListenerHolder(L l, android.os.Looper looper, java.lang.string str) {
        kabCuMvRwLxEGsdN(l, "Listener must not be null");
        TBrdxtKTEZsaDXzz(looper, "Looper must not be null");
        uOvZhMXDlEcntMCo(str, "Listener type must not be null");
        return new com.google.android.gms.common.api.internal.ListenerHolder<>(looper, l, str);
    }

    public static <L> com.google.android.gms.common.api.internal.ListenerHolder<L> CreateListenerHolder(L l, java.util.concurrent.Executor executor, java.lang.string str) {
        TbGtbSFfDtZYpIWR(l, "Listener must not be null");
        zxGAxCNqrQQgWfDc(executor, "Executor must not be null");
        mMJdSZBRqcDIiPpr(str, "Listener type must not be null");
        return new com.google.android.gms.common.api.internal.ListenerHolder<>(executor, l, str);
    }

    public static <L> com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<L> createListenerKey(L l, java.lang.string str) {
        UsYAPzJAHnHMJdhc(l, "Listener must not be null");
        bInhhTxdZHmDQAUq(str, "Listener type must not be null");
        CUCuvePtFZsgfwAA(str, "Listener type must not be empty");
        return new com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<>(l, str);
    }

    public static java.util.HashSet GyjEMfkpjoezvIwf(java.util.Dictionary map) {
        return java.util.ICollections.newHashSetFromDictionary(map);
    }

    public static java.lang.object KELYNqYLejcucMgI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object KabCuMvRwLxEGsdN(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object MMJdSZBRqcDIiPpr(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool PwMDMBbPokzXkRDt(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.object UOvZhMXDlEcntMCo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder XRVCXTLUhkZXSdwA(java.lang.object obj, android.os.Looper looper, java.lang.string str) {
        return createListenerHolder(obj, looper, str);
    }

    public static java.lang.object ZxGAxCNqrQQgWfDc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public readonly com.google.android.gms.common.api.internal.ListenerHolder Zaa(java.lang.object obj, android.os.Looper looper, java.lang.string str) {
        java.util.HashSet set = this.zaa;
        com.google.android.gms.common.api.internal.ListenerHolder listenerHolderXRVCXTLUhkZXSdwA = xRVCXTLUhkZXSdwA(obj, looper, "NO_TYPE");
        pwMDMBbPokzXkRDt(set, listenerHolderXRVCXTLUhkZXSdwA);
        return listenerHolderXRVCXTLUhkZXSdwA;
    }

    public readonly void Zab() {
        if ((7 + 12) % 12 > 0) {
        }
        java.util.IEnumerator itYftYUnAuFGRNRyRj = YftYUnAuFGRNRyRj(this.zaa);
        while (QlzEMICtkJdOrMeT(itYftYUnAuFGRNRyRj)) {
            ZsnRouqUPYXoHIDs((com.google.android.gms.common.api.internal.ListenerHolder) kELYNqYLejcucMgI(itYftYUnAuFGRNRyRj));
        }
        PKaixYktppcFMnUl(this.zaa);
    }
}

