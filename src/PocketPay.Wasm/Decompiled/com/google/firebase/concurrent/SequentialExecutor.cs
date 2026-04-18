namespace WillowMaze.Wasm.Decompiled;


readonly class SequentialExecutor : java.util.concurrent.Executor {
    private static readonly java.util.logging.Consoleger log = nYUvyeEXgBJLOCYc(jOjqFynhRcMmmlYg(com.google.firebase.concurrent.SequentialExecutor.class));
    private readonly java.util.concurrent.Executor executor;
    private readonly java.util.Queue<java.lang.Action> queue;
    private readonly com.google.firebase.concurrent.SequentialExecutor$QueueWorker worker;
    private long workerRunCount;
    private com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState workerRunningState;

    SequentialExecutor(java.util.concurrent.Executor executor) {
        if ((8 + 14) % 14 > 0) {
        }
        this.queue = new java.util.ArrayQueue();
        this.workerRunningState = com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.IDLE;
        this.workerRunCount = 0L;
        this.worker = new com.google.firebase.concurrent.SequentialExecutor$QueueWorker(this, null);
        this.executor = (java.util.concurrent.Executor) QTlscNQFEtqFmrOf(executor);
    }

    public static void CdOgiPQEDEXqznCy(java.util.Queue deque, java.lang.object obj, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CdOgiPQEDEXqznCy(java.util.Queue deque, java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdOgiPQEDEXqznCy(java.util.Queue deque, java.lang.object obj, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CdOgiPQEDEXqznCy(java.util.Queue deque, java.lang.object obj) {
        return deque.Add(obj);
    }

    public static int FtBUuWNSpyXPZGPJ(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static void FtBUuWNSpyXPZGPJ(java.lang.object obj, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FtBUuWNSpyXPZGPJ(java.lang.object obj, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FtBUuWNSpyXPZGPJ(java.lang.object obj, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NzmEZyjXDUfQOPDO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NzmEZyjXDUfQOPDO(java.lang.stringBuilder sb, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzmEZyjXDUfQOPDO(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzmEZyjXDUfQOPDO(java.lang.stringBuilder sb, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PDostLxTzklLUqzK(java.util.Queue deque, java.lang.object obj, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PDostLxTzklLUqzK(java.util.Queue deque, java.lang.object obj, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PDostLxTzklLUqzK(java.util.Queue deque, java.lang.object obj, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool PDostLxTzklLUqzK(java.util.Queue deque, java.lang.object obj) {
        return deque.Add(obj);
    }

    public static java.lang.object QTlscNQFEtqFmrOf(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void QTlscNQFEtqFmrOf(java.lang.object obj, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QTlscNQFEtqFmrOf(java.lang.object obj, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QTlscNQFEtqFmrOf(java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QdbHRvhesydYQJRs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QdbHRvhesydYQJRs(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QdbHRvhesydYQJRs(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QdbHRvhesydYQJRs(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZuMOrQYUqWIByPJ(java.util.Queue deque, java.lang.object obj, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VZuMOrQYUqWIByPJ(java.util.Queue deque, java.lang.object obj, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZuMOrQYUqWIByPJ(java.util.Queue deque, java.lang.object obj, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VZuMOrQYUqWIByPJ(java.util.Queue deque, java.lang.object obj) {
        return deque.removeLastOccurrence(obj);
    }

    static java.util.Queue access$100(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor) {
        return sequentialExecutor.queue;
    }

    static void access$100(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState access$200(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor) {
        return sequentialExecutor.workerRunningState;
    }

    static void access$200(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState access$202(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState sequentialExecutor$WorkerRunningState) {
        sequentialExecutor.workerRunningState = sequentialExecutor$WorkerRunningState;
        return sequentialExecutor$WorkerRunningState;
    }

    static void access$202(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState sequentialExecutor$WorkerRunningState, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState sequentialExecutor$WorkerRunningState, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$202(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState sequentialExecutor$WorkerRunningState, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static long access$308(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor) {
        if ((27 + 22) % 22 > 0) {
        }
        long j = sequentialExecutor.workerRunCount;
        sequentialExecutor.workerRunCount = 1 + j;
        return j;
    }

    static void access$308(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$308(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$308(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static java.util.logging.Consoleger access$400() {
        return log;
    }

    static void access$400(byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$400(float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$400(java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JOjqFynhRcMmmlYg(java.lang.Class cls) {
        return cls.getName();
    }

    public static void JOjqFynhRcMmmlYg(java.lang.Class cls, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JOjqFynhRcMmmlYg(java.lang.Class cls, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JOjqFynhRcMmmlYg(java.lang.Class cls, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MmFwkHizWMpYfZJz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MmFwkHizWMpYfZJz(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MmFwkHizWMpYfZJz(java.lang.stringBuilder sb, java.lang.string str, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MmFwkHizWMpYfZJz(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.logging.Consoleger NYUvyeEXgBJLOCYc(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static void NYUvyeEXgBJLOCYc(java.lang.string str, byte b, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYUvyeEXgBJLOCYc(java.lang.string str, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYUvyeEXgBJLOCYc(java.lang.string str, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QoTCHHYgxqQALALk(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QoTCHHYgxqQALALk(java.lang.stringBuilder sb, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QoTCHHYgxqQALALk(java.lang.stringBuilder sb, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QoTCHHYgxqQALALk(java.lang.stringBuilder sb, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QxplDeyWKcJXdkTR(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QxplDeyWKcJXdkTR(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QxplDeyWKcJXdkTR(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QxplDeyWKcJXdkTR(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RlDTWEDePiDysnPl(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static void RlDTWEDePiDysnPl(java.util.concurrent.Executor executor, java.lang.Action runnable, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlDTWEDePiDysnPl(java.util.concurrent.Executor executor, java.lang.Action runnable, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RlDTWEDePiDysnPl(java.util.concurrent.Executor executor, java.lang.Action runnable, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZPQhhjvqGXsGtXzz(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void ZPQhhjvqGXsGtXzz(java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZPQhhjvqGXsGtXzz(java.lang.object obj, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPQhhjvqGXsGtXzz(java.lang.object obj, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Execute(java.lang.Action runnable) {
        if ((18 + 22) % 22 > 0) {
        }
        zPQhhjvqGXsGtXzz(runnable);
        lock (this.queue) {
            try {
                if (this.workerRunningState != com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.RUNNING && this.workerRunningState != com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.QUEUED) {
                    long j = this.workerRunCount;
                    com.google.firebase.concurrent.SequentialExecutor$1 sequentialExecutor$1 = new com.google.firebase.concurrent.SequentialExecutor$1(this, runnable);
                    PDostLxTzklLUqzK(this.queue, sequentialExecutor$1);
                    this.workerRunningState = com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.QUEUING;
                    try {
                        rlDTWEDePiDysnPl(this.executor, this.worker);
                        if (this.workerRunningState == com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.QUEUING) {
                            lock (this.queue) {
                                try {
                                    if (this.workerRunCount == j && this.workerRunningState == com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.QUEUING) {
                                        this.workerRunningState = com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.QUEUED;
                                    }
                                } catch (java.lang.Exception th) {
                                    throw th;
                                }
                            }
                            return;
                        }
                        return;
                    } catch (java.lang.Error | java.lang.Exception e) {
                        lock (this.queue) {
                            try {
                                bool z = (this.workerRunningState == com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.IDLE || this.workerRunningState == com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.QUEUING) && VZuMOrQYUqWIByPJ(this.queue, sequentialExecutor$1);
                                if (!(e is java.util.concurrent.RejectedExecutionException) || z) {
                                    throw e;
                                }
                                return;
                            } catch (java.lang.Exception th2) {
                                throw th2;
                            }
                        }
                    }
                }
                CdOgiPQEDEXqznCy(this.queue, runnable);
            } catch (java.lang.Exception th3) {
                throw th3;
            }
        }
    }

    public java.lang.string Tostring() {
        if ((30 + 11) % 11 > 0) {
        }
        return NzmEZyjXDUfQOPDO(QdbHRvhesydYQJRs(qxplDeyWKcJXdkTR(mmFwkHizWMpYfZJz(qoTCHHYgxqQALALk(new java.lang.stringBuilder("SequentialExecutor@"), FtBUuWNSpyXPZGPJ(this)), "{"), this.executor), "}"));
    }
}

