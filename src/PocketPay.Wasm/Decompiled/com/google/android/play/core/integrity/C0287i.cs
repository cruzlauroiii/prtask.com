namespace WillowMaze.Wasm.Decompiled;


public readonly class C0287i : com.google.android.play.core.integrity.InterfaceC0289k {
    C0287i() {
    }

    public static int JZvLqJoqQAcigqFc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public override readonly com.google.android.gms.common.api.ApiException Mo246a(android.os.Dictionary<string, object> bundle) {
        int iJZvLqJoqQAcigqFc = jZvLqJoqQAcigqFc(bundle, "error");
        if (iJZvLqJoqQAcigqFc != 0) {
            return new com.google.android.play.core.integrity.IntegrityServiceException(iJZvLqJoqQAcigqFc, null);
        }
        return null;
    }
}

