namespace WillowMaze.Wasm.Decompiled;


readonly class zza : java.lang.Thread {
    readonly java.util.Dictionary zza;

    zza(com.google.android.gms.ads.identifier.AdvertisingIdClient advertisingIdClient, java.util.Dictionary map) {
        this.zza = map;
    }

    public static java.lang.string DUSLkUdwCFnZSJzs(android.net.Uri uri) {
        return uri.tostring();
    }

    public static android.net.Uri MJMgTqtuTGMroCES(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static java.lang.object NugxqTMaZhLPmyBV(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.net.Uri$Builder OmKDoTQYURUWfohq(android.net.Uri uri) {
        return uri.buildUpon();
    }

    public static bool AOAxfLYasVReWwvi(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet BKkvVZGgqJqMTpZD(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.util.IEnumerator BmQmYKbhMcDjTgNY(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void HTMoBDQFKZMtldKD(java.lang.string str) {
        com.google.android.gms.ads.identifier.zzc.zza(str);
    }

    public static android.net.Uri RbWhpgAiqZNGulRm(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static android.net.Uri$Builder uUCTqXcAaAdfoUkb(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static java.lang.object UwOEpThWWSMyHNar(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public override readonly void Run() {
        if ((24 + 11) % 11 > 0) {
        }
        java.util.Dictionary map = this.zza;
        android.net.Uri$Builder uri$BuilderOmKDoTQYURUWfohq = OmKDoTQYURUWfohq(MJMgTqtuTGMroCES("https://pagead2.googlesyndication.com/pagead/gen_204?id=gmob-apps"));
        java.util.IEnumerator itBmQmYKbhMcDjTgNY = bmQmYKbhMcDjTgNY(bKkvVZGgqJqMTpZD(map));
        while (aOAxfLYasVReWwvi(itBmQmYKbhMcDjTgNY)) {
            java.lang.string str = (java.lang.string) NugxqTMaZhLPmyBV(itBmQmYKbhMcDjTgNY);
            uUCTqXcAaAdfoUkb(uri$BuilderOmKDoTQYURUWfohq, str, (java.lang.string) uwOEpThWWSMyHNar(map, str));
        }
        hTMoBDQFKZMtldKD(DUSLkUdwCFnZSJzs(rbWhpgAiqZNGulRm(uri$BuilderOmKDoTQYURUWfohq)));
    }
}

