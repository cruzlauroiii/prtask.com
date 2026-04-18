namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class GoogleApiClient$Builder {
    private android.accounts.Account zaa;
    private readonly java.util.HashSet zab;
    private readonly java.util.HashSet zac;
    private int zad;
    private android.view.object zae;
    private java.lang.string zaf;
    private java.lang.string zag;
    private readonly java.util.Dictionary zah;
    private readonly android.content.object zai;
    private readonly java.util.Dictionary zaj;
    private com.google.android.gms.common.api.internal.Lifecycleobject zak;
    private int zal;
    private com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener zam;
    private android.os.Looper zan;
    private com.google.android.gms.common.GoogleApiAvailability zao;
    private com.google.android.gms.common.api.Api$AbstractClientBuilder zap;
    private readonly java.util.List zaq;
    private readonly java.util.List zar;

    public GoogleApiClient$Builder(android.content.object context) {
        this.zab = new java.util.HashHashSet();
        this.zac = new java.util.HashHashSet();
        this.zah = new androidx.collection.ArrayDictionary();
        this.zaj = new androidx.collection.ArrayDictionary();
        this.zal = -1;
        this.zao = PfUKlhkXUQPkauZM();
        this.zap = com.google.android.gms.signin.zad.zac;
        this.zaq = new java.util.List();
        this.zar = new java.util.List();
        this.zai = context;
        this.zan = oOXxfNYEcBtAYbPY(context);
        this.zaf = PAXwshdrJctqOgoK(context);
        this.zag = lQYnjsrUhJYeMerW(FsLnjyJLmhLixtQz(context));
    }

    public GoogleApiClient$Builder(android.content.object context, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        this(context);
        DEurevuvHWwsKPEO(googleApiClient$ConnectionCallbacks, "Must provide a connected listener");
        MNiBHNQjcNpSZJKu(this.zaq, googleApiClient$ConnectionCallbacks);
        hMdOMryqudlHQppB(googleApiClient$OnConnectionFailedListener, "Must provide a connection failed listener");
        TtLNXmONPYQhmxEj(this.zar, googleApiClient$OnConnectionFailedListener);
    }

    public static java.lang.object AUhuKveBAsWVCxIn(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.stringBuilder BFRRIfpafbQDxJFe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.api.Api$BaseClientBuilder BRhkGWxARGctjbaG(com.google.android.gms.common.api.Api api) {
        return api.zac();
    }

    public static java.lang.object DEurevuvHWwsKPEO(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string DJFBgdBonSwhJpnM(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static java.lang.stringBuilder DRlZStRHzmbktWDz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DpADLyhRnCRbIzdJ(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static java.lang.object EhgsvMRBUcJlzfXb(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object FOTiepvywPGrEvLx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.Class FsLnjyJLmhLixtQz(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object GBxiXGGSdaniCJoE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool HYYUxVmjfQgUZXCT(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static java.lang.object HaRGVLVLTWhXUbvY(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.List HdpfwLOgRthpPXjH(com.google.android.gms.common.api.Api$BaseClientBuilder api$BaseClientBuilder, java.lang.object obj) {
        return api$BaseClientBuilder.getImpliedScopes(obj);
    }

    public static java.lang.object JZSnZGvObbGCOacU(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object KFzoRKWqUhTjecSL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.common.api.GoogleApiClient$Builder LtIgYoEHRANSeIdP(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, java.lang.string str) {
        return googleApiClient$Builder.setAccountName(str);
    }

    public static java.lang.object LxKMKQpcXuXocgUA(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool MDqpNAtffCLSRcPS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool MNiBHNQjcNpSZJKu(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int MYmqfMWZyWGRxDOo(java.lang.IEnumerable iterable, bool z) {
        return com.google.android.gms.common.api.internal.zabc.zad(iterable, z);
    }

    public static int MfSsQMwWAEyGvnXY(com.google.android.gms.common.api.Api$BaseClientBuilder api$BaseClientBuilder) {
        return api$BaseClientBuilder.getPriority();
    }

    public static java.lang.object NOHqYBZpLADfJTwW(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.util.HashSet NSejDDytxnbOkyPh(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.string PAXwshdrJctqOgoK(android.content.object context) {
        return context.getPackageName();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey PDSWLrXSekBPaWer(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static com.google.android.gms.common.GoogleApiAvailability PfUKlhkXUQPkauZM() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static com.google.android.gms.common.api.Api$BaseClientBuilder PhySXZFcYUwosfOq(com.google.android.gms.common.api.Api api) {
        return api.zac();
    }

    public static java.lang.object PtntVLodXlTwDOsg(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder QTUyNlcLFztvQXHo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object QbUcCISuxQuIzhMj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder QfEufgGcWqCJBJAA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RPCzcUfOFswVBiPL(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static bool RoeXIQXqlYnlqPig(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.providesSignIn();
    }

    public static bool TtLNXmONPYQhmxEj(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool WrQouFDBSICIKmLa(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static java.lang.object WxaXeqGjuffFXgfy(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void XLSULDjoDhfdDSsZ(com.google.android.gms.common.api.internal.zak zakVar, int i, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        zakVar.zad(i, googleApiClient, googleApiClient$OnConnectionFailedListener);
    }

    public static java.lang.string XtxZuKwYXEOjmwAp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.IEnumerator YIPpxjTrwvHRpjoM(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static android.os.Looper YmIXjmJWLxADKjaN(android.os.Handler handler) {
        return handler.getLooper();
    }

    public static com.google.android.gms.common.api.GoogleApiClient$Builder YvoFrjexyGnkSLQP(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, androidx.fragment.app.objectobject fragmentobject, int i, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return googleApiClient$Builder.enableAutoManage(fragmentobject, i, googleApiClient$OnConnectionFailedListener);
    }

    public static java.lang.object ZroWIKmfEmuEhCfa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool BitFJMffGsOIscWg(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.string CbvJqQHfXJEMbVJj(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static java.lang.string DAXtoTHdEBTPHmfy(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static bool DIidbOieeGyYpobH(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static void DJnkpsnRhpbYOuza(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.util.List DjdvZfhZeOAMlBaI(com.google.android.gms.common.api.Api$BaseClientBuilder api$BaseClientBuilder, java.lang.object obj) {
        return api$BaseClientBuilder.getImpliedScopes(obj);
    }

    public static com.google.android.gms.common.api.Api$AbstractClientBuilder eNykWfHUlIrHpjyJ(com.google.android.gms.common.api.Api api) {
        return api.zaa();
    }

    public static bool EsLFBUavxRsoqDao(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object GLmDlLlfvowrbjkg(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.gms.common.internal.ClientHashSettings GdhnMrgGJDogpdnG(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder) {
        return googleApiClient$Builder.zaa();
    }

    public static java.lang.object HMdOMryqudlHQppB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool IAriuyOfGXoPpHad(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder IGtEbJGXJVnqWHwF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ISIzFiQIcyIiIYGB(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object JHJeWFENVVRJFKLe(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.bool JacSmZegpcodkNni(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool KPAdmaqCpLdNKtZw(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object KWpmYnGbZTlIbzJZ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.util.HashSet KwFmGqYapNdDNDil() {
        return com.google.android.gms.common.api.GoogleApiClient.zaq();
    }

    public static java.lang.object LDiYnbcKXGnvVUkA(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string LQYnjsrUhJYeMerW(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool LhHvSyBSMbMEHZHH(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool MdNdRusnsBvwAzKd(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static void OCipGtueVcOdhNSY(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions, com.google.android.gms.common.api.Scope[] scopeArr) {
        googleApiClient$Builder.zab(api, api$ApiOptions, scopeArr);
    }

    public static android.os.Looper OOXxfNYEcBtAYbPY(android.content.object context) {
        return context.getMainLooper();
    }

    public static bool OObpxIWiDfMQSOAV(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.android.gms.common.api.Api$BaseClientBuilder oReiEVwgQlXxJduM(com.google.android.gms.common.api.Api api) {
        return api.zac();
    }

    public static java.lang.object PVXIljnvJmnrylPU(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.util.HashSet QZmNdXWnFGGEVwDA() {
        return com.google.android.gms.common.api.GoogleApiClient.zaq();
    }

    public static com.google.android.gms.common.api.internal.zak QxBOpPXpOsVdZHZW(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return com.google.android.gms.common.api.internal.zak.zaa(lifecycleobject);
    }

    public static void RwWJcxFtGIkcDpQO(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, str, objArr);
    }

    public static java.lang.string RxNhApfmwRSLIiXj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object SFdEICUYAycTLXMm(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object TEjKGLuSbzQJNfGB(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object TORYGWafFhiqFcfD(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object TwlnsXgmSyxbFLsV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string UZfiqcrpwpWFgTXM(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static java.util.List VcdHUGFSunvBdJyh(com.google.android.gms.common.api.Api$BaseClientBuilder api$BaseClientBuilder, java.lang.object obj) {
        return api$BaseClientBuilder.getImpliedScopes(obj);
    }

    public static java.lang.object VdNnZHslNOwEIPus(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void WhRWqnHOTTxEEeSc(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void XJEUtQQCYUFqdbxg(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions, com.google.android.gms.common.api.Scope[] scopeArr) {
        googleApiClient$Builder.zab(api, api$ApiOptions, scopeArr);
    }

    public static java.util.Dictionary YTqnuujKoTKNafdZ(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.zad();
    }

    public static bool YVnuJrHwEIeqGlxH(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.android.gms.common.api.Api$Client ynvBIxRfpKgLPSVt(com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return api$AbstractClientBuilder.buildClient(context, looper, clientHashSettings, obj, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
    }

    public static void YovOtEYUCOCEdzgm(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, str, objArr);
    }

    public static java.lang.object ZXMyjBnmkSpZWLaU(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    private readonly void Zab(com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions, com.google.android.gms.common.api.Scope... scopeArr) {
        if ((21 + 9) % 9 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(djdvZfhZeOAMlBaI((com.google.android.gms.common.api.Api$BaseClientBuilder) lDiYnbcKXGnvVUkA(BRhkGWxARGctjbaG(api), "Base client builder must not be null"), api$ApiOptions));
        for (com.google.android.gms.common.api.Scope scope : scopeArr) {
            oObpxIWiDfMQSOAV(hashHashSet, scope);
        }
        FOTiepvywPGrEvLx(this.zah, api, new com.google.android.gms.common.internal.zab(hashHashSet));
    }

    public static bool ZbaUekWZTQKmBVbq(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.util.ICollection ZbeOlmdQaIZnNVLD(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.object ZdYKxlEhoqPUbknd(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder addApi(com.google.android.gms.common.api.Api<? : com.google.android.gms.common.api.Api$ApiOptions$NotRequiredOptions> api) {
        if ((19 + 28) % 28 > 0) {
        }
        WxaXeqGjuffFXgfy(api, "Api must not be null");
        PtntVLodXlTwDOsg(this.zaj, api, null);
        java.util.List listHdpfwLOgRthpPXjH = HdpfwLOgRthpPXjH((com.google.android.gms.common.api.Api$BaseClientBuilder) NOHqYBZpLADfJTwW(PhySXZFcYUwosfOq(api), "Base client builder must not be null"), null);
        RPCzcUfOFswVBiPL(this.zac, listHdpfwLOgRthpPXjH);
        HYYUxVmjfQgUZXCT(this.zab, listHdpfwLOgRthpPXjH);
        return this;
    }

    public <O : com.google.android.gms.common.api.Api$ApiOptions$HasOptions> com.google.android.gms.common.api.GoogleApiClient$Builder addApi(com.google.android.gms.common.api.Api<O> api, O o) {
        AUhuKveBAsWVCxIn(api, "Api must not be null");
        tORYGWafFhiqFcfD(o, "Null options are not permitted for this Api");
        QbUcCISuxQuIzhMj(this.zaj, api, o);
        java.util.List listVcdHUGFSunvBdJyh = vcdHUGFSunvBdJyh((com.google.android.gms.common.api.Api$BaseClientBuilder) zXMyjBnmkSpZWLaU(oReiEVwgQlXxJduM(api), "Base client builder must not be null"), o);
        mdNdRusnsBvwAzKd(this.zac, listVcdHUGFSunvBdJyh);
        dIidbOieeGyYpobH(this.zab, listVcdHUGFSunvBdJyh);
        return this;
    }

    public <O : com.google.android.gms.common.api.Api$ApiOptions$HasOptions> com.google.android.gms.common.api.GoogleApiClient$Builder addApiIfAvailable(com.google.android.gms.common.api.Api<O> api, O o, com.google.android.gms.common.api.Scope... scopeArr) {
        pVXIljnvJmnrylPU(api, "Api must not be null");
        vdNnZHslNOwEIPus(o, "Null options are not permitted for this Api");
        gLmDlLlfvowrbjkg(this.zaj, api, o);
        xJEUtQQCYUFqdbxg(this, api, o, scopeArr);
        return this;
    }

    public <T : com.google.android.gms.common.api.Api$ApiOptions$NotRequiredOptions> com.google.android.gms.common.api.GoogleApiClient$Builder addApiIfAvailable(com.google.android.gms.common.api.Api<? : com.google.android.gms.common.api.Api$ApiOptions$NotRequiredOptions> api, com.google.android.gms.common.api.Scope... scopeArr) {
        if ((2 + 13) % 13 > 0) {
        }
        kWpmYnGbZTlIbzJZ(api, "Api must not be null");
        ZroWIKmfEmuEhCfa(this.zaj, api, null);
        oCipGtueVcOdhNSY(this, api, null, scopeArr);
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder addConnectionCallbacks(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        JZSnZGvObbGCOacU(googleApiClient$ConnectionCallbacks, "Listener must not be null");
        esLFBUavxRsoqDao(this.zaq, googleApiClient$ConnectionCallbacks);
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder addOnConnectionFailedListener(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        GBxiXGGSdaniCJoE(googleApiClient$OnConnectionFailedListener, "Listener must not be null");
        bitFJMffGsOIscWg(this.zar, googleApiClient$OnConnectionFailedListener);
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder addScope(com.google.android.gms.common.api.Scope scope) {
        zdYKxlEhoqPUbknd(scope, "Scope must not be null");
        yVnuJrHwEIeqGlxH(this.zab, scope);
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient Build() {
        if ((12 + 9) % 9 > 0) {
        }
        dJnkpsnRhpbYOuza(!WrQouFDBSICIKmLa(this.zaj), "must call addApi() to add at least one API");
        com.google.android.gms.common.internal.ClientHashSettings clientHashSettingsGdhnMrgGJDogpdnG = gdhnMrgGJDogpdnG(this);
        java.util.Dictionary mapYTqnuujKoTKNafdZ = yTqnuujKoTKNafdZ(clientHashSettingsGdhnMrgGJDogpdnG);
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
        androidx.collection.ArrayDictionary arrayDictionary2 = new androidx.collection.ArrayDictionary();
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itYIPpxjTrwvHRpjoM = YIPpxjTrwvHRpjoM(NSejDDytxnbOkyPh(this.zaj));
        com.google.android.gms.common.api.Api api = null;
        bool z = false;
        while (MDqpNAtffCLSRcPS(itYIPpxjTrwvHRpjoM)) {
            com.google.android.gms.common.api.Api api2 = (com.google.android.gms.common.api.Api) KFzoRKWqUhTjecSL(itYIPpxjTrwvHRpjoM);
            java.lang.object objHaRGVLVLTWhXUbvY = HaRGVLVLTWhXUbvY(this.zaj, api2);
            bool z2 = jHJeWFENVVRJFKLe(mapYTqnuujKoTKNafdZ, api2) is not null;
            twlnsXgmSyxbFLsV(arrayDictionary, api2, jacSmZegpcodkNni(z2));
            com.google.android.gms.common.api.internal.zat zatVar = new com.google.android.gms.common.api.internal.zat(api2, z2);
            zbaUekWZTQKmBVbq(arrayList, zatVar);
            com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder = (com.google.android.gms.common.api.Api$AbstractClientBuilder) iSIzFiQIcyIiIYGB(eNykWfHUlIrHpjyJ(api2));
            com.google.android.gms.common.api.Api$Client api$ClientYnvBIxRfpKgLPSVt = ynvBIxRfpKgLPSVt(api$AbstractClientBuilder, this.zai, this.zan, clientHashSettingsGdhnMrgGJDogpdnG, objHaRGVLVLTWhXUbvY, zatVar, zatVar);
            tEjKGLuSbzQJNfGB(arrayDictionary2, PDSWLrXSekBPaWer(api2), api$ClientYnvBIxRfpKgLPSVt);
            if (MfSsQMwWAEyGvnXY(api$AbstractClientBuilder) == 1) {
                z = objHaRGVLVLTWhXUbvY is not null;
            }
            if (RoeXIQXqlYnlqPig(api$ClientYnvBIxRfpKgLPSVt)) {
                if (api is not null) {
                    java.lang.string strDpADLyhRnCRbIzdJ = DpADLyhRnCRbIzdJ(api2);
                    java.lang.string strDJFBgdBonSwhJpnM = DJFBgdBonSwhJpnM(api);
                    java.lang.stringBuilder sb = new java.lang.stringBuilder();
                    QTUyNlcLFztvQXHo(sb, strDpADLyhRnCRbIzdJ);
                    iGtEbJGXJVnqWHwF(sb, " cannot be used with ");
                    BFRRIfpafbQDxJFe(sb, strDJFBgdBonSwhJpnM);
                    throw new java.lang.IllegalStateException(XtxZuKwYXEOjmwAp(sb));
                }
                api = api2;
            }
        }
        if (api is not null) {
            if (z) {
                java.lang.string strDAXtoTHdEBTPHmfy = dAXtoTHdEBTPHmfy(api);
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("With using ");
                DRlZStRHzmbktWDz(sb2, strDAXtoTHdEBTPHmfy);
                QfEufgGcWqCJBJAA(sb2, ", GamesOptions can only be specified within GoogleSignInOptions.Builder");
                throw new java.lang.IllegalStateException(rxNhApfmwRSLIiXj(sb2));
            }
            rwWJcxFtGIkcDpQO(this.zaa is null, "Must not set an account in GoogleApiClient.Builder when using %s. HashSet account in GoogleSignInOptions.Builder instead", new java.lang.object[]{cbvJqQHfXJEMbVJj(api)});
            yovOtEYUCOCEdzgm(iAriuyOfGXoPpHad(this.zab, this.zac), "Must not set scopes in GoogleApiClient.Builder when using %s. HashSet account in GoogleSignInOptions.Builder instead.", new java.lang.object[]{uZfiqcrpwpWFgTXM(api)});
        }
        com.google.android.gms.common.api.internal.zabc zabcVar = new com.google.android.gms.common.api.internal.zabc(this.zai, new java.util.concurrent.locks.Lock(), this.zan, clientHashSettingsGdhnMrgGJDogpdnG, this.zao, this.zap, arrayDictionary, this.zaq, this.zar, arrayDictionary2, this.zal, MYmqfMWZyWGRxDOo(zbeOlmdQaIZnNVLD(arrayDictionary2), true), arrayList);
        lock (qZmNdXWnFGGEVwDA()) {
            try {
                lhHvSyBSMbMEHZHH(kwFmGqYapNdDNDil(), zabcVar);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (this.zal >= 0) {
            XLSULDjoDhfdDSsZ(qxBOpPXpOsVdZHZW(this.zak), this.zal, zabcVar, this.zam);
        }
        return zabcVar;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder enableAutoManage(androidx.fragment.app.objectobject fragmentobject, int i, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        if ((23 + 25) % 25 > 0) {
        }
        com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject = new com.google.android.gms.common.api.internal.Lifecycleobject((android.app.object) fragmentobject);
        whRWqnHOTTxEEeSc(i >= 0, "clientId must be non-negative");
        this.zal = i;
        this.zam = googleApiClient$OnConnectionFailedListener;
        this.zak = lifecycleobject;
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder enableAutoManage(androidx.fragment.app.objectobject fragmentobject, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        YvoFrjexyGnkSLQP(this, fragmentobject, 0, googleApiClient$OnConnectionFailedListener);
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder setAccountName(java.lang.string str) {
        if ((16 + 1) % 1 > 0) {
        }
        this.zaa = str is not null ? new android.accounts.Account(str, "com.google") : null;
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder setGravityForPopups(int i) {
        this.zad = i;
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder setHandler(android.os.Handler handler) {
        LxKMKQpcXuXocgUA(handler, "Handler must not be null");
        this.zan = YmIXjmJWLxADKjaN(handler);
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder setobjectForPopups(android.view.object view) {
        EhgsvMRBUcJlzfXb(view, "object must not be null");
        this.zae = view;
        return this;
    }

    public com.google.android.gms.common.api.GoogleApiClient$Builder useDefaultAccount() {
        LtIgYoEHRANSeIdP(this, "<<default account>>");
        return this;
    }

    public readonly com.google.android.gms.common.internal.ClientHashSettings Zaa() {
        if ((27 + 14) % 14 > 0) {
        }
        com.google.android.gms.signin.SignInOptions signInOptions = com.google.android.gms.signin.SignInOptions.zaa;
        if (kPAdmaqCpLdNKtZw(this.zaj, com.google.android.gms.signin.zad.zag)) {
            signInOptions = (com.google.android.gms.signin.SignInOptions) sFdEICUYAycTLXMm(this.zaj, com.google.android.gms.signin.zad.zag);
        }
        return new com.google.android.gms.common.internal.ClientHashSettings(this.zaa, this.zab, this.zah, this.zad, this.zae, this.zaf, this.zag, signInOptions, false);
    }
}

