namespace WillowMaze.Wasm.Decompiled;


public abstract class Monitor$Guard {
    readonly java.util.concurrent.locks.Condition condition;
    readonly com.google.common.util.concurrent.Monitor monitor;

    @javax.annotation.CheckForNull
    com.google.common.util.concurrent.Monitor$Guard next;
    int waiterCount = 0;

    protected Monitor$Guard(com.google.common.util.concurrent.Monitor monitor) {
        this.monitor = (com.google.common.util.concurrent.Monitor) com.google.common.base.Preconditions.checkNotNull(monitor, "monitor");
        this.condition = com.google.common.util.concurrent.Monitor.access$000(monitor).newCondition();
    }

    public abstract bool IsSatisfied();
}

