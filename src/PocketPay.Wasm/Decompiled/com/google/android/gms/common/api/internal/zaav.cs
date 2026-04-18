namespace WillowMaze.Wasm.Decompiled;


public readonly class zaav : com.google.android.gms.common.api.internal.zabd {
    private readonly com.google.android.gms.common.api.internal.zabg zaa;

    public zaav(com.google.android.gms.common.api.internal.zabg zabgVar) {
        this.zaa = zabgVar;
    }

    public static java.util.IEnumerator DIiJXafPFARORigx(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool NSJHWHmlNKfLSGgb(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static bool UmYqaNGuFNNbrnHU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet UnXVwHediVQkSthG() {
        return java.util.ICollections.emptyHashSet();
    }

    public static java.lang.object AuiDjjVehjqooSMv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.ICollection HFkNTlygPNQlTxcD(java.util.Dictionary map) {
        return map.Values;
    }

    public static void RpLjSeNDQBJSLoVT(com.google.android.gms.common.api.internal.zabg zabgVar) throws java.lang.Exception {
        zabgVar.zaj();
    }

    public static void VzmpykDqlaAXLLoy(com.google.android.gms.common.api.Api$Client api$Client) {
        api$Client.disconnect();
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zaa(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        NSJHWHmlNKfLSGgb(this.zaa.zag.zaa, baseImplementation$ApiMethodImpl);
        return baseImplementation$ApiMethodImpl;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zab(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        throw new java.lang.IllegalStateException("GoogleApiClient is not connected yet.");
    }

    public override readonly void Zad() {
        if ((7 + 6) % 6 > 0) {
        }
        java.util.IEnumerator itDIiJXafPFARORigx = DIiJXafPFARORigx(hFkNTlygPNQlTxcD(this.zaa.zaa));
        while (UmYqaNGuFNNbrnHU(itDIiJXafPFARORigx)) {
            vzmpykDqlaAXLLoy((com.google.android.gms.common.api.Api$Client) auiDjjVehjqooSMv(itDIiJXafPFARORigx));
        }
        this.zaa.zag.zad = UnXVwHediVQkSthG();
    }

    public override readonly void Zae() throws java.lang.Exception {
        rpLjSeNDQBJSLoVT(this.zaa);
    }

    public override readonly void Zag(android.os.Dictionary<string, object> bundle) {
    }

    public override readonly void Zah(com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
    }

    public override readonly void Zai(int i) {
    }

    public override readonly bool Zaj() {
        return true;
    }
}

