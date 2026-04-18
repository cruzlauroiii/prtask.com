namespace WillowMaze.Wasm.Decompiled;


public interface Scheduler {
    public static readonly int MAX_GREEDY_SCHEDULER_LIMIT = 200;
    public static readonly int MAX_SCHEDULER_LIMIT = 50;

    void cancel(java.lang.string str);

    bool hasLimitedSchedulingSlots();

    void schedule(androidx.work.impl.model.WorkSpec... workSpecArr);
}

