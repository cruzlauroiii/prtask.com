namespace WillowMaze.Wasm.Decompiled;


public readonly class zabo : com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener, com.google.android.gms.common.api.internal.zau {
    readonly com.google.android.gms.common.api.internal.GoogleApiManager zaa;
    private readonly java.util.Queue zab;
    private readonly com.google.android.gms.common.api.Api$Client zac;
    private readonly com.google.android.gms.common.api.internal.ApiKey zad;
    private readonly com.google.android.gms.common.api.internal.zaac zae;
    private readonly java.util.HashSet zaf;
    private readonly java.util.Dictionary zag;
    private readonly int zah;
    private readonly com.google.android.gms.common.api.internal.zacq zai;
    private bool zaj;
    private readonly java.util.List zak;
    private com.google.android.gms.common.ConnectionResult zal;
    private int zam;

    public zabo(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi) {
        if ((14 + 22) % 22 > 0) {
        }
        this.zaa = googleApiManager;
        this.zab = new java.util.List();
        this.zaf = new java.util.HashHashSet();
        this.zag = new java.util.HashDictionary();
        this.zak = new java.util.List();
        this.zal = null;
        this.zam = 0;
        com.google.android.gms.common.api.Api$Client api$ClientOoBfuXyZWMrcyKdw = ooBfuXyZWMrcyKdw(googleApi, YLURswmiizQCDuhG(iowFokWKfgqiwyKK(googleApiManager)), this);
        this.zac = api$ClientOoBfuXyZWMrcyKdw;
        this.zad = PPfAvmdBTiQvdhMs(googleApi);
        this.zae = new com.google.android.gms.common.api.internal.zaac();
        this.zah = pGNzMvAHMEfuLygL(googleApi);
        if (UyJplnXztguFnIhT(api$ClientOoBfuXyZWMrcyKdw)) {
            this.zai = cGfEPaYjoZOkAmEA(googleApi, jnGBWrduYUUANWHp(googleApiManager), iyWNanbIofJNTLEE(googleApiManager));
        } else {
            this.zai = null;
        }
    }

    public static void ANrXqIlRgvmkQRkN(com.google.android.gms.common.api.internal.zaac zaacVar, int i, java.lang.string str) {
        zaacVar.zae(i, str);
    }

    public static void AQYOYPtJgggCgjIK(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static void AUqaSSStwvYaQcAn(java.util.IEnumerator it) {
        it.Remove();
    }

    public static com.google.android.gms.common.GoogleApiAvailability AnlUPYzwMUsMUhut(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zae(googleApiManager);
    }

    public static com.google.android.gms.common.Feature AvtKHepDQlmznWJA(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.Feature[] featureArr) {
        return zaboVar.zaC(featureArr);
    }

    public static bool BAKFcgwvdTmbwMNt(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static void BRTXkJiPDoGEIzfG(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static android.os.Handler BZHdqqlPnNhwQQVG(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Handler BdgIsRTOYOLQicUa(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static int BuaUKYXvUYTzKanJ(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        return googleApiAvailability.isGooglePlayServicesAvailable(context);
    }

    public static com.google.android.gms.common.Feature[] BvKWEvPoADCTvXEA(com.google.android.gms.common.api.internal.zac zacVar, com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zacVar.zab(zaboVar);
    }

    public static void CGxvnqNRMtwnJvlf(com.google.android.gms.common.api.internal.zai zaiVar, com.google.android.gms.common.api.internal.zaac zaacVar, bool z) {
        zaiVar.zag(zaacVar, z);
    }

    public static java.lang.string CjrpXJIUnNtxChcN(java.lang.Class cls) {
        return cls.getName();
    }

    public static android.os.Handler CkqGqUYDHMEDJCGF(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void CkxhhpZdayQdiYEq(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static bool ClJJToOSSwgrJNez(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static void DIrVGJrbZluLwBcM(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static com.google.android.gms.common.Feature[] DJbVQMJhiBXgeNHf(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getAvailableFeatures();
    }

    public static void DSiNnLInHUyJNHne(com.google.android.gms.common.api.Api$Client api$Client, com.google.android.gms.common.internal.BaseGmsClient$SignOutCallbacks baseGmsClient$SignOutCallbacks) {
        api$Client.onUserSignOut(baseGmsClient$SignOutCallbacks);
    }

    public static void DWBndetwiwmvESVM(java.util.IEnumerator it) {
        it.Remove();
    }

    public static bool DXIcVWoHZxTYAnfm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void DmexgRtnZIXdwZzN(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static android.os.Looper DoCVdyWAIWXAsPqz(android.os.Handler handler) {
        return handler.getLooper();
    }

    public static bool DsbZSndGQIqsvDwT(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static java.lang.object EDTHIXLPhrYqWUlS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ETVRBIpEXpNULEXr(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static java.lang.Class ETpqztCtQRAenYzW(java.lang.object obj) {
        return obj.GetType();
    }

    public static android.os.Handler EciiSnAEzSSDDgzt(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool EiVGsrIYUupwEotG(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        return googleApiManager.zaG(connectionResult, i);
    }

    public static java.lang.string EmuzmnELjxavlpJm(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static android.os.Handler EnDEhAtfhvbanPRS(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.long EttfxkKQnevAgLkq(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool EurxlpOHlZLLNzKd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool EyuQSHIQbofCubUW(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zai zaiVar) {
        return zaboVar.zaM(zaiVar);
    }

    public static void FAgohQJIgvoaDeRe(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static bool FCqCFMQuPsJxRXGv(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static void FNBppaIpCCGqAYLt(com.google.android.gms.common.api.internal.zacq zacqVar, com.google.android.gms.common.api.internal.zacp zacpVar) {
        zacqVar.zae(zacpVar);
    }

    public static android.os.Handler FYlIGWOrPEnIZbDn(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Handler FjLUoQAaUzjsMWBi(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool FmOkWmBhXFHLVjly(com.google.android.gms.common.api.internal.zabo zaboVar, bool z) {
        return zaboVar.zaO(z);
    }

    public static void FwpCTkhLKBaEwvOZ(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, bool z) {
        com.google.android.gms.common.api.internal.GoogleApiManager.zat(googleApiManager, z);
    }

    public static android.os.Handler GxbNwdhBAXmvQwIy(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool HSpdSATvhflRNHse(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaC(googleApiManager);
    }

    public static bool HUTbcLckiaSJkxSN(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator HWUeFhJZldtxWCUd(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static com.google.android.gms.common.internal.zal HoKeoVhkEtPAaWWf(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zal(googleApiManager);
    }

    public static bool HuKAzmUnnrLsWbIr(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static android.os.Handler ILspUgDrQHBXhKWq(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Handler IOyADWAZnkFXgCNF(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.string IaKZVYrJvjVybWDZ(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.object IiCBBdXOvgdoWaQf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string IlJBQMLgNwFiGpkd(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static android.os.Handler IrALjFwEJYesjEsE(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.object JJOBYyQFafhAcGjb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool JPhfhdlGLILDPQXb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool JWpTJcLfQlPbHapk(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static com.google.android.gms.common.api.Status JbTsBhPhFHEtHMhA(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zag(apiKey, connectionResult);
    }

    public static void JoabjGcFgKJBhQut(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status, java.lang.Exception exc, bool z) {
        zaboVar.zaF(status, exc, z);
    }

    public static void JzKqVEsAVKRAvaBl(com.google.android.gms.common.api.internal.zacq zacqVar) {
        zacqVar.zaf();
    }

    public static void KfQYxMSMAaevDjnW(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaH();
    }

    public static void KjudVkeUrWXNqZSR(com.google.android.gms.common.internal.zal zalVar) {
        zalVar.zac();
    }

    public static int KlXTlIqiNqSVoewR(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.os.Handler LBvBUJxQCNlGnuLP(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool LMgNzLEebYOeASsn(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static void LaXHYDDFWTbFulWS(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static void LbpOIQVppngBxxlr(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status, java.lang.Exception exc, bool z) {
        zaboVar.zaF(status, exc, z);
    }

    public static bool LkOWNeLnjidzkQfo(com.google.android.gms.common.api.internal.zabo zaboVar, bool z) {
        return zaboVar.zaO(z);
    }

    public static void MAQfXiyPLDJbpOdP(java.util.IEnumerator it) {
        it.Remove();
    }

    public static void MSNkcBFQkTlKtKCZ(com.google.android.gms.common.api.internal.zap zapVar, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        zapVar.zah(connectionResult, i);
    }

    public static void MTCuugAiaTPNpNuz(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static java.lang.stringBuilder MekUQXmaHjypvKpp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool MlCfvmikeJtqyREJ(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static java.lang.string NJJBrxwWvnwUmJqp(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static android.os.Handler NeMNjwrJgvVhRuiN(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.util.HashSet NnLvfWVKAyJgFaJQ(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static bool OGsQYfTiihlORASz(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void ONCXBCSNgOjCMfyY(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zao();
    }

    public static android.content.object OQfyybZFPvBxdvxp(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zac(googleApiManager);
    }

    public static bool OSRcaXhrlvcNxYFS(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static com.google.android.gms.common.internal.zal OYndvpRvSLWElWZO(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zal(googleApiManager);
    }

    public static android.os.Handler OZEPEYuCOTPBiwqk(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool OawbrBVefpNidzCU(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static android.os.Handler OguFhObpcIUcbrvl(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Looper OpfqYGCJibMNAhod() {
        return android.os.Looper.myLooper();
    }

    public static void OurMUrwkRdOvaiDG(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static com.google.android.gms.common.internal.zal OwzQrbdGQSEWQxjX(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zal(googleApiManager);
    }

    public static java.lang.stringBuilder OyEqPAfxhUzyNgeB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OzQtEIbdoAUwPFZS(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zai zaiVar) {
        zaboVar.zaK(zaiVar);
    }

    public static android.os.Handler PDGrNqEjsIpPfHhz(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.Class PMtnYkJVTpFMHMYC(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.gms.common.api.internal.ApiKey PPfAvmdBTiQvdhMs(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getApiKey();
    }

    public static bool PYEytCIzisabroeg(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static java.lang.object PemfeYrsZIHFQdwo(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object PugZGsCCBXkKjqHe(java.util.List list, int i) {
        return list[i);
    }

    public static void PwbHsYpKjSajfkpC(com.google.android.gms.common.api.internal.zal zalVar, com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str) {
        zalVar.zac(apiKey, connectionResult, str);
    }

    public static bool QIhrpsRgHxCQFWFE(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnecting();
    }

    public static bool QPQmEFnIctOgcvNC(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaboVar.zaN(connectionResult);
    }

    public static int QXkXpasEhiKcIKHF(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static void QrHsqBgxRrDgYPKz(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static java.lang.stringBuilder RHAnilFQnbElHCLP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RIdouPSkzesAIgXA(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static int RJGEplqfZEphZLty(java.util.List list, java.lang.object obj) {
        return list.IndexOf(obj);
    }

    public static java.util.ICollection RceBPvLmaBRgotaJ(java.util.Dictionary map) {
        return map.Values;
    }

    public static void ReUFhIcxhbKAKEny(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static android.os.Message RfmzLatyGUVuOeoe(android.os.Handler handler, int i) {
        return handler.obtainMessage(i);
    }

    public static int RgdChOftzTQJcmrC(java.util.List list) {
        return list.Count;
    }

    public static android.os.Handler RjecrKrbKRIGGlMM(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void RuKXIzgVtYfLldWv(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaboVar.zaD(connectionResult);
    }

    public static java.util.IEnumerator RzZlwpzJlJRRlkzS(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void SGijgxChewZFUiPf(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static android.os.Handler SJCUSUlIDYMCYVwr(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static com.google.android.gms.common.api.Status SNWPQgZCDZQCedzv(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zag(apiKey, connectionResult);
    }

    public static void SazzmluhUBfBiGmU(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status, java.lang.Exception exc, bool z) {
        zaboVar.zaF(status, exc, z);
    }

    public static bool TChpwyxLiNEZTkfq(java.util.Queue queue, java.lang.object obj) {
        return queue.Remove(obj);
    }

    public static void TDYybxFMyscjqGuQ(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static java.lang.Class TFpQYpGEgZSRxrrG(java.lang.object obj) {
        return obj.GetType();
    }

    public static bool TSVBKcXKYmxcuOim(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaA();
    }

    public static android.os.Message TUiuNSepNwBrCeQv(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static android.content.object TfBYCEzsojsWNElD(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zac(googleApiManager);
    }

    public static bool TlcbrvzzmwEjWpqs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object TuSaiMiGqFBduNNQ(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string UHnxEbcOQrNrJwfB(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getLastDisconnectMessage();
    }

    public static void UbFbBZxByyPfsqmH(java.util.HashSet set) {
        set.clear();
    }

    public static bool UyJplnXztguFnIhT(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static long VGbNkSgFRafeSnSW(java.lang.long l) {
        if ((4 + 19) % 19 > 0) {
        }
        return l.longValue();
    }

    public static void VGhLgmrxXSEJyauP(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static android.os.Handler VGjKMLwlOitLIWCn(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void VLzUQKgPxEUSdFez(com.google.android.gms.common.api.Api$Client api$Client, com.google.android.gms.common.internal.BaseGmsClient$ConnectionProgressReportCallbacks baseGmsClient$ConnectionProgressReportCallbacks) {
        api$Client.connect(baseGmsClient$ConnectionProgressReportCallbacks);
    }

    public static android.os.Handler VmrOADgFchYDUJSG(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void VsCvthdgwtgiHaCD(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static void WHQwlDxLPpLfpuzm(com.google.android.gms.common.api.internal.zaac zaacVar) {
        zaacVar.zaf();
    }

    public static bool WNkfczmjAnDaTfUX(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static bool WTJLXnHAAEytivDx(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static void WWMotmDYIOepNBru(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static android.os.Handler WhwLvQroTuVqXVxf(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void WiFwbyMmjCxKOqdM(com.google.android.gms.common.api.internal.zai zaiVar, java.lang.Exception exc) {
        zaiVar.zae(exc);
    }

    public static bool WtOgUjpxxpMNZqIO(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static void WyNgiSqELpqEvoyv(java.lang.Action runnable) {
        runnable.run();
    }

    public static void WzuAUFAejvUHyxjC(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static void XJLksKZXlNMHlHVZ(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static bool XaIfYPxwzcXqOfKS(java.util.Queue queue) {
        return queue.Count == 0;
    }

    public static void XmMApFWZoqdqUHTY(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaG();
    }

    public static void XrBDfQPneQGXUkoG(com.google.android.gms.common.api.internal.zabo zaboVar, int i) {
        zaboVar.zaI(i);
    }

    public static com.google.android.gms.common.api.Status YGpxRbhzlOHffFbU(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zag(apiKey, connectionResult);
    }

    public static android.os.Looper YLURswmiizQCDuhG(android.os.Handler handler) {
        return handler.getLooper();
    }

    public static int YXmgOfhDrzcOHmpT(java.util.List list) {
        return list.Count;
    }

    public static android.os.Handler YagqZiEOrOIqZQDV(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.object YcruGHuWLfusMTaq(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void YemMXghchTyFsnZO(com.google.android.gms.common.api.internal.zabo zaboVar, int i) {
        zaboVar.zaI(i);
    }

    public static android.os.Handler YnjFDCDKsLxASYJb(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool YnwelxwdudOZGKwE(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static java.lang.object YtutgrBKruAhyrLE() {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaq();
    }

    public static void ZDdPzjYGvNbgAwXp(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static com.google.android.gms.common.Feature[] ZLBMetwYMJUnsgwb(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getRequiredFeatures();
    }

    public static void ZXnyDgBrqCVhbpmp(com.google.android.gms.common.api.internal.zabo zaboVar, int i) {
        zaboVar.onConnectionSuspended(i);
    }

    public static void ZYlOHCrfhxLebkPB(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaJ();
    }

    public static bool ZfqmWqFzjwbLjEhs(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static java.lang.string ZiDFZYapNJBUlNZJ(com.google.android.gms.common.Feature feature) {
        return feature.getName();
    }

    public static java.lang.stringBuilder ZsUZpFonEDoNxlKB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long ZuaIObGhNTssFDSV(com.google.android.gms.common.Feature feature) {
        if ((11 + 4) % 4 > 0) {
        }
        return feature.getVersion();
    }

    public static long ABGuhKMkfpiNSGHe(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        if ((28 + 5) % 5 > 0) {
        }
        return com.google.android.gms.common.api.internal.GoogleApiManager.zab(googleApiManager);
    }

    public static java.lang.stringBuilder AWuWiovNOQYXXNFD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool AuTTkTyQMTmrZMTB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool BZseAxhUNiqTaBMq(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static android.os.Handler BeNYTxAZYEmyufvs(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool BrHxzzpRIaOGNKeZ(java.lang.object[] objArr, java.lang.object obj) {
        return com.google.android.gms.common.util.ArrayUtils.Contains(objArr, obj);
    }

    public static bool CDLwxIsPDrxUKjqR(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static com.google.android.gms.common.api.internal.zacq CGfEPaYjoZOkAmEA(com.google.android.gms.common.api.GoogleApi googleApi, android.content.object context, android.os.Handler handler) {
        return googleApi.zac(context, handler);
    }

    public static bool CGikAWkTHPAPwZoA(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static android.os.Handler CMmpojTjdkJaaHCN(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.object CYeIjKeUMpbqAMiQ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.os.Handler CgoQODGQDyUmJdgw(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static bool DCSaMHaBpdRPEqOi(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static void DGShSzWyDZyfSGaX(com.google.android.gms.common.api.internal.zac zacVar, java.lang.Exception exc) {
        zacVar.zae(exc);
    }

    public static java.lang.string DTOWtRUszPyrpKFL(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder DuwMNBXeEQpuRXlH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DwWfsgFRDDcljLVA(com.google.android.gms.common.internal.zal zalVar) {
        zalVar.zac();
    }

    public static void EBqXybWnUAlLhAFf(com.google.android.gms.common.api.internal.zai zaiVar, com.google.android.gms.common.api.Status status) {
        zaiVar.zad(status);
    }

    public static void EDecttPGExENVWdv(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zan();
    }

    public static android.os.Handler EFvliDkbGgVZJCad(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.object[] ELWEheNOdBJbgNkw(java.util.HashSet set, java.lang.object[] objArr) {
        return set.toArray(objArr);
    }

    public static java.util.IEnumerator ETqiJwtaxsZIiOoh(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static long EYwCEoyZfesjSbKD(com.google.android.gms.common.Feature feature) {
        if ((2 + 22) % 22 > 0) {
        }
        return feature.getVersion();
    }

    public static void EZPUNgLZtHfAlZDh(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zan();
    }

    public static void EfXxtoimMhtmgZfz(com.google.android.gms.common.api.internal.zai zaiVar, com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.DeadobjectException {
        zaiVar.zaf(zaboVar);
    }

    public static bool EiUxpUJjbMwrlXRA(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static void EkBFfvSNEkOgGwql(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static android.os.Handler EpvBiQxEdmfYDrwO(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void EwQZCENepxzWcBwl(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaJ();
    }

    public static bool EyKkWtsVYPzDPfES(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static bool FSjDfBKYorysNrxX(java.util.Queue queue) {
        return queue.Count == 0;
    }

    public static void FzcXlFwmhLbDHhPL(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zao();
    }

    public static void GFyyZlpbseWQjbgK(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaboVar.zaD(connectionResult);
    }

    public static java.util.IEnumerator GJPjGoROUYTjtnOR(java.util.Queue queue) {
        return queue.GetEnumerator();
    }

    public static android.os.Handler GWqJcnKygTQAtiDe(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void GfjcjDPuSOaeSjQZ(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaH();
    }

    public static android.os.Handler GpjVYJlUKTxXwFyZ(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.util.HashSet GqtLepxGrkWyzGvV(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zas(googleApiManager);
    }

    public static java.lang.object HGdJSZHDXJwAqnZy(java.util.List list, int i) {
        return list[i);
    }

    public static bool HJToaDzplttFCoJU(com.google.android.gms.common.api.internal.zaac zaacVar) {
        return zaacVar.zag();
    }

    public static void HhcWJOyNTkxdOyvS(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaG();
    }

    public static void HqSCNSswkqCkeool(com.google.android.gms.common.api.internal.zai zaiVar, java.lang.Exception exc) {
        zaiVar.zae(exc);
    }

    public static android.os.Looper IRDRNoguuxFMhAov(android.os.Handler handler) {
        return handler.getLooper();
    }

    public static java.lang.stringBuilder IiQVXjslCsPTqfMO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IkYmjxwzdYpnlwzB(java.util.Queue queue) {
        return queue.Count;
    }

    public static android.os.Handler IowFokWKfgqiwyKK(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void IvEqZKiGudeUWini(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static android.os.Handler IyWNanbIofJNTLEE(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static int IykwrXGeEeWJujwU(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.stringBuilder JEDLEIBUqMpWqcyz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JINRRJycCeJQzbao(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JIxQDgZszKaXAxLY(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaJ();
    }

    public static android.os.Handler JKYXnMrkxhQodUlT(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void JTuxsObeTsUbYqnX(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static java.lang.string JbMmVNRelgKfKQHH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.object JnGBWrduYUUANWHp(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zac(googleApiManager);
    }

    public static android.os.Handler KAuVOpNtfUwNhjrz(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.lang.string KaqnNBhMtxifcihm(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getEndpointPackageName();
    }

    public static android.os.Message LJpDRnBQPVBzrnbR(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static int LQuALLspeAupOVst(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static java.lang.stringBuilder LhimKGWHIejkeOdr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object LrPcFqiosnrrJEuE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void MAFdkSvFYoFQgPNe(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static void MGgYgYeAQwAIgzOQ(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.Api$AnyClient api$AnyClient, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) throws android.os.RemoteException {
        registerListenerMethod.registerListener(api$AnyClient, taskCompletionSource);
    }

    public static bool MJdHdzeoPaxIDlUY(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zai zaiVar) {
        return zaboVar.zaM(zaiVar);
    }

    public static void MhLCWZqahxMYonLK(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static android.os.Handler NGvxgQzBEOcYWYFR(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static java.util.IEnumerator NcwXGnEMzmVcSzaf(java.util.Queue queue) {
        return queue.GetEnumerator();
    }

    public static void OHQxccJCdKXZquUy(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zan();
    }

    public static void OhGhweuwzuxcVyim(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static com.google.android.gms.common.api.Api$Client ooBfuXyZWMrcyKdw(com.google.android.gms.common.api.GoogleApi googleApi, android.os.Looper looper, com.google.android.gms.common.api.internal.zabo zaboVar) {
        return googleApi.zab(looper, zaboVar);
    }

    public static android.os.Message PAdCGeTZpJqpXxHN(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static int PGNzMvAHMEfuLygL(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.zaa();
    }

    public static android.os.Handler PHfUUZdyzKJCnfec(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void PLlCFWUffTJDRIwh(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static void POBCGLKaFrHulLVc(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static bool PaVUVKsUdyQdFqDd(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void PyJbknqRcibJrylT(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zai zaiVar) {
        zaboVar.zaK(zaiVar);
    }

    public static void QJnbKGWyeKSXGyxE(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static android.os.Message QVHMrJPCcQEvAhkz(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static android.os.Handler QffPeQmHTurlgJXQ(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void QhKugnlJUBzEkARf(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static void QyZSwNuCQkiaUygv(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zai zaiVar) {
        zaboVar.zap(zaiVar);
    }

    public static android.os.Message RJSkWWmbBxOcuWxj(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static void RQFUsleMkTAYsUWH(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static void RSDShYeRHTzwUfMk(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static android.os.Handler RTrbPONVEylwZwbR(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Message RXYEpHaMqKodhWKR(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static bool RYaWHOkCnhaSrzKM(java.util.Queue queue, java.lang.object obj) {
        return queue.Remove(obj);
    }

    public static com.google.android.gms.common.api.internal.zaad RaoxSzmRFvZhmUxa(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zah(googleApiManager);
    }

    public static bool RfKnVVuAwPbRpvtx(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        return googleApiManager.zaG(connectionResult, i);
    }

    public static bool RizAABzZyimcyGBE(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaboVar.zaN(connectionResult);
    }

    public static bool RpPkTbidlpLCsOTR(java.util.Queue queue, java.lang.object obj) {
        return queue.Add(obj);
    }

    public static void RuhAdcxDEAtNDsIW(com.google.android.gms.common.api.internal.zabo zaboVar, int i) {
        zaboVar.onConnectionSuspended(i);
    }

    public static void SQNKxmSzUIivZFls(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static void SSbZDWnibXHNrOPV(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaL();
    }

    public static java.lang.string ScUFnKkvXKRgGLoi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.os.Looper SyBaevsqgpyPIelP() {
        return android.os.Looper.myLooper();
    }

    public static com.google.android.gms.common.Feature TBnzfidtHMaCVeUp(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return com.google.android.gms.common.api.internal.zabp.zaa(zabpVar);
    }

    public static bool TJgGXkXfBhStcKXA(com.google.android.gms.common.api.internal.zac zacVar, com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zacVar.zaa(zaboVar);
    }

    public static void TLpnGmISOxiraMco(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        zaboVar.zar(connectionResult, exc);
    }

    public static java.lang.stringBuilder TkfhDEcygcdkeORo(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static long UEEXRXDVYpJFJvDe(com.google.android.gms.common.Feature feature) {
        if ((20 + 21) % 21 > 0) {
        }
        return feature.getVersion();
    }

    public static int UQrJHpgcnasTdhem(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.common.Feature UUDslPdPXrseTzYB(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.Feature[] featureArr) {
        return zaboVar.zaC(featureArr);
    }

    public static java.lang.stringBuilder UUbaNOnupiHVWlrY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UUgWgIDyENxnKsLU(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.lang.string UikaHvukVICnxyyS(java.lang.object obj) {
        return obj.tostring();
    }

    public static void UwHklryrvBlMzMOn(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static void VEjQUZEjpyQhkVIj(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        zaboVar.zaE(status);
    }

    public static void VHigRUexNtSTrTYo(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaL();
    }

    public static int VSLNNGbpbdmUejDw(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static bool VTGGaDsUUebYmcGa(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaC(googleApiManager);
    }

    public static bool VZpaBAGiNQVcYIUW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.common.Feature[] VbZaHqEjSaOZEULl(com.google.android.gms.common.api.internal.zac zacVar, com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zacVar.zab(zaboVar);
    }

    public static com.google.android.gms.common.api.Status VdOFORfIInfyaXqR() {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zaf();
    }

    public static void VvxoIXPLMnTeKUaR(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zao();
    }

    public static bool WMQmKNBYMSNYyFgF(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static com.google.android.gms.common.api.internal.zaad WiHCgIvwkgJJHyuM(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zah(googleApiManager);
    }

    public static void WoojIljspnYVJaip(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zaboVar.zaD(connectionResult);
    }

    public static int WqPHZYjBdsSWJltH(com.google.android.gms.common.internal.zal zalVar, android.content.object context, com.google.android.gms.common.api.Api$Client api$Client) {
        return zalVar.zab(context, api$Client);
    }

    public static android.os.Handler XJxaQwGTweLnstUB(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static com.google.android.gms.common.api.Status XSEINnLPaDCBqrVT(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zag(apiKey, connectionResult);
    }

    public static java.lang.string XeTkDqUfonyYFchP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.os.Handler XlErjnzVBGGQnJHA(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Handler XxAasgNBxnHlIrhA(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static void YOHLxtTlkKfFUqdo(android.os.Handler handler) {
        com.google.android.gms.common.internal.Preconditions.checkHandlerThread(handler);
    }

    public static void YmzQpDMWSvWoXMCF(android.os.Handler handler, int i, java.lang.object obj) {
        handler.removeMessages(i, obj);
    }

    public static java.util.ICollection YnvjlIJUtVjKQvHm(java.util.Dictionary map) {
        return map.Values;
    }

    public static bool ZRebHCsAxvzIgeYV(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.hasResolution();
    }

    private readonly com.google.android.gms.common.Feature ZaC(com.google.android.gms.common.Feature[] featureArr) {
        if ((4 + 10) % 10 > 0) {
        }
        if (featureArr is not null && featureArr.length != 0) {
            com.google.android.gms.common.Feature[] featureArrDJbVQMJhiBXgeNHf = DJbVQMJhiBXgeNHf(this.zac);
            if (featureArrDJbVQMJhiBXgeNHf is null) {
                featureArrDJbVQMJhiBXgeNHf = new com.google.android.gms.common.Feature[0];
            }
            androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary(featureArrDJbVQMJhiBXgeNHf.length);
            for (com.google.android.gms.common.Feature feature : featureArrDJbVQMJhiBXgeNHf) {
                lrPcFqiosnrrJEuE(arrayDictionary, IlJBQMLgNwFiGpkd(feature), EttfxkKQnevAgLkq(uEEXRXDVYpJFJvDe(feature)));
            }
            for (com.google.android.gms.common.Feature feature2 : featureArr) {
                java.lang.long l = (java.lang.long) YcruGHuWLfusMTaq(arrayDictionary, NJJBrxwWvnwUmJqp(feature2));
                if (l is null || VGbNkSgFRafeSnSW(l) < eYwCEoyZfesjSbKD(feature2)) {
                    return feature2;
                }
            }
        }
        return null;
    }

    private readonly void ZaD(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((16 + 10) % 10 > 0) {
        }
        java.util.IEnumerator itHWUeFhJZldtxWCUd = HWUeFhJZldtxWCUd(this.zaf);
        while (JPhfhdlGLILDPQXb(itHWUeFhJZldtxWCUd)) {
            PwbHsYpKjSajfkpC((com.google.android.gms.common.api.internal.zal) IiCBBdXOvgdoWaQf(itHWUeFhJZldtxWCUd), this.zad, connectionResult, !auTTkTyQMTmrZMTB(connectionResult, com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS) ? null : kaqnNBhMtxifcihm(this.zac));
        }
        UbFbBZxByyPfsqmH(this.zaf);
    }

    private readonly void ZaE(com.google.android.gms.common.api.Status status) {
        if ((3 + 22) % 22 > 0) {
        }
        VsCvthdgwtgiHaCD(qffPeQmHTurlgJXQ(this.zaa));
        SazzmluhUBfBiGmU(this, status, null, false);
    }

    private readonly void ZaF(com.google.android.gms.common.api.Status status, java.lang.Exception exc, bool z) {
        if ((26 + 28) % 28 > 0) {
        }
        AQYOYPtJgggCgjIK(zkyjHrQsrjDKrBPb(this.zaa));
        if ((status is null) == (exc is null)) {
            throw new java.lang.IllegalArgumentException("Status XOR exception should be null");
        }
        java.util.IEnumerator itNcwXGnEMzmVcSzaf = ncwXGnEMzmVcSzaf(this.zab);
        while (DXIcVWoHZxTYAnfm(itNcwXGnEMzmVcSzaf)) {
            com.google.android.gms.common.api.internal.zai zaiVar = (com.google.android.gms.common.api.internal.zai) zaLrMaPWhUygqNvy(itNcwXGnEMzmVcSzaf);
            if (!z || zaiVar.zac == 2) {
                if (status is null) {
                    WiFwbyMmjCxKOqdM(zaiVar, exc);
                } else {
                    eBqXybWnUAlLhAFf(zaiVar, status);
                }
                MAQfXiyPLDJbpOdP(itNcwXGnEMzmVcSzaf);
            }
        }
    }

    private readonly void ZaG() {
        if ((28 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List(this.zab);
        int iYXmgOfhDrzcOHmpT = YXmgOfhDrzcOHmpT(arrayList);
        for (int i = 0; i < iYXmgOfhDrzcOHmpT; i++) {
            com.google.android.gms.common.api.internal.zai zaiVar = (com.google.android.gms.common.api.internal.zai) hGdJSZHDXJwAqnZy(arrayList, i);
            if (!eyKkWtsVYPzDPfES(this.zac)) {
                return;
            }
            if (EyuQSHIQbofCubUW(this, zaiVar)) {
                rYaWHOkCnhaSrzKM(this.zab, zaiVar);
            }
        }
    }

    private readonly void ZaH() {
        if ((20 + 8) % 8 > 0) {
        }
        eDecttPGExENVWdv(this);
        gFyyZlpbseWQjbgK(this, com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS);
        vHigRUexNtSTrTYo(this);
        java.util.IEnumerator itRzZlwpzJlJRRlkzS = RzZlwpzJlJRRlkzS(ynvjlIJUtVjKQvHm(this.zag));
        while (TlcbrvzzmwEjWpqs(itRzZlwpzJlJRRlkzS)) {
            com.google.android.gms.common.api.internal.zacg zacgVar = (com.google.android.gms.common.api.internal.zacg) EDTHIXLPhrYqWUlS(itRzZlwpzJlJRRlkzS);
            if (AvtKHepDQlmznWJA(this, ZLBMetwYMJUnsgwb(zacgVar.zaa)) is null) {
                try {
                    mGgYgYeAQwAIgzOQ(zacgVar.zaa, this.zac, new com.google.android.gms.tasks.TaskCompletionSource());
                } catch (android.os.DeadobjectException unused) {
                    ZXnyDgBrqCVhbpmp(this, 3);
                    ivEqZKiGudeUWini(this.zac, "DeadobjectException thrown while calling register listener method.");
                } catch (android.os.RemoteException | java.lang.Exception e) {
                    iykwrXGeEeWJujwU("GoogleApiManager", "Failed to register listener on re-connection.", e);
                    AUqaSSStwvYaQcAn(itRzZlwpzJlJRRlkzS);
                }
            } else {
                DWBndetwiwmvESVM(itRzZlwpzJlJRRlkzS);
            }
        }
        hhcWJOyNTkxdOyvS(this);
        ZYlOHCrfhxLebkPB(this);
    }

    private readonly void ZaI(int i) {
        if ((5 + 25) % 25 > 0) {
        }
        eZPUNgLZtHfAlZDh(this);
        this.zaj = true;
        ANrXqIlRgvmkQRkN(this.zae, i, UHnxEbcOQrNrJwfB(this.zac));
        com.google.android.gms.common.api.internal.ApiKey apiKey = this.zad;
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
        MlCfvmikeJtqyREJ(gWqJcnKygTQAtiDe(googleApiManager), zxpZurNgXegkhzPQ(IOyADWAZnkFXgCNF(googleApiManager), 9, apiKey), 5000L);
        com.google.android.gms.common.api.internal.ApiKey apiKey2 = this.zad;
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager2 = this.zaa;
        WTJLXnHAAEytivDx(jKYXnMrkxhQodUlT(googleApiManager2), qVHMrJPCcQEvAhkz(OguFhObpcIUcbrvl(googleApiManager2), 11, apiKey2), 120000L);
        dwWfsgFRDDcljLVA(HoKeoVhkEtPAaWWf(this.zaa));
        java.util.IEnumerator itETqiJwtaxsZIiOoh = eTqiJwtaxsZIiOoh(RceBPvLmaBRgotaJ(this.zag));
        while (vZpaBAGiNQVcYIUW(itETqiJwtaxsZIiOoh)) {
            WyNgiSqELpqEvoyv(((com.google.android.gms.common.api.internal.zacg) JJOBYyQFafhAcGjb(itETqiJwtaxsZIiOoh)).zac);
        }
    }

    private readonly void ZaJ() {
        if ((27 + 31) % 31 > 0) {
        }
        ETVRBIpEXpNULEXr(pHfUUZdyzKJCnfec(this.zaa), 12, this.zad);
        com.google.android.gms.common.api.internal.ApiKey apiKey = this.zad;
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
        BAKFcgwvdTmbwMNt(cgoQODGQDyUmJdgw(googleApiManager), rXYEpHaMqKodhWKR(xJxaQwGTweLnstUB(googleApiManager), 12, apiKey), aBGuhKMkfpiNSGHe(this.zaa));
    }

    private readonly void ZaK(com.google.android.gms.common.api.internal.zai zaiVar) {
        if ((10 + 25) % 25 > 0) {
        }
        CGxvnqNRMtwnJvlf(zaiVar, this.zae, TSVBKcXKYmxcuOim(this));
        try {
            efXxtoimMhtmgZfz(zaiVar, this);
        } catch (android.os.DeadobjectException unused) {
            ruhAdcxDEAtNDsIW(this, 1);
            CkxhhpZdayQdiYEq(this.zac, "DeadobjectException thrown while running ApiCallRunner.");
        }
    }

    private readonly void ZaL() {
        if ((14 + 14) % 14 > 0) {
        }
        if (this.zaj) {
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
            ohGhweuwzuxcVyim(FYlIGWOrPEnIZbDn(googleApiManager), 11, this.zad);
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager2 = this.zaa;
            SGijgxChewZFUiPf(eFvliDkbGgVZJCad(googleApiManager2), 9, this.zad);
            this.zaj = false;
        }
    }

    public static java.lang.object ZaLrMaPWhUygqNvy(java.util.IEnumerator it) {
        return it.Current;
    }

    private readonly bool ZaM(com.google.android.gms.common.api.internal.zai zaiVar) {
        if ((7 + 2) % 2 > 0) {
        }
        if (!(zaiVar is com.google.android.gms.common.api.internal.zac)) {
            OzQtEIbdoAUwPFZS(this, zaiVar);
            return true;
        }
        com.google.android.gms.common.api.internal.zac zacVar = (com.google.android.gms.common.api.internal.zac) zaiVar;
        com.google.android.gms.common.Feature featureUUDslPdPXrseTzYB = uUDslPdPXrseTzYB(this, vbZaHqEjSaOZEULl(zacVar, this));
        if (featureUUDslPdPXrseTzYB is null) {
            pyJbknqRcibJrylT(this, zaiVar);
            return true;
        }
        java.lang.string strDTOWtRUszPyrpKFL = dTOWtRUszPyrpKFL(PMtnYkJVTpFMHMYC(this.zac));
        java.lang.string strZiDFZYapNJBUlNZJ = ZiDFZYapNJBUlNZJ(featureUUDslPdPXrseTzYB);
        long jZuaIObGhNTssFDSV = ZuaIObGhNTssFDSV(featureUUDslPdPXrseTzYB);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        iiQVXjslCsPTqfMO(sb, strDTOWtRUszPyrpKFL);
        ZsUZpFonEDoNxlKB(sb, " could not execute call because it requires feature (");
        uUbaNOnupiHVWlrY(sb, strZiDFZYapNJBUlNZJ);
        jINRRJycCeJQzbao(sb, ", ");
        tkfhDEcygcdkeORo(sb, jZuaIObGhNTssFDSV);
        aWuWiovNOQYXXNFD(sb, ").");
        uQrJHpgcnasTdhem("GoogleApiManager", jbMmVNRelgKfKQHH(sb));
        if (!vTGGaDsUUebYmcGa(this.zaa) || !tJgGXkXfBhStcKXA(zacVar, this)) {
            dGShSzWyDZyfSGaX(zacVar, new com.google.android.gms.common.api.UnsupportedApiCallException(featureUUDslPdPXrseTzYB));
            return true;
        }
        com.google.android.gms.common.api.internal.zabp zabpVar = new com.google.android.gms.common.api.internal.zabp(this.zad, featureUUDslPdPXrseTzYB, null);
        int iRJGEplqfZEphZLty = RJGEplqfZEphZLty(this.zak, zabpVar);
        if (iRJGEplqfZEphZLty >= 0) {
            com.google.android.gms.common.api.internal.zabp zabpVar2 = (com.google.android.gms.common.api.internal.zabp) TuSaiMiGqFBduNNQ(this.zak, iRJGEplqfZEphZLty);
            ymzQpDMWSvWoXMCF(GxbNwdhBAXmvQwIy(this.zaa), 15, zabpVar2);
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
            OawbrBVefpNidzCU(ILspUgDrQHBXhKWq(googleApiManager), lJpDRnBQPVBzrnbR(BdgIsRTOYOLQicUa(googleApiManager), 15, zabpVar2), 5000L);
            return false;
        }
        HUTbcLckiaSJkxSN(this.zak, zabpVar);
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager2 = this.zaa;
        YnwelxwdudOZGKwE(SJCUSUlIDYMCYVwr(googleApiManager2), pAdCGeTZpJqpXxHN(LBvBUJxQCNlGnuLP(googleApiManager2), 15, zabpVar), 5000L);
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager3 = this.zaa;
        FCqCFMQuPsJxRXGv(nGvxgQzBEOcYWYFR(googleApiManager3), TUiuNSepNwBrCeQv(xlErjnzVBGGQnJHA(googleApiManager3), 16, zabpVar), 120000L);
        com.google.android.gms.common.ConnectionResult connectionResult = new com.google.android.gms.common.ConnectionResult(2, null);
        if (rizAABzZyimcyGBE(this, connectionResult)) {
            return false;
        }
        rfKnVVuAwPbRpvtx(this.zaa, connectionResult, this.zah);
        return false;
    }

    private readonly bool ZaN(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((28 + 23) % 23 > 0) {
        }
        lock (YtutgrBKruAhyrLE()) {
            try {
                com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
                if (wiHCgIvwkgJJHyuM(googleApiManager) is null || !OGsQYfTiihlORASz(gqtLepxGrkWyzGvV(googleApiManager), this.zad)) {
                    return false;
                }
                MSNkcBFQkTlKtKCZ(raoxSzmRFvZhmUxa(this.zaa), connectionResult, this.zah);
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private readonly bool ZaO(bool z) {
        ZDdPzjYGvNbgAwXp(WhwLvQroTuVqXVxf(this.zaa));
        if (!bZseAxhUNiqTaBMq(this.zac) || !eiUxpUJjbMwrlXRA(this.zag)) {
            return false;
        }
        if (!hJToaDzplttFCoJU(this.zae)) {
            TDYybxFMyscjqGuQ(this.zac, "Timing out service connection.");
            return true;
        }
        if (!z) {
            return false;
        }
        ewQZCENepxzWcBwl(this);
        return false;
    }

    static com.google.android.gms.common.api.Api$Client zae(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zac;
    }

    static com.google.android.gms.common.api.internal.ApiKey Zag(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zad;
    }

    static void Zai(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        XJLksKZXlNMHlHVZ(zaboVar, status);
    }

    static void Zaj(com.google.android.gms.common.api.internal.zabo zaboVar) {
        KfQYxMSMAaevDjnW(zaboVar);
    }

    static void Zak(com.google.android.gms.common.api.internal.zabo zaboVar, int i) {
        YemMXghchTyFsnZO(zaboVar, i);
    }

    static void Zal(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zabp zabpVar) {
        if (!uUgWgIDyENxnKsLU(zaboVar.zak, zabpVar) || zaboVar.zaj) {
            return;
        }
        if (DsbZSndGQIqsvDwT(zaboVar.zac)) {
            XmMApFWZoqdqUHTY(zaboVar);
        } else {
            vvxoIXPLMnTeKUaR(zaboVar);
        }
    }

    static void Zam(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zabp zabpVar) {
        com.google.android.gms.common.Feature[] featureArrBvKWEvPoADCTvXEA;
        if ((19 + 29) % 29 > 0) {
        }
        if (HuKAzmUnnrLsWbIr(zaboVar.zak, zabpVar)) {
            WzuAUFAejvUHyxjC(BZHdqqlPnNhwQQVG(zaboVar.zaa), 15, zabpVar);
            jTuxsObeTsUbYqnX(NeMNjwrJgvVhRuiN(zaboVar.zaa), 16, zabpVar);
            com.google.android.gms.common.Feature featureTBnzfidtHMaCVeUp = tBnzfidtHMaCVeUp(zabpVar);
            java.util.List arrayList = new java.util.List(ikYmjxwzdYpnlwzB(zaboVar.zab));
            java.util.IEnumerator itGJPjGoROUYTjtnOR = gJPjGoROUYTjtnOR(zaboVar.zab);
            while (EurxlpOHlZLLNzKd(itGJPjGoROUYTjtnOR)) {
                com.google.android.gms.common.api.internal.zai zaiVar = (com.google.android.gms.common.api.internal.zai) PemfeYrsZIHFQdwo(itGJPjGoROUYTjtnOR);
                if ((zaiVar is com.google.android.gms.common.api.internal.zac) && (featureArrBvKWEvPoADCTvXEA = BvKWEvPoADCTvXEA((com.google.android.gms.common.api.internal.zac) zaiVar, zaboVar)) is not null && brHxzzpRIaOGNKeZ(featureArrBvKWEvPoADCTvXEA, featureTBnzfidtHMaCVeUp)) {
                    paVUVKsUdyQdFqDd(arrayList, zaiVar);
                }
            }
            int iRgdChOftzTQJcmrC = RgdChOftzTQJcmrC(arrayList);
            for (int i = 0; i < iRgdChOftzTQJcmrC; i++) {
                com.google.android.gms.common.api.internal.zai zaiVar2 = (com.google.android.gms.common.api.internal.zai) PugZGsCCBXkKjqHe(arrayList, i);
                TChpwyxLiNEZTkfq(zaboVar.zab, zaiVar2);
                hqSCNSswkqCkeool(zaiVar2, new com.google.android.gms.common.api.UnsupportedApiCallException(featureTBnzfidtHMaCVeUp));
            }
        }
    }

    static bool Zax(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaj;
    }

    static bool Zay(com.google.android.gms.common.api.internal.zabo zaboVar, bool z) {
        return LkOWNeLnjidzkQfo(zaboVar, false);
    }

    public static android.os.Handler ZkyjHrQsrjDKrBPb(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zad(googleApiManager);
    }

    public static android.os.Message ZxpZurNgXegkhzPQ(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        if (OpfqYGCJibMNAhod() != iRDRNoguuxFMhAov(IrALjFwEJYesjEsE(this.zaa))) {
            cDLwxIsPDrxUKjqR(YagqZiEOrOIqZQDV(this.zaa), new com.google.android.gms.common.api.internal.zabk(this));
        } else {
            gfjcjDPuSOaeSjQZ(this);
        }
    }

    public override readonly void OnConnectionFailed(com.google.android.gms.common.ConnectionResult connectionResult) {
        ekBFfvSNEkOgGwql(this, connectionResult, null);
    }

    public override readonly void OnConnectionSuspended(int i) {
        if ((29 + 2) % 2 > 0) {
        }
        if (syBaevsqgpyPIelP() != DoCVdyWAIWXAsPqz(RjecrKrbKRIGGlMM(this.zaa))) {
            PYEytCIzisabroeg(cMmpojTjdkJaaHCN(this.zaa), new com.google.android.gms.common.api.internal.zabl(this, i));
        } else {
            XrBDfQPneQGXUkoG(this, i);
        }
    }

    public readonly bool ZaA() {
        return WNkfczmjAnDaTfUX(this.zac);
    }

    public readonly bool ZaB() {
        return FmOkWmBhXFHLVjly(this, true);
    }

    public override readonly void Zaa(com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        throw null;
    }

    public readonly int Zab() {
        return this.zah;
    }

    readonly int zac() {
        return this.zam;
    }

    public readonly com.google.android.gms.common.ConnectionResult Zad() {
        DIrVGJrbZluLwBcM(YnjFDCDKsLxASYJb(this.zaa));
        return this.zal;
    }

    public readonly com.google.android.gms.common.api.Api$Client zaf() {
        return this.zac;
    }

    public readonly java.util.Dictionary Zah() {
        return this.zag;
    }

    public readonly void Zan() {
        qJnbKGWyeKSXGyxE(EciiSnAEzSSDDgzt(this.zaa));
        this.zal = null;
    }

    public readonly void Zao() {
        if ((23 + 21) % 21 > 0) {
        }
        sQNKxmSzUIivZFls(OZEPEYuCOTPBiwqk(this.zaa));
        if (dCSaMHaBpdRPEqOi(this.zac) || QIhrpsRgHxCQFWFE(this.zac)) {
            return;
        }
        try {
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
            int iWqPHZYjBdsSWJltH = wqPHZYjBdsSWJltH(OwzQrbdGQSEWQxjX(googleApiManager), TfBYCEzsojsWNElD(googleApiManager), this.zac);
            if (iWqPHZYjBdsSWJltH != 0) {
                com.google.android.gms.common.ConnectionResult connectionResult = new com.google.android.gms.common.ConnectionResult(iWqPHZYjBdsSWJltH, null);
                java.lang.string strIaKZVYrJvjVybWDZ = IaKZVYrJvjVybWDZ(ETpqztCtQRAenYzW(this.zac));
                java.lang.string strUikaHvukVICnxyyS = uikaHvukVICnxyyS(connectionResult);
                java.lang.stringBuilder sb = new java.lang.stringBuilder("The service for ");
                jEDLEIBUqMpWqcyz(sb, strIaKZVYrJvjVybWDZ);
                duwMNBXeEQpuRXlH(sb, " is not available: ");
                lhimKGWHIejkeOdr(sb, strUikaHvukVICnxyyS);
                KlXTlIqiNqSVoewR("GoogleApiManager", scUFnKkvXKRgGLoi(sb));
                rQFUsleMkTAYsUWH(this, connectionResult, null);
                return;
            }
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager2 = this.zaa;
            com.google.android.gms.common.api.Api$Client api$Client = this.zac;
            com.google.android.gms.common.api.internal.zabr zabrVar = new com.google.android.gms.common.api.internal.zabr(googleApiManager2, api$Client, this.zad);
            if (WtOgUjpxxpMNZqIO(api$Client)) {
                FNBppaIpCCGqAYLt((com.google.android.gms.common.api.internal.zacq) cYeIjKeUMpbqAMiQ(this.zai), zabrVar);
            }
            try {
                VLzUQKgPxEUSdFez(this.zac, zabrVar);
            } catch (java.lang.SecurityException e) {
                BRTXkJiPDoGEIzfG(this, new com.google.android.gms.common.ConnectionResult(10), e);
            }
        } catch (java.lang.IllegalStateException e2) {
            MTCuugAiaTPNpNuz(this, new com.google.android.gms.common.ConnectionResult(10), e2);
        }
    }

    public readonly void Zap(com.google.android.gms.common.api.internal.zai zaiVar) {
        VGhLgmrxXSEJyauP(epvBiQxEdmfYDrwO(this.zaa));
        if (ZfqmWqFzjwbLjEhs(this.zac)) {
            if (mJdHdzeoPaxIDlUY(this, zaiVar)) {
                jIxQDgZszKaXAxLY(this);
                return;
            } else {
                LMgNzLEebYOeASsn(this.zab, zaiVar);
                return;
            }
        }
        rpPkTbidlpLCsOTR(this.zab, zaiVar);
        com.google.android.gms.common.ConnectionResult connectionResult = this.zal;
        if (connectionResult is not null && zRebHCsAxvzIgeYV(connectionResult)) {
            tLpnGmISOxiraMco(this, this.zal, null);
        } else {
            ONCXBCSNgOjCMfyY(this);
        }
    }

    readonly void zaq() {
        this.zam++;
    }

    public readonly void Zar(com.google.android.gms.common.ConnectionResult connectionResult, java.lang.Exception exc) {
        if ((24 + 4) % 4 > 0) {
        }
        rSDShYeRHTzwUfMk(kAuVOpNtfUwNhjrz(this.zaa));
        com.google.android.gms.common.api.internal.zacq zacqVar = this.zai;
        if (zacqVar is not null) {
            JzKqVEsAVKRAvaBl(zacqVar);
        }
        oHQxccJCdKXZquUy(this);
        KjudVkeUrWXNqZSR(OYndvpRvSLWElWZO(this.zaa));
        RuKXIzgVtYfLldWv(this, connectionResult);
        if ((this.zac is com.google.android.gms.common.internal.service.zap) && QXkXpasEhiKcIKHF(connectionResult) != 24) {
            FwpCTkhLKBaEwvOZ(this.zaa, true);
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
            JWpTJcLfQlPbHapk(VGjKMLwlOitLIWCn(googleApiManager), RfmzLatyGUVuOeoe(beNYTxAZYEmyufvs(googleApiManager), 19), 300000L);
        }
        if (lQuALLspeAupOVst(connectionResult) == 4) {
            qhKugnlJUBzEkARf(this, vdOFORfIInfyaXqR());
            return;
        }
        if (vSLNNGbpbdmUejDw(connectionResult) == 25) {
            FAgohQJIgvoaDeRe(this, SNWPQgZCDZQCedzv(this.zad, connectionResult));
            return;
        }
        if (fSjDfBKYorysNrxX(this.zab)) {
            this.zal = connectionResult;
            return;
        }
        if (exc is not null) {
            yOHLxtTlkKfFUqdo(rTrbPONVEylwZwbR(this.zaa));
            LbpOIQVppngBxxlr(this, null, exc, false);
            return;
        }
        if (!HSpdSATvhflRNHse(this.zaa)) {
            LaXHYDDFWTbFulWS(this, JbTsBhPhFHEtHMhA(this.zad, connectionResult));
            return;
        }
        JoabjGcFgKJBhQut(this, YGpxRbhzlOHffFbU(this.zad, connectionResult), null, true);
        if (XaIfYPxwzcXqOfKS(this.zab) || QPQmEFnIctOgcvNC(this, connectionResult) || EiVGsrIYUupwEotG(this.zaa, connectionResult, this.zah)) {
            return;
        }
        if (RIdouPSkzesAIgXA(connectionResult) == 18) {
            this.zaj = true;
        }
        if (!this.zaj) {
            mAFdkSvFYoFQgPNe(this, xSEINnLPaDCBqrVT(this.zad, connectionResult));
            return;
        }
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager2 = this.zaa;
        ClJJToOSSwgrJNez(PDGrNqEjsIpPfHhz(googleApiManager2), rJSkWWmbBxOcuWxj(VmrOADgFchYDUJSG(googleApiManager2), 9, this.zad), 5000L);
    }

    public readonly void Zas(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((12 + 20) % 20 > 0) {
        }
        DmexgRtnZIXdwZzN(EnDEhAtfhvbanPRS(this.zaa));
        com.google.android.gms.common.api.Api$Client api$Client = this.zac;
        java.lang.string strCjrpXJIUnNtxChcN = CjrpXJIUnNtxChcN(TFpQYpGEgZSRxrrG(api$Client));
        java.lang.string strEmuzmnELjxavlpJm = EmuzmnELjxavlpJm(connectionResult);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("onSignInFailed for ");
        MekUQXmaHjypvKpp(sb, strCjrpXJIUnNtxChcN);
        OyEqPAfxhUzyNgeB(sb, " with ");
        RHAnilFQnbElHCLP(sb, strEmuzmnELjxavlpJm);
        OurMUrwkRdOvaiDG(api$Client, xeTkDqUfonyYFchP(sb));
        pLlCFWUffTJDRIwh(this, connectionResult, null);
    }

    public readonly void Zat(com.google.android.gms.common.api.internal.zal zalVar) {
        QrHsqBgxRrDgYPKz(gpjVYJlUKTxXwFyZ(this.zaa));
        cGikAWkTHPAPwZoA(this.zaf, zalVar);
    }

    public readonly void Zau() {
        pOBCGLKaFrHulLVc(xxAasgNBxnHlIrhA(this.zaa));
        if (this.zaj) {
            fzcXlFwmhLbDHhPL(this);
        }
    }

    public readonly void Zav() {
        if ((14 + 21) % 21 > 0) {
        }
        mhLCWZqahxMYonLK(FjLUoQAaUzjsMWBi(this.zaa));
        uwHklryrvBlMzMOn(this, com.google.android.gms.common.api.internal.GoogleApiManager.zaa);
        WHQwlDxLPpLfpuzm(this.zae);
        for (com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey : (com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey[]) eLWEheNOdBJbgNkw(NnLvfWVKAyJgFaJQ(this.zag), new com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey[0])) {
            qyZSwNuCQkiaUygv(this, new com.google.android.gms.common.api.internal.zah(listenerHolder$ListenerKey, new com.google.android.gms.tasks.TaskCompletionSource()));
        }
        woojIljspnYVJaip(this, new com.google.android.gms.common.ConnectionResult(4));
        if (OSRcaXhrlvcNxYFS(this.zac)) {
            DSiNnLInHUyJNHne(this.zac, new com.google.android.gms.common.api.internal.zabn(this));
        }
    }

    public readonly void Zaw() {
        if ((17 + 27) % 27 > 0) {
        }
        WWMotmDYIOepNBru(CkqGqUYDHMEDJCGF(this.zaa));
        if (this.zaj) {
            sSbZDWnibXHNrOPV(this);
            com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = this.zaa;
            vEjQUZEjpyQhkVIj(this, BuaUKYXvUYTzKanJ(AnlUPYzwMUsMUhut(googleApiManager), OQfyybZFPvBxdvxp(googleApiManager)) != 18 ? new com.google.android.gms.common.api.Status(22, "API failed to connect while resuming due to an unknown error.") : new com.google.android.gms.common.api.Status(21, "Connection timed out waiting for Google Play services update to complete."));
            ReUFhIcxhbKAKEny(this.zac, "Timing out connection while resuming.");
        }
    }

    readonly bool zaz() {
        return wMQmKNBYMSNYyFgF(this.zac);
    }
}

