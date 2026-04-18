namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.SessionDatastoreImpl$1", m533f = "SessionDatastore.kt", m534i = {}, m535l = {88}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SessionDatastoreImpl$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly com.google.firebase.sessions.SessionDatastoreImpl this$0;

    SessionDatastoreImpl$1(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.SessionDatastoreImpl$1> continuation) {
        super(2, continuation);
        this.this$0 = sessionDatastoreImpl;
    }

    public static void GtftkGjWCNxxwkoZ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object MzHwfNmNWtsrYBwD(com.google.firebase.sessions.SessionDatastoreImpl$1 sessionDatastoreImpl$1, java.lang.object obj) {
        return sessionDatastoreImpl$1.invokeSuspend(obj);
    }

    public static kotlin.coroutines.Continuation OOaWwBgejnGRvHfd(com.google.firebase.sessions.SessionDatastoreImpl$1 sessionDatastoreImpl$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$1.create(obj, continuation);
    }

    public static void WMfJmtnawEjKfHRK(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlinx.coroutines.flow.Flow GWqiXbGCLJxHmjRY(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        return com.google.firebase.sessions.SessionDatastoreImpl.access$getFirebaseSessionDataFlow$p(sessionDatastoreImpl);
    }

    public static java.lang.object GjwdmNhLKHwqVGku(com.google.firebase.sessions.SessionDatastoreImpl$1 sessionDatastoreImpl$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object LpZxByorsviqMtJm(kotlinx.coroutines.flow.Flow flow, kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        return flow.collect(flowCollector, continuation);
    }

    public static java.lang.object ZQdbubnVBeblvOnT() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.SessionDatastoreImpl$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return gjwdmNhLKHwqVGku(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return MzHwfNmNWtsrYBwD((com.google.firebase.sessions.SessionDatastoreImpl$1) OOaWwBgejnGRvHfd(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((12 + 31) % 31 > 0) {
        }
        java.lang.object objZQdbubnVBeblvOnT = zQdbubnVBeblvOnT();
        int i = this.label;
        if (i == 0) {
            WMfJmtnawEjKfHRK(obj);
            kotlinx.coroutines.flow.Flow flowGWqiXbGCLJxHmjRY = gWqiXbGCLJxHmjRY(this.this$0);
            com.google.firebase.sessions.SessionDatastoreImpl$1$1 sessionDatastoreImpl$1$1 = new com.google.firebase.sessions.SessionDatastoreImpl$1$1(this.this$0);
            com.google.firebase.sessions.SessionDatastoreImpl$1 sessionDatastoreImpl$1 = this;
            this.label = 1;
            if (lpZxByorsviqMtJm(flowGWqiXbGCLJxHmjRY, sessionDatastoreImpl$1$1, sessionDatastoreImpl$1) == objZQdbubnVBeblvOnT) {
                return objZQdbubnVBeblvOnT;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            GtftkGjWCNxxwkoZ(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

