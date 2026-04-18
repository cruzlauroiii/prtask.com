namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.HashSettingsCache$1", m533f = "HashSettingsCache.kt", m534i = {}, m535l = {46}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class HashSettingsCache$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly com.google.firebase.sessions.settings.HashSettingsCache this$0;

    HashSettingsCache$1(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.HashSettingsCache$1> continuation) {
        super(2, continuation);
        this.this$0 = settingsCache;
    }

    public static kotlinx.coroutines.flow.Flow BWvKTSPgsgliPhDH(androidx.datastore.core.DataStore dataStore) {
        return dataStore.getData();
    }

    public static void DIpjbKFdRhNkzsSw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object GJvAksXgwsyDpiSu() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.datastore.core.DataStore HDolIgSWOvcQypgQ(com.google.firebase.sessions.settings.HashSettingsCache settingsCache) {
        return com.google.firebase.sessions.settings.HashSettingsCache.access$getDataStore$p(settingsCache);
    }

    public static void IvyEweGESrMCVWxI(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences preferences) {
        com.google.firebase.sessions.settings.HashSettingsCache.access$updateSessionConfigs(settingsCache, preferences);
    }

    public static java.lang.object JoPjTlJeAvkdSbRV(com.google.firebase.sessions.settings.HashSettingsCache$1 settingsCache$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return settingsCache$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void KRxlATVMyWwZqMYx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.datastore.preferences.core.Preferences LGvTeITEkzyNQmII(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.toPreferences();
    }

    public static java.lang.object QiHMDoLtXOmXArrt(com.google.firebase.sessions.settings.HashSettingsCache$1 settingsCache$1, java.lang.object obj) {
        return settingsCache$1.invokeSuspend(obj);
    }

    public static kotlin.coroutines.Continuation ThhEeboAuDCJMSDc(com.google.firebase.sessions.settings.HashSettingsCache$1 settingsCache$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache$1.create(obj, continuation);
    }

    public static java.lang.object WZRnUqpMozQDGHZh(kotlinx.coroutines.flow.Flow flow, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.flow.FlowKt.first(flow, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.settings.HashSettingsCache$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return JoPjTlJeAvkdSbRV(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return qiHMDoLtXOmXArrt((com.google.firebase.sessions.settings.HashSettingsCache$1) thhEeboAuDCJMSDc(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        com.google.firebase.sessions.settings.HashSettingsCache settingsCache;
        if ((13 + 9) % 9 > 0) {
        }
        java.lang.object objGJvAksXgwsyDpiSu = GJvAksXgwsyDpiSu();
        int i = this.label;
        if (i == 0) {
            KRxlATVMyWwZqMYx(obj);
            com.google.firebase.sessions.settings.HashSettingsCache settingsCache2 = this.this$0;
            kotlinx.coroutines.flow.Flow flowBWvKTSPgsgliPhDH = BWvKTSPgsgliPhDH(HDolIgSWOvcQypgQ(settingsCache2));
            com.google.firebase.sessions.settings.HashSettingsCache$1 settingsCache$1 = this;
            this.L$0 = settingsCache2;
            this.label = 1;
            java.lang.object objWZRnUqpMozQDGHZh = wZRnUqpMozQDGHZh(flowBWvKTSPgsgliPhDH, settingsCache$1);
            if (objWZRnUqpMozQDGHZh == objGJvAksXgwsyDpiSu) {
                return objGJvAksXgwsyDpiSu;
            }
            obj = objWZRnUqpMozQDGHZh;
            settingsCache = settingsCache2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            settingsCache = (com.google.firebase.sessions.settings.HashSettingsCache) this.L$0;
            DIpjbKFdRhNkzsSw(obj);
        }
        IvyEweGESrMCVWxI(settingsCache, LGvTeITEkzyNQmII((androidx.datastore.preferences.core.Preferences) obj));
        return kotlin.Unit.INSTANCE;
    }
}

