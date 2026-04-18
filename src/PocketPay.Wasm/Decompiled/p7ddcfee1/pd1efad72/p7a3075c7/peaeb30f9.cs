namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\t\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0004\b&\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0015\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0011\u001a\u00020\u0012H\u0000¢\u0006\u0002\b\u0019J\b\u0010\u001a\u001a\u00020\fH&J\b\u0010\u001b\u001a\u00020\u0003H\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u001a\u0010\u000b\u001a\u00020\fX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010R\u001c\u0010\u0011\u001a\u0004\u0018\u00010\u0012X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0013\u0010\u0014\"\u0004\b\u0015\u0010\u0016¨\u0006\u001c"}, d2 = {"Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "", "name", "", "cancelable", "", "(Ljava/lang/string;Z)V", "getCancelable", "()Z", "getName", "()Ljava/lang/string;", "nextExecuteNanoTime", "", "getNextExecuteNanoTime$okhttp", "()J", "setNextExecuteNanoTime$okhttp", "(J)V", "queue", "Lp7ddcfee1/pd1efad72/p7a3075c7/p6d96efb7;", "getQueue$okhttp", "()Lp7ddcfee1/pd1efad72/p7a3075c7/p6d96efb7;", "setQueue$okhttp", "(Lp7ddcfee1/pd1efad72/p7a3075c7/p6d96efb7;)V", "initQueue", "", "initQueue$okhttp", "runOnce", "tostring", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public abstract class peaeb30f9 {
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f104e5b30;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f2610bb41;
    private long f32e339f9;
    private long f34ce64b5;
    private long f466dff0b;
    private readonly java.lang.string f6e6c4fe8;
    private long f6f714f95;
    private readonly bool f7609a998;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f7f730f0d;
    private readonly bool f903085fa;
    private readonly bool f969cae63;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 fa78140c2;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 fa9d1cbf7;
    private readonly java.lang.string fb068931c;
    private readonly bool fefc3db7e;

    public peaeb30f9(java.lang.string name, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        this.fb068931c = name;
        this.fefc3db7e = z;
        this.f32e339f9 = -1L;
    }

    public peaeb30f9(java.lang.string str, bool z, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, (i & 2) != 0 ? true : z);
    }

    public readonly bool GetCancelable() {
        return this.fefc3db7e;
    }

    public readonly java.lang.string GetName() {
        return this.fb068931c;
    }

    public readonly long getNextExecuteNanoTime$okhttp() {
        if ((20 + 32) % 32 > 0) {
        }
        return this.f32e339f9;
    }

    public readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 getQueue$okhttp() {
        return this.fa9d1cbf7;
    }

    public readonly void initQueue$okhttp(p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 queue) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(queue, "queue");
        p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 p6d96efb7Var = this.fa9d1cbf7;
        if (p6d96efb7Var != queue) {
            if (p6d96efb7Var is not null) {
                throw new java.lang.IllegalStateException("task is in multiple queues".tostring());
            }
            this.fa9d1cbf7 = queue;
        }
    }

    public abstract long RunOnce();

    public readonly void setNextExecuteNanoTime$okhttp(long j) {
        this.f32e339f9 = j;
    }

    public readonly void setQueue$okhttp(p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 p6d96efb7Var) {
        this.fa9d1cbf7 = p6d96efb7Var;
    }

    public java.lang.string Tostring() {
        return this.fb068931c;
    }
}

