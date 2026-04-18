namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1", m533f = "RemoteHashSettings.kt", m534i = {}, m535l = {151}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RemoteHashSettings$clearCachedHashSettings$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int label;
    readonly com.google.firebase.sessions.settings.RemoteHashSettings this$0;

    RemoteHashSettings$clearCachedHashSettings$1(com.google.firebase.sessions.settings.RemoteHashSettings remoteHashSettings, kotlin.coroutines.Continuation<? super com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1> continuation) {
        super(2, continuation);
        this.this$0 = remoteHashSettings;
    }

    public static java.lang.object AqJJykSLhNkwnKGW(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, kotlin.coroutines.Continuation continuation) {
        return settingsCache.removeConfigs$com_google_firebase_firebase_sessions(continuation);
    }

    public static java.lang.object DAfKvrQfKrquTzzj() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object GrBEMpzZiYItxcFr(com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1 remoteHashSettings$clearCachedHashSettings$1, java.lang.object obj) {
        return remoteHashSettings$clearCachedHashSettings$1.invokeSuspend(obj);
    }

    public static com.google.firebase.sessions.settings.HashSettingsCache LmGjvYSLLgogKeWm(com.google.firebase.sessions.settings.RemoteHashSettings remoteHashSettings) {
        return com.google.firebase.sessions.settings.RemoteHashSettings.access$getHashSettingsCache(remoteHashSettings);
    }

    public static void RqorjaVxveMOZQHD(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object SxfCYxuqwnGqFaAi(com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1 remoteHashSettings$clearCachedHashSettings$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettings$clearCachedHashSettings$1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void XMpMUwFYzvfkytKD(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation XOpFiYdTQycnFAag(com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1 remoteHashSettings$clearCachedHashSettings$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return remoteHashSettings$clearCachedHashSettings$1.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return SxfCYxuqwnGqFaAi(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return GrBEMpzZiYItxcFr((com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1) xOpFiYdTQycnFAag(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 9) % 9 > 0) {
        }
        java.lang.object objDAfKvrQfKrquTzzj = DAfKvrQfKrquTzzj();
        int i = this.label;
        if (i == 0) {
            RqorjaVxveMOZQHD(obj);
            com.google.firebase.sessions.settings.HashSettingsCache settingsCacheLmGjvYSLLgogKeWm = LmGjvYSLLgogKeWm(this.this$0);
            com.google.firebase.sessions.settings.RemoteHashSettings$clearCachedHashSettings$1 remoteHashSettings$clearCachedHashSettings$1 = this;
            this.label = 1;
            if (AqJJykSLhNkwnKGW(settingsCacheLmGjvYSLLgogKeWm, remoteHashSettings$clearCachedHashSettings$1) == objDAfKvrQfKrquTzzj) {
                return objDAfKvrQfKrquTzzj;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            xMpMUwFYzvfkytKD(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

