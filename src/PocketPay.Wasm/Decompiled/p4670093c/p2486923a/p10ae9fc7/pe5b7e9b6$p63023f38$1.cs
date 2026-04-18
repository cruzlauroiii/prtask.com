namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.list.PaybackReceiptListobjectModel$createPaybackReceipt$1", m533f = "PaybackReceiptListobjectModel.kt", m534i = {}, m535l = {76}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pe5b7e9b6$p63023f38$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.ped663a3e $receipt;
    int f42850619;
    int f50d9b506;
    int f9f8599c7;
    int fca69e663;
    int fd304ba20;
    readonly p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6 this$0;

    pe5b7e9b6$p63023f38$1(p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6 pe5b7e9b6Var, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p63023f38$1> continuation) {
        super(2, continuation);
        this.this$0 = pe5b7e9b6Var;
        this.$receipt = ped663a3eVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p63023f38$1(this.this$0, this.$receipt, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6$p63023f38$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                if (p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.md95a43c7(this.this$0).createPaybackReceipt(this.$receipt, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.mff8ebad6(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c.m02f94ccf(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c, null, 1, null));
        } catch (java.lang.Exception e) {
            p4670093c.p2486923a.p10ae9fc7.pe5b7e9b6.mff8ebad6(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

