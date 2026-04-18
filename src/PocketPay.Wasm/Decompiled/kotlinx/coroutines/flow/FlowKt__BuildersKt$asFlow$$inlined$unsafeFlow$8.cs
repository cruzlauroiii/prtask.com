namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8 : kotlinx.coroutines.flow.Flow<java.lang.long> {
    readonly /* synthetic */ long[] $this_asFlow$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8$1 */
    @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8", m533f = "Builders.kt", m534i = {0, 0}, m535l = {116}, m536m = "collect", m537n = {"$this$asFlow_u24lambda_u2415", "$this$forEach$iv"}, m538s = {"L$0", "L$1"})
    public static readonly class C23941 : kotlin.coroutines.jvm.internal.ContinuationImpl {
        int I$0;
        int I$1;
        java.lang.object L$0;
        java.lang.object L$1;
        int label;
        /* synthetic */ java.lang.object result;
        readonly /* synthetic */ kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8 this$0;

        public C23941(kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8 r1, kotlin.coroutines.Continuation r2) {
                r0 = this;
                goto L4
            L4:
                goto L12
            L7:
                goto Lb
            Lb:
                r0.this$0 = r1
                goto L16
            L11:
                return
            L12:
                goto L1d
            L16:
                r0.<init>(r2)
                goto L11
            L1d:
                goto L7
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                r1 = this;
                goto L15
            L4:
                r1.result = r2
                goto L3e
            La:
                return r1
            Lb:
                goto L22
            Lf:
                kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8 r2 = r1.this$0
                goto L44
            L15:
                goto Lb
            L18:
                goto L4
            L1c:
                r0 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L33
            L22:
                goto L18
            L25:
                java.lang.object r1 = r2.collect(r0, r1)
                goto La
            L2d:
                r1.label = r2
                goto Lf
            L33:
                r2 = r2 | r0
                goto L2d
            L38:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L25
            L3e:
                int r2 = r1.label
                goto L1c
            L44:
                r0 = 0
                goto L38
        }
    }

    public FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8(long[] r1) {
            r0 = this;
            goto L16
        L4:
            r0.<init>()
            goto Lb
        Lb:
            return
        Lc:
            goto L1d
        L10:
            r0.$this_asFlow$inlined = r1
            goto L4
        L16:
            goto Lc
        L19:
            goto L10
        L1d:
            goto L19
    }

    @Override // kotlinx.coroutines.flow.Flow
    public java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<java.lang.long> r8, kotlin.coroutines.Continuation<kotlin.Unit> r9) {
            r7 = this;
            goto La8
        L4:
            r7 = r9
            goto L13a
        L9:
            r0.L$1 = r2
            goto L13f
        Lf:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L87
        L15:
            kotlin.coroutines.Continuation r9 = (kotlin.coroutines.Continuation) r9
            goto L123
        L1b:
            r2 = r7
            goto L4
        L20:
            int r9 = r9 - r2
            goto L4e
        L25:
            java.lang.object r2 = r0.L$1
            goto L172
        L2b:
            r9 = r4
            goto L48
        L30:
            int r7 = r0.I$1
            goto L197
        L36:
            java.lang.object r4 = r0.L$0
            goto L54
        L3c:
            kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8$1 r0 = new kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8$1
            goto L145
        L42:
            java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
            goto L116
        L48:
            goto L14d
        L4a:
            goto L18e
        L4e:
            r0.label = r9
            goto Lfa
        L54:
            kotlinx.coroutines.flow.FlowCollector r4 = (kotlinx.coroutines.flow.FlowCollector) r4
            goto L60
        L5a:
            int r9 = r0.label
            goto L20
        L60:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L2b
        L67:
            java.lang.long r4 = kotlin.coroutines.jvm.internal.Boxing.boxlong(r4)
            goto L156
        L6f:
            bool r0 = r9 is kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8.C23941
            goto L10d
        L75:
            kotlin.Unit r7 = kotlin.Unit.INSTANCE
            goto L129
        L7b:
            int r9 = r7.length
            goto Ld0
        L80:
            r1 = 28
            goto L188
        L87:
            r1 = r1 & r2
            goto L169
        L8c:
            r4 = r2[r8]
            goto L67
        L92:
            r9 = r0
            goto L15
        L97:
            if (r0 <= 0) goto L9c
            goto L136
        L9c:
            goto L133
        La0:
            java.lang.object r4 = r9.emit(r4, r0)
            goto Lc1
        La8:
            goto L15f
        Lab:
            goto L19d
        Laf:
            r3 = 1
            goto Lf1
        Lb4:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L178
        Lbc:
            r6 = r2
            goto L1b
        Lc1:
            if (r4 == r1) goto Lc6
            goto L14d
        Lc6:
            goto L14c
        Lca:
            kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8$1 r0 = (kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$8.C23941) r0
            goto L1a4
        Ld0:
            r2 = 0
            goto Lbc
        Ld5:
            kotlin.ResultKt.throwOnFailure(r9)
            goto L92
        Ldc:
            java.lang.object r9 = r0.result
            goto Lb4
        Le2:
            int r0 = r0 % r1
            goto L97
        Le8:
            if (r2 == r3) goto Led
            goto L4a
        Led:
            goto L30
        Lf1:
            if (r2 != 0) goto Lf6
            goto L12f
        Lf6:
            goto Le8
        Lfa:
            goto L148
        Lfb:
            goto L3c
        Lff:
            if (r8 < r7) goto L104
            goto L109
        L104:
            goto L8c
        L108:
            goto L17f
        L109:
            goto L75
        L10d:
            if (r0 != 0) goto L112
            goto Lfb
        L112:
            goto L183
        L116:
            r7.<init>(r8)
            goto L12e
        L11d:
            r0.I$1 = r7
            goto L163
        L123:
            long[] r7 = r7.$this_asFlow$inlined
            goto L7b
        L129:
            return r7
        L12a:
            goto L15c
        L12e:
            throw r7
        L12f:
            goto Ld5
        L133:
            goto L12a
        L136:
            goto L6f
        L13a:
            r9 = r8
            goto L17e
        L13f:
            r0.I$0 = r8
            goto L11d
        L145:
            r0.<init>(r7, r9)
        L148:
            goto Ldc
        L14c:
            return r1
        L14d:
            goto L151
        L151:
            int r8 = r8 + r3
            goto L108
        L156:
            r0.L$0 = r9
            goto L9
        L15c:
            goto L136
        L15f:
            goto L194
        L163:
            r0.label = r3
            goto La0
        L169:
            if (r1 != 0) goto L16e
            goto Lfb
        L16e:
            goto L5a
        L172:
            long[] r2 = (long[]) r2
            goto L36
        L178:
            int r2 = r0.label
            goto Laf
        L17e:
            r8 = r6
        L17f:
            goto Lff
        L183:
            r0 = r9
            goto Lca
        L188:
            int r0 = r0 + r1
            goto Le2
        L18e:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L42
        L194:
            goto Lab
        L197:
            int r8 = r0.I$0
            goto L25
        L19d:
            r0 = 3
            goto L80
        L1a4:
            int r1 = r0.label
            goto Lf
    }
}

