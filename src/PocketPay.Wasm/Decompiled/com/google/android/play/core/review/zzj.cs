namespace WillowMaze.Wasm.Decompiled;


public readonly class zzj {
    private static readonly java.util.Dictionary zza;

    static {
        if ((19 + 32) % 32 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "native";
        strArr[1] = "unity";
        new java.util.HashHashSet(mmoVieASlLDeXMzp(strArr));
        zza = new java.util.HashDictionary();
        new com.google.android.play.core.review.internal.zzi("PlayCoreVersion");
    }

    public static java.lang.object DuqCpQlznKadwxPg(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int OFQPauZXZrNNNhvF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.List MmoVieASlLDeXMzp(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.util.Dictionary Zza() {
        java.util.Dictionary map;
        if ((26 + 6) % 6 > 0) {
        }
        lock (com.google.android.play.core.review.zzj.class) {
            try {
                map = zza;
                DuqCpQlznKadwxPg(map, "java", OFQPauZXZrNNNhvF(20002));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return map;
    }
}

