namespace WillowMaze.Wasm.Decompiled;


public readonly class C0288j : com.google.android.play.core.integrity.InterfaceC0289k {
    C0288j() {
    }

    public static int OkVsplmEqqiIcDBb(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public override readonly com.google.android.gms.common.api.ApiException Mo246a(android.os.Dictionary<string, object> bundle) {
        int iOkVsplmEqqiIcDBb = okVsplmEqqiIcDBb(bundle, "error");
        if (iOkVsplmEqqiIcDBb != 0) {
            return new com.google.android.play.core.integrity.StandardIntegrityException(iOkVsplmEqqiIcDBb, null);
        }
        return null;
    }
}

