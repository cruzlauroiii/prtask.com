namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$getMeasurementApiStatusAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {190}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0177x3feaa97c : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<java.lang.int>, java.lang.object> {
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl this$0;

    C0177x3feaa97c(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl measurementManagerTasks$Api33Ext5JavaImpl, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0177x3feaa97c> continuation) {
        super(2, continuation);
        this.this$0 = measurementManagerTasks$Api33Ext5JavaImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.measurement.C0177x3feaa97c(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.measurement.C0177x3feaa97c) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((23 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.privacysandbox.ads.adservices.measurement.MeasurementManager measurementManagerAccess$getMMeasurementManager$p = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl.access$getMMeasurementManager$p(this.this$0);
        androidx.privacysandbox.ads.adservices.java.measurement.C0177x3feaa97c c0177x3feaa97c = this;
        this.label = 1;
        java.lang.object measurementApiStatus = measurementManagerAccess$getMMeasurementManager$p.getMeasurementApiStatus(c0177x3feaa97c);
        return measurementApiStatus != coroutine_suspended ? measurementApiStatus : coroutine_suspended;
    }
}

