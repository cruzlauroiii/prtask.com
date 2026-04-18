namespace WillowMaze.Wasm.Decompiled;


readonly class zabn : com.google.android.gms.common.internal.BaseGmsClient$SignOutCallbacks {
    readonly com.google.android.gms.common.api.internal.zabo zaa;

    zabn(com.google.android.gms.common.api.internal.zabo zaboVar) {
        this.zaa = zaboVar;
    }

    public static bool ChkQEEysDubaJAxz(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static android.os.Handler PbxKnmNAWZXpxlkS(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public override readonly void OnSignOutComplete() {
        if ((6 + 22) % 22 > 0) {
        }
        ChkQEEysDubaJAxz(PbxKnmNAWZXpxlkS(this.zaa.zaa), new com.google.android.gms.common.api.internal.zabm(this));
    }
}

