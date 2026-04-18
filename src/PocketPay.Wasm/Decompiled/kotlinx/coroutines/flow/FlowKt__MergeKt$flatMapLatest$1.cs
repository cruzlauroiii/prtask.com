namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1", m533f = "Merge.kt", m534i = {}, m535l = {193, 193}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowKt__MergeKt$flatDictionaryLatest$1<R, T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, java.lang.object> $transform;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    public FlowKt__MergeKt$flatDictionaryLatest$1(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1> continuation) {
        super(3, continuation);
        this.$transform = function2;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, obj2, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1 flowKt__MergeKt$flatDictionaryLatest$1 = new kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1(this.$transform, continuation);
        flowKt__MergeKt$flatDictionaryLatest$1.L$0 = flowCollector;
        flowKt__MergeKt$flatDictionaryLatest$1.L$1 = t;
        return flowKt__MergeKt$flatDictionaryLatest$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1<R, T> for r5v4 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r6) {
        /*
            Method dump skipped, instruction units count: 313
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1.invokeSuspend(java.lang.object):java.lang.object");
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1<R, T> for r2v3 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public readonly java.lang.object invokeSuspend$$forInline(java.lang.object r3) {
        /*
            r2 = this;
            goto La
        L4:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L4a
        La:
            goto L20
        Ld:
            goto L37
        L11:
            java.lang.object r3 = r2.L$0
            goto L3e
        L17:
            kotlinx.coroutines.flow.Flow r0 = (kotlinx.coroutines.flow.Flow) r0
            goto L4
        L1d:
            goto L73
        L20:
            goto L57
        L24:
            r1 = 25
            goto L51
        L2b:
            java.lang.object r0 = r2.L$1
            goto L77
        L31:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L62
        L37:
            r0 = 32
            goto L24
        L3e:
            kotlinx.coroutines.flow.FlowCollector r3 = (kotlinx.coroutines.flow.FlowCollector) r3
            goto L2b
        L44:
            int r0 = r0 % r1
            goto L67
        L4a:
            kotlinx.coroutines.flow.FlowKt.emitAll(r3, r0, r2)
            goto L31
        L51:
            int r0 = r0 + r1
            goto L44
        L57:
            goto Ld
        L5a:
            java.lang.object r0 = r1.invoke(r0, r2)
            goto L17
        L62:
            return r2
        L63:
            goto L1d
        L67:
            if (r0 <= 0) goto L6c
            goto L73
        L6c:
            goto L70
        L70:
            goto L63
        L73:
            goto L11
        L77:
            kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, java.lang.object> r1 = r2.$transform
            goto L5a
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.flow.FlowKt__MergeKt$flatDictionaryLatest$1.invokeSuspend$$forInline(java.lang.object):java.lang.object");
    }
}

