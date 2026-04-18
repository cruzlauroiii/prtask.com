namespace WillowMaze.Wasm.Decompiled;


public readonly class zaau : com.google.android.gms.common.api.internal.zabd {
    private readonly com.google.android.gms.common.api.internal.zabg zaa;
    private readonly java.util.concurrent.locks.Lock zab;
    private readonly android.content.object zac;
    private readonly com.google.android.gms.common.GoogleApiAvailabilityLight zad;
    private com.google.android.gms.common.ConnectionResult zae;
    private int zaf;
    private int zah;
    private com.google.android.gms.signin.zae zak;
    private bool zal;
    private bool zam;
    private bool zan;
    private com.google.android.gms.common.internal.IAccountAccessor zao;
    private bool zap;
    private bool zaq;
    private readonly com.google.android.gms.common.internal.ClientHashSettings zar;
    private readonly java.util.Dictionary zas;
    private readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zat;
    private int zag = 0;
    private readonly android.os.Dictionary<string, object> zai = new android.os.Dictionary<string, object>();
    private readonly java.util.HashSet zaj = new java.util.HashHashSet();
    private readonly java.util.List zau = new java.util.List();

    public zaau(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.util.Dictionary map, com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, java.util.concurrent.locks.Lock lock, android.content.object context) {
        this.zaa = zabgVar;
        this.zar = clientHashSettings;
        this.zas = map;
        this.zad = googleApiAvailabilityLight;
        this.zat = api$AbstractClientBuilder;
        this.zab = lock;
        this.zac = context;
    }

    public static void AOnRokFkWSGAscHX(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaC();
    }

    public static void ATOROroJQcWEegVg(java.util.Dictionary map) {
        map.clear();
    }

    public static java.util.HashSet AsxsXEguGgWaNAMy(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object BMveLtYxHFIQDHbu(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int BWbVuXhZKwjzAsvP(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.common.api.Api$Client BqfigJZeWkuErsLw(com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return api$AbstractClientBuilder.buildClient(context, looper, clientHashSettings, obj, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
    }

    public static bool DRtdFlPRzEsifLKX(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static bool DslXaZyiXAebupHT(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void DttWWmvcJltOJvOC(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zai();
    }

    public static void DvLnPZYzVUdbDDbR(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        zaauVar.zaE(connectionResult, api, z);
    }

    public static bool DxDkbedKoIIEGoou(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void EPEYVeXqFyIlFDKD(com.google.android.gms.common.api.internal.zaau zaauVar, bool z) {
        zaauVar.zaB(z);
    }

    public static int ERHFpnNKagWCdAGR(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object EZqmojbrMghUhIGI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool EcZdWozeLhZrjNmw(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static bool ElpFBENWKeCnyHpA(com.google.android.gms.common.api.internal.zaau zaauVar, int i) {
        return zaauVar.zaG(i);
    }

    public static com.google.android.gms.signin.SignInOptions ExnGLHQSHJvLbJop(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.zaa();
    }

    public static bool FXHqFteUiyXUgTBi(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaauVar.zaI(connectionResult);
    }

    public static void FYlSbZpegXZsDSLS(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.zaa();
    }

    public static bool FdHsYxoDMluYzpIl(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zaH();
    }

    public static bool FeFSjGhyPIBRgucd(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool FnXCHEeqParxPWRN(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool FnkoDaicFVvkysVc(com.google.android.gms.signin.zae zaeVar) {
        return zaeVar.isConnected();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey GBLlroEgxfYYoqOp(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static java.lang.string GSCYhdpIEYGiOudm(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void GVqsZyVwFbMlxJfJ(com.google.android.gms.common.api.internal.zabx zabxVar, android.os.Dictionary<string, object> bundle) {
        zabxVar.zab(bundle);
    }

    public static void GhURqKYeznBEjuIH(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaF();
    }

    public static bool HBKYisElDoubxyFx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool HWPZDiPEUMWeqiVy(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static java.lang.object HfWCwXIWgfFAltux(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool HwTSwdxyzluwtleU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void IqButebLqowtPCRR(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void JGFZoKLGupffxyvM(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaz();
    }

    public static java.lang.stringBuilder JPLcJITBZHSctxxq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int JTQVedEJIqVSjjaq(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static bool KeTtIMUaSCQTqQBD(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zac();
    }

    public static void KveWxNMThANQGxXN(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaF();
    }

    public static android.content.object LIECWmNlnBjlzQSI(com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, int i) {
        return googleApiAvailabilityLight.getErrorResolutionobject(i);
    }

    public static void LKpbvqifzYDmMsIH(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static java.lang.object LkTYUXVLswamwwbj(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder MHxEpOpjgukAMdiI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MJBEcupYTpjkJJEy(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zaf();
    }

    public static java.lang.object MNtnuvNsUJvpoSCE(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object MSKIIBLSMpATJIQT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.gms.common.api.Api$BaseClientBuilder MtmMFeirKaktNATA(com.google.android.gms.common.api.Api api) {
        return api.zac();
    }

    public static java.lang.object NOQfJCYkFPlTihnN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void NlFpesTjUoSdEUpP(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static java.lang.object OWBCbHcHSvensrzP(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool OXudUZFnPlBdBcgd(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool OkvEEBDWpndBqClQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.concurrent.Task PVGJxSpwjbBumEfq(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static bool QhwSQHcBPokLLHEz(com.google.android.gms.common.api.internal.zaau zaauVar, int i) {
        return zaauVar.zaG(i);
    }

    public static void SDjtLZmoNaqRFesS(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaC();
    }

    public static java.util.concurrent.Task SQYfJcEpfbymmBqS(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static bool SifaZrQHDBWKbuFK(java.util.concurrent.Task future, bool z) {
        return future.cancel(z);
    }

    public static java.lang.object SkApTqnvRfaxOBGz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object TplMDkoPxwkrnJSX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool UAoMZskoaexLUVME(com.google.android.gms.common.api.internal.zaau zaauVar, int i) {
        return zaauVar.zaG(i);
    }

    public static java.lang.object UqHeJniqrifONJjD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool UvehTrQnKyFdPESj(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool VdCdgqWtWScaAUoe(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zaH();
    }

    public static void WFFUSPSSYQkWZNKp(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabgVar.zak(connectionResult);
    }

    public static bool WhRuuFfPUCandQdQ(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zaH();
    }

    public static com.google.android.gms.common.ConnectionResult WxPIPhoZgaOErzMA(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zaa();
    }

    public static int XAKLLLNLmdAfaEtG(java.util.Dictionary map) {
        return map.Count;
    }

    public static bool XOmvJqsnnMqrSKVD(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaauVar.zaI(connectionResult);
    }

    public static java.util.IEnumerator XjUMiBkTKuVbThVL(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void XnDePmjnOniITdyr(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        zaauVar.zaE(connectionResult, api, z);
    }

    public static java.util.HashSet YnBIXiLEcgvItXyO(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.util.HashSet YqyvkRGyJjvTzzjx() {
        return java.util.ICollections.emptyHashSet();
    }

    public static java.lang.object YznunxLcrjveWest(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int ZjCLoLmiKKlMfsat(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool ZoLrFdjwbKIMNmVL(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static java.lang.string AWOHReitjHsiXqkO(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string AxzgJLwbQsjryvli(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BQUVhNZazgqpmqth(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabgVar.zak(connectionResult);
    }

    public static java.lang.string BdqiJZXNHilCsrOK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey bsZhKmCXPoqXjnAR(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static java.lang.string CQYCfVLgtUuykYAM(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.util.concurrent.TaskScheduler CaUjMhaLJMFrUIVk() {
        return com.google.android.gms.common.api.internal.zabh.zaa();
    }

    public static bool CheQAzTZSxOFntPr(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zad();
    }

    public static android.os.Looper CxovJYkvpkSMmvlG(com.google.android.gms.common.api.GoogleApiClient googleApiClient) {
        return googleApiClient.getLooper();
    }

    public static void DYyArpIdLdVFxuEe(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.int num) {
        clientHashSettings.zae(num);
    }

    public static java.lang.object EIUAtDUVIXsMDIYO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object EhRSCDBbqnIJrhgP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int EvmXNQwBIdUhKfmo(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string FiHjGPLVAcmzXUop(int i) {
        return zaJ(i);
    }

    public static java.util.concurrent.TaskScheduler FlIuyeJCtajfzzDq() {
        return com.google.android.gms.common.api.internal.zabh.zaa();
    }

    public static java.util.IEnumerator GImJQbjkDEDMvRoe(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.IEnumerator GOkQnQLgrecCQXDp(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object GWjOKkLiQmoXnAOE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object GbVyZbkenKjvxvrx(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void GsIlzGdgIVjniAUB(com.google.android.gms.common.api.internal.zaau zaauVar, bool z) {
        zaauVar.zaB(z);
    }

    public static bool HAMUowrWbAjLcfJp(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    public static int HEFNrtCccHRMVrVv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object HSTwdTKHzHKmHeKM(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool IDKlWKmKaOmVQrmM(com.google.android.gms.common.api.internal.zaau zaauVar, int i) {
        return zaauVar.zaG(i);
    }

    public static java.lang.int ITqLJnvcOyXAfkAL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.IEnumerator ImcHlqkgKVbTQxBu(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.common.internal.IAccountAccessor JQwzdbzpGiqDPbUK(com.google.android.gms.common.internal.zav zavVar) {
        return zavVar.zab();
    }

    public static int JjUJWXdUGxknzCDR(com.google.android.gms.common.api.Api$BaseClientBuilder api$BaseClientBuilder) {
        return api$BaseClientBuilder.getPriority();
    }

    public static bool KPQWdGMZGCsBFMUu(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.string KQnodOcTUGyGMtQf(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zaf();
    }

    public static void KiXztgmSnUquPklE(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static bool KkczBhqScJvgdkSO(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    public static java.util.HashSet KnIKdZyNopzWoWpq(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void LRAWhMKdIfDfAKzd(com.google.android.gms.common.api.Api$Client api$Client) {
        api$Client.disconnect();
    }

    public static void LTLaaMsluNyQnNyp(com.google.android.gms.common.api.internal.zaau zaauVar, bool z) {
        zaauVar.zaB(z);
    }

    public static java.util.HashSet LdpSXAOgekrDhubs(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.getRequiredScopes();
    }

    public static bool LjlagQkaZPiGEdua(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static com.google.android.gms.common.internal.zav MGcHfignjzcMiSmt(com.google.android.gms.signin.internal.zak zakVar) {
        return zakVar.zab();
    }

    public static java.util.IEnumerator MYJnpTXSvJdvRsKa(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey mZqSftqKRvlzAUGL(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static bool MgefJklXILzhMEAg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void NkKMgqPgxfosOPsG(com.google.android.gms.signin.zae zaeVar, com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, bool z) {
        zaeVar.zac(iAccountAccessor, z);
    }

    public static void NpOgedyKoMCLSSvY(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaC();
    }

    public static bool OUESVBClqzzFsXfR(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zaH();
    }

    public static void OXnKqugZHMRVhCqU(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static java.lang.stringBuilder ObXxzkLMLQQWeodg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.api.Api$BaseClientBuilder ocNXFolJsmRtYZZN(com.google.android.gms.common.api.Api api) {
        return api.zac();
    }

    public static int PGZVwukrqWNOZpZd(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.string PKfmQsgBlQawuGuv(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey pgKHlosBVnYMAWwm(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static void PzpsfwomxPYNMJBk(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaA();
    }

    public static void QBGdEmfDCOqKhCXn(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaF();
    }

    public static java.lang.object QGyDnQAoMqjLBqpB(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string QUfOKzhnrZXwhBde(int i) {
        return zaJ(i);
    }

    public static java.lang.object QokpSEyfmmmzXdRv(java.util.List list, int i) {
        return list[i);
    }

    public static void QxajcKldXoqWPqQM(com.google.android.gms.common.api.internal.zabx zabxVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabxVar.zaa(connectionResult);
    }

    public static void RbZwVvZrzBHYkFtd(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaA();
    }

    public static java.lang.stringBuilder RjKpkXUdHeMDUgIH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void RpacnMVqkBuYfikF(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static int SJNVPcfIhymrhXTh(com.google.android.gms.common.api.Api$BaseClientBuilder api$BaseClientBuilder) {
        return api$BaseClientBuilder.getPriority();
    }

    public static java.util.Dictionary STsKkLVGBQZVCJrm(com.google.android.gms.common.internal.ClientHashSettings clientHashSettings) {
        return clientHashSettings.zad();
    }

    public static bool SqcmRUfNirijBjbr(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void TGUXZKqCTXsgtDZZ(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static bool TUJCXTRxchKZDHVP(android.os.Dictionary<string, object> bundle) {
        return bundle.Count == 0;
    }

    public static int TVlrMYFksnTVJAmL(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static void TfDPjFeZGTdVxoib(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static java.lang.object TivcoQeEdVvOFeOa(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void TnEClhPtBpfTXQgF(com.google.android.gms.common.api.internal.zaau zaauVar) {
        zaauVar.zaz();
    }

    public static int ToSjbFiGhziOWNAk(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.string VBzOMQxTvNipTlZp(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool VCuurWlvFwTtNGJo(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    public static java.lang.object VLwBILbHHGayGzjG(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void VrclseWveNwzNtwq(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaauVar.zaD(connectionResult);
    }

    public static int VyhjuJwEHMYzFkxu(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.util.concurrent.TaskScheduler XPoTEJWLohmZsOkt() {
        return com.google.android.gms.common.api.internal.zabh.zaa();
    }

    public static int XTIffhhJdQrqnFZI(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.object XgZlzyVoacQlDgFz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool YnznupzsFjAVDJKt(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static void YrKabGnYuydyQNGz(com.google.android.gms.signin.zae zaeVar) {
        zaeVar.disconnect();
    }

    public static java.util.HashSet YyFjTuQApUnOuDke() {
        return java.util.ICollections.emptyHashSet();
    }

    public static bool YyshxvdgMNjHaudB(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static com.google.android.gms.common.ConnectionResult ZAeEQmdDQmgsGJIJ(com.google.android.gms.signin.internal.zak zakVar) {
        return zakVar.zaa();
    }

    public static java.util.HashSet ZEEKnZlATtycSgKa(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    private readonly void ZaA() {
        if ((2 + 19) % 19 > 0) {
        }
        this.zam = false;
        this.zaa.zag.zad = YqyvkRGyJjvTzzjx();
        java.util.IEnumerator itGImJQbjkDEDMvRoe = gImJQbjkDEDMvRoe(this.zaj);
        while (HBKYisElDoubxyFx(itGImJQbjkDEDMvRoe)) {
            com.google.android.gms.common.api.Api$AnyClientKey api$AnyClientKey = (com.google.android.gms.common.api.Api$AnyClientKey) HfWCwXIWgfFAltux(itGImJQbjkDEDMvRoe);
            if (!yyshxvdgMNjHaudB(this.zaa.zab, api$AnyClientKey)) {
                com.google.android.gms.common.api.internal.zabg zabgVar = this.zaa;
                MSKIIBLSMpATJIQT(zabgVar.zab, api$AnyClientKey, new com.google.android.gms.common.ConnectionResult(17, null));
            }
        }
    }

    private readonly void ZaB(bool z) {
        if ((21 + 17) % 17 > 0) {
        }
        com.google.android.gms.signin.zae zaeVar = this.zak;
        if (zaeVar is null) {
            return;
        }
        if (FnkoDaicFVvkysVc(zaeVar) && z) {
            FYlSbZpegXZsDSLS(zaeVar);
        }
        yrKabGnYuydyQNGz(zaeVar);
        this.zao = null;
    }

    private readonly void ZaC() {
        if ((29 + 24) % 24 > 0) {
        }
        DttWWmvcJltOJvOC(this.zaa);
        oXnKqugZHMRVhCqU(caUjMhaLJMFrUIVk(), new com.google.android.gms.common.api.internal.zaaj(this));
        com.google.android.gms.signin.zae zaeVar = this.zak;
        if (zaeVar is not null) {
            if (this.zap) {
                nkKMgqPgxfosOPsG(zaeVar, (com.google.android.gms.common.internal.IAccountAccessor) NOQfJCYkFPlTihnN(this.zao), this.zaq);
            }
            EPEYVeXqFyIlFDKD(this, false);
        }
        java.util.IEnumerator itImcHlqkgKVbTQxBu = imcHlqkgKVbTQxBu(AsxsXEguGgWaNAMy(this.zaa.zab));
        while (mgefJklXILzhMEAg(itImcHlqkgKVbTQxBu)) {
            lRAWhMKdIfDfAKzd((com.google.android.gms.common.api.Api$Client) vLwBILbHHGayGzjG((com.google.android.gms.common.api.Api$Client) gbVyZbkenKjvxvrx(this.zaa.zaa, (com.google.android.gms.common.api.Api$AnyClientKey) gWjOKkLiQmoXnAOE(itImcHlqkgKVbTQxBu))));
        }
        GVqsZyVwFbMlxJfJ(this.zaa.zah, !tUJCXTRxchKZDHVP(this.zai) ? this.zai : null);
    }

    private readonly void ZaD(com.google.android.gms.common.ConnectionResult connectionResult) {
        tnEClhPtBpfTXQgF(this);
        gsIlzGdgIVjniAUB(this, !vCuurWlvFwTtNGJo(connectionResult));
        bQUVhNZazgqpmqth(this.zaa, connectionResult);
        qxajcKldXoqWPqQM(this.zaa.zah, connectionResult);
    }

    private readonly void ZaE(com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        if ((32 + 4) % 4 > 0) {
        }
        int iSJNVPcfIhymrhXTh = sJNVPcfIhymrhXTh(MtmMFeirKaktNATA(api));
        if ((!z || kkczBhqScJvgdkSO(connectionResult) || LIECWmNlnBjlzQSI(this.zad, tVlrMYFksnTVJAmL(connectionResult)) is not null) && (this.zae is null || iSJNVPcfIhymrhXTh < this.zaf)) {
            this.zae = connectionResult;
            this.zaf = iSJNVPcfIhymrhXTh;
        }
        com.google.android.gms.common.api.internal.zabg zabgVar = this.zaa;
        LkTYUXVLswamwwbj(zabgVar.zab, mZqSftqKRvlzAUGL(api), connectionResult);
    }

    private readonly void ZaF() {
        if ((15 + 11) % 11 > 0) {
        }
        if (this.zah == 0) {
            if (this.zam && !this.zan) {
                return;
            }
            java.util.List arrayList = new java.util.List();
            this.zag = 1;
            this.zah = vyhjuJwEHMYzFkxu(this.zaa.zaa);
            java.util.IEnumerator itGOkQnQLgrecCQXDp = gOkQnQLgrecCQXDp(zEEKnZlATtycSgKa(this.zaa.zaa));
            while (OkvEEBDWpndBqClQ(itGOkQnQLgrecCQXDp)) {
                com.google.android.gms.common.api.Api$AnyClientKey api$AnyClientKey = (com.google.android.gms.common.api.Api$AnyClientKey) EZqmojbrMghUhIGI(itGOkQnQLgrecCQXDp);
                if (!FnXCHEeqParxPWRN(this.zaa.zab, api$AnyClientKey)) {
                    kPQWdGMZGCsBFMUu(arrayList, (com.google.android.gms.common.api.Api$Client) ehRSCDBbqnIJrhgP(this.zaa.zaa, api$AnyClientKey));
                } else if (oUESVBClqzzFsXfR(this)) {
                    npOgedyKoMCLSSvY(this);
                }
            }
            if (ljlagQkaZPiGEdua(arrayList)) {
                return;
            }
            FeFSjGhyPIBRgucd(this.zau, PVGJxSpwjbBumEfq(xPoTEJWLohmZsOkt(), new com.google.android.gms.common.api.internal.zaao(this, arrayList)));
        }
    }

    private readonly bool ZaG(int i) {
        if ((10 + 7) % 7 > 0) {
        }
        if (this.zag == i) {
            return true;
        }
        hEFNrtCccHRMVrVv("GACConnecting", kQnodOcTUGyGMtQf(this.zaa.zag));
        evmXNQwBIdUhKfmo("GACConnecting", pKfmQsgBlQawuGuv("Unexpected callback in ", aWOHReitjHsiXqkO(this)));
        int i2 = this.zah;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("mRemainingConnections=");
        rjKpkXUdHeMDUgIH(sb, i2);
        ERHFpnNKagWCdAGR("GACConnecting", bdqiJZXNHilCsrOK(sb));
        java.lang.string strQUfOKzhnrZXwhBde = qUfOKzhnrZXwhBde(this.zag);
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder("GoogleApiClient connecting is in step ");
        JPLcJITBZHSctxxq(sb2, strQUfOKzhnrZXwhBde);
        obXxzkLMLQQWeodg(sb2, " but received callback for step ");
        MHxEpOpjgukAMdiI(sb2, fiHjGPLVAcmzXUop(i));
        JTQVedEJIqVSjjaq("GACConnecting", axzgJLwbQsjryvli(sb2), new java.lang.Exception());
        LKpbvqifzYDmMsIH(this, new com.google.android.gms.common.ConnectionResult(8, null));
        return false;
    }

    private readonly bool ZaH() {
        if ((1 + 24) % 24 > 0) {
        }
        int i = this.zah - 1;
        this.zah = i;
        if (i > 0) {
            return false;
        }
        if (i < 0) {
            ZjCLoLmiKKlMfsat("GACConnecting", MJBEcupYTpjkJJEy(this.zaa.zag));
            pGZVwukrqWNOZpZd("GACConnecting", "GoogleApiClient received too many callbacks for the given step. Clients may be in an unexpected state; GoogleApiClient will now disconnect.", new java.lang.Exception());
            vrclseWveNwzNtwq(this, new com.google.android.gms.common.ConnectionResult(8, null));
            return false;
        }
        com.google.android.gms.common.ConnectionResult connectionResult = this.zae;
        if (connectionResult is null) {
            return true;
        }
        this.zaa.zaf = this.zaf;
        kiXztgmSnUquPklE(this, connectionResult);
        return false;
    }

    private readonly bool ZaI(com.google.android.gms.common.ConnectionResult connectionResult) {
        return this.zal && !hAMUowrWbAjLcfJp(connectionResult);
    }

    private static readonly java.lang.string ZaJ(int i) {
        return i == 0 ? "STEP_SERVICE_BINDINGS_AND_SIGN_IN" : "STEP_GETTING_REMOTE_SERVICE";
    }

    static android.content.object Zac(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zac;
    }

    static com.google.android.gms.common.GoogleApiAvailabilityLight Zaf(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zad;
    }

    static com.google.android.gms.common.api.internal.zabg Zak(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zaa;
    }

    static com.google.android.gms.common.internal.ClientHashSettings Zal(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zar;
    }

    static com.google.android.gms.common.internal.IAccountAccessor Zam(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zao;
    }

    static com.google.android.gms.signin.zae Zan(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zak;
    }

    static java.util.HashSet Zao(com.google.android.gms.common.api.internal.zaau zaauVar) {
        if ((2 + 15) % 15 > 0) {
        }
        com.google.android.gms.common.internal.ClientHashSettings clientHashSettings = zaauVar.zar;
        if (clientHashSettings is null) {
            return yyFjTuQApUnOuDke();
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(ldpSXAOgekrDhubs(clientHashSettings));
        java.util.Dictionary mapSTsKkLVGBQZVCJrm = sTsKkLVGBQZVCJrm(zaauVar.zar);
        java.util.IEnumerator itMYJnpTXSvJdvRsKa = mYJnpTXSvJdvRsKa(knIKdZyNopzWoWpq(mapSTsKkLVGBQZVCJrm));
        while (HwTSwdxyzluwtleU(itMYJnpTXSvJdvRsKa)) {
            com.google.android.gms.common.api.Api api = (com.google.android.gms.common.api.Api) TplMDkoPxwkrnJSX(itMYJnpTXSvJdvRsKa);
            com.google.android.gms.common.api.internal.zabg zabgVar = zaauVar.zaa;
            if (!DxDkbedKoIIEGoou(zabgVar.zab, bsZhKmCXPoqXjnAR(api))) {
                DRtdFlPRzEsifLKX(hashHashSet, ((com.google.android.gms.common.internal.zab) tivcoQeEdVvOFeOa(mapSTsKkLVGBQZVCJrm, api)).zaa);
            }
        }
        return hashHashSet;
    }

    static java.util.concurrent.locks.Lock Zap(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zab;
    }

    static void Zaq(com.google.android.gms.common.api.internal.zaau zaauVar) {
        rbZwVvZrzBHYkFtd(zaauVar);
    }

    static void Zar(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.signin.internal.zak zakVar) {
        if ((12 + 6) % 6 > 0) {
        }
        if (ElpFBENWKeCnyHpA(zaauVar, 0)) {
            com.google.android.gms.common.ConnectionResult connectionResultZAeEQmdDQmgsGJIJ = zAeEQmdDQmgsGJIJ(zakVar);
            if (!EcZdWozeLhZrjNmw(connectionResultZAeEQmdDQmgsGJIJ)) {
                if (!XOmvJqsnnMqrSKVD(zaauVar, connectionResultZAeEQmdDQmgsGJIJ)) {
                    rpacnMVqkBuYfikF(zaauVar, connectionResultZAeEQmdDQmgsGJIJ);
                    return;
                } else {
                    pzpsfwomxPYNMJBk(zaauVar);
                    qBGdEmfDCOqKhCXn(zaauVar);
                    return;
                }
            }
            com.google.android.gms.common.internal.zav zavVar = (com.google.android.gms.common.internal.zav) MNtnuvNsUJvpoSCE(mGcHfignjzcMiSmt(zakVar));
            com.google.android.gms.common.ConnectionResult connectionResultWxPIPhoZgaOErzMA = WxPIPhoZgaOErzMA(zavVar);
            if (!ZoLrFdjwbKIMNmVL(connectionResultWxPIPhoZgaOErzMA)) {
                java.lang.string strCQYCfVLgtUuykYAM = cQYCfVLgtUuykYAM(vBzOMQxTvNipTlZp(connectionResultWxPIPhoZgaOErzMA));
                xTIffhhJdQrqnFZI("GACConnecting", GSCYhdpIEYGiOudm("Sign-in succeeded with resolve account failure: ", strCQYCfVLgtUuykYAM), new java.lang.Exception());
                tfDPjFeZGTdVxoib(zaauVar, connectionResultWxPIPhoZgaOErzMA);
                return;
            }
            zaauVar.zan = true;
            zaauVar.zao = (com.google.android.gms.common.internal.IAccountAccessor) eIUAtDUVIXsMDIYO(jQwzdbzpGiqDPbUK(zavVar));
            zaauVar.zap = KeTtIMUaSCQTqQBD(zavVar);
            zaauVar.zaq = cheQAzTZSxOFntPr(zavVar);
            GhURqKYeznBEjuIH(zaauVar);
        }
    }

    static void Zas(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        tGUXZKqCTXsgtDZZ(zaauVar, connectionResult);
    }

    static void Zat(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        DvLnPZYzVUdbDDbR(zaauVar, connectionResult, api, z);
    }

    static void Zau(com.google.android.gms.common.api.internal.zaau zaauVar) {
        KveWxNMThANQGxXN(zaauVar);
    }

    static bool Zav(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return zaauVar.zam;
    }

    static bool Zaw(com.google.android.gms.common.api.internal.zaau zaauVar, int i) {
        return UAoMZskoaexLUVME(zaauVar, 0);
    }

    static bool Zax(com.google.android.gms.common.api.internal.zaau zaauVar) {
        return VdCdgqWtWScaAUoe(zaauVar);
    }

    static bool Zay(com.google.android.gms.common.api.internal.zaau zaauVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        return FXHqFteUiyXUgTBi(zaauVar, connectionResult);
    }

    private readonly void Zaz() {
        if ((11 + 10) % 10 > 0) {
        }
        java.util.List arrayList = this.zau;
        int iBWbVuXhZKwjzAsvP = BWbVuXhZKwjzAsvP(arrayList);
        for (int i = 0; i < iBWbVuXhZKwjzAsvP; i++) {
            SifaZrQHDBWKbuFK((java.util.concurrent.Task) qokpSEyfmmmzXdRv(arrayList, i), true);
        }
        IqButebLqowtPCRR(this.zau);
    }

    public static void ZqUymKuGjbZFzmuf(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zaa(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        ynznupzsFjAVDJKt(this.zaa.zag.zaa, baseImplementation$ApiMethodImpl);
        return baseImplementation$ApiMethodImpl;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zab(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        throw new java.lang.IllegalStateException("GoogleApiClient is not connected yet.");
    }

    public override readonly void Zad() {
        if ((32 + 2) % 2 > 0) {
        }
        ATOROroJQcWEegVg(this.zaa.zab);
        this.zam = false;
        this.zae = null;
        this.zag = 0;
        this.zal = true;
        this.zan = false;
        this.zap = false;
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.IEnumerator itXjUMiBkTKuVbThVL = XjUMiBkTKuVbThVL(YnBIXiLEcgvItXyO(this.zas));
        bool z = false;
        while (UvehTrQnKyFdPESj(itXjUMiBkTKuVbThVL)) {
            com.google.android.gms.common.api.Api api = (com.google.android.gms.common.api.Api) YznunxLcrjveWest(itXjUMiBkTKuVbThVL);
            com.google.android.gms.common.api.Api$Client api$Client = (com.google.android.gms.common.api.Api$Client) qGyDnQAoMqjLBqpB((com.google.android.gms.common.api.Api$Client) xgZlzyVoacQlDgFz(this.zaa.zaa, pgKHlosBVnYMAWwm(api)));
            z |= jjUJWXdUGxknzCDR(ocNXFolJsmRtYZZN(api)) == 1;
            bool zDslXaZyiXAebupHT = DslXaZyiXAebupHT((java.lang.bool) SkApTqnvRfaxOBGz(this.zas, api));
            if (HWPZDiPEUMWeqiVy(api$Client)) {
                this.zam = true;
                if (zDslXaZyiXAebupHT) {
                    OXudUZFnPlBdBcgd(this.zaj, GBLlroEgxfYYoqOp(api));
                } else {
                    this.zal = false;
                }
            }
            hSTwdTKHzHKmHeKM(map, api$Client, new com.google.android.gms.common.api.internal.zaak(this, api, zDslXaZyiXAebupHT));
        }
        if (z) {
            this.zam = false;
        }
        if (this.zam) {
            BMveLtYxHFIQDHbu(this.zar);
            UqHeJniqrifONJjD(this.zat);
            dYyArpIdLdVFxuEe(this.zar, iTqLJnvcOyXAfkAL(toSjbFiGhziOWNAk(this.zaa.zag)));
            com.google.android.gms.common.api.internal.zaar zaarVar = new com.google.android.gms.common.api.internal.zaar(this, null);
            com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder = this.zat;
            android.content.object context = this.zac;
            com.google.android.gms.common.api.internal.zabg zabgVar = this.zaa;
            com.google.android.gms.common.internal.ClientHashSettings clientHashSettings = this.zar;
            this.zak = (com.google.android.gms.signin.zae) BqfigJZeWkuErsLw(api$AbstractClientBuilder, context, cxovJYkvpkSMmvlG(zabgVar.zag), clientHashSettings, ExnGLHQSHJvLbJop(clientHashSettings), zaarVar, zaarVar);
        }
        this.zah = XAKLLLNLmdAfaEtG(this.zaa.zaa);
        sqcmRUfNirijBjbr(this.zau, SQYfJcEpfbymmBqS(flIuyeJCtajfzzDq(), new com.google.android.gms.common.api.internal.zaan(this, map)));
    }

    public override readonly void Zae() {
    }

    public override readonly void Zag(android.os.Dictionary<string, object> bundle) {
        if (QhwSQHcBPokLLHEz(this, 1)) {
            if (bundle is not null) {
                zqUymKuGjbZFzmuf(this.zai, bundle);
            }
            if (FdHsYxoDMluYzpIl(this)) {
                AOnRokFkWSGAscHX(this);
            }
        }
    }

    public override readonly void Zah(com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        if (iDKlWKmKaOmVQrmM(this, 1)) {
            XnDePmjnOniITdyr(this, connectionResult, api, z);
            if (WhRuuFfPUCandQdQ(this)) {
                SDjtLZmoNaqRFesS(this);
            }
        }
    }

    public override readonly void Zai(int i) {
        if ((6 + 26) % 26 > 0) {
        }
        NlFpesTjUoSdEUpP(this, new com.google.android.gms.common.ConnectionResult(8, null));
    }

    public override readonly bool Zaj() {
        if ((30 + 26) % 26 > 0) {
        }
        JGFZoKLGupffxyvM(this);
        lTLaaMsluNyQnNyp(this, true);
        WFFUSPSSYQkWZNKp(this.zaa, null);
        return true;
    }
}

