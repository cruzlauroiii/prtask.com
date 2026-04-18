namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3 */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3", m533f = "Zip.kt", m534i = {}, m535l = {273}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C2478xd7c321e8<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow[] $flows;
    readonly /* synthetic */ kotlin.jvm.functions.Function5 $transform$inlined;
    private /* synthetic */ java.lang.object L$0;
    int label;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3$1, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3$1", m533f = "Zip.kt", m534i = {}, m535l = {333}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ kotlin.jvm.functions.Function5 $transform$inlined;
        private /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        int label;

        public AnonymousClass1(kotlin.coroutines.Continuation r1, kotlin.jvm.functions.Function5 r2) {
                r0 = this;
                goto L12
            L4:
                return
            L5:
                goto L9
            L9:
                goto L15
            Lc:
                r0.$transform$inlined = r2
                goto L20
            L12:
                goto L5
            L15:
                goto Lc
            L19:
                r0.<init>(r2, r1)
                goto L4
            L20:
                r2 = 3
                goto L19
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object[] r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
                r0 = this;
                goto L15
            L4:
                java.lang.object[] r2 = (java.lang.object[]) r2
                goto La
            La:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto L22
            L10:
                return r0
            L11:
                goto L2a
            L15:
                goto L11
            L18:
                goto L1c
            L1c:
                kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
                goto L4
            L22:
                java.lang.object r0 = r0.invoke(r1, r2, r3)
                goto L10
            L2a:
                goto L18
        }

        public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r2, java.lang.object[] r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
                r1 = this;
                goto Ld
            L4:
                r0.L$1 = r3
                goto L22
            La:
                goto L10
            Ld:
                goto L3c
            L10:
                goto L28
            L14:
                java.lang.object r1 = r0.invokeSuspend(r1)
                goto L3b
            L1c:
                r0.L$0 = r2
                goto L4
            L22:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L14
            L28:
                kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3$1
                goto L2e
            L2e:
                kotlin.jvm.functions.Function5 r1 = r1.$transform$inlined
                goto L34
            L34:
                r0.<init>(r4, r1)
                goto L1c
            L3b:
                return r1
            L3c:
                goto La
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r10) {
                r9 = this;
                goto Lb4
            L4:
                int r1 = r9.label
                goto L93
            La:
                java.lang.IllegalStateException r9 = new java.lang.IllegalStateException
                goto L87
            L10:
                goto L63
            L13:
                goto Le6
            L17:
                goto L13
            L1a:
                goto L103
            L1e:
                return r0
            L1f:
                goto L98
            L23:
                r1 = r9
                goto Lae
            L28:
                java.lang.object r10 = r9.L$0
                goto La9
            L2e:
                kotlin.jvm.functions.Function5 r3 = r9.$transform$inlined
                goto L34
            L34:
                r1 = 0
                goto Lf4
            L39:
                r8 = r9
                goto L4e
            L3e:
                if (r9 == r0) goto L43
                goto L1f
            L43:
                goto L1e
            L47:
                kotlin.ResultKt.throwOnFailure(r10)
                goto L28
            L4e:
                java.lang.object r9 = r3.invoke(r4, r5, r6, r7, r8)
                goto L3e
            L56:
                java.lang.object[] r10 = (java.lang.object[]) r10
                goto L23
            L5c:
                kotlinx.coroutines.flow.FlowCollector r4 = (kotlinx.coroutines.flow.FlowCollector) r4
                goto Lee
            L62:
                return r9
            L63:
                goto L17
            L67:
                r6 = r10[r2]
                goto L9e
            L6d:
                int r0 = r0 + r1
                goto L8d
            L73:
                r9.label = r2
                goto L39
            L79:
                r0 = 4
                goto L80
            L80:
                r1 = 9
                goto L6d
            L87:
                java.lang.string r10 = "call to 'resume' before 'invoke' with coroutine"
                goto Lca
            L8d:
                int r0 = r0 % r1
                goto Lbb
            L93:
                r2 = 1
                goto Lfa
            L98:
                kotlin.Unit r9 = kotlin.Unit.INSTANCE
                goto L62
            L9e:
                r1 = 2
                goto La3
            La3:
                r7 = r10[r1]
                goto L73
            La9:
                r4 = r10
                goto L5c
            Lae:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto L2e
            Lb4:
                goto L1a
            Lb7:
                goto L79
            Lbb:
                if (r0 <= 0) goto Lc0
                goto L13
            Lc0:
                goto L10
            Lc4:
                goto L1f
            Lc6:
                goto La
            Lca:
                r9.<init>(r10)
                goto Ld8
            Ld1:
                kotlin.ResultKt.throwOnFailure(r10)
                goto Lc4
            Ld8:
                throw r9
            Ld9:
                goto L47
            Ldd:
                if (r1 == r2) goto Le2
                goto Lc6
            Le2:
                goto Ld1
            Le6:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L4
            Lee:
                java.lang.object r10 = r9.L$1
                goto L56
            Lf4:
                r5 = r10[r1]
                goto L67
            Lfa:
                if (r1 != 0) goto Lff
                goto Ld9
            Lff:
                goto Ldd
            L103:
                goto Lb7
        }
    }

    public C2478xd7c321e8(kotlinx.coroutines.flow.Flow[] r1, kotlin.coroutines.Continuation r2, kotlin.jvm.functions.Function5 r3) {
            r0 = this;
            goto L24
        L4:
            return
        L5:
            goto L14
        L9:
            r1 = 2
            goto L17
        Le:
            r0.$flows = r1
            goto L1e
        L14:
            goto L27
        L17:
            r0.<init>(r1, r2)
            goto L4
        L1e:
            r0.$transform$inlined = r3
            goto L9
        L24:
            goto L5
        L27:
            goto Le
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L3f
        L4:
            r0.<init>(r1, r4, r2)
            goto L27
        Lb:
            goto L1c
        Le:
            goto L53
        L12:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L1b
        L18:
            goto L42
        L1b:
            return r0
        L1c:
            goto L62
        L20:
            r0 = 6
            goto L4c
        L27:
            r0.L$0 = r3
            goto L12
        L2d:
            int r0 = r0 % r1
            goto L59
        L33:
            kotlinx.coroutines.flow.Flow[] r1 = r2.$flows
            goto L39
        L39:
            kotlin.jvm.functions.Function5 r2 = r2.$transform$inlined
            goto L4
        L3f:
            goto L65
        L42:
            goto L20
        L46:
            int r0 = r0 + r1
            goto L2d
        L4c:
            r1 = 10
            goto L46
        L53:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3
            goto L33
        L59:
            if (r0 <= 0) goto L5e
            goto Le
        L5e:
            goto Lb
        L62:
            goto Le
        L65:
            goto L18
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L1b
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto Le
        L1b:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L21
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L13
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L23
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto La
        La:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L2a
        L12:
            goto L26
        L15:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L1d
        L1d:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3 r0 = (kotlinx.coroutines.flow.C2478xd7c321e8) r0
            goto L4
        L23:
            goto L2b
        L26:
            goto L15
        L2a:
            return r0
        L2b:
            goto L12
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
            r7 = this;
            goto L58
        L4:
            throw r7
        L5:
            goto L3e
        L9:
            return r0
        La:
            goto L1e
        Le:
            if (r7 == r0) goto L13
            goto La
        L13:
            goto L9
        L17:
            goto La2
        L1a:
            goto L4e
        L1e:
            kotlin.Unit r7 = kotlin.Unit.INSTANCE
            goto L78
        L24:
            r5 = r7
            goto Lce
        L29:
            int r0 = r0 + r1
            goto L65
        L2f:
            if (r0 <= 0) goto L34
            goto La2
        L34:
            goto L9f
        L38:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3$1 r4 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$3$1
            goto L89
        L3e:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L93
        L45:
            if (r1 == r2) goto L4a
            goto L9b
        L4a:
            goto Ldc
        L4e:
            goto L5b
        L51:
            r1 = 7
            goto L29
        L58:
            goto L1a
        L5b:
            goto Lb9
        L5f:
            kotlin.jvm.functions.Function5 r6 = r7.$transform$inlined
            goto Lac
        L65:
            int r0 = r0 % r1
            goto L2f
        L6b:
            r7.<init>(r8)
            goto L4
        L72:
            kotlinx.coroutines.flow.FlowCollector r8 = (kotlinx.coroutines.flow.FlowCollector) r8
            goto Le3
        L78:
            return r7
        L79:
            goto L17
        L7d:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L83
        L83:
            java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
            goto L6b
        L89:
            r5 = 0
            goto L5f
        L8e:
            r2 = 1
            goto Lf1
        L93:
            java.lang.object r8 = r7.L$0
            goto L72
        L99:
            goto La
        L9b:
            goto L7d
        L9f:
            goto L79
        La2:
            goto Lc0
        La6:
            r7.label = r2
            goto Le9
        Lac:
            r4.<init>(r5, r6)
            goto Lc8
        Lb3:
            int r1 = r7.label
            goto L8e
        Lb9:
            r0 = 28
            goto L51
        Lc0:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lb3
        Lc8:
            kotlin.jvm.functions.Function3 r4 = (kotlin.jvm.functions.Function3) r4
            goto L24
        Lce:
            kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
            goto La6
        Ld4:
            kotlin.jvm.functions.Function0 r3 = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory()
            goto L38
        Ldc:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L99
        Le3:
            kotlinx.coroutines.flow.Flow[] r1 = r7.$flows
            goto Ld4
        Le9:
            java.lang.object r7 = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(r8, r1, r3, r4, r5)
            goto Le
        Lf1:
            if (r1 != 0) goto Lf6
            goto L5
        Lf6:
            goto L45
    }
}

