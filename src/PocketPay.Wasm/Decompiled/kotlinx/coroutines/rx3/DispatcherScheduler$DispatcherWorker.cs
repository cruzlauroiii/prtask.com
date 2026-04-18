namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000f\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\b\u0010\u0013\u001a\u00020\rH\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016J$\u0010\u0016\u001a\u00020\u00172\n\u0010\u0018\u001a\u00060\u0019j\u0002`\u001a2\u0006\u0010\u001b\u001a\u00020\u00032\u0006\u0010\u001c\u001a\u00020\u001dH\u0016J\b\u0010\u001e\u001a\u00020\u001fH\u0016R-\u0010\t\u001a\u001e\u0012\u001a\u0012\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\u000b0\nX\u0082\u0004ø\u0001\u0000¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006 "}, d2 = {"Lkotlinx/coroutines/rx3/DispatcherScheduler$DispatcherWorker;", "Lio/reactivex/rxjava3/core/Scheduler$Worker;", "counter", "", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "parentJob", "Lkotlinx/coroutines/Job;", "(JLkotlinx/coroutines/CoroutineDispatcher;Lkotlinx/coroutines/Job;)V", "blockChannel", "Lkotlinx/coroutines/channels/Channel;", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "", "", "workerJob", "Lkotlinx/coroutines/CompletableJob;", "workerScope", "Lkotlinx/coroutines/CoroutineScope;", "dispose", "isDisposed", "", "schedule", "Lpf98ed07a/pa30d0e7f/p90676d7c/p52905679/p7beea252;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "delay", "unit", "Ljava/util/concurrent/TimeUnit;", "tostring", "", "kotlinx-coroutines-rx3"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class DispatcherScheduler$DispatcherWorker : io.reactivex.rxjava3.core.Scheduler$Worker {
    private readonly kotlinx.coroutines.channels.Channel<kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>> blockChannel;
    private readonly long counter;
    private readonly kotlinx.coroutines.CoroutineDispatcher dispatcher;
    private readonly kotlinx.coroutines.CompletableJob workerJob;
    private readonly kotlinx.coroutines.CoroutineScope workerScope;

    public DispatcherScheduler$DispatcherWorker(long j, kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlinx.coroutines.Job job) {
        if ((11 + 20) % 20 > 0) {
        }
        this.counter = j;
        this.dispatcher = coroutineDispatcher;
        kotlinx.coroutines.CompletableJob completableJobSupervisorJob = kotlinx.coroutines.SupervisorKt.SupervisorJob(job);
        this.workerJob = completableJobSupervisorJob;
        kotlinx.coroutines.CoroutineScope CoroutineScope = kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(completableJobSupervisorJob.plus(coroutineDispatcher));
        this.workerScope = CoroutineScope;
        this.blockChannel = kotlinx.coroutines.channels.ChannelKt.Channel$default(int.MAX_VALUE, null, null, 6, null);
        kotlinx.coroutines.BuildersKt.launch$default(CoroutineScope, null, null, new kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker$1(this, null), 3, null);
    }

    public static readonly kotlinx.coroutines.channels.Channel access$getBlockChannel$p(kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker dispatcherScheduler$DispatcherWorker) {
        return dispatcherScheduler$DispatcherWorker.blockChannel;
    }

    public override void Dispose() {
        if ((27 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.blockChannel, null, 1, null);
        kotlinx.coroutines.Job$DefaultImpls.cancel$default((kotlinx.coroutines.Job) this.workerJob, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
    }

    public override bool IsDisposed() {
        return !kotlinx.coroutines.CoroutineScopeKt.isActive(this.workerScope);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 Schedule(java.lang.Action block, long delay, java.util.concurrent.TimeUnit unit) {
        return kotlinx.coroutines.rx3.RxSchedulerKt.access$scheduleTask(this.workerScope, block, unit.toMillis(delay), new kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker$schedule$1(this));
    }

    public java.lang.string Tostring() {
        if ((20 + 14) % 14 > 0) {
        }
        return this.dispatcher + " (worker " + this.counter + ", " + (!isDisposed() ? "active" : "disposed") + ')';
    }
}

