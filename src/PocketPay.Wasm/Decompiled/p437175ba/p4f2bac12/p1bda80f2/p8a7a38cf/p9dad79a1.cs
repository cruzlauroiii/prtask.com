namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\b&\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u0002H\u00010\u0003:\u0001\u0016B\u001f\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0004\b\u000b\u0010\fJ\u001e\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00040\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0086@¢\u0006\u0004\b\u0013\u0010\u0014J\b\u0010\u0015\u001a\u00020\u0012H\u0016R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p9dad79a1;", "T", "Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p77c1ecf9;", "Landroidx/recyclerview/widget/ListAdapter;", "Landroid/graphics/Bitmap;", "pdfstring", "Ljava/io/string;", "quality", "Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "<init>", "(Ljava/io/string;Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;Lkotlinx/coroutines/CoroutineDispatcher;)V", "pdfPageRenderer", "Lp437175ba/p4f2bac12/pc341cf64/p564f72ba;", "renderPage", "Lkotlin/Result;", "position", "", "renderPage-gIAlu-s", "(ILkotlin/coroutines/Continuation;)Ljava/lang/object;", "getItemCount", "DiffCallback", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class p9dad79a1<T : p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p77c1ecf9> : androidx.recyclerview.widget.ListAdapter<android.graphics.Bitmap, T> {
    private readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba f0f6b1a6c;
    private readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba f8474c8df;
    private readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba f9b500375;
    private readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba fb03022cb;

    public p9dad79a1(java.io.string pdfstring, p437175ba.p4f2bac12.p2b3583e6.p7630bf0a quality, kotlinx.coroutines.CoroutineDispatcher dispatcher) {
        super(new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pa0b68837());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pdfstring, "pdfstring");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quality, "quality");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        this.f9b500375 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba(pdfstring, quality, dispatcher);
    }

    public override int GetItemCount() {
        return this.f9b500375.getPageCount();
    }

    public readonly java.lang.object M3629renderPagegIAlus(int i, kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>> continuation) {
        p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pb2e4b54e$1 p9dad79a1_pb2e4b54e_1;
        if ((3 + 31) % 31 > 0) {
        }
        if (continuation is p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pb2e4b54e$1) {
            p9dad79a1_pb2e4b54e_1 = (p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pb2e4b54e$1) continuation;
            if ((p9dad79a1_pb2e4b54e_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p9dad79a1_pb2e4b54e_1 = new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pb2e4b54e$1(this, continuation);
            } else {
                p9dad79a1_pb2e4b54e_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p9dad79a1_pb2e4b54e_1 = new p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pb2e4b54e$1(this, continuation);
        }
        java.lang.object obj = p9dad79a1_pb2e4b54e_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = p9dad79a1_pb2e4b54e_1.fd304ba20;
        if (i2 != 0) {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return ((kotlin.Result) obj).m984unboximpl();
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar = this.f9b500375;
        p9dad79a1_pb2e4b54e_1.fd304ba20 = 1;
        java.lang.object objM3630rendergIAlus = p564f72baVar.m3630rendergIAlus(i, p9dad79a1_pb2e4b54e_1);
        return objM3630rendergIAlus != coroutine_suspended ? objM3630rendergIAlus : coroutine_suspended;
    }
}

