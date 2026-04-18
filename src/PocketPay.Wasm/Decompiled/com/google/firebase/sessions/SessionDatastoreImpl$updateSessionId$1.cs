namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1", m533f = "SessionDatastore.kt", m534i = {}, m535l = {95}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SessionDatastoreImpl$updateSessionId$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $sessionId;
    int label;
    readonly com.google.firebase.sessions.SessionDatastoreImpl this$0;

    SessionDatastoreImpl$updateSessionId$1(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl, java.lang.string str, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1> continuation) {
        super(2, continuation);
        this.this$0 = sessionDatastoreImpl;
        this.$sessionId = str;
    }

    public static java.lang.object AlpuWcnDBNCdkHSY(com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1 sessionDatastoreImpl$updateSessionId$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$updateSessionId$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.stringBuilder ChEtTnsmAoXxMFek(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object GVtRZusLHjsRaLQQ(com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1 sessionDatastoreImpl$updateSessionId$1, java.lang.object obj) {
        return sessionDatastoreImpl$updateSessionId$1.invokeSuspend(obj);
    }

    public static android.content.object ISEdwaDNrxHZBPqv(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        return com.google.firebase.sessions.SessionDatastoreImpl.access$getAppobject$p(sessionDatastoreImpl);
    }

    public static kotlin.coroutines.Continuation PmhLXmpsdiHoqzAB(com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1 sessionDatastoreImpl$updateSessionId$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$updateSessionId$1.create(obj, continuation);
    }

    public static java.lang.object YFvyHgUtoREotdvH(androidx.datastore.core.DataStore dataStore, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.preferences.core.PreferencesKt.edit(dataStore, function2, continuation);
    }

    public static java.lang.string ZdPuhZoAThnGXiBO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AnDKZSyPlTMqJKQr(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int CNjyXYSgRaEXXmGD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.firebase.sessions.SessionDatastoreImpl$Companion maShNmioiKKBJWMX() {
        return com.google.firebase.sessions.SessionDatastoreImpl.access$getCompanion$p();
    }

    public static java.lang.object PyvLmQcHtoprLucB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void QGVGjcJOlQyqcXIs(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.datastore.core.DataStore XShvEvQuyRrBviJu(com.google.firebase.sessions.SessionDatastoreImpl$Companion sessionDatastoreImpl$Companion, android.content.object context) {
        return com.google.firebase.sessions.SessionDatastoreImpl$Companion.access$getDataStore(sessionDatastoreImpl$Companion, context);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1(this.this$0, this.$sessionId, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return AlpuWcnDBNCdkHSY(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return GVtRZusLHjsRaLQQ((com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1) PmhLXmpsdiHoqzAB(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 24) % 24 > 0) {
        }
        java.lang.object objPyvLmQcHtoprLucB = pyvLmQcHtoprLucB();
        int i = this.label;
        try {
            if (i == 0) {
                qGVGjcJOlQyqcXIs(obj);
                this.label = 1;
                if (YFvyHgUtoREotdvH(xShvEvQuyRrBviJu(maShNmioiKKBJWMX(), ISEdwaDNrxHZBPqv(this.this$0)), new com.google.firebase.sessions.SessionDatastoreImpl$updateSessionId$1$1(this.$sessionId, null), this) == objPyvLmQcHtoprLucB) {
                    return objPyvLmQcHtoprLucB;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                anDKZSyPlTMqJKQr(obj);
            }
        } catch (java.io.IOException e) {
            cNjyXYSgRaEXXmGD("FirebaseSessionsRepo", ZdPuhZoAThnGXiBO(ChEtTnsmAoXxMFek(new java.lang.stringBuilder("Failed to update session Id: "), e)));
        }
        return kotlin.Unit.INSTANCE;
    }
}

