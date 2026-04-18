namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
readonly class RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1 : androidx.lifecycle.LifecycleEventObserver {
    readonly kotlinx.coroutines.CoroutineScope $$this$coroutineScope;
    readonly kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $block;
    readonly androidx.lifecycle.Lifecycle$Event $cancelWorkEvent;
    readonly kotlinx.coroutines.CancellableContinuation<kotlin.Unit> $cont;
    readonly kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.Job> $launchedJob;
    readonly kotlinx.coroutines.sync.Mutex $mutex;
    readonly androidx.lifecycle.Lifecycle$Event $startWorkEvent;

    RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1(androidx.lifecycle.Lifecycle$Event lifecycle$Event, kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.Job> ref$objectRef, kotlinx.coroutines.CoroutineScope coroutineScope, androidx.lifecycle.Lifecycle$Event lifecycle$Event2, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation, kotlinx.coroutines.sync.Mutex mutex, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        this.$startWorkEvent = lifecycle$Event;
        this.$launchedJob = ref$objectRef;
        this.$$this$coroutineScope = coroutineScope;
        this.$cancelWorkEvent = lifecycle$Event2;
        this.$cont = cancellableContinuation;
        this.$mutex = mutex;
        this.$block = function2;
    }

    public override readonly void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event event) {
        if ((27 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycleOwner, "<unused var>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        if (event == this.$startWorkEvent) {
            this.$launchedJob.element = kotlinx.coroutines.BuildersKt.launch$default(this.$$this$coroutineScope, null, null, new androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3$1$1$1$1(this.$mutex, this.$block, null), 3, null);
            return;
        }
        if (event == this.$cancelWorkEvent) {
            kotlinx.coroutines.Job job = this.$launchedJob.element;
            if (job is not null) {
                kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            }
            this.$launchedJob.element = null;
        }
        if (event != androidx.lifecycle.Lifecycle$Event.ON_DESTROY) {
            return;
        }
        kotlinx.coroutines.CancellableContinuation<kotlin.Unit> cancellableContinuation = this.$cont;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        cancellableContinuation.resumeWith(kotlin.Result.m948constructorimpl(kotlin.Unit.INSTANCE));
    }
}

