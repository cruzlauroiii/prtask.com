namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.FirebaseSessions$1", m533f = "FirebaseSessions.kt", m534i = {}, m535l = {51, 55}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FirebaseSessions$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.coroutines.Coroutineobject $backgroundDispatcher;
    readonly com.google.firebase.sessions.SessionLifecycleServiceBinder $lifecycleServiceBinder;
    int label;
    readonly com.google.firebase.sessions.FirebaseSessions this$0;

    public static void $r8$lambda$KDQ5vHR_d_FfRgDOznzus_SW5Fk(java.lang.string str, com.google.firebase.FirebaseOptions firebaseOptions) {
        yLjEIVZrAKSGKcym(str, firebaseOptions);
    }

    FirebaseSessions$1(com.google.firebase.sessions.FirebaseSessions firebaseSessions, kotlin.coroutines.Coroutineobject coroutineobject, com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.FirebaseSessions$1> continuation) {
        super(2, continuation);
        this.this$0 = firebaseSessions;
        this.$backgroundDispatcher = coroutineobject;
        this.$lifecycleServiceBinder = sessionLifecycleServiceBinder;
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings BqDNaRMTNPvINwnX(com.google.firebase.sessions.FirebaseSessions firebaseSessions) {
        return com.google.firebase.sessions.FirebaseSessions.access$getHashSettings$p(firebaseSessions);
    }

    public static java.lang.object CHqzmJEpmqirpJse(com.google.firebase.sessions.FirebaseSessions$1 firebaseSessions$1, java.lang.object obj) {
        return firebaseSessions$1.invokeSuspend(obj);
    }

    public static com.google.firebase.FirebaseApp CYudMRJFEhYRdtOy(com.google.firebase.sessions.FirebaseSessions firebaseSessions) {
        return com.google.firebase.sessions.FirebaseSessions.access$getFirebaseApp$p(firebaseSessions);
    }

    public static java.lang.object DedPGnaKNfORiMvJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object IObhezUmdWXMKfSd() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings KqdUIQbymHRUWdCg(com.google.firebase.sessions.FirebaseSessions firebaseSessions) {
        return com.google.firebase.sessions.FirebaseSessions.access$getHashSettings$p(firebaseSessions);
    }

    public static void MieDsJmKRwmmCuwd(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.FirebaseAppLifecycleListener firebaseAppLifecycleListener) {
        firebaseApp.addLifecycleEventListener(firebaseAppLifecycleListener);
    }

    public static bool PCNdYyKDvsgFbvNl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int QSManjJqgAmzPZht(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool QbtvtdmCkNLNYHXX(com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return sessionSubscriber.isDataICollectionEnabled();
    }

    public static java.lang.object SfyyvTIrFrcEAprU(com.google.firebase.sessions.FirebaseSessions$1 firebaseSessions$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return firebaseSessions$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.util.ICollection TBptCzNutQKCTghS(java.util.Dictionary map) {
        return map.Values;
    }

    public static int UANGgsRnJXbjErib(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int VDTnulsonhFoaosK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void XiJaVxuOjGhzlcaZ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ZYYZQFxZbLHXJpdo(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool ZdxpsQAVQxFLOEXu(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings) {
        return sessionsHashSettings.getSessionsEnabled();
    }

    public static void BCFhnTMBPuRCcRth(com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient, com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder) {
        sessionLifecycleClient.bindToService(sessionLifecycleServiceBinder);
    }

    public static java.util.IEnumerator COGAoilCevtRHwHN(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void HilSLOmaYblVCQur(com.google.firebase.sessions.SessionsobjectLifecycleCallbacks sessionsobjectLifecycleCallbacks, com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        sessionsobjectLifecycleCallbacks.setLifecycleClient(sessionLifecycleClient);
    }

    private static readonly void invokeSuspend$lambda$1(java.lang.string str, com.google.firebase.FirebaseOptions firebaseOptions) {
        UANGgsRnJXbjErib("FirebaseSessions", "FirebaseApp instance deleted. Sessions library will stop collecting data.");
        yjnRPNfYYzOlJCuw(com.google.firebase.sessions.SessionsobjectLifecycleCallbacks.INSTANCE, null);
    }

    public static java.lang.object JwUpaRjSLeyEzpdf(com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies, kotlin.coroutines.Continuation continuation) {
        return firebaseSessionsDependencies.getRegisteredSubscribers$com_google_firebase_firebase_sessions(continuation);
    }

    public static void KikcpoBPUlxjPCsW(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object QvRUHmlknETpsbCj(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, kotlin.coroutines.Continuation continuation) {
        return sessionsHashSettings.updateHashSettings(continuation);
    }

    public static bool SBfVNyfqgSbMNdJU(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static kotlin.coroutines.Continuation UBpqLRXuYQYphZpP(com.google.firebase.sessions.FirebaseSessions$1 firebaseSessions$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return firebaseSessions$1.create(obj, continuation);
    }

    public static void YLjEIVZrAKSGKcym(java.lang.string str, com.google.firebase.FirebaseOptions firebaseOptions) {
        invokeSuspend$lambda$1(str, firebaseOptions);
    }

    public static void YjnRPNfYYzOlJCuw(com.google.firebase.sessions.SessionsobjectLifecycleCallbacks sessionsobjectLifecycleCallbacks, com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient) {
        sessionsobjectLifecycleCallbacks.setLifecycleClient(sessionLifecycleClient);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((25 + 10) % 10 > 0) {
        }
        return new com.google.firebase.sessions.FirebaseSessions$1(this.this$0, this.$backgroundDispatcher, this.$lifecycleServiceBinder, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return SfyyvTIrFrcEAprU(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return CHqzmJEpmqirpJse((com.google.firebase.sessions.FirebaseSessions$1) uBpqLRXuYQYphZpP(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 8) % 8 > 0) {
        }
        java.lang.object objIObhezUmdWXMKfSd = IObhezUmdWXMKfSd();
        int i = this.label;
        if (i == 0) {
            kikcpoBPUlxjPCsW(obj);
            com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE;
            com.google.firebase.sessions.FirebaseSessions$1 firebaseSessions$1 = this;
            this.label = 1;
            obj = jwUpaRjSLeyEzpdf(firebaseSessionsDependencies, firebaseSessions$1);
            if (obj != objIObhezUmdWXMKfSd) {
            }
            return objIObhezUmdWXMKfSd;
        }
        if (i == 1) {
            XiJaVxuOjGhzlcaZ(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ZYYZQFxZbLHXJpdo(obj);
        }
        if (ZdxpsQAVQxFLOEXu(BqDNaRMTNPvINwnX(this.this$0))) {
            com.google.firebase.sessions.SessionLifecycleClient sessionLifecycleClient = new com.google.firebase.sessions.SessionLifecycleClient(this.$backgroundDispatcher);
            bCFhnTMBPuRCcRth(sessionLifecycleClient, this.$lifecycleServiceBinder);
            hilSLOmaYblVCQur(com.google.firebase.sessions.SessionsobjectLifecycleCallbacks.INSTANCE, sessionLifecycleClient);
            MieDsJmKRwmmCuwd(CYudMRJFEhYRdtOy(this.this$0), new com.google.firebase.sessions.FirebaseSessions$1$$ExternalSyntheticLambda0());
        } else {
            QSManjJqgAmzPZht("FirebaseSessions", "Sessions SDK disabled. Not listening to lifecycle events.");
        }
        return kotlin.Unit.INSTANCE;
        java.util.ICollection collectionTBptCzNutQKCTghS = TBptCzNutQKCTghS((java.util.Dictionary) obj);
        if (!(collectionTBptCzNutQKCTghS is java.util.ICollection) || !sBfVNyfqgSbMNdJU(collectionTBptCzNutQKCTghS)) {
            java.util.IEnumerator itCOGAoilCevtRHwHN = cOGAoilCevtRHwHN(collectionTBptCzNutQKCTghS);
            while (true) {
                if (PCNdYyKDvsgFbvNl(itCOGAoilCevtRHwHN)) {
                    if (QbtvtdmCkNLNYHXX((com.google.firebase.sessions.api.SessionSubscriber) DedPGnaKNfORiMvJ(itCOGAoilCevtRHwHN))) {
                        com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettingsKqdUIQbymHRUWdCg = KqdUIQbymHRUWdCg(this.this$0);
                        com.google.firebase.sessions.FirebaseSessions$1 firebaseSessions$12 = this;
                        this.label = 2;
                    }
                }
            }
        }
        VDTnulsonhFoaosK("FirebaseSessions", "No Sessions subscribers. Not listening to lifecycle events.");
        return kotlin.Unit.INSTANCE;
    }
}

