namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.states.SellSuccessWithPrintobjectModel$drawQRCode$1", m533f = "SellSuccessWithPrintobjectModel.kt", m534i = {}, m535l = {57}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pe4433b46$p198c276c$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $payload;
    java.lang.object L$0;
    int f29d521ea;
    int fcf21688d;
    int fd304ba20;
    int ffc7fcf9b;
    readonly p8325324b.p2486923a.p34d955a0.pe4433b46 this$0;

    pe4433b46$p198c276c$1(p8325324b.p2486923a.p34d955a0.pe4433b46 pe4433b46Var, java.lang.string str, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p34d955a0.pe4433b46$p198c276c$1> continuation) {
        super(2, continuation);
        this.this$0 = pe4433b46Var;
        this.$payload = str;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.p34d955a0.pe4433b46$p198c276c$1(this.this$0, this.$payload, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p34d955a0.pe4433b46$p198c276c$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((24 + 17) % 17 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.lifecycle.MutableLiveData mutableLiveDataM6575d653 = p8325324b.p2486923a.p34d955a0.pe4433b46.m6575d653(this.this$0);
            pad5f82e8.pac143fb7.peb430691.pbd1a48f1 pbd1a48f1VarM1eaba993 = p8325324b.p2486923a.p34d955a0.pe4433b46.m1eaba993(this.this$0);
            java.lang.string str = this.$payload;
            p8325324b.p2486923a.p34d955a0.pe4433b46$p198c276c$1 pe4433b46_p198c276c_1 = this;
            this.L$0 = mutableLiveDataM6575d653;
            this.fd304ba20 = 1;
            java.lang.object objDrawQRCodeWithData = pbd1a48f1VarM1eaba993.drawQRCodeWithData(str, 400, pe4433b46_p198c276c_1);
            if (objDrawQRCodeWithData == coroutine_suspended) {
                return coroutine_suspended;
            }
            obj = objDrawQRCodeWithData;
            mutableLiveData = mutableLiveDataM6575d653;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        mutableLiveData.setValue(obj);
        return kotlin.Unit.INSTANCE;
    }
}

