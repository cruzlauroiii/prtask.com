namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [Value] */
/* JADX INFO: renamed from: androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u0005H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Landroidx/paging/SimpleProducerScope;", "androidx/paging/FlowExtKt$combineWithoutBatching$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {161}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C0730x6423e720<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow $otherFlow;
    readonly /* synthetic */ androidx.paging.MutableLoadStateICollection $sourceStates$inlined;
    readonly /* synthetic */ kotlinx.coroutines.flow.Flow $this_combineWithoutBatching;
    private /* synthetic */ java.lang.object L$0;
    int label;

    /* JADX INFO: renamed from: androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$1, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\u0006\u0010\u0005\u001a\u0002H\u00022\u0006\u0010\u0006\u001a\u0002H\u00032\u0006\u0010\u0007\u001a\u00020\bH\u008a@¨\u0006\t"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "t1", "t2", "updateFrom", "Landroidx/paging/CombineSource;", "androidx/paging/FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {141}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function4<androidx.paging.LoadStates, androidx.paging.PageEvent<Value>, androidx.paging.CombineSource, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> $$this$simpleChannelFlow;
        readonly /* synthetic */ androidx.paging.MutableLoadStateICollection $sourceStates$inlined;
        /* synthetic */ java.lang.object L$0;
        /* synthetic */ java.lang.object L$1;
        /* synthetic */ java.lang.object L$2;
        int label;

        public AnonymousClass1(androidx.paging.SimpleProducerScope r1, kotlin.coroutines.Continuation r2, androidx.paging.MutableLoadStateICollection r3) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L21
            La:
                goto L25
            Le:
                r1 = 4
                goto L13
            L13:
                r0.<init>(r1, r2)
                goto L20
            L1a:
                r0.$$this$simpleChannelFlow = r1
                goto Le
            L20:
                return
            L21:
                goto L4
            L25:
                r0.$sourceStates$inlined = r3
                goto L1a
        }

        public readonly java.lang.object Invoke(androidx.paging.LoadStates r3, androidx.paging.PageEvent<Value> r4, androidx.paging.CombineSource r5, kotlin.coroutines.Continuation<kotlin.Unit> r6) {
                r2 = this;
                goto L27
            L4:
                return r2
            L5:
                goto L4f
            L9:
                r0.L$1 = r4
                goto L2e
            Lf:
                goto L2a
            L12:
                androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> r1 = r2.$$this$simpleChannelFlow
                goto L43
            L18:
                androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$1 r0 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$1
                goto L12
            L1e:
                if (r0 <= 0) goto L23
                goto L3f
            L23:
                goto L3c
            L27:
                goto L52
            L2a:
                goto L5c
            L2e:
                r0.L$2 = r5
                goto L71
            L34:
                java.lang.object r2 = r0.invokeSuspend(r2)
                goto L4
            L3c:
                goto L5
            L3f:
                goto L18
            L43:
                androidx.paging.MutableLoadStateICollection r2 = r2.$sourceStates$inlined
                goto L6a
            L49:
                int r0 = r0 % r1
                goto L1e
            L4f:
                goto L3f
            L52:
                goto Lf
            L56:
                r0.L$0 = r3
                goto L9
            L5c:
                r0 = 19
                goto L63
            L63:
                r1 = 3
                goto L77
            L6a:
                r0.<init>(r1, r6, r2)
                goto L56
            L71:
                kotlin.Unit r2 = kotlin.Unit.INSTANCE
                goto L34
            L77:
                int r0 = r0 + r1
                goto L49
        }

        @Override // kotlin.jvm.functions.Function4
        public /* bridge */ /* synthetic */ java.lang.object invoke(androidx.paging.LoadStates r1, java.lang.object r2, androidx.paging.CombineSource r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
                r0 = this;
                goto Ld
            L4:
                kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
                goto L1f
            La:
                goto L10
            Ld:
                goto L1b
            L10:
                goto L14
            L14:
                androidx.paging.CombineSource r3 = (androidx.paging.CombineSource) r3
                goto L4
            L1a:
                return r0
            L1b:
                goto La
            L1f:
                java.lang.object r0 = r0.invoke(r1, r2, r3, r4)
                goto L1a
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r18) {
                r17 = this;
                goto L1bd
            L4:
                java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
                goto L7a
            La:
                androidx.paging.LoadStates r13 = r8.getSourceLoadStates()
                goto Lfa
            L12:
                kotlin.ResultKt.throwOnFailure(r18)
                goto L136
            L19:
                androidx.paging.PageEvent r4 = (androidx.paging.PageEvent) r4
            L1b:
                goto L1a8
            L1f:
                java.lang.object r2 = r0.L$0
                goto L1c4
            L25:
                if (r2 != 0) goto L2a
                goto L2f
            L2a:
                goto L1e8
            L2e:
                goto L1b
            L2f:
                goto L170
            L33:
                r0.<init>()
                goto L240
            L3a:
                androidx.paging.PageEvent$Insert r2 = androidx.paging.PageEvent.Insert.copy$default(r8, r9, r10, r11, r12, r13, r14, r15, r16)
                goto L151
            L42:
                r3 = 1
                goto L221
            L47:
                androidx.paging.PageEvent$LoadStateUpdate r4 = (androidx.paging.PageEvent.LoadStateUpdate) r4
                goto L1d2
            L4d:
                r16 = 0
                goto L234
            L53:
                r2.set(r5)
                goto L74
            L5a:
                r0 = 2
                goto L1ee
            L61:
                int r0 = r0 + r1
                goto L13c
            L67:
                androidx.paging.LoadState$NotLoading$Companion r8 = androidx.paging.LoadState.NotLoading.Companion
                goto L106
            L6d:
                r2.set(r4)
                goto La
            L74:
                androidx.paging.PageEvent$LoadStateUpdate r2 = new androidx.paging.PageEvent$LoadStateUpdate
                goto L251
            L7a:
                java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
                goto Lc0
            L80:
                androidx.paging.MutableLoadStateICollection r4 = r0.$sourceStates$inlined
                goto L1ca
            L86:
                r0.<init>(r1)
                goto L15f
            L8d:
                r14 = r2
                goto L19b
            L92:
                kotlin.Unit r0 = kotlin.Unit.INSTANCE
                goto L1f5
            L98:
                androidx.paging.PageEvent r4 = (androidx.paging.PageEvent) r4
                goto L8d
            L9e:
                goto L1a4
            La1:
                goto L127
            La5:
                r2.<init>(r4, r14)
                goto L122
            Lac:
                if (r0 <= 0) goto Lb1
                goto L1a4
            Lb1:
                goto L1a1
            Lb5:
                androidx.paging.PageEvent$Insert r8 = (androidx.paging.PageEvent.Insert) r8
                goto L10e
            Lbb:
                return r1
            Lbc:
                goto L92
            Lc0:
                r0.<init>(r1)
                goto L268
            Lc7:
                androidx.paging.MutableLoadStateICollection r2 = r0.$sourceStates$inlined
                goto L47
            Lcd:
                kotlin.ResultKt.throwOnFailure(r18)
                goto L1f
            Ld4:
                r12 = 0
                goto L3a
            Ld9:
                r8 = r4
                goto Lb5
            Lde:
                androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> r6 = r0.$$this$simpleChannelFlow
                goto L22a
            Le4:
                java.lang.object r0 = r6.send(r4, r7)
                goto L25f
            Lec:
                r5 = r4
                goto L1ae
            Lf1:
                if (r2 != 0) goto Lf6
                goto L1dc
            Lf6:
                goto L245
            Lfa:
                r15 = 15
                goto L4d
            L100:
                bool r2 = r4 is androidx.paging.PageEvent.LoadStateUpdate
                goto L1b4
            L106:
                androidx.paging.LoadState$NotLoading r8 = r8.getIncomplete$paging_common_release()
                goto L17f
            L10e:
                androidx.paging.LoadStates r4 = r8.getSourceLoadStates()
                goto L6d
            L116:
                androidx.paging.CombineSource r5 = (androidx.paging.CombineSource) r5
                goto Lde
            L11c:
                r0 = r17
                goto L1e0
            L122:
                r4 = r2
                goto L130
            L127:
                goto L1c0
            L12a:
                kotlin.coroutines.Continuation r7 = (kotlin.coroutines.Continuation) r7
                goto L98
            L130:
                androidx.paging.PageEvent r4 = (androidx.paging.PageEvent) r4
                goto L20f
            L136:
                goto Lbc
            L138:
                goto L4
            L13c:
                int r0 = r0 % r1
                goto Lac
            L142:
                r2.<init>(r4, r14)
                goto L190
            L149:
                androidx.paging.LoadType r5 = r5.getLoadType()
                goto L67
            L151:
                r4 = r2
                goto L18a
            L156:
                if (r2 == r3) goto L15b
                goto L138
            L15b:
                goto L12
            L15f:
                throw r0
            L160:
                goto L164
            L164:
                kotlin.NoWhenBranchMatchedException r0 = new kotlin.NoWhenBranchMatchedException
                goto L33
            L16a:
                bool r0 = r4 is androidx.paging.PageEvent.StaticList
                goto L176
            L170:
                bool r2 = r4 is androidx.paging.PageEvent.Drop
                goto Lf1
            L176:
                if (r0 != 0) goto L17b
                goto L160
            L17b:
                goto L21b
            L17f:
                androidx.paging.LoadState r8 = (androidx.paging.LoadState) r8
                goto L239
            L185:
                r10 = 0
                goto L22f
            L18a:
                androidx.paging.PageEvent r4 = (androidx.paging.PageEvent) r4
                goto L2e
            L190:
                r4 = r2
                goto L19
            L195:
                bool r2 = r4 is androidx.paging.PageEvent.Insert
                goto L25
            L19b:
                androidx.paging.LoadStates r14 = (androidx.paging.LoadStates) r14
                goto L259
            L1a1:
                goto L1f6
            L1a4:
                goto L11c
            L1a8:
                r0.label = r3
                goto Le4
            L1ae:
                androidx.paging.PageEvent$Drop r5 = (androidx.paging.PageEvent.Drop) r5
                goto L149
            L1b4:
                if (r2 != 0) goto L1b9
                goto L211
            L1b9:
                goto Lc7
            L1bd:
                goto La1
            L1c0:
                goto L5a
            L1c4:
                java.lang.object r4 = r0.L$1
                goto L203
            L1ca:
                androidx.paging.LoadStates r4 = r4.snapshot()
                goto L142
            L1d2:
                androidx.paging.LoadStates r5 = r4.getSource()
                goto L53
            L1da:
                goto L1b
            L1dc:
                goto L100
            L1e0:
                java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L215
            L1e8:
                androidx.paging.MutableLoadStateICollection r2 = r0.$sourceStates$inlined
                goto Ld9
            L1ee:
                r1 = 1
                goto L61
            L1f5:
                return r0
            L1f6:
                goto L9e
            L1fa:
                if (r5 != r2) goto L1ff
                goto L241
            L1ff:
                goto L195
            L203:
                java.lang.object r5 = r0.L$2
                goto L116
            L209:
                androidx.paging.PageEvent$LoadStateUpdate r2 = new androidx.paging.PageEvent$LoadStateUpdate
                goto L80
            L20f:
                goto L1b
            L211:
                goto L16a
            L215:
                int r2 = r0.label
                goto L42
            L21b:
                java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
                goto L24b
            L221:
                if (r2 != 0) goto L226
                goto L269
            L226:
                goto L156
            L22a:
                r7 = r0
                goto L12a
            L22f:
                r11 = 0
                goto Ld4
            L234:
                r9 = 0
                goto L185
            L239:
                r2.set(r5, r8)
                goto L1da
            L240:
                throw r0
            L241:
                goto L209
            L245:
                androidx.paging.MutableLoadStateICollection r2 = r0.$sourceStates$inlined
                goto Lec
            L24b:
                java.lang.string r1 = "Paging generated an event to display a static list that\n originated from a paginated source. If you see this\n exception, it is most likely a bug in the library.\n Please file a bug so we can fix it at:\n https://issuetracker.google.com/issues/new?component=413106"
                goto L86
            L251:
                androidx.paging.LoadStates r4 = r4.getSource()
                goto La5
            L259:
                androidx.paging.CombineSource r2 = androidx.paging.CombineSource.RECEIVER
                goto L1fa
            L25f:
                if (r0 == r1) goto L264
                goto Lbc
            L264:
                goto Lbb
            L268:
                throw r0
            L269:
                goto Lcd
        }
    }

    /* JADX INFO: renamed from: androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2, reason: invalid class name */
    @kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\u00020\u0005H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Lkotlinx/coroutines/CoroutineScope;", "androidx/paging/FlowExtKt$combineWithoutBatching$2$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
    @kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1", m533f = "FlowExt.kt", m534i = {}, m535l = {147}, m536m = "invokeSuspend", m537n = {}, m538s = {})
    public static readonly class AnonymousClass2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
        readonly /* synthetic */ androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> $$this$simpleChannelFlow;
        readonly /* synthetic */ kotlinx.coroutines.flow.Flow $flow;
        readonly /* synthetic */ java.util.concurrent.atomic.Atomicint $incompleteFlows;
        readonly /* synthetic */ int $index;
        readonly /* synthetic */ androidx.paging.UnbatchedFlowCombiner $unbatchedFlowCombiner;
        int label;

        /* JADX INFO: renamed from: androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1, reason: invalid class name */
        @kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u008a@¢\u0006\u0004\b\u0007\u0010\b¨\u0006\t"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "value", "", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "androidx/paging/FlowExtKt$combineWithoutBatching$2$1$1$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
        public static readonly class AnonymousClass1<T> : kotlinx.coroutines.flow.FlowCollector {
            readonly /* synthetic */ int $index;
            readonly /* synthetic */ androidx.paging.UnbatchedFlowCombiner $unbatchedFlowCombiner;

            /* JADX INFO: renamed from: androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1$1, reason: invalid class name and collision with other inner class name */
            @kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
            static readonly class C31801 : kotlin.coroutines.jvm.internal.ContinuationImpl {
                int label;
                /* synthetic */ java.lang.object result;
                readonly /* synthetic */ androidx.paging.C0730x6423e720.AnonymousClass2.AnonymousClass1 this$0;

                C31801(androidx.paging.C0730x6423e720.AnonymousClass2.AnonymousClass1 r1, kotlin.coroutines.Continuation r2) {
                        r0 = this;
                        goto La
                    L4:
                        r0.this$0 = r1
                        goto L11
                    La:
                        goto L19
                    Ld:
                        goto L4
                    L11:
                        r0.<init>(r2)
                        goto L18
                    L18:
                        return
                    L19:
                        goto L1d
                    L1d:
                        goto Ld
                }

                @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
                public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
                        r1 = this;
                        goto La
                    L4:
                        kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
                        goto L16
                    La:
                        goto L3f
                    Ld:
                        goto L1e
                    L11:
                        r2 = r2 | r0
                        goto L32
                    L16:
                        java.lang.object r1 = r2.emit(r0, r1)
                        goto L3e
                    L1e:
                        r1.result = r2
                        goto L24
                    L24:
                        int r2 = r1.label
                        goto L43
                    L2a:
                        goto Ld
                    L2d:
                        r0 = 0
                        goto L4
                    L32:
                        r1.label = r2
                        goto L38
                    L38:
                        androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1 r2 = r1.this$0
                        goto L2d
                    L3e:
                        return r1
                    L3f:
                        goto L2a
                    L43:
                        r0 = -2147483648(0xffffffff80000000, float:-0.0)
                        goto L11
                }
            }

            public AnonymousClass1(androidx.paging.UnbatchedFlowCombiner r1, int r2) {
                    r0 = this;
                    goto L9
                L4:
                    return
                L5:
                    goto L23
                L9:
                    goto L5
                Lc:
                    goto L10
                L10:
                    r0.$unbatchedFlowCombiner = r1
                    goto L16
                L16:
                    r0.$index = r2
                    goto L1c
                L1c:
                    r0.<init>()
                    goto L4
                L23:
                    goto Lc
            }

            @Override // kotlinx.coroutines.flow.FlowCollector
            public readonly java.lang.object Emit(java.lang.object r6, kotlin.coroutines.Continuation<kotlin.Unit> r7) {
                    r5 = this;
                    goto L11b
                L4:
                    if (r5 == r1) goto L9
                    goto Le
                L9:
                    goto Ld
                Ld:
                    return r1
                Le:
                    goto L12d
                L12:
                    androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1$1 r0 = (androidx.paging.C0730x6423e720.AnonymousClass2.AnonymousClass1.C31801) r0
                    goto L144
                L18:
                    int r7 = r7 - r2
                    goto L55
                L1d:
                    goto Lbf
                L20:
                    goto La0
                L24:
                    goto L108
                L26:
                    goto L2a
                L2a:
                    kotlin.ResultKt.throwOnFailure(r7)
                    goto Lfb
                L31:
                    r2 = -2147483648(0xffffffff80000000, float:-0.0)
                    goto L128
                L37:
                    java.lang.object r7 = r0.result
                    goto L13c
                L3d:
                    throw r5
                L3e:
                    goto L93
                L42:
                    if (r1 != 0) goto L47
                    goto Ld8
                L47:
                    goto L5b
                L4b:
                    r0 = r7
                    goto L12
                L50:
                    goto Le
                L51:
                    goto Lb2
                L55:
                    r0.label = r7
                    goto Ld7
                L5b:
                    int r7 = r0.label
                    goto L18
                L61:
                    java.lang.object r5 = kotlinx.coroutines.YieldKt.yield(r0)
                    goto L4
                L69:
                    if (r2 != 0) goto L6e
                    goto L26
                L6e:
                    goto L133
                L72:
                    r1 = 8
                    goto L81
                L79:
                    java.lang.object r5 = r7.onNext(r5, r6, r0)
                    goto La9
                L81:
                    int r0 = r0 + r1
                    goto L10c
                L87:
                    kotlin.ResultKt.throwOnFailure(r7)
                    goto L50
                L8e:
                    r3 = 2
                    goto L101
                L93:
                    kotlin.ResultKt.throwOnFailure(r7)
                    goto L24
                L9a:
                    androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1$1 r0 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1$1
                    goto Ld0
                La0:
                    bool r0 = r7 is androidx.paging.C0730x6423e720.AnonymousClass2.AnonymousClass1.C31801
                    goto L112
                La6:
                    goto L11e
                La9:
                    if (r5 == r1) goto Lae
                    goto L108
                Lae:
                    goto L106
                Lb2:
                    java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
                    goto L122
                Lb8:
                    r0.label = r3
                    goto L61
                Lbe:
                    return r5
                Lbf:
                    goto Lc3
                Lc3:
                    goto L20
                Lc6:
                    goto La6
                Lca:
                    int r2 = r0.label
                    goto L8e
                Ld0:
                    r0.<init>(r5, r7)
                Ld3:
                    goto L37
                Ld7:
                    goto Ld3
                Ld8:
                    goto L9a
                Ldc:
                    r0.label = r4
                    goto L79
                Le2:
                    r0 = 21
                    goto L72
                Le9:
                    if (r0 <= 0) goto Lee
                    goto L20
                Lee:
                    goto L1d
                Lf2:
                    if (r2 == r3) goto Lf7
                    goto L51
                Lf7:
                    goto L87
                Lfb:
                    androidx.paging.UnbatchedFlowCombiner r7 = r5.$unbatchedFlowCombiner
                    goto L14a
                L101:
                    r4 = 1
                    goto L69
                L106:
                    goto L9
                L108:
                    goto Lb8
                L10c:
                    int r0 = r0 % r1
                    goto Le9
                L112:
                    if (r0 != 0) goto L117
                    goto Ld8
                L117:
                    goto L4b
                L11b:
                    goto Lc6
                L11e:
                    goto Le2
                L122:
                    java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
                    goto L150
                L128:
                    r1 = r1 & r2
                    goto L42
                L12d:
                    kotlin.Unit r5 = kotlin.Unit.INSTANCE
                    goto Lbe
                L133:
                    if (r2 != r4) goto L138
                    goto L3e
                L138:
                    goto Lf2
                L13c:
                    java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                    goto Lca
                L144:
                    int r1 = r0.label
                    goto L31
                L14a:
                    int r5 = r5.$index
                    goto Ldc
                L150:
                    r5.<init>(r6)
                    goto L3d
            }
        }

        public AnonymousClass2(kotlinx.coroutines.flow.Flow r1, java.util.concurrent.atomic.Atomicint r2, androidx.paging.SimpleProducerScope r3, androidx.paging.UnbatchedFlowCombiner r4, int r5, kotlin.coroutines.Continuation r6) {
                r0 = this;
                goto L36
            L4:
                return
            L5:
                goto L21
            L9:
                r0.<init>(r1, r6)
                goto L4
            L10:
                r0.$unbatchedFlowCombiner = r4
                goto L30
            L16:
                r0.$incompleteFlows = r2
                goto L10
            L1c:
                r1 = 2
                goto L9
            L21:
                goto L39
            L24:
                r0.$$this$simpleChannelFlow = r3
                goto L1c
            L2a:
                r0.$flow = r1
                goto L16
            L30:
                r0.$index = r5
                goto L24
            L36:
                goto L5
            L39:
                goto L2a
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r8, kotlin.coroutines.Continuation<object> r9) {
                r7 = this;
                goto L11
            L4:
                r0.<init>(r1, r2, r3, r4, r5, r6)
                goto L46
            Lb:
                int r5 = r7.$index
                goto L1b
            L11:
                goto L42
            L14:
                goto L5e
            L18:
                goto L14
            L1b:
                r6 = r9
                goto L4
            L20:
                return r0
            L21:
                goto L3f
            L25:
                kotlinx.coroutines.flow.Flow r1 = r7.$flow
                goto L2b
            L2b:
                java.util.concurrent.atomic.Atomicint r2 = r7.$incompleteFlows
                goto L4c
            L31:
                goto L21
            L34:
                goto L52
            L38:
                r1 = 16
                goto L65
            L3f:
                goto L34
            L42:
                goto L18
            L46:
                kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
                goto L20
            L4c:
                androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> r3 = r7.$$this$simpleChannelFlow
                goto L74
            L52:
                androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2 r0 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2
                goto L25
            L58:
                int r0 = r0 % r1
                goto L6b
            L5e:
                r0 = 15
                goto L38
            L65:
                int r0 = r0 + r1
                goto L58
            L6b:
                if (r0 <= 0) goto L70
                goto L34
            L70:
                goto L31
            L74:
                androidx.paging.UnbatchedFlowCombiner r4 = r7.$unbatchedFlowCombiner
                goto Lb
        }

        @Override // kotlin.jvm.functions.Function2
        public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L18
            L4:
                java.lang.object r0 = r0.invoke2(r1, r2)
                goto L1f
            Lc:
                kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
                goto L4
            L12:
                kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
                goto Lc
            L18:
                goto L20
            L1b:
                goto L12
            L1f:
                return r0
            L20:
                goto L24
            L24:
                goto L1b
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
                r0 = this;
                goto L1f
            L4:
                java.lang.object r0 = r0.invokeSuspend(r1)
                goto Lc
            Lc:
                return r0
            Ld:
                goto L26
            L11:
                kotlin.Unit r1 = kotlin.Unit.INSTANCE
                goto L4
            L17:
                kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
                goto L29
            L1f:
                goto Ld
            L22:
                goto L17
            L26:
                goto L22
            L29:
                androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2 r0 = (androidx.paging.C0730x6423e720.AnonymousClass2) r0
                goto L11
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly java.lang.object InvokeSuspend(java.lang.object r7) {
                r6 = this;
                goto La
            L4:
                java.util.concurrent.atomic.Atomicint r0 = r6.$incompleteFlows
                goto L97
            La:
                goto L26
            Ld:
                goto L17
            L11:
                goto L2b
            L12:
                r7 = move-exception
                goto L92
            L17:
                r0 = 14
                goto L4e
            L1e:
                throw r7
            L1f:
                goto L23
            L23:
                goto L89
            L26:
                goto Lef
            L2a:
                return r0
            L2b:
                goto L35
            L2f:
                androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> r6 = r6.$$this$simpleChannelFlow
                goto L102
            L35:
                java.util.concurrent.atomic.Atomicint r7 = r6.$incompleteFlows
                goto L111
            L3b:
                kotlinx.coroutines.channels.SendChannel.DefaultImpls.close$default(r6, r2, r3, r2)
            L3e:
                goto L1e
            L42:
                androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> r6 = r6.$$this$simpleChannelFlow
                goto L80
            L48:
                int r0 = r0 + r1
                goto L7a
            L4e:
                r1 = 20
                goto L48
            L55:
                java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
                goto L62
            L5d:
                throw r6
            L5e:
                goto Lc6
            L62:
                int r1 = r6.label
                goto L75
            L68:
                java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
                goto Lf2
            L6e:
                kotlinx.coroutines.channels.SendChannel.DefaultImpls.close$default(r6, r2, r3, r2)
            L71:
                goto Le3
            L75:
                r2 = 0
                goto L119
            L7a:
                int r0 = r0 % r1
                goto Lf9
            L80:
                kotlinx.coroutines.channels.SendChannel r6 = (kotlinx.coroutines.channels.SendChannel) r6
                goto L3b
            L86:
                goto L1f
            L89:
                goto L55
            L8d:
                return r6
            L8e:
                goto L4
            L92:
                goto L8e
            L93:
                goto Le9
            L97:
                int r0 = r0.decrementAndGet()
                goto L108
            L9f:
                if (r1 == r3) goto La4
                goto L93
            La4:
                kotlin.ResultKt.throwOnFailure(r7)     // Catch: java.lang.Exception -> L12
                goto L11
            Lab:
                if (r1 != 0) goto Lb0
                goto L5e
            Lb0:
                goto L9f
            Lb4:
                if (r7 == 0) goto Lb9
                goto L71
            Lb9:
                goto L2f
            Lbd:
                if (r7 == r0) goto Lc2
                goto L2b
            Lc2:
                goto L2a
            Lc6:
                kotlin.ResultKt.throwOnFailure(r7)
                kotlinx.coroutines.flow.Flow r7 = r6.$flow     // Catch: java.lang.Exception -> L12
                androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1 r1 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2$1     // Catch: java.lang.Exception -> L12
                androidx.paging.UnbatchedFlowCombiner r4 = r6.$unbatchedFlowCombiner     // Catch: java.lang.Exception -> L12
                int r5 = r6.$index     // Catch: java.lang.Exception -> L12
                r1.<init>(r4, r5)     // Catch: java.lang.Exception -> L12
                kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1     // Catch: java.lang.Exception -> L12
                r4 = r6
                kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4     // Catch: java.lang.Exception -> L12
                r6.label = r3     // Catch: java.lang.Exception -> L12
                java.lang.object r7 = r7.collect(r1, r4)     // Catch: java.lang.Exception -> L12
                goto Lbd
            Le3:
                kotlin.Unit r6 = kotlin.Unit.INSTANCE
                goto L8d
            Le9:
                java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
                goto L68
            Lef:
                goto Ld
            Lf2:
                r6.<init>(r7)
                goto L5d
            Lf9:
                if (r0 <= 0) goto Lfe
                goto L89
            Lfe:
                goto L86
            L102:
                kotlinx.coroutines.channels.SendChannel r6 = (kotlinx.coroutines.channels.SendChannel) r6
                goto L6e
            L108:
                if (r0 == 0) goto L10d
                goto L3e
            L10d:
                goto L42
            L111:
                int r7 = r7.decrementAndGet()
                goto Lb4
            L119:
                r3 = 1
                goto Lab
        }
    }


    public C0730x6423e720(kotlinx.coroutines.flow.Flow r1, kotlinx.coroutines.flow.Flow r2, kotlin.coroutines.Continuation r3, androidx.paging.MutableLoadStateICollection r4) {
            r0 = this;
            goto L2a
        L4:
            r0.$sourceStates$inlined = r4
            goto La
        La:
            r1 = 2
            goto L1d
        Lf:
            r0.$otherFlow = r2
            goto L4
        L15:
            goto L2d
        L18:
            return
        L19:
            goto L15
        L1d:
            r0.<init>(r1, r3)
            goto L18
        L24:
            r0.$this_combineWithoutBatching = r1
            goto Lf
        L2a:
            goto L19
        L2d:
            goto L24
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r4, kotlin.coroutines.Continuation<object> r5) {
            r3 = this;
            goto L35
        L4:
            int r0 = r0 % r1
            goto L4f
        La:
            return r0
        Lb:
            goto L1b
        Lf:
            int r0 = r0 + r1
            goto L4
        L15:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto La
        L1b:
            goto L6b
        L1e:
            goto L5f
        L22:
            kotlinx.coroutines.flow.Flow r1 = r3.$this_combineWithoutBatching
            goto L42
        L28:
            r0.L$0 = r4
            goto L15
        L2e:
            r0.<init>(r1, r2, r5, r3)
            goto L28
        L35:
            goto L1e
        L38:
            goto L48
        L3c:
            androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1 r0 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1
            goto L22
        L42:
            kotlinx.coroutines.flow.Flow r2 = r3.$otherFlow
            goto L62
        L48:
            r0 = 21
            goto L58
        L4f:
            if (r0 <= 0) goto L54
            goto L6b
        L54:
            goto L68
        L58:
            r1 = 27
            goto Lf
        L5f:
            goto L38
        L62:
            androidx.paging.MutableLoadStateICollection r3 = r3.$sourceStates$inlined
            goto L2e
        L68:
            goto Lb
        L6b:
            goto L3c
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L28
        L4:
            goto L2b
        L7:
            androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1 r0 = (androidx.paging.C0730x6423e720) r0
            goto L22
        Ld:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L7
        L15:
            return r0
        L16:
            goto L4
        L1a:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L15
        L22:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L1a
        L28:
            goto L16
        L2b:
            goto Ld
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L20
        L4:
            goto L23
        L7:
            return r0
        L8:
            goto L4
        Lc:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L18
        L12:
            androidx.paging.SimpleProducerScope r1 = (androidx.paging.SimpleProducerScope) r1
            goto Lc
        L18:
            java.lang.object r0 = r0.invoke(r1, r2)
            goto L7
        L20:
            goto L8
        L23:
            goto L12
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r22) {
            r21 = this;
            goto L18f
        L4:
            goto L192
        L7:
            androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$1 r4 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$1
            goto L7f
        Ld:
            androidx.paging.SimpleProducerScope r7 = (androidx.paging.SimpleProducerScope) r7
            goto L13d
        L13:
            kotlin.jvm.functions.Function4 r4 = (kotlin.jvm.functions.Function4) r4
            goto Laa
        L19:
            r4 = r0
            goto Ld7
        L1e:
            r15 = r7
            goto L16c
        L23:
            goto L70
        L24:
            goto Ldd
        L28:
            goto L119
        L2b:
            goto L4
        L2f:
            r0 = r21
            goto L1b8
        L35:
            r20 = 0
            goto L166
        L3b:
            r12[r5] = r4
            goto Led
        L41:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE
            goto Le3
        L47:
            androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2 r4 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$2
            goto L14f
        L4d:
            r7 = r2
            goto Ld
        L52:
            r0.<init>(r1)
            goto Le8
        L59:
            r0 = 32
            goto L129
        L60:
            if (r2 == r3) goto L65
            goto L24
        L65:
            goto L196
        L69:
            r5 = r12[r13]
            goto L160
        L6f:
            return r1
        L70:
            goto L41
        L74:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L52
        L7a:
            r9 = r14
            goto L123
        L7f:
            androidx.paging.MutableLoadStateICollection r5 = r0.$sourceStates$inlined
            goto L19d
        L85:
            kotlin.coroutines.Coroutineobject r16 = (kotlin.coroutines.Coroutineobject) r16
            goto L47
        L8b:
            r9 = r5
            goto L1c0
        L90:
            r5 = 0
            goto L3b
        L95:
            r16 = r11
            goto L85
        L9b:
            java.lang.object r0 = r7.awaitClose(r2, r4)
            goto Lce
        La3:
            r6.<init>(r2)
            goto L1ab
        Laa:
            r8.<init>(r4)
            goto Lba
        Lb1:
            if (r2 != 0) goto Lb6
            goto Le9
        Lb6:
            goto L60
        Lba:
            kotlinx.coroutines.CompletableJob r11 = kotlinx.coroutines.JobKt.Job$default(r9, r3, r9)
            goto Lf3
        Lc2:
            r19 = 2
            goto L35
        Lc8:
            kotlin.jvm.functions.Function0 r2 = (kotlin.jvm.functions.Function0) r2
            goto L19
        Lce:
            if (r0 == r1) goto Ld3
            goto L70
        Ld3:
            goto L6f
        Ld7:
            kotlin.coroutines.Continuation r4 = (kotlin.coroutines.Continuation) r4
            goto L154
        Ldd:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L74
        Le3:
            return r0
        Le4:
            goto L28
        Le8:
            throw r0
        Le9:
            goto L188
        Led:
            kotlinx.coroutines.flow.Flow r4 = r0.$otherFlow
            goto L1c5
        Lf3:
            kotlinx.coroutines.flow.Flow[] r12 = new kotlinx.coroutines.flow.Flow[r2]
            goto L130
        Lf9:
            kotlin.jvm.functions.Function2 r18 = (kotlin.jvm.functions.Function2) r18
            goto Lc2
        Lff:
            r3 = 1
            goto Lb1
        L104:
            int r13 = r13 + 1
            goto L7a
        L10a:
            r2 = 2
            goto La3
        L10f:
            r4.<init>(r7, r9, r5)
            goto L13
        L116:
            goto Le4
        L119:
            goto L2f
        L11d:
            int r0 = r0 % r1
            goto L178
        L123:
            goto L1c1
        L125:
            goto L15a
        L129:
            r1 = 20
            goto L1cb
        L130:
            kotlinx.coroutines.flow.Flow r4 = r0.$this_combineWithoutBatching
            goto L90
        L136:
            kotlinx.coroutines.BuildersKt.launch$default(r15, r16, r17, r18, r19, r20)
            goto L104
        L13d:
            java.util.concurrent.atomic.Atomicint r6 = new java.util.concurrent.atomic.Atomicint
            goto L10a
        L143:
            r18 = r4
            goto Lf9
        L149:
            java.lang.object r2 = r0.L$0
            goto L4d
        L14f:
            r10 = 0
            goto L181
        L154:
            r0.label = r3
            goto L9b
        L15a:
            androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$3 r2 = new androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1$3
            goto L1b1
        L160:
            int r14 = r9 + 1
            goto L1e
        L166:
            r17 = 0
            goto L136
        L16c:
            kotlinx.coroutines.CoroutineScope r15 = (kotlinx.coroutines.CoroutineScope) r15
            goto L95
        L172:
            int r2 = r0.label
            goto Lff
        L178:
            if (r0 <= 0) goto L17d
            goto L119
        L17d:
            goto L116
        L181:
            r4.<init>(r5, r6, r7, r8, r9, r10)
            goto L143
        L188:
            kotlin.ResultKt.throwOnFailure(r22)
            goto L149
        L18f:
            goto L2b
        L192:
            goto L59
        L196:
            kotlin.ResultKt.throwOnFailure(r22)
            goto L23
        L19d:
            r9 = 0
            goto L10f
        L1a2:
            if (r13 < r2) goto L1a7
            goto L125
        L1a7:
            goto L69
        L1ab:
            androidx.paging.UnbatchedFlowCombiner r8 = new androidx.paging.UnbatchedFlowCombiner
            goto L7
        L1b1:
            r2.<init>(r11)
            goto Lc8
        L1b8:
            java.lang.object r1 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L172
        L1c0:
            r13 = r9
        L1c1:
            goto L1a2
        L1c5:
            r12[r3] = r4
            goto L8b
        L1cb:
            int r0 = r0 + r1
            goto L11d
    }
}

