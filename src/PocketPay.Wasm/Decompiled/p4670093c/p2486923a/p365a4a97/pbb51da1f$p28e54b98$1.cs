namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.positions.PaybackPositionsobjectModel$openInventoriesForPaybackScreen$1", m533f = "PaybackPositionsobjectModel.kt", m534i = {}, m535l = {183}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pbb51da1f$p28e54b98$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f482828fe;
    int fd304ba20;
    readonly p4670093c.p2486923a.p365a4a97.pbb51da1f this$0;

    pbb51da1f$p28e54b98$1(p4670093c.p2486923a.p365a4a97.pbb51da1f pbb51da1fVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p365a4a97.pbb51da1f$p28e54b98$1> continuation) {
        super(2, continuation);
        this.this$0 = pbb51da1fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p365a4a97.pbb51da1f$p28e54b98$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p365a4a97.pbb51da1f$p28e54b98$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 17) % 17 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p4670093c.p2486923a.p365a4a97.pbb51da1f.md95a43c7(this.this$0).getPaybackReceiptType(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            if (p4670093c.p2486923a.p365a4a97.pbb51da1f$p28e54b98$1$p12c674ac.$EnumSwitchDictionaryping$0[((pad5f82e8.p07214c67.p1e11b989.p22820a6f) obj).ordinal()] == 1) {
                p4670093c.p2486923a.p365a4a97.pbb51da1f.m59e4759d(this.this$0).openInventories(pad5f82e8.p07214c67.pfd9160bb.p17096304.f70474f2d);
            } else {
                p4670093c.p2486923a.p365a4a97.pbb51da1f.m89a7f193(this.this$0).openPaybackReceiptDetail();
            }
        } catch (java.lang.Exception e) {
            android.util.Console.e(this.this$0.tostring(), java.lang.string.valueOf(e.getMessage()));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

