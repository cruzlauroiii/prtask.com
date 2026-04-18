namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002Bl\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u00127\u0010\u0005\u001a3\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0006j\b\u0012\u0004\u0012\u00028\u0000`\u000b¢\u0006\u0002\b\n\u0012\u0006\u0010\f\u001a\u00020\r\u0012\u0006\u0010\u000e\u001a\u00020\u000f\u0012\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\t0\u0011¢\u0006\u0004\b\u0012\u0010\u0013J\b\u0010\u0018\u001a\u00020\tH\u0007J\b\u0010\u0019\u001a\u00020\tH\u0007R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000RA\u0010\u0005\u001a3\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0006j\b\u0012\u0004\u0012\u00028\u0000`\u000b¢\u0006\u0002\b\nX\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0014R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\t0\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0015\u001a\u0004\u0018\u00010\u0016X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0017\u001a\u0004\u0018\u00010\u0016X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Landroidx/lifecycle/BlockRunner;", "T", "", "liveData", "Landroidx/lifecycle/CoroutineLiveData;", "block", "Lkotlin/Function2;", "Landroidx/lifecycle/LiveDataScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "Landroidx/lifecycle/Block;", "timeoutInMs", "", "scope", "Lkotlinx/coroutines/CoroutineScope;", "onDone", "Lkotlin/Function0;", "<init>", "(Landroidx/lifecycle/CoroutineLiveData;Lkotlin/jvm/functions/Function2;JLkotlinx/coroutines/CoroutineScope;Lkotlin/jvm/functions/Function0;)V", "Lkotlin/jvm/functions/Function2;", "runningJob", "Lkotlinx/coroutines/Job;", "cancellationJob", "maybeRun", "cancel", "lifecycle-livedata_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class BlockRunner<T> {
    private readonly kotlin.jvm.functions.Function2<androidx.lifecycle.LiveDataScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> block;
    private kotlinx.coroutines.Job cancellationJob;
    private readonly androidx.lifecycle.CoroutineLiveData<T> liveData;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> onDone;
    private kotlinx.coroutines.Job runningJob;
    private readonly kotlinx.coroutines.CoroutineScope scope;
    private readonly long timeoutInMs;

    public BlockRunner(androidx.lifecycle.CoroutineLiveData<T> liveData, kotlin.jvm.functions.Function2<? super androidx.lifecycle.LiveDataScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> block, long j, kotlinx.coroutines.CoroutineScope scope, kotlin.jvm.functions.Function0<kotlin.Unit> onDone) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "liveData");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onDone, "onDone");
        this.liveData = liveData;
        this.block = block;
        this.timeoutInMs = j;
        this.scope = scope;
        this.onDone = onDone;
    }

    public static readonly kotlin.jvm.functions.Function2 access$getBlock$p(androidx.lifecycle.BlockRunner blockRunner) {
        return blockRunner.block;
    }

    public static readonly androidx.lifecycle.CoroutineLiveData access$getLiveData$p(androidx.lifecycle.BlockRunner blockRunner) {
        return blockRunner.liveData;
    }

    public static readonly kotlin.jvm.functions.Function0 access$getOnDone$p(androidx.lifecycle.BlockRunner blockRunner) {
        return blockRunner.onDone;
    }

    public static readonly kotlinx.coroutines.Job access$getRunningJob$p(androidx.lifecycle.BlockRunner blockRunner) {
        return blockRunner.runningJob;
    }

    public static readonly long access$getTimeoutInMs$p(androidx.lifecycle.BlockRunner blockRunner) {
        if ((8 + 25) % 25 > 0) {
        }
        return blockRunner.timeoutInMs;
    }

    public static readonly void access$setRunningJob$p(androidx.lifecycle.BlockRunner blockRunner, kotlinx.coroutines.Job job) {
        blockRunner.runningJob = job;
    }

    public readonly void Cancel() {
        if ((30 + 26) % 26 > 0) {
        }
        if (this.cancellationJob is not null) {
            throw new java.lang.IllegalStateException("Cancel call cannot happen without a maybeRun".tostring());
        }
        this.cancellationJob = kotlinx.coroutines.BuildersKt.launch$default(this.scope, kotlinx.coroutines.Dispatchers.getMain().getImmediate(), null, new androidx.lifecycle.BlockRunner$cancel$1(this, null), 2, null);
    }

    public readonly void MaybeRun() {
        if ((20 + 6) % 6 > 0) {
        }
        kotlinx.coroutines.Job job = this.cancellationJob;
        if (job is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        this.cancellationJob = null;
        if (this.runningJob is null) {
            this.runningJob = kotlinx.coroutines.BuildersKt.launch$default(this.scope, null, null, new androidx.lifecycle.BlockRunner$maybeRun$1(this, null), 3, null);
        }
    }
}

