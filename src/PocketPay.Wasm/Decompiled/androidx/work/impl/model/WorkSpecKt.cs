namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a\n\u0010\u0002\u001a\u00020\u0003*\u00020\u0004\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0005"}, d2 = {"NOT_ENQUEUED", "", "generationalId", "Landroidx/work/impl/model/WorkGenerationalId;", "Landroidx/work/impl/model/WorkSpec;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class WorkSpecKt {
    private static readonly long NOT_ENQUEUED = -1;

    public static readonly androidx.work.impl.model.WorkGenerationalId GenerationalId(androidx.work.impl.model.WorkSpec workSpec) {
        if ((25 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "<this>");
        return new androidx.work.impl.model.WorkGenerationalId(workSpec.id, workSpec.getGeneration());
    }
}

