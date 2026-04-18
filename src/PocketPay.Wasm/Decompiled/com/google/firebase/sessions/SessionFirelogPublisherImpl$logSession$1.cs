namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1", m533f = "SessionFirelogPublisher.kt", m534i = {2}, m535l = {69, 70, 76}, m536m = "invokeSuspend", m537n = {"installationId"}, m538s = {"L$0"})
readonly class SessionFirelogPublisherImpl$logSession$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly com.google.firebase.sessions.SessionDetails $sessionDetails;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    java.lang.object L$4;
    java.lang.object L$5;
    int label;
    readonly com.google.firebase.sessions.SessionFirelogPublisherImpl this$0;

    SessionFirelogPublisherImpl$logSession$1(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, com.google.firebase.sessions.SessionDetails sessionDetails, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1> continuation) {
        super(2, continuation);
        this.this$0 = sessionFirelogPublisherImpl;
        this.$sessionDetails = sessionDetails;
    }

    public static void AxmmEfSvbWdQYsuM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static com.google.firebase.installations.FirebaseInstallationsApi GImIriZhlaZVNtbA(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return com.google.firebase.sessions.SessionFirelogPublisherImpl.access$getFirebaseInstallations$p(sessionFirelogPublisherImpl);
    }

    public static java.lang.object IbtcRNoLysBefnfL(com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return sessionFirelogPublisherImpl$logSession$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object MssWUdbMeXnBKLIy(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, kotlin.coroutines.Continuation continuation) {
        return com.google.firebase.sessions.SessionFirelogPublisherImpl.access$shouldConsoleSession(sessionFirelogPublisherImpl, continuation);
    }

    public static kotlin.coroutines.Continuation PWeGuNMFAUgsMqOR(com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sessionFirelogPublisherImpl$logSession$1.create(obj, continuation);
    }

    public static com.google.firebase.sessions.settings.SessionsHashSettings PeEsdsUwNTGDjPLY(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return com.google.firebase.sessions.SessionFirelogPublisherImpl.access$getSessionHashSettings$p(sessionFirelogPublisherImpl);
    }

    public static java.lang.object RRSUpwbSWabMcIdk(com.google.firebase.sessions.InstallationId$Companion installationId$Companion, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, kotlin.coroutines.Continuation continuation) {
        return installationId$Companion.create(firebaseInstallationsApi, continuation);
    }

    public static java.lang.string ValyUWlazeTcxAmL(com.google.firebase.sessions.InstallationId installationId) {
        return installationId.getFid();
    }

    public static void XUcohrhlZzpjVZbv(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool YoZsOonqyJYXMlku(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void ZLktiyAVIflidMNY(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string ZiLuFTKJAwcyBIBg(com.google.firebase.sessions.InstallationId installationId) {
        return installationId.getAuthToken();
    }

    public static void AJHcdOuLlCtgAuAg(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, com.google.firebase.sessions.SessionEvent sessionEvent) {
        com.google.firebase.sessions.SessionFirelogPublisherImpl.access$attemptConsolegingSessionEvent(sessionFirelogPublisherImpl, sessionEvent);
    }

    public static com.google.firebase.FirebaseApp BpuswNWkWQVAdIPg(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return com.google.firebase.sessions.SessionFirelogPublisherImpl.access$getFirebaseApp$p(sessionFirelogPublisherImpl);
    }

    public static java.lang.object BvNavlwkJwfujdRi(com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies, kotlin.coroutines.Continuation continuation) {
        return firebaseSessionsDependencies.getRegisteredSubscribers$com_google_firebase_firebase_sessions(continuation);
    }

    public static com.google.firebase.sessions.SessionEvent ONMRebDQFPIsQpbC(com.google.firebase.sessions.SessionEvents sessionEvents, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.sessions.SessionDetails sessionDetails, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, java.util.Dictionary map, java.lang.string str, java.lang.string str2) {
        return sessionEvents.buildSession(firebaseApp, sessionDetails, sessionsHashSettings, map, str, str2);
    }

    public static java.lang.object RnxfBwXMgKwnrWLx() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void SkkKmPDNuFiMgvWt(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object XjibOKHCFSqkcJdW(com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$1, java.lang.object obj) {
        return sessionFirelogPublisherImpl$logSession$1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1(this.this$0, this.$sessionDetails, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return IbtcRNoLysBefnfL(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return xjibOKHCFSqkcJdW((com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1) PWeGuNMFAUgsMqOR(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        com.google.firebase.sessions.InstallationId installationId;
        com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl;
        com.google.firebase.sessions.SessionEvents sessionEvents;
        com.google.firebase.FirebaseApp firebaseAppBpuswNWkWQVAdIPg;
        com.google.firebase.sessions.SessionDetails sessionDetails;
        com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettingsPeEsdsUwNTGDjPLY;
        java.lang.object objBvNavlwkJwfujdRi;
        com.google.firebase.sessions.InstallationId installationId2;
        com.google.firebase.sessions.SessionEvents sessionEvents2;
        com.google.firebase.sessions.SessionDetails sessionDetails2;
        com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings;
        if ((29 + 26) % 26 > 0) {
        }
        java.lang.object objRnxfBwXMgKwnrWLx = rnxfBwXMgKwnrWLx();
        int i = this.label;
        if (i == 0) {
            XUcohrhlZzpjVZbv(obj);
            com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl2 = this.this$0;
            com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$1 = this;
            this.label = 1;
            obj = MssWUdbMeXnBKLIy(sessionFirelogPublisherImpl2, sessionFirelogPublisherImpl$logSession$1);
            if (obj != objRnxfBwXMgKwnrWLx) {
            }
            return objRnxfBwXMgKwnrWLx;
        }
        if (i == 1) {
            ZLktiyAVIflidMNY(obj);
        } else {
            if (i == 2) {
                AxmmEfSvbWdQYsuM(obj);
                installationId = (com.google.firebase.sessions.InstallationId) obj;
                sessionFirelogPublisherImpl = this.this$0;
                sessionEvents = com.google.firebase.sessions.SessionEvents.INSTANCE;
                firebaseAppBpuswNWkWQVAdIPg = bpuswNWkWQVAdIPg(this.this$0);
                sessionDetails = this.$sessionDetails;
                sessionsHashSettingsPeEsdsUwNTGDjPLY = PeEsdsUwNTGDjPLY(this.this$0);
                com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE;
                com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$12 = this;
                this.L$0 = installationId;
                this.L$1 = sessionFirelogPublisherImpl;
                this.L$2 = sessionEvents;
                this.L$3 = firebaseAppBpuswNWkWQVAdIPg;
                this.L$4 = sessionDetails;
                this.L$5 = sessionsHashSettingsPeEsdsUwNTGDjPLY;
                this.label = 3;
                objBvNavlwkJwfujdRi = bvNavlwkJwfujdRi(firebaseSessionsDependencies, sessionFirelogPublisherImpl$logSession$12);
                if (objBvNavlwkJwfujdRi != objRnxfBwXMgKwnrWLx) {
                    obj = objBvNavlwkJwfujdRi;
                    installationId2 = installationId;
                    sessionEvents2 = sessionEvents;
                    sessionDetails2 = sessionDetails;
                    sessionsHashSettings = sessionsHashSettingsPeEsdsUwNTGDjPLY;
                }
                return objRnxfBwXMgKwnrWLx;
            }
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings2 = (com.google.firebase.sessions.settings.SessionsHashSettings) this.L$5;
            com.google.firebase.sessions.SessionDetails sessionDetails3 = (com.google.firebase.sessions.SessionDetails) this.L$4;
            com.google.firebase.FirebaseApp firebaseApp = (com.google.firebase.FirebaseApp) this.L$3;
            com.google.firebase.sessions.SessionEvents sessionEvents3 = (com.google.firebase.sessions.SessionEvents) this.L$2;
            sessionFirelogPublisherImpl = (com.google.firebase.sessions.SessionFirelogPublisherImpl) this.L$1;
            installationId2 = (com.google.firebase.sessions.InstallationId) this.L$0;
            skkKmPDNuFiMgvWt(obj);
            sessionsHashSettings = sessionsHashSettings2;
            sessionEvents2 = sessionEvents3;
            sessionDetails2 = sessionDetails3;
            firebaseAppBpuswNWkWQVAdIPg = firebaseApp;
        }
        aJHcdOuLlCtgAuAg(sessionFirelogPublisherImpl, oNMRebDQFPIsQpbC(sessionEvents2, firebaseAppBpuswNWkWQVAdIPg, sessionDetails2, sessionsHashSettings, (java.util.Dictionary) obj, ValyUWlazeTcxAmL(installationId2), ZiLuFTKJAwcyBIBg(installationId2)));
        return kotlin.Unit.INSTANCE;
        if (YoZsOonqyJYXMlku((java.lang.bool) obj)) {
            com.google.firebase.sessions.InstallationId$Companion installationId$Companion = com.google.firebase.sessions.InstallationId.Companion;
            com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApiGImIriZhlaZVNtbA = GImIriZhlaZVNtbA(this.this$0);
            com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$13 = this;
            this.label = 2;
            obj = RRSUpwbSWabMcIdk(installationId$Companion, firebaseInstallationsApiGImIriZhlaZVNtbA, sessionFirelogPublisherImpl$logSession$13);
            if (obj != objRnxfBwXMgKwnrWLx) {
                installationId = (com.google.firebase.sessions.InstallationId) obj;
                sessionFirelogPublisherImpl = this.this$0;
                sessionEvents = com.google.firebase.sessions.SessionEvents.INSTANCE;
                firebaseAppBpuswNWkWQVAdIPg = bpuswNWkWQVAdIPg(this.this$0);
                sessionDetails = this.$sessionDetails;
                sessionsHashSettingsPeEsdsUwNTGDjPLY = PeEsdsUwNTGDjPLY(this.this$0);
                com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies2 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE;
                com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1 sessionFirelogPublisherImpl$logSession$122 = this;
                this.L$0 = installationId;
                this.L$1 = sessionFirelogPublisherImpl;
                this.L$2 = sessionEvents;
                this.L$3 = firebaseAppBpuswNWkWQVAdIPg;
                this.L$4 = sessionDetails;
                this.L$5 = sessionsHashSettingsPeEsdsUwNTGDjPLY;
                this.label = 3;
                objBvNavlwkJwfujdRi = bvNavlwkJwfujdRi(firebaseSessionsDependencies2, sessionFirelogPublisherImpl$logSession$122);
                if (objBvNavlwkJwfujdRi != objRnxfBwXMgKwnrWLx) {
                    obj = objBvNavlwkJwfujdRi;
                    installationId2 = installationId;
                    sessionEvents2 = sessionEvents;
                    sessionDetails2 = sessionDetails;
                    sessionsHashSettings = sessionsHashSettingsPeEsdsUwNTGDjPLY;
                    aJHcdOuLlCtgAuAg(sessionFirelogPublisherImpl, oNMRebDQFPIsQpbC(sessionEvents2, firebaseAppBpuswNWkWQVAdIPg, sessionDetails2, sessionsHashSettings, (java.util.Dictionary) obj, ValyUWlazeTcxAmL(installationId2), ZiLuFTKJAwcyBIBg(installationId2)));
                }
            }
            return objRnxfBwXMgKwnrWLx;
        }
        return kotlin.Unit.INSTANCE;
    }
}

