namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R, T] */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0002*\u0002H\u0001\"\b\b\u0001\u0010\u0001*\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u0001H\u00022\b\u0010\u0005\u001a\u0004\u0018\u0001H\u0002H\u008a@"}, d2 = {"<anonymous>", "R", "T", "", "before", "after"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.SeparatorsKt$insertEventSeparators$separatorState$1", m533f = "Separators.kt", m534i = {}, m535l = {604}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SeparatorsKt$insertEventSeparators$separatorState$1<R, T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<R>, java.lang.object> {
    readonly /* synthetic */ kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<R>, java.lang.object> $generator;
    /* synthetic */ java.lang.object L$0;
    /* synthetic */ java.lang.object L$1;
    int label;

    SeparatorsKt$insertEventSeparators$separatorState$1(kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> r1, kotlin.coroutines.Continuation<? super androidx.paging.SeparatorsKt$insertEventSeparators$separatorState$1> r2) {
            r0 = this;
            goto L17
        L4:
            goto L1a
        L7:
            r0.$generator = r1
            goto Ld
        Ld:
            r1 = 3
            goto L1e
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L7
        L1e:
            r0.<init>(r1, r2)
            goto L12
    }

    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object r2, java.lang.object r3) {
            r0 = this;
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L19
        L12:
            goto L5
        L15:
            goto Lc
        L19:
            java.lang.object r0 = r0.invoke(r1, r2, r3)
            goto L4
    }

    public readonly java.lang.object Invoke(T r2, T r3, kotlin.coroutines.Continuation<R> r4) {
            r1 = this;
            goto L39
        L4:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L10
        La:
            androidx.paging.SeparatorsKt$insertEventSeparators$separatorState$1 r0 = new androidx.paging.SeparatorsKt$insertEventSeparators$separatorState$1
            goto L23
        L10:
            java.lang.object r1 = r0.invokeSuspend(r1)
            goto L1e
        L18:
            r0.L$0 = r2
            goto L33
        L1e:
            return r1
        L1f:
            goto L29
        L23:
            kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<R>, java.lang.object> r1 = r1.$generator
            goto L2c
        L29:
            goto L3c
        L2c:
            r0.<init>(r1, r4)
            goto L18
        L33:
            r0.L$1 = r3
            goto L4
        L39:
            goto L1f
        L3c:
            goto La
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
            r5 = this;
            goto L52
        L4:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L9c
        Lb:
            r5.<init>(r6)
            goto L78
        L12:
            return r5
        L13:
            goto L46
        L17:
            java.lang.object r1 = r5.L$1
            goto Lb1
        L1d:
            if (r1 != 0) goto L22
            goto L79
        L22:
            goto L88
        L26:
            return r6
        L27:
            goto L91
        L2b:
            r0 = 11
            goto Laa
        L32:
            java.lang.object r5 = r3.invoke(r6, r1, r5)
            goto L6f
        L3a:
            java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
            goto Lb
        L40:
            int r0 = r0 % r1
            goto L5f
        L46:
            goto Lc0
        L49:
            goto Lca
        L4d:
            return r0
        L4e:
            goto L12
        L52:
            goto L49
        L55:
            goto L2b
        L59:
            r5.label = r2
            goto L32
        L5f:
            if (r0 <= 0) goto L64
            goto Lc0
        L64:
            goto Lbd
        L68:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L26
        L6f:
            if (r5 == r0) goto L74
            goto L4e
        L74:
            goto L4d
        L78:
            throw r5
        L79:
            goto L4
        L7d:
            r2 = 1
            goto L1d
        L82:
            int r1 = r5.label
            goto L7d
        L88:
            if (r1 == r2) goto L8d
            goto L27
        L8d:
            goto L68
        L91:
            java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
            goto L3a
        L97:
            r4 = 0
            goto Lc4
        L9c:
            java.lang.object r6 = r5.L$0
            goto L17
        La2:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L82
        Laa:
            r1 = 23
            goto Lb7
        Lb1:
            kotlin.jvm.functions.Function3<T, T, kotlin.coroutines.Continuation<R>, java.lang.object> r3 = r5.$generator
            goto L97
        Lb7:
            int r0 = r0 + r1
            goto L40
        Lbd:
            goto L13
        Lc0:
            goto La2
        Lc4:
            r5.L$0 = r4
            goto L59
        Lca:
            goto L55
    }
}

