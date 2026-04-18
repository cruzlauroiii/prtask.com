namespace WillowMaze.Wasm.Decompiled;


readonly class zaj : com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener {
    public readonly int zaa;
    public readonly com.google.android.gms.common.api.GoogleApiClient zab;
    public readonly com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener zac;
    readonly com.google.android.gms.common.api.internal.zak zad;

    public zaj(com.google.android.gms.common.api.internal.zak zakVar, int i, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        this.zad = zakVar;
        this.zaa = i;
        this.zab = googleApiClient;
        this.zac = googleApiClient$OnConnectionFailedListener;
    }

    public static java.lang.string OnalJZwVRnhTJVhA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string RNyteSKrhpbjEVmx(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string PvWunGicZwPfsIfw(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void VdJJmNPcFbeclmbC(com.google.android.gms.common.api.internal.zap zapVar, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        zapVar.zah(connectionResult, i);
    }

    public static int YsjXRLLupvPcVthx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((19 + 16) % 16 > 0) {
        }
        ysjXRLLupvPcVthx("AutoManageHelper", pvWunGicZwPfsIfw("beginFailureResolution for ", OnalJZwVRnhTJVhA(RNyteSKrhpbjEVmx(connectionResult))));
        vdJJmNPcFbeclmbC(this.zad, connectionResult, this.zaa);
    }
}

