namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1<T> : kotlinx.coroutines.flow.Flow<T> {
    readonly /* synthetic */ java.lang.object[] $elements$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1", m533f = "Builders.kt", m534i = {0, 0}, m535l = {115}, m536m = "collect", m537n = {"this", "$this$flowOf_u24lambda_u248"}, m538s = {"L$0", "L$1"})
    public static readonly class C23961 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        int I$0;
        int I$1;
        java.lang.object L$0;
        java.lang.object L$1;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1 this$0;

        public C23961(kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1 r1, kotlin.coroutines.Continuation r2) {
                r0 = this;
                goto L14
            L4:
                goto L17
            L7:
                r0.this$0 = r1
                goto Ld
            Ld:
                r0.<init>(r2)
                goto L1b
            L14:
                goto L1c
            L17:
                goto L7
            L1b:
                return
            L1c:
                goto L4
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L4
            L4:
                goto L26
            L7:
                goto L3b
            Lb:
                goto L7
            Le:
                int r2 = r1.label
                goto L1f
            L14:
                r2 = r2 | r0
                goto L19
            L19:
                r1.label = r2
                goto L2f
            L1f:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L14
            L25:
                return r1
            L26:
                goto Lb
            L2a:
                r0 = 0
                goto L35
            L2f:
                kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1 r2 = r1.this$0
                goto L2a
            L35:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L41
            L3b:
                r1.result = r2
                goto Le
            L41:
                java.lang.object r1 = r2.collect(r0, r1)
                goto L25
        }
    }

    public FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1(java.lang.object[] r1) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            r0.<init>()
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L1a
        L1a:
            r0.$elements$inlined = r1
            goto L7
    }

    @Override // kotlinx.coroutines.flow.Flow
    public java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> r7, kotlin.coroutines.Continuation<kotlin.Unit> r8) {
            r6 = this;
            goto L16f
        L4:
            r1 = r1 & r2
            goto L1a6
        L9:
            r7 = r6
            goto L97
        Le:
            int r8 = r8 - r2
            goto L118
        L13:
            java.lang.object r4 = r0.L$0
            goto Le2
        L19:
            kotlinx.coroutines.flow.FlowCollector r2 = (kotlinx.coroutines.flow.FlowCollector) r2
            goto L13
        L1f:
            goto L87
        L20:
            goto Lc1
        L24:
            java.lang.object[] r4 = r7.$elements$inlined
            goto Le8
        L2a:
            goto L35
        L2b:
            goto L128
        L2f:
            goto L53
        L30:
            goto L134
        L34:
            r8 = r5
        L35:
            goto L19d
        L39:
            int r8 = r8.length
            goto L191
        L3e:
            int r2 = r7 + 1
            goto L8b
        L44:
            kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1$1 r0 = (kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1.C23961) r0
            goto Laf
        L4a:
            java.lang.object[] r8 = r6.$elements$inlined
            goto L39
        L50:
            r0.<init>(r6, r8)
        L53:
            goto L148
        L57:
            r3 = 1
            goto Lf4
        L5c:
            if (r0 <= 0) goto L61
            goto L114
        L61:
            goto L111
        L65:
            bool r0 = r8 is kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1.C23961
            goto L108
        L6b:
            r0.I$1 = r6
            goto L102
        L71:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L4
        L77:
            if (r2 == r3) goto L7c
            goto L20
        L7c:
            goto L169
        L80:
            int r8 = r0.label
            goto Le
        L86:
            r7 = r2
        L87:
            goto L3e
        L8b:
            r7 = r4
            goto L2a
        L90:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L11e
        L97:
            r6 = r8
            goto L34
        L9c:
            throw r6
        L9d:
            goto L90
        La1:
            int r0 = r0 % r1
            goto L5c
        La7:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L182
        Laf:
            int r1 = r0.label
            goto L71
        Lb5:
            r0.L$0 = r7
            goto L153
        Lbb:
            int r0 = r0 + r1
            goto La1
        Lc1:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto Lc7
        Lc7:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L13a
        Lcd:
            java.lang.object r4 = r8.emit(r4, r0)
            goto L188
        Ld5:
            int r7 = r0.I$0
            goto L12e
        Ldb:
            r0 = 32
            goto L196
        Le2:
            kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1 r4 = (kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1) r4
            goto L141
        Le8:
            r4 = r4[r2]
            goto Lb5
        Lee:
            r0.I$0 = r2
            goto L6b
        Lf4:
            if (r2 != 0) goto Lf9
            goto L9d
        Lf9:
            goto L77
        Lfd:
            r5 = r7
            goto L9
        L102:
            r0.label = r3
            goto Lcd
        L108:
            if (r0 != 0) goto L10d
            goto L30
        L10d:
            goto L159
        L111:
            goto L177
        L114:
            goto L65
        L118:
            r0.label = r8
            goto L2f
        L11e:
            r8 = r0
            goto L163
        L123:
            return r1
        L124:
            goto L15e
        L128:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L176
        L12e:
            java.lang.object r2 = r0.L$1
            goto L19
        L134:
            kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1$1 r0 = new kotlinx.coroutines.flow.FlowKt__BuildersKt$flowOf$$inlined$unsafeFlow$1$1
            goto L50
        L13a:
            r6.<init>(r7)
            goto L9c
        L141:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L14e
        L148:
            java.lang.object r8 = r0.result
            goto La7
        L14e:
            r8 = r2
            goto L1f
        L153:
            r0.L$1 = r8
            goto Lee
        L159:
            r0 = r8
            goto L44
        L15e:
            r4 = r7
            goto L86
        L163:
            kotlin.coroutines.Continuation r8 = (kotlin.coroutines.Continuation) r8
            goto L4a
        L169:
            int r6 = r0.I$1
            goto Ld5
        L16f:
            goto L17e
        L172:
            goto Ldb
        L176:
            return r6
        L177:
            goto L17b
        L17b:
            goto L114
        L17e:
            goto L1af
        L182:
            int r2 = r0.label
            goto L57
        L188:
            if (r4 == r1) goto L18d
            goto L124
        L18d:
            goto L123
        L191:
            r2 = 0
            goto Lfd
        L196:
            r1 = 7
            goto Lbb
        L19d:
            if (r2 < r6) goto L1a2
            goto L2b
        L1a2:
            goto L24
        L1a6:
            if (r1 != 0) goto L1ab
            goto L30
        L1ab:
            goto L80
        L1af:
            goto L172
    }
}

