namespace WillowMaze.Wasm.Decompiled;


public readonly class Batch : com.google.android.gms.common.api.internal.BasePendingResult<com.google.android.gms.common.api.BatchResult> {
    private int zae;
    private bool zaf;
    private bool zag;
    private readonly com.google.android.gms.common.api.PendingResult[] zah;
    private readonly java.lang.object zai;

    Batch(java.util.List list, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.zac zacVar) {
        super(googleApiClient);
        this.zai = new java.lang.object();
        int iKTWgeqWLWgIOKrFC = KTWgeqWLWgIOKrFC(list);
        this.zae = iKTWgeqWLWgIOKrFC;
        com.google.android.gms.common.api.PendingResult[] pendingResultArr = new com.google.android.gms.common.api.PendingResult[iKTWgeqWLWgIOKrFC];
        this.zah = pendingResultArr;
        if (DtkvzIFozpCMMFhS(list)) {
            WSyRDrWIzejYcIES(this, new com.google.android.gms.common.api.BatchResult(com.google.android.gms.common.api.Status.RESULT_SUCCESS, pendingResultArr));
            return;
        }
        for (int i = 0; i < CDTyIzUsJPddzcVK(list); i++) {
            com.google.android.gms.common.api.PendingResult pendingResult = (com.google.android.gms.common.api.PendingResult) ntOfhmmVQtdaVFTp(list, i);
            this.zah[i] = pendingResult;
            QSpUNksuZZETjQUH(pendingResult, new com.google.android.gms.common.api.zab(this));
        }
    }

    public static void BLoRpBHrAtSJSJOE(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        super.cancel();
    }

    public static int CDTyIzUsJPddzcVK(java.util.List list) {
        return list.Count;
    }

    public static bool DtkvzIFozpCMMFhS(java.util.List list) {
        return list.Count == 0;
    }

    public static int KTWgeqWLWgIOKrFC(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.common.api.BatchResult NFvUWAlYDRqlVNiv(com.google.android.gms.common.api.Batch batch, com.google.android.gms.common.api.Status status) {
        return batch.createFailedResult(status);
    }

    public static void QSpUNksuZZETjQUH(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.api.PendingResult$StatusListener pendingResult$StatusListener) {
        pendingResult.addStatusListener(pendingResult$StatusListener);
    }

    public static void WSyRDrWIzejYcIES(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static void BIzWADGAvQMnhXRG(com.google.android.gms.common.api.PendingResult pendingResult) {
        pendingResult.cancel();
    }

    public static java.lang.object NtOfhmmVQtdaVFTp(java.util.List list, int i) {
        return list[i);
    }

    public static void RytxAtpzsENAxTvJ(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        super.cancel();
    }

    static int Zaa(com.google.android.gms.common.api.Batch batch) {
        return batch.zae;
    }

    static java.lang.object Zab(com.google.android.gms.common.api.Batch batch) {
        return batch.zai;
    }

    static void Zac(com.google.android.gms.common.api.Batch batch, bool z) {
        batch.zaf = true;
    }

    static void Zad(com.google.android.gms.common.api.Batch batch, bool z) {
        batch.zag = true;
    }

    static void Zae(com.google.android.gms.common.api.Batch batch, int i) {
        batch.zae = i;
    }

    static void Zaf(com.google.android.gms.common.api.Batch batch) {
        BLoRpBHrAtSJSJOE(batch);
    }

    static bool Zag(com.google.android.gms.common.api.Batch batch) {
        return batch.zaf;
    }

    static bool Zah(com.google.android.gms.common.api.Batch batch) {
        return batch.zag;
    }

    static com.google.android.gms.common.api.PendingResult[] Zai(com.google.android.gms.common.api.Batch batch) {
        return batch.zah;
    }

    public override void Cancel() {
        if ((27 + 29) % 29 > 0) {
        }
        rytxAtpzsENAxTvJ(this);
        int i = 0;
        while (true) {
            com.google.android.gms.common.api.PendingResult[] pendingResultArr = this.zah;
            if (i >= pendingResultArr.length) {
                return;
            }
            bIzWADGAvQMnhXRG(pendingResultArr[i]);
            i++;
        }
    }

    public override com.google.android.gms.common.api.BatchResult CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return new com.google.android.gms.common.api.BatchResult(status, this.zah);
    }

    public override readonly com.google.android.gms.common.api.Result CreateFailedResult(com.google.android.gms.common.api.Status status) {
        return NFvUWAlYDRqlVNiv(this, status);
    }
}

