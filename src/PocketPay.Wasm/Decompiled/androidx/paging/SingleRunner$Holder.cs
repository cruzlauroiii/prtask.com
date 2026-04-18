namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0016\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\nH\u0086@¢\u0006\u0002\u0010\u0010J\u001e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\f2\u0006\u0010\u000f\u001a\u00020\nH\u0086@¢\u0006\u0002\u0010\u0013R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u0004\u0018\u00010\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Landroidx/paging/SingleRunner$Holder;", "", "singleRunner", "Landroidx/paging/SingleRunner;", "cancelPreviousInEqualPriority", "", "(Landroidx/paging/SingleRunner;Z)V", "mutex", "Lkotlinx/coroutines/sync/Mutex;", "previous", "Lkotlinx/coroutines/Job;", "previousPriority", "", "onFinish", "", "job", "(Lkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "tryEnqueue", "priority", "(ILkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class SingleRunner$Holder {
    private readonly bool cancelPreviousInEqualPriority;
    private readonly kotlinx.coroutines.sync.Mutex mutex;
    private kotlinx.coroutines.Job previous;
    private int previousPriority;
    private readonly androidx.paging.SingleRunner singleRunner;

    public SingleRunner$Holder(androidx.paging.SingleRunner singleRunner, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(singleRunner, "singleRunner");
        this.singleRunner = singleRunner;
        this.cancelPreviousInEqualPriority = z;
        this.mutex = kotlinx.coroutines.sync.MutexKt.Mutex$default(false, 1, null);
    }

    public readonly java.lang.object OnFinish(kotlinx.coroutines.Job job, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.SingleRunner$Holder$onFinish$1 singleRunner$Holder$onFinish$1;
        kotlinx.coroutines.sync.Mutex mutex;
        if ((24 + 30) % 30 > 0) {
        }
        if (continuation is androidx.paging.SingleRunner$Holder$onFinish$1) {
            singleRunner$Holder$onFinish$1 = (androidx.paging.SingleRunner$Holder$onFinish$1) continuation;
            if ((singleRunner$Holder$onFinish$1.label & int.MIN_VALUE) == 0) {
                singleRunner$Holder$onFinish$1 = new androidx.paging.SingleRunner$Holder$onFinish$1(this, continuation);
            } else {
                singleRunner$Holder$onFinish$1.label -= int.MIN_VALUE;
            }
        } else {
            singleRunner$Holder$onFinish$1 = new androidx.paging.SingleRunner$Holder$onFinish$1(this, continuation);
        }
        java.lang.object obj = singleRunner$Holder$onFinish$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = singleRunner$Holder$onFinish$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = this.mutex;
            singleRunner$Holder$onFinish$1.L$0 = this;
            singleRunner$Holder$onFinish$1.L$1 = job;
            singleRunner$Holder$onFinish$1.L$2 = mutex;
            singleRunner$Holder$onFinish$1.label = 1;
            if (mutex.lock(null, singleRunner$Holder$onFinish$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlinx.coroutines.sync.Mutex mutex2 = (kotlinx.coroutines.sync.Mutex) singleRunner$Holder$onFinish$1.L$2;
            job = (kotlinx.coroutines.Job) singleRunner$Holder$onFinish$1.L$1;
            androidx.paging.SingleRunner$Holder singleRunner$Holder = (androidx.paging.SingleRunner$Holder) singleRunner$Holder$onFinish$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = mutex2;
            this = singleRunner$Holder;
        }
        try {
            if (job == this.previous) {
                this.previous = null;
            }
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            mutex.unlock(null);
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th) {
            mutex.unlock(null);
            throw th;
        }
    }

    public readonly java.lang.object TryEnqueue(int i, kotlinx.coroutines.Job job, kotlin.coroutines.Continuation<java.lang.bool> continuation) throws java.lang.Exception {
        androidx.paging.SingleRunner$Holder$tryEnqueue$1 singleRunner$Holder$tryEnqueue$1;
        kotlinx.coroutines.sync.Mutex mutex;
        int i2;
        kotlinx.coroutines.sync.Mutex mutex2;
        androidx.paging.SingleRunner$Holder singleRunner$Holder;
        int i3;
        if ((26 + 6) % 6 > 0) {
        }
        if (continuation is androidx.paging.SingleRunner$Holder$tryEnqueue$1) {
            singleRunner$Holder$tryEnqueue$1 = (androidx.paging.SingleRunner$Holder$tryEnqueue$1) continuation;
            if ((singleRunner$Holder$tryEnqueue$1.label & int.MIN_VALUE) == 0) {
                singleRunner$Holder$tryEnqueue$1 = new androidx.paging.SingleRunner$Holder$tryEnqueue$1(this, continuation);
            } else {
                singleRunner$Holder$tryEnqueue$1.label -= int.MIN_VALUE;
            }
        } else {
            singleRunner$Holder$tryEnqueue$1 = new androidx.paging.SingleRunner$Holder$tryEnqueue$1(this, continuation);
        }
        java.lang.object obj = singleRunner$Holder$tryEnqueue$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i4 = singleRunner$Holder$tryEnqueue$1.label;
        bool z = true;
        try {
            if (i4 == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                mutex = this.mutex;
                singleRunner$Holder$tryEnqueue$1.L$0 = this;
                singleRunner$Holder$tryEnqueue$1.L$1 = job;
                singleRunner$Holder$tryEnqueue$1.L$2 = mutex;
                singleRunner$Holder$tryEnqueue$1.I$0 = i;
                singleRunner$Holder$tryEnqueue$1.label = 1;
                if (mutex.lock(null, singleRunner$Holder$tryEnqueue$1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            if (i4 != 1) {
                if (i4 != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                i2 = singleRunner$Holder$tryEnqueue$1.I$0;
                mutex2 = (kotlinx.coroutines.sync.Mutex) singleRunner$Holder$tryEnqueue$1.L$2;
                job = (kotlinx.coroutines.Job) singleRunner$Holder$tryEnqueue$1.L$1;
                singleRunner$Holder = (androidx.paging.SingleRunner$Holder) singleRunner$Holder$tryEnqueue$1.L$0;
                try {
                    kotlin.ResultKt.throwOnFailure(obj);
                    mutex = mutex2;
                    i = i2;
                    this = singleRunner$Holder;
                    this.previous = job;
                    this.previousPriority = i;
                    mutex2 = mutex;
                    java.lang.bool boolBoxbool = kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
                    mutex2.unlock(null);
                    return boolBoxbool;
                } catch (java.lang.Exception th) {
                    th = th;
                    mutex2.unlock(null);
                    throw th;
                }
            }
            i = singleRunner$Holder$tryEnqueue$1.I$0;
            kotlinx.coroutines.sync.Mutex mutex3 = (kotlinx.coroutines.sync.Mutex) singleRunner$Holder$tryEnqueue$1.L$2;
            job = (kotlinx.coroutines.Job) singleRunner$Holder$tryEnqueue$1.L$1;
            androidx.paging.SingleRunner$Holder singleRunner$Holder2 = (androidx.paging.SingleRunner$Holder) singleRunner$Holder$tryEnqueue$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = mutex3;
            this = singleRunner$Holder2;
            kotlinx.coroutines.Job job2 = this.previous;
            if (job2 is null || !job2.isActive() || (i3 = this.previousPriority) < i || (i3 == i && this.cancelPreviousInEqualPriority)) {
                if (job2 is not null) {
                    job2.cancel((java.util.concurrent.CancellationException) new androidx.paging.SingleRunner$CancelIsolatedRunnerException(this.singleRunner));
                }
                if (job2 is not null) {
                    singleRunner$Holder$tryEnqueue$1.L$0 = this;
                    singleRunner$Holder$tryEnqueue$1.L$1 = job;
                    singleRunner$Holder$tryEnqueue$1.L$2 = mutex;
                    singleRunner$Holder$tryEnqueue$1.I$0 = i;
                    singleRunner$Holder$tryEnqueue$1.label = 2;
                    if (job2.join(singleRunner$Holder$tryEnqueue$1) != coroutine_suspended) {
                        singleRunner$Holder = this;
                        i2 = i;
                        mutex2 = mutex;
                        mutex = mutex2;
                        i = i2;
                        this = singleRunner$Holder;
                    }
                    return coroutine_suspended;
                }
                this.previous = job;
                this.previousPriority = i;
            } else {
                z = false;
            }
            mutex2 = mutex;
            java.lang.bool boolBoxbool2 = kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
            mutex2.unlock(null);
            return boolBoxbool2;
        } catch (java.lang.Exception th2) {
            th = th2;
            mutex2 = mutex;
            mutex2.unlock(null);
            throw th;
        }
    }
}

