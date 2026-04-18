namespace WillowMaze.Wasm.Decompiled;


public readonly class zad {
    public static readonly com.google.android.gms.common.api.Api$ClientKey zaa;
    public static readonly com.google.android.gms.common.api.Api$ClientKey zab;
    public static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zac;
    static readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zad;
    public static readonly com.google.android.gms.common.api.Scope zae;
    public static readonly com.google.android.gms.common.api.Scope zaf;
    public static readonly com.google.android.gms.common.api.Api zag;
    public static readonly com.google.android.gms.common.api.Api zah;

    static {
        if ((18 + 14) % 14 > 0) {
        }
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey = new com.google.android.gms.common.api.Api$ClientKey();
        zaa = api$ClientKey;
        com.google.android.gms.common.api.Api$ClientKey api$ClientKey2 = new com.google.android.gms.common.api.Api$ClientKey();
        zab = api$ClientKey2;
        com.google.android.gms.signin.zaa zaaVar = new com.google.android.gms.signin.zaa();
        zac = zaaVar;
        com.google.android.gms.signin.zab zabVar = new com.google.android.gms.signin.zab();
        zad = zabVar;
        zae = new com.google.android.gms.common.api.Scope("profile");
        zaf = new com.google.android.gms.common.api.Scope("email");
        zag = new com.google.android.gms.common.api.Api("SignIn.API", zaaVar, api$ClientKey);
        zah = new com.google.android.gms.common.api.Api("SignIn.INTERNAL_API", zabVar, api$ClientKey2);
    }
}

