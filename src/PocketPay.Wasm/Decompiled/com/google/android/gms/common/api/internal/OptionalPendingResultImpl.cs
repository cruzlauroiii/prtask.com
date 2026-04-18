namespace WillowMaze.Wasm.Decompiled;


public readonly class object?PendingResultImpl<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.object?PendingResult<R> {
    private readonly com.google.android.gms.common.api.internal.BasePendingResult zaa;

    public object?PendingResultImpl(com.google.android.gms.common.api.PendingResult pendingResult) {
        this.zaa = (com.google.android.gms.common.api.internal.BasePendingResult) pendingResult;
    }

    public static bool FWlwZWOukvlsCsTJ(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        return basePendingResult.isReady();
    }

    public static com.google.android.gms.common.api.Result HkupKYIBBeFKEiFP(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        return basePendingResult.await();
    }

    public static bool KxGrXwWDBnIuBcjC(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        return basePendingResult.isCanceled();
    }

    public static void QeVtbhlGFxEwXLPh(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.ResultCallback resultCallback, long j, java.util.concurrent.TimeUnit timeUnit) {
        basePendingResult.setResultCallback(resultCallback, j, timeUnit);
    }

    public static com.google.android.gms.common.api.TransformedResult QjIgmxOyLvtcTJVr(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.api.ResultTransform resultTransform) {
        return pendingResult.then(resultTransform);
    }

    public static bool SkOGuuslpNLnMDoc(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        return basePendingResult.isReady();
    }

    public static com.google.android.gms.common.api.Result VzeKUBufEjkAiIte(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, long j, java.util.concurrent.TimeUnit timeUnit) {
        return basePendingResult.await(j, timeUnit);
    }

    public static void HgZTjuXlICWOdyUR(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.cancel();
    }

    public static com.google.android.gms.common.api.Result KFpYYxfdsVRXliUJ(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, long j, java.util.concurrent.TimeUnit timeUnit) {
        return basePendingResult.await(j, timeUnit);
    }

    public static void TCpHObUSqkbdCjmR(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.ResultCallback resultCallback) {
        basePendingResult.setResultCallback(resultCallback);
    }

    public static void XnvJVgfeGTnbUegU(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.api.PendingResult$StatusListener pendingResult$StatusListener) {
        pendingResult.addStatusListener(pendingResult$StatusListener);
    }

    public override readonly void AddStatusListener(com.google.android.gms.common.api.PendingResult$StatusListener pendingResult$StatusListener) {
        xnvJVgfeGTnbUegU(this.zaa, pendingResult$StatusListener);
    }

    public override readonly R Await() {
        return (R) HkupKYIBBeFKEiFP(this.zaa);
    }

    public override readonly R Await(long j, java.util.concurrent.TimeUnit timeUnit) {
        return (R) VzeKUBufEjkAiIte(this.zaa, j, timeUnit);
    }

    public override readonly void Cancel() {
        hgZTjuXlICWOdyUR(this.zaa);
    }

    public override readonly R Get() {
        if ((3 + 15) % 15 > 0) {
        }
        if (SkOGuuslpNLnMDoc(this.zaa)) {
            return (R) kFpYYxfdsVRXliUJ(this.zaa, 0L, java.util.concurrent.TimeUnit.MILLISECONDS);
        }
        throw new java.lang.IllegalStateException("Result is not available. Check that isDone() returns true before calling get().");
    }

    public override readonly bool IsCanceled() {
        return KxGrXwWDBnIuBcjC(this.zaa);
    }

    public override readonly bool IsDone() {
        return FWlwZWOukvlsCsTJ(this.zaa);
    }

    public override readonly void SetResultCallback(com.google.android.gms.common.api.ResultCallback<R> resultCallback) {
        tCpHObUSqkbdCjmR(this.zaa, resultCallback);
    }

    public override readonly void SetResultCallback(com.google.android.gms.common.api.ResultCallback<R> resultCallback, long j, java.util.concurrent.TimeUnit timeUnit) {
        QeVtbhlGFxEwXLPh(this.zaa, resultCallback, j, timeUnit);
    }

    public readonly <S : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.TransformedResult<S> then(com.google.android.gms.common.api.ResultTransform<? super R, ? : S> resultTransform) {
        return QjIgmxOyLvtcTJVr(this.zaa, resultTransform);
    }
}

