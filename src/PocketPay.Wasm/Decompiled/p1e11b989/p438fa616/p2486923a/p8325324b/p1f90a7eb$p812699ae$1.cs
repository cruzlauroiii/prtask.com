namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.intermediate.presentation.sell.IntermediateSellReceiptobjectModel$saveQueueReceiptToDb$1", m533f = "IntermediateSellReceiptobjectModel.kt", m534i = {1, 2}, m535l = {99, 102, 100}, m536m = "invokeSuspend", m537n = {"currentSellReceipt", "currentSellReceipt"}, m538s = {"L$0", "L$0"})
readonly class p1f90a7eb$p812699ae$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f8a15e8a1;
    int fb8b53b09;
    int fd304ba20;
    readonly p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb this$0;

    p1f90a7eb$p812699ae$1(p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb p1f90a7ebVar, kotlin.coroutines.Continuation<? super p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p812699ae$1> continuation) {
        super(2, continuation);
        this.this$0 = p1f90a7ebVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p812699ae$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb$p812699ae$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar2;
        pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 pf21d5ed1Var;
        pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar3;
        pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1 pf21d5ed1VarMbb30f96e;
        pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar4;
        java.lang.object selectedDevice;
        if ((2 + 7) % 7 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            ped663a3eVar3 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) obj;
            pf21d5ed1VarMbb30f96e = p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.mbb30f96e(this.this$0);
            ped663a3eVar4 = ped663a3eVar3;
            this.L$0 = ped663a3eVar3;
            this.L$1 = pf21d5ed1VarMbb30f96e;
            this.L$2 = ped663a3eVar4;
            this.fd304ba20 = 2;
            selectedDevice = p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m701d8e58(this.this$0).getSelectedDevice(this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.fd304ba20 = 1;
            obj = p1e11b989.p438fa616.p2486923a.p8325324b.p1f90a7eb.m260c792f(this.this$0).getCurrentSellReceipt(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i == 2) {
                p9ded6185Var = (pad5f82e8.p07214c67.p1e11b989.p9ded6185) this.L$2;
                pf21d5ed1Var = (pad5f82e8.pac143fb7.p1e11b989.pf21d5ed1) this.L$1;
                ped663a3eVar2 = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                this.L$0 = ped663a3eVar2;
                this.L$1 = null;
                this.L$2 = null;
                this.fd304ba20 = 3;
                if (pf21d5ed1Var.saveQueueReceiptToDb(p9ded6185Var, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) != coroutine_suspended) {
                    ped663a3eVar = ped663a3eVar2;
                }
                return coroutine_suspended;
            }
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ped663a3eVar = (pad5f82e8.p07214c67.p1e11b989.ped663a3e) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        this.this$0.openReceiptSentScreen(ped663a3eVar);
        return kotlin.Unit.INSTANCE;
        if (selectedDevice != coroutine_suspended) {
            ped663a3eVar2 = ped663a3eVar3;
            obj = selectedDevice;
            pf21d5ed1Var = pf21d5ed1VarMbb30f96e;
            p9ded6185Var = ped663a3eVar4;
            this.L$0 = ped663a3eVar2;
            this.L$1 = null;
            this.L$2 = null;
            this.fd304ba20 = 3;
            if (pf21d5ed1Var.saveQueueReceiptToDb(p9ded6185Var, ((pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj).getDeviceId(), this.this$0.tostring(), this) != coroutine_suspended) {
                ped663a3eVar = ped663a3eVar2;
                this.this$0.openReceiptSentScreen(ped663a3eVar);
                return kotlin.Unit.INSTANCE;
            }
        }
    }
}

