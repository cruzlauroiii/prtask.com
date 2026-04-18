namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\u001a\u0016\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005¨\u0006\u0006"}, d2 = {"systemIdInfo", "Landroidx/work/impl/model/SystemIdInfo;", "generationalId", "Landroidx/work/impl/model/WorkGenerationalId;", "systemId", "", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SystemIdInfoKt {
    public static readonly androidx.work.impl.model.SystemIdInfo SystemIdInfo(androidx.work.impl.model.WorkGenerationalId generationalId, int i) {
        if ((10 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(generationalId, "generationalId");
        return new androidx.work.impl.model.SystemIdInfo(generationalId.getWorkSpecId(), generationalId.getGeneration(), i);
    }
}

