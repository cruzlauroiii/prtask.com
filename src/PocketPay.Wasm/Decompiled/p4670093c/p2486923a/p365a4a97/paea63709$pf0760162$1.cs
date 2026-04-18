namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.positions.EditPaybackPositionobjectModel$getPaybackReceiptParams$1", m533f = "EditPaybackPositionobjectModel.kt", m534i = {1, 2}, m535l = {34, 36, 37}, m536m = "invokeSuspend", m537n = {"receiptType", "receiptType"}, m538s = {"L$0", "L$0"})
readonly class paea63709$pf0760162$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 $position;
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f4b2fb04f;
    int f8dd57eda;
    int f8e58374c;
    int fa9be9f13;
    int fd304ba20;
    readonly p4670093c.p2486923a.p365a4a97.paea63709 this$0;

    paea63709$pf0760162$1(p4670093c.p2486923a.p365a4a97.paea63709 paea63709Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p365a4a97.paea63709$pf0760162$1> continuation) {
        super(2, continuation);
        this.this$0 = paea63709Var;
        this.$position = pd031d465Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p365a4a97.paea63709$pf0760162$1(this.this$0, this.$position, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p365a4a97.paea63709$pf0760162$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.math.decimal bigDecimal;
        pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar;
        pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var;
        p4670093c.p2486923a.p365a4a97.paea63709 paea63709Var;
        pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar2;
        pad5f82e8.p07214c67.p1e11b989.p22820a6f p22820a6fVar3;
        java.math.decimal bigDecimal2;
        java.lang.object quantityPositionForPaybackByUuid;
        if ((7 + 13) % 13 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        java.math.decimal bigDecimalAdd = null;
        try {
            p22820a6fVar3 = (pad5f82e8.p07214c67.p1e11b989.p22820a6f) obj;
            pd031d465Var = this.$position;
            if (pd031d465Var is not null) {
                p4670093c.p2486923a.p365a4a97.paea63709 paea63709Var2 = this.this$0;
                p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c7 = p4670093c.p2486923a.p365a4a97.paea63709.md95a43c7(paea63709Var2);
                java.lang.string uuid = pd031d465Var.getUuid();
                this.L$0 = p22820a6fVar3;
                this.L$1 = paea63709Var2;
                this.L$2 = pd031d465Var;
                this.fd304ba20 = 2;
                java.lang.object quantityPaybackPositionByUuid = pa36ef9b5VarMd95a43c7.getQuantityPaybackPositionByUuid(uuid, this);
                if (quantityPaybackPositionByUuid != coroutine_suspended) {
                    p22820a6fVar2 = p22820a6fVar3;
                    obj = quantityPaybackPositionByUuid;
                    paea63709Var = paea63709Var2;
                    bigDecimal2 = (java.math.decimal) obj;
                    p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c72 = p4670093c.p2486923a.p365a4a97.paea63709.md95a43c7(paea63709Var);
                    java.lang.string uuid2 = pd031d465Var.getUuid();
                    this.L$0 = p22820a6fVar2;
                    this.L$1 = bigDecimal2;
                    this.L$2 = null;
                    this.fd304ba20 = 3;
                    quantityPositionForPaybackByUuid = pa36ef9b5VarMd95a43c72.getQuantityPositionForPaybackByUuid(uuid2, this);
                    if (quantityPositionForPaybackByUuid != coroutine_suspended) {
                        bigDecimal = bigDecimal2;
                        obj = quantityPositionForPaybackByUuid;
                        p22820a6fVar = p22820a6fVar2;
                        bigDecimalAdd = bigDecimal.Add((java.math.decimal) obj);
                        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalAdd, "add(...)");
                        p22820a6fVar3 = p22820a6fVar;
                    }
                }
                return coroutine_suspended;
            }
            p4670093c.p2486923a.p365a4a97.paea63709.m90240938(this.this$0).setValue(new p4670093c.p2486923a.p365a4a97.p921e779a(p22820a6fVar3, bigDecimalAdd));
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.fd304ba20 = 1;
            obj = p4670093c.p2486923a.p365a4a97.paea63709.md95a43c7(this.this$0).getPaybackReceiptType(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i == 2) {
                pd031d465Var = (pad5f82e8.p07214c67.p1e11b989.pd031d465) this.L$2;
                paea63709Var = (p4670093c.p2486923a.p365a4a97.paea63709) this.L$1;
                p22820a6fVar2 = (pad5f82e8.p07214c67.p1e11b989.p22820a6f) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                bigDecimal2 = (java.math.decimal) obj;
                p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c722 = p4670093c.p2486923a.p365a4a97.paea63709.md95a43c7(paea63709Var);
                java.lang.string uuid22 = pd031d465Var.getUuid();
                this.L$0 = p22820a6fVar2;
                this.L$1 = bigDecimal2;
                this.L$2 = null;
                this.fd304ba20 = 3;
                quantityPositionForPaybackByUuid = pa36ef9b5VarMd95a43c722.getQuantityPositionForPaybackByUuid(uuid22, this);
                if (quantityPositionForPaybackByUuid != coroutine_suspended) {
                    bigDecimal = bigDecimal2;
                    obj = quantityPositionForPaybackByUuid;
                    p22820a6fVar = p22820a6fVar2;
                }
                return coroutine_suspended;
            }
            if (i != 3) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            bigDecimal = (java.math.decimal) this.L$1;
            p22820a6fVar = (pad5f82e8.p07214c67.p1e11b989.p22820a6f) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        bigDecimalAdd = bigDecimal.Add((java.math.decimal) obj);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalAdd, "add(...)");
        p22820a6fVar3 = p22820a6fVar;
        p4670093c.p2486923a.p365a4a97.paea63709.m90240938(this.this$0).setValue(new p4670093c.p2486923a.p365a4a97.p921e779a(p22820a6fVar3, bigDecimalAdd));
        return kotlin.Unit.INSTANCE;
        return kotlin.Unit.INSTANCE;
    }
}

