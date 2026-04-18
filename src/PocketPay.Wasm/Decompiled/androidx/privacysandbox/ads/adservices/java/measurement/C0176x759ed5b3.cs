namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$deleteRegistrationsAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {132}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0176x759ed5b3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.measurement.DeletionRequest $deletionRequest;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl this$0;

    C0176x759ed5b3(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl measurementManagerTasks$Api33Ext5JavaImpl, androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0176x759ed5b3> continuation) {
        super(2, continuation);
        this.this$0 = measurementManagerTasks$Api33Ext5JavaImpl;
        this.$deletionRequest = deletionRequest;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.measurement.C0176x759ed5b3(this.this$0, this.$deletionRequest, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.measurement.C0176x759ed5b3) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager measurementManagerAccess$getMMeasurementManager$p = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl.access$getMMeasurementManager$p(this.this$0);
            androidx.privacysandbox.ads.adservices.measurement.DeletionRequest deletionRequest = this.$deletionRequest;
            androidx.privacysandbox.ads.adservices.java.measurement.C0176x759ed5b3 c0176x759ed5b3 = this;
            this.label = 1;
            if (measurementManagerAccess$getMMeasurementManager$p.deleteRegistrations(deletionRequest, c0176x759ed5b3) == coroutine_suspended) {
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

