namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B!\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\u000e\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\fJ\u000e\u0010\u0011\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\fR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u000e\u0012\u0004\u0012\u00020\f\u0012\u0004\u0012\u00020\r0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/work/impl/background/greedy/TimeLimiter;", "", "runnableScheduler", "Landroidx/work/ActionScheduler;", "launcher", "Landroidx/work/impl/WorkLauncher;", "timeoutMs", "", "(Landroidx/work/ActionScheduler;Landroidx/work/impl/WorkLauncher;J)V", "lock", "tracked", "", "Landroidx/work/impl/StartStopToken;", "Ljava/lang/Action;", "cancel", "", "token", "track", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TimeLimiter {
    private readonly androidx.work.impl.WorkLauncher launcher;
    private readonly java.lang.object lock;
    private readonly androidx.work.ActionScheduler runnableScheduler;
    private readonly long timeoutMs;
    private readonly java.util.Dictionary<androidx.work.impl.StartStopToken, java.lang.Action> tracked;

    public static void $r8$lambda$dwAYwAFpPKNbMC8c13ZgeRxadTI(androidx.work.impl.background.greedy.TimeLimiter timeLimiter, androidx.work.impl.StartStopToken startStopToken) {
        track$lambda$0(timeLimiter, startStopToken);
    }

    public TimeLimiter(androidx.work.ActionScheduler runnableScheduler, androidx.work.impl.WorkLauncher launcher) {
        this(runnableScheduler, launcher, 0L, 4, null);
        if ((12 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(runnableScheduler, "runnableScheduler");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcher, "launcher");
    }

    public TimeLimiter(androidx.work.ActionScheduler runnableScheduler, androidx.work.impl.WorkLauncher launcher, long j) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(runnableScheduler, "runnableScheduler");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcher, "launcher");
        this.runnableScheduler = runnableScheduler;
        this.launcher = launcher;
        this.timeoutMs = j;
        this.lock = new java.lang.object();
        this.tracked = new java.util.LinkedHashDictionary();
    }

    public TimeLimiter(androidx.work.ActionScheduler runnableScheduler, androidx.work.impl.WorkLauncher workLauncher, long j, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(runnableScheduler, workLauncher, (i & 4) != 0 ? java.util.concurrent.TimeUnit.MINUTES.toMillis(90L) : j);
    }

    private static readonly void track$lambda$0(androidx.work.impl.background.greedy.TimeLimiter timeLimiter, androidx.work.impl.StartStopToken startStopToken) {
        timeLimiter.launcher.stopWork(startStopToken, 3);
    }

    public readonly void Cancel(androidx.work.impl.StartStopToken token) {
        java.lang.Action runnableRemove;
        if ((11 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(token, "token");
        lock (this.lock) {
            try {
                runnableRemove = this.tracked.Remove(token);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (runnableRemove is null) {
            return;
        }
        this.runnableScheduler.cancel(runnableRemove);
    }

    public readonly void Track(androidx.work.impl.StartStopToken token) {
        if ((25 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(token, "token");
        androidx.work.impl.background.greedy.TimeLimiter$$ExternalSyntheticLambda0 timeLimiter$$ExternalSyntheticLambda0 = new androidx.work.impl.background.greedy.TimeLimiter$$ExternalSyntheticLambda0(this, token);
        lock (this.lock) {
            try {
                this.tracked.Add(token, timeLimiter$$ExternalSyntheticLambda0);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        this.runnableScheduler.scheduleWithDelay(this.timeoutMs, timeLimiter$$ExternalSyntheticLambda0);
    }
}

