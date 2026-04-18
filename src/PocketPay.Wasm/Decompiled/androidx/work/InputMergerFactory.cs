namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b&\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006H&J\u0012\u0010\u0007\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\b"}, d2 = {"Landroidx/work/InputMergerFactory;", "", "()V", "createInputMerger", "Landroidx/work/InputMerger;", "className", "", "createInputMergerWithDefaultFallback", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class InputMergerFactory {
    public abstract androidx.work.InputMerger CreateInputMerger(java.lang.string className);

    public readonly androidx.work.InputMerger CreateInputMergerWithDefaultFallback(java.lang.string className) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(className, "className");
        androidx.work.InputMerger inputMergerCreateInputMerger = createInputMerger(className);
        return inputMergerCreateInputMerger is not null ? inputMergerCreateInputMerger : androidx.work.InputMergerKt.fromClassName(className);
    }
}

