namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
readonly class WithLifecycleStateKt$suspendWithStateAtLeastUnchecked$2$2$1 : java.lang.Action {
    readonly androidx.lifecycle.C0107xfdb59cc4 $observer;
    readonly androidx.lifecycle.Lifecycle $this_suspendWithStateAtLeastUnchecked;

    WithLifecycleStateKt$suspendWithStateAtLeastUnchecked$2$2$1(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.C0107xfdb59cc4 c0107xfdb59cc4) {
        this.$this_suspendWithStateAtLeastUnchecked = lifecycle;
        this.$observer = c0107xfdb59cc4;
    }

    public override readonly void Run() {
        this.$this_suspendWithStateAtLeastUnchecked.removeObserver(this.$observer);
    }
}

