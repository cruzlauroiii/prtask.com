namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pf0c561f3;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "itemobject", "Landroid/view/object;", "<init>", "(Landroid/view/object;)V", "headerTitle", "Landroid/widget/Textobject;", "bind", "", "header", "Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/pac5552fd/p8be42052;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf0c561f3 : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private readonly android.widget.Textobject f6834d7dd;
    private readonly android.widget.Textobject fd40dca47;

    public pf0c561f3(android.view.object itemobject) {
        super(itemobject);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(itemobject, "itemobject");
        android.view.object viewFindobjectById = itemobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.header_title);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewFindobjectById, "findobjectById(...)");
        this.fd40dca47 = (android.widget.Textobject) viewFindobjectById;
    }

    public readonly void Bind(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052 header) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(header, "header");
        this.fd40dca47.setText(header.getTitle());
    }
}

