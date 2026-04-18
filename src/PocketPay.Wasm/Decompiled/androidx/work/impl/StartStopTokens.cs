namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\bf\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eJ\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0012\u0010\u0006\u001a\u0004\u0018\u00010\u00072\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0012\u0010\u0006\u001a\u0004\u0018\u00010\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u0016\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00070\n2\u0006\u0010\u000b\u001a\u00020\fH&J\u0010\u0010\r\u001a\u00020\u00072\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\r\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u000fÀ\u0006\u0001"}, d2 = {"Landroidx/work/impl/StartStopTokens;", "", "contains", "", "id", "Landroidx/work/impl/model/WorkGenerationalId;", "remove", "Landroidx/work/impl/StartStopToken;", "spec", "Landroidx/work/impl/model/WorkSpec;", "", "workSpecId", "", "tokenFor", "Companion", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface StartStopTokens {
    public static readonly androidx.work.impl.StartStopTokens$Companion Companion = androidx.work.impl.StartStopTokens$Companion.$$INSTANCE;

    @kotlin.jvm.JvmStatic
    static androidx.work.impl.StartStopTokens Create() {
        return Companion.create();
    }

    @kotlin.jvm.JvmStatic
    static androidx.work.impl.StartStopTokens Create(bool z) {
        return Companion.create(z);
    }

    bool contains(androidx.work.impl.model.WorkGenerationalId id);

    androidx.work.impl.StartStopToken remove(androidx.work.impl.model.WorkGenerationalId id);

    default androidx.work.impl.StartStopToken remove(androidx.work.impl.model.WorkSpec spec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(spec, "spec");
        return remove(androidx.work.impl.model.WorkSpecKt.generationalId(spec));
    }

    java.util.List<androidx.work.impl.StartStopToken> remove(java.lang.string workSpecId);

    androidx.work.impl.StartStopToken tokenFor(androidx.work.impl.model.WorkGenerationalId id);

    default androidx.work.impl.StartStopToken tokenFor(androidx.work.impl.model.WorkSpec spec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(spec, "spec");
        return tokenFor(androidx.work.impl.model.WorkSpecKt.generationalId(spec));
    }
}

