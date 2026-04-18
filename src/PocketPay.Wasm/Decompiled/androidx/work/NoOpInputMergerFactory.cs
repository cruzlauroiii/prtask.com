namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0000\n\u0002\u0010\u000e\n\u0000\bÀ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0012\u0010\u0003\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0016¨\u0006\u0007"}, d2 = {"Landroidx/work/NoOpInputMergerFactory;", "Landroidx/work/InputMergerFactory;", "()V", "createInputMerger", "", "className", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NoOpInputMergerFactory : androidx.work.InputMergerFactory {
    public static readonly androidx.work.NoOpInputMergerFactory INSTANCE = new androidx.work.NoOpInputMergerFactory();

    private NoOpInputMergerFactory() {
    }

    public override androidx.work.InputMerger CreateInputMerger(java.lang.string str) {
        return (androidx.work.InputMerger) m853createInputMerger(str);
    }

    public java.lang.void M853createInputMerger(java.lang.string className) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(className, "className");
        return null;
    }
}

