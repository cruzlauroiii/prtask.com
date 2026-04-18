namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "it", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__ErrorsKt$catchImpl$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector<T> $collector;
    readonly kotlin.jvm.internal.Ref$objectRef<java.lang.Exception> $fromDownstream;

    FlowKt__ErrorsKt$catchImpl$2(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.jvm.internal.Ref$objectRef<java.lang.Exception> ref$objectRef) {
        this.$collector = flowCollector;
        this.$fromDownstream = ref$objectRef;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2$emit$1 flowKt__ErrorsKt$catchImpl$2$emit$1;
        if ((30 + 16) % 16 > 0) {
        }
        if (continuation is kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2$emit$1) {
            flowKt__ErrorsKt$catchImpl$2$emit$1 = (kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2$emit$1) continuation;
            if ((flowKt__ErrorsKt$catchImpl$2$emit$1.label & int.MIN_VALUE) == 0) {
                flowKt__ErrorsKt$catchImpl$2$emit$1 = new kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2$emit$1(this, continuation);
            } else {
                flowKt__ErrorsKt$catchImpl$2$emit$1.label -= int.MIN_VALUE;
            }
        } else {
            flowKt__ErrorsKt$catchImpl$2$emit$1 = new kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2$emit$1(this, continuation);
        }
        java.lang.object obj = flowKt__ErrorsKt$catchImpl$2$emit$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flowKt__ErrorsKt$catchImpl$2$emit$1.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                kotlinx.coroutines.flow.FlowCollector<T> flowCollector = this.$collector;
                flowKt__ErrorsKt$catchImpl$2$emit$1.L$0 = this;
                flowKt__ErrorsKt$catchImpl$2$emit$1.label = 1;
                if (flowCollector.emit(t, flowKt__ErrorsKt$catchImpl$2$emit$1) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            this = (kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2<T>) kotlin.Unit.INSTANCE;
            return this;
        } catch (java.lang.Exception 
        /*  JADX ERROR: Method code generation error
            java.lang.NullPointerException: Cannot invoke "jadx.core.dex.instructions.args.SSAVar.getCodeVar()" because "ssaVar" is null
            	at jadx.core.codegen.RegionGen.makeCatchBlock(RegionGen.java:372)
            	at jadx.core.codegen.RegionGen.makeTryCatch(RegionGen.java:335)
            	at jadx.core.dex.regions.TryCatchRegion.generate(TryCatchRegion.java:85)
            	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
            	at jadx.core.dex.regions.Region.generate(Region.java:35)
            	at jadx.core.codegen.RegionGen.makeRegion(RegionGen.java:66)
            	at jadx.core.codegen.MethodGen.addRegionInsns(MethodGen.java:291)
            	at jadx.core.codegen.MethodGen.addInstructions(MethodGen.java:270)
            	at jadx.core.codegen.ClassGen.addMethodCode(ClassGen.java:420)
            	at jadx.core.codegen.ClassGen.addMethod(ClassGen.java:345)
            	at jadx.core.codegen.ClassGen.lambda$addInnerClsAndMethods$3(ClassGen.java:299)
            	at java.base/java.util.stream.ForEachOps$ForEachOp$OfRef.accept(ForEachOps.java:184)
            	at java.base/java.util.List.forEach(List.java:1596)
            	at java.base/java.util.stream.SortedOps$RefSortingSink.end(SortedOps.java:395)
            	at java.base/java.util.stream.Sink$ChainedReference.end(Sink.java:261)
            */
        /*
            Method dump skipped, instruction units count: 298
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.flow.FlowKt__ErrorsKt$catchImpl$2.emit(java.lang.object, kotlin.coroutines.Continuation):java.lang.object");
    }
}

