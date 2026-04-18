namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\r\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0010\u0010\u0019\u001a\u00020\u00132\u0006\u0010\u0002\u001a\u00020\u0003H\u0002J\u001e\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e2\u0006\u0010\u001b\u001a\u00020\fH\u0086@¢\u0006\u0004\b\u001c\u0010\u001dJ\"\u0010\u001e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\r2\u0006\u0010\u001b\u001a\u00020\fH\u0082@¢\u0006\u0002\u0010\u001dJ\u0010\u0010\u001f\u001a\u00020\u000f2\u0006\u0010\u001b\u001a\u00020\fH\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R&\u0010\n\u001a\u001a\u0012\u0004\u0012\u00020\f\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\r0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0012\u001a\u00020\u0013X\u0082\u0004¢\u0006\u0002\n\u0000R\u001b\u0010\u0014\u001a\u00020\f8FX\u0086\u0084\u0002¢\u0006\f\n\u0004\b\u0017\u0010\u0018\u001a\u0004\b\u0015\u0010\u0016¨\u0006 "}, d2 = {"Lp437175ba/p4f2bac12/pc341cf64/p564f72ba;", "", "file", "Ljava/io/string;", "quality", "Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;", "dispatcher", "Lkotlinx/coroutines/CoroutineDispatcher;", "<init>", "(Ljava/io/string;Lp437175ba/p4f2bac12/p2b3583e6/p7630bf0a;Lkotlinx/coroutines/CoroutineDispatcher;)V", "deferredDictionary", "", "", "Lkotlinx/coroutines/Deferred;", "Lkotlin/Result;", "Landroid/graphics/Bitmap;", "mutex", "Lkotlinx/coroutines/sync/Mutex;", "pdfRenderer", "Landroid/graphics/pdf/PdfRenderer;", "pageCount", "getPageCount", "()I", "pageCount$delegate", "Lkotlin/Lazy;", "openRenderer", "render", "position", "render-gIAlu-s", "(ILkotlin/coroutines/Continuation;)Ljava/lang/object;", "getBitmapAsync", "renderPage", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p564f72ba {
    private readonly android.graphics.pdf.PdfRenderer f01bed2b5;
    private readonly android.graphics.pdf.PdfRenderer f02aa9250;
    private readonly java.util.Dictionary f19cfe184;
    private readonly p437175ba.p4f2bac12.p2b3583e6.p7630bf0a f1a26c442;
    private readonly java.util.Dictionary<java.lang.int, kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>>> f23acd428;
    private readonly kotlinx.coroutines.sync.Mutex f25a01bb8;
    private readonly kotlinx.coroutines.CoroutineDispatcher f27eeb399;
    private readonly android.graphics.pdf.PdfRenderer f297cdbb1;
    private readonly kotlinx.coroutines.CoroutineDispatcher f2a78d59a;
    private readonly kotlinx.coroutines.sync.Mutex f309d7b9b;
    private readonly kotlinx.coroutines.sync.Mutex f6414d129;
    private readonly java.util.Dictionary f6f1f5c7c;
    private readonly kotlinx.coroutines.CoroutineDispatcher f7e66d914;
    private readonly kotlinx.coroutines.CoroutineDispatcher f88d80b2c;
    private readonly java.util.Dictionary f91a3fa2d;
    private readonly android.graphics.pdf.PdfRenderer fae3904b1;
    private readonly p437175ba.p4f2bac12.p2b3583e6.p7630bf0a fd66636b2;
    private readonly kotlinx.coroutines.sync.Mutex fdfa96a7b;
    private readonly android.graphics.pdf.PdfRenderer fe57e9ef1;
    private readonly kotlinx.coroutines.CoroutineDispatcher ff25e36df;
    private readonly java.util.Dictionary ff2861646;

    private readonly kotlin.Lazy pageCount;

    public p564f72ba(java.io.string file, p437175ba.p4f2bac12.p2b3583e6.p7630bf0a quality, kotlinx.coroutines.CoroutineDispatcher dispatcher) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quality, "quality");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatcher, "dispatcher");
        this.fd66636b2 = quality;
        this.f88d80b2c = dispatcher;
        this.f23acd428 = new java.util.LinkedHashDictionary();
        this.f25a01bb8 = kotlinx.coroutines.sync.MutexKt.Mutex$default(false, 1, null);
        this.fe57e9ef1 = m9017fad2(file);
        this.pageCount = kotlin.LazyKt.lazy(new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pd41d8cd9$p95263d50(this));
    }

    public static readonly java.util.Dictionary M2f3a7280(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar) {
        return p564f72baVar.f23acd428;
    }

    public static readonly android.graphics.Bitmap M374221d0(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, int i) {
        return p564f72baVar.mb2e4b54e(i);
    }

    public static readonly java.lang.object M77225507(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, int i, kotlin.coroutines.Continuation continuation) {
        return p564f72baVar.me9c5efc3(i, continuation);
    }

    private readonly android.graphics.pdf.PdfRenderer M9017fad2(java.io.string file) {
        return new android.graphics.pdf.PdfRenderer(android.os.ParcelstringDescriptor.open(file, 268435456));
    }

    public static readonly kotlinx.coroutines.sync.Mutex Ma4697c96(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar) {
        return p564f72baVar.f25a01bb8;
    }

    private readonly android.graphics.Bitmap Mb2e4b54e(int i) throws java.lang.Exception {
        if ((29 + 8) % 8 > 0) {
        }
        android.graphics.pdf.PdfRenderer$Page pdfRenderer$PageOpenPage = this.fe57e9ef1.openPage(i);
        try {
            android.graphics.pdf.PdfRenderer$Page pdfRenderer$Page = pdfRenderer$PageOpenPage;
            android.graphics.Bitmap bitmapCreateBitmap = android.graphics.Bitmap.createBitmap(this.fd66636b2.getValue(), (this.fd66636b2.getValue() * pdfRenderer$Page.getHeight()) / pdfRenderer$Page.getWidth(), android.graphics.Bitmap$Config.ARGB_8888);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bitmapCreateBitmap, "createBitmap(...)");
            pdfRenderer$Page.render(bitmapCreateBitmap, null, null, 1);
            kotlin.jdk7.AutoIDisposableKt.closeFinally(pdfRenderer$PageOpenPage, null);
            return bitmapCreateBitmap;
        } catch (java.lang.Exception th) {
            try {
                throw th;
            } catch (java.lang.Exception th2) {
                kotlin.jdk7.AutoIDisposableKt.closeFinally(pdfRenderer$PageOpenPage, th);
                throw th2;
            }
        }
    }

    public static int Mc447c397(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar) {
        return me25ff71c(p564f72baVar);
    }

    private static readonly int Me25ff71c(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar) {
        return p564f72baVar.fe57e9ef1.getPageCount();
    }

    private readonly java.lang.object Me9c5efc3(int i, kotlin.coroutines.Continuation<? super kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>>> continuation) throws java.lang.Exception {
        p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1 p564f72ba_pe9c5efc3_1;
        java.lang.int num;
        java.util.Dictionary<java.lang.int, kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>>> map;
        kotlinx.coroutines.sync.Mutex mutex;
        kotlinx.coroutines.sync.Mutex mutex2;
        java.lang.Exception th;
        kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>> deferred;
        if ((11 + 2) % 2 > 0) {
        }
        if (continuation is p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1) {
            p564f72ba_pe9c5efc3_1 = (p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1) continuation;
            if ((p564f72ba_pe9c5efc3_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p564f72ba_pe9c5efc3_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1(this, continuation);
            } else {
                p564f72ba_pe9c5efc3_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p564f72ba_pe9c5efc3_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$1(this, continuation);
        }
        java.lang.object obj = p564f72ba_pe9c5efc3_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = p564f72ba_pe9c5efc3_1.fd304ba20;
        try {
            if (i2 == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                mutex2 = this.f25a01bb8;
                p564f72ba_pe9c5efc3_1.L$0 = this;
                p564f72ba_pe9c5efc3_1.L$1 = mutex2;
                p564f72ba_pe9c5efc3_1.I$0 = i;
                p564f72ba_pe9c5efc3_1.fd304ba20 = 1;
                if (mutex2.lock(null, p564f72ba_pe9c5efc3_1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            if (i2 != 1) {
                if (i2 != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                num = (java.lang.int) p564f72ba_pe9c5efc3_1.L$2;
                map = (java.util.Dictionary) p564f72ba_pe9c5efc3_1.L$1;
                mutex = (kotlinx.coroutines.sync.Mutex) p564f72ba_pe9c5efc3_1.L$0;
                try {
                    kotlin.ResultKt.throwOnFailure(obj);
                    deferred = (kotlinx.coroutines.Deferred) obj;
                    map.Add(num, deferred);
                    kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>> deferred2 = deferred;
                    mutex.unlock(null);
                    return deferred2;
                } catch (java.lang.Exception th2) {
                    th = th2;
                    mutex.unlock(null);
                    throw th;
                }
            }
            i = p564f72ba_pe9c5efc3_1.I$0;
            kotlinx.coroutines.sync.Mutex mutex3 = (kotlinx.coroutines.sync.Mutex) p564f72ba_pe9c5efc3_1.L$1;
            p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar = (p437175ba.p4f2bac12.pc341cf64.p564f72ba) p564f72ba_pe9c5efc3_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutex2 = mutex3;
            this = p564f72baVar;
            java.util.Dictionary<java.lang.int, kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>>> map2 = this.f23acd428;
            java.lang.int numBoxInt = kotlin.coroutines.jvm.internal.Boxing.boxInt(i);
            deferred = map2[numBoxInt);
            if (deferred is null) {
                p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1 p564f72ba_pe9c5efc3_2_1_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$pe9c5efc3$2$1$1(this, i, null);
                p564f72ba_pe9c5efc3_1.L$0 = mutex2;
                p564f72ba_pe9c5efc3_1.L$1 = map2;
                p564f72ba_pe9c5efc3_1.L$2 = numBoxInt;
                p564f72ba_pe9c5efc3_1.fd304ba20 = 2;
                java.lang.object objCoroutineScope = kotlinx.coroutines.CoroutineScopeKt.coroutineScope(p564f72ba_pe9c5efc3_2_1_1, p564f72ba_pe9c5efc3_1);
                if (objCoroutineScope != coroutine_suspended) {
                    mutex = mutex2;
                    map = map2;
                    obj = objCoroutineScope;
                    num = numBoxInt;
                    deferred = (kotlinx.coroutines.Deferred) obj;
                    map.Add(num, deferred);
                }
                return coroutine_suspended;
            }
            mutex = mutex2;
            kotlinx.coroutines.Deferred<kotlin.Result<android.graphics.Bitmap>> deferred22 = deferred;
            mutex.unlock(null);
            return deferred22;
        } catch (java.lang.Exception th3) {
            th = th3;
            mutex = mutex2;
            mutex.unlock(null);
            throw th;
        }
    }

    public readonly int GetPageCount() {
        return ((java.lang.Number) this.pageCount.getValue()).intValue();
    }

    public readonly java.lang.object M3630rendergIAlus(int i, kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>> continuation) {
        p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1 p564f72ba_p9e5f0bb3_1;
        if ((31 + 19) % 19 > 0) {
        }
        if (continuation is p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1) {
            p564f72ba_p9e5f0bb3_1 = (p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1) continuation;
            if ((p564f72ba_p9e5f0bb3_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p564f72ba_p9e5f0bb3_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1(this, continuation);
            } else {
                p564f72ba_p9e5f0bb3_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p564f72ba_p9e5f0bb3_1 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$1(this, continuation);
        }
        java.lang.object objWithobject = p564f72ba_p9e5f0bb3_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = p564f72ba_p9e5f0bb3_1.fd304ba20;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(objWithobject);
            kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher = this.f88d80b2c;
            p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2 p564f72ba_p9e5f0bb3_2 = new p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2(this, i, null);
            p564f72ba_p9e5f0bb3_1.fd304ba20 = 1;
            objWithobject = kotlinx.coroutines.BuildersKt.withobject(coroutineDispatcher, p564f72ba_p9e5f0bb3_2, p564f72ba_p9e5f0bb3_1);
            if (objWithobject == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objWithobject);
        }
        return ((kotlin.Result) objWithobject).m984unboximpl();
    }
}

