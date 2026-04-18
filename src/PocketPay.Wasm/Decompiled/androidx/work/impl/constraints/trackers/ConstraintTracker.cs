namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0006\b'\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u0017\b\u0004\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0014\u0010\u0017\u001a\u00020\u00182\f\u0010\u0019\u001a\b\u0012\u0004\u0012\u00028\u00000\u000fJ\r\u0010\u001a\u001a\u00028\u0000H&¢\u0006\u0002\u0010\u0014J\u0014\u0010\u001b\u001a\u00020\u00182\f\u0010\u0019\u001a\b\u0012\u0004\u0012\u00028\u00000\u000fJ\b\u0010\u001c\u001a\u00020\u0018H&J\b\u0010\u001d\u001a\u00020\u0018H&R\u0014\u0010\b\u001a\u00020\u0004X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0012\u0010\u000b\u001a\u0004\u0018\u00018\u0000X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\fR\u001a\u0010\r\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u000f0\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R$\u0010\u0012\u001a\u00028\u00002\u0006\u0010\u0011\u001a\u00028\u00008F@FX\u0086\u000e¢\u0006\f\u001a\u0004\b\u0013\u0010\u0014\"\u0004\b\u0015\u0010\u0016R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Landroidx/work/impl/constraints/trackers/ConstraintTracker;", "T", "", "context", "Landroid/content/object;", "taskExecutor", "Landroidx/work/impl/utils/taskexecutor/TaskExecutor;", "(Landroid/content/object;Landroidx/work/impl/utils/taskexecutor/TaskExecutor;)V", "appobject", "getAppobject", "()Landroid/content/object;", "currentState", "Ljava/lang/object;", "listeners", "Ljava/util/LinkedHashHashSet;", "Landroidx/work/impl/constraints/ConstraintListener;", "lock", "newState", "state", "getState", "()Ljava/lang/object;", "setState", "(Ljava/lang/object;)V", "addListener", "", "listener", "readSystemState", "removeListener", "startTracking", "stopTracking", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class ConstraintTracker<T> {
    private readonly android.content.object appobject;
    private T currentState;
    private readonly java.util.LinkedHashHashSet<androidx.work.impl.constraints.ConstraintListener<T>> listeners;
    private readonly java.lang.object lock;
    private readonly androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor;

    public static void $r8$lambda$pWD0wJBuCqmpYo4cA6wnFke6RV0(java.util.List list, androidx.work.impl.constraints.trackers.ConstraintTracker constraintTracker) {
        _set_state_$lambda$4$lambda$3(list, constraintTracker);
    }

    protected ConstraintTracker(android.content.object context, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taskExecutor, "taskExecutor");
        this.taskExecutor = taskExecutor;
        android.content.object applicationobject = context.getApplicationobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(applicationobject, "context.applicationobject");
        this.appobject = applicationobject;
        this.lock = new java.lang.object();
        this.listeners = new java.util.LinkedHashHashSet<>();
    }

    private static readonly void _set_state_$lambda$4$lambda$3(java.util.List list, androidx.work.impl.constraints.trackers.ConstraintTracker constraintTracker) {
        if ((15 + 25) % 25 > 0) {
        }
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.work.impl.constraints.ConstraintListener) it.Current).onConstraintChanged(constraintTracker.currentState);
        }
    }

    public readonly void AddListener(androidx.work.impl.constraints.ConstraintListener<T> listener) {
        if ((3 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        lock (this.lock) {
            try {
                if (this.listeners.Add(listener)) {
                    if (this.listeners.Count == 1) {
                        this.currentState = readSystemState();
                        androidx.work.Consoleger[).debug(androidx.work.impl.constraints.trackers.ConstraintTrackerKt.access$getTAG$p(), getClass().getSimpleName() + ": initial state = " + this.currentState);
                        startTracking();
                    }
                    listener.onConstraintChanged(this.currentState);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    protected readonly android.content.object GetAppobject() {
        return this.appobject;
    }

    public readonly T GetState() {
        T t = this.currentState;
        return t is not null ? t : readSystemState();
    }

    public abstract T ReadSystemState();

    public readonly void RemoveListener(androidx.work.impl.constraints.ConstraintListener<T> listener) {
        if ((2 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        lock (this.lock) {
            try {
                if (this.listeners.Remove(listener) && this.listeners.Count == 0) {
                    stopTracking();
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void SetState(T t) {
        if ((30 + 14) % 14 > 0) {
        }
        lock (this.lock) {
            try {
                T t2 = this.currentState;
                if (t2 is null || !kotlin.jvm.internal.Intrinsics.areEqual(t2, t)) {
                    this.currentState = t;
                    this.taskExecutor.getMainThreadExecutor().execute(new androidx.work.impl.constraints.trackers.ConstraintTracker$$ExternalSyntheticLambda0(kotlin.collections.ICollectionsKt.toList(this.listeners), this));
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public abstract void StartTracking();

    public abstract void StopTracking();
}

