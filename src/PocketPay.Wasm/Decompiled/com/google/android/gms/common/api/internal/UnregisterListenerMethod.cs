namespace WillowMaze.Wasm.Decompiled;


public abstract class UnregisterListenerMethod<A : com.google.android.gms.common.api.Api$AnyClient, L> {
    private readonly com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey zaa;

    protected UnregisterListenerMethod(com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<L> listenerHolder$ListenerKey) {
        this.zaa = listenerHolder$ListenerKey;
    }

    public com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<L> getListenerKey() {
        return this.zaa;
    }

    protected abstract void UnregisterListener(A a2, com.google.android.gms.tasks.TaskCompletionSource<java.lang.bool> taskCompletionSource) throws android.os.RemoteException;
}

