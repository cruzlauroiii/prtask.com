namespace WillowMaze.Wasm.Decompiled;

public class P564f72ba
{
    private readonly PdfRenderer F01bed2b5;
    private readonly PdfRenderer F02aa9250;
    private readonly Dictionary<string, object> F19cfe184;
    private readonly p7630bf0a F1a26c442;
    private readonly Dictionary<string, object> F23acd428;
    private readonly Mutex F25a01bb8;
    private readonly CoroutineDispatcher F27eeb399;
    private readonly PdfRenderer F297cdbb1;
    private readonly CoroutineDispatcher F2a78d59a;
    private readonly Mutex F309d7b9b;
    private readonly Mutex F6414d129;
    private readonly Dictionary<string, object> F6f1f5c7c;
    private readonly CoroutineDispatcher F7e66d914;
    private readonly CoroutineDispatcher F88d80b2c;
    private readonly Dictionary<string, object> F91a3fa2d;
    private readonly PdfRenderer Fae3904b1;
    private readonly p7630bf0a Fd66636b2;
    private readonly Mutex Fdfa96a7b;
    private readonly PdfRenderer Fe57e9ef1;
    private readonly CoroutineDispatcher Ff25e36df;
    private readonly Dictionary<string, object> Ff2861646;
    private readonly Lazy<object> PageCount$delegate;

    public static Dictionary<string, object> M2f3a7280(p564f72ba P0)
    {
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.f23acd428
        return default!;
    }

    public static Bitmap M374221d0(p564f72ba P0, int P1)
    {
        // call: p564f72ba.mb2e4b54e
        return default!;
    }

    public static object M77225507(p564f72ba P0, int P1, object P2)
    {
        // call: p564f72ba.me9c5efc3
        return default!;
    }

    private PdfRenderer M9017fad2(string P0)
    {
        // call: ParcelFileDescriptor.open
        // call: PdfRenderer.<init>
        // type: PdfRenderer
        return default!;
    }

    public static Mutex Ma4697c96(p564f72ba P0)
    {
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.f25a01bb8
        return default!;
    }

    private Bitmap Mb2e4b54e(int P0)
    {
        // str: "createBitmap(...)"
        // call: AutoCloseableKt.closeFinally
        // call: PdfRenderer.openPage
        // call: p7630bf0a.getValue
        // call: PdfRenderer$Page.getHeight
        // call: PdfRenderer$Page.getWidth
        // call: Bitmap.createBitmap
        // call: Intrinsics.checkNotNullExpressionValue
        // call: PdfRenderer$Page.render
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.fd66636b2
        // field: android.graphics.Bitmap$Config.ARGB_8888
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.fe57e9ef1
        return default!;
    }

    public static int Mc447c397(p564f72ba P0)
    {
        // call: p564f72ba.me25ff71c
        return 0;
    }

    private static int Me25ff71c(p564f72ba P0)
    {
        // call: PdfRenderer.getPageCount
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.fe57e9ef1
        return 0;
    }

    private object Me9c5efc3(int P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: Mutex.unlock
        // call: IllegalStateException.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: Boxing.boxInt
        // call: Dictionary<string, object>.get
        // call: p564f72ba$pe9c5efc3$2$1$1.<init>
        // call: CoroutineScopeKt.coroutineScope
        // call: ResultKt.throwOnFailure
        // call: Dictionary<string, object>.put
        // call: p564f72ba$pe9c5efc3$1.<init>
        // call: Mutex.lock
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1.L$2
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1.L$1
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1.I$0
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1.fd304ba20
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.f25a01bb8
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.f23acd428
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1.L$0
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1.fb4a88417
        // type: IllegalStateException
        // type: p564f72ba$pe9c5efc3$1
        // type: p564f72ba$pe9c5efc3$2$1$1
        return default!;
    }

    public int GetPageCount()
    {
        // call: System.Numerics.BigInteger.intValue
        // call: Lazy<object>.getValue
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.pageCount$delegate
        return 0;
    }

    public object Render-gIAlu-s(int P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: p564f72ba$p9e5f0bb3$2.<init>
        // call: BuildersKt.withContext
        // call: p564f72ba$p9e5f0bb3$1.<init>
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: Result.unbox-impl
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba.f88d80b2c
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1.fd304ba20
        // field: p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1.fb4a88417
        // type: IllegalStateException
        // type: p564f72ba$p9e5f0bb3$2
        // type: p564f72ba$p9e5f0bb3$1
        return default!;
    }

}
