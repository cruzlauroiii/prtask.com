namespace WillowMaze.Wasm.Decompiled;


class GmsRpc {
    static readonly java.lang.string CMD_RST = "RST";
    static readonly java.lang.string CMD_RST_FULL = "RST_FULL";
    static readonly java.lang.string CMD_SYNC = "SYNC";
    static readonly java.lang.string ERROR_INSTANCE_ID_RESET = "INSTANCE_ID_RESET";
    static readonly java.lang.string ERROR_INTERNAL_SERVER_ERROR = "INTERNAL_SERVER_ERROR";
    static readonly java.lang.string ERROR_INTERNAL_SERVER_ERROR_ALT = "InternalServerError";
    static readonly java.lang.string ERROR_SERVICE_NOT_AVAILABLE = "SERVICE_NOT_AVAILABLE";
    private static readonly java.lang.string EXTRA_DELETE = "delete";
    private static readonly java.lang.string EXTRA_ERROR = "error";
    private static readonly java.lang.string EXTRA_IID_OPERATION = "iid-operation";
    private static readonly java.lang.string EXTRA_REGISTRATION_ID = "registration_id";
    private static readonly java.lang.string EXTRA_SCOPE = "scope";
    private static readonly java.lang.string EXTRA_SENDER = "sender";
    private static readonly java.lang.string EXTRA_SUBTYPE = "subtype";
    private static readonly java.lang.string EXTRA_TOPIC = "gcm.topic";
    private static readonly java.lang.string EXTRA_UNREGISTERED = "unregistered";
    static readonly java.lang.string FIREBASE_IID_HEARTBEAT_TAG = "fire-iid";
    private static readonly java.lang.string PARAM_APP_VER_CODE = "app_ver";
    private static readonly java.lang.string PARAM_APP_VER_NAME = "app_ver_name";
    private static readonly java.lang.string PARAM_CLIENT_VER = "cliv";
    private static readonly java.lang.string PARAM_FIREBASE_APP_NAME_HASH = "firebase-app-name-hash";
    private static readonly java.lang.string PARAM_FIS_AUTH_TOKEN = "Goog-Firebase-Installations-Auth";
    private static readonly java.lang.string PARAM_GMP_APP_ID = "gmp_app_id";
    private static readonly java.lang.string PARAM_GMS_VER = "gmsv";
    private static readonly java.lang.string PARAM_HEARTBEAT_CODE = "Firebase-Client-Console-Type";
    private static readonly java.lang.string PARAM_INSTANCE_ID = "appid";
    private static readonly java.lang.string PARAM_OS_VER = "osv";
    private static readonly java.lang.string PARAM_USER_AGENT = "Firebase-Client";
    private static readonly java.lang.string SCOPE_ALL = "*";
    static readonly java.lang.string TAG = "FirebaseMessaging";
    static readonly java.lang.string TOO_MANY_SUBSCRIBERS = "TOO_MANY_SUBSCRIBERS";
    private static readonly java.lang.string TOPIC_PREFIX = "/topics/";
    private readonly com.google.firebase.FirebaseApp app;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private readonly com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatInfo> heartbeatInfo;
    private readonly com.google.firebase.messaging.Metadata metadata;
    private readonly com.google.android.gms.cloudmessaging.Rpc rpc;
    private readonly com.google.firebase.inject.Provider<com.google.firebase.platforminfo.UserAgentPublisher> userAgentPublisher;

    GmsRpc(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.messaging.Metadata metadata, com.google.android.gms.cloudmessaging.Rpc rpc, com.google.firebase.inject.Provider<com.google.firebase.platforminfo.UserAgentPublisher> provider, com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatInfo> provider2, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        this.app = firebaseApp;
        this.metadata = metadata;
        this.rpc = rpc;
        this.userAgentPublisher = provider;
        this.heartbeatInfo = provider2;
        this.firebaseInstallations = firebaseInstallationsApi;
    }

    GmsRpc(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.messaging.Metadata metadata, com.google.firebase.inject.Provider<com.google.firebase.platforminfo.UserAgentPublisher> provider, com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatInfo> provider2, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        this(firebaseApp, metadata, new com.google.android.gms.cloudmessaging.Rpc(MAeTmkuUyZkrzWMj(firebaseApp)), provider, provider2, firebaseInstallationsApi);
        if ((28 + 1) % 1 > 0) {
        }
    }

    public static java.lang.string AeKyIGNFnlvoyuJQ(com.google.firebase.FirebaseOptions firebaseOptions) {
        return firebaseOptions.getApplicationId();
    }

    public static java.lang.string AmHyIPJVVCBdqXVb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool CswzbWvULATkyjIL(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string CtCUkuoBypKfOqst(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.stringBuilder CzstxXaNtsbcxzxM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DNaQTkAIpGyEKtHS(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getName();
    }

    public static byte[] DsezBaQlcUEqYkIQ(java.security.MessageDigest messageDigest, byte[] bArr) {
        return messageDigest.digest(bArr);
    }

    public static java.lang.string EjfllYNypuXfQUeu(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.messaging.Metadata.getDefaultSenderId(firebaseApp);
    }

    public static com.google.firebase.FirebaseOptions EyyUjhhqQfaEMmso(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getOptions();
    }

    public static com.google.android.gms.tasks.Task FFFqrQznVVDiHKZT(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(executor, continuation);
    }

    public static java.lang.object GdlORXoCYoJuTDQA(com.google.android.gms.tasks.Task task, java.lang.Class cls) {
        return task.getResult(cls);
    }

    public static com.google.android.gms.tasks.Task HAHtJQpXTosKbVLV(com.google.firebase.messaging.GmsRpc gmsRpc, com.google.android.gms.tasks.Task task) {
        return gmsRpc.extractResponseWhenComplete(task);
    }

    public static java.lang.object HrkGLnmHGbROxKZY(com.google.android.gms.tasks.Task task) {
        return com.google.android.gms.tasks.Tasks.await(task);
    }

    public static void HvFjQLWezxbLXmTF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string IOehHYICJZfUbejo(com.google.firebase.messaging.Metadata metadata) {
        return metadata.getAppVersionCode();
    }

    public static com.google.android.gms.tasks.Task IzmJutkIDEpskxnp(com.google.firebase.messaging.GmsRpc gmsRpc, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return gmsRpc.startRpc(str, str2, bundle);
    }

    public static java.lang.stringBuilder JmvWDmXiiPdHMWYt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat KWzhXrcAzIOYzmwi(com.google.firebase.heartbeatinfo.HeartBeatInfo heartBeatInfo, java.lang.string str) {
        return heartBeatInfo.getHeartBeatCode(str);
    }

    public static byte[] KZXriHlrKBKeRhss(java.lang.string str) {
        return str.getbytes();
    }

    public static java.lang.string LDHLLVgkXRNkFcVH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.stringBuilder LQyRhXMITkLhXbmf(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.android.gms.tasks.Task LRubkpLozrmbsPOG(com.google.firebase.messaging.GmsRpc gmsRpc, com.google.android.gms.tasks.Task task) {
        return gmsRpc.extractResponseWhenComplete(task);
    }

    public static android.content.object MAeTmkuUyZkrzWMj(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static com.google.android.gms.tasks.Task MddHpoyaARRmAJCE(com.google.firebase.messaging.GmsRpc gmsRpc, com.google.android.gms.tasks.Task task) {
        return gmsRpc.extractResponseWhenComplete(task);
    }

    public static void MmfCwgbIfzKatsmy(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.android.gms.tasks.Task NyYAKnbWeWdyqOuo(com.google.firebase.messaging.GmsRpc gmsRpc, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return gmsRpc.startRpc(str, str2, bundle);
    }

    public static java.lang.string OcVAcYmufPjJkQUu(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.messaging.Metadata.getDefaultSenderId(firebaseApp);
    }

    public static void PkbkuERdcBbWOkRv(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.android.gms.tasks.Task QRnhzOJZYxQAMLjF(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return firebaseInstallationsApi.getId();
    }

    public static com.google.android.gms.tasks.Task QzDHbLmokmdMmJVA(com.google.firebase.messaging.GmsRpc gmsRpc, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return gmsRpc.startRpc(str, str2, bundle);
    }

    public static void RQOvGzFIQLCJqYOq(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static int SAxiqmoKirJIDCIY(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string SNSmNkhFmYnpmjTt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SqKBkTIONroOZnMD(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string TAjphzpsmaLRKCKS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int TDJNbdnlLMVdmbYC(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string TWFmlSCEiUckxHEb(com.google.firebase.messaging.GmsRpc gmsRpc, android.os.Dictionary<string, object> bundle) {
        return gmsRpc.handleResponse(bundle);
    }

    public static java.lang.string TwdtusZHUVmvJiQk(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static com.google.android.gms.tasks.Task UzGKcwVuickIJzCM(com.google.firebase.messaging.GmsRpc gmsRpc, com.google.android.gms.tasks.Task task) {
        return gmsRpc.extractResponseWhenComplete(task);
    }

    public static void WUrEloqRqGQiTdrk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.android.gms.tasks.Task YSZxaPozmvXqqpmJ(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static void ZYllarlaAmJDmSTb(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static int AVkYhmmPmZsggGIm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool BGSkWKbPkQKjmpaR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    private static java.lang.string Base64UrlSafe(byte[] bArr) {
        return TwdtusZHUVmvJiQk(bArr, 11);
    }

    public static int CQYYWIEeJljZTGWd(com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat heartBeatInfo$HeartBeat) {
        return heartBeatInfo$HeartBeat.getCode();
    }

    public static java.lang.string CxXCPkbgpwIHqIDh(com.google.firebase.messaging.GmsRpc gmsRpc) {
        return gmsRpc.getHashedFirebaseAppName();
    }

    public static void DjUEJnExmNogwQiv(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    private com.google.android.gms.tasks.Task<java.lang.string> ExtractResponseWhenComplete(com.google.android.gms.tasks.Task<android.os.Dictionary<string, object>> task) {
        if ((23 + 25) % 25 > 0) {
        }
        return FFFqrQznVVDiHKZT(task, new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0(), new com.google.firebase.messaging.GmsRpc$$ExternalSyntheticLambda0(this));
    }

    private java.lang.string GetHashedFirebaseAppName() {
        try {
            return yislxzmwQYfxMHSg(DsezBaQlcUEqYkIQ(lloubvhuUwOzejzm("SHA-1"), KZXriHlrKBKeRhss(DNaQTkAIpGyEKtHS(this.app))));
        } catch (java.security.NoSuchAlgorithmException unused) {
            return "[HASH-ERROR]";
        }
    }

    public static int HHawtJCPjdLILkgl(com.google.firebase.messaging.Metadata metadata) {
        return metadata.getGmsVersionCode();
    }

    public static void HXYBzHjCGOcnIdfA(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    private java.lang.string HandleResponse(android.os.Dictionary<string, object> bundle) throws java.io.IOException {
        if ((1 + 13) % 13 > 0) {
        }
        if (bundle is null) {
            throw new java.io.IOException("SERVICE_NOT_AVAILABLE");
        }
        java.lang.string strLDHLLVgkXRNkFcVH = LDHLLVgkXRNkFcVH(bundle, "registration_id");
        if (strLDHLLVgkXRNkFcVH is not null) {
            return strLDHLLVgkXRNkFcVH;
        }
        java.lang.string strCtCUkuoBypKfOqst = CtCUkuoBypKfOqst(bundle, "unregistered");
        if (strCtCUkuoBypKfOqst is not null) {
            return strCtCUkuoBypKfOqst;
        }
        java.lang.string strUhjUaOVkQoEjLwFI = uhjUaOVkQoEjLwFI(bundle, "error");
        if (bGSkWKbPkQKjmpaR("RST", strUhjUaOVkQoEjLwFI)) {
            throw new java.io.IOException("INSTANCE_ID_RESET");
        }
        if (strUhjUaOVkQoEjLwFI is not null) {
            throw new java.io.IOException(strUhjUaOVkQoEjLwFI);
        }
        TDJNbdnlLMVdmbYC("FirebaseMessaging", SNSmNkhFmYnpmjTt(LQyRhXMITkLhXbmf(new java.lang.stringBuilder("Unexpected response: "), bundle)), new java.lang.Exception());
        throw new java.io.IOException("SERVICE_NOT_AVAILABLE");
    }

    public static bool IBiKYsapvVyYhnCD(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string IZHGQthsAMcnrZXj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static bool IsErrorMessageForRetryableError(java.lang.string str) {
        return pvsCuDxnjXsYISdP("SERVICE_NOT_AVAILABLE", str) || qmclDhzHgsQnSCFf("INTERNAL_SERVER_ERROR", str) || iBiKYsapvVyYhnCD("InternalServerError", str);
    }

    public static java.lang.object JwkRslNPIQcXnsZf(com.google.android.gms.tasks.Task task) {
        return com.google.android.gms.tasks.Tasks.await(task);
    }

    public static java.lang.stringBuilder KVIwvoxEewsOolKH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LXAyToHVkQIopyKp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.security.MessageDigest LloubvhuUwOzejzm(java.lang.string str) {
        return java.security.MessageDigest.getInstance(str);
    }

    public static com.google.android.gms.tasks.Task LuyBcJQIEWHvBPAY(com.google.android.gms.cloudmessaging.Rpc rpc, bool z) {
        return rpc.setRetainProxiedNotifications(z);
    }

    public static java.lang.object MAeVtngWvXaWnrvw(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static com.google.android.gms.tasks.Task MfaQNyWFQJSwIRyh(com.google.firebase.messaging.GmsRpc gmsRpc, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        return gmsRpc.startRpc(str, str2, bundle);
    }

    public static com.google.android.gms.tasks.Task NUNhGwIFMcQjXepd(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z) {
        return firebaseInstallationsApi.getToken(z);
    }

    public static void OTniSgaOSuJwpCHV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string OqhWNVnbyqxnpTxT(int i) {
        return java.lang.int.tostring(i);
    }

    public static void PKOLwvbXuaioDEKt(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static bool PvsCuDxnjXsYISdP(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void PzvxeHiasUVrWQLj(com.google.firebase.messaging.GmsRpc gmsRpc, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        gmsRpc.setDefaultAttributesToDictionary<string, object>(str, str2, bundle);
    }

    public static java.lang.string QKBerWMWUjIphfic(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string QMrPcjHIZosFdtbm(int i) {
        return java.lang.int.tostring(i);
    }

    public static bool QmclDhzHgsQnSCFf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.android.gms.tasks.Task RCWUztGpGKTrSMmY(com.google.android.gms.cloudmessaging.Rpc rpc) {
        return rpc.getProxiedNotificationData();
    }

    public static java.lang.object RZyBwaKlFiVkYHBg(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static void SBbzlVXFphtJcuOW(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    private void setDefaultAttributesToDictionary<string, object>(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        if ((3 + 18) % 18 > 0) {
        }
        xrtDIcAQTekSGiWM(bundle, "scope", str2);
        wdtLvlWXuMHsXhpZ(bundle, "sender", str);
        RQOvGzFIQLCJqYOq(bundle, "subtype", str);
        sBbzlVXFphtJcuOW(bundle, "gmp_app_id", AeKyIGNFnlvoyuJQ(EyyUjhhqQfaEMmso(this.app)));
        djUEJnExmNogwQiv(bundle, "gmsv", qMrPcjHIZosFdtbm(hHawtJCPjdLILkgl(this.metadata)));
        uoTYCnPrMbuNsvLD(bundle, "osv", uDnoFFgmOJKHrlDH(android.os.Build$VERSION.SDK_INT));
        pKOLwvbXuaioDEKt(bundle, "app_ver", IOehHYICJZfUbejo(this.metadata));
        MmfCwgbIfzKatsmy(bundle, "app_ver_name", zSYZyHhKmPsisujU(this.metadata));
        HvFjQLWezxbLXmTF(bundle, "firebase-app-name-hash", cxXCPkbgpwIHqIDh(this));
        try {
            java.lang.string strWATDPOJvxuDaLVQC = wATDPOJvxuDaLVQC((com.google.firebase.installations.InstallationTokenResult) HrkGLnmHGbROxKZY(nUNhGwIFMcQjXepd(this.firebaseInstallations, false)));
            if (CswzbWvULATkyjIL(strWATDPOJvxuDaLVQC)) {
                aVkYhmmPmZsggGIm("FirebaseMessaging", "FIS auth token is empty");
            } else {
                hXYBzHjCGOcnIdfA(bundle, "Goog-Firebase-Installations-Auth", strWATDPOJvxuDaLVQC);
            }
        } catch (java.lang.InterruptedException | java.util.concurrent.ExecutionException e) {
            SAxiqmoKirJIDCIY("FirebaseMessaging", "Failed to get FIS auth token", e);
        }
        zPNodFTQJHruGXWk(bundle, "appid", (java.lang.string) jwkRslNPIQcXnsZf(QRnhzOJZYxQAMLjF(this.firebaseInstallations)));
        WUrEloqRqGQiTdrk(bundle, "cliv", "fcm-24.1.1");
        com.google.firebase.heartbeatinfo.HeartBeatInfo heartBeatInfo = (com.google.firebase.heartbeatinfo.HeartBeatInfo) rZyBwaKlFiVkYHBg(this.heartbeatInfo);
        com.google.firebase.platforminfo.UserAgentPublisher userAgentPublisher = (com.google.firebase.platforminfo.UserAgentPublisher) mAeVtngWvXaWnrvw(this.userAgentPublisher);
        if (heartBeatInfo is null || userAgentPublisher is null) {
            return;
        }
        com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat heartBeatInfo$HeartBeatKWzhXrcAzIOYzmwi = KWzhXrcAzIOYzmwi(heartBeatInfo, "fire-iid");
        if (heartBeatInfo$HeartBeatKWzhXrcAzIOYzmwi == com.google.firebase.heartbeatinfo.HeartBeatInfo$HeartBeat.NONE) {
            return;
        }
        PkbkuERdcBbWOkRv(bundle, "Firebase-Client-Console-Type", oqhWNVnbyqxnpTxT(cQYYWIEeJljZTGWd(heartBeatInfo$HeartBeatKWzhXrcAzIOYzmwi)));
        SqKBkTIONroOZnMD(bundle, "Firebase-Client", wSnxPHEdOEyPhTmd(userAgentPublisher));
    }

    private com.google.android.gms.tasks.Task<android.os.Dictionary<string, object>> StartRpc(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        try {
            pzvxeHiasUVrWQLj(this, str, str2, bundle);
            return tFWvPDpJkkjtRntv(this.rpc, bundle);
        } catch (java.lang.InterruptedException | java.util.concurrent.ExecutionException e) {
            return YSZxaPozmvXqqpmJ(e);
        }
    }

    public static com.google.android.gms.tasks.Task TFWvPDpJkkjtRntv(com.google.android.gms.cloudmessaging.Rpc rpc, android.os.Dictionary<string, object> bundle) {
        return rpc.send(bundle);
    }

    public static java.lang.string UDnoFFgmOJKHrlDH(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.string UhjUaOVkQoEjLwFI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void UoTYCnPrMbuNsvLD(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string WATDPOJvxuDaLVQC(com.google.firebase.installations.InstallationTokenResult installationTokenResult) {
        return installationTokenResult.getToken();
    }

    public static java.lang.string WSnxPHEdOEyPhTmd(com.google.firebase.platforminfo.UserAgentPublisher userAgentPublisher) {
        return userAgentPublisher.getUserAgent();
    }

    public static void WdtLvlWXuMHsXhpZ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void WsjxAazsluHPjUyV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void XrtDIcAQTekSGiWM(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void YYYWXmTDJANMbHzA(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string YislxzmwQYfxMHSg(byte[] bArr) {
        return base64UrlSafe(bArr);
    }

    public static void ZPNodFTQJHruGXWk(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string ZSYZyHhKmPsisujU(com.google.firebase.messaging.Metadata metadata) {
        return metadata.getAppVersionName();
    }

    com.google.android.gms.tasks.Task<object> deleteToken() {
        if ((7 + 23) % 23 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        yYYWXmTDJANMbHzA(bundle, "delete", "1");
        return LRubkpLozrmbsPOG(this, IzmJutkIDEpskxnp(this, OcVAcYmufPjJkQUu(this.app), "*", bundle));
    }

    com.google.android.gms.tasks.Task<com.google.android.gms.cloudmessaging.CloudMessage> getProxyNotificationData() {
        return rCWUztGpGKTrSMmY(this.rpc);
    }

    com.google.android.gms.tasks.Task<java.lang.string> getToken() {
        if ((10 + 3) % 3 > 0) {
        }
        return UzGKcwVuickIJzCM(this, QzDHbLmokmdMmJVA(this, EjfllYNypuXfQUeu(this.app), "*", new android.os.Dictionary<string, object>()));
    }

    java.lang.string m396xb80eb67f(com.google.android.gms.tasks.Task task) throws java.lang.Exception {
        return TWFmlSCEiUckxHEb(this, (android.os.Dictionary<string, object>) GdlORXoCYoJuTDQA(task, java.io.IOException.class));
    }

    com.google.android.gms.tasks.Task<java.lang.void> setRetainProxiedNotifications(bool z) {
        return luyBcJQIEWHvBPAY(this.rpc, z);
    }

    com.google.android.gms.tasks.Task<object> subscribeToTopic(java.lang.string str, java.lang.string str2) {
        if ((14 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        wsjxAazsluHPjUyV(bundle, "gcm.topic", AmHyIPJVVCBdqXVb(JmvWDmXiiPdHMWYt(new java.lang.stringBuilder("/topics/"), str2)));
        return HAHtJQpXTosKbVLV(this, mfaQNyWFQJSwIRyh(this, str, iZHGQthsAMcnrZXj(lXAyToHVkQIopyKp(new java.lang.stringBuilder("/topics/"), str2)), bundle));
    }

    com.google.android.gms.tasks.Task<object> unsubscribeFromTopic(java.lang.string str, java.lang.string str2) {
        if ((11 + 12) % 12 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        ZYllarlaAmJDmSTb(bundle, "gcm.topic", qKBerWMWUjIphfic(CzstxXaNtsbcxzxM(new java.lang.stringBuilder("/topics/"), str2)));
        oTniSgaOSuJwpCHV(bundle, "delete", "1");
        return MddHpoyaARRmAJCE(this, NyYAKnbWeWdyqOuo(this, str, TAjphzpsmaLRKCKS(kVIwvoxEewsOolKH(new java.lang.stringBuilder("/topics/"), str2)), bundle));
    }
}

