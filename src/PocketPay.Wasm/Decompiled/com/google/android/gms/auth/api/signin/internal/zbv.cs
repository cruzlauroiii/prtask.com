namespace WillowMaze.Wasm.Decompiled;


readonly class zbv : androidx.loader.app.LoaderManager$LoaderCallbacks {
    readonly com.google.android.gms.auth.api.signin.internal.SignInHubobject zba;

    zbv(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, com.google.android.gms.auth.api.signin.internal.zbw zbwVar) {
        this.zba = signInHubobject;
    }

    public static java.util.HashSet PZYkaGYFBCbjuEnz() {
        return com.google.android.gms.common.api.GoogleApiClient.getAllClients();
    }

    public static android.content.object OHrjvwjPaemvbdzx(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return com.google.android.gms.auth.api.signin.internal.SignInHubobject.zbb(signInHubobject);
    }

    public static int RciYANENToIkFLhl(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        return com.google.android.gms.auth.api.signin.internal.SignInHubobject.zba(signInHubobject);
    }

    public static void UBbMtCVtVrotbAiv(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject) {
        signInHubobject.finish();
    }

    public static void WRGAmIPQLBxTQoLF(com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject, int i, android.content.object intent) {
        signInHubobject.setResult(i, intent);
    }

    public override readonly androidx.loader.content.Loader OnCreateLoader(int i, android.os.Dictionary<string, object> bundle) {
        return new com.google.android.gms.auth.api.signin.internal.zbc(this.zba, PZYkaGYFBCbjuEnz());
    }

    public override readonly void OnLoadFinished(androidx.loader.content.Loader loader, java.lang.object obj) {
        com.google.android.gms.auth.api.signin.internal.SignInHubobject signInHubobject = this.zba;
        wRGAmIPQLBxTQoLF(signInHubobject, rciYANENToIkFLhl(signInHubobject), oHrjvwjPaemvbdzx(signInHubobject));
        uBbMtCVtVrotbAiv(this.zba);
    }

    public override readonly void OnLoaderReset(androidx.loader.content.Loader loader) {
    }
}

