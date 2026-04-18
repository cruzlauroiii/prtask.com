namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0018\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\b\u001a\u00020\tH&J\u0010\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\fH&J\b\u0010\r\u001a\u00020\tH&¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60$p2e427c26;", "", "beforeTask", "", "taskRunner", "Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;", "coordinatorNotify", "coordinatorWait", "nanos", "", "execute", "runnable", "Ljava/lang/Action;", "nanoTime", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface pf9f34f60$p2e427c26 {
    void beforeTask(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 taskRunner);

    void coordinatorNotify(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 taskRunner);

    void coordinatorWait(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 taskRunner, long nanos);

    void execute(java.lang.Action runnable);

    long nanoTime();
}

