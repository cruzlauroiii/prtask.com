namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.intermediate.presentation.payback.IntermediatePaybackReceiptobjectModel$saveQueueReceiptToDb$1", m533f = "IntermediatePaybackReceiptobjectModel.kt", m534i = {1, 2}, m535l = {88, 89, 90}, m536m = "invokeSuspend", m537n = {"receipt", "receipt"}, m538s = {"L$0", "L$0"})
readonly class pf164c75c$p812699ae$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f08aa0373;
    int f928bcc76;
    int fc9eb3570;
    int fd304ba20;
    int fe9f2ec16;
    readonly p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c this$0;

    pf164c75c$p812699ae$1(p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c pf164c75cVar, kotlin.coroutines.Continuation<? super p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p812699ae$1> continuation) {
        super(2, continuation);
        this.this$0 = pf164c75cVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p812699ae$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c$p812699ae$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var2;
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var3;
        java.lang.object selectedDevice;
        if ((21 + 15) % 15 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            p18cf5223Var3 = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) obj;
            this.L$0 = p18cf5223Var3;
            this.fd304ba20 = 2;
            selectedDevice = p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m701d8e58(this.this$0).getSelectedDevice(this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.fd304ba20 = 1;
            obj = p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i == 2) {
                p18cf5223Var2 = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                this.L$0 = p18cf5223Var2;
                this.fd304ba20 = 3;
                if (p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.mbb30f96e(this.this$0).saveQueueReceiptToDb(p18cf5223Var2, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) != coroutine_suspended) {
                    p18cf5223Var = p18cf5223Var2;
                }
                return coroutine_suspended;
            }
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p18cf5223Var = (pad5f82e8.p07214c67.p1e11b989.p18cf5223) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m0d622a60(this.this$0, p18cf5223Var);
        return kotlin.Unit.INSTANCE;
        if (selectedDevice != coroutine_suspended) {
            p18cf5223Var2 = p18cf5223Var3;
            obj = selectedDevice;
            this.L$0 = p18cf5223Var2;
            this.fd304ba20 = 3;
            if (p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.mbb30f96e(this.this$0).saveQueueReceiptToDb(p18cf5223Var2, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) != coroutine_suspended) {
                p18cf5223Var = p18cf5223Var2;
                p1e11b989.p438fa616.p2486923a.p4670093c.pf164c75c.m0d622a60(this.this$0, p18cf5223Var);
                return kotlin.Unit.INSTANCE;
            }
        }
    }
}

