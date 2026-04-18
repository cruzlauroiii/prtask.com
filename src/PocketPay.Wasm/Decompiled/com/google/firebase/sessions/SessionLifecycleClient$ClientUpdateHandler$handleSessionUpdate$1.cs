namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1", m533f = "SessionLifecycleClient.kt", m534i = {}, m535l = {74}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $sessionId;
    int label;

    SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1(java.lang.string str, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1> continuation) {
        super(2, continuation);
        this.$sessionId = str;
    }

    public static java.lang.stringBuilder BrkqjDbIXYKYFXFr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object ClZRObBAzdGFpFbC() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static com.google.firebase.sessions.api.SessionSubscriber$Name HkZoxAUpqiqdmFKc(com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return sessionSubscriber.getSessionSubscriberName();
    }

    public static java.lang.object ItlGFWRrNiLzKOAg(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LEGquQHVOAGurfvp(com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber, com.google.firebase.sessions.api.SessionSubscriber$SessionDetails sessionSubscriber$SessionDetails) {
        sessionSubscriber.onSessionChanged(sessionSubscriber$SessionDetails);
    }

    public static bool NMDxdBOJLYwCFXQG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder NksDGZriKetXCvOT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object SrrixXordGgDthvC(com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1 sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1, java.lang.object obj) {
        return sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1.invokeSuspend(obj);
    }

    public static java.lang.string WTBqibNgzcokidFn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XCIRbyGEUGmVBPGK(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void EDgOBJpdPlUOkdgu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object JknNWXVWBOGcZbmr(com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1 sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static kotlin.coroutines.Continuation LeTteobwCAJteiGz(com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1 sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1.create(obj, continuation);
    }

    public static java.lang.object OLYhIiGTWwKYGoBt(com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies, kotlin.coroutines.Continuation continuation) {
        return firebaseSessionsDependencies.getRegisteredSubscribers$com_google_firebase_firebase_sessions(continuation);
    }

    public static int UDwyFeuOPegtyqEn(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder UENyrepGDrHPduws(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.ICollection WDkCHhnYTRpnxHsz(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.util.IEnumerator WHKZRcEtIpiwOvvR(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1(this.$sessionId, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return jknNWXVWBOGcZbmr(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return SrrixXordGgDthvC((com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1) leTteobwCAJteiGz(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 5) % 5 > 0) {
        }
        java.lang.object objClZRObBAzdGFpFbC = ClZRObBAzdGFpFbC();
        int i = this.label;
        if (i == 0) {
            XCIRbyGEUGmVBPGK(obj);
            com.google.firebase.sessions.api.FirebaseSessionsDependencies firebaseSessionsDependencies = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE;
            com.google.firebase.sessions.SessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1 sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1 = this;
            this.label = 1;
            obj = oLYhIiGTWwKYGoBt(firebaseSessionsDependencies, sessionLifecycleClient$ClientUpdateHandler$handleSessionUpdate$1);
            if (obj == objClZRObBAzdGFpFbC) {
                return objClZRObBAzdGFpFbC;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            eDgOBJpdPlUOkdgu(obj);
        }
        java.util.ICollection collectionWDkCHhnYTRpnxHsz = wDkCHhnYTRpnxHsz((java.util.Dictionary) obj);
        java.lang.string str = this.$sessionId;
        java.util.IEnumerator itWHKZRcEtIpiwOvvR = wHKZRcEtIpiwOvvR(collectionWDkCHhnYTRpnxHsz);
        while (NMDxdBOJLYwCFXQG(itWHKZRcEtIpiwOvvR)) {
            com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber = (com.google.firebase.sessions.api.SessionSubscriber) ItlGFWRrNiLzKOAg(itWHKZRcEtIpiwOvvR);
            LEGquQHVOAGurfvp(sessionSubscriber, new com.google.firebase.sessions.api.SessionSubscriber$SessionDetails(str));
            uDwyFeuOPegtyqEn("SessionLifecycleClient", WTBqibNgzcokidFn(NksDGZriKetXCvOT(uENyrepGDrHPduws(BrkqjDbIXYKYFXFr(new java.lang.stringBuilder("Notified "), HkZoxAUpqiqdmFKc(sessionSubscriber)), " of new session "), str)));
        }
        return kotlin.Unit.INSTANCE;
    }
}

