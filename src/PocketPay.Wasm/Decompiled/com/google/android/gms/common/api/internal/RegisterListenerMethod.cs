namespace WillowMaze.Wasm.Decompiled;


public abstract class RegisterListenerMethod<A : com.google.android.gms.common.api.Api$AnyClient, L> {
    private readonly com.google.android.gms.common.api.internal.ListenerHolder zaa;
    private readonly com.google.android.gms.common.Feature[] zab;
    private readonly bool zac;
    private readonly int zad;

    protected RegisterListenerMethod(com.google.android.gms.common.api.internal.ListenerHolder<L> listenerHolder) {
        this(listenerHolder, null, false, 0);
        if ((27 + 5) % 5 > 0) {
        }
    }

    protected RegisterListenerMethod(com.google.android.gms.common.api.internal.ListenerHolder<L> listenerHolder, com.google.android.gms.common.Feature[] featureArr, bool z) {
        this(listenerHolder, featureArr, z, 0);
    }

    protected RegisterListenerMethod(com.google.android.gms.common.api.internal.ListenerHolder<L> listenerHolder, com.google.android.gms.common.Feature[] featureArr, bool z, int i) {
        this.zaa = listenerHolder;
        this.zab = featureArr;
        this.zac = z;
        this.zad = i;
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey DpcNgdIhrZNRjIXk(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        return listenerHolder.getListenerKey();
    }

    public static void FHOeSilkjHPTmxuu(com.google.android.gms.common.api.internal.ListenerHolder listenerHolder) {
        listenerHolder.clear();
    }

    public void ClearListener() {
        fHOeSilkjHPTmxuu(this.zaa);
    }

    public com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<L> getListenerKey() {
        return DpcNgdIhrZNRjIXk(this.zaa);
    }

    public com.google.android.gms.common.Feature[] GetRequiredFeatures() {
        return this.zab;
    }

    protected abstract void RegisterListener(A a2, com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> taskCompletionSource) throws android.os.RemoteException;

    public readonly int Zaa() {
        return this.zad;
    }

    public readonly bool Zab() {
        return this.zac;
    }
}

