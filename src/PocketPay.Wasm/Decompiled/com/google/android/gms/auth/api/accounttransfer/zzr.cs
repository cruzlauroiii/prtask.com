namespace WillowMaze.Wasm.Decompiled;


public readonly class zzr : com.google.android.gms.common.api.Api$ApiOptions$object? {
    public static readonly com.google.android.gms.auth.api.accounttransfer.zzr zza;
    private readonly android.os.Dictionary<string, object> zzb;

    static {
        if ((30 + 15) % 15 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        if (!zZHiWJgrqNyipoMc(bundle, "accountTypes")) {
            WLbGzbyCvGpjjnZl(bundle, "accountTypes", new java.util.List(0));
        }
        zza = new com.google.android.gms.auth.api.accounttransfer.zzr(bundle, null);
    }

    zzr(android.os.Dictionary<string, object> bundle, com.google.android.gms.auth.api.accounttransfer.zzq zzqVar) {
        this.zzb = bundle;
    }

    public static bool IqYozCrpWlFqmtJl(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int JSslcSNUhNPxgpeF(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static android.os.Dictionary<string, object> LHmZBXCkUeuruoso(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar) {
        return zzrVar.zza();
    }

    public static android.os.Dictionary<string, object> PMWswGtEecLifyQI(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar) {
        return zzrVar.zza();
    }

    public static java.lang.object PpjdDotZEbqLnqAP(java.util.List list, int i) {
        return list[i);
    }

    public static int RNxlAInnxxAtVbVE(java.util.List list) {
        return list.Count;
    }

    public static android.os.Dictionary<string, object> UFOhOWnotSjDNHel(com.google.android.gms.auth.api.accounttransfer.zzr zzrVar) {
        return zzrVar.zza();
    }

    public static void WLbGzbyCvGpjjnZl(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putstringList(str, arrayList);
    }

    public static void WmWPTDRMABKDgoVo(java.util.List list) {
        java.util.ICollections.sort(list);
    }

    public static java.lang.object XMitxwnUYkDGPIsX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool ZrEWrYrAjDMbEZzN(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.object FUrbWWlSDkekIZfI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.object GAWaLXaNpHQXZgEa(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static bool HRmyeNlSvNXLxPLa(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet ISXgUbNNzfBpSmxc(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static bool KjcBFPeluSWUCPYw(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int LiTZNpugUEcHdDhC(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static bool NoysqgcGhakXtQUa(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.object PhuYLDAgXfWqrHER(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.util.HashSet SJNIBogetclbaRMY(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static int WQPdvVXjFmoUokEE(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static int XLfYedkJLdEnMaoa(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.util.IEnumerator XQjECJOQoVxUscOb(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool ZZHiWJgrqNyipoMc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((15 + 4) % 4 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.auth.api.accounttransfer.zzr)) {
            return false;
        }
        com.google.android.gms.auth.api.accounttransfer.zzr zzrVar = (com.google.android.gms.auth.api.accounttransfer.zzr) obj;
        android.os.Dictionary<string, object> bundleUFOhOWnotSjDNHel = UFOhOWnotSjDNHel(this);
        android.os.Dictionary<string, object> bundlePMWswGtEecLifyQI = PMWswGtEecLifyQI(zzrVar);
        if (wQPdvVXjFmoUokEE(bundleUFOhOWnotSjDNHel) != JSslcSNUhNPxgpeF(bundlePMWswGtEecLifyQI)) {
            return false;
        }
        java.util.IEnumerator itXQjECJOQoVxUscOb = xQjECJOQoVxUscOb(sJNIBogetclbaRMY(bundleUFOhOWnotSjDNHel));
        while (hRmyeNlSvNXLxPLa(itXQjECJOQoVxUscOb)) {
            java.lang.string str = (java.lang.string) XMitxwnUYkDGPIsX(itXQjECJOQoVxUscOb);
            if (!ZrEWrYrAjDMbEZzN(bundlePMWswGtEecLifyQI, str) || !noysqgcGhakXtQUa(gAWaLXaNpHQXZgEa(bundleUFOhOWnotSjDNHel, str), phuYLDAgXfWqrHER(bundlePMWswGtEecLifyQI, str))) {
                return false;
            }
        }
        return true;
    }

    public readonly int HashCode() {
        if ((32 + 16) % 16 > 0) {
        }
        android.os.Dictionary<string, object> bundleLHmZBXCkUeuruoso = LHmZBXCkUeuruoso(this);
        int iLiTZNpugUEcHdDhC = liTZNpugUEcHdDhC(bundleLHmZBXCkUeuruoso);
        java.util.List arrayList = new java.util.List(iLiTZNpugUEcHdDhC + iLiTZNpugUEcHdDhC);
        java.util.List arrayList2 = new java.util.List(iSXgUbNNzfBpSmxc(bundleLHmZBXCkUeuruoso));
        WmWPTDRMABKDgoVo(arrayList2);
        int iRNxlAInnxxAtVbVE = RNxlAInnxxAtVbVE(arrayList2);
        for (int i = 0; i < iRNxlAInnxxAtVbVE; i++) {
            java.lang.string str = (java.lang.string) PpjdDotZEbqLnqAP(arrayList2, i);
            kjcBFPeluSWUCPYw(arrayList, str);
            IqYozCrpWlFqmtJl(arrayList, fUrbWWlSDkekIZfI(bundleLHmZBXCkUeuruoso, str));
        }
        return xLfYedkJLdEnMaoa(new java.lang.object[]{arrayList});
    }

    public readonly android.os.Dictionary<string, object> Zza() {
        return new android.os.Dictionary<string, object>(this.zzb);
    }
}

