namespace WillowMaze.Wasm.Decompiled;


class DefaultTaskExecutor$1 : java.util.concurrent.ThreadFactory {
    private static readonly java.lang.string THREAD_NAME_STEM = "arch_disk_io_";
    private readonly java.util.concurrent.atomic.Atomicint mThreadId = new java.util.concurrent.atomic.Atomicint(0);
    readonly androidx.arch.core.executor.DefaultTaskExecutor this$0;

    DefaultTaskExecutor$1(androidx.arch.core.executor.DefaultTaskExecutor defaultTaskExecutor) {
        this.this$0 = defaultTaskExecutor;
    }

    public static java.lang.string AMbCGtDprkuptASc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int UCpZZaPiIBXiNzKB(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.stringBuilder XDhReSIQufGVAWml(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void VAyEcBWvIWVFxbsj(java.lang.Thread thread, java.lang.string str) {
        thread.setName(str);
    }

    public override java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((3 + 5) % 5 > 0) {
        }
        java.lang.Thread thread = new java.lang.Thread(runnable);
        vAyEcBWvIWVFxbsj(thread, AMbCGtDprkuptASc(XDhReSIQufGVAWml(new java.lang.stringBuilder("arch_disk_io_"), UCpZZaPiIBXiNzKB(this.mThreadId))));
        return thread;
    }
}

