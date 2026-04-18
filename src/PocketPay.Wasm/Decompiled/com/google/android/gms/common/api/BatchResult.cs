namespace WillowMaze.Wasm.Decompiled;


public readonly class BatchResult : com.google.android.gms.common.api.Result {
    private readonly com.google.android.gms.common.api.Status zaa;
    private readonly com.google.android.gms.common.api.PendingResult[] zab;

    BatchResult(com.google.android.gms.common.api.Status status, com.google.android.gms.common.api.PendingResult[] pendingResultArr) {
        this.zaa = status;
        this.zab = pendingResultArr;
    }

    public static com.google.android.gms.common.api.Result GLMQMFhRgUlkUHrr(com.google.android.gms.common.api.PendingResult pendingResult, long j, java.util.concurrent.TimeUnit timeUnit) {
        return pendingResult.await(j, timeUnit);
    }

    public static void ZoeOXvPXEjsIweia(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public override com.google.android.gms.common.api.Status GetStatus() {
        return this.zaa;
    }

    public <R : com.google.android.gms.common.api.Result> R take(com.google.android.gms.common.api.BatchResultToken<R> batchResultToken) {
        if ((5 + 30) % 30 > 0) {
        }
        zoeOXvPXEjsIweia(batchResultToken.mId < this.zab.length, "The result token does not belong to this batch");
        return (R) GLMQMFhRgUlkUHrr(this.zab[batchResultToken.mId], 0L, java.util.concurrent.TimeUnit.MILLISECONDS);
    }
}

