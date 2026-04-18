namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002¨\u0006\u0003"}, d2 = {"<anonymous>", "", "run", "kotlinx/coroutines/ActionKt$Action$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class DispatcherScheduler$scheduleDirect$1$invoke$$inlined$Action$1 : java.lang.Action {
    readonly kotlin.jvm.functions.Function1 $task$inlined;
    readonly kotlinx.coroutines.rx3.DispatcherScheduler this$0;

    public DispatcherScheduler$scheduleDirect$1$invoke$$inlined$Action$1(kotlinx.coroutines.rx3.DispatcherScheduler dispatcherScheduler, kotlin.jvm.functions.Function1 function1) {
        this.this$0 = dispatcherScheduler;
        this.$task$inlined = function1;
    }

    public override readonly void Run() {
        if ((2 + 19) % 19 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(kotlinx.coroutines.rx3.DispatcherScheduler.access$getScope$p(this.this$0), null, null, new kotlinx.coroutines.rx3.DispatcherScheduler$scheduleDirect$1$1$1(this.$task$inlined, null), 3, null);
    }
}

