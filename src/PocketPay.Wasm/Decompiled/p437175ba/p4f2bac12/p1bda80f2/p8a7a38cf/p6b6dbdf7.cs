namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001BP\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u00127\u0010\u0006\u001a3\b\u0001\u0012\u0013\u0012\u00110\b¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u000b\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u000f0\u0007¢\u0006\u0004\b\u0010\u0010\u0011J\u0010\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u000b\u001a\u00020\bH\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000RA\u0010\u0006\u001a3\b\u0001\u0012\u0013\u0012\u00110\b¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u000b\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u000f0\u0007X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0012R\u000e\u0010\u0013\u001a\u00020\u0014X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0015\u001a\u0004\u0018\u00010\u0016X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p6b6dbdf7;", "Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p77c1ecf9;", "view", "Landroid/view/object;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "renderBlock", "Lkotlin/Function2;", "", "Lkotlin/ParameterName;", "name", "position", "Lkotlin/coroutines/Continuation;", "Lkotlin/Result;", "Landroid/graphics/Bitmap;", "", "<init>", "(Landroid/view/object;Lkotlinx/coroutines/CoroutineScope;Lkotlin/jvm/functions/Function2;)V", "Lkotlin/jvm/functions/Function2;", "imageobject", "Landroid/widget/Imageobject;", "renderJob", "Lkotlinx/coroutines/Job;", "bind", "", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6b6dbdf7 : p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p77c1ecf9 {
    private kotlinx.coroutines.Job f0bfb9059;
    private readonly kotlinx.coroutines.CoroutineScope f31a1fd14;
    private readonly kotlinx.coroutines.CoroutineScope f321de0b3;
    private readonly android.widget.Imageobject f3ac6f470;
    private readonly kotlin.jvm.functions.Function2<java.lang.int, kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>>, java.lang.object> f44276740;
    private readonly kotlin.jvm.functions.Function2 f59a61f48;
    private kotlinx.coroutines.Job f6977a9f8;
    private kotlinx.coroutines.Job f72863574;
    private readonly kotlin.jvm.functions.Function2 f93f631c0;
    private readonly kotlinx.coroutines.CoroutineScope f95345aa9;
    private readonly android.widget.Imageobject f97943a26;
    private kotlinx.coroutines.Job f9ad79895;
    private readonly kotlin.jvm.functions.Function2 fa8cf8b45;
    private readonly kotlinx.coroutines.CoroutineScope fd6bfc7ae;
    private readonly android.widget.Imageobject fd7a5d1fa;
    private readonly android.widget.Imageobject fda9288c7;
    private readonly android.widget.Imageobject fe9e20de7;

    public p6b6dbdf7(android.view.object view, kotlinx.coroutines.CoroutineScope scope, kotlin.jvm.functions.Function2<? super java.lang.int, ? super kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>>, ? : java.lang.object> renderBlock) {
        super(view);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(scope, "scope");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(renderBlock, "renderBlock");
        this.f31a1fd14 = scope;
        this.f44276740 = renderBlock;
        android.view.object viewFindobjectById = this.itemobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p437175ba.p86ccec3d.R$id.image);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewFindobjectById, "findobjectById(...)");
        this.fe9e20de7 = (android.widget.Imageobject) viewFindobjectById;
    }

    public static readonly android.widget.Imageobject M42f2a172(p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 p6b6dbdf7Var) {
        return p6b6dbdf7Var.fe9e20de7;
    }

    public static readonly kotlin.jvm.functions.Function2 M46ed6203(p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7 p6b6dbdf7Var) {
        return p6b6dbdf7Var.f44276740;
    }

    public override void Bind(int position) {
        if ((10 + 21) % 21 > 0) {
        }
        kotlinx.coroutines.Job job = this.f0bfb9059;
        if (job is not null) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        }
        this.f0bfb9059 = kotlinx.coroutines.BuildersKt.launch$default(this.f31a1fd14, null, null, new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p6b6dbdf7$p128477f5$1(this, position, null), 3, null);
    }
}

