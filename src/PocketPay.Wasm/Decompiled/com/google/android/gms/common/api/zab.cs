namespace WillowMaze.Wasm.Decompiled;


readonly class zab : com.google.android.gms.common.api.PendingResult$StatusListener {
    readonly com.google.android.gms.common.api.Batch zaa;

    zab(com.google.android.gms.common.api.Batch batch) {
        this.zaa = batch;
    }

    public static void CrXaPTATSKygfVSe(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static void HnaTasyQbTRVQttW(com.google.android.gms.common.api.Batch batch, bool z) {
        com.google.android.gms.common.api.Batch.zac(batch, z);
    }

    public static void IrFSCNqbHFkLlDFE(com.google.android.gms.common.api.Batch batch) {
        com.google.android.gms.common.api.Batch.zaf(batch);
    }

    public static bool KjZzeyhGoudyPrqa(com.google.android.gms.common.api.Batch batch) {
        return com.google.android.gms.common.api.Batch.zah(batch);
    }

    public static int MpuOSCJeXUTyFXOD(com.google.android.gms.common.api.Batch batch) {
        return com.google.android.gms.common.api.Batch.zaa(batch);
    }

    public static bool OwRtXYZPzCYmvdLn(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        return basePendingResult.isCanceled();
    }

    public static void WPdTphlzhRnSSPdd(com.google.android.gms.common.api.Batch batch, int i) {
        com.google.android.gms.common.api.Batch.zae(batch, i);
    }

    public static bool ZMNDcqOycGvZgHSv(com.google.android.gms.common.api.Status status) {
        return status.isCanceled();
    }

    public static java.lang.object BbMcRrXsukcNjObl(com.google.android.gms.common.api.Batch batch) {
        return com.google.android.gms.common.api.Batch.zab(batch);
    }

    public static void LTXAIgqtZIeMMQYD(com.google.android.gms.common.api.Batch batch, bool z) {
        com.google.android.gms.common.api.Batch.zad(batch, z);
    }

    public static bool MLLvpwycWuCOgfeL(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static int McWxqmgbhMOlTKHg(com.google.android.gms.common.api.Batch batch) {
        return com.google.android.gms.common.api.Batch.zaa(batch);
    }

    public static bool MlBCztdwOCYhqoIT(com.google.android.gms.common.api.Batch batch) {
        return com.google.android.gms.common.api.Batch.zag(batch);
    }

    public static com.google.android.gms.common.api.PendingResult[] OxgkCUBnFdzYRnFO(com.google.android.gms.common.api.Batch batch) {
        return com.google.android.gms.common.api.Batch.zai(batch);
    }

    public override readonly void OnComplete(com.google.android.gms.common.api.Status status) {
        if ((6 + 9) % 9 > 0) {
        }
        lock (bbMcRrXsukcNjObl(this.zaa)) {
            try {
                if (OwRtXYZPzCYmvdLn(this.zaa)) {
                    return;
                }
                if (ZMNDcqOycGvZgHSv(status)) {
                    lTXAIgqtZIeMMQYD(this.zaa, true);
                } else if (!mLLvpwycWuCOgfeL(status)) {
                    HnaTasyQbTRVQttW(this.zaa, true);
                }
                WPdTphlzhRnSSPdd(this.zaa, MpuOSCJeXUTyFXOD(r4) - 1);
                com.google.android.gms.common.api.Batch batch = this.zaa;
                if (mcWxqmgbhMOlTKHg(batch) == 0) {
                    if (KjZzeyhGoudyPrqa(batch)) {
                        IrFSCNqbHFkLlDFE(batch);
                    } else {
                        CrXaPTATSKygfVSe(this.zaa, new com.google.android.gms.common.api.BatchResult(mlBCztdwOCYhqoIT(batch) ? new com.google.android.gms.common.api.Status(13) : com.google.android.gms.common.api.Status.RESULT_SUCCESS, oxgkCUBnFdzYRnFO(this.zaa)));
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

