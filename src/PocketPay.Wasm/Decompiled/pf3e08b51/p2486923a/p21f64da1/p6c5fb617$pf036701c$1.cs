namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "launcher.presentation.documents.DocumentsMenuobjectModel$checkInspectionMode$1", m533f = "DocumentsMenuobjectModel.kt", m534i = {}, m535l = {41}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6c5fb617$pf036701c$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f1768ba7b;
    int fa2535c8b;
    int fd304ba20;
    int fd532fdef;
    int ff6d68d36;
    readonly pf3e08b51.p2486923a.p21f64da1.p6c5fb617 this$0;

    p6c5fb617$pf036701c$1(pf3e08b51.p2486923a.p21f64da1.p6c5fb617 p6c5fb617Var, kotlin.coroutines.Continuation<? super pf3e08b51.p2486923a.p21f64da1.p6c5fb617$pf036701c$1> continuation) {
        super(2, continuation);
        this.this$0 = p6c5fb617Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf3e08b51.p2486923a.p21f64da1.p6c5fb617$pf036701c$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf3e08b51.p2486923a.p21f64da1.p6c5fb617$pf036701c$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((31 + 14) % 14 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59VarM4aee790e = pf3e08b51.p2486923a.p21f64da1.p6c5fb617.m4aee790e(this.this$0);
            pf3e08b51.p2486923a.p21f64da1.p6c5fb617$pf036701c$1 p6c5fb617_pf036701c_1 = this;
            this.fd304ba20 = 1;
            obj = p4ee8dd59VarM4aee790e.getInspectedPositions(p6c5fb617_pf036701c_1);
            if (obj == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (((java.util.ICollection) obj).Count == 0) {
            this.this$0.openInspectionScreen();
        } else {
            pf3e08b51.p2486923a.p21f64da1.p6c5fb617.m783d903f(this.this$0).setValue(kotlin.coroutines.jvm.internal.Boxing.boxbool(true));
        }
        return kotlin.Unit.INSTANCE;
    }
}

