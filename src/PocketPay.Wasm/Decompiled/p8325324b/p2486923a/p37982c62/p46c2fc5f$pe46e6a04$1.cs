namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.fast_sell.FastSellChoosePaySystemobjectModel$processPayment$1", m533f = "FastSellChoosePaySystemobjectModel.kt", m534i = {}, m535l = {77}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p46c2fc5f$pe46e6a04$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $inventoryName;
    readonly pad5f82e8.p07214c67.p1e11b989.pb5374042 $paymentTypeobjectState;
    readonly java.math.decimal $price;
    int f70167033;
    int fd304ba20;
    readonly p8325324b.p2486923a.p37982c62.p46c2fc5f this$0;

    p46c2fc5f$pe46e6a04$1(p8325324b.p2486923a.p37982c62.p46c2fc5f p46c2fc5fVar, pad5f82e8.p07214c67.p1e11b989.pb5374042 pb5374042Var, java.lang.string str, java.math.decimal bigDecimal, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p37982c62.p46c2fc5f$pe46e6a04$1> continuation) {
        super(2, continuation);
        this.this$0 = p46c2fc5fVar;
        this.$paymentTypeobjectState = pb5374042Var;
        this.$inventoryName = str;
        this.$price = bigDecimal;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((9 + 17) % 17 > 0) {
        }
        return new p8325324b.p2486923a.p37982c62.p46c2fc5f$pe46e6a04$1(this.this$0, this.$paymentTypeobjectState, this.$inventoryName, this.$price, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p37982c62.p46c2fc5f$pe46e6a04$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p8325324b.p2486923a.p37982c62.p46c2fc5f.m9f7212d6(this.this$0, this.$paymentTypeobjectState);
            p8325324b.p2486923a.p37982c62.p46c2fc5f p46c2fc5fVar = this.this$0;
            pad5f82e8.p07214c67.p1e11b989.pb5374042 pb5374042Var = this.$paymentTypeobjectState;
            java.lang.string str = this.$inventoryName;
            java.math.decimal bigDecimal = this.$price;
            p8325324b.p2486923a.p37982c62.p46c2fc5f$pe46e6a04$1 p46c2fc5f_pe46e6a04_1 = this;
            this.fd304ba20 = 1;
            if (p8325324b.p2486923a.p37982c62.p46c2fc5f.m1937a21d(p46c2fc5fVar, pb5374042Var, str, bigDecimal, p46c2fc5f_pe46e6a04_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p8325324b.p2486923a.p37982c62.p46c2fc5f.mbb00931f(this.this$0, this.$paymentTypeobjectState, this.$price);
        return kotlin.Unit.INSTANCE;
    }
}

