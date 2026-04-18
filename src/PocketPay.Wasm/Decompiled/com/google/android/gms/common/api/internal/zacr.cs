namespace WillowMaze.Wasm.Decompiled;


public readonly class zacr : com.google.android.gms.common.api.internal.RemoteCall {
    public readonly com.google.android.gms.common.util.BiConsumer zaa;

    public zacr(com.google.android.gms.common.util.BiConsumer biConsumer) {
        this.zaa = biConsumer;
    }

    public static void IFeyARChlhvwAOMT(com.google.android.gms.common.util.BiConsumer biConsumer, java.lang.object obj, java.lang.object obj2) {
        biConsumer.accept(obj, obj2);
    }

    public override readonly void Accept(java.lang.object obj, java.lang.object obj2) {
        iFeyARChlhvwAOMT(this.zaa, (com.google.android.gms.common.api.Api$AnyClient) obj, (com.google.android.gms.tasks.TaskCompletionSource) obj2);
    }
}

