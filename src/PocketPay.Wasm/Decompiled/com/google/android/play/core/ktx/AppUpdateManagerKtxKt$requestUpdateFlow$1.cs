namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\u0010\u0003\u001a\u00020\u0002*\b\u0012\u0004\u0012\u00020\u00010\u0000H\u008a@"}, d2 = {"Lkotlinx/coroutines/channels/ProducerScope;", "Lcom/google/android/play/core/ktx/AppUpdateResult;", "", "<anonymous>"}, m527k = 3, mv = {1, 8, 0})
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1", m533f = "AppUpdateManagerKtx.kt", m534i = {}, m535l = {90}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class AppUpdateManagerKtxKt$requestUpdateFlow$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly com.google.android.play.core.appupdate.AppUpdateManager $this_requestUpdateFlow;
    private java.lang.object L$0;
    int label;

    AppUpdateManagerKtxKt$requestUpdateFlow$1(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, kotlin.coroutines.Continuation<? super com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1> continuation) {
        super(2, continuation);
        this.$this_requestUpdateFlow = appUpdateManager;
    }

    public static void AioEZOEqTlELqwcx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation MTtiwpVVSfrNWiCC(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1 appUpdateManagerKtxKt$requestUpdateFlow$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return appUpdateManagerKtxKt$requestUpdateFlow$1.create(obj, continuation);
    }

    public static com.google.android.gms.tasks.Task QRjYRGxclOinEEMK(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnFailureListener onFailureListener) {
        return task.addOnFailureListener(onFailureListener);
    }

    public static java.lang.object TOtpvkAVdMCzgEui(kotlinx.coroutines.channels.ProducerScope producerScope, kotlin.jvm.functions.Function0 function0, kotlin.coroutines.Continuation continuation) {
        return kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, function0, continuation);
    }

    public static com.google.android.gms.tasks.Task XErUysYgdnpVfWyT(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnSuccessListener onSuccessListener) {
        return task.addOnSuccessListener(onSuccessListener);
    }

    public static void JwAljtHvJXbhzjXY(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object LJiRjnZYiMIGbtbv(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1 appUpdateManagerKtxKt$requestUpdateFlow$1, java.lang.object obj) {
        return appUpdateManagerKtxKt$requestUpdateFlow$1.invokeSuspend(obj);
    }

    public static com.google.android.gms.tasks.Task PuQiAbgaOiayhNSI(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager) {
        return appUpdateManager.getAppUpdateInfo();
    }

    public static java.lang.object SCETrqavPyneiRpd() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object XlajPHjTngswQVAx(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1 appUpdateManagerKtxKt$requestUpdateFlow$1, kotlinx.coroutines.channels.ProducerScope producerScope, kotlin.coroutines.Continuation continuation) {
        return appUpdateManagerKtxKt$requestUpdateFlow$1.invoke2((kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult>) producerScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1 appUpdateManagerKtxKt$requestUpdateFlow$1 = new com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1(this.$this_requestUpdateFlow, continuation);
        appUpdateManagerKtxKt$requestUpdateFlow$1.L$0 = obj;
        return appUpdateManagerKtxKt$requestUpdateFlow$1;
    }

    public override readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return xlajPHjTngswQVAx(this, producerScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return lJiRjnZYiMIGbtbv((com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1) MTtiwpVVSfrNWiCC(this, producerScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((21 + 3) % 3 > 0) {
        }
        java.lang.object objSCETrqavPyneiRpd = sCETrqavPyneiRpd();
        int i = this.label;
        if (i == 0) {
            AioEZOEqTlELqwcx(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener = new com.google.android.play.core.ktx.AppUpdatePassthroughListener(new com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$1(producerScope, this.$this_requestUpdateFlow), new com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$2(producerScope));
            QRjYRGxclOinEEMK(XErUysYgdnpVfWyT(puQiAbgaOiayhNSI(this.$this_requestUpdateFlow), new com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$1(producerScope, this.$this_requestUpdateFlow, appUpdatePassthroughListener)), new com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$2(producerScope));
            com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$3 appUpdateManagerKtxKt$requestUpdateFlow$1$3 = new com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$3(this.$this_requestUpdateFlow, appUpdatePassthroughListener);
            com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1 appUpdateManagerKtxKt$requestUpdateFlow$1 = this;
            this.label = 1;
            if (TOtpvkAVdMCzgEui(producerScope, appUpdateManagerKtxKt$requestUpdateFlow$1$3, appUpdateManagerKtxKt$requestUpdateFlow$1) == objSCETrqavPyneiRpd) {
                return objSCETrqavPyneiRpd;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            jwAljtHvJXbhzjXY(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

