namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0004\u001a\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;", "Landroidx/datastore/preferences/core/Preferences;", "exception", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1", m533f = "SessionDatastore.kt", m534i = {}, m535l = {82}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SessionDatastoreImpl$firebaseSessionDataFlow$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<androidx.datastore.preferences.core.Preferences>, java.lang.Exception, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    SessionDatastoreImpl$firebaseSessionDataFlow$1(kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1> continuation) {
        super(3, continuation);
    }

    public static java.lang.object BHIUdXxAFrYXHTaq(com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1 sessionDatastoreImpl$firebaseSessionDataFlow$1, kotlinx.coroutines.flow.FlowCollector flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$firebaseSessionDataFlow$1.invoke2((kotlinx.coroutines.flow.FlowCollector<androidx.datastore.preferences.core.Preferences>) flowCollector, th, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static androidx.datastore.preferences.core.Preferences HsswMNyCMgKEumih() {
        return androidx.datastore.preferences.core.PreferencesFactory.createEmpty();
    }

    public static int NrZZFQDqLTGXGYNI(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void RlyMoXUtDEPVjEwH(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ZAmJYCmxIeUCpMjx(kotlinx.coroutines.flow.FlowCollector flowCollector, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return flowCollector.emit(obj, continuation);
    }

    public static java.lang.object ZkAiHaRHiTqctfLi(com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1 sessionDatastoreImpl$firebaseSessionDataFlow$1, java.lang.object obj) {
        return sessionDatastoreImpl$firebaseSessionDataFlow$1.invokeSuspend(obj);
    }

    public static void WxtNTkVHzYGuoRCZ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object WzKBNIWUCFfDPvNu() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.datastore.preferences.core.Preferences> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return BHIUdXxAFrYXHTaq(this, flowCollector, th, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<androidx.datastore.preferences.core.Preferences> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1 sessionDatastoreImpl$firebaseSessionDataFlow$1 = new com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1(continuation);
        sessionDatastoreImpl$firebaseSessionDataFlow$1.L$0 = flowCollector;
        sessionDatastoreImpl$firebaseSessionDataFlow$1.L$1 = th;
        return ZkAiHaRHiTqctfLi(sessionDatastoreImpl$firebaseSessionDataFlow$1, kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 9) % 9 > 0) {
        }
        java.lang.object objWzKBNIWUCFfDPvNu = wzKBNIWUCFfDPvNu();
        int i = this.label;
        if (i == 0) {
            wxtNTkVHzYGuoRCZ(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            NrZZFQDqLTGXGYNI("FirebaseSessionsRepo", "Error reading stored session data.", (java.lang.Exception) this.L$1);
            androidx.datastore.preferences.core.Preferences preferencesHsswMNyCMgKEumih = HsswMNyCMgKEumih();
            com.google.firebase.sessions.SessionDatastoreImpl$firebaseSessionDataFlow$1 sessionDatastoreImpl$firebaseSessionDataFlow$1 = this;
            this.L$0 = null;
            this.label = 1;
            if (ZAmJYCmxIeUCpMjx(flowCollector, preferencesHsswMNyCMgKEumih, sessionDatastoreImpl$firebaseSessionDataFlow$1) == objWzKBNIWUCFfDPvNu) {
                return objWzKBNIWUCFfDPvNu;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            RlyMoXUtDEPVjEwH(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

