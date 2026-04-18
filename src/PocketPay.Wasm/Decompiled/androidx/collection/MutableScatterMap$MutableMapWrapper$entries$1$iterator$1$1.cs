namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010'\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u00050\u0004H\u008a@"}, d2 = {"<anonymous>", "", "K", "V", "Lkotlin/sequences/SequenceScope;", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1", m533f = "ScatterDictionary.kt", m534i = {0, 0, 0, 0, 0, 0, 0}, m535l = {1328}, m536m = "invokeSuspend", m537n = {"$this$iterator", "m$iv", "lastIndex$iv", "i$iv", "slot$iv", "bitCount$iv", "j$iv"}, m538s = {"L$0", "L$3", "I$0", "I$1", "J$0", "I$2", "I$3"})
readonly class MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1<K, V> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<? super java.util.Dictionary$Entry<K, V>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int I$0;
    int I$1;
    int I$2;
    int I$3;
    long J$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    java.lang.object L$3;
    int label;
    readonly androidx.collection.MutableScatterDictionary<K, V> this$0;
    readonly androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1<K, V> this$1;

    MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1(androidx.collection.MutableScatterDictionary<K, V> mutableScatterDictionary, androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1<K, V> mutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1, kotlin.coroutines.Continuation<? super androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1> continuation) {
        super(2, continuation);
        this.this$0 = mutableScatterDictionary;
        this.this$1 = mutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((14 + 29) % 29 > 0) {
        }
        androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1 mutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1 = new androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1(this.this$0, this.this$1, continuation);
        mutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1.L$0 = obj;
        return mutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<? super java.util.Dictionary$Entry<K, V>> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r22) {
        /*
            Method dump skipped, instruction units count: 756
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.collection.MutableScatterDictionary$MutableDictionaryWrapper$entries$1$iterator$1$1.invokeSuspend(java.lang.object):java.lang.object");
    }
}

