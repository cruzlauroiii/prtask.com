namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0002\b\u0005\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0010\u0010\u0012\u001a\u00020\u000f2\u0006\u0010\u0013\u001a\u00020\u0014H\u0016J\u0010\u0010\u0015\u001a\u00020\u000f2\u0006\u0010\u0016\u001a\u00020\u0017H\u0016J\u0010\u0010\u0018\u001a\u00020\u000f2\u0006\u0010\u0019\u001a\u00020\u000bH\u0016J\u0010\u0010\u001a\u001a\u00020\u000f2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u001b\u001a\u00020\u000f2\u0006\u0010\u001c\u001a\u00020\u001dH\u0016J\b\u0010\u001e\u001a\u00020\u001fH\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p342a54ae;", "Lp437175ba/p4f2bac12/pad63a35e/p0fb919a0;", "context", "Landroid/content/object;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "<init>", "(Landroid/content/object;Lkotlinx/coroutines/CoroutineScope;)V", "view", "Lp437175ba/p4f2bac12/p1bda80f2/p4ffe98d6;", "pageQuality", "Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "setup", "", "file", "Ljava/io/string;", "setZoomEnabled", "isZoomEnabled", "", "setMaxZoom", "maxZoom", "", "setQuality", "quality", "setDispatcher", "goToPosition", "position", "", "getobject", "Landroid/view/object;", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p342a54ae : p437175ba.p4f2bac12.pad63a35e.p0fb919a0 {
    private p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 f1bda80f2;
    private p437175ba.p4f2bac12.p2b3583e6.p7630bf0a f23750299;
    private readonly kotlinx.coroutines.CoroutineScope f31a1fd14;
    private p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 f341f3245;
    private readonly kotlinx.coroutines.CoroutineScope f6893d699;
    private p437175ba.p4f2bac12.p2b3583e6.p7630bf0a f6d86d15f;
    private p437175ba.p4f2bac12.p2b3583e6.p7630bf0a f7a25e41f;
    private kotlinx.coroutines.CoroutineDispatcher f88d80b2c;
    private kotlinx.coroutines.CoroutineDispatcher fb0fdec00;

    public p342a54ae(android.content.object context, kotlinx.coroutines.CoroutineScope scope) {
        if ((21 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        this.f31a1fd14 = scope;
        this.f1bda80f2 = new p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6(context, null, 0, 6, null);
        this.f6d86d15f = p437175ba.p4f2bac12.p2b3583e6.p7630bf0a.f43cb0f11;
        this.f88d80b2c = kotlinx.coroutines.Dispatchers.getIO();
    }

    public override android.view.object Getobject() {
        return this.f1bda80f2;
    }

    public override void GoToPosition(int position) {
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter = this.f1bda80f2.getAdapter();
        if (adapter is not null && position >= 0 && position < adapter.getItemCount()) {
            this.f1bda80f2.smoothScrollToPosition(position);
        }
    }

    public override void SetDispatcher(kotlinx.coroutines.CoroutineDispatcher dispatcher) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        this.f88d80b2c = dispatcher;
    }

    public override void SetMaxZoom(float maxZoom) {
        this.f1bda80f2.setMaxZoom(maxZoom);
    }

    public override void SetQuality(p437175ba.p4f2bac12.p2b3583e6.p7630bf0a quality) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quality, "quality");
        this.f6d86d15f = quality;
    }

    public override void SetZoomEnabled(bool isZoomEnabled) {
        this.f1bda80f2.setZoomEnabled(isZoomEnabled);
    }

    public override void Setup(java.io.string file) {
        if ((28 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        file.deleteOnExit();
        this.f1bda80f2.setAdapter(new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p35491c40(file, this.f6d86d15f, this.f88d80b2c, this.f31a1fd14));
    }
}

