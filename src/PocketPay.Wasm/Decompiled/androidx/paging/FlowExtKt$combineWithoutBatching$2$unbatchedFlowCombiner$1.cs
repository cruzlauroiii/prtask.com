namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T1, T2] */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\u0006\u0010\u0005\u001a\u0002H\u00022\u0006\u0010\u0006\u001a\u0002H\u00032\u0006\u0010\u0007\u001a\u00020\bH\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "t1", "t2", "updateFrom", "Landroidx/paging/CombineSource;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1", m533f = "FlowExt.kt", m534i = {}, m535l = {141, 141}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1<T1, T2> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.paging.SimpleProducerScope<R> $$this$simpleChannelFlow;
    readonly /* synthetic */ kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    /* synthetic */ java.lang.object L$0;
    /* synthetic */ java.lang.object L$1;
    /* synthetic */ java.lang.object L$2;
    int label;

    public FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1(androidx.paging.SimpleProducerScope<R> r1, kotlin.jvm.functions.Function4<? super T1, ? super T2, ? super androidx.paging.CombineSource, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> r2, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1> r3) {
            r0 = this;
            goto La
        L4:
            r0.$$this$simpleChannelFlow = r1
            goto L1b
        La:
            goto L22
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            r0.<init>(r1, r3)
            goto L21
        L1b:
            r0.$transform = r2
            goto L26
        L21:
            return
        L22:
            goto L11
        L26:
            r1 = 4
            goto L14
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(T1 r3, T2 r4, androidx.paging.CombineSource r5, kotlin.coroutines.Continuation<kotlin.Unit> r6) {
            r2 = this;
            goto L18
        L4:
            r0 = 3
            goto L65
        Lb:
            r0.L$2 = r5
            goto L71
        L11:
            r0.<init>(r1, r2, r6)
            goto L51
        L18:
            goto L44
        L1b:
            goto L4
        L1f:
            goto L6d
        L22:
            goto L5f
        L26:
            r0.L$1 = r4
            goto Lb
        L2c:
            kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<R>, java.lang.object> r2 = r2.$transform
            goto L11
        L32:
            androidx.paging.SimpleProducerScope<R> r1 = r2.$$this$simpleChannelFlow
            goto L2c
        L38:
            if (r0 <= 0) goto L3d
            goto L22
        L3d:
            goto L1f
        L41:
            goto L22
        L44:
            goto L4e
        L48:
            int r0 = r0 + r1
            goto L77
        L4e:
            goto L1b
        L51:
            r0.L$0 = r3
            goto L26
        L57:
            java.lang.object r2 = r0.invokeSuspend(r2)
            goto L6c
        L5f:
            androidx.paging.FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1 r0 = new androidx.paging.FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1
            goto L32
        L65:
            r1 = 20
            goto L48
        L6c:
            return r2
        L6d:
            goto L41
        L71:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L57
        L77:
            int r0 = r0 % r1
            goto L38
    }

    @Override // kotlin.jvm.functions.Function4
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object r2, androidx.paging.CombineSource r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto Lf
        L9:
            androidx.paging.CombineSource r3 = (androidx.paging.CombineSource) r3
            goto L21
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
        L19:
            java.lang.object r0 = r0.invoke2(r1, r2, r3, r4)
            goto L4
        L21:
            kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
            goto L19
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r9) {
            r8 = this;
            goto L135
        L4:
            java.lang.object r9 = r7.invoke(r9, r1, r5, r8)
            goto Ldd
        Lc:
            if (r1 != 0) goto L11
            goto Lb2
        L11:
            goto L7d
        L15:
            goto L74
        L16:
            goto L67
        L1a:
            int r1 = r8.label
            goto L27
        L20:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L15
        L27:
            r2 = 0
            goto Le6
        L2c:
            java.lang.object r9 = r8.L$0
            goto L32
        L32:
            java.lang.object r1 = r8.L$1
            goto Lc6
        L38:
            if (r8 == r0) goto L3d
            goto L74
        L3d:
            goto L73
        L41:
            goto L93
        L44:
            goto L5f
        L48:
            r8.label = r3
            goto Lf1
        L4e:
            r1 = r6
        L4f:
            goto Lac
        L53:
            kotlin.Unit r8 = kotlin.Unit.INSTANCE
            goto L92
        L59:
            int r0 = r0 + r1
            goto L126
        L5f:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L1a
        L67:
            java.lang.IllegalStateException r8 = new java.lang.IllegalStateException
            goto L8c
        L6d:
            r8.L$0 = r6
            goto Lfe
        L73:
            return r0
        L74:
            goto L53
        L78:
            goto L3d
        L79:
            goto L4e
        L7d:
            if (r1 != r4) goto L82
            goto Lfa
        L82:
            goto L12c
        L86:
            java.lang.object r1 = r8.L$0
            goto Lbd
        L8c:
            java.lang.string r9 = "call to 'resume' before 'invoke' with coroutine"
            goto L13c
        L92:
            return r8
        L93:
            goto L9e
        L97:
            r1 = 24
            goto L59
        L9e:
            goto L44
        La1:
            goto Lc3
        La5:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L2c
        Lac:
            r4 = r8
            goto Leb
        Lb1:
            goto L4f
        Lb2:
            goto La5
        Lb6:
            r0 = 32
            goto L97
        Lbd:
            androidx.paging.SimpleProducerScope r1 = (androidx.paging.SimpleProducerScope) r1
            goto L11f
        Lc3:
            goto L138
        Lc6:
            java.lang.object r5 = r8.L$2
            goto L104
        Lcc:
            r8.L$0 = r2
            goto L48
        Ld2:
            r4 = 1
            goto Lc
        Ld7:
            androidx.paging.SimpleProducerScope<R> r6 = r8.$$this$simpleChannelFlow
            goto L119
        Ldd:
            if (r9 == r0) goto Le2
            goto L79
        Le2:
            goto L78
        Le6:
            r3 = 2
            goto Ld2
        Leb:
            kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
            goto Lcc
        Lf1:
            java.lang.object r8 = r1.send(r9, r4)
            goto L38
        Lf9:
            throw r8
        Lfa:
            goto L86
        Lfe:
            r8.L$1 = r2
            goto L113
        L104:
            androidx.paging.CombineSource r5 = (androidx.paging.CombineSource) r5
            goto Ld7
        L10a:
            if (r0 <= 0) goto L10f
            goto L44
        L10f:
            goto L41
        L113:
            r8.label = r4
            goto L4
        L119:
            kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<R>, java.lang.object> r7 = r8.$transform
            goto L6d
        L11f:
            kotlin.ResultKt.throwOnFailure(r9)
            goto Lb1
        L126:
            int r0 = r0 % r1
            goto L10a
        L12c:
            if (r1 == r3) goto L131
            goto L16
        L131:
            goto L20
        L135:
            goto La1
        L138:
            goto Lb6
        L13c:
            r8.<init>(r9)
            goto Lf9
    }

    public readonly java.lang.object invokeSuspend$$forInline(java.lang.object r5) {
            r4 = this;
            goto L42
        L4:
            java.lang.object r0 = r4.L$1
            goto L16
        La:
            androidx.paging.SimpleProducerScope<R> r2 = r4.$$this$simpleChannelFlow
            goto L25
        L10:
            androidx.paging.CombineSource r1 = (androidx.paging.CombineSource) r1
            goto La
        L16:
            java.lang.object r1 = r4.L$2
            goto L10
        L1c:
            goto L45
        L1f:
            int r0 = r0 + r1
            goto L7d
        L25:
            kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<R>, java.lang.object> r3 = r4.$transform
            goto L56
        L2b:
            r0 = 4
            goto L64
        L32:
            if (r0 <= 0) goto L37
            goto L52
        L37:
            goto L4f
        L3b:
            r2.send(r5, r4)
            goto L72
        L42:
            goto L6e
        L45:
            goto L2b
        L49:
            kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
            goto L3b
        L4f:
            goto L79
        L52:
            goto L5e
        L56:
            java.lang.object r5 = r3.invoke(r5, r0, r1, r4)
            goto L49
        L5e:
            java.lang.object r5 = r4.L$0
            goto L4
        L64:
            r1 = 31
            goto L1f
        L6b:
            goto L52
        L6e:
            goto L1c
        L72:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L78
        L78:
            return r4
        L79:
            goto L6b
        L7d:
            int r0 = r0 % r1
            goto L32
    }
}

