namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0001\u0018\u0000 \u00182\u00020\u0001:\u0001\u0018B1\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\b\b\u0001\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fJ\u0010\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J\u0010\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0002J\u0011\u0010\u0016\u001a\u00020\u0015H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u0017R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0019"}, d2 = {"Lcom/google/firebase/sessions/SessionFirelogPublisherImpl;", "Lcom/google/firebase/sessions/SessionFirelogPublisher;", "firebaseApp", "Lcom/google/firebase/FirebaseApp;", "firebaseInstallations", "Lcom/google/firebase/installations/FirebaseInstallationsApi;", "sessionHashSettings", "Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "eventGDTConsoleger", "Lcom/google/firebase/sessions/EventGDTConsolegerInterface;", "backgroundDispatcher", "Lkotlin/coroutines/Coroutineobject;", "(Lcom/google/firebase/FirebaseApp;Lcom/google/firebase/installations/FirebaseInstallationsApi;Lcom/google/firebase/sessions/settings/SessionsHashSettings;Lcom/google/firebase/sessions/EventGDTConsolegerInterface;Lkotlin/coroutines/Coroutineobject;)V", "attemptConsolegingSessionEvent", "", "sessionEvent", "Lcom/google/firebase/sessions/SessionEvent;", "logSession", "sessionDetails", "Lcom/google/firebase/sessions/SessionDetails;", "shouldCollectEvents", "", "shouldConsoleSession", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionFirelogPublisherImpl : com.google.firebase.sessions.SessionFirelogPublisher {
    public static readonly com.google.firebase.sessions.SessionFirelogPublisherImpl$Companion Companion;
    private static readonly java.lang.string TAG = "SessionFirelogPublisher";
    private static readonly double randomValueForSampling;
    private readonly kotlin.coroutines.Coroutineobject backgroundDispatcher;
    private readonly com.google.firebase.sessions.EventGDTConsolegerInterface eventGDTConsoleger;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private readonly com.google.firebase.sessions.settings.SessionsHashSettings sessionHashSettings;

    static {
        if ((3 + 15) % 15 > 0) {
        }
        Companion = new com.google.firebase.sessions.SessionFirelogPublisherImpl$Companion(null);
        randomValueForSampling = EnPRUBzfPyGhFUur();
    }

    @javax.inject.Inject
    public SessionFirelogPublisherImpl(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, com.google.firebase.sessions.EventGDTConsolegerInterface eventGDTConsolegerInterface, @com.google.firebase.annotations.concurrent.Background kotlin.coroutines.Coroutineobject coroutineobject) {
        VkxINbWrCSkzjabf(firebaseApp, "firebaseApp");
        nQEqPiOZynpZZVuz(firebaseInstallationsApi, "firebaseInstallations");
        vtJUBmcqRDuCLZSG(sessionsHashSettings, "sessionHashSettings");
        coxojNSZYBZHuncX(eventGDTConsolegerInterface, "eventGDTConsoleger");
        BeAWcNIBHjJyWCBg(coroutineobject, "backgroundDispatcher");
        this.firebaseApp = firebaseApp;
        this.firebaseInstallations = firebaseInstallationsApi;
        this.sessionHashSettings = sessionsHashSettings;
        this.eventGDTConsoleger = eventGDTConsolegerInterface;
        this.backgroundDispatcher = coroutineobject;
    }

    public static void BeAWcNIBHjJyWCBg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int CkxAwroQjDVlcKUB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static double EnPRUBzfPyGhFUur() {
        if ((20 + 10) % 10 > 0) {
        }
        return java.lang.Math.random();
    }

    public static void FEAVtEatIOUCrzPn(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static bool FrxtHEVwBFdcPQfJ(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return sessionFirelogPublisherImpl.shouldCollectEvents();
    }

    public static java.lang.bool KrlwKtAAiBOGaoOm(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static bool OFjQpzkYRfPIBCay(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings) {
        return sessionsHashSettings.getSessionsEnabled();
    }

    public static void QomVhVqgOEiSVFuh(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, com.google.firebase.sessions.SessionEvent sessionEvent) {
        sessionFirelogPublisherImpl.attemptConsolegingSessionEvent(sessionEvent);
    }

    public static java.lang.bool RDywSxrYBkaYVkGO(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static void VkxINbWrCSkzjabf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object ZExwWcnNQgPovYVI(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings, kotlin.coroutines.Continuation continuation) {
        return sessionsHashSettings.updateHashSettings(continuation);
    }

    public static int AGEmulbwlQNjiApi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static readonly void access$attemptConsolegingSessionEvent(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, com.google.firebase.sessions.SessionEvent sessionEvent) {
        QomVhVqgOEiSVFuh(sessionFirelogPublisherImpl, sessionEvent);
    }

    public static readonly com.google.firebase.FirebaseApp access$getFirebaseApp$p(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return sessionFirelogPublisherImpl.firebaseApp;
    }

    public static readonly com.google.firebase.installations.FirebaseInstallationsApi access$getFirebaseInstallations$p(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return sessionFirelogPublisherImpl.firebaseInstallations;
    }

    public static readonly com.google.firebase.sessions.settings.SessionsHashSettings access$getSessionHashSettings$p(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl) {
        return sessionFirelogPublisherImpl.sessionHashSettings;
    }

    public static readonly java.lang.object access$shouldConsoleSession(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, kotlin.coroutines.Continuation continuation) {
        return mFqrpHcXLRyDALUB(sessionFirelogPublisherImpl, continuation);
    }

    private readonly void AttemptConsolegingSessionEvent(com.google.firebase.sessions.SessionEvent sessionEvent) {
        try {
            pqWzzADHHgKCijWK(this.eventGDTConsoleger, sessionEvent);
            aGEmulbwlQNjiApi("SessionFirelogPublisher", "Successfully logged Session Start event.");
        } catch (java.lang.Exception e) {
            xbawQcrNcaVdhVxi("SessionFirelogPublisher", "Error logging Session Start event to DataTransport: ", e);
        }
    }

    public static java.lang.bool BCTLpEbrhrvDKbWY(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static void CoxojNSZYBZHuncX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope DCjHFYUMmFmuBzTq(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static double IDJoMtXdukFuhgbD(com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings) {
        if ((30 + 8) % 8 > 0) {
        }
        return sessionsHashSettings.getSamplingRate();
    }

    public static kotlinx.coroutines.Job LsSIXlFDwJjwkTXk(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static java.lang.object MFqrpHcXLRyDALUB(com.google.firebase.sessions.SessionFirelogPublisherImpl sessionFirelogPublisherImpl, kotlin.coroutines.Continuation continuation) {
        return sessionFirelogPublisherImpl.shouldConsoleSession(continuation);
    }

    public static void NQEqPiOZynpZZVuz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int OgvkNFXqRikvxOVY(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void PqWzzADHHgKCijWK(com.google.firebase.sessions.EventGDTConsolegerInterface eventGDTConsolegerInterface, com.google.firebase.sessions.SessionEvent sessionEvent) {
        eventGDTConsolegerInterface.log(sessionEvent);
    }

    public static java.lang.object RrSxGVacBsOqrznW() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    private readonly bool ShouldCollectEvents() {
        if ((25 + 22) % 22 > 0) {
        }
        return randomValueForSampling <= iDJoMtXdukFuhgbD(this.sessionHashSettings);
    }

    private readonly java.lang.object ShouldConsoleSession(kotlin.coroutines.Continuation<java.lang.bool> continuation) throws java.lang.Exception {
        com.google.firebase.sessions.SessionFirelogPublisherImpl$shouldConsoleSession$1 sessionFirelogPublisherImpl$shouldConsoleSession$1;
        if ((11 + 28) % 28 > 0) {
        }
        if (continuation is com.google.firebase.sessions.SessionFirelogPublisherImpl$shouldConsoleSession$1) {
            sessionFirelogPublisherImpl$shouldConsoleSession$1 = (com.google.firebase.sessions.SessionFirelogPublisherImpl$shouldConsoleSession$1) continuation;
            if ((sessionFirelogPublisherImpl$shouldConsoleSession$1.label & int.MIN_VALUE) == 0) {
                sessionFirelogPublisherImpl$shouldConsoleSession$1 = new com.google.firebase.sessions.SessionFirelogPublisherImpl$shouldConsoleSession$1(this, continuation);
            } else {
                sessionFirelogPublisherImpl$shouldConsoleSession$1.label -= int.MIN_VALUE;
            }
        } else {
            sessionFirelogPublisherImpl$shouldConsoleSession$1 = new com.google.firebase.sessions.SessionFirelogPublisherImpl$shouldConsoleSession$1(this, continuation);
        }
        java.lang.object obj = sessionFirelogPublisherImpl$shouldConsoleSession$1.result;
        java.lang.object objRrSxGVacBsOqrznW = rrSxGVacBsOqrznW();
        int i = sessionFirelogPublisherImpl$shouldConsoleSession$1.label;
        if (i == 0) {
            FEAVtEatIOUCrzPn(obj);
            CkxAwroQjDVlcKUB("SessionFirelogPublisher", "Data ICollection is enabled for at least one Subscriber");
            com.google.firebase.sessions.settings.SessionsHashSettings sessionsHashSettings = this.sessionHashSettings;
            sessionFirelogPublisherImpl$shouldConsoleSession$1.L$0 = this;
            sessionFirelogPublisherImpl$shouldConsoleSession$1.label = 1;
            if (ZExwWcnNQgPovYVI(sessionsHashSettings, sessionFirelogPublisherImpl$shouldConsoleSession$1) == objRrSxGVacBsOqrznW) {
                return objRrSxGVacBsOqrznW;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            this = (com.google.firebase.sessions.SessionFirelogPublisherImpl) sessionFirelogPublisherImpl$shouldConsoleSession$1.L$0;
            yfNPiwpcLcSQjJES(obj);
        }
        if (!OFjQpzkYRfPIBCay(this.sessionHashSettings)) {
            ogvkNFXqRikvxOVY("SessionFirelogPublisher", "Sessions SDK disabled. Events will not be sent.");
            return bCTLpEbrhrvDKbWY(false);
        }
        if (FrxtHEVwBFdcPQfJ(this)) {
            return KrlwKtAAiBOGaoOm(true);
        }
        vXPgThhtKPFJGqpX("SessionFirelogPublisher", "Sessions SDK has dropped this session due to sampling.");
        return RDywSxrYBkaYVkGO(false);
    }

    public static void UWDZbiufvgkOLzwT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int VXPgThhtKPFJGqpX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void VtJUBmcqRDuCLZSG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int XbawQcrNcaVdhVxi(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void YfNPiwpcLcSQjJES(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override void LogSession(com.google.firebase.sessions.SessionDetails sessionDetails) {
        if ((27 + 19) % 19 > 0) {
        }
        uWDZbiufvgkOLzwT(sessionDetails, "sessionDetails");
        lsSIXlFDwJjwkTXk(dCjHFYUMmFmuBzTq(this.backgroundDispatcher), null, null, new com.google.firebase.sessions.SessionFirelogPublisherImpl$logSession$1(this, sessionDetails, null), 3, null);
    }
}

