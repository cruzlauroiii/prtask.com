namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class pd7f55df8$p11955777$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 this$0;

    pd7f55df8$p11955777$1$1(p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8 pd7f55df8Var) {
        this.this$0 = pd7f55df8Var;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((pad5f82e8.p07214c67.p1e11b989.p9ded6185) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8.m501e9fd2(this.this$0).setValue(p9ded6185Var);
        java.lang.object objMc5ead714 = p1e11b989.p9acb4454.p2486923a.pf83c2a85.pd7f55df8.mc5ead714(this.this$0, p9ded6185Var, continuation);
        return objMc5ead714 != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objMc5ead714;
    }
}

