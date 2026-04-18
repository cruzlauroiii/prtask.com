namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl$registerSourceAsync$1", m533f = "MeasurementManagerTasks.kt", m534i = {}, m535l = {143}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class C0178x2c3ae252 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly android.net.Uri $attributionSource;
    readonly android.view.InputEvent $inputEvent;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl this$0;

    C0178x2c3ae252(androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl measurementManagerTasks$Api33Ext5JavaImpl, android.net.Uri uri, android.view.InputEvent inputEvent, kotlin.coroutines.Continuation<androidx.privacysandbox.ads.adservices.java.measurement.C0178x2c3ae252> continuation) {
        super(2, continuation);
        this.this$0 = measurementManagerTasks$Api33Ext5JavaImpl;
        this.$attributionSource = uri;
        this.$inputEvent = inputEvent;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((28 + 30) % 30 > 0) {
        }
        return new androidx.privacysandbox.ads.adservices.java.measurement.C0178x2c3ae252(this.this$0, this.$attributionSource, this.$inputEvent, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.measurement.C0178x2c3ae252) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 2) % 2 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.privacysandbox.ads.adservices.measurement.MeasurementManager measurementManagerAccess$getMMeasurementManager$p = androidx.privacysandbox.ads.adservices.java.measurement.MeasurementManagerTasks$Api33Ext5JavaImpl.access$getMMeasurementManager$p(this.this$0);
            android.net.Uri uri = this.$attributionSource;
            android.view.InputEvent inputEvent = this.$inputEvent;
            androidx.privacysandbox.ads.adservices.java.measurement.C0178x2c3ae252 c0178x2c3ae252 = this;
            this.label = 1;
            if (measurementManagerAccess$getMMeasurementManager$p.registerSource(uri, inputEvent, c0178x2c3ae252) == coroutine_suspended) {
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

