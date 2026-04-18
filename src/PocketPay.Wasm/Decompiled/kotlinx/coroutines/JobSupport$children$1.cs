namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002H\u008a@"}, d2 = {"<anonymous>", "", "Lkotlin/sequences/SequenceScope;", "Lkotlinx/coroutines/Job;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.JobSupport$children$1", m533f = "JobSupport.kt", m534i = {1, 1, 1}, m535l = {956, 958}, m536m = "invokeSuspend", m537n = {"$this$sequence", "this_$iv", "cur$iv"}, m538s = {"L$0", "L$1", "L$2"})
readonly class JobSupport$children$1 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<kotlinx.coroutines.Job>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private /* synthetic */ java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;
    readonly /* synthetic */ kotlinx.coroutines.JobSupport this$0;

    JobSupport$children$1(kotlinx.coroutines.JobSupport r1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.JobSupport$children$1> r2) {
            r0 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L1a
        Lb:
            r1 = 2
            goto L10
        L10:
            r0.<init>(r1, r2)
            goto L20
        L17:
            goto L7
        L1a:
            r0.this$0 = r1
            goto Lb
        L20:
            return
        L21:
            goto L17
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object r2, kotlin.coroutines.Continuation<object> r3) {
            r1 = this;
            goto L1e
        L4:
            return r0
        L5:
            goto L15
        L9:
            kotlinx.coroutines.JobSupport r1 = r1.this$0
            goto L25
        Lf:
            kotlinx.coroutines.JobSupport$children$1 r0 = new kotlinx.coroutines.JobSupport$children$1
            goto L9
        L15:
            goto L21
        L18:
            kotlin.coroutines.Continuation r0 = (kotlin.coroutines.Continuation) r0
            goto L4
        L1e:
            goto L5
        L21:
            goto Lf
        L25:
            r0.<init>(r1, r3)
            goto L2c
        L2c:
            r0.L$0 = r2
            goto L18
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ java.lang.object invoke(kotlin.sequences.SequenceScope<kotlinx.coroutines.Job> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L18
        L4:
            kotlin.sequences.SequenceScope r1 = (kotlin.sequences.SequenceScope) r1
            goto L12
        La:
            goto L1b
        Ld:
            return r0
        Le:
            goto La
        L12:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1f
        L18:
            goto Le
        L1b:
            goto L4
        L1f:
            java.lang.object r0 = r0.invoke2(r1, r2)
            goto Ld
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<kotlinx.coroutines.Job> r1, kotlin.coroutines.Continuation<kotlin.Unit> r2) {
            r0 = this;
            goto L4
        L4:
            goto L2b
        L7:
            goto L17
        Lb:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE
            goto L22
        L11:
            kotlinx.coroutines.JobSupport$children$1 r0 = (kotlinx.coroutines.JobSupport$children$1) r0
            goto Lb
        L17:
            kotlin.coroutines.Continuation r0 = r0.create(r1, r2)
            goto L11
        L1f:
            goto L7
        L22:
            java.lang.object r0 = r0.invokeSuspend(r1)
            goto L2a
        L2a:
            return r0
        L2b:
            goto L1f
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r6) {
            r5 = this;
            goto Ld5
        L4:
            r1 = r4
            goto Lfa
        L9:
            r3 = 1
            goto L13a
        Le:
            goto L6b
        Lf:
            goto Ldc
        L13:
            r3 = r1
            goto L4
        L18:
            java.lang.object r4 = r5.L$0
            goto L76
        L1e:
            if (r3 != 0) goto L23
            goto L100
        L23:
            goto L35
        L27:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L1ed
        L2d:
            kotlinx.coroutines.NodeList r1 = r1.getList()
            goto L1ae
        L35:
            kotlinx.coroutines.Incomplete r1 = (kotlinx.coroutines.Incomplete) r1
            goto L2d
        L3b:
            goto L110
        L3e:
            goto L14a
        L42:
            kotlin.sequences.SequenceScope r6 = (kotlin.sequences.SequenceScope) r6
            goto L84
        L48:
            kotlinx.coroutines.ChildJob r1 = r1.childJob
            goto L7c
        L4e:
            kotlinx.coroutines.internal.LockFreeListNode r3 = (kotlinx.coroutines.internal.LockFreeListNode) r3
            goto L8a
        L54:
            java.lang.object r3 = r5.L$1
            goto L60
        L5a:
            java.lang.string r6 = "call to 'resume' before 'invoke' with coroutine"
            goto Lc1
        L60:
            kotlinx.coroutines.internal.LockFreeListHead r3 = (kotlinx.coroutines.internal.LockFreeListHead) r3
            goto L18
        L66:
            if (r6 == r0) goto L6b
            goto L10b
        L6b:
            goto L10a
        L6f:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r3, r4)
            goto L4e
        L76:
            kotlin.sequences.SequenceScope r4 = (kotlin.sequences.SequenceScope) r4
            goto Lc8
        L7c:
            r2 = r5
            goto L27
        L81:
            goto Ld8
        L84:
            kotlinx.coroutines.JobSupport r1 = r5.this$0
            goto L190
        L8a:
            r4 = r3
            goto L13
        L8f:
            java.lang.object r6 = r4.yield(r6, r5)
            goto L66
        L97:
            r6 = r1
            goto L1d8
        L9c:
            r5.L$1 = r3
            goto L176
        La2:
            kotlinx.coroutines.internal.LockFreeListNode r1 = (kotlinx.coroutines.internal.LockFreeListNode) r1
            goto L54
        La8:
            goto L10b
        La9:
            goto L104
        Lad:
            java.lang.object r6 = r5.L$0
            goto L42
        Lb3:
            kotlinx.coroutines.internal.LockFreeListNode r1 = r1.getNextNode()
            goto Lff
        Lbb:
            int r0 = r0 % r1
            goto L17c
        Lc1:
            r5.<init>(r6)
            goto L185
        Lc8:
            kotlin.ResultKt.throwOnFailure(r6)
            goto La8
        Lcf:
            int r1 = r5.label
            goto L129
        Ld5:
            goto L19b
        Ld8:
            goto L162
        Ldc:
            bool r3 = r1 is kotlinx.coroutines.Incomplete
            goto L1e
        Le2:
            r5.L$0 = r4
            goto L9c
        Le8:
            if (r4 != 0) goto Led
            goto Lf
        Led:
            goto L1b7
        Lf1:
            if (r1 == r2) goto Lf6
            goto La9
        Lf6:
            goto L1a8
        Lfa:
            r4 = r6
        Lfb:
            goto L15a
        Lff:
            goto Lfb
        L100:
            goto L1bd
        L104:
            java.lang.IllegalStateException r5 = new java.lang.IllegalStateException
            goto L5a
        L10a:
            return r0
        L10b:
            goto Lb3
        L10f:
            return r5
        L110:
            goto L198
        L114:
            bool r4 = r1 is kotlinx.coroutines.ChildHandleNode
            goto Le8
        L11a:
            java.lang.object r3 = r1.getNext()
            goto L12e
        L122:
            r1 = 25
            goto L1d2
        L129:
            r2 = 2
            goto L9
        L12e:
            java.lang.string r4 = "null cannot be cast to non-null type kotlinx.coroutines.internal.LockFreeListNode{ kotlinx.coroutines.internal.LockFreeListKt.Node }"
            goto L6f
        L134:
            kotlinx.coroutines.internal.LockFreeListHead r1 = (kotlinx.coroutines.internal.LockFreeListHead) r1
            goto L11a
        L13a:
            if (r1 != 0) goto L13f
            goto L18c
        L13f:
            goto L19f
        L143:
            kotlin.ResultKt.throwOnFailure(r6)
            goto L18a
        L14a:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto Lcf
        L152:
            java.lang.object r5 = r6.yield(r1, r2)
            goto L1e4
        L15a:
            bool r6 = kotlin.jvm.internal.Intrinsics.areEqual(r1, r3)
            goto L1f3
        L162:
            r0 = 14
            goto L122
        L169:
            r5.label = r2
            goto L8f
        L16f:
            kotlin.ResultKt.throwOnFailure(r6)
            goto Lad
        L176:
            r5.L$2 = r1
            goto L169
        L17c:
            if (r0 <= 0) goto L181
            goto L3e
        L181:
            goto L3b
        L185:
            throw r5
        L186:
            goto L143
        L18a:
            goto L100
        L18c:
            goto L16f
        L190:
            java.lang.object r1 = r1.getState$kotlinx_coroutines_core()
            goto L114
        L198:
            goto L3e
        L19b:
            goto L81
        L19f:
            if (r1 != r3) goto L1a4
            goto L186
        L1a4:
            goto Lf1
        L1a8:
            java.lang.object r1 = r5.L$2
            goto La2
        L1ae:
            if (r1 != 0) goto L1b3
            goto L100
        L1b3:
            goto L134
        L1b7:
            kotlinx.coroutines.ChildHandleNode r1 = (kotlinx.coroutines.ChildHandleNode) r1
            goto L48
        L1bd:
            kotlin.Unit r5 = kotlin.Unit.INSTANCE
            goto L10f
        L1c3:
            if (r6 != 0) goto L1c8
            goto L10b
        L1c8:
            goto L97
        L1cc:
            bool r6 = r1 is kotlinx.coroutines.ChildHandleNode
            goto L1c3
        L1d2:
            int r0 = r0 + r1
            goto Lbb
        L1d8:
            kotlinx.coroutines.ChildHandleNode r6 = (kotlinx.coroutines.ChildHandleNode) r6
            goto L1de
        L1de:
            kotlinx.coroutines.ChildJob r6 = r6.childJob
            goto Le2
        L1e4:
            if (r5 == r0) goto L1e9
            goto L100
        L1e9:
            goto Le
        L1ed:
            r5.label = r3
            goto L152
        L1f3:
            if (r6 == 0) goto L1f8
            goto L100
        L1f8:
            goto L1cc
    }
}

