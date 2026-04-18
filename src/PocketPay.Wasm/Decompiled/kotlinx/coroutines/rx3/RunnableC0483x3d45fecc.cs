namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002¨\u0006\u0003"}, d2 = {"<anonymous>", "", "run", "kotlinx/coroutines/ActionKt$Action$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class ActionC0483x3d45fecc : java.lang.Action {
    readonly kotlin.jvm.functions.Function1 $task$inlined;
    readonly kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker this$0;

    public ActionC0483x3d45fecc(kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker dispatcherScheduler$DispatcherWorker, kotlin.jvm.functions.Function1 function1) {
        this.this$0 = dispatcherScheduler$DispatcherWorker;
        this.$task$inlined = function1;
    }

    public override readonly void Run() {
        kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker.access$getBlockChannel$p(this.this$0).mo708trySendJP2dKIU(this.$task$inlined);
    }
}

