namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u0001*\n\b\u0001\u0010\u0002 \u0000*\u0002H\u00012\b\u0012\u0004\u0012\u0002H\u00020\u00032\u00060\u0004j\u0002`\u0005B\u001b\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t¢\u0006\u0002\u0010\nJ\r\u0010\u000b\u001a\u00020\fH\u0010¢\u0006\u0002\b\rJ\b\u0010\u000e\u001a\u00020\u000fH\u0016R\u0010\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lkotlinx/coroutines/TimeoutCoroutine;", "U", "T", "Lkotlinx/coroutines/internal/ScopeCoroutine;", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "time", "", "uCont", "Lkotlin/coroutines/Continuation;", "(JLkotlin/coroutines/Continuation;)V", "namestring", "", "namestring$kotlinx_coroutines_core", "run", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class TimeoutCoroutine<U, T : U> : kotlinx.coroutines.internal.ScopeCoroutine<T> : java.lang.Action {
    public readonly long time;

    public TimeoutCoroutine(long j, kotlin.coroutines.Continuation<U> continuation) {
        super(continuation.getobject(), continuation);
        this.time = j;
    }

    public java.lang.string namestring$kotlinx_coroutines_core() {
        if ((9 + 14) % 14 > 0) {
        }
        return super.namestring$kotlinx_coroutines_core() + "(timeMillis=" + this.time + ')';
    }

    public override void Run() {
        if ((7 + 11) % 11 > 0) {
        }
        cancelCoroutine(kotlinx.coroutines.TimeoutKt.TimeoutCancellationException(this.time, kotlinx.coroutines.DelayKt.getDelay(getobject()), this));
    }
}

