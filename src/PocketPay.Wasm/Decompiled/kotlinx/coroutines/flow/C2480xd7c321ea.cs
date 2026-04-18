namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5 */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5", m533f = "Zip.kt", m534i = {}, m535l = {273}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C2480xd7c321ea<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow[] $flows;
    readonly /* synthetic */ kotlin.jvm.functions.Function7 $transform$inlined;
    private /* synthetic */ java.lang.object L$0;
    int label;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5$1, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5$1", m533f = "Zip.kt", m534i = {}, m535l = {333}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ kotlin.jvm.functions.Function7 $transform$inlined;
        private /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        int label;

        public AnonymousClass1(kotlin.coroutines.Continuation r1, kotlin.jvm.functions.Function7 r2) {
                r0 = this;
                goto L1e
            L4:
                r2 = 3
                goto L11
            L9:
                return
            La:
                goto Le
            Le:
                goto L21
            L11:
                r0.<init>(r2, r1)
                goto L9
            L18:
                r0.$transform$inlined = r2
                goto L4
            L1e:
                goto La
            L21:
                goto L18
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object[] r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto Lf
            L9:
                java.lang.object[] r2 = (java.lang.object[]) r2
                goto L1f
            Lf:
                goto L15
            L12:
                goto L5
            L15:
                goto L19
            L19:
                kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
                goto L9
            L1f:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L25
            L25:
                java.lang.object r0 = r0.invoke(r1, r2, r3)
                goto L4
        }

        public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r2, java.lang.object[] r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
                r1 = this;
                goto L39
            L4:
                r0.L$1 = r3
                goto La
            La:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L15
            L10:
                return r1
            L11:
                goto L1d
            L15:
                java.lang.object r1 = r0.invokeSuspend(r1)
                goto L10
            L1d:
                goto L3c
            L20:
                kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5$1
                goto L2c
            L26:
                r0.L$0 = r2
                goto L4
            L2c:
                kotlin.jvm.functions.Function7 r1 = r1.$transform$inlined
                goto L32
            L32:
                r0.<init>(r4, r1)
                goto L26
            L39:
                goto L11
            L3c:
                goto L20
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r12) {
                r11 = this;
                goto La7
            L4:
                r7 = r12[r1]
                goto L84
            La:
                java.lang.object[] r12 = (java.lang.object[]) r12
                goto Lcd
            L10:
                kotlin.Unit r11 = kotlin.Unit.INSTANCE
                goto L2a
            L16:
                r1 = 2
                goto L4
            L1b:
                goto L73
            L1e:
                goto L118
            L22:
                java.lang.object r11 = r3.invoke(r4, r5, r6, r7, r8, r9, r10)
                goto L50
            L2a:
                return r11
            L2b:
                goto L1b
            L2f:
                int r0 = r0 % r1
                goto Lef
            L35:
                r9 = r12[r1]
                goto L4a
            L3b:
                r8 = r12[r1]
                goto Lb9
            L41:
                if (r1 == r2) goto L46
                goto L61
            L46:
                goto L7d
            L4a:
                r11.label = r2
                goto L65
            L50:
                if (r11 == r0) goto L55
                goto L90
            L55:
                goto L8f
            L59:
                r11.<init>(r12)
                goto L10d
            L60:
                goto L90
            L61:
                goto Le4
            L65:
                r10 = r11
                goto L22
            L6a:
                int r0 = r0 + r1
                goto L2f
            L70:
                goto L2b
            L73:
                goto L105
            L77:
                java.lang.object r12 = r11.L$1
                goto La
            L7d:
                kotlin.ResultKt.throwOnFailure(r12)
                goto L60
            L84:
                r1 = 3
                goto L3b
            L89:
                java.lang.string r12 = "call to 'resume' before 'invoke' with coroutine"
                goto L59
            L8f:
                return r0
            L90:
                goto L10
            L94:
                r5 = r12[r1]
                goto Lf8
            L9a:
                r0 = 16
                goto Ld8
            La1:
                kotlin.jvm.functions.Function7 r3 = r11.$transform$inlined
                goto Ldf
            La7:
                goto L1e
            Laa:
                goto L9a
            Lae:
                r2 = 1
                goto Lc4
            Lb3:
                kotlinx.coroutines.flow.FlowCollector r4 = (kotlinx.coroutines.flow.FlowCollector) r4
                goto L77
            Lb9:
                r1 = 4
                goto L35
            Lbe:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto La1
            Lc4:
                if (r1 != 0) goto Lc9
                goto L10e
            Lc9:
                goto L41
            Lcd:
                r1 = r11
                goto Lbe
            Ld2:
                java.lang.object r12 = r11.L$0
                goto Lea
            Ld8:
                r1 = 6
                goto L6a
            Ldf:
                r1 = 0
                goto L94
            Le4:
                java.lang.IllegalStateException r11 = new java.lang.IllegalStateException
                goto L89
            Lea:
                r4 = r12
                goto Lb3
            Lef:
                if (r0 <= 0) goto Lf4
                goto L73
            Lf4:
                goto L70
            Lf8:
                r6 = r12[r2]
                goto L16
            Lfe:
                kotlin.ResultKt.throwOnFailure(r12)
                goto Ld2
            L105:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L112
            L10d:
                throw r11
            L10e:
                goto Lfe
            L112:
                int r1 = r11.label
                goto Lae
            L118:
                goto Laa
        }
    }

    public C2480xd7c321ea(kotlinx.coroutines.flow.Flow[] r1, kotlin.coroutines.Continuation r2, kotlin.jvm.functions.Function7 r3) {
            r0 = this;
            goto L24
        L4:
            r1 = 2
            goto Lf
        L9:
            r0.$transform$inlined = r3
            goto L4
        Lf:
            r0.<init>(r1, r2)
            goto L19
        L16:
            goto L27
        L19:
            return
        L1a:
            goto L16
        L1e:
            r0.$flows = r1
            goto L9
        L24:
            goto L1a
        L27:
            goto L1e
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L36
        L4:
            kotlin.jvm.functions.Function7 r2 = r2.$transform$inlined
            goto L44
        La:
            kotlinx.coroutines.flow.Flow[] r1 = r2.$flows
            goto L4
        L10:
            int r0 = r0 % r1
            goto L4b
        L16:
            r1 = 23
            goto L60
        L1d:
            return r0
        L1e:
            goto L22
        L22:
            goto L2c
        L25:
            goto L66
        L29:
            goto L1e
        L2c:
            goto L5a
        L30:
            r0.L$0 = r3
            goto L54
        L36:
            goto L25
        L39:
            goto L3d
        L3d:
            r0 = 22
            goto L16
        L44:
            r0.<init>(r1, r4, r2)
            goto L30
        L4b:
            if (r0 <= 0) goto L50
            goto L2c
        L50:
            goto L29
        L54:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L1d
        L5a:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5
            goto La
        L60:
            int r0 = r0 + r1
            goto L10
        L66:
            goto L39
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L17
        L11:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
        L17:
            goto L23
        L1a:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L11
        L20:
            goto Ld
        L23:
            goto L1a
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L20
        L7:
            goto L11
        Lb:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L24
        L11:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L19
        L19:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5 r0 = (kotlinx.coroutines.flow.C2480xd7c321ea) r0
            goto Lb
        L1f:
            return r0
        L20:
            goto L2c
        L24:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L1f
        L2c:
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
            r7 = this;
            goto Lca
        L4:
            int r0 = r0 + r1
            goto Ldf
        La:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L55
        L12:
            kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
            goto Le5
        L18:
            if (r7 == r0) goto L1d
            goto Lf1
        L1d:
            goto Lf0
        L21:
            throw r7
        L22:
            goto Lbe
        L26:
            r5 = 0
            goto Ld9
        L2b:
            r4.<init>(r5, r6)
            goto L68
        L32:
            r0 = 29
            goto L8c
        L39:
            kotlin.jvm.functions.Function0 r3 = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory()
            goto L74
        L41:
            java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
            goto L99
        L47:
            goto Lc6
        L4a:
            goto La
        L4e:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L62
        L55:
            int r1 = r7.label
            goto Lf5
        L5b:
            goto L4a
        L5e:
            goto La6
        L62:
            goto Lf1
        L64:
            goto La9
        L68:
            kotlin.jvm.functions.Function3 r4 = (kotlin.jvm.functions.Function3) r4
            goto Leb
        L6e:
            java.lang.object r8 = r7.L$0
            goto La0
        L74:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5$1 r4 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$5$1
            goto L26
        L7a:
            if (r1 == r2) goto L7f
            goto L64
        L7f:
            goto L4e
        L83:
            if (r1 != 0) goto L88
            goto L22
        L88:
            goto L7a
        L8c:
            r1 = 29
            goto L4
        L93:
            kotlin.Unit r7 = kotlin.Unit.INSTANCE
            goto Lc5
        L99:
            r7.<init>(r8)
            goto L21
        La0:
            kotlinx.coroutines.flow.FlowCollector r8 = (kotlinx.coroutines.flow.FlowCollector) r8
            goto Lb8
        La6:
            goto Lcd
        La9:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L41
        Laf:
            if (r0 <= 0) goto Lb4
            goto L4a
        Lb4:
            goto L47
        Lb8:
            kotlinx.coroutines.flow.Flow[] r1 = r7.$flows
            goto L39
        Lbe:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L6e
        Lc5:
            return r7
        Lc6:
            goto L5b
        Lca:
            goto L5e
        Lcd:
            goto L32
        Ld1:
            java.lang.object r7 = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(r8, r1, r3, r4, r5)
            goto L18
        Ld9:
            kotlin.jvm.functions.Function7 r6 = r7.$transform$inlined
            goto L2b
        Ldf:
            int r0 = r0 % r1
            goto Laf
        Le5:
            r7.label = r2
            goto Ld1
        Leb:
            r5 = r7
            goto L12
        Lf0:
            return r0
        Lf1:
            goto L93
        Lf5:
            r2 = 1
            goto L83
    }
}

