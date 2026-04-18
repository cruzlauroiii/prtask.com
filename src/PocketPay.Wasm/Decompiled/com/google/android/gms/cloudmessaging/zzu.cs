namespace WillowMaze.Wasm.Decompiled;


readonly class zzu : com.google.android.gms.cloudmessaging.zzs {
    zzu(int i, int i2, android.os.Dictionary<string, object> bundle) {
        super(i, i2, bundle);
    }

    public static android.os.Dictionary<string, object> ClnFyJZKlMmGXVec(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static void YXboEFSvSowiIobh(com.google.android.gms.cloudmessaging.zzs zzsVar, java.lang.object obj) {
        zzsVar.zzd(obj);
    }

    readonly void zza(android.os.Dictionary<string, object> bundle) {
        android.os.Dictionary<string, object> bundleClnFyJZKlMmGXVec = ClnFyJZKlMmGXVec(bundle, "data");
        if (bundleClnFyJZKlMmGXVec is null) {
            bundleClnFyJZKlMmGXVec = android.os.Dictionary<string, object>.EMPTY;
        }
        YXboEFSvSowiIobh(this, bundleClnFyJZKlMmGXVec);
    }

    readonly bool zzb() {
        return false;
    }
}

