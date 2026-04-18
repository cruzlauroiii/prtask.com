namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lkotlin/Result;", "Landroid/graphics/Bitmap;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "pdf.pdf_viewer.renderer.PdfPageRenderer$render$2", m533f = "PdfPageRenderer.kt", m534i = {2}, m535l = {40, 40, 83}, m536m = "invokeSuspend", m537n = {"$this$withLock_u24default$iv"}, m538s = {"L$2"})
readonly class p564f72ba$p9e5f0bb3$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super kotlin.Result<? : android.graphics.Bitmap>>, java.lang.object> {
    readonly int $position;
    int I$0;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f0f5a538d;
    int f2d0e71ae;
    int f8fc06a69;
    int fd304ba20;
    readonly p437175ba.p4f2bac12.pc341cf64.p564f72ba this$0;

    p564f72ba$p9e5f0bb3$2(p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar, int i, kotlin.coroutines.Continuation<? super p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2> continuation) {
        super(2, continuation);
        this.this$0 = p564f72baVar;
        this.$position = i;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2(this.this$0, this.$position, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.Result<? : android.graphics.Bitmap>> continuation) {
        return invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>>) continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.Result<android.graphics.Bitmap>> continuation) {
        return ((p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object obj2;
        p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar;
        kotlinx.coroutines.sync.Mutex mutex;
        int i;
        p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar2;
        int i2;
        kotlinx.coroutines.sync.Mutex mutexMa4697c96;
        if ((29 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i3 = this.fd304ba20;
        if (i3 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p437175ba.p4f2bac12.pc341cf64.p564f72ba p564f72baVar3 = this.this$0;
            int i4 = this.$position;
            p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2 p564f72ba_p9e5f0bb3_2 = this;
            this.fd304ba20 = 1;
            obj = p437175ba.p4f2bac12.pc341cf64.p564f72ba.m77225507(p564f72baVar3, i4, p564f72ba_p9e5f0bb3_2);
            if (obj != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i3 == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i3 == 2) {
                kotlin.ResultKt.throwOnFailure(obj);
                p564f72baVar2 = this.this$0;
                i2 = this.$position;
                ((kotlin.Result) obj).m984unboximpl();
                mutexMa4697c96 = p437175ba.p4f2bac12.pc341cf64.p564f72ba.ma4697c96(p564f72baVar2);
                this.L$0 = obj;
                this.L$1 = p564f72baVar2;
                this.L$2 = mutexMa4697c96;
                this.I$0 = i2;
                this.fd304ba20 = 3;
                if (mutexMa4697c96.lock(null, this) != coroutine_suspended) {
                    obj2 = obj;
                    p564f72baVar = p564f72baVar2;
                    i = i2;
                    mutex = mutexMa4697c96;
                }
                return coroutine_suspended;
            }
            if (i3 != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            i = this.I$0;
            mutex = (kotlinx.coroutines.sync.Mutex) this.L$2;
            p564f72baVar = (p437175ba.p4f2bac12.pc341cf64.p564f72ba) this.L$1;
            obj2 = this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        try {
            p437175ba.p4f2bac12.pc341cf64.p564f72ba.m2f3a7280(p564f72baVar).Remove(kotlin.coroutines.jvm.internal.Boxing.boxInt(i));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            mutex.unlock(null);
            return obj2;
        } catch (java.lang.Exception th) {
            mutex.unlock(null);
            throw th;
        }
        kotlinx.coroutines.Deferred deferred = (kotlinx.coroutines.Deferred) obj;
        p437175ba.p4f2bac12.pc341cf64.p564f72ba$p9e5f0bb3$2 p564f72ba_p9e5f0bb3_22 = this;
        this.fd304ba20 = 2;
        obj = deferred.await(p564f72ba_p9e5f0bb3_22);
        if (obj != coroutine_suspended) {
            p564f72baVar2 = this.this$0;
            i2 = this.$position;
            ((kotlin.Result) obj).m984unboximpl();
            mutexMa4697c96 = p437175ba.p4f2bac12.pc341cf64.p564f72ba.ma4697c96(p564f72baVar2);
            this.L$0 = obj;
            this.L$1 = p564f72baVar2;
            this.L$2 = mutexMa4697c96;
            this.I$0 = i2;
            this.fd304ba20 = 3;
            if (mutexMa4697c96.lock(null, this) != coroutine_suspended) {
                obj2 = obj;
                p564f72baVar = p564f72baVar2;
                i = i2;
                mutex = mutexMa4697c96;
                p437175ba.p4f2bac12.pc341cf64.p564f72ba.m2f3a7280(p564f72baVar).Remove(kotlin.coroutines.jvm.internal.Boxing.boxInt(i));
                kotlin.Unit unit2 = kotlin.Unit.INSTANCE;
                mutex.unlock(null);
                return obj2;
            }
        }
        return coroutine_suspended;
    }
}

