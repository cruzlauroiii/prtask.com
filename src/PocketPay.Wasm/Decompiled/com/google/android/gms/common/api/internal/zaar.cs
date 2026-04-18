namespace WillowMaze.Wasm.Decompiled;


readonly class zaar : com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener {
    readonly com.google.android.gms.common.api.internal.zaau zaa;

    zaar(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.api.internal.zaat zaatVar) {
        this.zaa = zaauVar;
    }

    public static java.util.concurrent.locks.Lock BvUwlyBeOhhAWDnt(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static void DerLjMiPSTdNkKYx(com.google.android.gms.common.api.internal.zaau zaauVar) {
        com.google.android.gms.common.api.internal.zaau.zau(zaauVar);
    }

    public static java.lang.object EIButlPyIXpCRhEb(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void FVHOHtLeShiYYvLe(com.google.android.gms.common.api.internal.zaau zaauVar) {
        com.google.android.gms.common.api.internal.zaau.zaq(zaauVar);
    }

    public static void JwFjCmeAPfwqkvYr(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.object LPJwsoJCfrfwANPy(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.signin.zae MJkFWQWCRfWMqqEm(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zan(zaauVar);
    }

    public static void XsZWBdSNZTtTLDZd(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void ZVfahWvpEjiDjMnU(com.google.android.gms.signin.zae zaeVar, com.google.android.gms.signin.internal.zae zaeVar2) {
        zaeVar.zad(zaeVar2);
    }

    public static bool ANioXrxiUglrDwDl(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        return com.google.android.gms.common.api.internal.zaau.zay(zaauVar, connectionResult);
    }

    public static java.util.concurrent.locks.Lock DolmedQcyQSJTbrF(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static void EpdRuRlZhLwNCCzB(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        com.google.android.gms.common.api.internal.zaau.zas(zaauVar, connectionResult);
    }

    public static void FRzGcszhdORkOcAJ(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.concurrent.locks.Lock OUICOcmLVypQIVGv(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zap(zaauVar);
    }

    public static com.google.android.gms.common.internal.ClientHashSettings WSZPScNBCGnOZSkX(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return com.google.android.gms.common.api.internal.zaau.zal(zaauVar);
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        ZVfahWvpEjiDjMnU((com.google.android.gms.signin.zae) EIButlPyIXpCRhEb(MJkFWQWCRfWMqqEm(this.zaa)), new com.google.android.gms.common.api.internal.zaaq(this.zaa));
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        JwFjCmeAPfwqkvYr(BvUwlyBeOhhAWDnt(this.zaa));
        try {
            if (aNioXrxiUglrDwDl(this.zaa, connectionResult)) {
                FVHOHtLeShiYYvLe(this.zaa);
                DerLjMiPSTdNkKYx(this.zaa);
            } else {
                epdRuRlZhLwNCCzB(this.zaa, connectionResult);
            }
            XsZWBdSNZTtTLDZd(oUICOcmLVypQIVGv(this.zaa));
        } catch (java.lang.Exception th) {
            fRzGcszhdORkOcAJ(dolmedQcyQSJTbrF(this.zaa));
            throw th;
        }
    }

    public override readonly void OnConnectionSuspended(int i) {
    }
}

