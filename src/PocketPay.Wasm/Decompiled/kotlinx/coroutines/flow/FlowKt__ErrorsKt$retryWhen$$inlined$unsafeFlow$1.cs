namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1<T> : kotlinx.coroutines.flow.Flow<T> {
    readonly /* synthetic */ kotlin.jvm.functions.Function4 $predicate$inlined;
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow $this_retryWhen$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1", m533f = "Errors.kt", m534i = {0, 0, 0, 0, 1, 1, 1, 1}, m535l = {118, 120}, m536m = "collect", m537n = {"this", "$this$retryWhen_u24lambda_u242", "attempt", "shallRetry", "this", "$this$retryWhen_u24lambda_u242", "cause", "attempt"}, m538s = {"L$0", "L$1", "J$0", "I$0", "L$0", "L$1", "L$2", "J$0"})
    public static readonly class C24221 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        int I$0;
        long J$0;
        java.lang.object L$0;
        java.lang.object L$1;
        java.lang.object L$2;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1 this$0;

        public C24221(kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1 r1, kotlin.coroutines.Continuation r2) {
                r0 = this;
                goto L14
            L4:
                r0.<init>(r2)
                goto L1b
            Lb:
                r0.this$0 = r1
                goto L4
            L11:
                goto L17
            L14:
                goto L1c
            L17:
                goto Lb
            L1b:
                return
            L1c:
                goto L11
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L19
            L4:
                int r2 = r1.label
                goto L2e
            La:
                goto L1c
            Ld:
                r1.result = r2
                goto L4
            L13:
                r1.label = r2
                goto L34
            L19:
                goto L3b
            L1c:
                goto Ld
            L20:
                java.lang.object r1 = r2.collect(r0, r1)
                goto L3a
            L28:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L20
            L2e:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L44
            L34:
                kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1 r2 = r1.this$0
                goto L3f
            L3a:
                return r1
            L3b:
                goto La
            L3f:
                r0 = 0
                goto L28
            L44:
                r2 = r2 | r0
                goto L13
        }
    }

    public FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1(kotlinx.coroutines.flow.Flow r1, kotlin.jvm.functions.Function4 r2) {
            r0 = this;
            goto L4
        L4:
            goto L22
        L7:
            goto L1b
        Lb:
            goto L7
        Le:
            r0.<init>()
            goto L21
        L15:
            r0.$predicate$inlined = r2
            goto Le
        L1b:
            r0.$this_retryWhen$inlined = r1
            goto L15
        L21:
            return
        L22:
            goto Lb
    }

    @Override // kotlinx.coroutines.flow.Flow
    public java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> r13, kotlin.coroutines.Continuation<kotlin.Unit> r14) {
            r12 = this;
            goto Lee
        L4:
            java.lang.Exception r2 = (java.lang.Exception) r2
            goto L84
        La:
            r0.label = r4
            goto L16
        L10:
            int r2 = r0.label
            goto L228
        L16:
            java.lang.object r14 = kotlinx.coroutines.flow.FlowKt.catchImpl(r14, r13, r0)
            goto L1fb
        L1e:
            java.lang.bool r14 = (java.lang.bool) r14
            goto L24a
        L24:
            kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1 r6 = (kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1) r6
            goto Lb3
        L2a:
            r9 = r12
            goto Lba
        L2f:
            long r12 = r12 + r7
            goto L1e6
        L34:
            int r0 = r0 % r1
            goto La4
        L3a:
            r0.label = r14
            goto L62
        L40:
            throw r12
        L41:
            goto L278
        L45:
            goto L1b4
        L47:
            goto L1b3
        L4b:
            r14 = r9
        L4c:
            goto L1e
        L50:
            r0.label = r3
            goto Lc5
        L56:
            java.lang.object r2 = r0.L$2
            goto L4
        L5c:
            r0.L$1 = r13
            goto L1a6
        L62:
            goto L268
        L64:
            goto L10e
        L68:
            r0.L$0 = r6
            goto L1cc
        L6e:
            r12 = r6
            goto L167
        L73:
            r6 = r12
            goto L151
        L78:
            r5 = 0
        L7a:
            goto L26c
        L7e:
            bool r0 = r14 is kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1.C24221
            goto L1d2
        L84:
            java.lang.object r5 = r0.L$1
            goto L135
        L8a:
            goto L4c
        L8c:
            goto L1b8
        L90:
            kotlin.ResultKt.throwOnFailure(r14)
            goto L22d
        L97:
            r0.L$0 = r12
            goto L5c
        L9d:
            r0 = 20
            goto L1eb
        La4:
            if (r0 <= 0) goto La9
            goto L25b
        La9:
            goto L258
        Lad:
            kotlinx.coroutines.flow.FlowCollector r13 = (kotlinx.coroutines.flow.FlowCollector) r13
            goto L1db
        Lb3:
            kotlin.ResultKt.throwOnFailure(r14)
            goto L8a
        Lba:
            r13 = r5
            goto L6e
        Lbf:
            int r0 = r0 + r1
            goto L34
        Lc5:
            java.lang.object r2 = r2.invoke(r5, r14, r7, r0)
            goto L1f2
        Lcd:
            goto Lf1
        Ld0:
            if (r2 != 0) goto Ld5
            goto L274
        Ld5:
            goto L23b
        Ld9:
            if (r2 == r3) goto Lde
            goto L8c
        Lde:
            goto L289
        Le2:
            kotlin.coroutines.Continuation r14 = (kotlin.coroutines.Continuation) r14
            goto L78
        Le8:
            java.lang.string r13 = "call to 'resume' before 'invoke' with coroutine"
            goto L215
        Lee:
            goto L21f
        Lf1:
            goto L9d
        Lf5:
            java.lang.long r7 = kotlin.coroutines.jvm.internal.Boxing.boxlong(r12)
            goto L68
        Lfd:
            r0.J$0 = r12
            goto L50
        L103:
            r2 = 0
            goto L20f
        L108:
            long r5 = r0.J$0
            goto L15b
        L10e:
            kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1$1 r0 = new kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1$1
            goto L265
        L114:
            r0.L$2 = r2
            goto L209
        L11a:
            java.lang.Exception r14 = (java.lang.Exception) r14
            goto L16c
        L120:
            int r14 = r14 - r2
            goto L3a
        L125:
            r0.L$2 = r14
            goto Lfd
        L12b:
            r2 = r14
            goto L4b
        L130:
            return r12
        L131:
            goto L21c
        L135:
            kotlinx.coroutines.flow.FlowCollector r5 = (kotlinx.coroutines.flow.FlowCollector) r5
            goto L146
        L13b:
            r10 = r5
            goto L17b
        L140:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L156
        L146:
            java.lang.object r6 = r0.L$0
            goto L24
        L14c:
            r12 = r10
            goto L272
        L151:
            r5 = r13
            goto L180
        L156:
            r1 = r1 & r2
            goto L232
        L15b:
            java.lang.object r13 = r0.L$1
            goto Lad
        L161:
            kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1$1 r0 = (kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1.C24221) r0
            goto L25f
        L167:
            r5 = r9
            goto L1c3
        L16c:
            if (r14 != 0) goto L171
            goto L1b4
        L171:
            goto L252
        L175:
            java.lang.object r14 = r0.result
            goto L1ab
        L17b:
            r5 = r13
            goto L204
        L180:
            r12 = r9
        L181:
            goto L11a
        L185:
            kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1 r2 = (kotlinx.coroutines.flow.FlowKt__ErrorsKt$retryWhen$$inlined$unsafeFlow$1) r2
            goto L90
        L18b:
            goto L1f7
        L18c:
            goto L223
        L190:
            kotlin.ResultKt.throwOnFailure(r14)
            goto L197
        L197:
            r14 = r0
            goto Le2
        L19c:
            r0 = r14
            goto L161
        L1a1:
            r9 = r2
            goto L12b
        L1a6:
            r2 = 0
            goto L114
        L1ab:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L10
        L1b3:
            throw r2
        L1b4:
            goto L2a
        L1b8:
            java.lang.IllegalStateException r12 = new java.lang.IllegalStateException
            goto Le8
        L1be:
            r2 = r12
            goto L13b
        L1c3:
            if (r2 == 0) goto L1c8
            goto L7a
        L1c8:
            goto L283
        L1cc:
            r0.L$1 = r5
            goto L125
        L1d2:
            if (r0 != 0) goto L1d7
            goto L64
        L1d7:
            goto L19c
        L1db:
            java.lang.object r2 = r0.L$0
            goto L185
        L1e1:
            r4 = 1
            goto Ld0
        L1e6:
            r2 = r4
            goto L45
        L1eb:
            r1 = 24
            goto Lbf
        L1f2:
            if (r2 == r1) goto L1f7
            goto L27f
        L1f7:
            goto L27e
        L1fb:
            if (r14 == r1) goto L200
            goto L18c
        L200:
            goto L18b
        L204:
            r6 = r9
            goto L14c
        L209:
            r0.J$0 = r5
            goto L103
        L20f:
            r0.I$0 = r2
            goto La
        L215:
            r12.<init>(r13)
            goto L40
        L21c:
            goto L25b
        L21f:
            goto Lcd
        L223:
            r9 = r5
            goto L73
        L228:
            r3 = 2
            goto L1e1
        L22d:
            r9 = r2
            goto L1be
        L232:
            if (r1 != 0) goto L237
            goto L64
        L237:
            goto L244
        L23b:
            if (r2 != r4) goto L240
            goto L41
        L240:
            goto Ld9
        L244:
            int r14 = r0.label
            goto L120
        L24a:
            bool r14 = r14.boolValue()
            goto L295
        L252:
            kotlin.jvm.functions.Function4 r2 = r6.$predicate$inlined
            goto Lf5
        L258:
            goto L131
        L25b:
            goto L7e
        L25f:
            int r1 = r0.label
            goto L140
        L265:
            r0.<init>(r12, r14)
        L268:
            goto L175
        L26c:
            kotlinx.coroutines.flow.Flow r14 = r12.$this_retryWhen$inlined
            goto L97
        L272:
            goto L181
        L274:
            goto L190
        L278:
            int r12 = r0.I$0
            goto L108
        L27e:
            return r1
        L27f:
            goto L1a1
        L283:
            kotlin.Unit r12 = kotlin.Unit.INSTANCE
            goto L130
        L289:
            long r12 = r0.J$0
            goto L56
        L28f:
            r7 = 1
            goto L2f
        L295:
            if (r14 != 0) goto L29a
            goto L47
        L29a:
            goto L28f
    }
}

