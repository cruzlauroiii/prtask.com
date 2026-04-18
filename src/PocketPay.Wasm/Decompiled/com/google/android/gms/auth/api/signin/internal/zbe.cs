namespace WillowMaze.Wasm.Decompiled;


public readonly class zbe : com.google.android.gms.common.internal.GmsClient {
    private readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions zba;

    public zbe(android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        super(context, looper, 91, clientHashSettings, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
        if ((5 + 18) % 18 > 0) {
        }
        com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder = googleSignInOptions is null ? new com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder() : new com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder(googleSignInOptions);
        VGBWyqUBzuoaRmZG(googleSignInOptions$Builder, icPGbzJetGjWiDad());
        if (!mUCRtBgBVetbYAiD(EpxmSFwgwLMCGoVt(clientHashSettings))) {
            java.util.IEnumerator itWCnDzwAydFjaSkYH = WCnDzwAydFjaSkYH(JSciCnMrJsnkCfIC(clientHashSettings));
            while (bNxmOIQQJeUPYwme(itWCnDzwAydFjaSkYH)) {
                sJiFVMKyBFBuBJAQ(googleSignInOptions$Builder, (com.google.android.gms.common.api.Scope) JDeLIUfrlIdseiCP(itWCnDzwAydFjaSkYH), new com.google.android.gms.common.api.Scope[0]);
            }
        }
        this.zba = eOiZzabgXRJNMuXz(googleSignInOptions$Builder);
    }

    public static java.util.HashSet EpxmSFwgwLMCGoVt(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getAllRequestedScopes();
    }

    public static java.lang.object JDeLIUfrlIdseiCP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.HashSet JSciCnMrJsnkCfIC(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getAllRequestedScopes();
    }

    public static android.os.IInterface SrzsGodmXZdIEClX(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static android.content.object TWhxGvGbUpoXGXJm(android.content.object context, com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.internal.zbm.zbc(context, googleSignInOptions);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder VGBWyqUBzuoaRmZG(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, java.lang.string str) {
        return googleSignInOptions$Builder.setConsoleSessionId(str);
    }

    public static java.util.IEnumerator WCnDzwAydFjaSkYH(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool BNxmOIQQJeUPYwme(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions EOiZzabgXRJNMuXz(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.build();
    }

    public static java.lang.string IcPGbzJetGjWiDad() {
        return com.google.android.gms.internal.p007authapi.zbas.zba();
    }

    public static android.content.object KGrPshFzpasJnbxw(com.google.android.gms.auth.api.signin.internal.zbe zbeVar) {
        return zbeVar.getobject();
    }

    public static bool MUCRtBgBVetbYAiD(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder sJiFVMKyBFBuBJAQ(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, com.google.android.gms.common.api.Scope scope, com.google.android.gms.common.api.Scope[] scopeArr) {
        return googleSignInOptions$Builder.requestScopes(scope, scopeArr);
    }

    protected override readonly android.os.IInterface CreateServiceInterface(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceSrzsGodmXZdIEClX = SrzsGodmXZdIEClX(iBinder, "com.google.android.gms.auth.api.signin.internal.ISignInService");
        return !(iInterfaceSrzsGodmXZdIEClX is com.google.android.gms.auth.api.signin.internal.zbs) ? new com.google.android.gms.auth.api.signin.internal.zbs(iBinder) : (com.google.android.gms.auth.api.signin.internal.zbs) iInterfaceSrzsGodmXZdIEClX;
    }

    public override readonly int GetMinApkVersion() {
        return 12451000;
    }

    protected override readonly java.lang.string GetServiceDescriptor() {
        return "com.google.android.gms.auth.api.signin.internal.ISignInService";
    }

    public override readonly android.content.object GetSignInobject() {
        return TWhxGvGbUpoXGXJm(kGrPshFzpasJnbxw(this), this.zba);
    }

    protected override readonly java.lang.string GetStartServiceAction() {
        return "com.google.android.gms.auth.api.signin.service.START";
    }

    public override readonly bool ProvidesSignIn() {
        return true;
    }

    public readonly com.google.android.gms.auth.api.signin.GoogleSignInOptions Zba() {
        return this.zba;
    }
}

