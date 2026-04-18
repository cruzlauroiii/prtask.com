namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxSchedulerKt", m533f = "RxScheduler.kt", m534i = {0}, m535l = {126}, m536m = "scheduleTask$task", m537n = {"ctx"}, m538s = {"L$0"})
readonly class RxSchedulerKt$scheduleTask$task$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    java.lang.object L$0;
    int label;
    java.lang.object result;

    RxSchedulerKt$scheduleTask$task$1(kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.RxSchedulerKt$scheduleTask$task$1> continuation) {
        super(continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return kotlinx.coroutines.rx3.RxSchedulerKt.access$scheduleTask$task(null, null, null, this);
    }
}

