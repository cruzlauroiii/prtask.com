namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.positions.PaybackPositionsobjectModel$getNotePaybackReceipt$1", m533f = "PaybackPositionsobjectModel.kt", m534i = {}, m535l = {235}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pbb51da1f$p41ec2dec$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f2b1f8cb6;
    int fc248856a;
    int fd304ba20;
    readonly p4670093c.p2486923a.p365a4a97.pbb51da1f this$0;

    pbb51da1f$p41ec2dec$1(p4670093c.p2486923a.p365a4a97.pbb51da1f pbb51da1fVar, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p365a4a97.pbb51da1f$p41ec2dec$1> continuation) {
        super(2, continuation);
        this.this$0 = pbb51da1fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p365a4a97.pbb51da1f$p41ec2dec$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p365a4a97.pbb51da1f$p41ec2dec$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((4 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataM78918dd4 = p4670093c.p2486923a.p365a4a97.pbb51da1f.m78918dd4(this.this$0);
                this.L$0 = mutableLiveDataM78918dd4;
                this.fd304ba20 = 1;
                java.lang.object notePaybackReceipt = p4670093c.p2486923a.p365a4a97.pbb51da1f.md95a43c7(this.this$0).getNotePaybackReceipt(this);
                if (notePaybackReceipt == coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj = notePaybackReceipt;
                mutableLiveData = mutableLiveDataM78918dd4;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            java.lang.string str = (java.lang.string) obj;
            if (str is null) {
                str = "";
            }
            mutableLiveData.setValue(str);
        } catch (java.lang.Exception unused) {
        }
        return kotlin.Unit.INSTANCE;
    }
}

