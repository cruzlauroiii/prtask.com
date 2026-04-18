namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u00020\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$values$1$iterator$1$iterator$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {1511}, m536m = "invokeSuspend", m537n = {"$this$iterator", "m$iv", "lastIndex$iv", "i$iv", "slot$iv", "bitCount$iv", "j$iv"}, m538s = {"L$0", "L$1", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class C0019x9ca97416 : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<java.lang.int>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;
    readonly androidx.collection.MutableScatterDictionary<K, V> this$0;

    C0019x9ca97416(androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary, kotlin.coroutines.Continuation<androidx.collection.C0019x9ca97416> continuation) {
        super(2, continuation);
        this.this$0 = mutableScatterDictionary;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.collection.C0019x9ca97416 c0019x9ca97416 = new androidx.collection.C0019x9ca97416(this.this$0, continuation);
        c0019x9ca97416.L$0 = obj;
        return c0019x9ca97416;
    }

    public override java.lang.object Invoke(kotlin.sequences.SequenceScope<java.lang.int> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(sequenceScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.sequences.SequenceScope<java.lang.int> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.collection.C0019x9ca97416) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r20) {
        /*
            Method dump skipped, instruction units count: 600
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.collection.C0019x9ca97416.invokeSuspend(java.lang.object):java.lang.object");
    }
}

