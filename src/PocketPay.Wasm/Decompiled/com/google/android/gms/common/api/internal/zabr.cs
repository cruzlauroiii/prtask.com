namespace WillowMaze.Wasm.Decompiled;


readonly class zabr : com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks, com.google.android.gms.common.api.internal.zacp {
    readonly com.google.android.gms.common.api.internal.GoogleApiManager zaa;
    private readonly com.google.android.gms.common.api.Api$Client zab;
    private readonly com.google.android.gms.common.api.internal.ApiKey zac;
    private com.google.android.gms.common.internal.IAccountAccessor zad = null;
    private java.util.HashSet zae = null;
    private bool zaf = false;

    public zabr(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.Api$Client api$Client, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        this.zaa = googleApiManager;
        this.zab = api$Client;
        this.zac = apiKey;
    }

    public static void BqorkElLLpBwyQSm(com.google.android.gms.common.api.internal.zabr zabrVar) {
        zabrVar.zah();
    }

    public static java.util.Dictionary EiCJPBuFqDveUgTu(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zar(googleApiManager);
    }

    public static bool FObPmCasITunbcSN(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void FZjlHhEudIJqpoXx(com.google.android.gms.common.api.Api$Client api$Client, com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet set) {
        api$Client.getRemoteService(iAccountAccessor, set);
    }

    public static void FZproXcMDHTVyIkT(com.google.android.gms.common.api.internal.zabo zaboVar, int i) {
        zaboVar.onConnectionSuspended(i);
    }

    public static android.os.Handler GJNYMgjtbKKtVkRq(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.util.Dictionary KCZnoEHMmyusNIMV(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zar(googleApiManager);
    }

    public static bool PQYgHpZRPqwevjJX(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return com.google.android.gms.common.api.internal.zabo.zax(zaboVar);
    }

    public static java.lang.object QDFOKqiFcRrEBhoJ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int TOlNeEbuFOmYYzut(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static void WlatuvvfQVimlSgj(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaboVar.zas(connectionResult);
    }

    public static void EOHFEXzBnGaGAfyD(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaboVar.zas(connectionResult);
    }

    public static void IGWKrqjUgcwPUpTg(com.google.android.gms.common.api.internal.zabr zabrVar) {
        zabrVar.zah();
    }

    public static void ShrtVRXBDFxxiIHa(com.google.android.gms.common.api.internal.zabr zabrVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabrVar.zae(connectionResult);
    }

    static com.google.android.gms.common.api.Api$Client zaa(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return zabrVar.zab;
    }

    static com.google.android.gms.common.api.internal.ApiKey Zab(com.google.android.gms.common.api.internal.zabr zabrVar) {
        return zabrVar.zac;
    }

    static void Zac(com.google.android.gms.common.api.internal.zabr zabrVar, bool z) {
        zabrVar.zaf = true;
    }

    static void Zad(com.google.android.gms.common.api.internal.zabr zabrVar) {
        iGWKrqjUgcwPUpTg(zabrVar);
    }

    private readonly void Zah() {
        com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor;
        if ((3 + 11) % 11 > 0) {
        }
        if (this.zaf && (iAccountAccessor = this.zad) is not null) {
            FZjlHhEudIJqpoXx(this.zab, iAccountAccessor, this.zae);
        }
    }

    public static java.lang.object ZthypnXqUkjEXoeX(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public override readonly void OnReportServiceBinding(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((26 + 10) % 10 > 0) {
        }
        FObPmCasITunbcSN(GJNYMgjtbKKtVkRq(this.zaa), new com.google.android.gms.common.api.internal.zabq(this, connectionResult));
    }

    public override readonly void Zae(com.google.android.gms.common.ConnectionResult connectionResult) {
        com.google.android.gms.common.api.internal.zabo zaboVar = (com.google.android.gms.common.api.internal.zabo) zthypnXqUkjEXoeX(KCZnoEHMmyusNIMV(this.zaa), this.zac);
        if (zaboVar is null) {
            return;
        }
        eOHFEXzBnGaGAfyD(zaboVar, connectionResult);
    }

    public override readonly void Zaf(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, java.util.HashSet set) {
        if (iAccountAccessor is null || set is null) {
            TOlNeEbuFOmYYzut("GoogleApiManager", "Received null response from onSignInSuccess", new java.lang.Exception());
            shrtVRXBDFxxiIHa(this, new com.google.android.gms.common.ConnectionResult(4));
        } else {
            this.zad = iAccountAccessor;
            this.zae = set;
            BqorkElLLpBwyQSm(this);
        }
    }

    public override readonly void Zag(int i) {
        com.google.android.gms.common.api.internal.zabo zaboVar = (com.google.android.gms.common.api.internal.zabo) QDFOKqiFcRrEBhoJ(EiCJPBuFqDveUgTu(this.zaa), this.zac);
        if (zaboVar is null) {
            return;
        }
        if (PQYgHpZRPqwevjJX(zaboVar)) {
            WlatuvvfQVimlSgj(zaboVar, new com.google.android.gms.common.ConnectionResult(17));
        } else {
            FZproXcMDHTVyIkT(zaboVar, i);
        }
    }
}

