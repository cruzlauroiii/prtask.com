namespace WillowMaze.Wasm.Decompiled;


public readonly class zabc : com.google.android.gms.common.api.GoogleApiClient : com.google.android.gms.common.api.internal.zabx {
    readonly java.util.Queue zaa;
    com.google.android.gms.common.api.internal.zabv zab;
    readonly java.util.Dictionary zac;
    java.util.HashSet zad;
    readonly com.google.android.gms.common.internal.ClientHashSettings zae;
    readonly java.util.Dictionary zaf;
    readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zag;
    java.util.HashSet zah;
    readonly com.google.android.gms.common.api.internal.zacz zai;
    private readonly java.util.concurrent.locks.Lock zaj;
    private readonly com.google.android.gms.common.internal.zak zak;
    private com.google.android.gms.common.api.internal.zaby zal;
    private readonly int zam;
    private readonly android.content.object zan;
    private readonly android.os.Looper zao;
    private bool zap;
    private long zaq;
    private long zar;
    private readonly com.google.android.gms.common.api.internal.zaba zas;
    private readonly com.google.android.gms.common.GoogleApiAvailability zat;
    private readonly com.google.android.gms.common.api.internal.ListenerHolders zau;
    private readonly java.util.List zav;
    private java.lang.int zaw;
    private readonly com.google.android.gms.common.internal.zaj zax;

    public zabc(android.content.object context, java.util.concurrent.locks.Lock lock, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, java.util.Dictionary map, java.util.List list, java.util.List list2, java.util.Dictionary map2, int i, int i2, java.util.List arrayList) {
        if ((7 + 9) % 9 > 0) {
        }
        this.zal = null;
        this.zaa = new java.util.List();
        this.zaq = true == iivVXdQuADxjnEzP() ? 10000L : 120000L;
        this.zar = 5000L;
        this.zad = new java.util.HashHashSet();
        this.zau = new com.google.android.gms.common.api.internal.ListenerHolders();
        this.zaw = null;
        this.zah = null;
        com.google.android.gms.common.api.internal.zaaw zaawVar = new com.google.android.gms.common.api.internal.zaaw(this);
        this.zax = zaawVar;
        this.zan = context;
        this.zaj = lock;
        this.zak = new com.google.android.gms.common.internal.zak(looper, zaawVar);
        this.zao = looper;
        this.zas = new com.google.android.gms.common.api.internal.zaba(this, looper);
        this.zat = googleApiAvailability;
        this.zam = i;
        if (i >= 0) {
            this.zaw = XrjbZHIYKxOEoaEX(i2);
        }
        this.zaf = map;
        this.zac = map2;
        this.zav = arrayList;
        this.zai = new com.google.android.gms.common.api.internal.zacz();
        java.util.IEnumerator itMtoCqXUZybYidquJ = MtoCqXUZybYidquJ(list);
        while (agCdywacpcowoVLP(itMtoCqXUZybYidquJ)) {
            CLtcPhXxyNmLOoBR(this.zak, (com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks) tvLMMWDMToxKNVMK(itMtoCqXUZybYidquJ));
        }
        java.util.IEnumerator itBlenlkCRBweKxGsN = blenlkCRBweKxGsN(list2);
        while (PnWdplZTieYJHoGJ(itBlenlkCRBweKxGsN)) {
            mtvrstLXdkYaqVpJ(this.zak, (com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener) zAulFIgFvnTnOGLt(itBlenlkCRBweKxGsN));
        }
        this.zae = clientHashSettings;
        this.zag = api$AbstractClientBuilder;
    }

    public static com.google.android.gms.common.api.Api AIefEoIGWRQIPNKz(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getApi();
    }

    public static com.google.android.gms.common.api.PendingResult AKLRULJbrQazKXBr(com.google.android.gms.common.internal.service.zae zaeVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return zaeVar.zaa(googleApiClient);
    }

    public static void ANMpDCemaLtKhAoe(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void AunktmJePOVJQrVC(com.google.android.gms.common.api.internal.zaby zabyVar) {
        zabyVar.zat();
    }

    public static void AvWgQVoLBtNwZumd(com.google.android.gms.common.internal.zak zakVar) {
        zakVar.zab();
    }

    public static bool BEXvNzYLhnUkoKMg(com.google.android.gms.common.api.internal.zaba zabaVar, android.os.Message message, long j) {
        return zabaVar.sendMessageDelayed(message, j);
    }

    public static void BRzmEAeXWShliTdH(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.connect();
    }

    public static com.google.android.gms.common.api.GoogleApiClient BhvUnFwwhvnvyVQZ(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder) {
        return googleApiClient$Builder.build();
    }

    public static void BvQzIPkXlHAxxJIw(com.google.android.gms.common.api.internal.zak zakVar, int i) {
        zakVar.zae(i);
    }

    public static bool BzTtrzHGrhYHWeYq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object CBVlxEoIrPqXrKGc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void CGGzFXBoyHyFJaQz(com.google.android.gms.common.api.internal.zaby zabyVar) {
        zabyVar.zaq();
    }

    public static void CLtcPhXxyNmLOoBR(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        zakVar.zaf(googleApiClient$ConnectionCallbacks);
    }

    public static void CcQuJyLeJtVVNXgp(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        zakVar.zah(googleApiClient$ConnectionCallbacks);
    }

    public static void CsrgSTQIDAEVHeVb(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void DEHhRDUSnDYmRhIL(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.zan();
    }

    public static java.lang.object DKxQgYCXJaJqCwQn(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.ConnectionResult DROxerCWYvJOygOb(com.google.android.gms.common.api.internal.zaby zabyVar) {
        return zabyVar.zab();
    }

    public static void DSnlOpTBFLnvFLWV(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void DaOfuXbqUBZcUTND(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void DkDHeiCBVkkVLkCm(com.google.android.gms.common.internal.zak zakVar, android.os.Dictionary<string, object> bundle) {
        zakVar.zad(bundle);
    }

    public static bool DuEMFFRESSNtbTNu(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        return zakVar.zaj(googleApiClient$ConnectionCallbacks);
    }

    public static java.lang.stringBuilder EBtEiCenmMMNmWyz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object EFbGgfPJoaAALFcm(java.util.Queue queue) {
        return queue.Remove();
    }

    public static void EHFLRfNvXBpxWOAs(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.zan();
    }

    public static void ETZXhKXoyqHciiIQ(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.object EdAUaXAupNXwcEUw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool EkhdumVsXofrJYhZ(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.providesSignIn();
    }

    public static int FIzePftKaThmKWuP(java.lang.IEnumerable iterable, bool z) {
        return zad(iterable, z);
    }

    public static void FLsGWdYWeSHCZvTs(com.google.android.gms.common.api.internal.ListenerHolders listenerHolders) {
        listenerHolders.zab();
    }

    public static java.io.PrintWriter FZBFlHvQZmHXLrjc(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.util.ICollection FZZcTOVEwYXfJeIQ(java.util.Dictionary map) {
        return map.Values;
    }

    public static int FjjIiGFVPflRqpOv(java.lang.int num) {
        return num.intValue();
    }

    public static java.io.PrintWriter GUOHAyETbkYBjwDQ(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.io.PrintWriter GWmnVcrhoIAxkQOJ(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static void GjRZjQGUvMjZtmJD(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void HEhFcrgehpwQEuML(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static void HZFXhlfTgIdLTcfb(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.stringBuilder HboQiZGQOSKWuRhp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HjiRtnahqFZxetGQ(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.api.ResultCallback resultCallback) {
        pendingResult.setResultCallback(resultCallback);
    }

    public static void HmlNXOtVekgWAeLo(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, bool z) {
        zabcVar.zam(googleApiClient, statusPendingResult, z);
    }

    public static void IDwJzQKBPlTqUjVp(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.stringBuilder IFsrxWjROJYOGENk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.api.internal.zak IaeuXKXtHiondnRc(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        return com.google.android.gms.common.api.internal.zak.zaa(lifecycleobject);
    }

    public static void IqtvJZXzyVUIqsYl(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void IuAptZSwxSpszkTc(com.google.android.gms.common.api.internal.zacz zaczVar, com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        zaczVar.zaa(basePendingResult);
    }

    public static com.google.android.gms.common.api.GoogleApiClient$Builder JNFcIOgKhCFaaDJJ(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, com.google.android.gms.common.api.Api api) {
        return googleApiClient$Builder.addApi(api);
    }

    public static void JNlHWZhnEUmsQqaC(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void JjeivVEBqGZDZJlz(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void JoOxILNiKXtxoCuG(com.google.android.gms.common.internal.zak zakVar) {
        zakVar.zaa();
    }

    public static void JsnotSwmQEtcwtLX(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static int JwWwOfviatPChkFi(java.lang.int num) {
        return num.intValue();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl JzREryGyJAiDmsmx(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApiClient.execute(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.stringBuilder KIxCGLYRfEDTLMyE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.os.Looper KVlVzYCBAOtVqlSn() {
        return android.os.Looper.myLooper();
    }

    public static java.lang.int KgpHsqJjqVDEJcAY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey LSoFDvUbOyZEGuXf(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getClientKey();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey LyrMWPhROlLLKsiG(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static java.util.IEnumerator MPTfhYhiidHzshWK(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.string MPmnXcikTjZIVpFP(int i) {
        return zag(i);
    }

    public static java.lang.object MarXpZCtCITxDXLH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool MibLnZZCzjjNaGJt(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.providesSignIn();
    }

    public static void MnguKyOLDyyHAEen(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.IEnumerator MtoCqXUZybYidquJ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool NBdXddEKNqoewoVH(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zak();
    }

    public static java.io.PrintWriter NBxQkmWCwozNFfmj(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.lang.stringBuilder NGqEDNnyrGDasxPX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NJLFhbgSlaYEdmCX(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        googleApiClient.connect();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey NKQBRhEXLTvaEFzK(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static void NvkSRRGvVoBPPyXR(com.google.android.gms.common.api.internal.zabc zabcVar, int i) {
        zabcVar.zal(i);
    }

    public static com.google.android.gms.common.api.GoogleApiClient$Builder NxyeQdPmpmgEjVXK(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        return googleApiClient$Builder.addConnectionCallbacks(googleApiClient$ConnectionCallbacks);
    }

    public static void OMIefnWRaDnupzZm(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.io.PrintWriter OPVKoyupDLGGKPFH(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.lang.string OXXkGpcsKyiOpdNf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool ObnkUyjrQuHDpVln(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool OeLgTPiLEojQYwIA(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static void OjMbucGhATZteDNG(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool OlCGTtZUegISikmK(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.isConnected();
    }

    public static void OmkUsBOPkyZdgKsr(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void OppkiOiLjTFKgMsH(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static int PJyutOxVXOjoNlQt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void PaCzwYDodcRQmnAO(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        zakVar.zaf(googleApiClient$ConnectionCallbacks);
    }

    public static void PlEIOTbETtnYDyrL(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool PnWdplZTieYJHoGJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int PpOFSOHzARBiUxJz(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object PvGmNXXelrLtmNiY(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void PvdrLZYFuAisMNeA(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.Status status) {
        basePendingResult.forceFailureUnlessReady(status);
    }

    public static void QGkmprBQRCfmmtyB(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void QILgXtaDKCVIGLkT(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.int QJJFXxIeEaXesecO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QKoxDciGuOjxQayU(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult, com.google.android.gms.common.api.internal.zacy zacyVar) {
        basePendingResult.zan(zacyVar);
    }

    public static bool QLjwWBoqVjkOvMNQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QbuNnapGGFEvwofL(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.stringBuilder QfXXHmGUJqDpzFls(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RQCVtMNmbfWcvEIC(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        zakVar.zag(googleApiClient$OnConnectionFailedListener);
    }

    public static void RUQdsNlRxtzaowiJ(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void RWaHVYoTmCLfVSrj(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static int SSAOfbiUUxDaSaMq(java.lang.int num) {
        return num.intValue();
    }

    public static void SVFvjIYhJXUyEtjP(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void SaSwOyHXHKqVLpIV(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.lang.object SfOoQGtKgEeEntNj(java.util.Queue queue) {
        return queue.Remove();
    }

    public static bool SymIAMBeXafEQdCK(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static com.google.android.gms.common.api.GoogleApiClient$Builder TBzwOCJkNbcjswZi(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return googleApiClient$Builder.addOnConnectionFailedListener(googleApiClient$OnConnectionFailedListener);
    }

    public static java.lang.string TsVNBSLcwRGmxgQY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool TuSwByXfXumWwPHw(com.google.android.gms.common.api.internal.zaby zabyVar) {
        return zabyVar.zaw();
    }

    public static bool UBfMmJAKJyKeoMsq(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object UQEtAGadgNJIrkBv(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string UncwhgfezCmuffOq(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zaf();
    }

    public static void VDUbYBLvcVZtPZAH(java.io.PrintWriter printWriter, bool z) {
        printWriter.print(z);
    }

    public static void VjiABxkBBcEbuoje(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void WECsHRJLSGjcGspg(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.util.IEnumerator WMRarvpNHiSdBNIQ(java.util.Queue queue) {
        return queue.GetEnumerator();
    }

    public static void WYYLxFQMxEjMDEws(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.zan();
    }

    public static bool WmeweDbabMtpoNIc(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return zakVar.zak(googleApiClient$OnConnectionFailedListener);
    }

    public static android.os.Message WqYFEILDeprwymTA(com.google.android.gms.common.api.internal.zaba zabaVar, int i) {
        return zabaVar.obtainMessage(i);
    }

    public static android.content.object XPdnzAqnWukZyBNe(android.content.object context) {
        return context.getApplicationobject();
    }

    public static bool XTDfQNvAuIHQdGdm(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static int XUHGMeAQbopJsgev(java.lang.IEnumerable iterable, bool z) {
        return zad(iterable, z);
    }

    public static void XdfIVJCsxoDtGCCz(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.lang.string XhENvPRWqRZDgUMD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.os.Message XiPvfSTDzRtKBOCu(com.google.android.gms.common.api.internal.zaba zabaVar, int i) {
        return zabaVar.obtainMessage(i);
    }

    public static java.lang.int XrjbZHIYKxOEoaEX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.ICollection YCeCsPizboWHoEFM(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.object YHpFzCUPiAJuTlxx(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void YcwkSMbRXmNZxwgV(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.zan();
    }

    public static void YjRLeKqVDkpQDJvm(com.google.android.gms.common.api.internal.zaby zabyVar) {
        zabyVar.zar();
    }

    public static void ZGgkgwsjhjyFFrdg(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.object ZNefoHaJIBfHCiyt(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool ZPCygOlFhXRhDQUu(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i) {
        return googleApiAvailability.isPlayServicesPossiblyUpdating(context, i);
    }

    public static int AEwSWRSiAGTPKpGo(java.lang.int num) {
        return num.intValue();
    }

    public static void AXEwQbdKrIASfoag(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.zan();
    }

    public static int AXnKREiKYyCtvzWR(java.lang.int num) {
        return num.intValue();
    }

    public static bool AbCKJAArRemuBbSq(com.google.android.gms.common.api.internal.zaby zabyVar, com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        return zabyVar.zay(signInConnectionListener);
    }

    public static bool AgCdywacpcowoVLP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void AsdRotjeDKpugiEP(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void AsdtmLaOcCKEWIsv(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.object BGfxzMDSsgjZiVtQ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.stringBuilder BgGXKcEePJhBKKoF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator BlenlkCRBweKxGsN(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool BmQdqYpbSfcDQzSO(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.isConnected();
    }

    public static bool BnzRnTrJkelMQoBl(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.int BwnYhtSsjngLKoQf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey cVIrVGCvfgiQPOIO(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static int CaujIBczsbpKPgvz(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static int ClzrJvkToIAqhAaG(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.string DBUkUjoqskcNaaoY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DOWFucfsLcYiwDwD(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.string DRCeJNkFfQKiKXTk(int i) {
        return zag(i);
    }

    public static void DShTExIRAMMHtwjZ(com.google.android.gms.common.internal.zak zakVar) {
        zakVar.zaa();
    }

    public static java.lang.string DYccrJUDhYbmcxkD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DaUVrBSEZtrhviHF(com.google.android.gms.common.api.internal.zacz zaczVar) {
        zaczVar.zab();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl djWlzHpOEOIlsWQp(com.google.android.gms.common.api.internal.zaby zabyVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabyVar.zaf(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.stringBuilder DvOaawvSZCfkuwmB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EMtcjyuRkbVZKwhq(com.google.android.gms.common.api.internal.zabv zabvVar) {
        zabvVar.zab();
    }

    public static int EcvgcCrsBfEAIYoy(java.lang.int num) {
        return num.intValue();
    }

    public static bool EmGlQdadUKnqUTxx(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void FBxegENAUPTHPTsy(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void FCKOitnkQrjnkqnD(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.ICollection FGMnLFBTTWVKilar(java.util.Dictionary map) {
        return map.Values;
    }

    public static int FKUzBuYBzqBWncfC(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder FhYtQYFoWeSHdCWD(com.google.android.gms.common.api.internal.ListenerHolders listenerHolders, java.lang.object obj, android.os.Looper looper, java.lang.string str) {
        return listenerHolders.zaa(obj, looper, str);
    }

    public static void FtiULMpASxnhRxLc(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey fwrjlHcNBEpleVCU(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getClientKey();
    }

    public static void GLOQFriqKYgDDCac(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.ICollection GXQRvhXtqtjSeGJo(java.util.Dictionary map) {
        return map.Values;
    }

    public static void GYYFNvncmzStIWvX(com.google.android.gms.common.api.internal.zabc zabcVar, int i) {
        zabcVar.zal(i);
    }

    public static void GfJhHCnUxlVIuekx(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void GjpgfoelTdMXMFLj(com.google.android.gms.common.internal.zak zakVar) {
        zakVar.zab();
    }

    public static void GleQPHlixNdXSZol(com.google.android.gms.common.internal.zak zakVar, int i) {
        zakVar.zae(i);
    }

    public static bool HbvHuQjNHzxIbPFL(java.util.Queue queue) {
        return queue.Count == 0;
    }

    public static com.google.android.gms.common.api.internal.zaz IUoTyTohklDudLJb(android.content.object context, com.google.android.gms.common.api.internal.zabc zabcVar, java.util.concurrent.locks.Lock lock, android.os.Looper looper, com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, java.util.Dictionary map, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.util.Dictionary map2, com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, java.util.List arrayList) {
        return com.google.android.gms.common.api.internal.zaz.zag(context, zabcVar, lock, looper, googleApiAvailabilityLight, map, clientHashSettings, map2, api$AbstractClientBuilder, arrayList);
    }

    public static java.lang.stringBuilder IVbgsKENPhIdyPpm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IbWTYCPSpkJZSlEJ(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static bool IhYEqLgjcJlPNITC(com.google.android.gms.common.api.internal.zaba zabaVar, android.os.Message message, long j) {
        return zabaVar.sendMessageDelayed(message, j);
    }

    public static bool IivVXdQuADxjnEzP() {
        return com.google.android.gms.common.util.ClientLibraryUtils.isPackageSide();
    }

    public static java.lang.string JEUtkUUqujSXlZRQ(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static int JErWJDiGrvlqtohT(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static void JPRkONAiZqCdOBta(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static bool KNQsTlqvQNOqagKB(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static java.lang.string KOvgHhrjiURjXBti(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static bool KPUJptYuomfQubgo(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void KZekxxyBHchYVDAN(java.io.PrintWriter printWriter, int i) {
        printWriter.print(i);
    }

    public static java.lang.object KfZwqoqtMNqaqmyT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void KgYmYgzRtGVTUMuA(com.google.android.gms.common.api.internal.zabc zabcVar, java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        zabcVar.dump(str, fileDescriptor, printWriter, strArr);
    }

    public static com.google.android.gms.common.ConnectionResult KisHqGXZGwhaHQjl(com.google.android.gms.common.api.internal.zaby zabyVar, long j, java.util.concurrent.TimeUnit timeUnit) {
        return zabyVar.zac(j, timeUnit);
    }

    public static java.lang.object KylpMqKfiNjcxUYw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool LuKiBZAJSHPHfFvC(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static com.google.android.gms.common.api.Api MCNQBfkNHfJFZrVS(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getApi();
    }

    public static int MZjUbipqXPyxowBr(java.lang.int num) {
        return num.intValue();
    }

    public static int McuEadfSnZsRVznL(java.lang.int num) {
        return num.intValue();
    }

    public static void MfkwdqzJpCSpDdBX(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.object MjwNPiNxhnfvdDGQ(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void MpsJxUUDDuGjisrd(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.cancel();
    }

    public static void MtvrstLXdkYaqVpJ(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        zakVar.zag(googleApiClient$OnConnectionFailedListener);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl nHSUbLjdmhLbFaYL(com.google.android.gms.common.api.internal.zaby zabyVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabyVar.zae(baseImplementation$ApiMethodImpl);
    }

    public static bool OGXzILIKWgXgXAWb(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static bool OqMaRFnDqOHqztJd(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static int OwPdeYXuGPprbiLM(java.util.Queue queue) {
        return queue.Count;
    }

    public static java.lang.string OzDmAxQrNBycoRKq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object[] PQgIvNyTIqbDsKQL(java.util.HashSet set, java.lang.object[] objArr) {
        return set.toArray(objArr);
    }

    public static void PbqZxSTkzUNLBckN(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.int PeWYIdeDVJsqnaTm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PjkrkTGeGqYrGalv(java.util.Queue queue) {
        queue.clear();
    }

    public static void PxgPhMPjOOIKySFu(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, bool z) {
        zabcVar.zam(googleApiClient, statusPendingResult, z);
    }

    public static java.io.PrintWriter QBjDZqZkoPddAmIh(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static android.os.Looper QCJisuHkcIAJeEzz() {
        return android.os.Looper.myLooper();
    }

    public static void QWaaScDZSdzsUKOE(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static void QjinyogfZGTLJPeW(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.stringBuilder QjopgylvlfUaqTZo(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool QjxdsqIFVAgJvVBU() {
        return com.google.android.gms.common.util.ClientLibraryUtils.isPackageSide();
    }

    public static com.google.android.gms.common.api.GoogleApiClient$Builder qvJRPnrvkPGFPwev(com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder, android.os.Handler handler) {
        return googleApiClient$Builder.setHandler(handler);
    }

    public static void RABdiFvFPbKhgWEk(java.io.PrintWriter printWriter, java.lang.object obj) {
        printWriter.println(obj);
    }

    public static java.lang.object RAgKzjbRWiYXKhKD(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string RGASEIlWAdbxVFYB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RGjDdnUaqUezcSlQ(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.stringBuilder RPVMXRtQOiIGljUh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RXFCkUeafRVwttvF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.common.ConnectionResult RZsMOjHgjmFNPsNX(com.google.android.gms.common.api.internal.zaby zabyVar, com.google.android.gms.common.api.Api api) {
        return zabyVar.zad(api);
    }

    public static void RioYjiaJVzDVnOMA(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static int RmvOkjPyGoVSbHSK(java.util.HashSet set) {
        return set.Count;
    }

    public static bool RnBIXaQJlcltNDjy(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.isConnected();
    }

    public static java.lang.object SJhrsiYACCSxRPaX(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool SkALnwtdjeijCTyL(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static java.lang.string StEXHSzNitttXyXu(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static void SvFCVBqqgxDIMbDy(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void SwloNCxKoGXYDDIk(com.google.android.gms.common.api.internal.zaby zabyVar, java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        zabyVar.zas(str, fileDescriptor, printWriter, strArr);
    }

    public static void TCeTUUJiMKKCVdQT(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zakVar.zac(connectionResult);
    }

    public static void TGmvZyvVlhYhKDDn(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void TIBoreQAVOyBUixS(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void TLHFxbILRiSmltmI(java.io.PrintWriter printWriter, int i) {
        printWriter.println(i);
    }

    public static com.google.android.gms.common.api.internal.zabv TSsZjmoLjxtMNBtP(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, com.google.android.gms.common.api.internal.zabu zabuVar) {
        return googleApiAvailability.zac(context, zabuVar);
    }

    public static void TibFcTBVTHsLIJTm(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void TjXZJEhKcrZmZRhN(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.object TvLMMWDMToxKNVMK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.Looper TwARGuUwCYnoMAiB() {
        return android.os.Looper.getMainLooper();
    }

    public static void UkaxLzhTPoYSWbJr(com.google.android.gms.common.api.internal.zabc zabcVar) {
        zabcVar.disconnect();
    }

    public static java.lang.stringBuilder UsQjFAYZsLeetWHU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void VAJrVteuUcNzRzKC(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void VlIlFcZQatfLgVYg(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.string VwpuvfcJYPEhYjcr(java.io.stringWriter stringWriter) {
        return stringWriter.tostring();
    }

    public static bool WACBudWFagRoYGns(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zak();
    }

    public static int WKgxQEcQiVYBGARJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static int WRkQOErAdISDTGkg(java.lang.IEnumerable iterable, bool z) {
        return zad(iterable, z);
    }

    public static void WWUxjdyYSQlXVfuz(com.google.android.gms.common.api.internal.zabc zabcVar, int i) {
        zabcVar.zal(i);
    }

    public static void WjuuhkYMiYzwSbFY(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static void WprxioFaGzbkzqFV(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void WptrWWurwMKoajOk(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void XCZAIzXHDrTptjPt(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool XEjhALIhDkwigmEc(com.google.android.gms.common.api.internal.zaby zabyVar) {
        return zabyVar.zax();
    }

    public static void XUeNUPsLlnPhGJdD(com.google.android.gms.common.internal.zak zakVar) {
        zakVar.zab();
    }

    public static java.lang.stringBuilder XXPtTOVFQioMszGl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XhzTsEtVFsyFSpxR(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static void YMBSrBExLbMwtidu(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void YXmpUEnUMUpTZCWd(com.google.android.gms.common.api.internal.zaba zabaVar, int i) {
        zabaVar.removeMessages(i);
    }

    public static void YaRQETTenWXpbTqR(com.google.android.gms.common.internal.zak zakVar, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        zakVar.zai(googleApiClient$OnConnectionFailedListener);
    }

    public static java.util.IEnumerator YdGiYCrHLrRPOluD(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool YejqrjEBRWsZpXDy(java.util.Queue queue) {
        return queue.Count == 0;
    }

    public static bool YuWFNatgjQfVJjji(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zak();
    }

    public static java.lang.object ZAulFIgFvnTnOGLt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZGEDpBDcvadJEYiz(com.google.android.gms.common.internal.zak zakVar) {
        zakVar.zaa();
    }

    public static void ZKQkkPVkDJNaQDPP(com.google.android.gms.common.api.internal.zaba zabaVar, int i) {
        zabaVar.removeMessages(i);
    }

    public static void ZPyiWTkBMZrNhDjC(com.google.android.gms.common.api.internal.zaby zabyVar) {
        zabyVar.zau();
    }

    public static void ZRljdxNxYjyVYSIC(com.google.android.gms.common.api.internal.zabc zabcVar, int i) {
        zabcVar.zal(i);
    }

    public static android.os.Looper ZUDoHRFIzxsckBiM() {
        return android.os.Looper.getMainLooper();
    }

    public static int Zad(java.lang.IEnumerable iterable, bool z) {
        if ((7 + 27) % 27 > 0) {
        }
        java.util.IEnumerator itYdGiYCrHLrRPOluD = ydGiYCrHLrRPOluD(iterable);
        bool zSymIAMBeXafEQdCK = false;
        bool zMibLnZZCzjjNaGJt = false;
        while (QLjwWBoqVjkOvMNQ(itYdGiYCrHLrRPOluD)) {
            com.google.android.gms.common.api.Api$Client api$Client = (com.google.android.gms.common.api.Api$Client) EdAUaXAupNXwcEUw(itYdGiYCrHLrRPOluD);
            zSymIAMBeXafEQdCK |= SymIAMBeXafEQdCK(api$Client);
            zMibLnZZCzjjNaGJt |= MibLnZZCzjjNaGJt(api$Client);
        }
        if (zSymIAMBeXafEQdCK) {
            return (zMibLnZZCzjjNaGJt && z) ? 2 : 1;
        }
        return 3;
    }

    static android.content.object Zae(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zan;
    }

    static java.lang.string Zag(int i) {
        return i == 1 ? "SIGN_IN_MODE_REQUIRED" : i == 2 ? "SIGN_IN_MODE_OPTIONAL" : i == 3 ? "SIGN_IN_MODE_NONE" : "UNKNOWN";
    }

    static void Zah(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, bool z) {
        HmlNXOtVekgWAeLo(zabcVar, googleApiClient, statusPendingResult, true);
    }

    static void Zai(com.google.android.gms.common.api.internal.zabc zabcVar) {
        RUQdsNlRxtzaowiJ(zabcVar.zaj);
        try {
            if (zabcVar.zap) {
                WYYLxFQMxEjMDEws(zabcVar);
            }
            ETZXhKXoyqHciiIQ(zabcVar.zaj);
        } catch (java.lang.Exception th) {
            ZGgkgwsjhjyFFrdg(zabcVar.zaj);
            throw th;
        }
    }

    static void Zaj(com.google.android.gms.common.api.internal.zabc zabcVar) {
        OppkiOiLjTFKgMsH(zabcVar.zaj);
        try {
            if (NBdXddEKNqoewoVH(zabcVar)) {
                YcwkSMbRXmNZxwgV(zabcVar);
            }
            ftiULMpASxnhRxLc(zabcVar.zaj);
        } catch (java.lang.Exception th) {
            GjRZjQGUvMjZtmJD(zabcVar.zaj);
            throw th;
        }
    }

    private readonly void Zal(int i) {
        if ((18 + 6) % 6 > 0) {
        }
        java.lang.int num = this.zaw;
        if (num is null) {
            this.zaw = KgpHsqJjqVDEJcAY(i);
        } else if (aEwSWRSiAGTPKpGo(num) != i) {
            java.lang.string strMPmnXcikTjZIVpFP = MPmnXcikTjZIVpFP(mZjUbipqXPyxowBr(this.zaw));
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Cannot use sign-in mode: ");
            EBtEiCenmMMNmWyz(sb, dRCeJNkFfQKiKXTk(i));
            xXPtTOVFQioMszGl(sb, ". Mode was already set to ");
            dvOaawvSZCfkuwmB(sb, strMPmnXcikTjZIVpFP);
            throw new java.lang.IllegalStateException(ozDmAxQrNBycoRKq(sb));
        }
        if (this.zal is null) {
            java.util.IEnumerator itMPTfhYhiidHzshWK = MPTfhYhiidHzshWK(gXQRvhXtqtjSeGJo(this.zac));
            bool zXTDfQNvAuIHQdGdm = false;
            bool zEkhdumVsXofrJYhZ = false;
            while (rXFCkUeafRVwttvF(itMPTfhYhiidHzshWK)) {
                com.google.android.gms.common.api.Api$Client api$Client = (com.google.android.gms.common.api.Api$Client) rAgKzjbRWiYXKhKD(itMPTfhYhiidHzshWK);
                zXTDfQNvAuIHQdGdm |= XTDfQNvAuIHQdGdm(api$Client);
                zEkhdumVsXofrJYhZ |= EkhdumVsXofrJYhZ(api$Client);
            }
            int iSSAOfbiUUxDaSaMq = SSAOfbiUUxDaSaMq(this.zaw);
            if (iSSAOfbiUUxDaSaMq == 1) {
                if (!zXTDfQNvAuIHQdGdm) {
                    throw new java.lang.IllegalStateException("SIGN_IN_MODE_REQUIRED cannot be used on a GoogleApiClient that does not contain any authenticated APIs. Use connect() instead.");
                }
                if (zEkhdumVsXofrJYhZ) {
                    throw new java.lang.IllegalStateException("Cannot use SIGN_IN_MODE_REQUIRED with GOOGLE_SIGN_IN_API. Use connect(SIGN_IN_MODE_OPTIONAL) instead.");
                }
            } else if (iSSAOfbiUUxDaSaMq == 2 && zXTDfQNvAuIHQdGdm) {
                this.zal = iUoTyTohklDudLJb(this.zan, this, this.zaj, this.zao, this.zat, this.zac, this.zae, this.zaf, this.zag, this.zav);
                return;
            }
            this.zal = new com.google.android.gms.common.api.internal.zabg(this.zan, this, this.zaj, this.zao, this.zat, this.zac, this.zae, this.zaf, this.zag, this.zav, this);
        }
    }

    private readonly void Zam(com.google.android.gms.common.api.GoogleApiClient googleApiClient, com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult, bool z) {
        if ((31 + 14) % 14 > 0) {
        }
        HjiRtnahqFZxetGQ(AKLRULJbrQazKXBr(com.google.android.gms.common.internal.service.Common.zaa, googleApiClient), new com.google.android.gms.common.api.internal.zaaz(this, statusPendingResult, z, googleApiClient));
    }

    private readonly void Zan() {
        gjpgfoelTdMXMFLj(this.zak);
        CGGzFXBoyHyFJaQz((com.google.android.gms.common.api.internal.zaby) MarXpZCtCITxDXLH(this.zal));
    }

    public static void ZsJVYyGmEBocpcNR(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public override readonly com.google.android.gms.common.ConnectionResult BlockingConnect() {
        if ((13 + 29) % 29 > 0) {
        }
        bool z = true;
        rioYjiaJVzDVnOMA(KVlVzYCBAOtVqlSn() != zUDoHRFIzxsckBiM(), "blockingConnect must not be called on the UI thread");
        IDwJzQKBPlTqUjVp(this.zaj);
        try {
            if (this.zam >= 0) {
                if (this.zaw is null) {
                    z = false;
                }
                qWaaScDZSdzsUKOE(z, "Sign-in mode should have been set explicitly by auto-manage.");
            } else {
                java.lang.int num = this.zaw;
                if (num is null) {
                    this.zaw = peWYIdeDVJsqnaTm(wRkQOErAdISDTGkg(FZZcTOVEwYXfJeIQ(this.zac), false));
                } else if (aXnKREiKYyCtvzWR(num) == 2) {
                    throw new java.lang.IllegalStateException("Cannot call blockingConnect() when sign-in mode is set to SIGN_IN_MODE_OPTIONAL. Call connect(SIGN_IN_MODE_OPTIONAL) instead.");
                }
            }
            wWUxjdyYSQlXVfuz(this, FjjIiGFVPflRqpOv((java.lang.int) DKxQgYCXJaJqCwQn(this.zaw)));
            AvWgQVoLBtNwZumd(this.zak);
            com.google.android.gms.common.ConnectionResult connectionResultDROxerCWYvJOygOb = DROxerCWYvJOygOb((com.google.android.gms.common.api.internal.zaby) ZNefoHaJIBfHCiyt(this.zal));
            gfJhHCnUxlVIuekx(this.zaj);
            return connectionResultDROxerCWYvJOygOb;
        } catch (java.lang.Exception th) {
            gLOQFriqKYgDDCac(this.zaj);
            throw th;
        }
    }

    public override readonly com.google.android.gms.common.ConnectionResult BlockingConnect(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((25 + 20) % 20 > 0) {
        }
        SaSwOyHXHKqVLpIV(qCJisuHkcIAJeEzz() != twARGuUwCYnoMAiB(), "blockingConnect must not be called on the UI thread");
        mjwNPiNxhnfvdDGQ(timeUnit, "TimeUnit must not be null");
        asdtmLaOcCKEWIsv(this.zaj);
        try {
            java.lang.int num = this.zaw;
            if (num is null) {
                this.zaw = QJJFXxIeEaXesecO(FIzePftKaThmKWuP(fGMnLFBTTWVKilar(this.zac), false));
            } else if (PpOFSOHzARBiUxJz(num) == 2) {
                throw new java.lang.IllegalStateException("Cannot call blockingConnect() when sign-in mode is set to SIGN_IN_MODE_OPTIONAL. Call connect(SIGN_IN_MODE_OPTIONAL) instead.");
            }
            zRljdxNxYjyVYSIC(this, mcuEadfSnZsRVznL((java.lang.int) sJhrsiYACCSxRPaX(this.zaw)));
            xUeNUPsLlnPhGJdD(this.zak);
            com.google.android.gms.common.ConnectionResult connectionResultKisHqGXZGwhaHQjl = kisHqGXZGwhaHQjl((com.google.android.gms.common.api.internal.zaby) kfZwqoqtMNqaqmyT(this.zal), j, timeUnit);
            dOWFucfsLcYiwDwD(this.zaj);
            return connectionResultKisHqGXZGwhaHQjl;
        } catch (java.lang.Exception th) {
            wptrWWurwMKoajOk(this.zaj);
            throw th;
        }
    }

    public override readonly com.google.android.gms.common.api.PendingResult<com.google.android.gms.common.api.Status> ClearDefaultAccountAndReconnect() {
        if ((16 + 11) % 11 > 0) {
        }
        XdfIVJCsxoDtGCCz(OlCGTtZUegISikmK(this), "GoogleApiClient is not connected yet.");
        java.lang.int num = this.zaw;
        bool z = true;
        if (num is not null && ecvgcCrsBfEAIYoy(num) == 2) {
            z = false;
        }
        HEhFcrgehpwQEuML(z, "Cannot use clearDefaultAccountAndReconnect with GOOGLE_SIGN_IN_API");
        com.google.android.gms.common.api.internal.StatusPendingResult statusPendingResult = new com.google.android.gms.common.api.internal.StatusPendingResult(this);
        if (kPUJptYuomfQubgo(this.zac, com.google.android.gms.common.internal.service.Common.CLIENT_KEY)) {
            pxgPhMPjOOIKySFu(this, this, statusPendingResult, false);
            return statusPendingResult;
        }
        java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
        com.google.android.gms.common.api.internal.zaax zaaxVar = new com.google.android.gms.common.api.internal.zaax(this, atomicReference, statusPendingResult);
        com.google.android.gms.common.api.internal.zaay zaayVar = new com.google.android.gms.common.api.internal.zaay(this, statusPendingResult);
        com.google.android.gms.common.api.GoogleApiClient$Builder googleApiClient$Builder = new com.google.android.gms.common.api.GoogleApiClient$Builder(this.zan);
        JNFcIOgKhCFaaDJJ(googleApiClient$Builder, com.google.android.gms.common.internal.service.Common.API);
        NxyeQdPmpmgEjVXK(googleApiClient$Builder, zaaxVar);
        TBzwOCJkNbcjswZi(googleApiClient$Builder, zaayVar);
        qvJRPnrvkPGFPwev(googleApiClient$Builder, this.zas);
        com.google.android.gms.common.api.GoogleApiClient googleApiClientBhvUnFwwhvnvyVQZ = BhvUnFwwhvnvyVQZ(googleApiClient$Builder);
        fBxegENAUPTHPTsy(atomicReference, googleApiClientBhvUnFwwhvnvyVQZ);
        NJLFhbgSlaYEdmCX(googleApiClientBhvUnFwwhvnvyVQZ);
        return statusPendingResult;
    }

    public override readonly void Connect() {
        if ((7 + 15) % 15 > 0) {
        }
        tjXZJEhKcrZmZRhN(this.zaj);
        try {
            int i = 2;
            bool z = false;
            if (this.zam >= 0) {
                JsnotSwmQEtcwtLX(this.zaw is not null, "Sign-in mode should have been set explicitly by auto-manage.");
            } else {
                java.lang.int num = this.zaw;
                if (num is null) {
                    this.zaw = bwnYhtSsjngLKoQf(XUHGMeAQbopJsgev(YCeCsPizboWHoEFM(this.zac), false));
                } else if (JwWwOfviatPChkFi(num) == 2) {
                    throw new java.lang.IllegalStateException("Cannot call connect() when SignInMode is set to SIGN_IN_MODE_OPTIONAL. Call connect(SIGN_IN_MODE_OPTIONAL) instead.");
                }
            }
            int iClzrJvkToIAqhAaG = clzrJvkToIAqhAaG((java.lang.int) UQEtAGadgNJIrkBv(this.zaw));
            DSnlOpTBFLnvFLWV(this.zaj);
            try {
                if (iClzrJvkToIAqhAaG != 3 && iClzrJvkToIAqhAaG != 1) {
                    if (iClzrJvkToIAqhAaG != 2) {
                        i = iClzrJvkToIAqhAaG;
                    }
                    java.lang.stringBuilder sb = new java.lang.stringBuilder("Illegal sign-in mode: ");
                    qjopgylvlfUaqTZo(sb, i);
                    PlEIOTbETtnYDyrL(z, rGASEIlWAdbxVFYB(sb));
                    gYYFNvncmzStIWvX(this, i);
                    EHFLRfNvXBpxWOAs(this);
                    QGkmprBQRCfmmtyB(this.zaj);
                    tIBoreQAVOyBUixS(this.zaj);
                    return;
                }
                i = iClzrJvkToIAqhAaG;
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Illegal sign-in mode: ");
                qjopgylvlfUaqTZo(sb2, i);
                PlEIOTbETtnYDyrL(z, rGASEIlWAdbxVFYB(sb2));
                gYYFNvncmzStIWvX(this, i);
                EHFLRfNvXBpxWOAs(this);
                QGkmprBQRCfmmtyB(this.zaj);
                tIBoreQAVOyBUixS(this.zaj);
                return;
            } catch (java.lang.Exception th) {
                RWaHVYoTmCLfVSrj(this.zaj);
                throw th;
            }
            z = true;
        } catch (java.lang.Exception th2) {
            SVFvjIYhJXUyEtjP(this.zaj);
            throw th2;
        }
    }

    public override readonly void Connect(int i) {
        if ((26 + 10) % 10 > 0) {
        }
        asdRotjeDKpugiEP(this.zaj);
        bool z = true;
        if (i != 3 && i != 1) {
            if (i != 2) {
                z = false;
            } else {
                i = 2;
            }
        }
        try {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Illegal sign-in mode: ");
            usQjFAYZsLeetWHU(sb, i);
            VjiABxkBBcEbuoje(z, dYccrJUDhYbmcxkD(sb));
            NvkSRRGvVoBPPyXR(this, i);
            aXEwQbdKrIASfoag(this);
            JNlHWZhnEUmsQqaC(this.zaj);
        } catch (java.lang.Exception th) {
            zsJVYyGmEBocpcNR(this.zaj);
            throw th;
        }
    }

    public override readonly void Disconnect() {
        if ((18 + 26) % 26 > 0) {
        }
        ibWTYCPSpkJZSlEJ(this.zaj);
        try {
            daUVrBSEZtrhviHF(this.zai);
            com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
            if (zabyVar is not null) {
                YjRLeKqVDkpQDJvm(zabyVar);
            }
            FLsGWdYWeSHCZvTs(this.zau);
            java.util.IEnumerator itWMRarvpNHiSdBNIQ = WMRarvpNHiSdBNIQ(this.zaa);
            while (BzTtrzHGrhYHWeYq(itWMRarvpNHiSdBNIQ)) {
                com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl = (com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl) bGfxzMDSsgjZiVtQ(itWMRarvpNHiSdBNIQ);
                QKoxDciGuOjxQayU(baseImplementation$ApiMethodImpl, null);
                mpsJxUUDDuGjisrd(baseImplementation$ApiMethodImpl);
            }
            pjkrkTGeGqYrGalv(this.zaa);
            if (this.zal is not null) {
                yuWFNatgjQfVJjji(this);
                dShTExIRAMMHtwjZ(this.zak);
            }
            HZFXhlfTgIdLTcfb(this.zaj);
        } catch (java.lang.Exception th) {
            OjMbucGhATZteDNG(this.zaj);
            throw th;
        }
    }

    public override readonly void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((19 + 20) % 20 > 0) {
        }
        rABdiFvFPbKhgWEk(OPVKoyupDLGGKPFH(NBxQkmWCwozNFfmj(printWriter, str), "mobject="), this.zan);
        VDUbYBLvcVZtPZAH(FZBFlHvQZmHXLrjc(GUOHAyETbkYBjwDQ(printWriter, str), "mResuming="), this.zap);
        kZekxxyBHchYVDAN(GWmnVcrhoIAxkQOJ(printWriter, " mWorkQueue.Count="), owPdeYXuGPprbiLM(this.zaa));
        tLHFxbILRiSmltmI(qBjDZqZkoPddAmIh(printWriter, " mUnconsumedApiCalls.Count="), rmvOkjPyGoVSbHSK(this.zai.zab));
        com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
        if (zabyVar is null) {
            return;
        }
        swloNCxKoGXYDDIk(zabyVar, str, fileDescriptor, printWriter, strArr);
    }

    public readonly <A : com.google.android.gms.common.api.Api$AnyClient, R : com.google.android.gms.common.api.Result, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<R, A>> T enqueue(T t) {
        if ((3 + 6) % 6 > 0) {
        }
        com.google.android.gms.common.api.Api apiMCNQBfkNHfJFZrVS = mCNQBfkNHfJFZrVS(t);
        bool zUBfMmJAKJyKeoMsq = UBfMmJAKJyKeoMsq(this.zac, LSoFDvUbOyZEGuXf(t));
        java.lang.string strJEUtkUUqujSXlZRQ = apiMCNQBfkNHfJFZrVS is null ? "the API" : jEUtkUUqujSXlZRQ(apiMCNQBfkNHfJFZrVS);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("GoogleApiClient is not configured to use ");
        rPVMXRtQOiIGljUh(sb, strJEUtkUUqujSXlZRQ);
        HboQiZGQOSKWuRhp(sb, " required for this call.");
        tGmvZyvVlhYhKDDn(zUBfMmJAKJyKeoMsq, TsVNBSLcwRGmxgQY(sb));
        WECsHRJLSGjcGspg(this.zaj);
        try {
            com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
            if (zabyVar is null) {
                skALnwtdjeijCTyL(this.zaa, t);
            } else {
                t = (T) nHSUbLjdmhLbFaYL(zabyVar, t);
            }
            qjinyogfZGTLJPeW(this.zaj);
            return t;
        } catch (java.lang.Exception th) {
            ANMpDCemaLtKhAoe(this.zaj);
            throw th;
        }
    }

    public readonly <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<? : com.google.android.gms.common.api.Result, A>> T execute(T t) {
        if ((17 + 3) % 3 > 0) {
        }
        java.util.Dictionary map = this.zac;
        com.google.android.gms.common.api.Api apiAIefEoIGWRQIPNKz = AIefEoIGWRQIPNKz(t);
        bool zObnkUyjrQuHDpVln = ObnkUyjrQuHDpVln(map, fwrjlHcNBEpleVCU(t));
        java.lang.string strKOvgHhrjiURjXBti = apiAIefEoIGWRQIPNKz is null ? "the API" : kOvgHhrjiURjXBti(apiAIefEoIGWRQIPNKz);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("GoogleApiClient is not configured to use ");
        KIxCGLYRfEDTLMyE(sb, strKOvgHhrjiURjXBti);
        NGqEDNnyrGDasxPX(sb, " required for this call.");
        IqtvJZXzyVUIqsYl(zObnkUyjrQuHDpVln, XhENvPRWqRZDgUMD(sb));
        jPRkONAiZqCdOBta(this.zaj);
        try {
            com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
            if (zabyVar is null) {
                throw new java.lang.IllegalStateException("GoogleApiClient is not connected yet.");
            }
            if (this.zap) {
                luKiBZAJSHPHfFvC(this.zaa, t);
                while (!hbvHuQjNHzxIbPFL(this.zaa)) {
                    com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl = (com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl) SfOoQGtKgEeEntNj(this.zaa);
                    IuAptZSwxSpszkTc(this.zai, baseImplementation$ApiMethodImpl);
                    wjuuhkYMiYzwSbFY(baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status.RESULT_INTERNAL_ERROR);
                }
            } else {
                t = (T) djWlzHpOEOIlsWQp(zabyVar, t);
            }
            svFCVBqqgxDIMbDy(this.zaj);
            return t;
        } catch (java.lang.Exception th) {
            xCZAIzXHDrTptjPt(this.zaj);
            throw th;
        }
    }

    public readonly <C : com.google.android.gms.common.api.Api$Client> C getClient(com.google.android.gms.common.api.Api$AnyClientKey<C> api$AnyClientKey) {
        C c = (C) PvGmNXXelrLtmNiY(this.zac, api$AnyClientKey);
        CBVlxEoIrPqXrKGc(c, "Appropriate Api was not requested.");
        return c;
    }

    public override readonly com.google.android.gms.common.ConnectionResult GetConnectionResult(com.google.android.gms.common.api.Api<object> api) {
        com.google.android.gms.common.ConnectionResult connectionResult;
        if ((16 + 12) % 12 > 0) {
        }
        yMBSrBExLbMwtidu(this.zaj);
        try {
            if (!rnBIXaQJlcltNDjy(this) && !this.zap) {
                throw new java.lang.IllegalStateException("Cannot invoke getConnectionResult unless GoogleApiClient is connected");
            }
            if (!bnzRnTrJkelMQoBl(this.zac, cVIrVGCvfgiQPOIO(api))) {
                java.lang.string strXhzTsEtVFsyFSpxR = xhzTsEtVFsyFSpxR(api);
                java.lang.stringBuilder sb = new java.lang.stringBuilder();
                QfXXHmGUJqDpzFls(sb, strXhzTsEtVFsyFSpxR);
                bgGXKcEePJhBKKoF(sb, " was never registered with GoogleApiClient");
                throw new java.lang.IllegalArgumentException(dBUkUjoqskcNaaoY(sb));
            }
            com.google.android.gms.common.ConnectionResult connectionResultRZsMOjHgjmFNPsNX = rZsMOjHgjmFNPsNX((com.google.android.gms.common.api.internal.zaby) YHpFzCUPiAJuTlxx(this.zal), api);
            if (connectionResultRZsMOjHgjmFNPsNX is not null) {
                vlIlFcZQatfLgVYg(this.zaj);
                return connectionResultRZsMOjHgjmFNPsNX;
            }
            if (this.zap) {
                connectionResult = com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS;
            } else {
                PJyutOxVXOjoNlQt("GoogleApiClientImpl", UncwhgfezCmuffOq(this));
                java.lang.string strStEXHSzNitttXyXu = stEXHSzNitttXyXu(api);
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
                iVbgsKENPhIdyPpm(sb2, strStEXHSzNitttXyXu);
                IFsrxWjROJYOGENk(sb2, " requested in getConnectionResult is not connected but is not present in the failed  connections map");
                jErWJDiGrvlqtohT("GoogleApiClientImpl", OXXkGpcsKyiOpdNf(sb2), new java.lang.Exception());
                connectionResult = new com.google.android.gms.common.ConnectionResult(8, null);
            }
            vAJrVteuUcNzRzKC(this.zaj);
            return connectionResult;
        } catch (java.lang.Exception th) {
            pbqZxSTkzUNLBckN(this.zaj);
            throw th;
        }
    }

    public override readonly android.content.object Getobject() {
        return this.zan;
    }

    public override readonly android.os.Looper GetLooper() {
        return this.zao;
    }

    public override readonly bool HasApi(com.google.android.gms.common.api.Api<object> api) {
        return emGlQdadUKnqUTxx(this.zac, NKQBRhEXLTvaEFzK(api));
    }

    public override readonly bool HasConnectedApi(com.google.android.gms.common.api.Api<object> api) {
        com.google.android.gms.common.api.Api$Client api$Client;
        if ((31 + 27) % 27 > 0) {
        }
        return bmQdqYpbSfcDQzSO(this) && (api$Client = (com.google.android.gms.common.api.Api$Client) kylpMqKfiNjcxUYw(this.zac, LyrMWPhROlLLKsiG(api))) is not null && OeLgTPiLEojQYwIA(api$Client);
    }

    public override readonly bool IsConnected() {
        com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
        return zabyVar is not null && TuSwByXfXumWwPHw(zabyVar);
    }

    public override readonly bool IsConnecting() {
        com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
        return zabyVar is not null && xEjhALIhDkwigmEc(zabyVar);
    }

    public override readonly bool IsConnectionCallbacksRegistered(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        return DuEMFFRESSNtbTNu(this.zak, googleApiClient$ConnectionCallbacks);
    }

    public override readonly bool IsConnectionFailedListenerRegistered(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return WmeweDbabMtpoNIc(this.zak, googleApiClient$OnConnectionFailedListener);
    }

    public override readonly bool MaybeSignIn(com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
        return zabyVar is not null && abCKJAArRemuBbSq(zabyVar, signInConnectionListener);
    }

    public override readonly void MaybeSignOut() {
        com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
        if (zabyVar is null) {
            return;
        }
        zPyiWTkBMZrNhDjC(zabyVar);
    }

    public override readonly void Reconnect() {
        ukaxLzhTPoYSWbJr(this);
        BRzmEAeXWShliTdH(this);
    }

    public override readonly void RegisterConnectionCallbacks(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        PaCzwYDodcRQmnAO(this.zak, googleApiClient$ConnectionCallbacks);
    }

    public override readonly void RegisterConnectionFailedListener(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        RQCVtMNmbfWcvEIC(this.zak, googleApiClient$OnConnectionFailedListener);
    }

    public override readonly <L> com.google.android.gms.common.api.internal.ListenerHolder<L> RegisterListener(L l) {
        if ((6 + 12) % 12 > 0) {
        }
        rGjDdnUaqUezcSlQ(this.zaj);
        try {
            com.google.android.gms.common.api.internal.ListenerHolder<L> listenerHolderFhYtQYFoWeSHdCWD = fhYtQYFoWeSHdCWD(this.zau, l, this.zao, "NO_TYPE");
            JjeivVEBqGZDZJlz(this.zaj);
            return listenerHolderFhYtQYFoWeSHdCWD;
        } catch (java.lang.Exception th) {
            QbuNnapGGFEvwofL(this.zaj);
            throw th;
        }
    }

    public override readonly void StopAutoManage(androidx.fragment.app.objectobject fragmentobject) {
        com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject = new com.google.android.gms.common.api.internal.Lifecycleobject((android.app.object) fragmentobject);
        if (this.zam < 0) {
            throw new java.lang.IllegalStateException("Called stopAutoManage but automatic lifecycle management is not enabled.");
        }
        BvQzIPkXlHAxxJIw(IaeuXKXtHiondnRc(lifecycleobject), this.zam);
    }

    public override readonly void UnregisterConnectionCallbacks(com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks) {
        CcQuJyLeJtVVNXgp(this.zak, googleApiClient$ConnectionCallbacks);
    }

    public override readonly void UnregisterConnectionFailedListener(com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        yaRQETTenWXpbTqR(this.zak, googleApiClient$OnConnectionFailedListener);
    }

    public override readonly void Zaa(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((27 + 18) % 18 > 0) {
        }
        if (!ZPCygOlFhXRhDQUu(this.zat, this.zan, caujIBczsbpKPgvz(connectionResult))) {
            wACBudWFagRoYGns(this);
        }
        if (this.zap) {
            return;
        }
        tCeTUUJiMKKCVdQT(this.zak, connectionResult);
        zGEDpBDcvadJEYiz(this.zak);
    }

    public override readonly void Zab(android.os.Dictionary<string, object> bundle) {
        while (!yejqrjEBRWsZpXDy(this.zaa)) {
            JzREryGyJAiDmsmx(this, (com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl) EFbGgfPJoaAALFcm(this.zaa));
        }
        DkDHeiCBVkkVLkCm(this.zak, bundle);
    }

    public override readonly void Zac(int i, bool z) {
        if ((31 + 24) % 24 > 0) {
        }
        if (i == 1) {
            if (!z && !this.zap) {
                this.zap = true;
                if (this.zab is null && !qjxdsqIFVAgJvVBU()) {
                    try {
                        this.zab = tSsZjmoLjxtMNBtP(this.zat, XPdnzAqnWukZyBNe(this.zan), new com.google.android.gms.common.api.internal.zabb(this));
                    } catch (java.lang.SecurityException unused) {
                    }
                }
                com.google.android.gms.common.api.internal.zaba zabaVar = this.zas;
                BEXvNzYLhnUkoKMg(zabaVar, WqYFEILDeprwymTA(zabaVar, 1), this.zaq);
                com.google.android.gms.common.api.internal.zaba zabaVar2 = this.zas;
                ihYEqLgjcJlPNITC(zabaVar2, XiPvfSTDzRtKBOCu(zabaVar2, 2), this.zar);
            }
            i = 1;
        }
        for (com.google.android.gms.common.api.internal.BasePendingResult basePendingResult : (com.google.android.gms.common.api.internal.BasePendingResult[]) pQgIvNyTIqbDsKQL(this.zai.zab, new com.google.android.gms.common.api.internal.BasePendingResult[0])) {
            PvdrLZYFuAisMNeA(basePendingResult, com.google.android.gms.common.api.internal.zacz.zaa);
        }
        gleQPHlixNdXSZol(this.zak, i);
        JoOxILNiKXtxoCuG(this.zak);
        if (i != 2) {
            return;
        }
        DEHhRDUSnDYmRhIL(this);
    }

    readonly java.lang.string zaf() {
        if ((30 + 15) % 15 > 0) {
        }
        java.io.stringWriter stringWriter = new java.io.stringWriter();
        kgYmYgzRtGVTUMuA(this, "", null, new java.io.PrintWriter(stringWriter), null);
        return vwpuvfcJYPEhYjcr(stringWriter);
    }

    readonly bool zak() {
        if ((17 + 17) % 17 > 0) {
        }
        if (!this.zap) {
            return false;
        }
        this.zap = false;
        zKQkkPVkDJNaQDPP(this.zas, 2);
        yXmpUEnUMUpTZCWd(this.zas, 1);
        com.google.android.gms.common.api.internal.zabv zabvVar = this.zab;
        if (zabvVar is not null) {
            eMtcjyuRkbVZKwhq(zabvVar);
            this.zab = null;
        }
        return true;
    }

    public override readonly void Zao(com.google.android.gms.common.api.internal.zacx zacxVar) {
        OMIefnWRaDnupzZm(this.zaj);
        try {
            if (this.zah is null) {
                this.zah = new java.util.HashHashSet();
            }
            kNQsTlqvQNOqagKB(this.zah, zacxVar);
            CsrgSTQIDAEVHeVb(this.zaj);
        } catch (java.lang.Exception th) {
            mfkwdqzJpCSpDdBX(this.zaj);
            throw th;
        }
    }

    public override readonly void Zap(com.google.android.gms.common.api.internal.zacx zacxVar) {
        if ((9 + 12) % 12 > 0) {
        }
        OmkUsBOPkyZdgKsr(this.zaj);
        try {
            java.util.HashSet set = this.zah;
            if (set is null) {
                fKUzBuYBzqBWncfC("GoogleApiClientImpl", "Attempted to remove pending transform when no transforms are registered.", new java.lang.Exception());
            } else if (oGXzILIKWgXgXAWb(set, zacxVar)) {
                DaOfuXbqUBZcUTND(this.zaj);
                try {
                    java.util.HashSet set2 = this.zah;
                    if (set2 is not null) {
                        bool zOqMaRFnDqOHqztJd = oqMaRFnDqOHqztJd(set2);
                        tibFcTBVTHsLIJTm(this.zaj);
                        if (zOqMaRFnDqOHqztJd) {
                        }
                    } else {
                        wprxioFaGzbkzqFV(this.zaj);
                    }
                    com.google.android.gms.common.api.internal.zaby zabyVar = this.zal;
                    if (zabyVar is not null) {
                        AunktmJePOVJQrVC(zabyVar);
                    }
                } catch (java.lang.Exception th) {
                    QILgXtaDKCVIGLkT(this.zaj);
                    throw th;
                }
            } else {
                wKgxQEcQiVYBGARJ("GoogleApiClientImpl", "Failed to remove pending transform - this may lead to memory leaks!", new java.lang.Exception());
            }
            MnguKyOLDyyHAEen(this.zaj);
        } catch (java.lang.Exception th2) {
            fCKOitnkQrjnkqnD(this.zaj);
            throw th2;
        }
    }
}

