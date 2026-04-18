namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "androidx/paging/FlowExtKt$simpleFlatDictionaryLatest$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1", m533f = "PageFetcherSnapshot.kt", m534i = {0, 0, 0}, m535l = {232, 98}, m536m = "invokeSuspend", m537n = {"this_$iv", "$this$withLock_u24default$iv$iv", "generationId"}, m538s = {"L$1", "L$2", "I$0"})
public readonly class C0732xe29ec4fd : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<androidx.paging.GenerationalobjectportHint>, java.lang.int, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ androidx.paging.LoadType $loadType$inlined;
    int I$0;
    private /* synthetic */ java.lang.object L$0;
    /* synthetic */ java.lang.object L$1;
    java.lang.object L$2;
    int label;
    readonly /* synthetic */ androidx.paging.PageFetcherSnapshot this$0;

    public C0732xe29ec4fd(kotlin.coroutines.Continuation r1, androidx.paging.PageFetcherSnapshot r2, androidx.paging.LoadType r3) {
            r0 = this;
            goto La
        L4:
            r0.$loadType$inlined = r3
            goto L14
        La:
            goto L27
        Ld:
            goto L20
        L11:
            goto Ld
        L14:
            r2 = 3
            goto L19
        L19:
            r0.<init>(r2, r1)
            goto L26
        L20:
            r0.this$0 = r2
            goto L4
        L26:
            return
        L27:
            goto L11
    }

    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.flow.FlowCollector<androidx.paging.GenerationalobjectportHint> r1, java.lang.int r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L21
        Ld:
            goto L1d
        L10:
            goto L7
        L14:
            java.lang.object r0 = r0.invoke(r1, r2, r3)
            goto L1c
        L1c:
            return r0
        L1d:
            goto L4
        L21:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L14
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.paging.GenerationalobjectportHint> r3, java.lang.int r4, kotlin.coroutines.Continuation<kotlin.Unit> r5) {
            r2 = this;
            goto L41
        L4:
            return r2
        L5:
            goto L1c
        L9:
            r0.L$0 = r3
            goto L5b
        Lf:
            r0 = 13
            goto L31
        L16:
            int r0 = r0 + r1
            goto L23
        L1c:
            goto L64
        L1f:
            goto L74
        L23:
            int r0 = r0 % r1
            goto L38
        L29:
            java.lang.object r2 = r0.invokeSuspend(r2)
            goto L4
        L31:
            r1 = 11
            goto L16
        L38:
            if (r0 <= 0) goto L3d
            goto L64
        L3d:
            goto L61
        L41:
            goto L1f
        L44:
            goto Lf
        L48:
            r0.<init>(r5, r1, r2)
            goto L9
        L4f:
            androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1 r0 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$$inlined$simpleFlatDictionaryLatest$1
            goto L55
        L55:
            androidx.paging.PageFetcherSnapshot r1 = r2.this$0
            goto L6e
        L5b:
            r0.L$1 = r4
            goto L68
        L61:
            goto L5
        L64:
            goto L4f
        L68:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L29
        L6e:
            androidx.paging.LoadType r2 = r2.$loadType$inlined
            goto L48
        L74:
            goto L44
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r11) {
            r10 = this;
            goto L195
        L4:
            if (r11 == r0) goto L9
            goto L114
        L9:
            goto L112
        Ld:
            androidx.paging.PageFetcherSnapshot r11 = r10.this$0
            goto L23d
        L13:
            java.lang.string r11 = "call to 'resume' before 'invoke' with coroutine"
            goto L1ca
        L19:
            androidx.paging.LoadType r5 = r10.$loadType$inlined
            goto L1ae
        L1f:
            throw r10
        L20:
            goto L8c
        L24:
            r10.L$1 = r6
            goto Lc8
        L2a:
            kotlin.ResultKt.throwOnFailure(r11)
            goto L1f3
        L31:
            goto L114
        L33:
            goto L2a
        L37:
            r3 = 1
            goto Lc3
        L3c:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L20b
        L42:
            r10.label = r3
            goto Ld1
        L48:
            r7 = r11
            goto Laf
        L4d:
            r5.unlock(r4)
            goto Ld
        L54:
            goto L18c
        L56:
            goto L14a
        L5a:
            java.lang.object r11 = r10.L$1
            goto Lf2
        L60:
            goto La2
        L61:
            androidx.paging.MutableLoadStateICollection r6 = r11.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadType r9 = r10.$loadType$inlined     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState r6 = r6[r9)     // Catch: java.lang.Exception -> Lb6
            bool r6 = r6 is androidx.paging.LoadState.Error     // Catch: java.lang.Exception -> Lb6
            if (r6 != 0) goto L80
            androidx.paging.MutableLoadStateICollection r11 = r11.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadType r6 = r10.$loadType$inlined     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState$NotLoading$Companion r9 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState$NotLoading r9 = r9.getIncomplete$paging_common_release()     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState r9 = (androidx.paging.LoadState) r9     // Catch: java.lang.Exception -> Lb6
            r11.set(r6, r9)     // Catch: java.lang.Exception -> Lb6
        L80:
            kotlin.Unit r11 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Lb6
            goto L4d
        L86:
            kotlinx.coroutines.sync.Mutex r5 = (kotlinx.coroutines.sync.Mutex) r5
            goto L205
        L8c:
            int r1 = r10.I$0
            goto L225
        L92:
            r1 = 5
            goto Lf7
        L99:
            r5.unlock(r4)
            goto L60
        La0:
            kotlinx.coroutines.flow.Flow r11 = (kotlinx.coroutines.flow.Flow) r11
        La2:
            goto L190
        La6:
            if (r10 == r0) goto Lab
            goto L18c
        Lab:
            goto L18b
        Laf:
            kotlinx.coroutines.flow.FlowCollector r7 = (kotlinx.coroutines.flow.FlowCollector) r7
            goto L5a
        Lb5:
            return r10
        Lb6:
            r10 = move-exception
            goto L1a7
        Lbb:
            int r1 = r11.intValue()
            goto L1ff
        Lc3:
            r4 = 0
            goto L21c
        Lc8:
            r10.L$2 = r5
            goto L1f9
        Lce:
            goto L198
        Ld1:
            java.lang.object r11 = r5.lock(r4, r10)
            goto L4
        Ld9:
            androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$lambda$5$$inlined$map$1 r3 = new androidx.paging.PageFetcherSnapshot$collectAsGenerationalobjectportHints$lambda$5$$inlined$map$1
            goto L10b
        Ldf:
            goto L1a3
        Le2:
            goto L142
        Le6:
            r11 = r3
            goto La0
        Leb:
            goto Le2
        Lee:
            goto Lce
        Lf2:
            r1 = r10
            goto L1e7
        Lf7:
            int r0 = r0 + r1
            goto L237
        Lfd:
            java.lang.object r7 = r10.L$0
            goto L1b6
        L103:
            kotlinx.coroutines.sync.Mutex r5 = androidx.paging.PageFetcherSnapshotState.Holder.access$getLock$p(r6)
            goto L19c
        L10b:
            r3.<init>(r11, r1)
            goto Le6
        L112:
            goto Lab
        L114:
            androidx.paging.PageFetcherSnapshotState r11 = androidx.paging.PageFetcherSnapshotState.Holder.access$getState$p(r6)     // Catch: java.lang.Exception -> Lb6
            androidx.paging.MutableLoadStateICollection r6 = r11.getSourceLoadStates$paging_common_release()     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadType r8 = r10.$loadType$inlined     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState r6 = r6[r8)     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState$NotLoading$Companion r8 = androidx.paging.LoadState.NotLoading.Companion     // Catch: java.lang.Exception -> Lb6
            androidx.paging.LoadState$NotLoading r8 = r8.getComplete$paging_common_release()     // Catch: java.lang.Exception -> Lb6
            bool r6 = kotlin.jvm.internal.Intrinsics.areEqual(r6, r8)     // Catch: java.lang.Exception -> Lb6
            r8 = 0
            if (r6 == 0) goto L61
            androidx.paging.GenerationalobjectportHint[] r11 = new androidx.paging.GenerationalobjectportHint[r8]     // Catch: java.lang.Exception -> Lb6
            kotlinx.coroutines.flow.Flow r11 = kotlinx.coroutines.flow.FlowKt.flowOf(r11)     // Catch: java.lang.Exception -> Lb6
            goto L99
        L139:
            if (r1 == 0) goto L13e
            goto L218
        L13e:
            goto L217
        L142:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L231
        L14a:
            java.lang.IllegalStateException r10 = new java.lang.IllegalStateException
            goto L13
        L150:
            androidx.paging.PageFetcherSnapshotState$Holder r6 = androidx.paging.PageFetcherSnapshot.access$getStateHolder$p(r11)
            goto L103
        L158:
            kotlin.ResultKt.throwOnFailure(r11)
            goto L31
        L15f:
            if (r1 == r2) goto L164
            goto L56
        L164:
            goto L1d7
        L168:
            androidx.paging.PageFetcherSnapshotState$Holder r6 = (androidx.paging.PageFetcherSnapshotState.Holder) r6
            goto Lfd
        L16e:
            r2 = 2
            goto L37
        L173:
            java.lang.object r10 = kotlinx.coroutines.flow.FlowKt.emitAll(r7, r11, r1)
            goto La6
        L17b:
            if (r0 <= 0) goto L180
            goto Le2
        L180:
            goto Ldf
        L184:
            r0 = 27
            goto L92
        L18b:
            return r0
        L18c:
            goto L1d1
        L190:
            r1 = r10
            goto L3c
        L195:
            goto Lee
        L198:
            goto L184
        L19c:
            r10.L$0 = r7
            goto L24
        L1a2:
            throw r10
        L1a3:
            goto Leb
        L1a7:
            r5.unlock(r4)
            goto L1a2
        L1ae:
            kotlinx.coroutines.flow.Flow r11 = r11.hintFor(r5)
            goto L139
        L1b6:
            kotlinx.coroutines.flow.FlowCollector r7 = (kotlinx.coroutines.flow.FlowCollector) r7
            goto L158
        L1bc:
            r10.label = r2
            goto L173
        L1c2:
            kotlinx.coroutines.flow.Flow r11 = kotlinx.coroutines.flow.FlowKt.drop(r11, r3)
            goto Ld9
        L1ca:
            r10.<init>(r11)
            goto L1f
        L1d1:
            kotlin.Unit r10 = kotlin.Unit.INSTANCE
            goto Lb5
        L1d7:
            kotlin.ResultKt.throwOnFailure(r11)
            goto L54
        L1de:
            if (r1 != r3) goto L1e3
            goto L20
        L1e3:
            goto L15f
        L1e7:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L22b
        L1ed:
            r10.L$1 = r4
            goto L211
        L1f3:
            java.lang.object r11 = r10.L$0
            goto L48
        L1f9:
            r10.I$0 = r1
            goto L42
        L1ff:
            androidx.paging.PageFetcherSnapshot r11 = r10.this$0
            goto L150
        L205:
            java.lang.object r6 = r10.L$1
            goto L168
        L20b:
            r10.L$0 = r4
            goto L1ed
        L211:
            r10.L$2 = r4
            goto L1bc
        L217:
            r3 = r8
        L218:
            goto L1c2
        L21c:
            if (r1 != 0) goto L221
            goto L33
        L221:
            goto L1de
        L225:
            java.lang.object r5 = r10.L$2
            goto L86
        L22b:
            java.lang.Number r11 = (java.lang.Number) r11
            goto Lbb
        L231:
            int r1 = r10.label
            goto L16e
        L237:
            int r0 = r0 % r1
            goto L17b
        L23d:
            androidx.paging.HintHandler r11 = androidx.paging.PageFetcherSnapshot.access$getHintHandler$p(r11)
            goto L19
    }
}

