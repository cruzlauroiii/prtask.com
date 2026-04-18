namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1 */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1", m533f = "Zip.kt", m534i = {}, m535l = {273}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C2476xd7c321e6<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow[] $flows;
    readonly /* synthetic */ kotlin.jvm.functions.Function4 $transform$inlined;
    private /* synthetic */ java.lang.object L$0;
    int label;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1", m533f = "Zip.kt", m534i = {}, m535l = {333}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ kotlin.jvm.functions.Function4 $transform$inlined;
        private /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        int label;

        public AnonymousClass1(kotlin.coroutines.Continuation r1, kotlin.jvm.functions.Function4 r2) {
                r0 = this;
                goto L17
            L4:
                r2 = 3
                goto L1e
            L9:
                r0.$transform$inlined = r2
                goto L4
            Lf:
                goto L1a
            L12:
                return
            L13:
                goto Lf
            L17:
                goto L13
            L1a:
                goto L9
            L1e:
                r0.<init>(r2, r1)
                goto L12
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object[] r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
                r0 = this;
                goto L23
            L4:
                return r0
            L5:
                goto L2a
            L9:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto Lf
            Lf:
                java.lang.object r0 = r0.invoke(r1, r2, r3)
                goto L4
            L17:
                kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
                goto L1d
            L1d:
                java.lang.object[] r2 = (java.lang.object[]) r2
                goto L9
            L23:
                goto L5
            L26:
                goto L17
            L2a:
                goto L26
        }

        public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r2, java.lang.object[] r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
                r1 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L36
            La:
                goto L28
            Le:
                r0.L$0 = r2
                goto L22
            L14:
                java.lang.object r1 = r0.invokeSuspend(r1)
                goto L35
            L1c:
                kotlin.jvm.functions.Function4 r1 = r1.$transform$inlined
                goto L2e
            L22:
                r0.L$1 = r3
                goto L3a
            L28:
                kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1
                goto L1c
            L2e:
                r0.<init>(r4, r1)
                goto Le
            L35:
                return r1
            L36:
                goto L4
            L3a:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L14
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
                r5 = this;
                goto L2f
            L4:
                r2 = 1
                goto La6
            L9:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L69
            Lf:
                goto L87
            L12:
                goto L54
            L16:
                int r0 = r0 + r1
                goto L1c
            L1c:
                int r0 = r0 % r1
                goto Le7
            L22:
                goto L12
            L25:
                goto L61
            L29:
                java.lang.object r6 = r5.L$0
                goto Lbb
            L2f:
                goto L25
            L32:
                goto L3c
            L36:
                r5.label = r2
                goto L8b
            L3c:
                r0 = 14
                goto L6f
            L43:
                kotlin.Unit r5 = kotlin.Unit.INSTANCE
                goto L86
            L49:
                int r1 = r5.label
                goto L4
            L4f:
                r4 = 0
                goto Lb5
            L54:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L49
            L5c:
                throw r5
            L5d:
                goto Lc6
            L61:
                goto L32
            L64:
                goto Ld7
            L65:
                goto Le1
            L69:
                kotlin.jvm.functions.Function4 r3 = r5.$transform$inlined
                goto L4f
            L6f:
                r1 = 23
                goto L16
            L76:
                r5.<init>(r6)
                goto L5c
            L7d:
                if (r1 == r2) goto L82
                goto L65
            L82:
                goto L93
            L86:
                return r5
            L87:
                goto L22
            L8b:
                java.lang.object r5 = r3.invoke(r6, r4, r1, r5)
                goto Lcd
            L93:
                kotlin.ResultKt.throwOnFailure(r6)
                goto L64
            L9a:
                r1 = r1[r2]
                goto L36
            La0:
                java.lang.object r1 = r5.L$1
                goto Ldb
            La6:
                if (r1 != 0) goto Lab
                goto L5d
            Lab:
                goto L7d
            Laf:
                java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
                goto L76
            Lb5:
                r4 = r1[r4]
                goto L9a
            Lbb:
                kotlinx.coroutines.flow.FlowCollector r6 = (kotlinx.coroutines.flow.FlowCollector) r6
                goto La0
            Lc1:
                r3 = r5
                goto L9
            Lc6:
                kotlin.ResultKt.throwOnFailure(r6)
                goto L29
            Lcd:
                if (r5 == r0) goto Ld2
                goto Ld7
            Ld2:
                goto Ld6
            Ld6:
                return r0
            Ld7:
                goto L43
            Ldb:
                java.lang.object[] r1 = (java.lang.object[]) r1
                goto Lc1
            Le1:
                java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
                goto Laf
            Le7:
                if (r0 <= 0) goto Lec
                goto L12
            Lec:
                goto Lf
        }
    }

    public C2476xd7c321e6(kotlinx.coroutines.flow.Flow[] r1, kotlin.coroutines.Continuation r2, kotlin.jvm.functions.Function4 r3) {
            r0 = this;
            goto Lf
        L4:
            r0.$transform$inlined = r3
            goto L26
        La:
            return
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L20
        L16:
            goto L12
        L19:
            r0.<init>(r1, r2)
            goto La
        L20:
            r0.$flows = r1
            goto L4
        L26:
            r1 = 2
            goto L19
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L19
        L4:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1
            goto L63
        La:
            if (r0 <= 0) goto Lf
            goto L2c
        Lf:
            goto L29
        L13:
            r0.L$0 = r3
            goto L30
        L19:
            goto L5f
        L1c:
            goto L3d
        L20:
            goto L1c
        L23:
            int r0 = r0 + r1
            goto L44
        L29:
            goto L4b
        L2c:
            goto L4
        L30:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L4a
        L36:
            r1 = 28
            goto L23
        L3d:
            r0 = 5
            goto L36
        L44:
            int r0 = r0 % r1
            goto La
        L4a:
            return r0
        L4b:
            goto L5c
        L4f:
            r0.<init>(r1, r4, r2)
            goto L13
        L56:
            kotlin.jvm.functions.Function4 r2 = r2.$transform$inlined
            goto L4f
        L5c:
            goto L2c
        L5f:
            goto L20
        L63:
            kotlinx.coroutines.flow.Flow[] r1 = r2.$flows
            goto L56
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L15
        L4:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto La
        La:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1f
        L10:
            return r0
        L11:
            goto L1c
        L15:
            goto L11
        L18:
            goto L4
        L1c:
            goto L18
        L1f:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto L10
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L1e
        L11:
            return r0
        L12:
            goto L26
        L16:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L29
        L1e:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L11
        L26:
            goto L7
        L29:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1 r0 = (kotlinx.coroutines.flow.C2476xd7c321e6) r0
            goto Lb
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
            r7 = this;
            goto L89
        L4:
            r0 = 14
            goto Lc8
        Lb:
            kotlin.jvm.functions.Function0 r3 = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory()
            goto Lf3
        L13:
            java.lang.object r7 = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(r8, r1, r3, r4, r5)
            goto Lab
        L1b:
            kotlin.jvm.functions.Function3 r4 = (kotlin.jvm.functions.Function3) r4
            goto L9b
        L21:
            goto L56
        L24:
            goto L78
        L28:
            kotlinx.coroutines.flow.FlowCollector r8 = (kotlinx.coroutines.flow.FlowCollector) r8
            goto L95
        L2e:
            r2 = 1
            goto L61
        L33:
            kotlin.Unit r7 = kotlin.Unit.INSTANCE
            goto Le7
        L39:
            kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
            goto L4d
        L3f:
            if (r0 <= 0) goto L44
            goto L56
        L44:
            goto L53
        L48:
            r5 = 0
            goto Lcf
        L4d:
            r7.label = r2
            goto L13
        L53:
            goto Le8
        L56:
            goto L6a
        L5a:
            r7.<init>(r8)
            goto L90
        L61:
            if (r1 != 0) goto L66
            goto L91
        L66:
            goto Lb9
        L6a:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Ld5
        L72:
            java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
            goto L5a
        L78:
            goto L8c
        L7b:
            r4.<init>(r5, r6)
            goto L1b
        L82:
            kotlin.ResultKt.throwOnFailure(r8)
            goto La0
        L89:
            goto L24
        L8c:
            goto L4
        L90:
            throw r7
        L91:
            goto Lec
        L95:
            kotlinx.coroutines.flow.Flow[] r1 = r7.$flows
            goto Lb
        L9b:
            r5 = r7
            goto L39
        La0:
            goto Lb5
        La1:
            goto Le1
        La5:
            java.lang.object r8 = r7.L$0
            goto L28
        Lab:
            if (r7 == r0) goto Lb0
            goto Lb5
        Lb0:
            goto Lb4
        Lb4:
            return r0
        Lb5:
            goto L33
        Lb9:
            if (r1 == r2) goto Lbe
            goto La1
        Lbe:
            goto L82
        Lc2:
            int r0 = r0 + r1
            goto Ldb
        Lc8:
            r1 = 18
            goto Lc2
        Lcf:
            kotlin.jvm.functions.Function4 r6 = r7.$transform$inlined
            goto L7b
        Ld5:
            int r1 = r7.label
            goto L2e
        Ldb:
            int r0 = r0 % r1
            goto L3f
        Le1:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L72
        Le7:
            return r7
        Le8:
            goto L21
        Lec:
            kotlin.ResultKt.throwOnFailure(r8)
            goto La5
        Lf3:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1 r4 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$1$1
            goto L48
    }
}

