namespace WillowMaze.Wasm.Decompiled;


readonly class zaak : com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks {
    private readonly java.lang.ref.WeakReference zaa;
    private readonly com.google.android.gms.common.api.Api zab;
    private readonly bool zac;

    public zaak(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.api.Api api, bool z) {
        this.zaa = new java.lang.ref.WeakReference(zaauVar);
        this.zab = api;
        this.zac = z;
    }

    public static bool CAgVctVeMOXcfQYy(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zax(zaauVar);
    }

    public static void FmNssjIMxCPIvwrC(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void HmaFWkNiDJSwMytK(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        com.google.android.gms.common.api.internal.zaau.zat(zaauVar, connectionResult, api, z);
    }

    public static void JXySwwDAbcbFGAFR(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.util.concurrent.locks.Lock MKtsKpnxvvgndrKT(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static java.lang.object TYnjGDbpZvrJzHlb(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.util.concurrent.locks.Lock UgcQMqtPGtqBrWcT(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static void FLYsAlBxeXEcFCqC(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static android.os.Looper JDIueCgfYasgTXbp(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getLooper();
    }

    public static bool KDCLuGWWmLhTHZRR(com.google.android.gms.common.api.internal.zaau zaauVar, int i) {
        return com.google.android.gms.common.api.internal.zaau.zaw(zaauVar, i);
    }

    public static void NTOkCQRbqpWypSjm(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static com.google.android.gms.common.api.internal.zabg PMXXiwtRNAJksQeF(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zak(zaauVar);
    }

    public static java.util.concurrent.locks.Lock RdsojJuvxDKLNkFR(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static void SGudTXNlyDFwFPQY(com.google.android.gms.common.api.internal.zaau zaauVar) {
        com.google.android.gms.common.api.internal.zaau.zau(zaauVar);
    }

    public static android.os.Looper SsLWrrXPMlJyiGwQ() {
        return android.os.Looper.myLooper();
    }

    public static bool VjlDLaYwNJVXsacP(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    static bool Zaa(com.google.android.gms.common.api.internal.zaak zaakVar) {
        return zaakVar.zac;
    }

    public override readonly void OnReportServiceBinding(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((17 + 8) % 8 > 0) {
        }
        com.google.android.gms.common.api.internal.zaau zaauVar = (com.google.android.gms.common.api.internal.zaau) TYnjGDbpZvrJzHlb(this.zaa);
        if (zaauVar is not null) {
            nTOkCQRbqpWypSjm(ssLWrrXPMlJyiGwQ() == jDIueCgfYasgTXbp(pMXXiwtRNAJksQeF(zaauVar).zag), "onReportServiceBinding must be called on the GoogleApiClient handler thread");
            JXySwwDAbcbFGAFR(rdsojJuvxDKLNkFR(zaauVar));
            try {
                if (kDCLuGWWmLhTHZRR(zaauVar, 0)) {
                    if (!vjlDLaYwNJVXsacP(connectionResult)) {
                        HmaFWkNiDJSwMytK(zaauVar, connectionResult, this.zab, this.zac);
                    }
                    if (CAgVctVeMOXcfQYy(zaauVar)) {
                        sGudTXNlyDFwFPQY(zaauVar);
                    }
                }
                fLYsAlBxeXEcFCqC(MKtsKpnxvvgndrKT(zaauVar));
            } catch (java.lang.Exception th) {
                FmNssjIMxCPIvwrC(UgcQMqtPGtqBrWcT(zaauVar));
                throw th;
            }
        }
    }
}

