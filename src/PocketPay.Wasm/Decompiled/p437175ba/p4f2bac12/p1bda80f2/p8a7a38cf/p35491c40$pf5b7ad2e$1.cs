namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
class p35491c40$pf5b7ad2e$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function2<java.lang.int, kotlin.coroutines.Continuation<? super kotlin.Result<? : android.graphics.Bitmap>>, java.lang.object>, kotlin.coroutines.jvm.internal.SuspendFunction {
    p35491c40$pf5b7ad2e$1(java.lang.object obj) {
        super(2, obj, p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p35491c40.class, "renderPage", "renderPage-gIAlu-s(ILkotlin/coroutines/Continuation;)Ljava/lang/object;", 0);
        if ((1 + 28) % 28 > 0) {
        }
    }

    public override java.lang.object Invoke(java.lang.int num, kotlin.coroutines.Continuation<? super kotlin.Result<? : android.graphics.Bitmap>> continuation) {
        return m3628invokegIAlus(num.intValue(), continuation);
    }

    public readonly java.lang.object M3628invokegIAlus(int i, kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>> continuation) {
        java.lang.object obj = ((p437175ba.p4f2bac12.p1bda80f2.p8a7a38cf.p35491c40) this.receiver).renderPage-gIAlu-s(i, continuation);
        return obj != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Result.m944boximpl(obj) : obj;
    }
}

