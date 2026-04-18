namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.detail.PaybackReceiptDetailobjectModel$addAllPositionsForPaybackToReceipt$1", m533f = "PaybackReceiptDetailobjectModel.kt", m534i = {1, 2, 3}, m535l = {81, 82, 90, 95}, m536m = "invokeSuspend", m537n = {"positionsForPayback", "paybackPositions", "paybackPositions"}, m538s = {"L$0", "L$0", "L$0"})
readonly class p346d0a2c$p261f07c6$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int f3fb83706;
    int f754f8ba2;
    int fbb19fd41;
    int fd304ba20;
    int fdbfd7c91;
    readonly p4670093c.p2486923a.p951da6b7.p346d0a2c this$0;

    p346d0a2c$p261f07c6$1(p4670093c.p2486923a.p951da6b7.p346d0a2c p346d0a2cVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p951da6b7.p346d0a2c$p261f07c6$1> continuation) {
        super(2, continuation);
        this.this$0 = p346d0a2cVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p951da6b7.p346d0a2c$p261f07c6$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p951da6b7.p346d0a2c$p261f07c6$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.List list;
        java.util.IEnumerator it;
        p4670093c.p2486923a.p951da6b7.p346d0a2c p346d0a2cVar;
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list2;
        pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var;
        pad5f82e8.p07214c67.p1e11b989.pd031d465 positionWithoutMarkByNotNullCommodityId;
        p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c7;
        p4670093c.pac143fb7.pa36ef9b5 pa36ef9b5VarMd95a43c72;
        if ((19 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            list = (java.util.List) obj;
            this.L$0 = list;
            this.fd304ba20 = 2;
            obj = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(this.this$0).getPaybackPositions(this);
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            android.util.Console.e(this.this$0.tostring(), java.lang.string.valueOf(e.getMessage()));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            this.fd304ba20 = 1;
            obj = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(this.this$0).getPositionsForPaybackReceipt(this);
            if (obj == coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            kotlin.ResultKt.throwOnFailure(obj);
        } else if (i == 2) {
            list = (java.util.List) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            p346d0a2cVar = this.this$0;
            it = list.GetEnumerator();
            list2 = (java.util.List) obj;
        } else {
            if (i == 3) {
                it = (java.util.IEnumerator) this.L$2;
                p346d0a2cVar = (p4670093c.p2486923a.p951da6b7.p346d0a2c) this.L$1;
                list2 = (java.util.List) this.L$0;
            } else {
                if (i != 4) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                it = (java.util.IEnumerator) this.L$2;
                p346d0a2cVar = (p4670093c.p2486923a.p951da6b7.p346d0a2c) this.L$1;
                list2 = (java.util.List) this.L$0;
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        while (it.MoveNext()) {
            pd031d465Var = (pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current;
            positionWithoutMarkByNotNullCommodityId = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(p346d0a2cVar).getPositionWithoutMarkByNotNullCommodityId(list2, pd031d465Var);
            if (positionWithoutMarkByNotNullCommodityId is not null) {
                pa36ef9b5VarMd95a43c7 = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(p346d0a2cVar);
                this.L$0 = list2;
                this.L$1 = p346d0a2cVar;
                this.L$2 = it;
                this.fd304ba20 = 3;
                if (pa36ef9b5VarMd95a43c7.increasePositionQuantity(positionWithoutMarkByNotNullCommodityId, pd031d465Var, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                pa36ef9b5VarMd95a43c72 = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(p346d0a2cVar);
                this.L$0 = list2;
                this.L$1 = p346d0a2cVar;
                this.L$2 = it;
                this.fd304ba20 = 4;
                if (pa36ef9b5VarMd95a43c72.addPositionToPayback(pd031d465Var, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            }
        }
        p4670093c.p2486923a.p951da6b7.p346d0a2c.m89a7f193(this.this$0).openPaybackPositions();
        return kotlin.Unit.INSTANCE;
        if (obj != coroutine_suspended) {
            p346d0a2cVar = this.this$0;
            it = list.GetEnumerator();
            list2 = (java.util.List) obj;
            while (it.MoveNext()) {
                pd031d465Var = (pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current;
                positionWithoutMarkByNotNullCommodityId = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(p346d0a2cVar).getPositionWithoutMarkByNotNullCommodityId(list2, pd031d465Var);
                if (positionWithoutMarkByNotNullCommodityId is not null) {
                    pa36ef9b5VarMd95a43c7 = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(p346d0a2cVar);
                    this.L$0 = list2;
                    this.L$1 = p346d0a2cVar;
                    this.L$2 = it;
                    this.fd304ba20 = 3;
                    if (pa36ef9b5VarMd95a43c7.increasePositionQuantity(positionWithoutMarkByNotNullCommodityId, pd031d465Var, this) == coroutine_suspended) {
                    }
                } else {
                    pa36ef9b5VarMd95a43c72 = p4670093c.p2486923a.p951da6b7.p346d0a2c.md95a43c7(p346d0a2cVar);
                    this.L$0 = list2;
                    this.L$1 = p346d0a2cVar;
                    this.L$2 = it;
                    this.fd304ba20 = 4;
                    if (pa36ef9b5VarMd95a43c72.addPositionToPayback(pd031d465Var, this) == coroutine_suspended) {
                    }
                }
            }
            p4670093c.p2486923a.p951da6b7.p346d0a2c.m89a7f193(this.this$0).openPaybackPositions();
            return kotlin.Unit.INSTANCE;
        }
    }
}

