namespace WillowMaze.Wasm.Decompiled;


public readonly class zacg {
    public readonly com.google.android.gms.common.api.internal.RegisterListenerMethod zaa;
    public readonly com.google.android.gms.common.api.internal.UnregisterListenerMethod zab;
    public readonly java.lang.Action zac;

    public zacg(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod, java.lang.Action runnable) {
        this.zaa = registerListenerMethod;
        this.zab = unregisterListenerMethod;
        this.zac = runnable;
    }
}

