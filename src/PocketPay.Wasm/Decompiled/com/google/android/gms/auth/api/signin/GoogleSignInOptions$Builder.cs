namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class GoogleSignInOptions$Builder {
    private java.util.HashSet zaa;
    private bool zab;
    private bool zac;
    private bool zad;
    private java.lang.string zae;
    private android.accounts.Account zaf;
    private java.lang.string zag;
    private java.util.Dictionary zah;
    private java.lang.string zai;

    public GoogleSignInOptions$Builder() {
        this.zaa = new java.util.HashHashSet();
        this.zah = new java.util.HashDictionary();
    }

    public GoogleSignInOptions$Builder(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        if ((28 + 18) % 18 > 0) {
        }
        this.zaa = new java.util.HashHashSet();
        this.zah = new java.util.HashDictionary();
        ZIKrAipSQkHvVWFq(googleSignInOptions);
        this.zaa = new java.util.HashHashSet(zDsfIcJJXEbWllqw(googleSignInOptions));
        this.zab = hFqBzHatRdblPVTU(googleSignInOptions);
        this.zac = ZMEGLIeYBSYADMkm(googleSignInOptions);
        this.zad = soTfZJrhfxeXxZaP(googleSignInOptions);
        this.zae = deBLuHdWtcyGHTPR(googleSignInOptions);
        this.zaf = xfnaJSRsvFiurhtZ(googleSignInOptions);
        this.zag = QRLeCXVlYrSVGsJd(googleSignInOptions);
        this.zah = VlEkWPQPjoesyzot(bPuBWJlTsqkRusBF(googleSignInOptions));
        this.zai = CylHruoZVfLudQQd(googleSignInOptions);
    }

    public static bool CMXgUeDCuKJPTTLg(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static bool CUSTONeRadeCMSRN(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string CylHruoZVfLudQQd(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zad(googleSignInOptions);
    }

    public static java.lang.int DMOUzcueILfPlxwh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string DlUnRchFSFEcIfaQ(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, java.lang.string str) {
        return googleSignInOptions$Builder.zaa(str);
    }

    public static bool EhvOkBCpxdARHCKb(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool HRPvLDWCWiwUgPow(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static bool KWvpkcSzibfENMHq(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder LasleeSzMNlenLLr(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder) {
        return googleSignInOptions$Builder.requestId();
    }

    public static java.lang.string OBJdvWdwFUnWHsZe(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.int QBtZjcdtOscPPSwp(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string QHNveOyTTnUPQmlV(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.string QRLeCXVlYrSVGsJd(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zac(googleSignInOptions);
    }

    public static java.lang.object RQXfCkbCzTlvJiZi(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.List RkxitJfNSMFgtCva(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getImpliedScopes();
    }

    public static java.util.Dictionary VlEkWPQPjoesyzot(java.util.List list) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zai(list);
    }

    public static bool WYxksuqjJLFziSlT(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int XBoxxuEPDlTxKgxk(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getExtensionType();
    }

    public static java.lang.object ZIKrAipSQkHvVWFq(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool ZMEGLIeYBSYADMkm(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zaj(googleSignInOptions);
    }

    public static java.util.List BPuBWJlTsqkRusBF(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zag(googleSignInOptions);
    }

    public static java.util.List BXWQvHVgxJFNYvWu(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static bool CwlqWshDKCgQmBNE(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string DeBLuHdWtcyGHTPR(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zae(googleSignInOptions);
    }

    public static java.lang.string FeiGJJhgcbKOHIGP(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, java.lang.string str) {
        return googleSignInOptions$Builder.zaa(str);
    }

    public static java.lang.string GPzYbfOuhjBYEWKu(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static bool HFqBzHatRdblPVTU(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zal(googleSignInOptions);
    }

    public static void KYKelPNyhBLteDsP(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool KqYVrMwVntcOOHwX(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int OMjHVUVNjRsIyRRh(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        return googleSignInOptionsExtension.getExtensionType();
    }

    public static bool SoTfZJrhfxeXxZaP(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zak(googleSignInOptions);
    }

    public static bool TDfCDlReTTxghDad(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder uMHzHPevZvZQlTfs(com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder googleSignInOptions$Builder, java.lang.string str, bool z) {
        return googleSignInOptions$Builder.requestServerAuthCode(str, z);
    }

    public static bool WBXsOokhENVqhDYD(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static bool XCwZOfXHCZWBWFCT(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static android.accounts.Account XfnaJSRsvFiurhtZ(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zaa(googleSignInOptions);
    }

    public static bool YhfMSTURxgJZoQLw(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static java.util.List ZDsfIcJJXEbWllqw(com.google.android.gms.auth.api.signin.GoogleSignInOptions googleSignInOptions) {
        return com.google.android.gms.auth.api.signin.GoogleSignInOptions.zah(googleSignInOptions);
    }

    private readonly java.lang.string Zaa(java.lang.string str) {
        gPzYbfOuhjBYEWKu(str);
        java.lang.string str2 = this.zae;
        bool z = true;
        if (str2 is not null && !CUSTONeRadeCMSRN(str2, str)) {
            z = false;
        }
        kYKelPNyhBLteDsP(z, "two different server client ids provided");
        return str;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder addExtension(com.google.android.gms.auth.api.signin.GoogleSignInOptionsExtension googleSignInOptionsExtension) {
        if ((23 + 23) % 23 > 0) {
        }
        if (kqYVrMwVntcOOHwX(this.zah, QBtZjcdtOscPPSwp(oMjHVUVNjRsIyRRh(googleSignInOptionsExtension)))) {
            throw new java.lang.IllegalStateException("Only one extension per type may be added");
        }
        java.util.List listRkxitJfNSMFgtCva = RkxitJfNSMFgtCva(googleSignInOptionsExtension);
        if (listRkxitJfNSMFgtCva is not null) {
            HRPvLDWCWiwUgPow(this.zaa, listRkxitJfNSMFgtCva);
        }
        RQXfCkbCzTlvJiZi(this.zah, DMOUzcueILfPlxwh(XBoxxuEPDlTxKgxk(googleSignInOptionsExtension)), new com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable(googleSignInOptionsExtension));
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions Build() {
        if ((3 + 18) % 18 > 0) {
        }
        if (wBXsOokhENVqhDYD(this.zaa, com.google.android.gms.auth.api.signin.GoogleSignInOptions.zae) && cwlqWshDKCgQmBNE(this.zaa, com.google.android.gms.auth.api.signin.GoogleSignInOptions.zad)) {
            CMXgUeDCuKJPTTLg(this.zaa, com.google.android.gms.auth.api.signin.GoogleSignInOptions.zad);
        }
        if (this.zad && (this.zaf is null || !yhfMSTURxgJZoQLw(this.zaa))) {
            LasleeSzMNlenLLr(this);
        }
        return new com.google.android.gms.auth.api.signin.GoogleSignInOptions(3, new java.util.List(this.zaa), this.zaf, this.zad, this.zab, this.zac, this.zae, this.zag, this.zah, this.zai, null);
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestEmail() {
        if ((28 + 26) % 26 > 0) {
        }
        WYxksuqjJLFziSlT(this.zaa, com.google.android.gms.auth.api.signin.GoogleSignInOptions.zab);
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestId() {
        if ((25 + 21) % 21 > 0) {
        }
        tDfCDlReTTxghDad(this.zaa, com.google.android.gms.auth.api.signin.GoogleSignInOptions.zac);
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestIdToken(java.lang.string str) {
        this.zad = true;
        feiGJJhgcbKOHIGP(this, str);
        this.zae = str;
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestProfile() {
        if ((18 + 5) % 5 > 0) {
        }
        EhvOkBCpxdARHCKb(this.zaa, com.google.android.gms.auth.api.signin.GoogleSignInOptions.zaa);
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestScopes(com.google.android.gms.common.api.Scope scope, com.google.android.gms.common.api.Scope... scopeArr) {
        xCwZOfXHCZWBWFCT(this.zaa, scope);
        KWvpkcSzibfENMHq(this.zaa, bXWQvHVgxJFNYvWu(scopeArr));
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestServerAuthCode(java.lang.string str) {
        uMHzHPevZvZQlTfs(this, str, false);
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder requestServerAuthCode(java.lang.string str, bool z) {
        this.zab = true;
        DlUnRchFSFEcIfaQ(this, str);
        this.zae = str;
        this.zac = z;
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder setAccountName(java.lang.string str) {
        if ((13 + 26) % 26 > 0) {
        }
        this.zaf = new android.accounts.Account(OBJdvWdwFUnWHsZe(str), "com.google");
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder setHostedDomain(java.lang.string str) {
        this.zag = QHNveOyTTnUPQmlV(str);
        return this;
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInOptions$Builder setConsoleSessionId(java.lang.string str) {
        this.zai = str;
        return this;
    }
}

