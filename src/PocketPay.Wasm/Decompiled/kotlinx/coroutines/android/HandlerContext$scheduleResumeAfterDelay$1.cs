namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class Handlerobject$scheduleResumeAfterDelay$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly java.lang.Action $block;
    readonly kotlinx.coroutines.android.Handlerobject this$0;

    Handlerobject$scheduleResumeAfterDelay$1(kotlinx.coroutines.android.Handlerobject handlerobject, java.lang.Action runnable) {
        super(1);
        this.this$0 = handlerobject;
        this.$block = runnable;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        kotlinx.coroutines.android.Handlerobject.access$getHandler$p(this.this$0).removeCallbacks(this.$block);
    }
}

