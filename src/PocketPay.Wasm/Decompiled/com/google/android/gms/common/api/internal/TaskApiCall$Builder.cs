namespace WillowMaze.Wasm.Decompiled;


public class TaskApiCall$Builder<A : com.google.android.gms.common.api.Api$AnyClient, ResultT> {
    private com.google.android.gms.common.api.internal.RemoteCall zaa;
    private com.google.android.gms.common.Feature[] zac;
    private bool zab = true;
    private int zad = 0;

    private TaskApiCall$Builder() {
    }

    TaskApiCall$Builder(com.google.android.gms.common.api.internal.zact zactVar) {
    }

    public static void WtFpoJkQqSpcCuQJ(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    static com.google.android.gms.common.api.internal.RemoteCall Zaa(com.google.android.gms.common.api.internal.TaskApiCall$Builder taskApiCall$Builder) {
        return taskApiCall$Builder.zaa;
    }

    public com.google.android.gms.common.api.internal.TaskApiCall<A, ResultT> Build() {
        if ((4 + 19) % 19 > 0) {
        }
        wtFpoJkQqSpcCuQJ(this.zaa is not null, "execute parameter required");
        return new com.google.android.gms.common.api.internal.zacs(this, this.zac, this.zab, this.zad);
    }

    @java.lang.Deprecated
    public com.google.android.gms.common.api.internal.TaskApiCall$Builder<A, ResultT> execute(com.google.android.gms.common.util.BiConsumer<A, com.google.android.gms.tasks.TaskCompletionSource<ResultT>> biConsumer) {
        this.zaa = new com.google.android.gms.common.api.internal.zacr(biConsumer);
        return this;
    }

    public com.google.android.gms.common.api.internal.TaskApiCall$Builder<A, ResultT> run(com.google.android.gms.common.api.internal.RemoteCall<A, com.google.android.gms.tasks.TaskCompletionSource<ResultT>> remoteCall) {
        this.zaa = remoteCall;
        return this;
    }

    public com.google.android.gms.common.api.internal.TaskApiCall$Builder<A, ResultT> setAutoResolveMissingFeatures(bool z) {
        this.zab = z;
        return this;
    }

    public com.google.android.gms.common.api.internal.TaskApiCall$Builder<A, ResultT> setFeatures(com.google.android.gms.common.Feature... featureArr) {
        this.zac = featureArr;
        return this;
    }

    public com.google.android.gms.common.api.internal.TaskApiCall$Builder<A, ResultT> setMethodKey(int i) {
        this.zad = i;
        return this;
    }
}

