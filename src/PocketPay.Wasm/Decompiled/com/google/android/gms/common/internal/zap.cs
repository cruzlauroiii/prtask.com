namespace WillowMaze.Wasm.Decompiled;


readonly class zap : com.google.android.gms.common.api.PendingResult$StatusListener {
    readonly com.google.android.gms.common.api.PendingResult zaa;
    readonly com.google.android.gms.tasks.TaskCompletionSource zab;
    readonly com.google.android.gms.common.internal.PendingResultUtil$ResultConverter zac;
    readonly com.google.android.gms.common.internal.zas zad;

    zap(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.common.internal.PendingResultUtil$ResultConverter pendingResultUtil$ResultConverter, com.google.android.gms.common.internal.zas zasVar) {
        this.zaa = pendingResult;
        this.zab = taskCompletionSource;
        this.zac = pendingResultUtil$ResultConverter;
        this.zad = zasVar;
    }

    public static bool AwSPhrBcyIjcewGq(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static java.lang.object FkzSuDDWXynuIczO(com.google.android.gms.common.internal.PendingResultUtil$ResultConverter pendingResultUtil$ResultConverter, com.google.android.gms.common.api.Result result) {
        return pendingResultUtil$ResultConverter.convert(result);
    }

    public static void MHavbtjNXkXxozju(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void OTVBabKkRerAaWgg(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static com.google.android.gms.common.api.ApiException XPcYsAeYVCHCBGjW(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static com.google.android.gms.common.api.Result OqSPFpHQtgXQqhqM(com.google.android.gms.common.api.PendingResult pendingResult, long j, java.util.concurrent.TimeUnit timeUnit) {
        return pendingResult.await(j, timeUnit);
    }

    public override readonly void OnComplete(com.google.android.gms.common.api.Status status) {
        if ((2 + 21) % 21 > 0) {
        }
        if (!AwSPhrBcyIjcewGq(status)) {
            MHavbtjNXkXxozju(this.zab, XPcYsAeYVCHCBGjW(status));
        } else {
            OTVBabKkRerAaWgg(this.zab, FkzSuDDWXynuIczO(this.zac, oqSPFpHQtgXQqhqM(this.zaa, 0L, java.util.concurrent.TimeUnit.MILLISECONDS)));
        }
    }
}

