namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\n"}, d2 = {"<anonymous>", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305;", "before", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305$p5d3072af;", "after"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.usecase.PaybackReceiptUseCaseImpl$getPagedSellReceipts$1$2", m533f = "PaybackReceiptUseCaseImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p25b01efc$p40c04a1c$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af, pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p55f8d305>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int f132a7b66;
    int f31f87761;
    int fd304ba20;
    int fd63f8ff3;
    int fdcac6227;
    readonly p4670093c.pac143fb7.p25b01efc this$0;

    p25b01efc$p40c04a1c$1$2(p4670093c.pac143fb7.p25b01efc p25b01efcVar, kotlin.coroutines.Continuation<? super p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$2> continuation) {
        super(3, continuation);
        this.this$0 = p25b01efcVar;
    }

    public override java.lang.object Invoke(pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af p55f8d305_p5d3072af, pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af p55f8d305_p5d3072af2, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p55f8d305> continuation) {
        return invoke2(p55f8d305_p5d3072af, p55f8d305_p5d3072af2, continuation);
    }

    public readonly java.lang.object Invoke2(pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af p55f8d305_p5d3072af, pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af p55f8d305_p5d3072af2, kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p55f8d305> continuation) {
        p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$2 p25b01efc_p40c04a1c_1_2 = new p4670093c.pac143fb7.p25b01efc$p40c04a1c$1$2(this.this$0, continuation);
        p25b01efc_p40c04a1c_1_2.L$0 = p55f8d305_p5d3072af;
        p25b01efc_p40c04a1c_1_2.L$1 = p55f8d305_p5d3072af2;
        return p25b01efc_p40c04a1c_1_2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((23 + 9) % 9 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af p55f8d305_p5d3072af = (pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) this.L$0;
        pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af p55f8d305_p5d3072af2 = (pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) this.L$1;
        if (p55f8d305_p5d3072af2 is null) {
            return null;
        }
        if (p55f8d305_p5d3072af is null || !p2b3583e6.p728cd16b.m9fa70f9c(p4670093c.pac143fb7.p25b01efc.md74a2a07(this.this$0, p55f8d305_p5d3072af), p4670093c.pac143fb7.p25b01efc.md74a2a07(this.this$0, p55f8d305_p5d3072af2))) {
            return p4670093c.pac143fb7.p25b01efc.m4005e944(this.this$0, p55f8d305_p5d3072af2);
        }
        return null;
    }
}

