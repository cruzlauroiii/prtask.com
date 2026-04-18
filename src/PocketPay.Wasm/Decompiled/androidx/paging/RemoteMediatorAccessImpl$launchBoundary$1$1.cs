namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "Key", "", "Value"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1", m533f = "RemoteMediatorAccessor.kt", m534i = {0}, m535l = {393}, m536m = "invokeSuspend", m537n = {"loadType"}, m538s = {"L$0"})
readonly class RemoteMediatorAccessImpl$launchBoundary$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly androidx.paging.RemoteMediatorAccessImpl<Key, Value> this$0;

    RemoteMediatorAccessImpl$launchBoundary$1$1(androidx.paging.RemoteMediatorAccessImpl<Key, Value> remoteMediatorAccessImpl, kotlin.coroutines.Continuation<? super androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1> continuation) {
        super(1, continuation);
        this.this$0 = remoteMediatorAccessImpl;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1) create(continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions count limit reached at block B:81:0x0176
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r6) {
        /*
            Method dump skipped, instruction units count: 429
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.RemoteMediatorAccessImpl$launchBoundary$1$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

