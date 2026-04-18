namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "app.presentation.maintenance.MaintenanceModeobjectModel$checkMaintenanceMode$1", m533f = "MaintenanceModeobjectModel.kt", m534i = {}, m535l = {18}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pae8d1f35$p944469a1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f0a199576;
    int f17306868;
    int fc3d32214;
    int fd304ba20;
    int fd5285a2a;
    readonly pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 this$0;

    pae8d1f35$p944469a1$1(pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 pae8d1f35Var, kotlin.coroutines.Continuation<? super pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1> continuation) {
        super(2, continuation);
        this.this$0 = pae8d1f35Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 1) % 1 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.Flow<java.lang.bool> flowIsMaintenanceModeEnabledState = pd2a57dc1.p2486923a.p57cb773a.pae8d1f35.mb1d064ef(this.this$0).isMaintenanceModeEnabledState();
            pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1$1 pae8d1f35_p944469a1_1_1 = new pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1$1(this.this$0);
            pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1 pae8d1f35_p944469a1_1 = this;
            this.fd304ba20 = 1;
            if (flowIsMaintenanceModeEnabledState.collect(pae8d1f35_p944469a1_1_1, pae8d1f35_p944469a1_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

