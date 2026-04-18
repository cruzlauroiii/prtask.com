namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1 */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0019\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0005\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0006¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/FlowKt__LimitKt$collectWhile$collector$1", "Lkotlinx/coroutines/flow/FlowCollector;", "emit", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class C2428xdf1aa1b6<T> : kotlinx.coroutines.flow.FlowCollector<T> {
    readonly /* synthetic */ kotlinx.coroutines.flow.FlowCollector $$this$flow$inlined;
    readonly /* synthetic */ kotlin.jvm.functions.Function3 $transform$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1$1, reason: invalid class name */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1", m533f = "Limit.kt", m534i = {0}, m535l = {142}, m536m = "emit", m537n = {"this"}, m538s = {"L$0"})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        java.lang.object L$0;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ kotlinx.coroutines.flow.C2428xdf1aa1b6 this$0;

        public AnonymousClass1(kotlinx.coroutines.flow.C2428xdf1aa1b6 r1, kotlin.coroutines.Continuation r2) {
                r0 = this;
                goto L19
            L4:
                return
            L5:
                goto L9
            L9:
                goto L1c
            Lc:
                r0.<init>(r2)
                goto L4
            L13:
                r0.this$0 = r1
                goto Lc
            L19:
                goto L5
            L1c:
                goto L13
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L19
            L4:
                r2 = r2 | r0
                goto L28
            L9:
                r0 = 0
                goto L3d
            Le:
                kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1 r2 = r1.this$0
                goto L9
            L14:
                return r1
            L15:
                goto L3a
            L19:
                goto L15
            L1c:
                goto L2e
            L20:
                java.lang.object r1 = r2.emit(r0, r1)
                goto L14
            L28:
                r1.label = r2
                goto Le
            L2e:
                r1.result = r2
                goto L43
            L34:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L4
            L3a:
                goto L1c
            L3d:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L20
            L43:
                int r2 = r1.label
                goto L34
        }
    }

    public C2428xdf1aa1b6(kotlin.jvm.functions.Function3 r1, kotlinx.coroutines.flow.FlowCollector r2) {
            r0 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            r0.<init>()
            goto L15
        L15:
            return
        L16:
            goto Lb
        L1a:
            r0.$transform$inlined = r1
            goto L20
        L20:
            r0.$$this$flow$inlined = r2
            goto Le
    }

    @Override // kotlinx.coroutines.flow.FlowCollector
    public java.lang.object Emit(T r5, kotlin.coroutines.Continuation<kotlin.Unit> r6) {
            r4 = this;
            goto Lc0
        L4:
            goto L86
        L7:
            goto Lf3
        Lb:
            r0 = r6
            goto Lae
        L10:
            java.lang.IllegalStateException r4 = new java.lang.IllegalStateException
            goto L138
        L16:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto La3
        L1e:
            java.lang.bool r6 = (java.lang.bool) r6
            goto L3b
        L24:
            if (r5 != 0) goto L29
            goto L13f
        L29:
            goto L105
        L2d:
            r3 = 1
            goto L162
        L32:
            if (r6 == r1) goto L37
            goto L6e
        L37:
            goto L6d
        L3b:
            bool r5 = r6.boolValue()
            goto L24
        L43:
            if (r2 == r3) goto L48
            goto L91
        L48:
            goto Lf9
        L4c:
            kotlin.ResultKt.throwOnFailure(r6)
            goto La9
        L53:
            r0.label = r6
            goto L95
        L59:
            r4.<init>(r5)
            goto L15d
        L60:
            r1 = 14
            goto L149
        L67:
            kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1$1 r0 = new kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1$1
            goto Le6
        L6d:
            return r1
        L6e:
            goto L1e
        L72:
            if (r0 != 0) goto L77
            goto L96
        L77:
            goto Lb
        L7b:
            int r6 = r6 - r2
            goto L53
        L80:
            r1 = r1 & r2
            goto L10b
        L85:
            throw r5
        L86:
            goto L14f
        L8a:
            int r0 = r0 % r1
            goto L9a
        L90:
            goto L6e
        L91:
            goto L10
        L95:
            goto Le9
        L96:
            goto L67
        L9a:
            if (r0 <= 0) goto L9f
            goto L7
        L9f:
            goto L4
        La3:
            int r2 = r0.label
            goto L2d
        La9:
            r6 = r0
            goto Ld3
        Lae:
            kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1$1 r0 = (kotlinx.coroutines.flow.C2428xdf1aa1b6.AnonymousClass1) r0
            goto L143
        Lb4:
            kotlin.jvm.functions.Function3 r6 = r4.$transform$inlined
            goto L12f
        Lba:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L80
        Lc0:
            goto L152
        Lc3:
            goto L114
        Lc7:
            kotlinx.coroutines.flow.internal.AbortFlowException r5 = new kotlinx.coroutines.flow.internal.AbortFlowException
            goto Lff
        Lcd:
            r0.label = r3
            goto L127
        Ld3:
            kotlin.coroutines.Continuation r6 = (kotlin.coroutines.Continuation) r6
            goto Lb4
        Ld9:
            r5.<init>(r4)
            goto L85
        Le0:
            r0.L$0 = r4
            goto Lcd
        Le6:
            r0.<init>(r4, r6)
        Le9:
            goto Led
        Led:
            java.lang.object r6 = r0.result
            goto L16
        Lf3:
            bool r0 = r6 is kotlinx.coroutines.flow.C2428xdf1aa1b6.AnonymousClass1
            goto L72
        Lf9:
            java.lang.object r4 = r0.L$0
            goto L11b
        Lff:
            kotlinx.coroutines.flow.FlowCollector r4 = (kotlinx.coroutines.flow.FlowCollector) r4
            goto Ld9
        L105:
            kotlin.Unit r4 = kotlin.Unit.INSTANCE
            goto L13e
        L10b:
            if (r1 != 0) goto L110
            goto L96
        L110:
            goto L121
        L114:
            r0 = 24
            goto L60
        L11b:
            kotlinx.coroutines.flow.FlowKt__LimitKt$transformWhile$1$invokeSuspend$$inlined$collectWhile$1 r4 = (kotlinx.coroutines.flow.C2428xdf1aa1b6) r4
            goto L156
        L121:
            int r6 = r0.label
            goto L7b
        L127:
            java.lang.object r6 = r6.invoke(r2, r5, r0)
            goto L32
        L12f:
            kotlinx.coroutines.flow.FlowCollector r2 = r4.$$this$flow$inlined
            goto Le0
        L135:
            goto Lc3
        L138:
            java.lang.string r5 = "call to 'resume' before 'invoke' with coroutine"
            goto L59
        L13e:
            return r4
        L13f:
            goto Lc7
        L143:
            int r1 = r0.label
            goto Lba
        L149:
            int r0 = r0 + r1
            goto L8a
        L14f:
            goto L7
        L152:
            goto L135
        L156:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L90
        L15d:
            throw r4
        L15e:
            goto L4c
        L162:
            if (r2 != 0) goto L167
            goto L15e
        L167:
            goto L43
    }
}

