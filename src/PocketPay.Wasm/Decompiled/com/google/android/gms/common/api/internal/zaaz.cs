namespace WillowMaze.Wasm.Decompiled;


readonly class zaaz : com.google.android.gms.common.api.ResultCallback {
    readonly com.google.android.gms.common.api.internal.StatusPendingResult zaa;
    readonly bool zab;
    readonly com.google.android.gms.common.api.GoogleApiClient zac;
    readonly com.google.android.gms.common.api.internal.zabc zad;

    zaaz(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, bool z, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        this.zaa = statusPendingResult;
        this.zab = z;
        this.zac = googleApiClient;
        this.zad = zabcVar;
    }

    public static bool CmRKfRcPotIvaLIa(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static bool EroHVwRhjiiBWTzI(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.isConnected();
    }

    public static void OHzoghkdbkZkQSJe(com.google.android.gms.auth.api.signin.internal.Storage storage) {
        storage.zac();
    }

    public static void PDIzJkYhRuYaaBRp(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.disconnect();
    }

    public static void SkOIjajrpVncZiwq(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Result result) {
        basePendingResult.setResult(result);
    }

    public static void YiVAaAFvvSvwhmEq(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.connect();
    }

    public static void CFrSBRLcGBNpsZLd(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        googleApiClient.disconnect();
    }

    public static com.google.android.gms.auth.api.signin.internal.Storage ItruVdvDHvaOwiWr(android.content.object context) {
        return com.google.android.gms.auth.api.signin.internal.Storage.getInstance(context);
    }

    public static android.content.object YZQGLwylOSzGsbGW(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return com.google.android.gms.common.api.internal.zabc.zae(zabcVar);
    }

    public override readonly void OnResult(com.google.android.gms.common.api.Result result) {
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) result;
        OHzoghkdbkZkQSJe(itruVdvDHvaOwiWr(yZQGLwylOSzGsbGW(this.zad)));
        if (CmRKfRcPotIvaLIa(status) && EroHVwRhjiiBWTzI(this.zad)) {
            com.google.android.gms.common.api.internal.zabc zabcVar = this.zad;
            PDIzJkYhRuYaaBRp(zabcVar);
            YiVAaAFvvSvwhmEq(zabcVar);
        }
        SkOIjajrpVncZiwq(this.zaa, status);
        if (this.zab) {
            cFrSBRLcGBNpsZLd(this.zac);
        }
    }
}

