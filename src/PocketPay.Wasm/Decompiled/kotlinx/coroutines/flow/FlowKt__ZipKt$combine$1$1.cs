namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u00052\u000e\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\b0\u0007H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it", "", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__ZipKt$combine$1$1", m533f = "Zip.kt", m534i = {}, m535l = {33, 33}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class FlowKt__ZipKt$combine$1$1<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, java.lang.object[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly /* synthetic */ kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    private /* synthetic */ java.lang.object L$0;
    /* synthetic */ java.lang.object L$1;
    int label;

    FlowKt__ZipKt$combine$1$1(kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> r1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__ZipKt$combine$1$1> r2) {
            r0 = this;
            goto L11
        L4:
            goto L14
        L7:
            return
        L8:
            goto L4
        Lc:
            r1 = 3
            goto L18
        L11:
            goto L8
        L14:
            goto L1f
        L18:
            r0.<init>(r1, r2)
            goto L7
        L1f:
            r0.$transform = r1
            goto Lc
    }

    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ java.lang.object invoke(java.lang.object r1, java.lang.object[] r2, kotlin.coroutines.Continuation<kotlin.Unit> r3) {
            r0 = this;
            goto L15
        L4:
            java.lang.object[] r2 = (java.lang.object[]) r2
            goto Lf
        La:
            return r0
        Lb:
            goto L1c
        Lf:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L1f
        L15:
            goto Lb
        L18:
            goto L27
        L1c:
            goto L18
        L1f:
            java.lang.object r0 = r0.invoke(r1, r2, r3)
            goto La
        L27:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L4
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> r2, java.lang.object[] r3, kotlin.coroutines.Continuation<kotlin.Unit> r4) {
            r1 = this;
            goto La
        L4:
            kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> r1 = r1.$transform
            goto L33
        La:
            goto L27
        Ld:
            goto L1d
        L11:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L2b
        L17:
            r0.L$1 = r3
            goto L11
        L1d:
            kotlinx.coroutines.flow.FlowKt__ZipKt$combine$1$1 r0 = new kotlinx.coroutines.flow.FlowKt__ZipKt$combine$1$1
            goto L4
        L23:
            goto Ld
        L26:
            return r1
        L27:
            goto L23
        L2b:
            java.lang.object r1 = r0.invokeSuspend(r1)
            goto L26
        L33:
            r0.<init>(r1, r4)
            goto L3a
        L3a:
            r0.L$0 = r2
            goto L17
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r7) {
            r6 = this;
            goto L101
        L4:
            return r6
        L5:
            goto Lf
        L9:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE
            goto L4
        Lf:
            goto Lb7
        L12:
            goto L93
        L16:
            r6.L$0 = r1
            goto L123
        L1c:
            java.lang.object r6 = r1.emit(r7, r3)
            goto Ld8
        L24:
            r3 = r6
            goto Lf5
        L29:
            if (r1 != r3) goto L2e
            goto L33
        L2e:
            goto L140
        L32:
            throw r6
        L33:
            goto Lc1
        L37:
            r6.<init>(r7)
            goto L32
        L3e:
            r4 = 0
            goto L50
        L43:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L4a
        L4a:
            java.lang.object r7 = r6.L$0
            goto Lc7
        L50:
            r6.L$0 = r4
            goto Le1
        L56:
            r1 = 31
            goto Lbb
        L5d:
            return r0
        L5e:
            goto L9
        L62:
            if (r7 == r0) goto L67
            goto L109
        L67:
            goto L108
        L6b:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L13b
        L72:
            java.lang.object r7 = r6.L$1
            goto L7e
        L78:
            kotlin.jvm.functions.Function3<T1, T2, kotlin.coroutines.Continuation<R>, java.lang.object> r4 = r6.$transform
            goto L112
        L7e:
            java.lang.object[] r7 = (java.lang.object[]) r7
            goto L78
        L84:
            kotlin.ResultKt.throwOnFailure(r7)
            goto L117
        L8b:
            java.lang.object r7 = r4.invoke(r5, r7, r6)
            goto L62
        L93:
            goto L104
        L96:
            if (r0 <= 0) goto L9b
            goto Lb7
        L9b:
            goto Lb4
        L9f:
            int r1 = r6.label
            goto L10d
        La5:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L9f
        Lad:
            r0 = 3
            goto L56
        Lb4:
            goto L5
        Lb7:
            goto La5
        Lbb:
            int r0 = r0 + r1
            goto Ld2
        Lc1:
            java.lang.object r1 = r6.L$0
            goto Lcc
        Lc7:
            r1 = r7
            goto L11d
        Lcc:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L6b
        Ld2:
            int r0 = r0 % r1
            goto L96
        Ld8:
            if (r6 == r0) goto Ldd
            goto L5e
        Ldd:
            goto L5d
        Le1:
            r6.label = r2
            goto L1c
        Le7:
            r3 = 1
            goto Lec
        Lec:
            if (r1 != 0) goto Lf1
            goto L13c
        Lf1:
            goto L29
        Lf5:
            kotlin.coroutines.Continuation r3 = (kotlin.coroutines.Continuation) r3
            goto L3e
        Lfb:
            r5 = r7[r5]
            goto L12f
        L101:
            goto L12
        L104:
            goto Lad
        L108:
            goto Ldd
        L109:
            goto L24
        L10d:
            r2 = 2
            goto Le7
        L112:
            r5 = 0
            goto Lfb
        L117:
            goto L5e
        L119:
            goto L129
        L11d:
            kotlinx.coroutines.flow.FlowCollector r1 = (kotlinx.coroutines.flow.FlowCollector) r1
            goto L72
        L123:
            r6.label = r3
            goto L8b
        L129:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L135
        L12f:
            r7 = r7[r3]
            goto L16
        L135:
            java.lang.string r7 = "call to 'resume' before 'invoke' with coroutine"
            goto L37
        L13b:
            goto L109
        L13c:
            goto L43
        L140:
            if (r1 == r2) goto L145
            goto L119
        L145:
            goto L84
    }
}

