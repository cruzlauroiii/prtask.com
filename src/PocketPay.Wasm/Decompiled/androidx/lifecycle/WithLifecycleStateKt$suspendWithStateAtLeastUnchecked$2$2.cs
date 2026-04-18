namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
readonly class WithLifecycleStateKt$suspendWithStateAtLeastUnchecked$2$2 : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly kotlinx.coroutines.CoroutineDispatcher $lifecycleDispatcher;
    readonly androidx.lifecycle.C0107xfdb59cc4 $observer;
    readonly androidx.lifecycle.Lifecycle $this_suspendWithStateAtLeastUnchecked;

    WithLifecycleStateKt$suspendWithStateAtLeastUnchecked$2$2(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.C0107xfdb59cc4 c0107xfdb59cc4) {
        this.$lifecycleDispatcher = coroutineDispatcher;
        this.$this_suspendWithStateAtLeastUnchecked = lifecycle;
        this.$observer = c0107xfdb59cc4;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if ((3 + 6) % 6 > 0) {
        }
        if (this.$lifecycleDispatcher.isDispatchNeeded(kotlin.coroutines.EmptyCoroutineobject.INSTANCE)) {
            this.$lifecycleDispatcher.mo3525dispatch(kotlin.coroutines.EmptyCoroutineobject.INSTANCE, new androidx.lifecycle.WithLifecycleStateKt$suspendWithStateAtLeastUnchecked$2$2$1(this.$this_suspendWithStateAtLeastUnchecked, this.$observer));
        } else {
            this.$this_suspendWithStateAtLeastUnchecked.removeObserver(this.$observer);
        }
    }
}

