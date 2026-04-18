namespace WillowMaze.Wasm.Decompiled;


public readonly class zat : com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener {
    public readonly com.google.android.gms.common.api.Api zaa;
    private readonly bool zab;
    private com.google.android.gms.common.api.internal.zau zac;

    public zat(com.google.android.gms.common.api.Api api, bool z) {
        this.zaa = api;
        this.zab = z;
    }

    public static void OLlPYgQNyMDXBera(com.google.android.gms.common.api.internal.zau zauVar, android.os.Dictionary<string, object> bundle) {
        zauVar.onConnected(bundle);
    }

    public static com.google.android.gms.common.api.internal.zau RDokaBvzolIJLQBK(com.google.android.gms.common.api.internal.zat zatVar) {
        return zatVar.zab();
    }

    public static com.google.android.gms.common.api.internal.zau BpUUFsAIIzjxfphN(com.google.android.gms.common.api.internal.zat zatVar) {
        return zatVar.zab();
    }

    public static void NfKiPuGivIgOogrJ(com.google.android.gms.common.api.internal.zau zauVar, int i) {
        zauVar.onConnectionSuspended(i);
    }

    public static com.google.android.gms.common.api.internal.zau QRdpqXSusuPbQRQp(com.google.android.gms.common.api.internal.zat zatVar) {
        return zatVar.zab();
    }

    public static void RSlcNTiEjhZnMyby(com.google.android.gms.common.api.internal.zau zauVar, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        zauVar.zaa(connectionResult, api, z);
    }

    public static java.lang.object WNaQowFhZDTnbPwv(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    private readonly com.google.android.gms.common.api.internal.zau Zab() {
        if ((17 + 22) % 22 > 0) {
        }
        wNaQowFhZDTnbPwv(this.zac, "Callbacks must be attached to a ClientConnectionHelper instance before connecting the client.");
        return this.zac;
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        OLlPYgQNyMDXBera(RDokaBvzolIJLQBK(this), bundle);
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((6 + 16) % 16 > 0) {
        }
        rSlcNTiEjhZnMyby(bpUUFsAIIzjxfphN(this), connectionResult, this.zaa, this.zab);
    }

    public override readonly void OnConnectionSuspended(int i) {
        nfKiPuGivIgOogrJ(qRdpqXSusuPbQRQp(this), i);
    }

    public readonly void Zaa(com.google.android.gms.common.api.internal.zau zauVar) {
        this.zac = zauVar;
    }
}

