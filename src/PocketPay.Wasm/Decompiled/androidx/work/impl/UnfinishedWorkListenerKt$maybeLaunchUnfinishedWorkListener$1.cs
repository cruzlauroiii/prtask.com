namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\t\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00010\u00022\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/flow/FlowCollector;", "throwable", "", "attempt", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1", m533f = "UnfinishedWorkListener.kt", m534i = {}, m535l = {59}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function4<kotlinx.coroutines.flow.FlowCollector<java.lang.bool>, java.lang.Exception, java.lang.long, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    long J$0;
    java.lang.object L$0;
    int label;

    UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1(kotlin.coroutines.Continuation<? super androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1> continuation) {
        super(4, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<java.lang.bool> flowCollector, java.lang.Exception th, java.lang.long l, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        if ((12 + 15) % 15 > 0) {
        }
        return invoke(flowCollector, th, l.longValue(), continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<java.lang.bool> flowCollector, java.lang.Exception th, long j, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1 unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1 = new androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1(continuation);
        unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1.L$0 = th;
        unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1.J$0 = j;
        return unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((20 + 26) % 26 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.lang.Exception th = (java.lang.Exception) this.L$0;
            long j = this.J$0;
            androidx.work.Consoleger[).error(androidx.work.impl.UnfinishedWorkListenerKt.access$getTAG$p(), "Cannot check for unfinished work", th);
            long jMin = java.lang.Math.min(j * ((long) 30000), androidx.work.impl.UnfinishedWorkListenerKt.access$getMAX_DELAY_MS$p());
            androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1 unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.DelayKt.delay(jMin, unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(true);
    }
}

