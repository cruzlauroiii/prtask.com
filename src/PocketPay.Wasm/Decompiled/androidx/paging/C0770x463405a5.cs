namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: renamed from: androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\t"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$$inlined$unsafeFlow$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class C0770x463405a5<R> : kotlinx.coroutines.flow.Flow<androidx.paging.PageEvent<R>> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow $this_unsafeTransform$inlined;
    readonly /* synthetic */ kotlin.jvm.functions.Function2 $transform$inlined;


    /* JADX INFO: renamed from: androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
    public static readonly class AnonymousClass2<T> : kotlinx.coroutines.flow.FlowCollector {
        readonly /* synthetic */ kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
        readonly /* synthetic */ kotlin.jvm.functions.Function2 $transform$inlined$1;

        /* JADX INFO: renamed from: androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2$1, reason: invalid class name */
        @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
        @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2", m533f = "PagingDataTransforms.kt", m534i = {}, m535l = {224, 223}, m536m = "emit", m537n = {}, m538s = {})
        public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
            java.lang.object L$0;
            int label;
            /* synthetic */ java.lang.object result;
            readonly /* synthetic */ androidx.paging.C0770x463405a5.AnonymousClass2 this$0;

            public AnonymousClass1(androidx.paging.C0770x463405a5.AnonymousClass2 r1, kotlin.coroutines.Continuation r2) {
                    r0 = this;
                    goto L4
                L4:
                    goto L1c
                L7:
                    goto Lb
                Lb:
                    r0.this$0 = r1
                    goto L14
                L11:
                    goto L7
                L14:
                    r0.<init>(r2)
                    goto L1b
                L1b:
                    return
                L1c:
                    goto L11
            }

            @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
            public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                    r1 = this;
                    goto L4
                L4:
                    goto L34
                L7:
                    goto L38
                Lb:
                    r2 = r2 | r0
                    goto L10
                L10:
                    r1.label = r2
                    goto L3e
                L16:
                    goto L7
                L19:
                    r0 = -2147483648(0xffffffff80000000, float:-0.0)
                    goto Lb
                L1f:
                    kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                    goto L2b
                L25:
                    int r2 = r1.label
                    goto L19
                L2b:
                    java.lang.object r1 = r2.emit(r0, r1)
                    goto L33
                L33:
                    return r1
                L34:
                    goto L16
                L38:
                    r1.result = r2
                    goto L25
                L3e:
                    androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2 r2 = r1.this$0
                    goto L44
                L44:
                    r0 = 0
                    goto L1f
            }
        }

        public AnonymousClass2(kotlinx.coroutines.flow.FlowCollector r1, kotlin.jvm.functions.Function2 r2) {
                r0 = this;
                goto L18
            L4:
                r0.$transform$inlined$1 = r2
                goto L1f
            La:
                return
            Lb:
                goto L15
            Lf:
                r0.$this_unsafeFlow = r1
                goto L4
            L15:
                goto L1b
            L18:
                goto Lb
            L1b:
                goto Lf
            L1f:
                r0.<init>()
                goto La
        }

        @Override // kotlinx.coroutines.flow.FlowCollector
        public readonly java.lang.object Emit(java.lang.object r7, kotlin.coroutines.Continuation r8) {
                r6 = this;
                goto L14e
            L4:
                int r1 = r0.label
                goto L16b
            La:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L6d
            L11:
                r1 = 22
                goto L176
            L18:
                r0 = 21
                goto L11
            L1f:
                goto L10e
            L21:
                goto L101
            L25:
                java.lang.object r8 = r0.result
                goto L2b
            L2b:
                java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto Lbb
            L33:
                r3 = 2
                goto L182
            L38:
                kotlin.Unit r6 = kotlin.Unit.INSTANCE
                goto L171
            L3e:
                r5 = r8
                goto Ld8
            L43:
                androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2$1 r0 = (androidx.paging.C0770x463405a5.AnonymousClass2.AnonymousClass1) r0
                goto L4
            L49:
                if (r6 == r1) goto L4e
                goto L10e
            L4e:
                goto L10d
            L52:
                r0.<init>(r6, r8)
            L55:
                goto L25
            L59:
                throw r6
            L5a:
                goto Le3
            L5e:
                goto L14a
            L60:
                goto La
            L64:
                if (r2 != r4) goto L69
                goto L5a
            L69:
                goto Lca
            L6d:
                kotlinx.coroutines.flow.FlowCollector r8 = r6.$this_unsafeFlow
                goto L137
            L73:
                java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
                goto L124
            L79:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L1f
            L80:
                r0.L$0 = r8
                goto L12b
            L86:
                if (r0 != 0) goto L8b
                goto La5
            L8b:
                goto L144
            L8f:
                int r0 = r0 % r1
                goto L95
            L95:
                if (r0 <= 0) goto L9a
                goto L160
            L9a:
                goto L15d
            L9e:
                androidx.paging.PageEvent r7 = (androidx.paging.PageEvent) r7
                goto Lef
            La4:
                goto L55
            La5:
                goto L107
            La9:
                if (r2 != 0) goto Lae
                goto L60
            Lae:
                goto L64
            Lb2:
                goto L151
            Lb5:
                kotlinx.coroutines.flow.FlowCollector r6 = (kotlinx.coroutines.flow.FlowCollector) r6
                goto L11d
            Lbb:
                int r2 = r0.label
                goto L33
            Lc1:
                if (r6 == r1) goto Lc6
                goto L133
            Lc6:
                goto L131
            Lca:
                if (r2 == r3) goto Lcf
                goto L21
            Lcf:
                goto L79
            Ld3:
                int r8 = r8 - r2
                goto Lf5
            Ld8:
                r8 = r6
                goto L149
            Ldd:
                r0.label = r3
                goto L155
            Le3:
                java.lang.object r6 = r0.L$0
                goto Lb5
            Le9:
                bool r0 = r8 is androidx.paging.C0770x463405a5.AnonymousClass2.AnonymousClass1
                goto L86
            Lef:
                kotlin.jvm.functions.Function2 r6 = r6.$transform$inlined$1
                goto L80
            Lf5:
                r0.label = r8
                goto La4
            Lfb:
                int r8 = r0.label
                goto Ld3
            L101:
                java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
                goto L73
            L107:
                androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2$1 r0 = new androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2$1
                goto L52
            L10d:
                return r1
            L10e:
                goto L38
            L112:
                kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
                goto L9e
            L118:
                r7 = 0
                goto L17c
            L11d:
                kotlin.ResultKt.throwOnFailure(r8)
                goto L5e
            L124:
                r6.<init>(r7)
                goto L59
            L12b:
                r0.label = r4
                goto L13c
            L131:
                goto L4e
            L133:
                goto L3e
            L137:
                r2 = r0
                goto L112
            L13c:
                java.lang.object r6 = r6.invoke(r7, r0)
                goto Lc1
            L144:
                r0 = r8
                goto L43
            L149:
                r6 = r5
            L14a:
                goto L118
            L14e:
                goto L167
            L151:
                goto L18
            L155:
                java.lang.object r6 = r6.emit(r8, r0)
                goto L49
            L15d:
                goto L172
            L160:
                goto Le9
            L164:
                goto L160
            L167:
                goto Lb2
            L16b:
                r2 = -2147483648(0xffffffff80000000, float:-0.0)
                goto L190
            L171:
                return r6
            L172:
                goto L164
            L176:
                int r0 = r0 + r1
                goto L8f
            L17c:
                r0.L$0 = r7
                goto Ldd
            L182:
                r4 = 1
                goto La9
            L187:
                if (r1 != 0) goto L18c
                goto La5
            L18c:
                goto Lfb
            L190:
                r1 = r1 & r2
                goto L187
        }

        public readonly java.lang.object emit$$forInline(java.lang.object r2, kotlin.coroutines.Continuation r3) {
                r1 = this;
                goto L1b
            L4:
                androidx.paging.PageEvent r2 = (androidx.paging.PageEvent) r2
                goto L2d
            La:
                androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2$1 r0 = new androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2$1
                goto L33
            L10:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L16
            L16:
                return r1
            L17:
                goto L22
            L1b:
                goto L17
            L1e:
                goto La
            L22:
                goto L1e
            L25:
                java.lang.object r1 = r1.invoke(r2, r3)
                goto L3a
            L2d:
                kotlin.jvm.functions.Function2 r1 = r1.$transform$inlined$1
                goto L25
            L33:
                r0.<init>(r1, r3)
                goto L41
            L3a:
                r0.emit(r1, r3)
                goto L10
            L41:
                kotlinx.coroutines.flow.FlowCollector r0 = r1.$this_unsafeFlow
                goto L4
        }
    }

    public C0770x463405a5(kotlinx.coroutines.flow.Flow r1, kotlin.jvm.functions.Function2 r2) {
            r0 = this;
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L20
        L13:
            r0.$transform$inlined = r2
            goto L19
        L19:
            r0.<init>()
            goto L4
        L20:
            r0.$this_unsafeTransform$inlined = r1
            goto L13
    }

    @Override // kotlinx.coroutines.flow.Flow
    public java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector r3, kotlin.coroutines.Continuation r4) {
            r2 = this;
            goto L2f
        L4:
            goto L14
        L7:
            goto L6d
        Lb:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L7f
        L11:
            goto L19
        L14:
            goto L79
        L18:
            return r2
        L19:
            goto L4
        L1d:
            int r0 = r0 + r1
            goto L4b
        L23:
            return r2
        L24:
            goto L3e
        L28:
            r1 = 4
            goto L1d
        L2f:
            goto L7
        L32:
            goto L57
        L36:
            java.lang.object r3 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L70
        L3e:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L18
        L44:
            r1.<init>(r3, r2)
            goto Lb
        L4b:
            int r0 = r0 % r1
            goto L5e
        L51:
            kotlin.jvm.functions.Function2 r2 = r2.$transform$inlined
            goto L44
        L57:
            r0 = 22
            goto L28
        L5e:
            if (r0 <= 0) goto L63
            goto L14
        L63:
            goto L11
        L67:
            androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2 r1 = new androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2
            goto L51
        L6d:
            goto L32
        L70:
            if (r2 == r3) goto L75
            goto L24
        L75:
            goto L23
        L79:
            kotlinx.coroutines.flow.Flow r0 = r2.$this_unsafeTransform$inlined
            goto L67
        L7f:
            java.lang.object r2 = r0.collect(r1, r4)
            goto L36
    }

    public java.lang.object collect$$forInline(kotlinx.coroutines.flow.FlowCollector r3, kotlin.coroutines.Continuation r4) {
            r2 = this;
            goto L4d
        L4:
            goto L50
        L7:
            r0.collect(r1, r4)
            goto L27
        Le:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L7
        L14:
            kotlin.jvm.functions.Function2 r2 = r2.$transform$inlined
            goto L54
        L1a:
            r0 = 5
            goto L60
        L21:
            kotlinx.coroutines.flow.Flow r0 = r2.$this_unsafeTransform$inlined
            goto L67
        L27:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L5b
        L2d:
            androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$1 r0 = new androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$1
            goto L40
        L33:
            int r0 = r0 % r1
            goto L6d
        L39:
            goto L5c
        L3c:
            goto L2d
        L40:
            r0.<init>(r2, r4)
            goto L21
        L47:
            int r0 = r0 + r1
            goto L33
        L4d:
            goto L79
        L50:
            goto L1a
        L54:
            r1.<init>(r3, r2)
            goto Le
        L5b:
            return r2
        L5c:
            goto L76
        L60:
            r1 = 9
            goto L47
        L67:
            androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2 r1 = new androidx.paging.PagingDataTransforms__PagingDataTransformsKt$transform$$inlined$map$1$2
            goto L14
        L6d:
            if (r0 <= 0) goto L72
            goto L3c
        L72:
            goto L39
        L76:
            goto L3c
        L79:
            goto L4
    }
}

