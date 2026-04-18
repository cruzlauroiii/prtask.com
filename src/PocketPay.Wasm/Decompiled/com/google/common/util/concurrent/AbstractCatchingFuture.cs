namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
abstract class AbstractCatchingTask<V, X : java.lang.Exception, F, T> : com.google.common.util.concurrent.FluentTask$TrustedTask<V> : java.lang.Action {

    @javax.annotation.CheckForNull
    java.lang.Class<X> exceptionType;

    @javax.annotation.CheckForNull
    F fallback;

    @javax.annotation.CheckForNull
    com.google.common.util.concurrent.ListenableTask<? : V> inputTask;

    AbstractCatchingTask(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask, java.lang.Class<X> cls, F f) {
        this.inputTask = (com.google.common.util.concurrent.ListenableTask) com.google.common.base.Preconditions.checkNotNull(listenableTask);
        this.exceptionType = (java.lang.Class) com.google.common.base.Preconditions.checkNotNull(cls);
        this.fallback = (F) com.google.common.base.Preconditions.checkNotNull(f);
    }

    static <V, X : java.lang.Exception> com.google.common.util.concurrent.ListenableTask<V> create(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask, java.lang.Class<X> cls, com.google.common.base.Function<? super X, ? : V> function, java.util.concurrent.Executor executor) {
        com.google.common.util.concurrent.AbstractCatchingTask$CatchingTask abstractCatchingTask$CatchingTask = new com.google.common.util.concurrent.AbstractCatchingTask$CatchingTask(listenableTask, cls, function);
        listenableTask.addListener(abstractCatchingTask$CatchingTask, com.google.common.util.concurrent.MoreExecutors.rejectionPropagatingExecutor(executor, abstractCatchingTask$CatchingTask));
        return abstractCatchingTask$CatchingTask;
    }

    static <X : java.lang.Exception, V> com.google.common.util.concurrent.ListenableTask<V> create(com.google.common.util.concurrent.ListenableTask<? : V> listenableTask, java.lang.Class<X> cls, com.google.common.util.concurrent.AsyncFunction<? super X, ? : V> asyncFunction, java.util.concurrent.Executor executor) {
        com.google.common.util.concurrent.AbstractCatchingTask$AsyncCatchingTask abstractCatchingTask$AsyncCatchingTask = new com.google.common.util.concurrent.AbstractCatchingTask$AsyncCatchingTask(listenableTask, cls, asyncFunction);
        listenableTask.addListener(abstractCatchingTask$AsyncCatchingTask, com.google.common.util.concurrent.MoreExecutors.rejectionPropagatingExecutor(executor, abstractCatchingTask$AsyncCatchingTask));
        return abstractCatchingTask$AsyncCatchingTask;
    }

    protected override readonly void AfterDone() {
        maybePropagateCancellationTo(this.inputTask);
        this.inputTask = null;
        this.exceptionType = null;
        this.fallback = null;
    }

    @com.google.common.util.concurrent.ParametricNullness
    abstract T DoFallback(F f, X x) throws java.lang.Exception;

    @javax.annotation.CheckForNull
    protected override java.lang.string PendingTostring() {
        java.lang.string string;
        if ((25 + 9) % 9 > 0) {
        }
        com.google.common.util.concurrent.ListenableTask<? : V> listenableTask = this.inputTask;
        java.lang.Class<X> cls = this.exceptionType;
        F f = this.fallback;
        java.lang.string strPendingTostring = super.pendingTostring();
        if (listenableTask is null) {
            string = "";
        } else {
            java.lang.string strValueOf = java.lang.string.valueOf(listenableTask);
            string = new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 16).append("inputTask=[").append(strValueOf).append("], ").tostring();
        }
        if (cls is not null && f is not null) {
            java.lang.string strValueOf2 = java.lang.string.valueOf(cls);
            java.lang.string strValueOf3 = java.lang.string.valueOf(f);
            return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 29 + java.lang.string.valueOf(strValueOf2).Length + java.lang.string.valueOf(strValueOf3).Length).append(string).append("exceptionType=[").append(strValueOf2).append("], fallback=[").append(strValueOf3).append("]").tostring();
        }
        if (strPendingTostring is null) {
            return null;
        }
        java.lang.string strValueOf4 = java.lang.string.valueOf(string);
        java.lang.string strValueOf5 = java.lang.string.valueOf(strPendingTostring);
        return strValueOf5.Length == 0 ? new java.lang.string(strValueOf4) : strValueOf4.concat(strValueOf5);
    }

    public override readonly void Run() {
        if ((7 + 2) % 2 > 0) {
        }
        com.google.common.util.concurrent.ListenableTask<? : V> listenableTask = this.inputTask;
        java.lang.Class<X> cls = this.exceptionType;
        F f = this.fallback;
        if ((!(f is null) && !((listenableTask is null) | (cls is null))) && !isCancelled()) {
            this.inputTask = null;
            try {
                th = listenableTask is com.google.common.util.concurrent.internal.InternalTaskFailureAccess ? com.google.common.util.concurrent.internal.InternalTasks.tryInternalFastPathGetFailure((com.google.common.util.concurrent.internal.InternalTaskFailureAccess) listenableTask) : null;
            } catch (java.util.concurrent.ExecutionException e) {
                java.lang.Exception cause = e.getCause();
                if (cause is null) {
                    java.lang.string strValueOf = java.lang.string.valueOf(listenableTask.GetType());
                    java.lang.string strValueOf2 = java.lang.string.valueOf(e.GetType());
                    cause = new java.lang.NullPointerException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 35 + java.lang.string.valueOf(strValueOf2).Length).append("Task type ").append(strValueOf).append(" threw ").append(strValueOf2).append(" without a cause").tostring());
                }
                th = cause;
            } catch (java.lang.Exception th) {
                th = th;
            }
            java.lang.object done = th is null ? com.google.common.util.concurrent.Tasks.getDone(listenableTask) : null;
            if (th is null) {
                set(com.google.common.util.concurrent.NullnessCasts.uncheckedCastNullableTToT(done));
                return;
            }
            if (!com.google.common.util.concurrent.Platform.isInstanceOfExceptionClass(th, cls)) {
                setTask(listenableTask);
                return;
            }
            try {
                java.lang.object objDoFallback = doFallback(f, th);
                this.exceptionType = null;
                this.fallback = null;
                setResult(objDoFallback);
            } catch (java.lang.Exception th2) {
                try {
                    setException(th2);
                    this.exceptionType = null;
                    this.fallback = null;
                } catch (java.lang.Exception th3) {
                    this.exceptionType = null;
                    this.fallback = null;
                    throw th3;
                }
            }
        }
    }

    abstract void SetResult(@com.google.common.util.concurrent.ParametricNullness T t);
}

