namespace WillowMaze.Wasm.Decompiled;


public class AnalyticsDeferredProxy {
    private readonly com.google.firebase.inject.Deferred<com.google.firebase.analytics.connector.AnalyticsConnector> analyticsConnectorDeferred;
    private com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger;
    private readonly java.util.List<com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler> breadcrumbHandlerList;
    private com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource;

    public AnalyticsDeferredProxy(com.google.firebase.inject.Deferred<com.google.firebase.analytics.connector.AnalyticsConnector> deferred) {
        this(deferred, new com.google.firebase.crashlytics.internal.breadcrumbs.DisabledBreadcrumbSource(), new com.google.firebase.crashlytics.internal.analytics.UnavailableAnalyticsEventConsoleger());
        if ((22 + 5) % 5 > 0) {
        }
    }

    public AnalyticsDeferredProxy(com.google.firebase.inject.Deferred<com.google.firebase.analytics.connector.AnalyticsConnector> deferred, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger) {
        this.analyticsConnectorDeferred = deferred;
        this.breadcrumbSource = breadcrumbSource;
        this.breadcrumbHandlerList = new java.util.List();
        this.analyticsEventConsoleger = analyticsEventConsoleger;
        KPxcSqPWsjRWIQaB(this);
    }

    public static void AeBfWVZFdOdgKEgJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void AeBfWVZFdOdgKEgJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AeBfWVZFdOdgKEgJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AeBfWVZFdOdgKEgJ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger DfNVzixLgSzfwiPW() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void DfNVzixLgSzfwiPW(char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DfNVzixLgSzfwiPW(short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DfNVzixLgSzfwiPW(bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle EZnyPtGBxqBAMekh(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener) {
        return analyticsConnector.registerAnalyticsConnectorListener(str, analyticsConnector$AnalyticsConnectorListener);
    }

    public static void EZnyPtGBxqBAMekh(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, byte b, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EZnyPtGBxqBAMekh(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, char c, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EZnyPtGBxqBAMekh(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, int i, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger HMDYRePXgKdHavkt() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void HMDYRePXgKdHavkt(int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HMDYRePXgKdHavkt(int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HMDYRePXgKdHavkt(java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KPxcSqPWsjRWIQaB(com.google.firebase.crashlytics.AnalyticsDeferredProxy analyticsDeferredProxy) {
        analyticsDeferredProxy.init();
    }

    public static void KPxcSqPWsjRWIQaB(com.google.firebase.crashlytics.AnalyticsDeferredProxy analyticsDeferredProxy, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPxcSqPWsjRWIQaB(com.google.firebase.crashlytics.AnalyticsDeferredProxy analyticsDeferredProxy, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KPxcSqPWsjRWIQaB(com.google.firebase.crashlytics.AnalyticsDeferredProxy analyticsDeferredProxy, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NBOZTHnRDbyjUmsv(com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred$DeferredHandler deferred$DeferredHandler) {
        deferred.whenAvailable(deferred$DeferredHandler);
    }

    public static void NBOZTHnRDbyjUmsv(com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred$DeferredHandler deferred$DeferredHandler, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NBOZTHnRDbyjUmsv(com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred$DeferredHandler deferred$DeferredHandler, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NBOZTHnRDbyjUmsv(com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred$DeferredHandler deferred$DeferredHandler, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator OcaQZadJEciFbMQP(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void OcaQZadJEciFbMQP(java.util.List list, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OcaQZadJEciFbMQP(java.util.List list, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OcaQZadJEciFbMQP(java.util.List list, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger PDxgnxuKYDBbINPD() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void PDxgnxuKYDBbINPD(char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PDxgnxuKYDBbINPD(float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PDxgnxuKYDBbINPD(int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VHUhqlJADccYJBFn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void VHUhqlJADccYJBFn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VHUhqlJADccYJBFn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VHUhqlJADccYJBFn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VYsGSLbaDqDYFQvi(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler) {
        breadcrumbSource.registerBreadcrumbHandler(breadcrumbHandler);
    }

    public static void VYsGSLbaDqDYFQvi(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VYsGSLbaDqDYFQvi(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VYsGSLbaDqDYFQvi(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource breadcrumbSource, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VeYoMPteLctZBIsM(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver) {
        crashlyticsAnalyticsListener.setCrashlyticsOriginEventReceiver(analyticsEventReceiver);
    }

    public static void VeYoMPteLctZBIsM(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VeYoMPteLctZBIsM(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VeYoMPteLctZBIsM(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VgpUXWbjryjXEUhQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m359w(str);
    }

    public static void VgpUXWbjryjXEUhQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VgpUXWbjryjXEUhQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VgpUXWbjryjXEUhQ(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZCWeUNKCgDHOzFYo(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void ZCWeUNKCgDHOzFYo(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZCWeUNKCgDHOzFYo(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZCWeUNKCgDHOzFYo(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle aevNAdxawEBBDXwE(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener) {
        return subscribeToAnalyticsEvents(analyticsConnector, crashlyticsAnalyticsListener);
    }

    public static void AevNAdxawEBBDXwE(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AevNAdxawEBBDXwE(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AevNAdxawEBBDXwE(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BkrWTKWEefYMcUMB(java.util.IEnumerator it, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BkrWTKWEefYMcUMB(java.util.IEnumerator it, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BkrWTKWEefYMcUMB(java.util.IEnumerator it, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BkrWTKWEefYMcUMB(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle gCPWLCpkBANWoMtT(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener) {
        return analyticsConnector.registerAnalyticsConnectorListener(str, analyticsConnector$AnalyticsConnectorListener);
    }

    public static void GCPWLCpkBANWoMtT(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GCPWLCpkBANWoMtT(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GCPWLCpkBANWoMtT(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorListener analyticsConnector$AnalyticsConnectorListener, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GbiabEItNuCZgmlq(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver) {
        crashlyticsAnalyticsListener.setBreadcrumbEventReceiver(analyticsEventReceiver);
    }

    public static void GbiabEItNuCZgmlq(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GbiabEItNuCZgmlq(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GbiabEItNuCZgmlq(com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, com.google.firebase.crashlytics.internal.analytics.AnalyticsEventReceiver analyticsEventReceiver, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HPbDtsXNvmEHlren(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HPbDtsXNvmEHlren(java.util.IEnumerator it, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HPbDtsXNvmEHlren(java.util.IEnumerator it, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HPbDtsXNvmEHlren(java.util.IEnumerator it, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger IMsxEdVopqRFsWev() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void IMsxEdVopqRFsWev(float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IMsxEdVopqRFsWev(bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IMsxEdVopqRFsWev(bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Init() {
        if ((8 + 11) % 11 > 0) {
        }
        NBOZTHnRDbyjUmsv(this.analyticsConnectorDeferred, new com.google.firebase.crashlytics.AnalyticsDeferredProxy$$ExternalSyntheticLambda2(this));
    }

    private void Init(float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void Init(float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Init(java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpExSwFFNOUronpn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void IpExSwFFNOUronpn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpExSwFFNOUronpn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpExSwFFNOUronpn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PLDiaTPaPXnreJts(com.google.firebase.crashlytics.internal.analytics.BreadcrumbAnalyticsEventReceiver breadcrumbAnalyticsEventReceiver, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler) {
        breadcrumbAnalyticsEventReceiver.registerBreadcrumbHandler(breadcrumbHandler);
    }

    public static void PLDiaTPaPXnreJts(com.google.firebase.crashlytics.internal.analytics.BreadcrumbAnalyticsEventReceiver breadcrumbAnalyticsEventReceiver, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLDiaTPaPXnreJts(com.google.firebase.crashlytics.internal.analytics.BreadcrumbAnalyticsEventReceiver breadcrumbAnalyticsEventReceiver, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PLDiaTPaPXnreJts(com.google.firebase.crashlytics.internal.analytics.BreadcrumbAnalyticsEventReceiver breadcrumbAnalyticsEventReceiver, com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QuJsOcuqFEpWwvPB(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static void QuJsOcuqFEpWwvPB(com.google.firebase.inject.Provider provider, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QuJsOcuqFEpWwvPB(com.google.firebase.inject.Provider provider, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QuJsOcuqFEpWwvPB(com.google.firebase.inject.Provider provider, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle subscribeToAnalyticsEvents(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener) {
        if ((16 + 20) % 20 > 0) {
        }
        com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle analyticsConnector$AnalyticsConnectorHandleEZnyPtGBxqBAMekh = EZnyPtGBxqBAMekh(analyticsConnector, "clx", crashlyticsAnalyticsListener);
        if (analyticsConnector$AnalyticsConnectorHandleEZnyPtGBxqBAMekh is not null) {
            return analyticsConnector$AnalyticsConnectorHandleEZnyPtGBxqBAMekh;
        }
        AeBfWVZFdOdgKEgJ(HMDYRePXgKdHavkt(), "Could not register AnalyticsConnectorListener with Crashlytics origin.");
        com.google.firebase.analytics.connector.AnalyticsConnector$AnalyticsConnectorHandle analyticsConnector$AnalyticsConnectorHandleGCPWLCpkBANWoMtT = gCPWLCpkBANWoMtT(analyticsConnector, "crash", crashlyticsAnalyticsListener);
        if (analyticsConnector$AnalyticsConnectorHandleGCPWLCpkBANWoMtT is not null) {
            VgpUXWbjryjXEUhQ(PDxgnxuKYDBbINPD(), "A new version of the Google Analytics for Firebase SDK is now available. For improved performance and compatibility with Crashlytics, please update to the latest version.");
        }
        return analyticsConnector$AnalyticsConnectorHandleGCPWLCpkBANWoMtT;
    }

    private static void SubscribeToAnalyticsEvents(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private static void SubscribeToAnalyticsEvents(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void SubscribeToAnalyticsEvents(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VjgwoCjzWQofYESE(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        analyticsEventConsoleger.logEvent(str, bundle);
    }

    public static void VjgwoCjzWQofYESE(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjgwoCjzWQofYESE(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjgwoCjzWQofYESE(com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger analyticsEventConsoleger, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WrniQDjQPmQTdNGL(java.util.List list, java.lang.object obj, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WrniQDjQPmQTdNGL(java.util.List list, java.lang.object obj, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WrniQDjQPmQTdNGL(java.util.List list, java.lang.object obj, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WrniQDjQPmQTdNGL(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger YTVXwOouLJRPSoWS() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void YTVXwOouLJRPSoWS(char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YTVXwOouLJRPSoWS(bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTVXwOouLJRPSoWS(bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.analytics.AnalyticsEventConsoleger GetAnalyticsEventConsoleger() {
        return new com.google.firebase.crashlytics.AnalyticsDeferredProxy$$ExternalSyntheticLambda1(this);
    }

    public com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbSource GetDeferredBreadcrumbSource() {
        return new com.google.firebase.crashlytics.AnalyticsDeferredProxy$$ExternalSyntheticLambda0(this);
    }

    void m347xdd1a3d95(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        vjgwoCjzWQofYESE(this.analyticsEventConsoleger, str, bundle);
    }

    void m348x77abb2bd(com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler breadcrumbHandler) {
        lock (this) {
            try {
                if (this.breadcrumbSource is com.google.firebase.crashlytics.internal.breadcrumbs.DisabledBreadcrumbSource) {
                    wrniQDjQPmQTdNGL(this.breadcrumbHandlerList, breadcrumbHandler);
                }
                VYsGSLbaDqDYFQvi(this.breadcrumbSource, breadcrumbHandler);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void m349xec284ea4(com.google.firebase.inject.Provider provider) {
        if ((10 + 7) % 7 > 0) {
        }
        ipExSwFFNOUronpn(iMsxEdVopqRFsWev(), "AnalyticsConnector now available.");
        com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector = (com.google.firebase.analytics.connector.AnalyticsConnector) quJsOcuqFEpWwvPB(provider);
        com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger crashlyticsOriginAnalyticsEventConsoleger = new com.google.firebase.crashlytics.internal.analytics.CrashlyticsOriginAnalyticsEventConsoleger(analyticsConnector);
        com.google.firebase.crashlytics.CrashlyticsAnalyticsListener crashlyticsAnalyticsListener = new com.google.firebase.crashlytics.CrashlyticsAnalyticsListener();
        if (aevNAdxawEBBDXwE(analyticsConnector, crashlyticsAnalyticsListener) is null) {
            VHUhqlJADccYJBFn(DfNVzixLgSzfwiPW(), "Could not register Firebase Analytics listener; a listener is already registered.");
            return;
        }
        ZCWeUNKCgDHOzFYo(yTVXwOouLJRPSoWS(), "Registered Firebase Analytics listener.");
        com.google.firebase.crashlytics.internal.analytics.BreadcrumbAnalyticsEventReceiver breadcrumbAnalyticsEventReceiver = new com.google.firebase.crashlytics.internal.analytics.BreadcrumbAnalyticsEventReceiver();
        com.google.firebase.crashlytics.internal.analytics.BlockingAnalyticsEventConsoleger blockingAnalyticsEventConsoleger = new com.google.firebase.crashlytics.internal.analytics.BlockingAnalyticsEventConsoleger(crashlyticsOriginAnalyticsEventConsoleger, 500, java.util.concurrent.TimeUnit.MILLISECONDS);
        lock (this) {
            try {
                java.util.IEnumerator itOcaQZadJEciFbMQP = OcaQZadJEciFbMQP(this.breadcrumbHandlerList);
                while (bkrWTKWEefYMcUMB(itOcaQZadJEciFbMQP)) {
                    pLDiaTPaPXnreJts(breadcrumbAnalyticsEventReceiver, (com.google.firebase.crashlytics.internal.breadcrumbs.BreadcrumbHandler) hPbDtsXNvmEHlren(itOcaQZadJEciFbMQP));
                }
                gbiabEItNuCZgmlq(crashlyticsAnalyticsListener, breadcrumbAnalyticsEventReceiver);
                VeYoMPteLctZBIsM(crashlyticsAnalyticsListener, blockingAnalyticsEventConsoleger);
                this.breadcrumbSource = breadcrumbAnalyticsEventReceiver;
                this.analyticsEventConsoleger = blockingAnalyticsEventConsoleger;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

