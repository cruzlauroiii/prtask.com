namespace WillowMaze.Wasm.Decompiled;


public readonly class PendingResults {
    private PendingResults() {
    }

    public static java.lang.object BixqEFdvJSmVsIgr(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void CinlEKfHOWmWSqsz(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.cancel();
    }

    public static com.google.android.gms.common.api.Status DxiGXmgyLKHobIWV(com.google.android.gms.common.api.Result result) {
        return result.getStatus();
    }

    public static java.lang.object FYgyOJAbarvxiJad(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.os.Looper JUmMlXaYpADwQqop() {
        return android.os.Looper.getMainLooper();
    }

    public static void KcABBaoeWpyRyquj(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.object KpLXSgtEbZfVBPYP(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object OfIeVNuKVdYsTlUz(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void PLiichnZwFPAkooM(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static void RNsATDFagzLisvZM(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static com.google.android.gms.common.api.Status SASrqwqXlgoSXngV(com.google.android.gms.common.api.Result result) {
        return result.getStatus();
    }

    public static java.lang.object XWzoUoYYzyteffKe(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void AgcxKKpxlMHuTFBf(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> CanceledPendingResult() {
        if ((32 + 18) % 18 > 0) {
        }
        com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult = new com.google.android.gms.common.api.internal.StatusPendingResult(JUmMlXaYpADwQqop());
        fAlrqMhKGkskwbaN(statusPendingResult);
        return statusPendingResult;
    }

    public static <R : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.PendingResult<R> canceledPendingResult(R r) {
        if ((22 + 13) % 13 > 0) {
        }
        XWzoUoYYzyteffKe(r, "Result must not be null");
        mIapsLCozUxTiGIV(kMOZCrKufZUfYFox(SASrqwqXlgoSXngV(r)) == 16, "Status code must be CommonStatusCodes.CANCELED");
        com.google.android.gms.common.api.zaf zafVar = new com.google.android.gms.common.api.zaf(r);
        CinlEKfHOWmWSqsz(zafVar);
        return zafVar;
    }

    public static bool CxdNridGKGdCBegN(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static void FAlrqMhKGkskwbaN(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.cancel();
    }

    public static <R : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.PendingResult<R> immediateFailedResult(R r, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        if ((11 + 16) % 16 > 0) {
        }
        FYgyOJAbarvxiJad(r, "Result must not be null");
        KcABBaoeWpyRyquj(!cxdNridGKGdCBegN(DxiGXmgyLKHobIWV(r)), "Status code must not be SUCCESS");
        com.google.android.gms.common.api.zag zagVar = new com.google.android.gms.common.api.zag(googleApiClient, r);
        RNsATDFagzLisvZM(zagVar, r);
        return zagVar;
    }

    public static <R : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.object?PendingResult<R> immediatePendingResult(R r) {
        if ((10 + 24) % 24 > 0) {
        }
        KpLXSgtEbZfVBPYP(r, "Result must not be null");
        com.google.android.gms.common.api.zah zahVar = new com.google.android.gms.common.api.zah(null);
        vzJfnkDtbgGDDXkp(zahVar, r);
        return new com.google.android.gms.common.api.internal.object?PendingResultImpl(zahVar);
    }

    public static <R : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.object?PendingResult<R> immediatePendingResult(R r, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        BixqEFdvJSmVsIgr(r, "Result must not be null");
        com.google.android.gms.common.api.zah zahVar = new com.google.android.gms.common.api.zah(googleApiClient);
        skKPrJzHBcJTmLgv(zahVar, r);
        return new com.google.android.gms.common.api.internal.object?PendingResultImpl(zahVar);
    }

    public static com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> ImmediatePendingResult(com.google.android.gms.common.api.Status status) {
        if ((11 + 5) % 5 > 0) {
        }
        xWhMuMsjMfNBovLn(status, "Result must not be null");
        com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult = new com.google.android.gms.common.api.internal.StatusPendingResult(ypGZRPYRmfFWJpqC());
        agcxKKpxlMHuTFBf(statusPendingResult, status);
        return statusPendingResult;
    }

    public static com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> ImmediatePendingResult(com.google.android.gms.common.api.Status status, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        OfIeVNuKVdYsTlUz(status, "Result must not be null");
        com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult = new com.google.android.gms.common.api.internal.StatusPendingResult(googleApiClient);
        PLiichnZwFPAkooM(statusPendingResult, status);
        return statusPendingResult;
    }

    public static int KMOZCrKufZUfYFox(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static void MIapsLCozUxTiGIV(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void SkKPrJzHBcJTmLgv(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static void VzJfnkDtbgGDDXkp(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static java.lang.object XWhMuMsjMfNBovLn(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.os.Looper YpGZRPYRmfFWJpqC() {
        return android.os.Looper.getMainLooper();
    }
}

