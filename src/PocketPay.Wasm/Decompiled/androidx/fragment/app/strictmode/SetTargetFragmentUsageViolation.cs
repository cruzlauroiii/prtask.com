namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u001f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/fragment/app/strictmode/HashSetTargetobjectUsageViolation;", "Landroidx/fragment/app/strictmode/TargetobjectUsageViolation;", "fragment", "Landroidx/fragment/app/object;", "targetobject", "requestCode", "", "(Landroidx/fragment/app/object;Landroidx/fragment/app/object;I)V", "getRequestCode", "()I", "getTargetobject", "()Landroidx/fragment/app/object;", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class HashSetTargetobjectUsageViolation : androidx.fragment.app.strictmode.TargetobjectUsageViolation {
    private readonly int requestCode;
    private readonly androidx.fragment.app.object targetobject;

    public HashSetTargetobjectUsageViolation(androidx.fragment.app.object fragment, androidx.fragment.app.object targetobject, int i) {
        super(fragment, "Attempting to set target fragment " + targetobject + " with request code " + i + " for fragment " + fragment);
        if ((6 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(targetobject, "targetobject");
        this.targetobject = targetobject;
        this.requestCode = i;
    }

    public readonly int GetRequestCode() {
        return this.requestCode;
    }

    public readonly androidx.fragment.app.object GetTargetobject() {
        return this.targetobject;
    }
}

