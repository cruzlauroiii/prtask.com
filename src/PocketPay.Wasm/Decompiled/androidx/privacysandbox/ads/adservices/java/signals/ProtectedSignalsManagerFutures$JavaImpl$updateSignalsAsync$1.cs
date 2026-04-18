namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1", m533f = "ProtectedSignalsManagerTasks.kt", m534i = {}, m535l = {111}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest $request;
    int label;
    readonly androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl this$0;

    ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1(androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl protectedSignalsManagerTasks$JavaImpl, androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest updateSignalsRequest, kotlin.coroutines.Continuation<? super androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1> continuation) {
        super(2, continuation);
        this.this$0 = protectedSignalsManagerTasks$JavaImpl;
        this.$request = updateSignalsRequest;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1(this.this$0, this.$request, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.privacysandbox.ads.adservices.signals.ProtectedSignalsManager protectedSignalsManagerAccess$getMProtectedSignalsManager$p = androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl.access$getMProtectedSignalsManager$p(this.this$0);
            kotlin.jvm.internal.Intrinsics.checkNotNull(protectedSignalsManagerAccess$getMProtectedSignalsManager$p);
            androidx.privacysandbox.ads.adservices.signals.UpdateSignalsRequest updateSignalsRequest = this.$request;
            androidx.privacysandbox.ads.adservices.java.signals.ProtectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1 protectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1 = this;
            this.label = 1;
            if (protectedSignalsManagerAccess$getMProtectedSignalsManager$p.updateSignals(updateSignalsRequest, protectedSignalsManagerTasks$JavaImpl$updateSignalsAsync$1) == coroutine_suspended) {
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

