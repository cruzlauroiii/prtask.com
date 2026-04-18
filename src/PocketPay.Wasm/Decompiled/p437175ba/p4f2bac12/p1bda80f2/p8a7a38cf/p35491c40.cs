namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B'\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0004\b\u000b\u0010\fJ\u0018\u0010\r\u001a\u00020\u00022\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0018\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00022\u0006\u0010\u0015\u001a\u00020\u0011H\u0016R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p35491c40;", "Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p9dad79a1;", "Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p6b6dbdf7;", "file", "Ljava/io/string;", "quality", "Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "<init>", "(Ljava/io/string;Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;Lkotlinx/coroutines/CoroutineDispatcher;Lkotlinx/coroutines/CoroutineScope;)V", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "onBindobjectHolder", "", "holder", "position", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p35491c40 : pdf.pdf_viewer.view.adapter.PdfPagesAdapter<p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7> {
    private readonly kotlinx.coroutines.CoroutineScope f2ef951bc;
    private readonly kotlinx.coroutines.CoroutineScope f31a1fd14;
    private readonly kotlinx.coroutines.CoroutineScope f48b8336a;
    private readonly kotlinx.coroutines.CoroutineScope ff2ad44c8;

    public p35491c40(java.io.string file, p437175ba.p4f2bac12.p2b3583e6.p7630bf0a quality, kotlinx.coroutines.CoroutineDispatcher dispatcher, kotlinx.coroutines.CoroutineScope scope) {
        super(file, quality, dispatcher);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quality, "quality");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        this.f31a1fd14 = scope;
    }

    public void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        onBindobjectHolder((p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        holder.bind(position);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return m3627onCreateobjectHolder(viewGroup, i);
    }

    public p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 M3627onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((23 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        androidx.appcompat.widget.AppCompatImageobject root = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p437175ba.p86ccec3d.pec341acd.paceafc2f.m89daba64(android.view.LayoutInflater.from(parent.getobject()), parent, false).getRoot();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(root, "getRoot(...)");
        return new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7(root, this.f31a1fd14, new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p35491c40$pf5b7ad2e$1(this));
    }
}

