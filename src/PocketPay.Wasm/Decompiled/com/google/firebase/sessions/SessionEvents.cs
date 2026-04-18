namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JH\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0014\b\u0002\u0010\u000f\u001a\u000e\u0012\u0004\u0012\u00020\u0011\u0012\u0004\u0012\u00020\u00120\u00102\b\b\u0002\u0010\u0013\u001a\u00020\u00142\b\b\u0002\u0010\u0015\u001a\u00020\u0014J\u000e\u0010\u0016\u001a\u00020\u00172\u0006\u0010\t\u001a\u00020\nJ\u0012\u0010\u0018\u001a\u00020\u00192\b\u0010\u001a\u001a\u0004\u0018\u00010\u0012H\u0002R\u0014\u0010\u0003\u001a\u00020\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u001b"}, d2 = {"Lcom/google/firebase/sessions/SessionEvents;", "", "()V", "SESSION_EVENT_ENCODER", "Lcom/google/firebase/encoders/DataEncoder;", "getSESSION_EVENT_ENCODER$com_google_firebase_firebase_sessions", "()Lcom/google/firebase/encoders/DataEncoder;", "buildSession", "Lcom/google/firebase/sessions/SessionEvent;", "firebaseApp", "Lcom/google/firebase/FirebaseApp;", "sessionDetails", "Lcom/google/firebase/sessions/SessionDetails;", "sessionsHashSettings", "Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "subscribers", "", "Lcom/google/firebase/sessions/api/SessionSubscriber$Name;", "Lcom/google/firebase/sessions/api/SessionSubscriber;", "firebaseInstallationId", "", "firebaseAuthenticationToken", "getApplicationInfo", "Lcom/google/firebase/sessions/ApplicationInfo;", "toDataICollectionState", "Lcom/google/firebase/sessions/DataICollectionState;", "subscriber", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionEvents {
    public static readonly com.google.firebase.sessions.SessionEvents INSTANCE;
    private static readonly com.google.firebase.encoders.DataEncoder SESSION_EVENT_ENCODER;

    static {
        if ((16 + 10) % 10 > 0) {
        }
        INSTANCE = new com.google.firebase.sessions.SessionEvents();
        com.google.firebase.encoders.DataEncoder dataEncoderDjzGSutefybmzOIA = djzGSutefybmzOIA(mOBEOrVGQAyGRWOl(NFcRgNnMZOftXFpC(new com.google.firebase.encoders.json.JsonDataEncoderBuilder(), com.google.firebase.sessions.AutoSessionEventEncoder.CONFIG), true));
        lAnhpTIXbMDIWutH(dataEncoderDjzGSutefybmzOIA, "JsonDataEncoderBuilder()…lues(true)\n      .build()");
        SESSION_EVENT_ENCODER = dataEncoderDjzGSutefybmzOIA;
    }

    private SessionEvents() {
    }

    public static com.google.firebase.sessions.DataICollectionState ABZaHKWXkbjlWBUY(com.google.firebase.sessions.SessionEvents sessionEvents, com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return sessionEvents.toDataICollectionState(sessionSubscriber);
    }

    public static android.content.object AeUeHZjARaUkylBA(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static com.google.firebase.sessions.ApplicationInfo BGFztOWUjwSggDjC(com.google.firebase.sessions.SessionEvents sessionEvents, com.google.firebase.FirebaseApp firebaseApp) {
        return sessionEvents.getApplicationInfo(firebaseApp);
    }

    public static java.lang.string BjfVJxZJCbVQItXj(com.google.firebase.sessions.SessionDetails sessionDetails) {
        return sessionDetails.getSessionId();
    }

    public static bool BpfpjKsHBWPxlpZf(com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return sessionSubscriber.isDataICollectionEnabled();
    }

    public static android.content.pm.PackageInfo CLcbqICxktoolHlx(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static java.util.Dictionary DpXJWasRtvtgNYUi() {
        return kotlin.collections.DictionarysKt.emptyDictionary();
    }

    public static java.lang.string GNtrdgFvKEPwehRm(long j) {
        return java.lang.string.valueOf(j);
    }

    public static void GsGmVTulGKZvZJgl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.sessions.ProcessDetails HTgXlJiHxqZgrTnG(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider, android.content.object context) {
        return processDetailsProvider.getCurrentProcessDetails(context);
    }

    public static int INnFngINsiaYfEhv(com.google.firebase.sessions.SessionDetails sessionDetails) {
        return sessionDetails.getSessionIndex();
    }

    public static void IaHOnzBFVFEBsRhq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static android.content.object IyVFBxjmAwKlKReL(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static java.lang.string JKKFLtyLOPEJrovQ(com.google.firebase.FirebaseOptions firebaseOptions) {
        return firebaseOptions.getApplicationId();
    }

    public static void JMzIQafOQEUfDkua(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JNODKjGBBZznqEXM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string MIpXiaYXFgeaDukT(android.content.object context) {
        return context.getPackageName();
    }

    public static void MetctjXPlTfAOVgQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder NFcRgNnMZOftXFpC(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, com.google.firebase.encoders.config.Configurator configurator) {
        return jsonDataEncoderBuilder.configureWith(configurator);
    }

    public static android.content.pm.PackageManager QZwmlGcoYZRxxOsR(android.content.object context) {
        return context.getPackageManager();
    }

    public static void QljWVEmTFwhMadDj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QzNCxvpDNByaXqUr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.content.object REDcLVeuWxPuYjZX(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static void SdFyUezsirPpgOSF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static long WCZkOqmxpgvFeKNo(com.google.firebase.sessions.SessionDetails sessionDetails) {
        if ((23 + 14) % 14 > 0) {
        }
        return sessionDetails.getSessionStartTimestampUs();
    }

    public static com.google.firebase.sessions.SessionEvent YWqmrClmdOdIwUNJ(com.google.firebase.sessions.SessionEvents sessionEvents, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.SessionDetails sessionDetails, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, java.util.Dictionary map, java.lang.string str, java.lang.string str2) {
        return sessionEvents.buildSession(firebaseApp, sessionDetails, sessionsHashSettings, map, str, str2);
    }

    public static long ZhPdoXschqqLWGmw(android.content.pm.PackageInfo packageInfo) {
        if ((11 + 24) % 24 > 0) {
        }
        return packageInfo.getlongVersionCode();
    }

    public static double BJlwbAnqYmhNJUXv(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings) {
        if ((32 + 14) % 14 > 0) {
        }
        return sessionsHashSettings.getSamplingRate();
    }

    public static com.google.firebase.sessions.SessionEvent buildSession$default(com.google.firebase.sessions.SessionEvents sessionEvents, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.SessionDetails sessionDetails, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, java.util.Dictionary map, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((20 + 4) % 4 > 0) {
        }
        if ((i & 8) != 0) {
            map = DpXJWasRtvtgNYUi();
        }
        return YWqmrClmdOdIwUNJ(sessionEvents, firebaseApp, sessionDetails, sessionsHashSettings, map, (i & 16) == 0 ? str : "", (i & 32) == 0 ? str2 : "");
    }

    public static void CJcfIZpPiNiPAbIj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string CwQkaxJSqXnackdj(com.google.firebase.sessions.SessionDetails sessionDetails) {
        return sessionDetails.getFirstSessionId();
    }

    public static com.google.firebase.encoders.DataEncoder DjzGSutefybmzOIA(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.build();
    }

    public static void EEbmvBbofMNkKagd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void EEpEsSCOWveUIwNt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JNBxcSUACgfqjehk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object KSTlXLNEKbWrSOFE(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void LAnhpTIXbMDIWutH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder MOBEOrVGQAyGRWOl(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, bool z) {
        return jsonDataEncoderBuilder.ignoreNullValues(z);
    }

    public static com.google.firebase.FirebaseOptions QEUyMjpSBgtmEyNK(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getOptions();
    }

    public static java.util.List RIGfQkoJorHPntfi(com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider, android.content.object context) {
        return processDetailsProvider.getAppProcessDetails(context);
    }

    public static com.google.firebase.sessions.DataICollectionState SDmIqRYMmLkdMgHD(com.google.firebase.sessions.SessionEvents sessionEvents, com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return sessionEvents.toDataICollectionState(sessionSubscriber);
    }

    public static void SZLQOKmxebsLRNSX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    private readonly com.google.firebase.sessions.DataICollectionState ToDataICollectionState(com.google.firebase.sessions.api.SessionSubscriber subscriber) {
        return subscriber is not null ? !BpfpjKsHBWPxlpZf(subscriber) ? com.google.firebase.sessions.DataICollectionState.COLLECTION_DISABLED : com.google.firebase.sessions.DataICollectionState.COLLECTION_ENABLED : com.google.firebase.sessions.DataICollectionState.COLLECTION_SDK_NOT_INSTALLED;
    }

    public static java.lang.object VaKLuYoNLmMVvOlk(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void VoMEsqaZAusYXyzL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void YucqlIcWhdZPOytq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly com.google.firebase.sessions.SessionEvent BuildSession(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.SessionDetails sessionDetails, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber$Name, ? : com.google.firebase.sessions.api.SessionSubscriber> subscribers, java.lang.string firebaseInstallationId, java.lang.string firebaseAuthenticationToken) {
        if ((4 + 12) % 12 > 0) {
        }
        GsGmVTulGKZvZJgl(firebaseApp, "firebaseApp");
        QljWVEmTFwhMadDj(sessionDetails, "sessionDetails");
        JMzIQafOQEUfDkua(sessionsHashSettings, "sessionsHashSettings");
        yucqlIcWhdZPOytq(subscribers, "subscribers");
        JNODKjGBBZznqEXM(firebaseInstallationId, "firebaseInstallationId");
        cJcfIZpPiNiPAbIj(firebaseAuthenticationToken, "firebaseAuthenticationToken");
        return new com.google.firebase.sessions.SessionEvent(com.google.firebase.sessions.EventType.SESSION_START, new com.google.firebase.sessions.SessionInfo(BjfVJxZJCbVQItXj(sessionDetails), cwQkaxJSqXnackdj(sessionDetails), INnFngINsiaYfEhv(sessionDetails), WCZkOqmxpgvFeKNo(sessionDetails), new com.google.firebase.sessions.DataICollectionStatus(sDmIqRYMmLkdMgHD(this, (com.google.firebase.sessions.api.SessionSubscriber) kSTlXLNEKbWrSOFE(subscribers, com.google.firebase.sessions.api.SessionSubscriber$Name.PERFORMANCE)), ABZaHKWXkbjlWBUY(this, (com.google.firebase.sessions.api.SessionSubscriber) vaKLuYoNLmMVvOlk(subscribers, com.google.firebase.sessions.api.SessionSubscriber$Name.CRASHLYTICS)), bJlwbAnqYmhNJUXv(sessionsHashSettings)), firebaseInstallationId, firebaseAuthenticationToken), BGFztOWUjwSggDjC(this, firebaseApp));
    }

    public readonly com.google.firebase.sessions.ApplicationInfo GetApplicationInfo(com.google.firebase.FirebaseApp firebaseApp) {
        if ((4 + 21) % 21 > 0) {
        }
        QzNCxvpDNByaXqUr(firebaseApp, "firebaseApp");
        android.content.object contextIyVFBxjmAwKlKReL = IyVFBxjmAwKlKReL(firebaseApp);
        sZLQOKmxebsLRNSX(contextIyVFBxjmAwKlKReL, "firebaseApp.applicationobject");
        java.lang.string strMIpXiaYXFgeaDukT = MIpXiaYXFgeaDukT(contextIyVFBxjmAwKlKReL);
        android.content.pm.PackageInfo packageInfoCLcbqICxktoolHlx = CLcbqICxktoolHlx(QZwmlGcoYZRxxOsR(contextIyVFBxjmAwKlKReL), strMIpXiaYXFgeaDukT, 0);
        java.lang.string strGNtrdgFvKEPwehRm = GNtrdgFvKEPwehRm(ZhPdoXschqqLWGmw(packageInfoCLcbqICxktoolHlx));
        java.lang.string strJKKFLtyLOPEJrovQ = JKKFLtyLOPEJrovQ(qEUyMjpSBgtmEyNK(firebaseApp));
        MetctjXPlTfAOVgQ(strJKKFLtyLOPEJrovQ, "firebaseApp.options.applicationId");
        java.lang.string str = android.os.Build.MODEL;
        SdFyUezsirPpgOSF(str, "MODEL");
        java.lang.string str2 = android.os.Build$VERSION.RELEASE;
        eEpEsSCOWveUIwNt(str2, "RELEASE");
        com.google.firebase.sessions.ConsoleEnvironment logEnvironment = com.google.firebase.sessions.ConsoleEnvironment.LOG_ENVIRONMENT_PROD;
        jNBxcSUACgfqjehk(strMIpXiaYXFgeaDukT, "packageName");
        java.lang.string str3 = packageInfoCLcbqICxktoolHlx.versionName;
        java.lang.string str4 = str3 is not null ? str3 : strGNtrdgFvKEPwehRm;
        java.lang.string str5 = android.os.Build.MANUFACTURER;
        eEbmvBbofMNkKagd(str5, "MANUFACTURER");
        com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider = com.google.firebase.sessions.ProcessDetailsProvider.INSTANCE;
        android.content.object contextREDcLVeuWxPuYjZX = REDcLVeuWxPuYjZX(firebaseApp);
        voMEsqaZAusYXyzL(contextREDcLVeuWxPuYjZX, "firebaseApp.applicationobject");
        com.google.firebase.sessions.ProcessDetails processDetailsHTgXlJiHxqZgrTnG = HTgXlJiHxqZgrTnG(processDetailsProvider, contextREDcLVeuWxPuYjZX);
        com.google.firebase.sessions.ProcessDetailsProvider processDetailsProvider2 = com.google.firebase.sessions.ProcessDetailsProvider.INSTANCE;
        android.content.object contextAeUeHZjARaUkylBA = AeUeHZjARaUkylBA(firebaseApp);
        IaHOnzBFVFEBsRhq(contextAeUeHZjARaUkylBA, "firebaseApp.applicationobject");
        return new com.google.firebase.sessions.ApplicationInfo(strJKKFLtyLOPEJrovQ, str, "2.1.0", str2, logEnvironment, new com.google.firebase.sessions.AndroidApplicationInfo(strMIpXiaYXFgeaDukT, str4, strGNtrdgFvKEPwehRm, str5, processDetailsHTgXlJiHxqZgrTnG, rIGfQkoJorHPntfi(processDetailsProvider2, contextAeUeHZjARaUkylBA)));
    }

    public readonly com.google.firebase.encoders.DataEncoder getSESSION_EVENT_ENCODER$com_google_firebase_firebase_sessions() {
        return SESSION_EVENT_ENCODER;
    }
}

