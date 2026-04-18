namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/flow/FlowCollector;", "e", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__MigrationKt$onErrorReturn$2", m533f = "Migration.kt", m534i = {}, m535l = {306}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__MigrationKt$onErrorReturn$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<T>, java.lang.Exception, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly T $fallback;
    readonly kotlin.jvm.functions.Function1<java.lang.Exception, java.lang.bool> $predicate;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    FlowKt__MigrationKt$onErrorReturn$2(kotlin.jvm.functions.Function1<? super java.lang.Exception, java.lang.bool> function1, T t, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__MigrationKt$onErrorReturn$2> continuation) {
        super(3, continuation);
        this.$predicate = function1;
        this.$fallback = t;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, th, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, java.lang.Exception th, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((3 + 23) % 23 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__MigrationKt$onErrorReturn$2 flowKt__MigrationKt$onErrorReturn$2 = new kotlinx.coroutines.flow.FlowKt__MigrationKt$onErrorReturn$2(this.$predicate, this.$fallback, continuation);
        flowKt__MigrationKt$onErrorReturn$2.L$0 = flowCollector;
        flowKt__MigrationKt$onErrorReturn$2.L$1 = th;
        return flowKt__MigrationKt$onErrorReturn$2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((11 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            java.lang.Exception th = (java.lang.Exception) this.L$1;
            if (!this.$predicate.invoke(th).boolValue()) {
                throw th;
            }
            T t = this.$fallback;
            kotlinx.coroutines.flow.FlowKt__MigrationKt$onErrorReturn$2<T> flowKt__MigrationKt$onErrorReturn$2 = this;
            this.L$0 = null;
            this.label = 1;
            if (flowCollector.emit(t, flowKt__MigrationKt$onErrorReturn$2) == coroutine_suspended) {
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

