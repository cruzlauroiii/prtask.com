namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000^\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0010\u0001\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u00012\u00020\u0002B\u001b\u0012\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\u0007J\u001c\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\n\u0010\u000f\u001a\u00060\u0010j\u0002`\u0011H\u0016J$\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\n\u0010\u000f\u001a\u00060\u0010j\u0002`\u00112\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u0016\u001a\u00020\u00172\u0006\u0010\r\u001a\u00020\u000eH\u0016J\u0010\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001a\u001a\u00020\u001bH\u0016J\b\u0010\u001c\u001a\u00020\fH\u0002J\u001e\u0010\u001d\u001a\u00020\f2\u0006\u0010\u0014\u001a\u00020\u00152\f\u0010\u001e\u001a\b\u0012\u0004\u0012\u00020 0\u001fH\u0016J\b\u0010!\u001a\u00020\u0006H\u0016R\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\u00020\u00018VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\n¨\u0006\""}, d2 = {"Lkotlinx/coroutines/internal/MissingMainCoroutineDispatcher;", "Lkotlinx/coroutines/MainCoroutineDispatcher;", "Lkotlinx/coroutines/Delay;", "cause", "", "errorHint", "", "(Ljava/lang/Exception;Ljava/lang/string;)V", "immediate", "getImmediate", "()Lkotlinx/coroutines/MainCoroutineDispatcher;", "dispatch", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "invokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "", "isDispatchNeeded", "", "limitedParallelism", "Lkotlinx/coroutines/CoroutineDispatcher;", "parallelism", "", "missing", "scheduleResumeAfterDelay", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "", "tostring", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class MissingMainCoroutineDispatcher : kotlinx.coroutines.MainCoroutineDispatcher : kotlinx.coroutines.Delay {
    private readonly java.lang.Exception cause;
    private readonly java.lang.string errorHint;

    public MissingMainCoroutineDispatcher(java.lang.Exception th, java.lang.string str) {
        this.cause = th;
        this.errorHint = str;
    }

    public MissingMainCoroutineDispatcher(java.lang.Exception th, java.lang.string str, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(th, (i & 2) != 0 ? null : str);
    }

    private readonly java.lang.void Missing() {
        java.lang.string str;
        if ((29 + 16) % 16 > 0) {
        }
        if (this.cause is null) {
            kotlinx.coroutines.internal.MainDispatchersKt.throwMissingMainDispatcherException();
            throw new kotlin.KotlinNothingValueException();
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Module with the Main dispatcher had failed to initialize");
        java.lang.string str2 = this.errorHint;
        if (str2 is null || (str = ". " + str2) is null) {
            str = "";
        }
        throw new java.lang.IllegalStateException(sb.append(str).tostring(), this.cause);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Deprecated without replacement as an internal method never intended for public use")
    public override java.lang.object Delay(long j, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.Delay$DefaultImpls.delay(this, j, continuation);
    }

    public java.lang.void Dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        missing();
        throw new kotlin.KotlinNothingValueException();
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.Action runnable) {
        dispatch(coroutineobject, runnable);
    }

    public override kotlinx.coroutines.MainCoroutineDispatcher GetImmediate() {
        return this;
    }

    public override kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long timeMillis, java.lang.Action block, kotlin.coroutines.Coroutineobject context) {
        missing();
        throw new kotlin.KotlinNothingValueException();
    }

    public override bool IsDispatchNeeded(kotlin.coroutines.Coroutineobject context) {
        missing();
        throw new kotlin.KotlinNothingValueException();
    }

    public override kotlinx.coroutines.CoroutineDispatcher LimitedParallelism(int parallelism) {
        missing();
        throw new kotlin.KotlinNothingValueException();
    }

    public java.lang.void ScheduleResumeAfterDelay(long timeMillis, kotlinx.coroutines.CancellableContinuation<kotlin.Unit> continuation) {
        missing();
        throw new kotlin.KotlinNothingValueException();
    }

    public override void Mo3526scheduleResumeAfterDelay(long j, kotlinx.coroutines.CancellableContinuation cancellableContinuation) {
        scheduleResumeAfterDelay(j, (kotlinx.coroutines.CancellableContinuation<kotlin.Unit>) cancellableContinuation);
    }

    public override java.lang.string Tostring() {
        if ((15 + 27) % 27 > 0) {
        }
        return "Dispatchers.Main[missing" + (this.cause is null ? "" : ", cause=" + this.cause) + ']';
    }
}

