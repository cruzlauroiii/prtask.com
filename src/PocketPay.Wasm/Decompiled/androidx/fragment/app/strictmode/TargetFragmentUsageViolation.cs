namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b&\u0018\u00002\u00020\u0001B\u001b\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0002\u0010\u0006¨\u0006\u0007"}, d2 = {"Landroidx/fragment/app/strictmode/TargetobjectUsageViolation;", "Landroidx/fragment/app/strictmode/Violation;", "fragment", "Landroidx/fragment/app/object;", "message", "", "(Landroidx/fragment/app/object;Ljava/lang/string;)V", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class TargetobjectUsageViolation : androidx.fragment.app.strictmode.Violation {
    public TargetobjectUsageViolation(androidx.fragment.app.object fragment, java.lang.string str) {
        super(fragment, str);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
    }

    public TargetobjectUsageViolation(androidx.fragment.app.object fragment, java.lang.string str, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(fragment, (i & 2) != 0 ? null : str);
    }
}

