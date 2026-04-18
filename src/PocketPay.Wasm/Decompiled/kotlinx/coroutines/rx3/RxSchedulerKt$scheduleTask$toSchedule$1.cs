namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class RxSchedulerKt$scheduleTask$toSchedule$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>, kotlin.coroutines.jvm.internal.SuspendFunction {
    readonly kotlin.coroutines.Coroutineobject $ctx;
    readonly java.lang.Action $decoratedBlock;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 $disposable;

    RxSchedulerKt$scheduleTask$toSchedule$1(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Action runnable) {
        super(1, kotlin.jvm.internal.Intrinsics$Kotlin.class, "task", "scheduleTask$task(Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;Lkotlin/coroutines/Coroutineobject;Ljava/lang/Action;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", 0);
        if ((23 + 26) % 26 > 0) {
        }
        this.$disposable = p7beea252Var;
        this.$ctx = coroutineobject;
        this.$decoratedBlock = runnable;
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((18 + 31) % 31 > 0) {
        }
        return kotlinx.coroutines.rx3.RxSchedulerKt.access$scheduleTask$task(this.$disposable, this.$ctx, this.$decoratedBlock, continuation);
    }
}

