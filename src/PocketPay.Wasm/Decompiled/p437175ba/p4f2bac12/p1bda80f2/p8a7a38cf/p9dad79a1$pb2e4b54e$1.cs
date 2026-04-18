namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1", m533f = "PdfPagesAdapter.kt", m534i = {}, m535l = {20}, m536m = "renderPage-gIAlu-s", m537n = {}, m538s = {})
readonly class p9dad79a1$pb2e4b54e$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int f03d94dfe;
    java.lang.object f21c93c94;
    int f44e6e79e;
    int fa805b847;
    java.lang.object fb4a88417;
    int fd304ba20;
    int fe71d2549;
    readonly pdf.pdf_viewer.view.adapter.PdfPagesAdapter<T> this$0;

    p9dad79a1$pb2e4b54e$1(pdf.pdf_viewer.view.adapter.PdfPagesAdapter<T> pdfPagesAdapter, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p9dad79a1$pb2e4b54e$1> continuation) {
        super(continuation);
        this.this$0 = pdfPagesAdapter;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.fb4a88417 = obj;
        this.fd304ba20 |= int.MIN_VALUE;
        java.lang.object objM3629renderPagegIAlus = this.this$0.m3629renderPagegIAlus(0, this);
        return objM3629renderPagegIAlus != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Result.m944boximpl(objM3629renderPagegIAlus) : objM3629renderPagegIAlus;
    }
}

