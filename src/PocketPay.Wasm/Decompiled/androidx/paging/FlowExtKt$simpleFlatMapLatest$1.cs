namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u00042\u0006\u0010\u0005\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1", m533f = "FlowExt.kt", m534i = {}, m535l = {98, 98}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowExtKt$simpleFlatDictionaryLatest$1<R, T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, java.lang.object> $transform;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    public FlowExtKt$simpleFlatDictionaryLatest$1(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1> continuation) {
        super(3, continuation);
        this.$transform = function2;
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.flow.FlowCollector) obj, obj2, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<R> flowCollector, T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1 flowExtKt$simpleFlatDictionaryLatest$1 = new androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1(this.$transform, continuation);
        flowExtKt$simpleFlatDictionaryLatest$1.L$0 = flowCollector;
        flowExtKt$simpleFlatDictionaryLatest$1.L$1 = t;
        return flowExtKt$simpleFlatDictionaryLatest$1.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1<R, T> for r5v4 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r6) {
        /*
            Method dump skipped, instruction units count: 314
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1.invokeSuspend(java.lang.object):java.lang.object");
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1<R, T> for r2v3 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public readonly java.lang.object invokeSuspend$$forInline(java.lang.object r3) {
        /*
            r2 = this;
            goto L3a
        L4:
            kotlinx.coroutines.flow.Flow r0 = (kotlinx.coroutines.flow.Flow) r0
            goto L63
        La:
            r1 = 3
            goto L2b
        L11:
            kotlinx.coroutines.flow.FlowCollector r3 = (kotlinx.coroutines.flow.FlowCollector) r3
            goto L41
        L17:
            java.lang.object r3 = r2.L$0
            goto L11
        L1d:
            goto L71
        L20:
            goto L37
        L24:
            r0 = 4
            goto La
        L2b:
            int r0 = r0 + r1
            goto L31
        L31:
            int r0 = r0 % r1
            goto L4d
        L37:
            goto L3d
        L3a:
            goto L20
        L3d:
            goto L24
        L41:
            java.lang.object r0 = r2.L$1
            goto L5d
        L47:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto L69
        L4d:
            if (r0 <= 0) goto L52
            goto L71
        L52:
            goto L6e
        L56:
            kotlinx.coroutines.flow.FlowKt.emitAll(r3, r0, r2)
            goto L47
        L5d:
            kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, java.lang.object> r1 = r2.$transform
            goto L75
        L63:
            kotlin.coroutines.Continuation r2 = (kotlin.coroutines.Continuation) r2
            goto L56
        L69:
            return r2
        L6a:
            goto L1d
        L6e:
            goto L6a
        L71:
            goto L17
        L75:
            java.lang.object r0 = r1.invoke(r0, r2)
            goto L4
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.FlowExtKt$simpleFlatDictionaryLatest$1.invokeSuspend$$forInline(java.lang.object):java.lang.object");
    }
}

