namespace WillowMaze.Wasm.Decompiled;


public readonly class zaai : com.google.android.gms.common.api.internal.zabd {
    private readonly com.google.android.gms.common.api.internal.zabg zaa;
    private bool zab = false;

    public zaai(com.google.android.gms.common.api.internal.zabg zabgVar) {
        this.zaa = zabgVar;
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl ATlFrQxIsSwmCYXT(com.google.android.gms.common.api.internal.zaai zaaiVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zaaiVar.zab(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.object JiiITODtAAlUrduc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object KJsQWeogfDNRjgeH(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void KMeuxpoHvjYhSSfD(com.google.android.gms.common.api.internal.zacz zaczVar, com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        zaczVar.zaa(basePendingResult);
    }

    public static bool MuaDdtjKFENCeMsz(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey OgkekyZZvffAHoOG(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getClientKey();
    }

    public static void QhCqXCOembaoWkGn(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Api$AnyClient api$AnyClient) throws android.os.DeadobjectException {
        baseImplementation$ApiMethodImpl.run(api$AnyClient);
    }

    public static void TKOGjFAlPdDKRDnL(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabgVar.zak(connectionResult);
    }

    public static bool TvZyIJsavrWuLjsm(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static java.lang.object XQctpaiDxXpGqFAA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZmIbAlejGmgBFyLb(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.internal.zabe zabeVar) {
        zabgVar.zal(zabeVar);
    }

    public static bool AgDEsOeBJnaNiKjI(com.google.android.gms.common.api.internal.zaai zaaiVar) {
        return zaaiVar.zaj();
    }

    public static java.util.IEnumerator AnHMuTEGHCmZbRed(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void BcxbaUqSbOmvGIKX(com.google.android.gms.common.api.internal.zacx zacxVar) {
        zacxVar.zah();
    }

    public static bool DqRWRbjZnTCFlhwN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey fnpDLftUIULrVHul(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getClientKey();
    }

    public static bool KviQufGDepParkwQ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void NyQotsqnyFiAshFh(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static void QpClUjxaysgcNIAT(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.internal.zabe zabeVar) {
        zabgVar.zal(zabeVar);
    }

    public static void XfRkZUZmzAOfayjM(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabgVar.zak(connectionResult);
    }

    public static void YQUriazecjihLgyI(com.google.android.gms.common.api.internal.zabx zabxVar, int i, bool z) {
        zabxVar.zac(i, z);
    }

    public static void YeREuNQbHxViiuFX(com.google.android.gms.common.api.internal.zacz zaczVar) {
        zaczVar.zab();
    }

    static com.google.android.gms.common.api.internal.zabg Zac(com.google.android.gms.common.api.internal.zaai zaaiVar) {
        return zaaiVar.zaa;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zaa(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        ATlFrQxIsSwmCYXT(this, baseImplementation$ApiMethodImpl);
        return baseImplementation$ApiMethodImpl;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zab(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        if ((27 + 32) % 32 > 0) {
        }
        try {
            KMeuxpoHvjYhSSfD(this.zaa.zag.zai, baseImplementation$ApiMethodImpl);
            com.google.android.gms.common.api.internal.zabc zabcVar = this.zaa.zag;
            com.google.android.gms.common.api.Api$Client api$Client = (com.google.android.gms.common.api.Api$Client) KJsQWeogfDNRjgeH(zabcVar.zac, fnpDLftUIULrVHul(baseImplementation$ApiMethodImpl));
            JiiITODtAAlUrduc(api$Client, "Appropriate Api was not requested.");
            if (MuaDdtjKFENCeMsz(api$Client) || !kviQufGDepParkwQ(this.zaa.zab, OgkekyZZvffAHoOG(baseImplementation$ApiMethodImpl))) {
                QhCqXCOembaoWkGn(baseImplementation$ApiMethodImpl, api$Client);
                return baseImplementation$ApiMethodImpl;
            }
            nyQotsqnyFiAshFh(baseImplementation$ApiMethodImpl, new com.google.android.gms.common.api.Status(17));
            return baseImplementation$ApiMethodImpl;
        } catch (android.os.DeadobjectException unused) {
            ZmIbAlejGmgBFyLb(this.zaa, new com.google.android.gms.common.api.internal.zaag(this, this));
            return baseImplementation$ApiMethodImpl;
        }
    }

    public override readonly void Zad() {
    }

    public override readonly void Zae() {
        if ((15 + 13) % 13 > 0) {
        }
        if (this.zab) {
            this.zab = false;
            qpClUjxaysgcNIAT(this.zaa, new com.google.android.gms.common.api.internal.zaah(this, this));
        }
    }

    readonly void zaf() {
        if (this.zab) {
            this.zab = false;
            yeREuNQbHxViiuFX(this.zaa.zag.zai);
            agDEsOeBJnaNiKjI(this);
        }
    }

    public override readonly void Zag(android.os.Dictionary<string, object> bundle) {
    }

    public override readonly void Zah(com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
    }

    public override readonly void Zai(int i) {
        if ((23 + 24) % 24 > 0) {
        }
        TKOGjFAlPdDKRDnL(this.zaa, null);
        yQUriazecjihLgyI(this.zaa.zah, i, this.zab);
    }

    public override readonly bool Zaj() {
        if ((14 + 1) % 1 > 0) {
        }
        if (this.zab) {
            return false;
        }
        java.util.HashSet set = this.zaa.zag.zah;
        if (set is null || TvZyIJsavrWuLjsm(set)) {
            xfRkZUZmzAOfayjM(this.zaa, null);
            return true;
        }
        this.zab = true;
        java.util.IEnumerator itAnHMuTEGHCmZbRed = anHMuTEGHCmZbRed(set);
        while (dqRWRbjZnTCFlhwN(itAnHMuTEGHCmZbRed)) {
            bcxbaUqSbOmvGIKX((com.google.android.gms.common.api.internal.zacx) XQctpaiDxXpGqFAA(itAnHMuTEGHCmZbRed));
        }
        return false;
    }
}

