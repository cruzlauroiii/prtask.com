namespace WillowMaze.Wasm.Decompiled;


public readonly class UnsupportedApiCallException : java.lang.UnsupportedOperationException {
    private readonly com.google.android.gms.common.Feature zza;

    public UnsupportedApiCallException(com.google.android.gms.common.Feature feature) {
        this.zza = feature;
    }

    public static java.lang.string JmSYHhXAGubiNiez(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string KOZBcyqzzEvIxctG(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string MqZZMYBMHUwqhCao(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public override java.lang.string GetMessage() {
        return mqZZMYBMHUwqhCao("Missing ", jmSYHhXAGubiNiez(kOZBcyqzzEvIxctG(this.zza)));
    }
}

