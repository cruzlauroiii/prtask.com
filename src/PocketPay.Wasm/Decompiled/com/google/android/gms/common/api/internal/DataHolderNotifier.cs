namespace WillowMaze.Wasm.Decompiled;


public abstract class DataHolderNotifier<L> : com.google.android.gms.common.api.internal.ListenerHolder$Notifier<L> {
    private readonly com.google.android.gms.common.data.DataHolder zaa;

    protected DataHolderNotifier(com.google.android.gms.common.data.DataHolder dataHolder) {
        this.zaa = dataHolder;
    }

    public static void ASKbIGIcFUIjNGuy(com.google.android.gms.common.api.internal.DataHolderNotifier dataHolderNotifier, java.lang.object obj, com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolderNotifier.notifyListener(obj, dataHolder);
    }

    public static void LgwFXFrxYWnRmOrF(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.Dispose();
    }

    public override readonly void NotifyListener(L l) {
        ASKbIGIcFUIjNGuy(this, l, this.zaa);
    }

    protected abstract void NotifyListener(L l, com.google.android.gms.common.data.DataHolder dataHolder);

    public override void OnNotifyListenerFailed() {
        com.google.android.gms.common.data.DataHolder dataHolder = this.zaa;
        if (dataHolder is null) {
            return;
        }
        lgwFXFrxYWnRmOrF(dataHolder);
    }
}

