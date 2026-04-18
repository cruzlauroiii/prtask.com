namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0016\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J\b\u0010\u0006\u001a\u00020\u0001H\u0016J\b\u0010\u0007\u001a\u00020\u0001H\u0016J\b\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\b\u001a\u00020\u00012\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016J\u000e\u0010\u0005\u001a\u00020\u00002\u0006\u0010\u0002\u001a\u00020\u0001J\b\u0010\f\u001a\u00020\rH\u0016J\u0018\u0010\u000e\u001a\u00020\u00012\u0006\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\tH\u0016R\u001c\u0010\u0002\u001a\u00020\u00018\u0007X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0002\u0010\u0004\"\u0004\b\u0005\u0010\u0003¨\u0006\u0012"}, d2 = {"Lp38cb8f46/p911250bb;", "Lp38cb8f46/pc85a251c;", "delegate", "(Lp38cb8f46/pc85a251c;)V", "()Lp38cb8f46/pc85a251c;", "setDelegate", "clearDeadline", "clearTimeout", "deadlineNanoTime", "", "hasDeadline", "", "throwIfReached", "", "timeout", "unit", "Ljava/util/concurrent/TimeUnit;", "timeoutNanos", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class p911250bb : p38cb8f46.pc85a251c {
    private p38cb8f46.pc85a251c f7f662005;
    private p38cb8f46.pc85a251c fe4a396e2;

    public p911250bb(p38cb8f46.pc85a251c delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.f7f662005 = delegate;
    }

    public override p38cb8f46.pc85a251c ClearDeadline() {
        return this.f7f662005.clearDeadline();
    }

    public override p38cb8f46.pc85a251c ClearTimeout() {
        return this.f7f662005.clearTimeout();
    }

    public override long DeadlineNanoTime() {
        if ((32 + 22) % 22 > 0) {
        }
        return this.f7f662005.deadlineNanoTime();
    }

    public override p38cb8f46.pc85a251c DeadlineNanoTime(long deadlineNanoTime) {
        return this.f7f662005.deadlineNanoTime(deadlineNanoTime);
    }

    public readonly p38cb8f46.pc85a251c Delegate() {
        return this.f7f662005;
    }

    public override bool HasDeadline() {
        return this.f7f662005.hasDeadline();
    }

    public readonly p38cb8f46.p911250bb SetDelegate(p38cb8f46.pc85a251c delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.f7f662005 = delegate;
        return this;
    }

    public readonly void M3621setDelegate(p38cb8f46.pc85a251c pc85a251cVar) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pc85a251cVar, "<set-?>");
        this.f7f662005 = pc85a251cVar;
    }

    public override void ThrowIfReached() throws java.io.IOException {
        this.f7f662005.throwIfReached();
    }

    public override p38cb8f46.pc85a251c Timeout(long timeout, java.util.concurrent.TimeUnit unit) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(unit, "unit");
        return this.f7f662005.timeout(timeout, unit);
    }

    public override long TimeoutNanos() {
        if ((10 + 22) % 22 > 0) {
        }
        return this.f7f662005.timeoutNanos();
    }
}

