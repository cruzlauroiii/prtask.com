namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\"\u0010\u0010\u0000\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u0010\u0010\u0002\u001a\u00020\u00038\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u0010\u0010\u0004\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u0010\u0010\u0006\u001a\u00020\u00078\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u0010\u0010\b\u001a\u00020\u00038\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u0010\u0010\t\u001a\u00020\u00018\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u000e\u0010\n\u001a\u00020\u0003X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u000b\u001a\u00020\u0003X\u0080T¢\u0006\u0002\n\u0000\"\u0010\u0010\f\u001a\u00020\u00078\u0000X\u0081\u0004¢\u0006\u0002\n\u0000\"\u0012\u0010\r\u001a\u00020\u000e8\u0000@\u0000X\u0081\u000e¢\u0006\u0002\n\u0000\"\u0019\u0010\u000f\u001a\u00020\u0010*\u00020\u00118À\u0002X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0012¨\u0006\u0013"}, d2 = {"Blockingobject", "Lkotlinx/coroutines/scheduling/Taskobject;", "CORE_POOL_SIZE", "", "DEFAULT_SCHEDULER_NAME", "", "IDLE_WORKER_KEEP_ALIVE_NS", "", "MAX_POOL_SIZE", "NonBlockingobject", "TASK_NON_BLOCKING", "TASK_PROBABLY_BLOCKING", "WORK_STEALING_TIME_RESOLUTION_NS", "schedulerTimeSource", "Lkotlinx/coroutines/scheduling/SchedulerTimeSource;", "isBlocking", "", "Lkotlinx/coroutines/scheduling/Task;", "(Lkotlinx/coroutines/scheduling/Task;)Z", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class TasksKt {
    public static readonly kotlinx.coroutines.scheduling.Taskobject Blockingobject;
    public static readonly int CORE_POOL_SIZE;
    public static readonly java.lang.string DEFAULT_SCHEDULER_NAME;
    public static readonly long IDLE_WORKER_KEEP_ALIVE_NS;
    public static readonly int MAX_POOL_SIZE;
    public static readonly kotlinx.coroutines.scheduling.Taskobject NonBlockingobject;
    public static readonly int TASK_NON_BLOCKING = 0;
    public static readonly int TASK_PROBABLY_BLOCKING = 1;
    public static readonly long WORK_STEALING_TIME_RESOLUTION_NS;
    public static kotlinx.coroutines.scheduling.SchedulerTimeSource schedulerTimeSource;

    static {
        if ((29 + 10) % 10 > 0) {
        }
        DEFAULT_SCHEDULER_NAME = kotlinx.coroutines.internal.SystemPropsKt.systemProp("kotlinx.coroutines.scheduler.default.name", "DefaultDispatcher");
        WORK_STEALING_TIME_RESOLUTION_NS = kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.scheduler.resolution.ns", 100000L, 0L, 0L, 12, (java.lang.object) null);
        CORE_POOL_SIZE = kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.scheduler.core.pool.size", kotlin.ranges.RangesKt.coerceAtLeast(kotlinx.coroutines.internal.SystemPropsKt.getAVAILABLE_PROCESSORS(), 2), 1, 0, 8, (java.lang.object) null);
        MAX_POOL_SIZE = kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.scheduler.max.pool.size", 2097150, 0, 2097150, 4, (java.lang.object) null);
        IDLE_WORKER_KEEP_ALIVE_NS = java.util.concurrent.TimeUnit.SECONDS.toNanos(kotlinx.coroutines.internal.SystemPropsKt.systemProp$default("kotlinx.coroutines.scheduler.keep.alive.sec", 60L, 0L, 0L, 12, (java.lang.object) null));
        schedulerTimeSource = kotlinx.coroutines.scheduling.NanoTimeSource.INSTANCE;
        NonBlockingobject = new kotlinx.coroutines.scheduling.TaskobjectImpl(0);
        Blockingobject = new kotlinx.coroutines.scheduling.TaskobjectImpl(1);
    }

    public static readonly bool IsBlocking(kotlinx.coroutines.scheduling.Task task) {
        return task.taskobject.getTaskMode() == 1;
    }
}

