namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.ListenableTaskKt$launchTask$1$2", m533f = "ListenableTask.kt", m534i = {}, m535l = {42}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ListenableTaskKt$launchTask$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> $block;
    readonly /* synthetic */ androidx.concurrent.futures.CallbackToTaskAdapter.Completer<T> $completer;
    private /* synthetic */ java.lang.object L$0;
    int label;

    ListenableTaskKt$launchTask$1$2(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> r1, androidx.concurrent.futures.CallbackToTaskAdapter.Completer<T> r2, kotlin.coroutines.Continuation<? super androidx.work.ListenableTaskKt$launchTask$1$2> r3) {
            r0 = this;
            goto La
        L4:
            r0.$completer = r2
            goto L26
        La:
            goto L15
        Ld:
            goto L19
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            r0.$block = r1
            goto L4
        L1f:
            r0.<init>(r1, r3)
            goto L14
        L26:
            r1 = 2
            goto L1f
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r3, kotlin.coroutines.Continuation<object> r4) {
            r2 = this;
            goto L11
        L4:
            r1 = 13
            goto L5d
        Lb:
            androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> r2 = r2.$completer
            goto L18
        L11:
            goto L2b
        L14:
            goto L3b
        L18:
            r0.<init>(r1, r2, r4)
            goto L63
        L1f:
            goto L14
        L22:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L36
        L28:
            goto L32
        L2b:
            goto L1f
        L2f:
            goto L37
        L32:
            goto L4b
        L36:
            return r0
        L37:
            goto L28
        L3b:
            r0 = 27
            goto L4
        L42:
            if (r0 <= 0) goto L47
            goto L32
        L47:
            goto L2f
        L4b:
            androidx.work.ListenableTaskKt$launchTask$1$2 r0 = new androidx.work.ListenableTaskKt$launchTask$1$2
            goto L51
        L51:
            kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> r1 = r2.$block
            goto Lb
        L57:
            int r0 = r0 % r1
            goto L42
        L5d:
            int r0 = r0 + r1
            goto L57
        L63:
            r0.L$0 = r3
            goto L22
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto L19
        Lb:
            goto L7
        Le:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1f
        L14:
            return r0
        L15:
            goto Lb
        L19:
            kotlinx.coroutines.CoroutineScope r1 = (kotlinx.coroutines.CoroutineScope) r1
            goto Le
        L1f:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto L14
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L27
        Lb:
            return r0
        Lc:
            goto L1e
        L10:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L16
        L16:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto Lb
        L1e:
            goto L7
        L21:
            androidx.work.ListenableTaskKt$launchTask$1$2 r0 = (androidx.work.ListenableTaskKt$launchTask$1$2) r0
            goto L10
        L27:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L21
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r4) {
            r3 = this;
            goto Lb4
        L4:
            int r0 = r0 % r1
            goto L6c
        La:
            goto Lc8
        Lc:
            r4 = move-exception
            goto Lae
        L11:
            goto Ldb
        L13:
            goto L5f
        L17:
            kotlin.ResultKt.throwOnFailure(r4)
            goto L2f
        L1e:
            throw r3
        L1f:
            goto L17
        L23:
            int r0 = r0 + r1
            goto L4
        L29:
            java.lang.string r4 = "call to 'resume' before 'invoke' with coroutine"
            goto L3c
        L2f:
            java.lang.object r4 = r3.L$0
            goto Lbb
        L35:
            goto Ld4
        L38:
            goto L75
        L3c:
            r3.<init>(r4)
            goto L1e
        L43:
            java.lang.IllegalStateException r3 = new java.lang.IllegalStateException
            goto L29
        L49:
            if (r1 != 0) goto L4e
            goto L1f
        L4e:
            goto L8b
        L52:
            kotlin.Unit r3 = kotlin.Unit.INSTANCE
            goto L7e
        L58:
            r1 = 29
            goto L23
        L5f:
            androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> r3 = r3.$completer
            goto La2
        L65:
            r0 = 12
            goto L58
        L6c:
            if (r0 <= 0) goto L71
            goto Ld4
        L71:
            goto Ld1
        L75:
            goto Lb7
        L78:
            int r1 = r3.label
            goto La9
        L7e:
            return r3
        L7f:
            goto L35
        L83:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L78
        L8b:
            if (r1 == r2) goto L90
            goto Lb0
        L90:
            kotlin.ResultKt.throwOnFailure(r4)     // Catch: java.lang.Exception -> Lc java.util.concurrent.CancellationException -> L98
            goto La
        L97:
            goto Ldb
        L98:
            goto L9c
        L9c:
            androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> r3 = r3.$completer
            goto Ld8
        La2:
            r3.setException(r4)
            goto L97
        La9:
            r2 = 1
            goto L49
        Lae:
            goto L13
        Lb0:
            goto L43
        Lb4:
            goto L38
        Lb7:
            goto L65
        Lbb:
            kotlinx.coroutines.CoroutineScope r4 = (kotlinx.coroutines.CoroutineScope) r4
            kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> r1 = r3.$block     // Catch: java.lang.Exception -> Lc java.util.concurrent.CancellationException -> L98
            r3.label = r2     // Catch: java.lang.Exception -> Lc java.util.concurrent.CancellationException -> L98
            java.lang.object r4 = r1.invoke(r4, r3)     // Catch: java.lang.Exception -> Lc java.util.concurrent.CancellationException -> L98
            if (r4 != r0) goto Lc8
            return r0
        Lc8:
            androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> r0 = r3.$completer     // Catch: java.lang.Exception -> Lc java.util.concurrent.CancellationException -> L98
            r0.set(r4)     // Catch: java.lang.Exception -> Lc java.util.concurrent.CancellationException -> L98
            goto L11
        Ld1:
            goto L7f
        Ld4:
            goto L83
        Ld8:
            r3.setCancelled()
        Ldb:
            goto L52
    }
}

