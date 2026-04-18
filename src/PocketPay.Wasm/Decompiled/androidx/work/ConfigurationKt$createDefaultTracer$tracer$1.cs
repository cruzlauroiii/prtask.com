namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\u0005H\u0016J\u0018\u0010\n\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\u000b\u001a\u00020\u0003H\u0016J\b\u0010\f\u001a\u00020\rH\u0016¨\u0006\u000e"}, d2 = {"androidx/work/ConfigurationKt$createDefaultTracer$tracer$1", "Landroidx/work/Tracer;", "beginAsyncSection", "", "methodName", "", "cookie", "", "beginSection", "label", "endAsyncSection", "endSection", "isEnabled", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ConfigurationKt$createDefaultTracer$tracer$1 : androidx.work.Tracer {
    ConfigurationKt$createDefaultTracer$tracer$1() {
    }

    public override void BeginAsyncSection(java.lang.string methodName, int cookie) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(methodName, "methodName");
        androidx.tracing.Trace.beginAsyncSection(methodName, cookie);
    }

    public override void BeginSection(java.lang.string label) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(label, "label");
        androidx.tracing.Trace.beginSection(label);
    }

    public override void EndAsyncSection(java.lang.string methodName, int cookie) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(methodName, "methodName");
        androidx.tracing.Trace.endAsyncSection(methodName, cookie);
    }

    public override void EndSection() {
        androidx.tracing.Trace.endSection();
    }

    public override bool IsEnabled() {
        return androidx.tracing.Trace.isEnabled();
    }
}

