namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4 */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4", m533f = "Zip.kt", m534i = {}, m535l = {273}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C2479xd7c321e9<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow[] $flows;
    readonly /* synthetic */ kotlin.jvm.functions.Function6 $transform$inlined;
    private /* synthetic */ java.lang.object L$0;
    int label;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4$1, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0006H\u008a@¨\u0006\u0007"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", "kotlinx/coroutines/flow/FlowKt__ZipKt$combineTransformUnsafe$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4$1", m533f = "Zip.kt", m534i = {}, m535l = {333}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ kotlin.jvm.functions.Function6 $transform$inlined;
        private /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        int label;

        public AnonymousClass1(kotlin.coroutines.Continuation r1, kotlin.jvm.functions.Function6 r2) {
                r0 = this;
                goto L9
            L4:
                r2 = 3
                goto L1e
            L9:
                goto L1a
            Lc:
                goto L13
            L10:
                goto Lc
            L13:
                r0.$transform$inlined = r2
                goto L4
            L19:
                return
            L1a:
                goto L10
            L1e:
                r0.<init>(r2, r1)
                goto L19
        }

        @Override // kotlin.jvm.functions.Function3
        public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object[] r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
                r0 = this;
                goto L21
            L4:
                kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
                goto L1b
            La:
                java.lang.object r0 = r0.invoke(r1, r2, r3)
                goto L28
            L12:
                goto L24
            L15:
                kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
                goto La
            L1b:
                java.lang.object[] r2 = (java.lang.object[]) r2
                goto L15
            L21:
                goto L29
            L24:
                goto L4
            L28:
                return r0
            L29:
                goto L12
        }

        public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r2, java.lang.object[] r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
                r1 = this;
                goto L11
            L4:
                java.lang.object r1 = r0.invokeSuspend(r1)
                goto Lc
            Lc:
                return r1
            Ld:
                goto L25
            L11:
                goto Ld
            L14:
                goto L1f
            L18:
                r0.<init>(r4, r1)
                goto L28
            L1f:
                kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4$1
                goto L34
            L25:
                goto L14
            L28:
                r0.L$0 = r2
                goto L3a
            L2e:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L4
            L34:
                kotlin.jvm.functions.Function6 r1 = r1.$transform$inlined
                goto L18
            L3a:
                r0.L$1 = r3
                goto L2e
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r11) {
                r10 = this;
                goto Lc6
            L4:
                java.lang.object r11 = r10.L$1
                goto L101
            La:
                goto L76
            Ld:
                goto Ldd
            L11:
                int r0 = r0 + r1
                goto L3c
            L17:
                kotlin.Unit r10 = kotlin.Unit.INSTANCE
                goto L6e
            L1d:
                r1 = 2
                goto L8d
            L22:
                throw r10
            L23:
                goto Ld6
            L27:
                kotlinx.coroutines.flow.FlowCollector r4 = (kotlinx.coroutines.flow.FlowCollector) r4
                goto L4
            L2d:
                r6 = r11[r2]
                goto L1d
            L33:
                if (r0 <= 0) goto L38
                goto L76
            L38:
                goto L73
            L3c:
                int r0 = r0 % r1
                goto L33
            L42:
                int r1 = r10.label
                goto L4e
            L48:
                java.lang.string r11 = "call to 'resume' before 'invoke' with coroutine"
                goto L93
            L4e:
                r2 = 1
                goto L65
            L53:
                goto Lf8
            L55:
                goto Lf1
            L59:
                r0 = 1
                goto L9a
            L60:
                r4 = r11
                goto L27
            L65:
                if (r1 != 0) goto L6a
                goto L23
            L6a:
                goto Lcd
            L6e:
                return r10
            L6f:
                goto La
            L73:
                goto L6f
            L76:
                goto Lad
            L7a:
                kotlin.ResultKt.throwOnFailure(r11)
                goto L53
            L81:
                java.lang.object r11 = r10.L$0
                goto L60
            L87:
                r5 = r11[r1]
                goto L2d
            L8d:
                r7 = r11[r1]
                goto L107
            L93:
                r10.<init>(r11)
                goto L22
            L9a:
                r1 = 10
                goto L11
            La1:
                kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                goto Leb
            La7:
                r10.label = r2
                goto Le6
            Lad:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L42
            Lb5:
                if (r10 == r0) goto Lba
                goto Lf8
            Lba:
                goto Lf7
            Lbe:
                java.lang.object r10 = r3.invoke(r4, r5, r6, r7, r8, r9)
                goto Lb5
            Lc6:
                goto Ld
            Lc9:
                goto L59
            Lcd:
                if (r1 == r2) goto Ld2
                goto L55
            Ld2:
                goto L7a
            Ld6:
                kotlin.ResultKt.throwOnFailure(r11)
                goto L81
            Ldd:
                goto Lc9
            Le0:
                r8 = r11[r1]
                goto La7
            Le6:
                r9 = r10
                goto Lbe
            Leb:
                kotlin.jvm.functions.Function6 r3 = r10.$transform$inlined
                goto L10c
            Lf1:
                java.lang.IllegalStateException r10 = new java.lang.IllegalStateException
                goto L48
            Lf7:
                return r0
            Lf8:
                goto L17
            Lfc:
                r1 = r10
                goto La1
            L101:
                java.lang.object[] r11 = (java.lang.object[]) r11
                goto Lfc
            L107:
                r1 = 3
                goto Le0
            L10c:
                r1 = 0
                goto L87
        }
    }

    public C2479xd7c321e9(kotlinx.coroutines.flow.Flow[] r1, kotlin.coroutines.Continuation r2, kotlin.jvm.functions.Function6 r3) {
            r0 = this;
            goto L24
        L4:
            goto L27
        L7:
            r0.$transform$inlined = r3
            goto L1f
        Ld:
            r0.<init>(r1, r2)
            goto L14
        L14:
            return
        L15:
            goto L4
        L19:
            r0.$flows = r1
            goto L7
        L1f:
            r1 = 2
            goto Ld
        L24:
            goto L15
        L27:
            goto L19
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L58
        L4:
            kotlin.jvm.functions.Function6 r2 = r2.$transform$inlined
            goto L51
        La:
            int r0 = r0 % r1
            goto L29
        L10:
            r0 = 24
            goto L5f
        L17:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L46
        L1d:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4
            goto L4b
        L23:
            int r0 = r0 + r1
            goto La
        L29:
            if (r0 <= 0) goto L2e
            goto L42
        L2e:
            goto L3f
        L32:
            goto L42
        L35:
            goto L66
        L39:
            r0.L$0 = r3
            goto L17
        L3f:
            goto L47
        L42:
            goto L1d
        L46:
            return r0
        L47:
            goto L32
        L4b:
            kotlinx.coroutines.flow.Flow[] r1 = r2.$flows
            goto L4
        L51:
            r0.<init>(r1, r4, r2)
            goto L39
        L58:
            goto L35
        L5b:
            goto L10
        L5f:
            r1 = 1
            goto L23
        L66:
            goto L5b
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L1a
        L4:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto L12
        Lc:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L21
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto L1d
        L1a:
            goto L13
        L1d:
            goto Lc
        L21:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto La
        La:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L12
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto L23
        L1a:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4 r0 = (kotlinx.coroutines.flow.C2479xd7c321e9) r0
            goto L4
        L20:
            goto L13
        L23:
            goto L27
        L27:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L1a
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r8) {
            r7 = this;
            goto Lc3
        L4:
            r4.<init>(r5, r6)
            goto L59
        Lb:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L54
        L12:
            int r0 = r0 % r1
            goto Lca
        L18:
            kotlin.jvm.functions.Function6 r6 = r7.$transform$inlined
            goto L4
        L1e:
            r7.label = r2
            goto L9d
        L24:
            if (r7 == r0) goto L29
            goto Lb3
        L29:
            goto Lb2
        L2d:
            kotlinx.coroutines.flow.Flow[] r1 = r7.$flows
            goto L95
        L33:
            kotlinx.coroutines.flow.FlowCollector r8 = (kotlinx.coroutines.flow.FlowCollector) r8
            goto L2d
        L39:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto Ld9
        L3f:
            throw r7
        L40:
            goto L4d
        L44:
            if (r1 == r2) goto L49
            goto L55
        L49:
            goto Lb
        L4d:
            kotlin.ResultKt.throwOnFailure(r8)
            goto L83
        L54:
            goto Lb3
        L55:
            goto L39
        L59:
            kotlin.jvm.functions.Function3 r4 = (kotlin.jvm.functions.Function3) r4
            goto Lf4
        L5f:
            r2 = 1
            goto L77
        L64:
            int r0 = r0 + r1
            goto L12
        L6a:
            r0 = 18
            goto L89
        L71:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4$1 r4 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combineTransform$$inlined$combineTransformUnsafe$FlowKt__ZipKt$4$1
            goto L90
        L77:
            if (r1 != 0) goto L7c
            goto L40
        L7c:
            goto L44
        L80:
            goto Lc6
        L83:
            java.lang.object r8 = r7.L$0
            goto L33
        L89:
            r1 = 9
            goto L64
        L90:
            r5 = 0
            goto L18
        L95:
            kotlin.jvm.functions.Function0 r3 = kotlinx.coroutines.flow.FlowKt__ZipKt.access$nullArrayFactory()
            goto L71
        L9d:
            java.lang.object r7 = kotlinx.coroutines.flow.internal.CombineKt.combineInternal(r8, r1, r3, r4, r5)
            goto L24
        La5:
            goto Le2
        La8:
            goto L80
        Lac:
            kotlin.Unit r7 = kotlin.Unit.INSTANCE
            goto Lbe
        Lb2:
            return r0
        Lb3:
            goto Lac
        Lb7:
            r7.<init>(r8)
            goto L3f
        Lbe:
            return r7
        Lbf:
            goto La5
        Lc3:
            goto La8
        Lc6:
            goto L6a
        Lca:
            if (r0 <= 0) goto Lcf
            goto Le2
        Lcf:
            goto Ldf
        Ld3:
            int r1 = r7.label
            goto L5f
        Ld9:
            java.lang.string r8 = "call to 'resume' before 'invoke' with coroutine"
            goto Lb7
        Ldf:
            goto Lbf
        Le2:
            goto Le6
        Le6:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Ld3
        Lee:
            kotlin.coroutines.Continuation r5 = (kotlin.coroutines.Continuation) r5
            goto L1e
        Lf4:
            r5 = r7
            goto Lee
    }
}

