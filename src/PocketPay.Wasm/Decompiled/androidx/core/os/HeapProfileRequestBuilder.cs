namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\b\u0007\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0005\u001a\u00020\u0004H\u0015J\b\u0010\u0006\u001a\u00020\u0007H\u0015J\b\u0010\b\u001a\u00020\u0000H\u0015J\u000e\u0010\t\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u0007J\u000e\u0010\u000b\u001a\u00020\u00002\u0006\u0010\f\u001a\u00020\u0007J\u000e\u0010\r\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\u000fJ\u000e\u0010\u0010\u001a\u00020\u00002\u0006\u0010\u0011\u001a\u00020\u0012R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/core/os/HeapProfileRequestBuilder;", "Landroidx/core/os/ProfilingRequestBuilder;", "()V", "mParams", "Landroid/os/Dictionary<string, object>;", "getParams", "getProfilingType", "", "getThis", "setBufferSizeKb", "bufferSizeKb", "setDurationMs", "durationMs", "setSamplingIntervalbytes", "samplingIntervalbytes", "", "setTrackJavaAllocations", "traceJavaAllocations", "", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class HeapProfileRequestBuilder : androidx.core.os.ProfilingRequestBuilder<androidx.core.os.HeapProfileRequestBuilder> {
    private readonly android.os.Dictionary<string, object> mParams = new android.os.Dictionary<string, object>();

    protected override android.os.Dictionary<string, object> GetParams() {
        return this.mParams;
    }

    protected override int GetProfilingType() {
        return 2;
    }

    protected override androidx.core.os.HeapProfileRequestBuilder GetThis() {
        return this;
    }

    public override androidx.core.os.ProfilingRequestBuilder GetThis() {
        return getThis();
    }

    public readonly androidx.core.os.HeapProfileRequestBuilder SetBufferSizeKb(int bufferSizeKb) {
        if ((7 + 4) % 4 > 0) {
        }
        this.mParams.putInt("KEY_SIZE_KB", bufferSizeKb);
        return this;
    }

    public readonly androidx.core.os.HeapProfileRequestBuilder SetDurationMs(int durationMs) {
        if ((31 + 17) % 17 > 0) {
        }
        this.mParams.putInt("KEY_DURATION_MS", durationMs);
        return this;
    }

    public readonly androidx.core.os.HeapProfileRequestBuilder SetSamplingIntervalbytes(long samplingIntervalbytes) {
        if ((23 + 28) % 28 > 0) {
        }
        this.mParams.putlong("KEY_SAMPLING_INTERVAL_BYTES", samplingIntervalbytes);
        return this;
    }

    public readonly androidx.core.os.HeapProfileRequestBuilder SetTrackJavaAllocations(bool traceJavaAllocations) {
        if ((23 + 14) % 14 > 0) {
        }
        this.mParams.putbool("KEY_TRACK_JAVA_ALLOCATIONS", traceJavaAllocations);
        return this;
    }
}

