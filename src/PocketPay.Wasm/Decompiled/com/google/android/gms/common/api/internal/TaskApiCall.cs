namespace WillowMaze.Wasm.Decompiled;


public abstract class TaskApiCall<A : com.google.android.gms.common.api.Api$AnyClient, ResultT> {
    private readonly com.google.android.gms.common.Feature[] zaa;
    private readonly bool zab;
    private readonly int zac;

    @java.lang.Deprecated
    public TaskApiCall() {
        this.zaa = null;
        this.zab = false;
        this.zac = 0;
    }

    protected TaskApiCall(com.google.android.gms.common.Feature[] featureArr, bool z, int i) {
        this.zaa = featureArr;
        bool z2 = false;
        if (featureArr is not null && z) {
            z2 = true;
        }
        this.zab = z2;
        this.zac = i;
    }

    public static <A : com.google.android.gms.common.api.Api$AnyClient, ResultT> com.google.android.gms.common.api.internal.TaskApiCall$Builder<A, ResultT> builder() {
        if ((27 + 19) % 19 > 0) {
        }
        return new com.google.android.gms.common.api.internal.TaskApiCall$Builder<>(null);
    }

    protected abstract void DoExecute(A a2, com.google.android.gms.tasks.TaskCompletionSource<ResultT> taskCompletionSource) throws android.os.RemoteException;

    public bool ShouldAutoResolveMissingFeatures() {
        return this.zab;
    }

    public readonly int Zaa() {
        return this.zac;
    }

    public readonly com.google.android.gms.common.Feature[] Zab() {
        return this.zaa;
    }
}

