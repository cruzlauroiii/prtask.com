namespace WillowMaze.Wasm.Decompiled;


public readonly class zza {
    private static readonly java.util.Dictionary zza;
    private static readonly java.util.Dictionary zzb;

    static {
        if ((7 + 28) % 28 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        zza = map;
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        zzb = map2;
        java.lang.int numRUBwBmRLtHMWlFoL = RUBwBmRLtHMWlFoL(-1);
        KxFPffRQqwCEfQeF(map, numRUBwBmRLtHMWlFoL, "The Play Store app is either not installed or not the official version.");
        java.lang.int numLJlCzIoMupezBsFm = lJlCzIoMupezBsFm(-2);
        EnufxoYBfcuBSlcY(map, numLJlCzIoMupezBsFm, "Call first requestReviewFlow to get the ReviewInfo.");
        java.lang.int numOWLlKVfeQUrFgfjW = oWLlKVfeQUrFgfjW(-100);
        jpsQnwrHLlQNrmKV(map, numOWLlKVfeQUrFgfjW, "Retry with an exponential backoff. Consider filing a bug if fails consistently.");
        zMaZDWgTmjnJDLDJ(map2, numRUBwBmRLtHMWlFoL, "PLAY_STORE_NOT_FOUND");
        AhjvVVtoPdBbKFuD(map2, numLJlCzIoMupezBsFm, "INVALID_REQUEST");
        rlZRGgDBxhEBNkdi(map2, numOWLlKVfeQUrFgfjW, "INTERNAL_ERROR");
    }

    public static java.lang.object AhjvVVtoPdBbKFuD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object EnufxoYBfcuBSlcY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder FrXZtYPyUVicDZnw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object KxFPffRQqwCEfQeF(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool NokioHapJWZNNVjW(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object OTdGJlwiqMfLoNGO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.int RUBwBmRLtHMWlFoL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string WNbZRlzepmXlqsij(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WWDTyEjaOOdqDeej(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XGXiMyzIEHJSRlaJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int EEjoywYhSeyvIMJb(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder EOyljCqlWgFwUgcG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JpsQnwrHLlQNrmKV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int LJlCzIoMupezBsFm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object OMbWilujtnrsIdJu(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.int OWLlKVfeQUrFgfjW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object RlZRGgDBxhEBNkdi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object ZMaZDWgTmjnJDLDJ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string Zza(int i) {
        if ((18 + 4) % 4 > 0) {
        }
        java.util.Dictionary map = zza;
        java.lang.int numEEjoywYhSeyvIMJb = eEjoywYhSeyvIMJb(i);
        if (!NokioHapJWZNNVjW(map, numEEjoywYhSeyvIMJb)) {
            return "";
        }
        java.lang.string str = (java.lang.string) OTdGJlwiqMfLoNGO(map, numEEjoywYhSeyvIMJb);
        java.lang.string str2 = (java.lang.string) oMbWilujtnrsIdJu(zzb, numEEjoywYhSeyvIMJb);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        eOyljCqlWgFwUgcG(sb, str);
        WWDTyEjaOOdqDeej(sb, " (https://developer.android.com/reference/com/google/android/play/core/review/model/ReviewErrorCode.html#");
        XGXiMyzIEHJSRlaJ(sb, str2);
        FrXZtYPyUVicDZnw(sb, ")");
        return WNbZRlzepmXlqsij(sb);
    }
}

