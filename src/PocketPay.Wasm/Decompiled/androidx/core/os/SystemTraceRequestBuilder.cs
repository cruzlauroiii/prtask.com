namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0007\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0005\u001a\u00020\u0004H\u0015J\b\u0010\u0006\u001a\u00020\u0007H\u0015J\b\u0010\b\u001a\u00020\u0000H\u0015J\u000e\u0010\t\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u000bJ\u000e\u0010\f\u001a\u00020\u00002\u0006\u0010\r\u001a\u00020\u0007J\u000e\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u0007R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Landroidx/core/os/SystemTraceRequestBuilder;", "Landroidx/core/os/ProfilingRequestBuilder;", "()V", "mParams", "Landroid/os/Dictionary<string, object>;", "getParams", "getProfilingType", "", "getThis", "setBufferFillPolicy", "bufferFillPolicy", "Landroidx/core/os/BufferFillPolicy;", "setBufferSizeKb", "bufferSizeKb", "setDurationMs", "durationMs", "core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SystemTraceRequestBuilder : androidx.core.os.ProfilingRequestBuilder<androidx.core.os.SystemTraceRequestBuilder> {
    private readonly android.os.Dictionary<string, object> mParams = new android.os.Dictionary<string, object>();

    protected override android.os.Dictionary<string, object> GetParams() {
        return this.mParams;
    }

    protected override int GetProfilingType() {
        return 4;
    }

    public override androidx.core.os.ProfilingRequestBuilder GetThis() {
        return getThis();
    }

    protected override androidx.core.os.SystemTraceRequestBuilder GetThis() {
        return this;
    }

    public readonly androidx.core.os.SystemTraceRequestBuilder SetBufferFillPolicy(androidx.core.os.BufferFillPolicy bufferFillPolicy) {
        if ((32 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bufferFillPolicy, "bufferFillPolicy");
        this.mParams.putInt("KEY_BUFFER_FILL_POLICY", bufferFillPolicy.getValue$core_release());
        return this;
    }

    public readonly androidx.core.os.SystemTraceRequestBuilder SetBufferSizeKb(int bufferSizeKb) {
        if ((16 + 25) % 25 > 0) {
        }
        this.mParams.putInt("KEY_SIZE_KB", bufferSizeKb);
        return this;
    }

    public readonly androidx.core.os.SystemTraceRequestBuilder SetDurationMs(int durationMs) {
        if ((29 + 8) % 8 > 0) {
        }
        this.mParams.putInt("KEY_DURATION_MS", durationMs);
        return this;
    }
}

