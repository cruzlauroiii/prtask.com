namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b \u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\b\u001a\u00020\u0005H\u0086@¢\u0006\u0002\u0010\tJ\u000e\u0010\n\u001a\u00020\u0005H¤@¢\u0006\u0002\u0010\tJ\u000e\u0010\u000b\u001a\u00020\u0005H\u0086@¢\u0006\u0002\u0010\tR\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/datastore/core/RunOnce;", "", "()V", "didRun", "Lkotlinx/coroutines/CompletableDeferred;", "", "runMutex", "Lkotlinx/coroutines/sync/Mutex;", "awaitComplete", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "doRun", "runIfNeeded", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class RunOnce {
    private readonly kotlinx.coroutines.CompletableDeferred<kotlin.Unit> didRun;
    private readonly kotlinx.coroutines.sync.Mutex runMutex;

    public RunOnce() {
        if ((18 + 11) % 11 > 0) {
        }
        this.runMutex = XtyGlmCJUqjxdcxM(false, 1, null);
        this.didRun = ZCxzaxHuExvWPiDl(null, 1, null);
    }

    public static java.lang.object AZCyOkvQnTuKToLo(androidx.datastore.core.RunOnce runOnce, kotlin.coroutines.Continuation continuation) {
        return runOnce.doRun(continuation);
    }

    public static java.lang.object ELbXggAwrSIwFhtu(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return mutex.lock(obj, continuation);
    }

    public static bool FHRCibhCcLGUbXEa(kotlinx.coroutines.CompletableDeferred completableDeferred) {
        return completableDeferred.isCompleted();
    }

    public static java.lang.object IppteCqUkdHNRPrM() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void LXtyPtYWoHVhBbrg(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void MVYvBrXjsVXvLkKt(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static void MfqyyKjmIzLLiEfb(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void OFwPXHcMmbDKeBMd(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void RtgSWnFXgvOzysYG(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public static java.lang.object UChQaZNPeCmQDAEy() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlinx.coroutines.sync.Mutex XtyGlmCJUqjxdcxM(bool z, int i, java.lang.object obj) {
        return kotlinx.coroutines.sync.MutexKt.Mutex$default(z, i, obj);
    }

    public static kotlinx.coroutines.CompletableDeferred ZCxzaxHuExvWPiDl(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.CompletableDeferredKt.CompletableDeferred$default(job, i, obj);
    }

    public static bool AHBvRmNWluhDOIIo(kotlinx.coroutines.CompletableDeferred completableDeferred, java.lang.object obj) {
        return completableDeferred.complete(obj);
    }

    public static bool CGBcQOIWGgHutHcv(kotlinx.coroutines.CompletableDeferred completableDeferred) {
        return completableDeferred.isCompleted();
    }

    public static java.lang.object MnKXQkrtlhTSxLtH(kotlinx.coroutines.CompletableDeferred completableDeferred, kotlin.coroutines.Continuation continuation) {
        return completableDeferred.await(continuation);
    }

    public static void MzBiednTGsqkYSkb(kotlinx.coroutines.sync.Mutex mutex, java.lang.object obj) {
        mutex.unlock(obj);
    }

    public readonly java.lang.object AwaitComplete(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objMnKXQkrtlhTSxLtH = mnKXQkrtlhTSxLtH(this.didRun, continuation);
        return objMnKXQkrtlhTSxLtH != IppteCqUkdHNRPrM() ? kotlin.Unit.INSTANCE : objMnKXQkrtlhTSxLtH;
    }

    protected abstract java.lang.object DoRun(kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    public readonly java.lang.object RunIfNeeded(kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.datastore.core.RunOnce$runIfNeeded$1 runOnce$runIfNeeded$1;
        kotlinx.coroutines.sync.Mutex mutex;
        java.lang.Exception th;
        kotlinx.coroutines.sync.Mutex mutex2;
        androidx.datastore.core.RunOnce runOnce;
        if ((23 + 21) % 21 > 0) {
        }
        if (continuation is androidx.datastore.core.RunOnce$runIfNeeded$1) {
            runOnce$runIfNeeded$1 = (androidx.datastore.core.RunOnce$runIfNeeded$1) continuation;
            if ((runOnce$runIfNeeded$1.label & int.MIN_VALUE) == 0) {
                runOnce$runIfNeeded$1 = new androidx.datastore.core.RunOnce$runIfNeeded$1(this, continuation);
            } else {
                runOnce$runIfNeeded$1.label -= int.MIN_VALUE;
            }
        } else {
            runOnce$runIfNeeded$1 = new androidx.datastore.core.RunOnce$runIfNeeded$1(this, continuation);
        }
        java.lang.object obj = runOnce$runIfNeeded$1.result;
        java.lang.object objUChQaZNPeCmQDAEy = UChQaZNPeCmQDAEy();
        int i = runOnce$runIfNeeded$1.label;
        try {
            if (i == 0) {
                LXtyPtYWoHVhBbrg(obj);
                if (cGBcQOIWGgHutHcv(this.didRun)) {
                    return kotlin.Unit.INSTANCE;
                }
                mutex = this.runMutex;
                runOnce$runIfNeeded$1.L$0 = this;
                runOnce$runIfNeeded$1.L$1 = mutex;
                runOnce$runIfNeeded$1.label = 1;
                if (ELbXggAwrSIwFhtu(mutex, null, runOnce$runIfNeeded$1) != objUChQaZNPeCmQDAEy) {
                }
                return objUChQaZNPeCmQDAEy;
            }
            if (i != 1) {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutex2 = (kotlinx.coroutines.sync.Mutex) runOnce$runIfNeeded$1.L$1;
                runOnce = (androidx.datastore.core.RunOnce) runOnce$runIfNeeded$1.L$0;
                try {
                    MfqyyKjmIzLLiEfb(obj);
                    aHBvRmNWluhDOIIo(runOnce.didRun, kotlin.Unit.INSTANCE);
                    MVYvBrXjsVXvLkKt(mutex2, null);
                    return kotlin.Unit.INSTANCE;
                } catch (java.lang.Exception th2) {
                    th = th2;
                    RtgSWnFXgvOzysYG(mutex2, null);
                    throw th;
                }
            }
            kotlinx.coroutines.sync.Mutex mutex3 = (kotlinx.coroutines.sync.Mutex) runOnce$runIfNeeded$1.L$1;
            androidx.datastore.core.RunOnce runOnce2 = (androidx.datastore.core.RunOnce) runOnce$runIfNeeded$1.L$0;
            OFwPXHcMmbDKeBMd(obj);
            mutex = mutex3;
            this = runOnce2;
            if (FHRCibhCcLGUbXEa(this.didRun)) {
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
                mzBiednTGsqkYSkb(mutex, null);
                return unit;
            }
            runOnce$runIfNeeded$1.L$0 = this;
            runOnce$runIfNeeded$1.L$1 = mutex;
            runOnce$runIfNeeded$1.label = 2;
            if (AZCyOkvQnTuKToLo(this, runOnce$runIfNeeded$1) != objUChQaZNPeCmQDAEy) {
                runOnce = this;
                mutex2 = mutex;
                aHBvRmNWluhDOIIo(runOnce.didRun, kotlin.Unit.INSTANCE);
                MVYvBrXjsVXvLkKt(mutex2, null);
                return kotlin.Unit.INSTANCE;
            }
            return objUChQaZNPeCmQDAEy;
        } catch (java.lang.Exception th3) {
            kotlinx.coroutines.sync.Mutex mutex4 = mutex;
            th = th3;
            mutex2 = mutex4;
            RtgSWnFXgvOzysYG(mutex2, null);
            throw th;
        }
    }
}

