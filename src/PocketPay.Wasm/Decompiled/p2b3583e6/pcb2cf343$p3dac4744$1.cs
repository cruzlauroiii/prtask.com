namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010 \n\u0002\b\u0003\u0010\u0000\u001a\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u000e\u0010\u0003\u001a\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00020\u00012\u0006\u0010\u0004\u001a\u0002H\u0002H\n"}, d2 = {"<anonymous>", "", "T", "previous", "value"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "utils.FlowUtilsKt$simpleScan$1", m533f = "FlowUtils.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pcb2cf343$p3dac4744$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<java.util.List<? : T>, T, kotlin.coroutines.Continuation<? super java.util.List<? : T>>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int f420e51b7;
    int f743ddf21;
    int fd304ba20;

    pcb2cf343$p3dac4744$1(kotlin.coroutines.Continuation<? super p2b3583e6.pcb2cf343$p3dac4744$1> continuation) {
        super(3, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return invoke((java.util.List<? : java.lang.object>) obj, obj2, (kotlin.coroutines.Continuation<? super java.util.List<? : java.lang.object>>) obj3);
    }

    public readonly java.lang.object Invoke(java.util.List<? : T> list, T t, kotlin.coroutines.Continuation<? super java.util.List<? : T>> continuation) {
        p2b3583e6.pcb2cf343$p3dac4744$1 pcb2cf343_p3dac4744_1 = new p2b3583e6.pcb2cf343$p3dac4744$1(continuation);
        pcb2cf343_p3dac4744_1.L$0 = list;
        pcb2cf343_p3dac4744_1.L$1 = t;
        return pcb2cf343_p3dac4744_1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.util.List list = (java.util.List) this.L$0;
        return kotlin.collections.ICollectionsKt.plus((java.util.ICollection<? : java.lang.object>) kotlin.collections.ICollectionsKt.drop(list, 1), this.L$1);
    }
}

