namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "preferences", "Landroidx/datastore/preferences/core/MutablePreferences;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1", m533f = "SessionDatastore.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SessionDatastoreImpl$updateSessionId$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.datastore.preferences.core.MutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $sessionId;
    java.lang.object L$0;
    int label;

    SessionDatastoreImpl$updateSessionId$1$1(java.lang.string str, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1> continuation) {
        super(2, continuation);
        this.$sessionId = str;
    }

    public static androidx.datastore.preferences.core.Preferences$Key BsiiFkmkvFVUBZRH(com.google.firebase.sessions.SessionDatastoreImpl$FirebaseSessionDataKeys sessionDatastoreImpl$FirebaseSessionDataKeys) {
        return sessionDatastoreImpl$FirebaseSessionDataKeys.getSESSION_ID();
    }

    public static java.lang.object EsMUkrIYtfechkWS(com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1 sessionDatastoreImpl$updateSessionId$1$1, androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$updateSessionId$1$1.invoke2(mutablePreferences, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void HbPeVRCaMyhFmlGw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation RYHWajaNgoePJLfa(com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1 sessionDatastoreImpl$updateSessionId$1$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$updateSessionId$1$1.create(obj, continuation);
    }

    public static java.lang.object RbRTYhpLfhyLccGB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object SjSDWivzLCmGQCRP(com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1 sessionDatastoreImpl$updateSessionId$1$1, java.lang.object obj) {
        return sessionDatastoreImpl$updateSessionId$1$1.invokeSuspend(obj);
    }

    public static void YPzPwgXVNWzKArNe(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1 sessionDatastoreImpl$updateSessionId$1$1 = new com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1(this.$sessionId, continuation);
        sessionDatastoreImpl$updateSessionId$1$1.L$0 = obj;
        return sessionDatastoreImpl$updateSessionId$1$1;
    }

    public readonly java.lang.object Invoke2(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return sjSDWivzLCmGQCRP((com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1) rYHWajaNgoePJLfa(this, mutablePreferences, continuation), kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return EsMUkrIYtfechkWS(this, mutablePreferences, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        rbRTYhpLfhyLccGB();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        HbPeVRCaMyhFmlGw(obj);
        yPzPwgXVNWzKArNe((androidx.datastore.preferences.core.MutablePreferences) this.L$0, BsiiFkmkvFVUBZRH(com.google.firebase.sessions.SessionDatastoreImpl$FirebaseSessionDataKeys.INSTANCE), this.$sessionId);
        return kotlin.Unit.INSTANCE;
    }
}

