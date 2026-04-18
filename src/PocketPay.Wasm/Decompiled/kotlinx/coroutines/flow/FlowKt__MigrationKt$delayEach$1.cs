namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__MigrationKt$delayEach$1", m533f = "Migration.kt", m534i = {}, m535l = {427}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__MigrationKt$delayEach$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly long $timeMillis;
    int label;

    FlowKt__MigrationKt$delayEach$1(long j, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__MigrationKt$delayEach$1> continuation) {
        super(2, continuation);
        this.$timeMillis = j;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((7 + 1) % 1 > 0) {
        }
        return new kotlinx.coroutines.flow.FlowKt__MigrationKt$delayEach$1(this.$timeMillis, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(obj, continuation);
    }

    public readonly java.lang.object Invoke2(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.FlowKt__MigrationKt$delayEach$1) create(t, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            long j = this.$timeMillis;
            kotlinx.coroutines.flow.FlowKt__MigrationKt$delayEach$1<T> flowKt__MigrationKt$delayEach$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.DelayKt.delay(j, flowKt__MigrationKt$delayEach$1) == coroutine_suspended) {
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

