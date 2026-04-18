namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"androidx/lifecycle/WithLifecycleStateKt$suspendWithStateAtLeastUnchecked$2$observer$1", "Landroidx/lifecycle/LifecycleEventObserver;", "onStateChanged", "", "source", "Landroidx/lifecycle/LifecycleOwner;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "lifecycle-runtime_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class C0107xfdb59cc4 : androidx.lifecycle.LifecycleEventObserver {
    readonly kotlin.jvm.functions.Function0<R> $block;
    readonly kotlinx.coroutines.CancellableContinuation<R> $co;
    readonly androidx.lifecycle.Lifecycle$State $state;
    readonly androidx.lifecycle.Lifecycle $this_suspendWithStateAtLeastUnchecked;

    C0107xfdb59cc4(androidx.lifecycle.Lifecycle$State lifecycle$State, androidx.lifecycle.Lifecycle lifecycle, kotlinx.coroutines.CancellableContinuation<R> cancellableContinuation, kotlin.jvm.functions.Function0<? : R> function0) {
        this.$state = lifecycle$State;
        this.$this_suspendWithStateAtLeastUnchecked = lifecycle;
        this.$co = cancellableContinuation;
        this.$block = function0;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner source, androidx.lifecycle.Lifecycle$Event event) {
        java.lang.object objM948constructorimpl;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        if (event != androidx.lifecycle.Lifecycle$Event.Companion.upTo(this.$state)) {
            if (event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
                return;
            }
            this.$this_suspendWithStateAtLeastUnchecked.removeObserver(this);
            kotlin.coroutines.Continuation continuation = this.$co;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            continuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(new androidx.lifecycle.LifecycleDestroyedException())));
            return;
        }
        this.$this_suspendWithStateAtLeastUnchecked.removeObserver(this);
        kotlin.coroutines.Continuation continuation2 = this.$co;
        kotlin.jvm.functions.Function0<R> function0 = this.$block;
        try {
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(function0.invoke());
        } catch (java.lang.Exception th) {
            kotlin.Result$Companion result$Companion3 = kotlin.Result.Companion;
            objM948constructorimpl = kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th));
        }
        continuation2.resumeWith(objM948constructorimpl);
    }
}

