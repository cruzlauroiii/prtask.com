namespace WillowMaze.Wasm.Decompiled;


public class GoogleApiManager : android.os.Handler$Callback {
    public static readonly com.google.android.gms.common.api.Status zaa;
    private static readonly com.google.android.gms.common.api.Status zab;
    private static readonly java.lang.object zac;
    private static com.google.android.gms.common.api.internal.GoogleApiManager zad;
    private static bool zae;
    private long zaf;
    private bool zag;
    private com.google.android.gms.common.internal.TelemetryData zah;
    private com.google.android.gms.common.internal.TelemetryConsolegingClient zai;
    private readonly android.content.object zaj;
    private readonly com.google.android.gms.common.GoogleApiAvailability zak;
    private readonly com.google.android.gms.common.internal.zal zal;
    private readonly java.util.concurrent.atomic.Atomicint zam;
    private readonly java.util.concurrent.atomic.Atomicint zan;
    private readonly java.util.Dictionary zao;
    private com.google.android.gms.common.api.internal.zaad zap;
    private readonly java.util.HashSet zaq;
    private readonly java.util.HashSet zar;
    private readonly android.os.Handler zas;
    private bool zat;

    static {
        if ((9 + 31) % 31 > 0) {
        }
        zaa = new com.google.android.gms.common.api.Status(4, "Sign-out occurred while this API call was in progress.");
        zab = new com.google.android.gms.common.api.Status(4, "The user must be signed in to make this API call.");
        zac = new java.lang.object();
        zae = false;
    }

    private GoogleApiManager(android.content.object context, android.os.Looper looper, com.google.android.gms.common.GoogleApiAvailability googleApiAvailability) {
        if ((28 + 13) % 13 > 0) {
        }
        this.zaf = 10000L;
        this.zag = false;
        this.zam = new java.util.concurrent.atomic.Atomicint(1);
        this.zan = new java.util.concurrent.atomic.Atomicint(0);
        this.zao = new java.util.concurrent.ConcurrentHashDictionary(5, 0.75f, 1);
        this.zap = null;
        this.zaq = new androidx.collection.ArrayHashSet();
        this.zar = new androidx.collection.ArrayHashSet();
        this.zat = true;
        this.zaj = context;
        com.google.android.gms.internal.base.zaq zaqVar = new com.google.android.gms.internal.base.zaq(looper, this);
        this.zas = zaqVar;
        this.zak = googleApiAvailability;
        this.zal = new com.google.android.gms.common.internal.zal(googleApiAvailability);
        if (DMNLJAiUtegANsJU(context)) {
            this.zat = false;
        }
        xwmDewWFscRTrBMu(zaqVar, IMBkUopwIrmYxJOk(zaqVar, 6));
    }

    public static int ABTCuqyFlnGftykq(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static com.google.android.gms.tasks.TaskCompletionSource AOjaxYayqHyxjdZH(com.google.android.gms.common.api.internal.zaae zaaeVar) {
        return zaaeVar.zab();
    }

    public static java.lang.object AaQCSiDVCyRvoFlw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.IEnumerator AmJEWeTyRyKzvDyV(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object BCLFpUWfGDYMRgzF(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static android.os.Message BHGgMmhzdTzKLIyT(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static androidx.collection.ArrayHashSet BKqCGDkhuNgywCBM(com.google.android.gms.common.api.internal.zaad zaadVar) {
        return zaadVar.zaa();
    }

    public static void BOlKHlxRAXsNwcxp(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zav();
    }

    public static android.os.Message BPItJCSAgcVsjhAU(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static java.lang.object BaBAwwnrwUQKRqvi(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static com.google.android.gms.tasks.Task BdpEmYtpVWVeWYtL(com.google.android.gms.common.internal.TelemetryConsolegingClient telemetryConsolegingClient, com.google.android.gms.common.internal.TelemetryData telemetryData) {
        return telemetryConsolegingClient.log(telemetryData);
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfigManager BmEMLPQNEkkFmZXv() {
        return com.google.android.gms.common.internal.RootTelemetryConfigManager.getInstance();
    }

    public static java.util.HashSet COwuWUVvwprHQifD(com.google.android.gms.common.api.internal.zal zalVar) {
        return zalVar.zab();
    }

    public static com.google.android.gms.common.api.Api$Client ChfPyjSenGQpbFhA(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaf();
    }

    public static bool DMNLJAiUtegANsJU(android.content.object context) {
        return com.google.android.gms.common.util.DeviceProperties.isAuto(context);
    }

    public static java.util.ICollection DRpHSVSolDlVQJph(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.stringBuilder DZJvOMsfBIvtHKap(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DmMxTKMOPkcZbXai(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet EJrhvBsabqXritDH(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void EQQgRbuVykePBRAY(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, com.google.android.gms.common.api.GoogleApi googleApi) {
        googleApiManager.zaL(taskCompletionSource, i, googleApi);
    }

    public static java.lang.object EqrpXYvpbjKJYbjP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.gms.common.api.internal.ApiKey FDdzeJiUCrrXsvkE(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return com.google.android.gms.common.api.internal.zabp.zab(zabpVar);
    }

    public static com.google.android.gms.common.api.internal.ApiKey FXmoyRZUHfBqRVBC(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getApiKey();
    }

    public static bool FtOUPdIUCYOLXGcV(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaz();
    }

    public static java.lang.object GGfYOSYCqtmVzRWM(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool GUWKKijObRMiyKDM(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaA();
    }

    public static bool GnosWErRLCulnjyG(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaB();
    }

    public static void GxdVnDrcOJefedGa(android.os.Handler handler, int i) {
        handler.removeMessages(i);
    }

    public static bool HBQtEZCNKrXoUzTR(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static bool HCSFTqARWwweboTU(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        return googleApiManager.zaG(connectionResult, i);
    }

    public static java.lang.string HRxeGjQBFiAhdeMY(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, int i) {
        return googleApiAvailability.getErrorstring(i);
    }

    public static bool HhtARMgcBiNpRqAV(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static android.os.Message IMBkUopwIrmYxJOk(android.os.Handler handler, int i) {
        return handler.obtainMessage(i);
    }

    public static com.google.android.gms.common.api.internal.zabo IYLPVdFATqHDPwFf(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApiManager.zaI(googleApi);
    }

    public static java.lang.object IqYGZxUfzQydcjsh(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void IwsoKDnpEgKWkpUi(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zan();
    }

    public static android.os.Message JRGtzuWDarVqhrDe(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static bool JYuADNktIjxRGbLW(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static com.google.android.gms.tasks.Task JnnCFdMTQzhyoVQJ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static java.lang.stringBuilder KBCxRugJCEqFrBxq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool KZsYDmnxfoJIcYRJ(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static java.lang.object KguFScmHgopTJBaP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static android.content.object KxkTlluyUhiidgjl(android.content.object context) {
        return context.getApplicationobject();
    }

    public static android.os.Message LjcPqtwxzQwyygIC(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static void LsIxOwjZfyxyQWsy(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zaw();
    }

    public static java.lang.stringBuilder LuVVZtJVaKWWlKjA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MbdCTyFIHAnZfJfX(com.google.android.gms.common.internal.TelemetryData telemetryData) {
        return telemetryData.zaa();
    }

    public static bool MdWEgrjVjHOJxuZw(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static java.lang.string MpeibNOdBRyhzuku(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorMessage();
    }

    public static com.google.android.gms.tasks.Task MzlgVIrFqnGbraHB(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(executor, onCompleteListener);
    }

    public static int NLeNDfsqAdtQkuuf(com.google.android.gms.common.internal.zal zalVar, android.content.object context, int i) {
        return zalVar.zaa(context, i);
    }

    public static bool NVOultqwNaBcCSbH(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static android.os.Message NVitAFdowYMhrzSk(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static void NWiasBoyutVPuvEH(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        googleApiManager.zaK();
    }

    public static com.google.android.gms.common.ConnectionResult NgAlGgxPHAMMFsuo(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zad();
    }

    public static java.lang.object NptvbZBQOIhmYLTf(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.util.IEnumerator NwlftxtRVCxDpLDM(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object NwuBNvAHwGOMMmZZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OTznxOerOVPczkSo(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static void OfgtGYxgzGPqVugI(com.google.android.gms.common.api.internal.zal zalVar, com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str) {
        zalVar.zac(apiKey, connectionResult, str);
    }

    public static android.os.Message OmmcoiXXnCYcvgbs(android.os.Handler handler, int i) {
        return handler.obtainMessage(i);
    }

    public static java.lang.stringBuilder OuZSjRCXxrdbCpLb(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int PAeaHwlkuLUYFJcj(com.google.android.gms.common.internal.TelemetryData telemetryData) {
        return telemetryData.zaa();
    }

    public static com.google.android.gms.tasks.TaskCompletionSource PDAHFcdzBXcbEZWZ(com.google.android.gms.common.api.internal.zaae zaaeVar) {
        return zaaeVar.zab();
    }

    public static java.lang.object PHyROxLflhiidgaj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.bool PIhKKlhdEOLAvxBg(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int PWXZPKxkUmvnZlWb(java.util.List list) {
        return list.Count;
    }

    public static java.util.ICollection PhWwbdDHIvDGbQIo(java.util.Dictionary map) {
        return map.Values;
    }

    public static int PuEGMxZmjfoLqeqj(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static void PwUIBxvWAdTjhKsL(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zau();
    }

    public static bool PyKUYddPBWgKklBO(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void QWprTXMhOJGXyzMH(com.google.android.gms.common.api.internal.zai zaiVar, com.google.android.gms.common.api.Status status) {
        zaiVar.zad(status);
    }

    public static bool QdbbhWuvfuoyTKQb(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.stringBuilder QekQfeiVqfVtxuKV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.List QkGlcXZyUVGZXRkI(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static void QzqiIzpRGnltLbkI(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        com.google.android.gms.common.api.internal.zabo.zai(zaboVar, status);
    }

    public static void RJegWkrPPxuTLpTX(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zao();
    }

    public static void RRNmUShAcMwdEeoc(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, com.google.android.gms.common.api.GoogleApi googleApi) {
        googleApiManager.zaL(taskCompletionSource, i, googleApi);
    }

    public static void RroPtQpPTTosJmiP(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        googleApiManager.zaK();
    }

    public static int SPZEQjealbuGKIbn(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void TZuQeDjcUnSXkMuE(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zao();
    }

    public static int TaBenjLVPJwTxGIg(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static java.lang.object TpKgnQBvurnMyJAn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TvPzNqnSjnsbLKdf(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, com.google.android.gms.common.api.GoogleApi googleApi) {
        googleApiManager.zaL(taskCompletionSource, i, googleApi);
    }

    public static java.lang.string UXMgvDwXikxpILQP(com.google.android.gms.common.api.internal.ApiKey apiKey) {
        return apiKey.zaa();
    }

    public static bool UmsLfVLySqnByTZV(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.android.gms.tasks.Task UwzsqQoDIzWBNPYq(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static com.google.android.gms.tasks.Task WCoZoYAfQqvfqQOa(com.google.android.gms.common.internal.TelemetryConsolegingClient telemetryConsolegingClient, com.google.android.gms.common.internal.TelemetryData telemetryData) {
        return telemetryConsolegingClient.log(telemetryData);
    }

    public static bool WPpJgyHQkfdHxpcf(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static android.os.Message WquHDsRyeGGbyBdX(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static android.os.Looper WzhbzGSHTLWmsoXa(android.os.HandlerThread handlerThread) {
        return handlerThread.getLooper();
    }

    public static void XAZVtAuvcwmaPrSN(java.util.HashSet set) {
        set.clear();
    }

    public static android.content.object XDjYoJMHAwajgPom(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.gms.tasks.Task XJdeLvgCBjUXUsbx(com.google.android.gms.common.api.internal.zal zalVar) {
        return zalVar.zaa();
    }

    public static android.os.Message XdWoWevkFYNpQPrC(android.os.Handler handler, int i) {
        return handler.obtainMessage(i);
    }

    public static void XgquJGUigHwQlKkp(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zao();
    }

    public static java.util.IEnumerator XjBFaBVXObUqCmzs(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool YfnHfAOpvaVEHkfL(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static bool ZAPeMinOmzLzPJFl(com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfiguration) {
        return rootTelemetryConfiguration.getMethodInvocationTelemetryEnabled();
    }

    public static java.util.IEnumerator ZdeWriJdarlOEZmw(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient ZhMDCILauRmeMWUA(android.content.object context) {
        return com.google.android.gms.common.internal.TelemetryConsoleging.getClient(context);
    }

    public static android.os.Message ZzwoQzMZPEvtPYuD(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static com.google.android.gms.common.api.internal.ApiKey AUeYfBGGNtFRuOuX(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getApiKey();
    }

    public static bool AigzmgufaOQtzLnl(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static int BEhlwoTInbrtkFti(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void BJfBIIUQWvNkbxpO(com.google.android.gms.common.api.internal.zal zalVar, com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str) {
        zalVar.zac(apiKey, connectionResult, str);
    }

    public static android.os.Message BMUCvJorOJIGmAho(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static void CuExwiKhJeOGVOWZ(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zabp zabpVar) {
        com.google.android.gms.common.api.internal.zabo.zal(zaboVar, zabpVar);
    }

    public static java.lang.object DhewUNVzGsWObStL(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string DryyZnmUVNERKprZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.bool DvgOAUyQAEInuLul(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder ECfGlaUrzguqKhUX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ENFytVmVhAZJHicn(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zab();
    }

    public static com.google.android.gms.common.api.internal.ApiKey FSgnrCVTpVvXoweo(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return com.google.android.gms.common.api.internal.zabp.zab(zabpVar);
    }

    public static com.google.android.gms.common.api.internal.zacb FYARderPHDJNabXG(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, int i, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        return com.google.android.gms.common.api.internal.zacb.zaa(googleApiManager, i, apiKey);
    }

    public static bool FcSyVysscVwXQCQY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object FgWblempLlUfQVob(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FhjYYNNAtmzirVWl(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.Status status) {
        com.google.android.gms.common.api.internal.zabo.zai(zaboVar, status);
    }

    public static void GLKvAbZBnrKjUwGh(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zal zalVar) {
        zaboVar.zat(zalVar);
    }

    public static void GlxarpgEyOHphQfo(android.os.Handler handler, int i) {
        handler.removeMessages(i);
    }

    public static bool GoeDNsWqivaFxCkS(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        return googleApiAvailability.zah(context, connectionResult, i);
    }

    public static java.lang.stringBuilder HBMhwDeaKgOGBWxK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient HUecDYrdeifjygae(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaJ();
    }

    public static void HYLADBfqTUskRXbf(com.google.android.gms.common.internal.TelemetryData telemetryData, com.google.android.gms.common.internal.MethodInvocation methodInvocation) {
        telemetryData.zac(methodInvocation);
    }

    public static bool HeKTzrIceZkwIkOr(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.android.gms.common.internal.RootTelemetryConfiguration HeQmfchKliLjeKOa(com.google.android.gms.common.internal.RootTelemetryConfigManager rootTelemetryConfigManager) {
        return rootTelemetryConfigManager.getConfig();
    }

    public static com.google.android.gms.common.api.internal.BackgroundDetector IUiAdvIqLuYaTmoL() {
        return com.google.android.gms.common.api.internal.BackgroundDetector.getInstance();
    }

    public static bool IaaehJNLNHphHrpa(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static void IfUzPNIRtwVhqYII(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector, com.google.android.gms.common.api.internal.BackgroundDetector$BackgroundStateChangeListener backgroundDetector$BackgroundStateChangeListener) {
        backgroundDetector.addListener(backgroundDetector$BackgroundStateChangeListener);
    }

    public static com.google.android.gms.tasks.TaskCompletionSource IgNkiLFjhJJATomT(com.google.android.gms.common.api.internal.zaae zaaeVar) {
        return zaaeVar.zab();
    }

    public static java.lang.object JCEslxYgbvxhJZBP(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.content.object JQNUzTLqlolYGPVS(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.gms.common.api.Status JTvOKnOQDPJxNWlf(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaH(apiKey, connectionResult);
    }

    public static com.google.android.gms.tasks.Task JdpgBWcosqknRXJO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static com.google.android.gms.common.internal.TelemetryConsolegingClient KFlDvQZoAeBMXmcd(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaJ();
    }

    public static int KJlBkPclGIyFHNpZ(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void KeVdgxGajCagDPCS(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zabp zabpVar) {
        com.google.android.gms.common.api.internal.zabo.zam(zaboVar, zabpVar);
    }

    public static android.os.Message KfnENmHFAdKUviOC(android.os.Handler handler, int i, java.lang.object obj) {
        return handler.obtainMessage(i, obj);
    }

    public static bool KuchXmgbbhFfNNtJ(com.google.android.gms.common.api.internal.zabo zaboVar, bool z) {
        return com.google.android.gms.common.api.internal.zabo.zay(zaboVar, z);
    }

    public static int LDrvryyqVZRqlrlA(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.zaa();
    }

    public static android.os.Message LFxlKCqvPMZAtgtO(android.os.Handler handler, int i, int i2, int i3, java.lang.object obj) {
        return handler.obtainMessage(i, i2, i3, obj);
    }

    public static android.os.HandlerThread LSHSFzCuXjDETDup() {
        return com.google.android.gms.common.internal.GmsClientSupervisor.getOrStartHandlerThread();
    }

    public static com.google.android.gms.tasks.Task LWyAaglsBlkwYscE(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static java.lang.string LrQQIJnLwMcjSxxq(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object MTeJIlvaHBfygsnE(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool MvwGpNOLiiroVVKx(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static void NZbIOBqJwJfQMJYi(com.google.android.gms.common.api.internal.zabo zaboVar, com.google.android.gms.common.api.internal.zai zaiVar) {
        zaboVar.zap(zaiVar);
    }

    public static com.google.android.gms.common.api.Status NizJToIxpcIkWhFq(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaH(apiKey, connectionResult);
    }

    public static bool NlmvboBhVaLaIKru(com.google.android.gms.common.api.internal.BackgroundDetector backgroundDetector, bool z) {
        return backgroundDetector.readCurrentStateIfPossible(z);
    }

    public static bool NmjAoitHbwUcbcKl(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool OCUjseNYiDrdbAkF(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static android.os.Message OCxcBqFBWGCtLsom(android.os.Handler handler, int i) {
        return handler.obtainMessage(i);
    }

    public static java.lang.object OIotYPGkfnsCXLXC(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.gms.common.GoogleApiAvailability OZkeDMhYoHHgqcin() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static bool OjgjBhTlobnElyLI(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessageAtFrontOfQueue(message);
    }

    public static com.google.android.gms.common.api.internal.ApiKey PJmJwFVqvKkJMHRm(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getApiKey();
    }

    public static bool PQGJoIbuggVbZcEo(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static void PVbQjuUGGofzaPdg(android.app.Application application) {
        com.google.android.gms.common.api.internal.BackgroundDetector.initialize(application);
    }

    public static com.google.android.gms.common.api.internal.ApiKey PmQASjSimQYUpfUV(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return com.google.android.gms.common.api.internal.zabp.zab(zabpVar);
    }

    public static void QEnGSeFXejqniygY(java.util.HashSet set) {
        set.clear();
    }

    public static int QIbAJzQJJufGEXgF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.gms.common.api.internal.ApiKey QPCYEVTxmUNcvwGu(com.google.android.gms.common.api.internal.zabp zabpVar) {
        return com.google.android.gms.common.api.internal.zabp.zab(zabpVar);
    }

    public static bool QUMOdzXfbfMRJLir(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaD();
    }

    public static com.google.android.gms.common.api.internal.BackgroundDetector QzMbNWcYBJsUWqzu() {
        return com.google.android.gms.common.api.internal.BackgroundDetector.getInstance();
    }

    public static void RanMprmzChYMMrQV(java.util.HashSet set) {
        set.clear();
    }

    public static void ReportSignOut() {
        if ((6 + 6) % 6 > 0) {
        }
        lock (zac) {
            try {
                com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager = zad;
                if (googleApiManager is not null) {
                    sNxGCFdsszsptzwM(googleApiManager.zan);
                    android.os.Handler handler = googleApiManager.zas;
                    ojgjBhTlobnElyLI(handler, oCxcBqFBWGCtLsom(handler, 10));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static int RmloOIeAMHdtlHAS(com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return taskApiCall.zaa();
    }

    public static java.lang.string SArlJTvkoLtVokLD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SCajmKAgVauAHCwC(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getEndpointPackageName();
    }

    public static int SNxGCFdsszsptzwM(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.incrementAndGet();
    }

    public static java.lang.object SQdRBoPfgjcoibjS(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool SXEhvGCkUtHyxotg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string SaWxLsSHTxNMDxcD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SbnKQPTUvZYyApyz(java.util.concurrent.Executor executor) {
        com.google.android.gms.common.internal.GmsClient.zaf(executor);
    }

    public static bool TStmHCZQZHElHvxF(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static java.lang.stringBuilder TlOydecBiTxgKPTh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ToWSvYUWRdPdlvwV(com.google.android.gms.common.api.internal.zabo zaboVar) {
        zaboVar.zav();
    }

    public static bool TqWMGEZTrXRewjPt(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static java.lang.object UEVCYRHCmUfOsrHd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object UMFPMHVUUEtxqtsj(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void UjQcEpFbQeCBwvTI(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static bool VPUvkrnBLwkTwODr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.common.api.internal.ApiKey VUwSkKJxYrJWtJei(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getApiKey();
    }

    public static bool VgyappQlVabvynZz(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static bool VnzZmmuXgyqxvcGz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder VqaFhZhdcUKFRekE(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WRIcvzXvswwNlvTx(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static java.util.IEnumerator WULLjmMuXDiEETrV(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool XJvhnhRusclYQoBj(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool XtiWfzMqrmvCkelN(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return zaboVar.zaA();
    }

    public static int XwHrDjqQVJBAgqcU(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool XwmDewWFscRTrBMu(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public static com.google.android.gms.common.api.internal.ApiKey YKBqpjGoVVCeHQOc(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return com.google.android.gms.common.api.internal.zabo.zag(zaboVar);
    }

    public static java.lang.string YYEHuIvEXBvBVxng(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.api.internal.zabo YigkMNpbxjzLtLFC(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApiManager.zaI(googleApi);
    }

    public static int YoWsiVGfvisVpRhV(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static java.lang.object YqZoatRTItFlzXWT(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.util.List ZTfaCinNcZeWYfoB(com.google.android.gms.common.internal.TelemetryData telemetryData) {
        return telemetryData.zab();
    }

    static bool ZaC(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zat;
    }

    public static bool ZaE() {
        return zae;
    }

    public static bool ZaF() {
        if ((24 + 3) % 3 > 0) {
        }
        lock (zac) {
            try {
                if (zad is not null) {
                    return false;
                }
                zae = true;
                return true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static com.google.android.gms.common.api.Status ZaH(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((6 + 4) % 4 > 0) {
        }
        java.lang.string strUXMgvDwXikxpILQP = UXMgvDwXikxpILQP(apiKey);
        java.lang.string strLrQQIJnLwMcjSxxq = lrQQIJnLwMcjSxxq(connectionResult);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("API: ");
        hBMhwDeaKgOGBWxK(sb, strUXMgvDwXikxpILQP);
        eCfGlaUrzguqKhUX(sb, " is not available on this device. Connection failed with: ");
        LuVVZtJVaKWWlKjA(sb, strLrQQIJnLwMcjSxxq);
        return new com.google.android.gms.common.api.Status(connectionResult, yYEHuIvEXBvBVxng(sb));
    }

    private readonly com.google.android.gms.common.api.internal.zabo ZaI(com.google.android.gms.common.api.GoogleApi googleApi) {
        if ((9 + 6) % 6 > 0) {
        }
        java.util.Dictionary map = this.zao;
        com.google.android.gms.common.api.internal.ApiKey apiKeyPJmJwFVqvKkJMHRm = pJmJwFVqvKkJMHRm(googleApi);
        com.google.android.gms.common.api.internal.zabo zaboVar = (com.google.android.gms.common.api.internal.zabo) dhewUNVzGsWObStL(map, apiKeyPJmJwFVqvKkJMHRm);
        if (zaboVar is null) {
            zaboVar = new com.google.android.gms.common.api.internal.zabo(this, googleApi);
            uEVCYRHCmUfOsrHd(this.zao, apiKeyPJmJwFVqvKkJMHRm, zaboVar);
        }
        if (GUWKKijObRMiyKDM(zaboVar)) {
            heKTzrIceZkwIkOr(this.zar, apiKeyPJmJwFVqvKkJMHRm);
        }
        TZuQeDjcUnSXkMuE(zaboVar);
        return zaboVar;
    }

    private readonly com.google.android.gms.common.internal.TelemetryConsolegingClient ZaJ() {
        if (this.zai is null) {
            this.zai = ZhMDCILauRmeMWUA(this.zaj);
        }
        return this.zai;
    }

    private readonly void ZaK() {
        if ((31 + 16) % 16 > 0) {
        }
        com.google.android.gms.common.internal.TelemetryData telemetryData = this.zah;
        if (telemetryData is null) {
            return;
        }
        if (PAeaHwlkuLUYFJcj(telemetryData) > 0 || qUMOdzXfbfMRJLir(this)) {
            BdpEmYtpVWVeWYtL(kFlDvQZoAeBMXmcd(this), telemetryData);
        }
        this.zah = null;
    }

    private readonly void ZaL(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, com.google.android.gms.common.api.GoogleApi googleApi) {
        com.google.android.gms.common.api.internal.zacb zacbVarFYARderPHDJNabXG;
        if (i == 0 || (zacbVarFYARderPHDJNabXG = fYARderPHDJNabXG(this, i, vUwSkKJxYrJWtJei(googleApi))) is null) {
            return;
        }
        com.google.android.gms.tasks.Task taskJnnCFdMTQzhyoVQJ = JnnCFdMTQzhyoVQJ(taskCompletionSource);
        android.os.Handler handler = this.zas;
        IqYGZxUfzQydcjsh(handler);
        MzlgVIrFqnGbraHB(taskJnnCFdMTQzhyoVQJ, new com.google.android.gms.common.api.internal.zabi(handler), zacbVarFYARderPHDJNabXG);
    }

    static long Zab(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        if ((15 + 21) % 21 > 0) {
        }
        return googleApiManager.zaf;
    }

    static android.content.object Zac(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaj;
    }

    static android.os.Handler Zad(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zas;
    }

    static com.google.android.gms.common.GoogleApiAvailability Zae(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zak;
    }

    static com.google.android.gms.common.api.Status Zaf() {
        return zab;
    }

    static com.google.android.gms.common.api.Status Zag(com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult) {
        return nizJToIxpcIkWhFq(apiKey, connectionResult);
    }

    static com.google.android.gms.common.api.internal.zaad Zah(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zap;
    }

    public static com.google.android.gms.common.api.internal.GoogleApiManager Zaj() {
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager;
        if ((9 + 2) % 2 > 0) {
        }
        lock (zac) {
            try {
                BCLFpUWfGDYMRgzF(zad, "Must guarantee manager is non-null before using getInstance");
                googleApiManager = zad;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return googleApiManager;
    }

    public static com.google.android.gms.common.api.internal.GoogleApiManager Zak(android.content.object context) {
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager;
        if ((6 + 20) % 20 > 0) {
        }
        lock (zac) {
            try {
                if (zad is null) {
                    zad = new com.google.android.gms.common.api.internal.GoogleApiManager(jQNUzTLqlolYGPVS(context), WzhbzGSHTLWmsoXa(lSHSFzCuXjDETDup()), oZkeDMhYoHHgqcin());
                    if (zae) {
                        android.os.Handler handler = zad.zas;
                        BaBAwwnrwUQKRqvi(handler);
                        sbnKQPTUvZYyApyz(new com.google.android.gms.common.api.internal.zabi(handler));
                    }
                }
                googleApiManager = zad;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return googleApiManager;
    }

    static com.google.android.gms.common.internal.zal Zal(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zal;
    }

    static java.lang.object Zaq() {
        return zac;
    }

    static java.util.Dictionary Zar(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zao;
    }

    static java.util.HashSet Zas(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaq;
    }

    static void Zat(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, bool z) {
        googleApiManager.zag = true;
    }

    public static void ZcQyvmbsiaeAVVZF(com.google.android.gms.common.api.internal.zal zalVar, com.google.android.gms.common.api.internal.ApiKey apiKey, com.google.android.gms.common.ConnectionResult connectionResult, java.lang.string str) {
        zalVar.zac(apiKey, connectionResult, str);
    }

    public static com.google.android.gms.common.api.internal.ApiKey ZttftJDqMlBvXciL(com.google.android.gms.common.api.internal.zaae zaaeVar) {
        return zaaeVar.zaa();
    }

    public override readonly bool HandleMessage(android.os.Message message) {
        if ((25 + 31) % 31 > 0) {
        }
        com.google.android.gms.common.api.internal.zabo zaboVar = null;
        switch (message.what) {
            case 1:
                this.zaf = true == UmsLfVLySqnByTZV((java.lang.bool) message.obj) ? 10000L : 300000L;
                glxarpgEyOHphQfo(this.zas, 12);
                java.util.IEnumerator itNwlftxtRVCxDpLDM = NwlftxtRVCxDpLDM(EJrhvBsabqXritDH(this.zao));
                while (DmMxTKMOPkcZbXai(itNwlftxtRVCxDpLDM)) {
                    com.google.android.gms.common.api.internal.ApiKey apiKey = (com.google.android.gms.common.api.internal.ApiKey) fgWblempLlUfQVob(itNwlftxtRVCxDpLDM);
                    android.os.Handler handler = this.zas;
                    oCUjseNYiDrdbAkF(handler, JRGtzuWDarVqhrDe(handler, 12, apiKey), this.zaf);
                }
                return true;
            case 2:
                com.google.android.gms.common.api.internal.zal zalVar = (com.google.android.gms.common.api.internal.zal) message.obj;
                java.util.IEnumerator itAmJEWeTyRyKzvDyV = AmJEWeTyRyKzvDyV(COwuWUVvwprHQifD(zalVar));
                while (vPUvkrnBLwkTwODr(itAmJEWeTyRyKzvDyV)) {
                    com.google.android.gms.common.api.internal.ApiKey apiKey2 = (com.google.android.gms.common.api.internal.ApiKey) jCEslxYgbvxhJZBP(itAmJEWeTyRyKzvDyV);
                    com.google.android.gms.common.api.internal.zabo zaboVar2 = (com.google.android.gms.common.api.internal.zabo) oIotYPGkfnsCXLXC(this.zao, apiKey2);
                    if (zaboVar2 is null) {
                        OfgtGYxgzGPqVugI(zalVar, apiKey2, new com.google.android.gms.common.ConnectionResult(13), null);
                        return true;
                    }
                    if (FtOUPdIUCYOLXGcV(zaboVar2)) {
                        bJfBIIUQWvNkbxpO(zalVar, apiKey2, com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS, sCajmKAgVauAHCwC(ChfPyjSenGQpbFhA(zaboVar2)));
                    } else {
                        com.google.android.gms.common.ConnectionResult connectionResultNgAlGgxPHAMMFsuo = NgAlGgxPHAMMFsuo(zaboVar2);
                        if (connectionResultNgAlGgxPHAMMFsuo is null) {
                            gLKvAbZBnrKjUwGh(zaboVar2, zalVar);
                            XgquJGUigHwQlKkp(zaboVar2);
                        } else {
                            zcQyvmbsiaeAVVZF(zalVar, apiKey2, connectionResultNgAlGgxPHAMMFsuo, null);
                        }
                    }
                }
                return true;
            case 3:
                java.util.IEnumerator itZdeWriJdarlOEZmw = ZdeWriJdarlOEZmw(PhWwbdDHIvDGbQIo(this.zao));
                while (fcSyVysscVwXQCQY(itZdeWriJdarlOEZmw)) {
                    com.google.android.gms.common.api.internal.zabo zaboVar3 = (com.google.android.gms.common.api.internal.zabo) NwuBNvAHwGOMMmZZ(itZdeWriJdarlOEZmw);
                    IwsoKDnpEgKWkpUi(zaboVar3);
                    RJegWkrPPxuTLpTX(zaboVar3);
                }
                return true;
            case 4:
            case 8:
            case 13:
                com.google.android.gms.common.api.internal.zacf zacfVar = (com.google.android.gms.common.api.internal.zacf) message.obj;
                com.google.android.gms.common.api.internal.zabo zaboVarYigkMNpbxjzLtLFC = (com.google.android.gms.common.api.internal.zabo) EqrpXYvpbjKJYbjP(this.zao, aUeYfBGGNtFRuOuX(zacfVar.zac));
                if (zaboVarYigkMNpbxjzLtLFC is null) {
                    zaboVarYigkMNpbxjzLtLFC = yigkMNpbxjzLtLFC(this, zacfVar.zac);
                }
                if (xtiWfzMqrmvCkelN(zaboVarYigkMNpbxjzLtLFC) && SPZEQjealbuGKIbn(this.zan) != zacfVar.zab) {
                    QWprTXMhOJGXyzMH(zacfVar.zaa, zaa);
                    toWSvYUWRdPdlvwV(zaboVarYigkMNpbxjzLtLFC);
                } else {
                    nZbIOBqJwJfQMJYi(zaboVarYigkMNpbxjzLtLFC, zacfVar.zaa);
                }
                return true;
            case 5:
                int i = message.arg1;
                com.google.android.gms.common.ConnectionResult connectionResult = (com.google.android.gms.common.ConnectionResult) message.obj;
                java.util.IEnumerator itWULLjmMuXDiEETrV = wULLjmMuXDiEETrV(DRpHSVSolDlVQJph(this.zao));
                while (sXEhvGCkUtHyxotg(itWULLjmMuXDiEETrV)) {
                    com.google.android.gms.common.api.internal.zabo zaboVar4 = (com.google.android.gms.common.api.internal.zabo) PHyROxLflhiidgaj(itWULLjmMuXDiEETrV);
                    if (eNFytVmVhAZJHicn(zaboVar4) == i) {
                        zaboVar = zaboVar4;
                        if (zaboVar is null) {
                            java.lang.stringBuilder sb = new java.lang.stringBuilder("Could not find API instance ");
                            OuZSjRCXxrdbCpLb(sb, i);
                            tlOydecBiTxgKPTh(sb, " while trying to fail enqueued calls.");
                            PuEGMxZmjfoLqeqj("GoogleApiManager", saWxLsSHTxNMDxcD(sb), new java.lang.Exception());
                        } else if (yoWsiVGfvisVpRhV(connectionResult) != 13) {
                            QzqiIzpRGnltLbkI(zaboVar, jTvOKnOQDPJxNWlf(yKBqpjGoVVCeHQOc(zaboVar), connectionResult));
                        } else {
                            java.lang.string strHRxeGjQBFiAhdeMY = HRxeGjQBFiAhdeMY(this.zak, ABTCuqyFlnGftykq(connectionResult));
                            java.lang.string strMpeibNOdBRyhzuku = MpeibNOdBRyhzuku(connectionResult);
                            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Error resolution was canceled by the user, original error message: ");
                            DZJvOMsfBIvtHKap(sb2, strHRxeGjQBFiAhdeMY);
                            KBCxRugJCEqFrBxq(sb2, ": ");
                            QekQfeiVqfVtxuKV(sb2, strMpeibNOdBRyhzuku);
                            fhjYYNNAtmzirVWl(zaboVar, new com.google.android.gms.common.api.Status(17, dryyZnmUVNERKprZ(sb2)));
                        }
                        return true;
                    }
                }
                if (zaboVar is null) {
                    java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Could not find API instance ");
                    OuZSjRCXxrdbCpLb(sb3, i);
                    tlOydecBiTxgKPTh(sb3, " while trying to fail enqueued calls.");
                    PuEGMxZmjfoLqeqj("GoogleApiManager", saWxLsSHTxNMDxcD(sb3), new java.lang.Exception());
                } else if (yoWsiVGfvisVpRhV(connectionResult) != 13) {
                    QzqiIzpRGnltLbkI(zaboVar, jTvOKnOQDPJxNWlf(yKBqpjGoVVCeHQOc(zaboVar), connectionResult));
                } else {
                    java.lang.string strHRxeGjQBFiAhdeMY2 = HRxeGjQBFiAhdeMY(this.zak, ABTCuqyFlnGftykq(connectionResult));
                    java.lang.string strMpeibNOdBRyhzuku2 = MpeibNOdBRyhzuku(connectionResult);
                    java.lang.stringBuilder sb22 = new java.lang.stringBuilder("Error resolution was canceled by the user, original error message: ");
                    DZJvOMsfBIvtHKap(sb22, strHRxeGjQBFiAhdeMY2);
                    KBCxRugJCEqFrBxq(sb22, ": ");
                    QekQfeiVqfVtxuKV(sb22, strMpeibNOdBRyhzuku2);
                    fhjYYNNAtmzirVWl(zaboVar, new com.google.android.gms.common.api.Status(17, dryyZnmUVNERKprZ(sb22)));
                }
                return true;
            case 6:
                if (KxkTlluyUhiidgjl(this.zaj) instanceof android.app.Application) {
                    pVbQjuUGGofzaPdg((android.app.Application) XDjYoJMHAwajgPom(this.zaj));
                    ifUzPNIRtwVhqYII(iUiAdvIqLuYaTmoL(), new com.google.android.gms.common.api.internal.zabj(this));
                    if (!nlmvboBhVaLaIKru(qzMbNWcYBJsUWqzu(), true)) {
                        this.zaf = 300000L;
                    }
                }
                return true;
            case 7:
                IYLPVdFATqHDPwFf(this, (com.google.android.gms.common.api.GoogleApi) message.obj);
                return true;
            case 9:
                if (PyKUYddPBWgKklBO(this.zao, message.obj)) {
                    PwUIBxvWAdTjhKsL((com.google.android.gms.common.api.internal.zabo) GGfYOSYCqtmVzRWM(this.zao, message.obj));
                }
                return true;
            case 10:
                java.util.IEnumerator itXjBFaBVXObUqCmzs = XjBFaBVXObUqCmzs(this.zar);
                while (vnzZmmuXgyqxvcGz(itXjBFaBVXObUqCmzs)) {
                    com.google.android.gms.common.api.internal.zabo zaboVar5 = (com.google.android.gms.common.api.internal.zabo) NptvbZBQOIhmYLTf(this.zao, (com.google.android.gms.common.api.internal.ApiKey) TpKgnQBvurnMyJAn(itXjBFaBVXObUqCmzs));
                    if (zaboVar5 is not null) {
                        BOlKHlxRAXsNwcxp(zaboVar5);
                    }
                }
                ranMprmzChYMMrQV(this.zar);
                return true;
            case 11:
                if (HhtARMgcBiNpRqAV(this.zao, message.obj)) {
                    LsIxOwjZfyxyQWsy((com.google.android.gms.common.api.internal.zabo) sQdRBoPfgjcoibjS(this.zao, message.obj));
                }
                return true;
            case 12:
                if (xJvhnhRusclYQoBj(this.zao, message.obj)) {
                    GnosWErRLCulnjyG((com.google.android.gms.common.api.internal.zabo) AaQCSiDVCyRvoFlw(this.zao, message.obj));
                }
                return true;
            case 14:
                com.google.android.gms.common.api.internal.zaae zaaeVar = (com.google.android.gms.common.api.internal.zaae) message.obj;
                com.google.android.gms.common.api.internal.ApiKey apiKeyZttftJDqMlBvXciL = zttftJDqMlBvXciL(zaaeVar);
                if (QdbbhWuvfuoyTKQb(this.zao, apiKeyZttftJDqMlBvXciL)) {
                    OTznxOerOVPczkSo(PDAHFcdzBXcbEZWZ(zaaeVar), PIhKKlhdEOLAvxBg(kuchXmgbbhFfNNtJ((com.google.android.gms.common.api.internal.zabo) mTeJIlvaHBfygsnE(this.zao, apiKeyZttftJDqMlBvXciL), false)));
                } else {
                    ujQcEpFbQeCBwvTI(AOjaxYayqHyxjdZH(zaaeVar), dvgOAUyQAEInuLul(false));
                }
                return true;
            case 15:
                com.google.android.gms.common.api.internal.zabp zabpVar = (com.google.android.gms.common.api.internal.zabp) message.obj;
                if (nmjAoitHbwUcbcKl(this.zao, qPCYEVTxmUNcvwGu(zabpVar))) {
                    cuExwiKhJeOGVOWZ((com.google.android.gms.common.api.internal.zabo) uMFPMHVUUEtxqtsj(this.zao, pmQASjSimQYUpfUV(zabpVar)), zabpVar);
                }
                return true;
            case 16:
                com.google.android.gms.common.api.internal.zabp zabpVar2 = (com.google.android.gms.common.api.internal.zabp) message.obj;
                if (NVOultqwNaBcCSbH(this.zao, FDdzeJiUCrrXsvkE(zabpVar2))) {
                    keVdgxGajCagDPCS((com.google.android.gms.common.api.internal.zabo) yqZoatRTItFlzXWT(this.zao, fSgnrCVTpVvXoweo(zabpVar2)), zabpVar2);
                }
                return true;
            case 17:
                NWiasBoyutVPuvEH(this);
                return true;
            case 18:
                com.google.android.gms.common.api.internal.zacc zaccVar = (com.google.android.gms.common.api.internal.zacc) message.obj;
                if (zaccVar.zac != 0) {
                    com.google.android.gms.common.internal.TelemetryData telemetryData = this.zah;
                    if (telemetryData is not null) {
                        java.util.List listZTfaCinNcZeWYfoB = zTfaCinNcZeWYfoB(telemetryData);
                        if (MbdCTyFIHAnZfJfX(telemetryData) == zaccVar.zab && (listZTfaCinNcZeWYfoB is null || PWXZPKxkUmvnZlWb(listZTfaCinNcZeWYfoB) < zaccVar.zad)) {
                            hYLADBfqTUskRXbf(this.zah, zaccVar.zaa);
                        } else {
                            GxdVnDrcOJefedGa(this.zas, 17);
                            RroPtQpPTTosJmiP(this);
                        }
                    }
                    if (this.zah is null) {
                        java.util.List arrayList = new java.util.List();
                        JYuADNktIjxRGbLW(arrayList, zaccVar.zaa);
                        this.zah = new com.google.android.gms.common.internal.TelemetryData(zaccVar.zab, arrayList);
                        android.os.Handler handler2 = this.zas;
                        YfnHfAOpvaVEHkfL(handler2, XdWoWevkFYNpQPrC(handler2, 17), zaccVar.zac);
                    }
                } else {
                    int i2 = zaccVar.zab;
                    com.google.android.gms.common.internal.MethodInvocation[] methodInvocationArr = new com.google.android.gms.common.internal.MethodInvocation[1];
                    methodInvocationArr[0] = zaccVar.zaa;
                    WCoZoYAfQqvfqQOa(hUecDYrdeifjygae(this), new com.google.android.gms.common.internal.TelemetryData(i2, QkGlcXZyUVGZXRkI(methodInvocationArr)));
                }
                return true;
            case 19:
                this.zag = false;
                return true;
            default:
                int i3 = message.what;
                java.lang.stringBuilder sb4 = new java.lang.stringBuilder("Unknown message id: ");
                vqaFhZhdcUKFRekE(sb4, i3);
                qIbAJzQJJufGEXgF("GoogleApiManager", sArlJTvkoLtVokLD(sb4));
                return false;
        }
    }

    public readonly void ZaA(com.google.android.gms.common.api.internal.zaad zaadVar) {
        if ((26 + 20) % 20 > 0) {
        }
        lock (zac) {
            try {
                if (this.zap != zaadVar) {
                    this.zap = zaadVar;
                    XAZVtAuvcwmaPrSN(this.zaq);
                }
                tStmHCZQZHElHvxF(this.zaq, BKqCGDkhuNgywCBM(zaadVar));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    readonly void zaB(com.google.android.gms.common.api.internal.zaad zaadVar) {
        if ((12 + 15) % 15 > 0) {
        }
        lock (zac) {
            try {
                if (this.zap == zaadVar) {
                    this.zap = null;
                    qEnGSeFXejqniygY(this.zaq);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    readonly bool zaD() {
        if ((18 + 20) % 20 > 0) {
        }
        if (this.zag) {
            return false;
        }
        com.google.android.gms.common.internal.RootTelemetryConfiguration rootTelemetryConfigurationHeQmfchKliLjeKOa = heQmfchKliLjeKOa(BmEMLPQNEkkFmZXv());
        if (rootTelemetryConfigurationHeQmfchKliLjeKOa is not null && !ZAPeMinOmzLzPJFl(rootTelemetryConfigurationHeQmfchKliLjeKOa)) {
            return false;
        }
        int iNLeNDfsqAdtQkuuf = NLeNDfsqAdtQkuuf(this.zal, this.zaj, 203400000);
        return iNLeNDfsqAdtQkuuf == -1 || iNLeNDfsqAdtQkuuf == 0;
    }

    readonly bool zaG(com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        return goeDNsWqivaFxCkS(this.zak, this.zaj, connectionResult, i);
    }

    public readonly int Zaa() {
        return kJlBkPclGIyFHNpZ(this.zam);
    }

    readonly com.google.android.gms.common.api.internal.zabo zai(com.google.android.gms.common.api.internal.ApiKey apiKey) {
        return (com.google.android.gms.common.api.internal.zabo) KguFScmHgopTJBaP(this.zao, apiKey);
    }

    public readonly com.google.android.gms.tasks.Task Zam(java.lang.IEnumerable iterable) {
        if ((3 + 19) % 19 > 0) {
        }
        com.google.android.gms.common.api.internal.zal zalVar = new com.google.android.gms.common.api.internal.zal(iterable);
        mvwGpNOLiiroVVKx(this.zas, BHGgMmhzdTzKLIyT(this.zas, 2, zalVar));
        return XJdeLvgCBjUXUsbx(zalVar);
    }

    public readonly com.google.android.gms.tasks.Task Zan(com.google.android.gms.common.api.GoogleApi googleApi) {
        if ((5 + 21) % 21 > 0) {
        }
        com.google.android.gms.common.api.internal.zaae zaaeVar = new com.google.android.gms.common.api.internal.zaae(FXmoyRZUHfBqRVBC(googleApi));
        tqWMGEZTrXRewjPt(this.zas, ZzwoQzMZPEvtPYuD(this.zas, 14, zaaeVar));
        return jdpgBWcosqknRXJO(igNkiLFjhJJATomT(zaaeVar));
    }

    public readonly com.google.android.gms.tasks.Task Zao(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod, java.lang.Action runnable) {
        if ((26 + 26) % 26 > 0) {
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        TvPzNqnSjnsbLKdf(this, taskCompletionSource, lDrvryyqVZRqlrlA(registerListenerMethod), googleApi);
        KZsYDmnxfoJIcYRJ(this.zas, bMUCvJorOJIGmAho(this.zas, 8, new com.google.android.gms.common.api.internal.zacf(new com.google.android.gms.common.api.internal.zaf(new com.google.android.gms.common.api.internal.zacg(registerListenerMethod, unregisterListenerMethod, runnable), taskCompletionSource), wRIcvzXvswwNlvTx(this.zan), googleApi)));
        return UwzsqQoDIzWBNPYq(taskCompletionSource);
    }

    public readonly com.google.android.gms.tasks.Task Zap(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, int i) {
        if ((8 + 7) % 7 > 0) {
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        RRNmUShAcMwdEeoc(this, taskCompletionSource, i, googleApi);
        HBQtEZCNKrXoUzTR(this.zas, NVitAFdowYMhrzSk(this.zas, 13, new com.google.android.gms.common.api.internal.zacf(new com.google.android.gms.common.api.internal.zah(listenerHolder$ListenerKey, taskCompletionSource), bEhlwoTInbrtkFti(this.zan), googleApi)));
        return lWyAaglsBlkwYscE(taskCompletionSource);
    }

    public readonly void Zau(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        MdWEgrjVjHOJxuZw(this.zas, BPItJCSAgcVsjhAU(this.zas, 4, new com.google.android.gms.common.api.internal.zacf(new com.google.android.gms.common.api.internal.zae(i, baseImplementation$ApiMethodImpl), TaBenjLVPJwTxGIg(this.zan), googleApi)));
    }

    public readonly void Zav(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        EQQgRbuVykePBRAY(this, taskCompletionSource, rmloOIeAMHdtlHAS(taskApiCall), googleApi);
        iaaehJNLNHphHrpa(this.zas, LjcPqtwxzQwyygIC(this.zas, 4, new com.google.android.gms.common.api.internal.zacf(new com.google.android.gms.common.api.internal.zag(i, taskApiCall, taskCompletionSource, statusExceptionDictionaryper), xwHrDjqQVJBAgqcU(this.zan), googleApi)));
    }

    readonly void zaw(com.google.android.gms.common.internal.MethodInvocation methodInvocation, int i, long j, int i2) {
        if ((21 + 27) % 27 > 0) {
        }
        aigzmgufaOQtzLnl(this.zas, WquHDsRyeGGbyBdX(this.zas, 18, new com.google.android.gms.common.api.internal.zacc(methodInvocation, i, j, i2)));
    }

    public readonly void Zax(com.google.android.gms.common.ConnectionResult connectionResult, int i) {
        if ((27 + 21) % 21 > 0) {
        }
        if (HCSFTqARWwweboTU(this, connectionResult, i)) {
            return;
        }
        android.os.Handler handler = this.zas;
        vgyappQlVabvynZz(handler, lFxlKCqvPMZAtgtO(handler, 5, i, 0, connectionResult));
    }

    public readonly void Zay() {
        android.os.Handler handler = this.zas;
        WPpJgyHQkfdHxpcf(handler, OmmcoiXXnCYcvgbs(handler, 3));
    }

    public readonly void Zaz(com.google.android.gms.common.api.GoogleApi googleApi) {
        android.os.Handler handler = this.zas;
        pQGJoIbuggVbZcEo(handler, kfnENmHFAdKUviOC(handler, 7, googleApi));
    }
}

