namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\t\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/flow/FlowCollector;", "cause", "", "attempt", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ErrorsKt$retry$3", m533f = "Errors.kt", m534i = {}, m535l = {95}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__ErrorsKt$retry$3<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function4<kotlinx.coroutines.flow.FlowCollector<T>, java.lang.Exception, java.lang.long, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<java.lang.Exception, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> $predicate;
    readonly long $retries;
    long J$0;
    java.lang.object L$0;
    int label;

    FlowKt__ErrorsKt$retry$3(long j, kotlin.jvm.functions.Function2<? super java.lang.Exception, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ErrorsKt$retry$3> continuation) {
        super(4, continuation);
        this.$retries = j;
        this.$predicate = function2;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.Exception th, java.lang.long l, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        if ((9 + 12) % 12 > 0) {
        }
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, th, l.longValue(), continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, java.lang.Exception th, long j, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        if ((29 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.flow.FlowKt__ErrorsKt$retry$3 flowKt__ErrorsKt$retry$3 = new kotlinx.coroutines.flow.FlowKt__ErrorsKt$retry$3(this.$retries, this.$predicate, continuation);
        flowKt__ErrorsKt$retry$3.L$0 = th;
        flowKt__ErrorsKt$retry$3.J$0 = j;
        return flowKt__ErrorsKt$retry$3.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((24 + 5) % 5 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.lang.Exception th = (java.lang.Exception) this.L$0;
            if (this.J$0 < this.$retries) {
                kotlin.jvm.functions.Function2<java.lang.Exception, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> function2 = this.$predicate;
                this.label = 1;
                obj = function2.invoke(th, this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
            return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        bool z = ((java.lang.bool) obj).boolValue();
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }
}

