namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2 */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2", m533f = "Zip.kt", m534i = {}, m535l = {273}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C2477xd7c321e7<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow[] $flows;
    readonly /* synthetic */ kotlin.jvm.functions.Function4 $transform$inlined;
    private /* synthetic */ java.lang.object L$0;
    int label;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2$1, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2$1", m533f = "Zip.kt", m534i = {}, m535l = {333}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ kotlin.jvm.functions.Function4 $transform$inlined;
        private /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        int label;

        public AnonymousClass1(kotlin.coroutines.Continuation r1, kotlin.jvm.functions.Function4 r2) {
                r0 = this;
                goto L15
            L4:
                return
            L5:
                goto L1c
            L9:
                r0.<init>(r2, r1)
                goto L4
            L10:
                r2 = 3
                goto L9
            L15:
                goto L5
            L18:
                goto L1f
            L1c:
                goto L18
            L1f:
                r0.$transform$inlined = r2
                goto L10
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object[] r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
                r0 = this;
                goto Lf
            L4:
                goto L12
            L7:
                java.lang.object r0 = r0.invoke(r1, r2, r3)
                goto L22
            Lf:
                goto L23
            L12:
                goto L27
            L16:
                java.lang.object[] r2 = (java.lang.object[]) r2
                goto L1c
            L1c:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L7
            L22:
                return r0
            L23:
                goto L4
            L27:
                kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
                goto L16
        }

        public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r2, java.lang.object[] r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
                r1 = this;
                goto L17
            L4:
                r0.L$0 = r2
                goto L32
            La:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L1e
            L10:
                r0.<init>(r4, r1)
                goto L4
            L17:
                goto L3c
            L1a:
                goto L2c
            L1e:
                java.lang.object r1 = r0.invokeSuspend(r1)
                goto L3b
            L26:
                kotlin.jvm.functions.Function4 r1 = r1.$transform$inlined
                goto L10
            L2c:
                kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2$1
                goto L26
            L32:
                r0.L$1 = r3
                goto La
            L38:
                goto L1a
            L3b:
                return r1
            L3c:
                goto L38
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
                r5 = this;
                goto La8
            L4:
                return r5
            L5:
                goto L34
            L9:
                kotlin.ResultKt.throwOnFailure(r6)
                goto La2
            L10:
                kotlin.Unit r5 = kotlin.Unit.INSTANCE
                goto L4
            L16:
                java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
                goto L5a
            L1c:
                goto Lab
            L1f:
                kotlinx.coroutines.flow.FlowCollector r6 = (kotlinx.coroutines.flow.FlowCollector) r6
                goto L73
            L25:
                java.lang.object r5 = r3.invoke(r6, r4, r1, r5)
                goto L94
            L2d:
                r0 = 31
                goto L4e
            L34:
                goto Lec
            L37:
                goto L1c
            L3b:
                if (r0 <= 0) goto L40
                goto Lec
            L40:
                goto Le9
            L44:
                throw r5
            L45:
                goto L9
            L49:
                goto Lc3
            L4a:
                goto Lc7
            L4e:
                r1 = 20
                goto L61
            L55:
                r3 = r5
                goto L79
            L5a:
                r5.<init>(r6)
                goto L44
            L61:
                int r0 = r0 + r1
                goto Lbc
            L67:
                kotlin.jvm.functions.Function4 r3 = r5.$transform$inlined
                goto Laf
            L6d:
                int r1 = r5.label
                goto L9d
            L73:
                java.lang.object r1 = r5.L$1
                goto Ld4
            L79:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L67
            L7f:
                r5.label = r2
                goto L25
            L85:
                if (r1 == r2) goto L8a
                goto L4a
            L8a:
                goto Lcd
            L8e:
                r1 = r1[r2]
                goto L7f
            L94:
                if (r5 == r0) goto L99
                goto Lc3
            L99:
                goto Lc2
            L9d:
                r2 = 1
                goto Lda
            La2:
                java.lang.object r6 = r5.L$0
                goto L1f
            La8:
                goto L37
            Lab:
                goto L2d
            Laf:
                r4 = 0
                goto Le3
            Lb4:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L6d
            Lbc:
                int r0 = r0 % r1
                goto L3b
            Lc2:
                return r0
            Lc3:
                goto L10
            Lc7:
                java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
                goto L16
            Lcd:
                kotlin.ResultKt.throwOnFailure(r6)
                goto L49
            Ld4:
                java.lang.object[] r1 = (java.lang.object[]) r1
                goto L55
            Lda:
                if (r1 != 0) goto Ldf
                goto L45
            Ldf:
                goto L85
            Le3:
                r4 = r1[r4]
                goto L8e
            Le9:
                goto L5
            Lec:
                goto Lb4
        }
    }

    public C2477xd7c321e7(kotlinx.coroutines.flow.Flow[] r1, kotlin.coroutines.Continuation r2, kotlin.jvm.functions.Function4 r3) {
            r0 = this;
            goto L16
        L4:
            r1 = 2
            goto L9
        L9:
            r0.<init>(r1, r2)
            goto L20
        L10:
            r0.$transform$inlined = r3
            goto L4
        L16:
            goto L21
        L19:
            goto L25
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            r0.$flows = r1
            goto L10
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L12
        L4:
            goto L36
        L7:
            goto L60
        Lb:
            r1 = 19
            goto L40
        L12:
            goto L7
        L15:
            goto L53
        L19:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L25
        L1f:
            int r0 = r0 % r1
            goto L2a
        L25:
            return r0
        L26:
            goto L4
        L2a:
            if (r0 <= 0) goto L2f
            goto L36
        L2f:
            goto L33
        L33:
            goto L26
        L36:
            goto L63
        L3a:
            r0.L$0 = r3
            goto L19
        L40:
            int r0 = r0 + r1
            goto L1f
        L46:
            kotlin.jvm.functions.Function4 r2 = r2.$transform$inlined
            goto L4c
        L4c:
            r0.<init>(r1, r4, r2)
            goto L3a
        L53:
            r0 = 12
            goto Lb
        L5a:
            kotlinx.coroutines.flow.Flow[] r1 = r2.$flows
            goto L46
        L60:
            goto L15
        L63:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2
            goto L5a
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1a
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
            goto L1d
        L1a:
            goto Ld
        L1d:
            goto L21
        L21:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L11
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L1a
        L7:
            goto L1e
        Lb:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2 r0 = (kotlinx.coroutines.flow.C2477xd7c321e7) r0
            goto L26
        L11:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L19
        L19:
            return r0
        L1a:
            goto L2c
        L1e:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto Lb
        L26:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L11
        L2c:
            goto L7
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
            r7 = this;
            goto L76
        L4:
            if (r1 != 0) goto L9
            goto Lb8
        L9:
            goto L29
        Ld:
            int r1 = r7.label
            goto L7d
        L13:
            r5 = 0
            goto L96
        L18:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2$1 r4 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$2$1
            goto L13
        L1e:
            java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
            goto Lde
        L24:
            return r0
        L25:
            goto L67
        L29:
            if (r1 == r2) goto L2e
            goto L9d
        L2e:
            goto L57
        L32:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L1e
        L38:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L82
        L3f:
            return r7
        L40:
            goto Ld7
        L44:
            r0 = 22
            goto La1
        L4b:
            kotlinx.coroutines.flow.Flow[] r1 = r7.$flows
            goto L88
        L51:
            int r0 = r0 % r1
            goto L5e
        L57:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L9c
        L5e:
            if (r0 <= 0) goto L63
            goto Lbf
        L63:
            goto Lbc
        L67:
            kotlin.Unit r7 = kotlin.Unit.INSTANCE
            goto L3f
        L6d:
            if (r7 == r0) goto L72
            goto L25
        L72:
            goto L24
        L76:
            goto Lda
        L79:
            goto L44
        L7d:
            r2 = 1
            goto L4
        L82:
            java.lang.object r8 = r7.L$0
            goto Lcc
        L88:
            kotlin.jvm.functions.Function0 r3 = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory()
            goto L18
        L90:
            r7.label = r2
            goto Leb
        L96:
            kotlin.jvm.functions.Function4 r6 = r7.$transform$inlined
            goto Lb0
        L9c:
            goto L25
        L9d:
            goto L32
        La1:
            r1 = 31
            goto Le5
        La8:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Ld
        Lb0:
            r4.<init>(r5, r6)
            goto Lf3
        Lb7:
            throw r7
        Lb8:
            goto L38
        Lbc:
            goto L40
        Lbf:
            goto La8
        Lc3:
            goto L79
        Lc6:
            kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
            goto L90
        Lcc:
            kotlinx.coroutines.flow.FlowCollector r8 = (kotlinx.coroutines.flow.FlowCollector) r8
            goto L4b
        Ld2:
            r5 = r7
            goto Lc6
        Ld7:
            goto Lbf
        Lda:
            goto Lc3
        Lde:
            r7.<init>(r8)
            goto Lb7
        Le5:
            int r0 = r0 + r1
            goto L51
        Leb:
            java.lang.object r7 = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(r8, r1, r3, r4, r5)
            goto L6d
        Lf3:
            kotlin.jvm.functions.Function3 r4 = (kotlin.jvm.functions.Function3) r4
            goto Ld2
    }
}

