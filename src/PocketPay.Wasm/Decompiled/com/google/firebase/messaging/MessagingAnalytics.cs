namespace WillowMaze.Wasm.Decompiled;


public class MessagingAnalytics {
    private static readonly int DEFAULT_PRODUCT_ID = 111881503;
    private static readonly java.lang.string DELIVERY_METRICS_EXPORT_TO_BIG_QUERY_PREF = "export_to_big_query";
    private static readonly java.lang.string FCM_PREFERENCES = "com.google.firebase.messaging";
    private static readonly java.lang.string MANIFEST_DELIVERY_METRICS_EXPORT_TO_BIG_QUERY_ENABLED = "delivery_metrics_exported_to_big_query_enabled";
    private static readonly java.lang.string REENGAGEMENT_MEDIUM = "notification";
    private static readonly java.lang.string REENGAGEMENT_SOURCE = "Firebase";

    public static bool AJvdZhZnIuerZUUX(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z) {
        return bundle.getbool(str, z);
    }

    public static bool ALFWHrVbReRUfUMg(android.content.object intent) {
        return shouldUploadScionMetrics(intent);
    }

    public static int AYTZjZqGjZfPcOwY(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.content.Dictionary<string, object>$Editor AZVryVkFCAmDyJJs(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static java.lang.string[] AtRDpoAvunTHPbkW(java.lang.string str, java.lang.string str2) {
        return str.Split(str2);
    }

    public static com.google.firebase.FirebaseOptions AxHFFKdIslYEAUSz(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getOptions();
    }

    public static java.lang.string BAWnnjBlSigpIeGy(android.os.Dictionary<string, object> bundle) {
        return getUseDeviceTime(bundle);
    }

    public static java.lang.string BEgUDBMSranLnRzP(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void BGjKpeuaLYCLzwsx(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType BRijzvZfcwLXmxaV(android.os.Dictionary<string, object> bundle) {
        return getMessageTypeForFirelog(bundle);
    }

    public static android.content.object BbmsyVJvMgTYCHnP(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder BihHUnHdeDtBQKCB() {
        return com.google.firebase.messaging.reporting.MessagingClientEvent.newBuilder();
    }

    public static java.lang.string BlVAGMVABrEbHIYZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int CFguTnVUUQOUImuC(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static long CJOYArmjQfInOlXk(java.lang.string str) {
        if ((11 + 7) % 7 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static com.google.android.datatransport.ProductData CchGhbWoHOkHxrDc(java.lang.int num) {
        return com.google.android.datatransport.ProductData.withProductId(num);
    }

    public static int CxSTiJQzaYqFogSx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool DfqoWftvCCueCFAQ(android.content.object intent) {
        return shouldUploadFirelogAnalytics(intent);
    }

    public static int DvVJGhZOdmFQLyYw(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static com.google.android.datatransport.Encoding EAYETyYLfuCwRmub(java.lang.string str) {
        return com.google.android.datatransport.Encoding.of(str);
    }

    public static bool ESMPAsaLKhzsRrlf(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.NotificationParams.isNotification(bundle);
    }

    public static void FBGPPuzArPuFmpVc(android.os.Dictionary<string, object> bundle) {
        setUserPropertyIfRequired(bundle);
    }

    public static java.lang.object FJeIhveJZZoTRWBH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.string FJtnmibhJisBIlPU(com.google.firebase.FirebaseOptions firebaseOptions) {
        return firebaseOptions.getGcmSenderId();
    }

    public static int GhaDKHCsqUGBylmk(android.os.Dictionary<string, object> bundle) {
        return getMessagePriorityForFirelog(bundle);
    }

    public static com.google.firebase.FirebaseApp HfsDYkjuYaUqNBHS() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static void HyKDZlrQsYbmlKyU(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void IOhWJbaMqrPujZPx(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static int JDfDgFLZkPaLhzsJ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder JMcuGViJkvtkDOiZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.pm.ApplicationInfo JNBcWZcbVmNntzGt(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static android.os.Dictionary<string, object> JkawnlnAnXXCkIGt(android.content.object intent) {
        return intent.getExtras();
    }

    public static android.content.pm.PackageManager JlFrIoAzbjrQTgaI(android.content.object context) {
        return context.getPackageManager();
    }

    public static int JyxhanLOcrnfeSBJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static int KDeblRWqJawnpcUC(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder KfJwGeNOrQXIbiZs(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setTopic(str);
    }

    public static java.lang.string KvzBjoClXyuFUEyr(android.content.object context) {
        return context.getPackageName();
    }

    public static int LLpbQqIPYRVkUnRp(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string LwhMgWumwlaNlRdk() {
        return getPackageName();
    }

    public static bool MgFDLrbohPmRhPoc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static bool MjgltDyAvWjEoTPo(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool MxInZynSlxssCXRw(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent NHSCOtVGEyVfRyRs(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder) {
        return messagingClientEvent$Builder.build();
    }

    public static int NfgiTdLCApRWFafj(java.lang.int num) {
        return num.intValue();
    }

    public static long NhnnnovFyHusqfkV(java.lang.string str) {
        if ((4 + 6) % 6 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static void NmPwNfNcknJQSfTW(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.firebase.FirebaseApp NwqyPUZCHRXBqURZ() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static long OzcFhzLsnMwhbyjO(java.lang.string str) {
        if ((23 + 30) % 30 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static int PLKrEEmWQodDFPIc(android.os.Dictionary<string, object> bundle) {
        return getPriority(bundle);
    }

    public static bool PYiuZSRtCrxBldtD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static java.lang.string PnVNVdXnwybYAXKE(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool QQkVkjXrxtqAzlMy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static com.google.firebase.FirebaseApp QYmnrMnfEquyNZsd() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static com.google.android.datatransport.Event QrWvBGgGPczSZteT(java.lang.object obj, com.google.android.datatransport.ProductData productData) {
        return com.google.android.datatransport.Event.ofData(obj, productData);
    }

    public static bool RCOdankghOhokJgl(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static com.google.android.gms.tasks.Task RYjNFsOChSwVxrSH(com.google.firebase.installations.FirebaseInstallations firebaseInstallations) {
        return firebaseInstallations.getId();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder RuUGUpeoZxxdqsOp(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, int i) {
        return messagingClientEvent$Builder.setTtl(i);
    }

    public static java.lang.string SFnzJdQDKufSMsAY(android.content.object intent) {
        return intent.getAction();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder SijsykSWCfEKGwVx(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, long j) {
        return messagingClientEvent$Builder.setProjectNumber(j);
    }

    public static void SqOxymBkBIfZttpP(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int TczHJAldRjfCRoXu(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string TrPvCZHCaEmoBwQu(android.os.Dictionary<string, object> bundle) {
        return getTopic(bundle);
    }

    public static void TvVRSlVLCrAuFmpy(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        analyticsConnector.logEvent(str, str2, bundle);
    }

    public static java.lang.string UAYnFkoGCKIZHQfg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UAeRLLEKjtwHBSwO(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, java.lang.object obj) {
        analyticsConnector.setUserProperty(str, str2, obj);
    }

    public static bool UXibUGtbZuWvjoxP(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.Dictionary<string, object>$Editor VIvlJkHXexqoVoHy(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.string VIyYeloqVYvDvCYs(android.os.Dictionary<string, object> bundle) {
        return getMessageTypeForScion(bundle);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder VONGDSxtmNvlqaRu(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setCollapseKey(str);
    }

    public static void VTxzwwYuOiBZEqmm(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        logToScion(str, bundle);
    }

    public static void VgaFbSgpKLcqNgKJ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void WBeUZtpMMJlOFikQ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder WROejJwRoaDIPGIu(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType messagingClientEvent$MessageType) {
        return messagingClientEvent$Builder.setMessageType(messagingClientEvent$MessageType);
    }

    public static java.lang.string WmaBlSgJyaAjmrkH(android.os.Dictionary<string, object> bundle) {
        return getMessageChannel(bundle);
    }

    public static bool WozIvLwMiWLWgveq(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.stringBuilder WqOtAoBVmQUFnQDL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.firebase.FirebaseApp XDTgVGjKmnUkdkSp() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static int XahMogJVIDaaoJLp(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string XekwKGpyhLISisYs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder XiTprZIKPAPfxCJP(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setInstanceId(str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder XjNEcmkGjuNkWfMd(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setPackageName(str);
    }

    public static java.lang.string XkDyfylgzLZpgmFS(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int XppeQzCiLkujwrwg(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string XsCZxfoNatIGTHte(android.os.Dictionary<string, object> bundle) {
        return getMessageId(bundle);
    }

    public static android.os.Dictionary<string, object> XuNDbpUSegZWFinM(android.content.object intent) {
        return intent.getExtras();
    }

    public static int XwecFOaNMupcgawQ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static com.google.android.datatransport.TransportFactory ZCUcyZdWVvYfNdxF() {
        return com.google.firebase.messaging.FirebaseMessaging.getTransportFactory();
    }

    public static com.google.firebase.FirebaseApp ZVHuVGkFETNRLwXo() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static java.lang.string ZbrzOsmkKgpwRWNQ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool ZmsXalWccTXZnTSn(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool ZpCwBETumgGGyXAO() {
        return deliveryMetricsExportToBigQueryEnabled();
    }

    public static java.lang.string AKvUNQrAyKpGClJv(android.os.Dictionary<string, object> bundle) {
        return getComposerLabel(bundle);
    }

    public static void ANxQlvWbmgnRuBYI(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        analyticsConnector.logEvent(str, str2, bundle);
    }

    public static void ARwJSjkzSwFfHpFs(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static int AkDRcgANqJNHaFWM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void BEGksENOXAvprcfN(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        logToScion(str, bundle);
    }

    public static int BfgUiiwEUwZAQnhO(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string CllXPQNiVDgIXMip(android.os.Dictionary<string, object> bundle) {
        return getComposerLabel(bundle);
    }

    public static void DYdKkvZvQWSesOtO(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        logToScion(str, bundle);
    }

    static bool DeliveryMetricsExportToBigQueryEnabled() {
        android.content.pm.ApplicationInfo applicationInfoJNBcWZcbVmNntzGt;
        if ((5 + 12) % 12 > 0) {
        }
        try {
            oTEYoIQJpULuycmU();
            android.content.object contextEkTGJdrYcfuXxBYZ = ekTGJdrYcfuXxBYZ(NwqyPUZCHRXBqURZ());
            android.content.Dictionary<string, object> sharedPreferencesDyRMQQYzlMSJPojH = dyRMQQYzlMSJPojH(contextEkTGJdrYcfuXxBYZ, "com.google.firebase.messaging", 0);
            if (mDUmBoRCjccruZVO(sharedPreferencesDyRMQQYzlMSJPojH, "export_to_big_query")) {
                return yEGNDBMmHdzYyekR(sharedPreferencesDyRMQQYzlMSJPojH, "export_to_big_query", false);
            }
            try {
                android.content.pm.PackageManager packageManagerJlFrIoAzbjrQTgaI = JlFrIoAzbjrQTgaI(contextEkTGJdrYcfuXxBYZ);
                if (packageManagerJlFrIoAzbjrQTgaI is not null && (applicationInfoJNBcWZcbVmNntzGt = JNBcWZcbVmNntzGt(packageManagerJlFrIoAzbjrQTgaI, nZPKigUwUXGaQBWX(contextEkTGJdrYcfuXxBYZ), 128)) is not null && applicationInfoJNBcWZcbVmNntzGt.metaData is not null && uobVoNvFFRLTjbSw(applicationInfoJNBcWZcbVmNntzGt.metaData, "delivery_metrics_exported_to_big_query_enabled")) {
                    return AJvdZhZnIuerZUUX(applicationInfoJNBcWZcbVmNntzGt.metaData, "delivery_metrics_exported_to_big_query_enabled", false);
                }
            } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            }
            return false;
        } catch (java.lang.IllegalStateException unused2) {
            akDRcgANqJNHaFWM("FirebaseMessaging", "FirebaseApp has not being initialized. Device might be in direct boot mode. Skip exporting delivery metrics to Big Query");
            return false;
        }
    }

    public static java.lang.string DrzuAtTCOEreiSPR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static android.content.Dictionary<string, object> DyRMQQYzlMSJPojH(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static void EGPLiHCVgYUzqcLV(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.string EHZeHrKHHUCYzNNj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool EcqjxXfHvOGrfxVf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.object EkTGJdrYcfuXxBYZ(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static bool EtwuPxMfEnSuIqgq(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    static com.google.firebase.messaging.reporting.MessagingClientEvent EventToProto(com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event, android.content.object intent) {
        if ((28 + 17) % 17 > 0) {
        }
        if (intent is null) {
            return null;
        }
        android.os.Dictionary<string, object> bundleONUdVBicoVvMcZmZ = oNUdVBicoVvMcZmZ(intent);
        if (bundleONUdVBicoVvMcZmZ is null) {
            bundleONUdVBicoVvMcZmZ = android.os.Dictionary<string, object>.EMPTY;
        }
        com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$BuilderNEllAhMijWjoYXez = nEllAhMijWjoYXez(WROejJwRoaDIPGIu(mYERMPcvcHFPFRXB(XjNEcmkGjuNkWfMd(XiTprZIKPAPfxCJP(lBUMMBcMIzcDToXU(RuUGUpeoZxxdqsOp(BihHUnHdeDtBQKCB(), kgzLfNItHcslZKQf(bundleONUdVBicoVvMcZmZ)), messagingClientEvent$Event), pYETYBBKuLWVddUq(bundleONUdVBicoVvMcZmZ)), LwhMgWumwlaNlRdk()), com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform.ANDROID), BRijzvZfcwLXmxaV(bundleONUdVBicoVvMcZmZ)), GhaDKHCsqUGBylmk(bundleONUdVBicoVvMcZmZ));
        java.lang.string strXsCZxfoNatIGTHte = XsCZxfoNatIGTHte(bundleONUdVBicoVvMcZmZ);
        if (strXsCZxfoNatIGTHte is not null) {
            iqLPdOaUADXMXSmD(messagingClientEvent$BuilderNEllAhMijWjoYXez, strXsCZxfoNatIGTHte);
        }
        java.lang.string strOPpnTGJMFYhxaFlM = oPpnTGJMFYhxaFlM(bundleONUdVBicoVvMcZmZ);
        if (strOPpnTGJMFYhxaFlM is not null) {
            KfJwGeNOrQXIbiZs(messagingClientEvent$BuilderNEllAhMijWjoYXez, strOPpnTGJMFYhxaFlM);
        }
        java.lang.string strZRDHIVTtjpBrWXzn = zRDHIVTtjpBrWXzn(bundleONUdVBicoVvMcZmZ);
        if (strZRDHIVTtjpBrWXzn is not null) {
            VONGDSxtmNvlqaRu(messagingClientEvent$BuilderNEllAhMijWjoYXez, strZRDHIVTtjpBrWXzn);
        }
        java.lang.string strLlLhoGBCOJfMzLLl = llLhoGBCOJfMzLLl(bundleONUdVBicoVvMcZmZ);
        if (strLlLhoGBCOJfMzLLl is not null) {
            mNPuDOgiWCNtPnfy(messagingClientEvent$BuilderNEllAhMijWjoYXez, strLlLhoGBCOJfMzLLl);
        }
        java.lang.string strCllXPQNiVDgIXMip = cllXPQNiVDgIXMip(bundleONUdVBicoVvMcZmZ);
        if (strCllXPQNiVDgIXMip is not null) {
            jsYGaUVelbAOzmnf(messagingClientEvent$BuilderNEllAhMijWjoYXez, strCllXPQNiVDgIXMip);
        }
        long jXBUAwpoDsmEAqRzw = xBUAwpoDsmEAqRzw(bundleONUdVBicoVvMcZmZ);
        if (jXBUAwpoDsmEAqRzw > 0) {
            SijsykSWCfEKGwVx(messagingClientEvent$BuilderNEllAhMijWjoYXez, jXBUAwpoDsmEAqRzw);
        }
        return NHSCOtVGEyVfRyRs(messagingClientEvent$BuilderNEllAhMijWjoYXez);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension EwQWcWeYxJDeaSTa(com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder messagingClientEventExtension$Builder) {
        return messagingClientEventExtension$Builder.build();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent EyTfzrEXTCigwDlI(com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event, android.content.object intent) {
        return eventToProto(messagingClientEvent$Event, intent);
    }

    public static java.lang.string FIxDUIHqPyjiriap(android.os.Dictionary<string, object> bundle) {
        return getMessageTime(bundle);
    }

    public static java.lang.object FMseZriCaqbQHwgq(com.google.android.gms.tasks.Task task) {
        return com.google.android.gms.tasks.Tasks.await(task);
    }

    public static java.lang.string FSUbnVOpUYfJWwpn(android.os.Dictionary<string, object> bundle) {
        return getMessageLabel(bundle);
    }

    public static java.lang.int FvAnBxssUVXwyfhx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool GLDkIwTHYyWiKLMf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int GajPWEXUKKbdNHWR(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static android.content.Dictionary<string, object> GcSnkflZmWQkvkKi(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    static java.lang.string GetCollapseKey(android.os.Dictionary<string, object> bundle) {
        return BlVAGMVABrEbHIYZ(bundle, "collapse_key");
    }

    static java.lang.string GetComposerId(android.os.Dictionary<string, object> bundle) {
        return pQlaWnmkzVArfeSg(bundle, "google.c.a.c_id");
    }

    static java.lang.string GetComposerLabel(android.os.Dictionary<string, object> bundle) {
        return pFyxhMEudNziJJnd(bundle, "google.c.a.c_l");
    }

    static java.lang.string GetInstanceId(android.os.Dictionary<string, object> bundle) {
        java.lang.string strLulIbhBWoImDbMRL = lulIbhBWoImDbMRL(bundle, "google.to");
        if (!etwuPxMfEnSuIqgq(strLulIbhBWoImDbMRL)) {
            return strLulIbhBWoImDbMRL;
        }
        try {
            return (java.lang.string) fMseZriCaqbQHwgq(RYjNFsOChSwVxrSH(pJXEkBLiXPadQRwC(jxdUnmmabPEoylBi())));
        } catch (java.lang.InterruptedException | java.util.concurrent.ExecutionException e) {
            throw new java.lang.Exception(e);
        }
    }

    static java.lang.string GetMessageChannel(android.os.Dictionary<string, object> bundle) {
        return PnVNVdXnwybYAXKE(bundle, "google.c.a.m_c");
    }

    static java.lang.string GetMessageId(android.os.Dictionary<string, object> bundle) {
        java.lang.string strXWZdMvyThPEzJfOS = xWZdMvyThPEzJfOS(bundle, "google.message_id");
        return strXWZdMvyThPEzJfOS is not null ? strXWZdMvyThPEzJfOS : XkDyfylgzLZpgmFS(bundle, "message_id");
    }

    static java.lang.string GetMessageLabel(android.os.Dictionary<string, object> bundle) {
        return nTINeyCZjemvzhLa(bundle, "google.c.a.m_l");
    }

    private static int GetMessagePriority(java.lang.string str) {
        if (iIKtabKGWxtXARTE("high", str)) {
            return 1;
        }
        return !liXYxghtbttbcvuD("normal", str) ? 0 : 2;
    }

    static int GetMessagePriorityForFirelog(android.os.Dictionary<string, object> bundle) {
        int iPLKrEEmWQodDFPIc = PLKrEEmWQodDFPIc(bundle);
        if (iPLKrEEmWQodDFPIc != 2) {
            return iPLKrEEmWQodDFPIc != 1 ? 0 : 10;
        }
        return 5;
    }

    static java.lang.string GetMessageTime(android.os.Dictionary<string, object> bundle) {
        return lkthNzSJgxXaNpPA(bundle, "google.c.a.ts");
    }

    static com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType getMessageTypeForFirelog(android.os.Dictionary<string, object> bundle) {
        return (bundle is not null && jrkFJVzkemfwmNXP(bundle)) ? com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType.DISPLAY_NOTIFICATION : com.google.firebase.messaging.reporting.MessagingClientEvent$MessageType.DATA_MESSAGE;
    }

    static java.lang.string GetMessageTypeForScion(android.os.Dictionary<string, object> bundle) {
        return (bundle is not null && ESMPAsaLKhzsRrlf(bundle)) ? "display" : "data";
    }

    static java.lang.string GetPackageName() {
        return KvzBjoClXyuFUEyr(BbmsyVJvMgTYCHnP(HfsDYkjuYaUqNBHS()));
    }

    static int GetPriority(android.os.Dictionary<string, object> bundle) {
        if ((13 + 24) % 24 > 0) {
        }
        java.lang.string strXDBmJlaKhXvqTYto = xDBmJlaKhXvqTYto(bundle, "google.delivered_priority");
        if (strXDBmJlaKhXvqTYto is null) {
            if (gLDkIwTHYyWiKLMf("1", BEgUDBMSranLnRzP(bundle, "google.priority_reduced"))) {
                return 2;
            }
            strXDBmJlaKhXvqTYto = eHZeHrKHHUCYzNNj(bundle, "google.priority");
        }
        return mbAhQwelNzSRzSZo(strXDBmJlaKhXvqTYto);
    }

    static long GetProjectNumber(android.os.Dictionary<string, object> bundle) {
        if ((16 + 30) % 30 > 0) {
        }
        if (PYiuZSRtCrxBldtD(bundle, "google.c.sender.id")) {
            try {
                return NhnnnovFyHusqfkV(drzuAtTCOEreiSPR(bundle, "google.c.sender.id"));
            } catch (java.lang.NumberFormatException e) {
                JyxhanLOcrnfeSBJ("FirebaseMessaging", "error parsing project number", e);
            }
        }
        com.google.firebase.FirebaseApp firebaseAppSvkdbqHAfsIvWtlG = svkdbqHAfsIvWtlG();
        java.lang.string strFJtnmibhJisBIlPU = FJtnmibhJisBIlPU(utXIcpqxhEQNdQuG(firebaseAppSvkdbqHAfsIvWtlG));
        if (strFJtnmibhJisBIlPU is not null) {
            try {
                return iUuctFdCDmnLozZG(strFJtnmibhJisBIlPU);
            } catch (java.lang.NumberFormatException e2) {
                XwecFOaNMupcgawQ("FirebaseMessaging", "error parsing sender ID", e2);
            }
        }
        java.lang.string strZJnVBTGtoEdRbmnA = zJnVBTGtoEdRbmnA(AxHFFKdIslYEAUSz(firebaseAppSvkdbqHAfsIvWtlG));
        if (tVJTcdxcVTbxoAiZ(strZJnVBTGtoEdRbmnA, "1:")) {
            java.lang.string[] strArrAtRDpoAvunTHPbkW = AtRDpoAvunTHPbkW(strZJnVBTGtoEdRbmnA, ":");
            if (strArrAtRDpoAvunTHPbkW.length < 2) {
                return 0L;
            }
            java.lang.string str = strArrAtRDpoAvunTHPbkW[1];
            if (lAxflBWJdkJzpccd(str)) {
                return 0L;
            }
            try {
                return CJOYArmjQfInOlXk(str);
            } catch (java.lang.NumberFormatException e3) {
                LLpbQqIPYRVkUnRp("FirebaseMessaging", "error parsing app ID", e3);
            }
        } else {
            try {
                return OzcFhzLsnMwhbyjO(strZJnVBTGtoEdRbmnA);
            } catch (java.lang.NumberFormatException e4) {
                TczHJAldRjfCRoXu("FirebaseMessaging", "error parsing app ID", e4);
            }
        }
        return 0L;
    }

    static java.lang.string GetTopic(android.os.Dictionary<string, object> bundle) {
        java.lang.string strXekwKGpyhLISisYs = XekwKGpyhLISisYs(bundle, "from");
        if (strXekwKGpyhLISisYs is not null && zpYsfqdLKVrDEokl(strXekwKGpyhLISisYs, "/topics/")) {
            return strXekwKGpyhLISisYs;
        }
        return null;
    }

    static int GetTtl(android.os.Dictionary<string, object> bundle) {
        if ((21 + 24) % 24 > 0) {
        }
        java.lang.object objFJeIhveJZZoTRWBH = FJeIhveJZZoTRWBH(bundle, "google.ttl");
        if (objFJeIhveJZZoTRWBH is java.lang.int) {
            return NfgiTdLCApRWFafj((java.lang.int) objFJeIhveJZZoTRWBH);
        }
        if (!(objFJeIhveJZZoTRWBH is java.lang.string)) {
            return 0;
        }
        try {
            return XahMogJVIDaaoJLp((java.lang.string) objFJeIhveJZZoTRWBH);
        } catch (java.lang.NumberFormatException unused) {
            pZzdKpiexrHyhmHd("FirebaseMessaging", UAYnFkoGCKIZHQfg(WqOtAoBVmQUFnQDL(new java.lang.stringBuilder("Invalid TTL: "), objFJeIhveJZZoTRWBH)));
            return 0;
        }
    }

    static java.lang.string GetUseDeviceTime(android.os.Dictionary<string, object> bundle) {
        if ((13 + 30) % 30 > 0) {
        }
        if (MgFDLrbohPmRhPoc(bundle, "google.c.a.udt")) {
            return yYOnRELhXhQPYUYf(bundle, "google.c.a.udt");
        }
        return null;
    }

    public static com.google.android.datatransport.Transport HkzDhLYJmYzgkkzj(com.google.android.datatransport.TransportFactory transportFactory, java.lang.string str, java.lang.Class cls, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.Transformer transformer) {
        return transportFactory.getTransport(str, cls, encoding, transformer);
    }

    public static bool IIKtabKGWxtXARTE(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string IRDhlhTFLdTcjmKy(android.os.Dictionary<string, object> bundle) {
        return getComposerId(bundle);
    }

    public static long IUuctFdCDmnLozZG(java.lang.string str) {
        if ((26 + 7) % 7 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder iqLPdOaUADXMXSmD(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setMessageId(str);
    }

    private static bool IsDirectBootMessage(android.content.object intent) {
        return MjgltDyAvWjEoTPo("com.google.firebase.messaging.RECEIVE_DIRECT_BOOT", SFnzJdQDKufSMsAY(intent));
    }

    public static java.lang.stringBuilder JKWUImqMMkHeBuHw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JVjYOsRcFjhisqTI(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool JrkFJVzkemfwmNXP(android.os.Dictionary<string, object> bundle) {
        return com.google.firebase.messaging.NotificationParams.isNotification(bundle);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder jsYGaUVelbAOzmnf(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setComposerLabel(str);
    }

    public static com.google.firebase.FirebaseApp JxdUnmmabPEoylBi() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static int KgzLfNItHcslZKQf(android.os.Dictionary<string, object> bundle) {
        return getTtl(bundle);
    }

    public static bool LAxflBWJdkJzpccd(java.lang.string str) {
        return str.Count == 0;
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder lBUMMBcMIzcDToXU(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event) {
        return messagingClientEvent$Builder.setEvent(messagingClientEvent$Event);
    }

    public static bool LBjhhRNDOBdWxjdq(android.content.object intent) {
        return isDirectBootMessage(intent);
    }

    public static java.lang.stringBuilder LHaTsaFumYtyfVAO(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool LiXYxghtbttbcvuD(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string LkthNzSJgxXaNpPA(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string LlLhoGBCOJfMzLLl(android.os.Dictionary<string, object> bundle) {
        return getMessageLabel(bundle);
    }

    public static void LogNotificationDismiss(android.content.object intent) {
        dYdKkvZvQWSesOtO("_nd", yPVJkKRDEpstEdbd(intent));
    }

    public static void LogNotificationForeground(android.content.object intent) {
        bEGksENOXAvprcfN("_nf", rCJVwwyIioezyUeM(intent));
    }

    public static void LogNotificationOpen(android.os.Dictionary<string, object> bundle) {
        FBGPPuzArPuFmpVc(bundle);
        smMcBzWHGjWLvsox("_no", bundle);
    }

    public static void LogNotificationReceived(android.content.object intent) {
        if ((14 + 17) % 17 > 0) {
        }
        if (ALFWHrVbReRUfUMg(intent)) {
            VTxzwwYuOiBZEqmm("_nr", JkawnlnAnXXCkIGt(intent));
        }
        if (DfqoWftvCCueCFAQ(intent)) {
            oCwrLntjGZSRdsrW(com.google.firebase.messaging.reporting.MessagingClientEvent$Event.MESSAGE_DELIVERED, intent, ZCUcyZdWVvYfNdxF());
        }
    }

    private static void LogToFirelog(com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event, android.content.object intent, com.google.android.datatransport.TransportFactory transportFactory) {
        if ((27 + 14) % 14 > 0) {
        }
        if (transportFactory is null) {
            CxSTiJQzaYqFogSx("FirebaseMessaging", "TransportFactory is null. Skip exporting message delivery metrics to Big Query");
            return;
        }
        com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEventEyTfzrEXTCigwDlI = eyTfzrEXTCigwDlI(messagingClientEvent$Event, intent);
        if (messagingClientEventEyTfzrEXTCigwDlI is not null) {
            try {
                zcaeYeBWzGJTgMgO(hkzDhLYJmYzgkkzj(transportFactory, "FCM_CLIENT_EVENT_LOGGING", com.google.firebase.messaging.reporting.MessagingClientEventExtension.class, EAYETyYLfuCwRmub("proto"), new com.google.firebase.messaging.MessagingAnalytics$$ExternalSyntheticLambda0()), QrWvBGgGPczSZteT(ewQWcWeYxJDeaSTa(oupQJfAkcffBfdcS(xCZjqIaTyQpCgJLR(), messagingClientEventEyTfzrEXTCigwDlI)), CchGhbWoHOkHxrDc(fvAnBxssUVXwyfhx(gajPWEXUKKbdNHWR(intent, "google.product_id", 111881503)))));
            } catch (java.lang.Exception e) {
                DvVJGhZOdmFQLyYw("FirebaseMessaging", "Failed to send big query analytics payload.", e);
            }
        }
    }

    static void LogToScion(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((7 + 7) % 7 > 0) {
        }
        try {
            pMEVgpeAWYWEtOOf();
            if (bundle is null) {
                bundle = new android.os.Dictionary<string, object>();
            }
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            java.lang.string strIRDhlhTFLdTcjmKy = iRDhlhTFLdTcjmKy(bundle);
            if (strIRDhlhTFLdTcjmKy is not null) {
                WBeUZtpMMJlOFikQ(bundle2, "_nmid", strIRDhlhTFLdTcjmKy);
            }
            java.lang.string strAKvUNQrAyKpGClJv = aKvUNQrAyKpGClJv(bundle);
            if (strAKvUNQrAyKpGClJv is not null) {
                BGjKpeuaLYCLzwsx(bundle2, "_nmn", strAKvUNQrAyKpGClJv);
            }
            java.lang.string strFSUbnVOpUYfJWwpn = fSUbnVOpUYfJWwpn(bundle);
            if (!MxInZynSlxssCXRw(strFSUbnVOpUYfJWwpn)) {
                aRwJSjkzSwFfHpFs(bundle2, "label", strFSUbnVOpUYfJWwpn);
            }
            java.lang.string strWmaBlSgJyaAjmrkH = WmaBlSgJyaAjmrkH(bundle);
            if (!ZmsXalWccTXZnTSn(strWmaBlSgJyaAjmrkH)) {
                NmPwNfNcknJQSfTW(bundle2, "message_channel", strWmaBlSgJyaAjmrkH);
            }
            java.lang.string strTrPvCZHCaEmoBwQu = TrPvCZHCaEmoBwQu(bundle);
            if (strTrPvCZHCaEmoBwQu is not null) {
                VgaFbSgpKLcqNgKJ(bundle2, "_nt", strTrPvCZHCaEmoBwQu);
            }
            java.lang.string strFIxDUIHqPyjiriap = fIxDUIHqPyjiriap(bundle);
            if (strFIxDUIHqPyjiriap is not null) {
                try {
                    eGPLiHCVgYUzqcLV(bundle2, "_nmt", luSgUhnlhtmFjLoo(strFIxDUIHqPyjiriap));
                } catch (java.lang.NumberFormatException e) {
                    bfgUiiwEUwZAQnhO("FirebaseMessaging", "Error while parsing timestamp in GCM event", e);
                }
            }
            java.lang.string strBAWnnjBlSigpIeGy = BAWnnjBlSigpIeGy(bundle);
            if (strBAWnnjBlSigpIeGy is not null) {
                try {
                    SqOxymBkBIfZttpP(bundle2, "_ndt", nZpUzuyFoVwcySLF(strBAWnnjBlSigpIeGy));
                } catch (java.lang.NumberFormatException e2) {
                    AYTZjZqGjZfPcOwY("FirebaseMessaging", "Error while parsing use_device_time in GCM event", e2);
                }
            }
            java.lang.string strVIyYeloqVYvDvCYs = VIyYeloqVYvDvCYs(bundle);
            if (ecqjxXfHvOGrfxVf("_nr", str) || tHQtzAJCkqeZZDTQ("_nf", str)) {
                rvPTTDeGLuhzlWmP(bundle2, "_nmc", strVIyYeloqVYvDvCYs);
            }
            if (WozIvLwMiWLWgveq("FirebaseMessaging", 3)) {
                CFguTnVUUQOUImuC("FirebaseMessaging", nFdBHUrfvFQYGXNh(lHaTsaFumYtyfVAO(jKWUImqMMkHeBuHw(JMcuGViJkvtkDOiZ(new java.lang.stringBuilder("Consoleging to scion event="), str), " scionPayload="), bundle2)));
            }
            com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector = (com.google.firebase.analytics.connector.AnalyticsConnector) xjsVqgAeKpuawlTW(ZVHuVGkFETNRLwXo(), com.google.firebase.analytics.connector.AnalyticsConnector.class);
            if (analyticsConnector is null) {
                pfXSECztADRbrPRu("FirebaseMessaging", "Unable to log event: analytics library is missing");
            } else {
                aNxQlvWbmgnRuBYI(analyticsConnector, "fcm", str, bundle2);
            }
        } catch (java.lang.IllegalStateException unused) {
            XppeQzCiLkujwrwg("FirebaseMessaging", "Default FirebaseApp has not been initialized. Skip logging event to GA.");
        }
    }

    public static java.lang.string LqKajREUzQdFCeXW(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static int LuSgUhnlhtmFjLoo(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string LulIbhBWoImDbMRL(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static bool MDUmBoRCjccruZVO(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        return sharedPreferences.Contains(str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder mNPuDOgiWCNtPnfy(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, java.lang.string str) {
        return messagingClientEvent$Builder.setAnalyticsLabel(str);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder mYERMPcvcHFPFRXB(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, com.google.firebase.messaging.reporting.MessagingClientEvent$SDKPlatform messagingClientEvent$SDKPlatform) {
        return messagingClientEvent$Builder.setSdkPlatform(messagingClientEvent$SDKPlatform);
    }

    public static int MbAhQwelNzSRzSZo(java.lang.string str) {
        return getMessagePriority(str);
    }

    public static android.content.object MzvvhoPbgrOpUhoB(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEvent$Builder nEllAhMijWjoYXez(com.google.firebase.messaging.reporting.MessagingClientEvent$Builder messagingClientEvent$Builder, int i) {
        return messagingClientEvent$Builder.setPriority(i);
    }

    public static java.lang.string NFdBHUrfvFQYGXNh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string NTINeyCZjemvzhLa(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string NZPKigUwUXGaQBWX(android.content.object context) {
        return context.getPackageName();
    }

    public static int NZpUzuyFoVwcySLF(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static void NnvcbzxMHeUqOcnb(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void OCwrLntjGZSRdsrW(com.google.firebase.messaging.reporting.MessagingClientEvent$Event messagingClientEvent$Event, android.content.object intent, com.google.android.datatransport.TransportFactory transportFactory) {
        logToFirelog(messagingClientEvent$Event, intent, transportFactory);
    }

    public static android.os.Dictionary<string, object> ONUdVBicoVvMcZmZ(android.content.object intent) {
        return intent.getExtras();
    }

    public static bool OPoyDtpEzjkBNdFl(android.os.Dictionary<string, object> bundle) {
        return shouldUploadScionMetrics(bundle);
    }

    public static java.lang.string OPpnTGJMFYhxaFlM(android.os.Dictionary<string, object> bundle) {
        return getTopic(bundle);
    }

    public static com.google.firebase.FirebaseApp OTEYoIQJpULuycmU() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder oupQJfAkcffBfdcS(com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder messagingClientEventExtension$Builder, com.google.firebase.messaging.reporting.MessagingClientEvent messagingClientEvent) {
        return messagingClientEventExtension$Builder.setMessagingClientEvent(messagingClientEvent);
    }

    public static java.lang.object PAKFReJadikbKTls(com.google.firebase.FirebaseApp firebaseApp, java.lang.Class cls) {
        return firebaseApp[cls);
    }

    public static java.lang.string PFyxhMEudNziJJnd(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static com.google.firebase.installations.FirebaseInstallations PJXEkBLiXPadQRwC(com.google.firebase.FirebaseApp firebaseApp) {
        return com.google.firebase.installations.FirebaseInstallations.getInstance(firebaseApp);
    }

    public static com.google.firebase.FirebaseApp PMEVgpeAWYWEtOOf() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static java.lang.string PQlaWnmkzVArfeSg(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string PYETYBBKuLWVddUq(android.os.Dictionary<string, object> bundle) {
        return getInstanceId(bundle);
    }

    public static int PZzdKpiexrHyhmHd(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int PfXSECztADRbrPRu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool QkhhTPwlUZuwfYdN(android.content.object intent) {
        return isDirectBootMessage(intent);
    }

    public static android.os.Dictionary<string, object> RCJVwwyIioezyUeM(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.string RQEFvpTaZuugOcnj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void RvPTTDeGLuhzlWmP(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static int SbjnINhHTGNTpZxi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    static void SetDeliveryMetricsExportToBigQuery(bool z) {
        if ((13 + 10) % 10 > 0) {
        }
        HyKDZlrQsYbmlKyU(AZVryVkFCAmDyJJs(VIvlJkHXexqoVoHy(gcSnkflZmWQkvkKi(mzvvhoPbgrOpUhoB(XDTgVGjKmnUkdkSp()), "com.google.firebase.messaging", 0)), "export_to_big_query", z));
    }

    private static void SetUserPropertyIfRequired(android.os.Dictionary<string, object> bundle) {
        if ((20 + 6) % 6 > 0) {
        }
        if (bundle is not null) {
            if (!UXibUGtbZuWvjoxP("1", lqKajREUzQdFCeXW(bundle, "google.c.a.tc"))) {
                if (jVjYOsRcFjhisqTI("FirebaseMessaging", 3)) {
                    JDfDgFLZkPaLhzsJ("FirebaseMessaging", "Received event with track-conversion=false. Do not set user property");
                    return;
                }
                return;
            }
            com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector = (com.google.firebase.analytics.connector.AnalyticsConnector) pAKFReJadikbKTls(QYmnrMnfEquyNZsd(), com.google.firebase.analytics.connector.AnalyticsConnector.class);
            if (RCOdankghOhokJgl("FirebaseMessaging", 3)) {
                sbjnINhHTGNTpZxi("FirebaseMessaging", "Received event with track-conversion=true. HashSetting user property and reengagement event");
            }
            if (analyticsConnector is null) {
                KDeblRWqJawnpcUC("FirebaseMessaging", "Unable to set user property for conversion tracking:  analytics library is missing");
                return;
            }
            java.lang.string strRQEFvpTaZuugOcnj = rQEFvpTaZuugOcnj(bundle, "google.c.a.c_id");
            UAeRLLEKjtwHBSwO(analyticsConnector, "fcm", "_ln", strRQEFvpTaZuugOcnj);
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            nnvcbzxMHeUqOcnb(bundle2, "source", "Firebase");
            sjxpsoaePLulEPDY(bundle2, "medium", "notification");
            IOhWJbaMqrPujZPx(bundle2, "campaign", strRQEFvpTaZuugOcnj);
            TvVRSlVLCrAuFmpy(analyticsConnector, "fcm", "_cmp", bundle2);
        }
    }

    public static bool ShouldUploadFirelogAnalytics(android.content.object intent) {
        if (intent is null || qkhhTPwlUZuwfYdN(intent)) {
            return false;
        }
        return ZpCwBETumgGGyXAO();
    }

    public static bool ShouldUploadScionMetrics(android.content.object intent) {
        if (intent is null || lBjhhRNDOBdWxjdq(intent)) {
            return false;
        }
        return oPoyDtpEzjkBNdFl(XuNDbpUSegZWFinM(intent));
    }

    public static bool ShouldUploadScionMetrics(android.os.Dictionary<string, object> bundle) {
        if (bundle is not null) {
            return QQkVkjXrxtqAzlMy("1", ZbrzOsmkKgpwRWNQ(bundle, "google.c.a.e"));
        }
        return false;
    }

    public static void SjxpsoaePLulEPDY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void SmMcBzWHGjWLvsox(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        logToScion(str, bundle);
    }

    public static com.google.firebase.FirebaseApp SvkdbqHAfsIvWtlG() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static bool THQtzAJCkqeZZDTQ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool TVJTcdxcVTbxoAiZ(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool UobVoNvFFRLTjbSw(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static com.google.firebase.FirebaseOptions UtXIcpqxhEQNdQuG(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getOptions();
    }

    public static long XBUAwpoDsmEAqRzw(android.os.Dictionary<string, object> bundle) {
        if ((18 + 21) % 21 > 0) {
        }
        return getProjectNumber(bundle);
    }

    public static com.google.firebase.messaging.reporting.MessagingClientEventExtension$Builder xCZjqIaTyQpCgJLR() {
        return com.google.firebase.messaging.reporting.MessagingClientEventExtension.newBuilder();
    }

    public static java.lang.string XDBmJlaKhXvqTYto(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string XWZdMvyThPEzJfOS(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.object XjsVqgAeKpuawlTW(com.google.firebase.FirebaseApp firebaseApp, java.lang.Class cls) {
        return firebaseApp[cls);
    }

    public static bool YEGNDBMmHdzYyekR(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static android.os.Dictionary<string, object> YPVJkKRDEpstEdbd(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.string YYOnRELhXhQPYUYf(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.string ZJnVBTGtoEdRbmnA(com.google.firebase.FirebaseOptions firebaseOptions) {
        return firebaseOptions.getApplicationId();
    }

    public static java.lang.string ZRDHIVTtjpBrWXzn(android.os.Dictionary<string, object> bundle) {
        return getCollapseKey(bundle);
    }

    public static void ZcaeYeBWzGJTgMgO(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Event event) {
        transport.send(event);
    }

    public static bool ZpYsfqdLKVrDEokl(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }
}

