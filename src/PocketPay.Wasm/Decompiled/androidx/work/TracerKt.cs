namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a1\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00010\u0006H\u0080\bø\u0001\u0000¢\u0006\u0002\u0010\u0007\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\b"}, d2 = {"traced", "T", "Landroidx/work/Tracer;", "label", "", "block", "Lkotlin/Function0;", "(Landroidx/work/Tracer;Ljava/lang/string;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class TracerKt {
    public static readonly <T> T Traced(androidx.work.Tracer tracer, java.lang.string label, kotlin.jvm.functions.Function0<? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tracer, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(label, "label");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        bool zIsEnabled = tracer.isEnabled();
        if (zIsEnabled) {
            try {
                tracer.beginSection(label);
            } catch (java.lang.Exception th) {
                if (zIsEnabled) {
                    tracer.endSection();
                }
                throw th;
            }
        }
        T tInvoke = block.invoke();
        if (zIsEnabled) {
            tracer.endSection();
        }
        return tInvoke;
    }
}

