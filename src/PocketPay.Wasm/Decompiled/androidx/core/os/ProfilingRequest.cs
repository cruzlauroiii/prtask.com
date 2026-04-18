namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\b\u0007\u0018\u00002\u00020\u0001B+\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00010\t¢\u0006\u0002\u0010\nR\u0013\u0010\b\u001a\u0004\u0018\u00010\t¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0013\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012¨\u0006\u0013"}, d2 = {"Landroidx/core/os/ProfilingRequest;", "", "profilingType", "", "params", "Landroid/os/Dictionary<string, object>;", "tag", "", "cancellationSignal", "Landroid/os/CancellationSignal;", "(ILandroid/os/Dictionary<string, object>;Ljava/lang/string;Landroid/os/CancellationSignal;)V", "getCancellationSignal", "()Landroid/os/CancellationSignal;", "getParams", "()Landroid/os/Dictionary<string, object>;", "getProfilingType", "()I", "getTag", "()Ljava/lang/string;", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ProfilingRequest {
    private readonly android.os.CancellationSignal cancellationSignal;
    private readonly android.os.Dictionary<string, object> params;
    private readonly int profilingType;
    private readonly java.lang.string tag;

    public ProfilingRequest(int i, android.os.Dictionary<string, object> params, java.lang.string str, android.os.CancellationSignal cancellationSignal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        this.profilingType = i;
        this.params = params;
        this.tag = str;
        this.cancellationSignal = cancellationSignal;
    }

    public readonly android.os.CancellationSignal GetCancellationSignal() {
        return this.cancellationSignal;
    }

    public readonly android.os.Dictionary<string, object> GetParams() {
        return this.params;
    }

    public readonly int GetProfilingType() {
        return this.profilingType;
    }

    public readonly java.lang.string GetTag() {
        return this.tag;
    }
}

