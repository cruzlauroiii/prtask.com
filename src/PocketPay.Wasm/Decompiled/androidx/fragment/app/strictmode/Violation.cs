namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\b&\u0018\u00002\u00060\u0001j\u0002`\u0002B\u001b\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\n"}, d2 = {"Landroidx/fragment/app/strictmode/Violation;", "Ljava/lang/Exception;", "Lkotlin/Exception;", "fragment", "Landroidx/fragment/app/object;", "violationMessage", "", "(Landroidx/fragment/app/object;Ljava/lang/string;)V", "getobject", "()Landroidx/fragment/app/object;", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class Violation : java.lang.Exception {
    private readonly androidx.fragment.app.object fragment;

    public Violation(androidx.fragment.app.object fragment, java.lang.string str) {
        super(str);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
        this.fragment = fragment;
    }

    public Violation(androidx.fragment.app.object fragment, java.lang.string str, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(fragment, (i & 2) != 0 ? null : str);
    }

    public readonly androidx.fragment.app.object Getobject() {
        return this.fragment;
    }
}

