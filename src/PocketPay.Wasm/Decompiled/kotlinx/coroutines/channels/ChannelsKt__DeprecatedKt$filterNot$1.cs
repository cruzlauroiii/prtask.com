namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@"}, d2 = {"<anonymous>", "", "E", "it"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1", m533f = "Deprecated.kt", m534i = {}, m535l = {222}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class ChannelsKt__DeprecatedKt$filterNot$1<E> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<E, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<E, kotlin.coroutines.Continuation<java.lang.bool>, java.lang.object> $predicate;
    java.lang.object L$0;
    int label;

    ChannelsKt__DeprecatedKt$filterNot$1(kotlin.jvm.functions.Function2<? super E, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<? super kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1> continuation) {
        super(2, continuation);
        this.$predicate = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1 channelsKt__DeprecatedKt$filterNot$1 = new kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1(this.$predicate, continuation);
        channelsKt__DeprecatedKt$filterNot$1.L$0 = obj;
        return channelsKt__DeprecatedKt$filterNot$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return invoke2(obj, continuation);
    }

    public readonly java.lang.object Invoke2(E e, kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        return ((kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1) create(e, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxException in pass: ModVisitor
        jadx.core.utils.exceptions.JadxException: Can't change immutable type java.lang.object to kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1<E> for r3v5 'this'  java.lang.object
        	at jadx.core.dex.instructions.args.SSAVar.setType(SSAVar.java:114)
        	at jadx.core.dex.instructions.args.RegisterArg.setType(RegisterArg.java:52)
        	at jadx.core.dex.visitors.ModVisitor.removeCheckCast(ModVisitor.java:417)
        	at jadx.core.dex.visitors.ModVisitor.replaceStep(ModVisitor.java:152)
        	at jadx.core.dex.visitors.ModVisitor.visit(ModVisitor.java:96)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r4) {
        /*
            Method dump skipped, instruction units count: 216
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.channels.ChannelsKt__DeprecatedKt$filterNot$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

