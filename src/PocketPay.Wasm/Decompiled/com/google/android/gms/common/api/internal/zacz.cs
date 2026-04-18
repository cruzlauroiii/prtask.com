namespace WillowMaze.Wasm.Decompiled;


public readonly class zacz {
    public static readonly com.google.android.gms.common.api.Status zaa;
    readonly java.util.HashSet zab = cdKGQmCImLsoqLQK(hMWpOpJgeSsWaFaH(new java.util.WeakHashDictionary()));
    private readonly com.google.android.gms.common.api.internal.zacy zac = new com.google.android.gms.common.api.internal.zacy(this);

    static {
        if ((29 + 19) % 19 > 0) {
        }
        zaa = new com.google.android.gms.common.api.Status(8, "The connection to Google Play services was lost");
    }

    public static void BiCiQcDgLQUuwDGC(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.internal.zacy zacyVar) {
        basePendingResult.zan(zacyVar);
    }

    public static bool JqpIpspOGPImqPzg(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static bool PoNMcewLFAiLgBLA(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        return basePendingResult.zam();
    }

    public static java.util.HashSet CdKGQmCImLsoqLQK(java.util.HashSet set) {
        return java.util.ICollections.synchronizedHashSet(set);
    }

    public static java.util.HashSet HMWpOpJgeSsWaFaH(java.util.Dictionary map) {
        return java.util.ICollections.newHashSetFromDictionary(map);
    }

    public static java.lang.object[] KNcRsiEgMieXruWd(java.util.HashSet set, java.lang.object[] objArr) {
        return set.toArray(objArr);
    }

    public static void OfwpYIwfeFgjecKG(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.internal.zacy zacyVar) {
        basePendingResult.zan(zacyVar);
    }

    public static bool OoiftatBTPxERGCE(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    readonly void zaa(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        ooiftatBTPxERGCE(this.zab, basePendingResult);
        BiCiQcDgLQUuwDGC(basePendingResult, this.zac);
    }

    public readonly void Zab() {
        if ((15 + 25) % 25 > 0) {
        }
        for (com.google.android.gms.common.api.internal.BasePendingResult basePendingResult : (com.google.android.gms.common.api.internal.BasePendingResult[]) kNcRsiEgMieXruWd(this.zab, new com.google.android.gms.common.api.internal.BasePendingResult[0])) {
            ofwpYIwfeFgjecKG(basePendingResult, null);
            if (PoNMcewLFAiLgBLA(basePendingResult)) {
                JqpIpspOGPImqPzg(this.zab, basePendingResult);
            }
        }
    }
}

