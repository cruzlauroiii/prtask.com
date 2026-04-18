namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/channels/ProducerScope;", "Lcom/google/firebase/remoteconfig/ConfigUpdate;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1", m533f = "RemoteConfig.kt", m534i = {}, m535l = {119}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RemoteConfigKt$configUpdates$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<com.google.firebase.remoteconfig.ConfigUpdate>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly com.google.firebase.remoteconfig.FirebaseRemoteConfig $this_configUpdates;
    private java.lang.object L$0;
    int label;

    RemoteConfigKt$configUpdates$1(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, kotlin.coroutines.Continuation<? super com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1> continuation) {
        super(2, continuation);
        this.$this_configUpdates = firebaseRemoteConfig;
    }

    public static java.lang.object LYNOCotppqFOwWvZ(kotlinx.coroutines.channels.ProducerScope producerScope, kotlin.jvm.functions.Function0 function0, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, function0, continuation);
    }

    public static java.lang.object OhpNkTyVcBnFdvRU(com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1 remoteConfigKt$configUpdates$1, kotlinx.coroutines.channels.ProducerScope producerScope, kotlin.coroutines.Continuation continuation) {
        return remoteConfigKt$configUpdates$1.invoke2((kotlinx.coroutines.channels.ProducerScope<com.google.firebase.remoteconfig.ConfigUpdate>) producerScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void BcmctcVMDKvjFcbe(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation HFgXhOKCOIXbTBSJ(com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1 remoteConfigKt$configUpdates$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return remoteConfigKt$configUpdates$1.create(obj, continuation);
    }

    public static com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration HztwPSzbpOliXgGN(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, com.google.firebase.remoteconfig.ConfigUpdateListener configUpdateListener) {
        return firebaseRemoteConfig.addOnConfigUpdateListener(configUpdateListener);
    }

    public static java.lang.object OvIACAGHNEgycRmm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void PjcCEolmMsDaMMXY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void PvDDavVWHIbUCEQm(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object YAuAWflfbxKOYuYx(com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1 remoteConfigKt$configUpdates$1, java.lang.object obj) {
        return remoteConfigKt$configUpdates$1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1 remoteConfigKt$configUpdates$1 = new com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1(this.$this_configUpdates, continuation);
        remoteConfigKt$configUpdates$1.L$0 = obj;
        return remoteConfigKt$configUpdates$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<com.google.firebase.remoteconfig.ConfigUpdate> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return OhpNkTyVcBnFdvRU(this, producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<com.google.firebase.remoteconfig.ConfigUpdate> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return yAuAWflfbxKOYuYx((com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1) hFgXhOKCOIXbTBSJ(this, producerScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 6) % 6 > 0) {
        }
        java.lang.object objOvIACAGHNEgycRmm = ovIACAGHNEgycRmm();
        int i = this.label;
        if (i == 0) {
            pvDDavVWHIbUCEQm(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration configUpdateListenerRegistrationHztwPSzbpOliXgGN = hztwPSzbpOliXgGN(this.$this_configUpdates, new com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1$registration$1(this.$this_configUpdates, producerScope));
            pjcCEolmMsDaMMXY(configUpdateListenerRegistrationHztwPSzbpOliXgGN, "FirebaseRemoteConfig.con…      }\n        }\n      )");
            com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1$1 remoteConfigKt$configUpdates$1$1 = new com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1$1(configUpdateListenerRegistrationHztwPSzbpOliXgGN);
            com.google.firebase.remoteconfig.ktx.RemoteConfigKt$configUpdates$1 remoteConfigKt$configUpdates$1 = this;
            this.label = 1;
            if (LYNOCotppqFOwWvZ(producerScope, remoteConfigKt$configUpdates$1$1, remoteConfigKt$configUpdates$1) == objOvIACAGHNEgycRmm) {
                return objOvIACAGHNEgycRmm;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            bcmctcVMDKvjFcbe(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

