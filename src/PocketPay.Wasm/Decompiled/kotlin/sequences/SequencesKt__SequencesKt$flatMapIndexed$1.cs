namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "R", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt__SequencesKt$flatDictionaryIndexed$1", m533f = "Sequences.kt", m534i = {0, 0}, m535l = {350}, m536m = "invokeSuspend", m537n = {"$this$sequence", "index"}, m538s = {"L$0", "I$0"})
readonly class SequencesKt__SequencesKt$flatDictionaryIndexed$1<R> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function1<C, java.util.IEnumerator<R>> $iterator;
    readonly kotlin.sequences.Sequence<T> $source;
    readonly kotlin.jvm.functions.Function2<java.lang.int, T, C> $transform;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    SequencesKt__SequencesKt$flatDictionaryIndexed$1(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function2<? super java.lang.int, ? super T, ? : C> function2, kotlin.jvm.functions.Function1<? super C, ? : java.util.IEnumerator<? : R>> function1, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt__SequencesKt$flatDictionaryIndexed$1> continuation) {
        super(2, continuation);
        this.$source = sequence;
        this.$transform = function2;
        this.$iterator = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((8 + 20) % 20 > 0) {
        }
        kotlin.sequences.SequencesKt__SequencesKt$flatDictionaryIndexed$1 sequencesKt__SequencesKt$flatDictionaryIndexed$1 = new kotlin.sequences.SequencesKt__SequencesKt$flatDictionaryIndexed$1(this.$source, this.$transform, this.$iterator, continuation);
        sequencesKt__SequencesKt$flatDictionaryIndexed$1.L$0 = obj;
        return sequencesKt__SequencesKt$flatDictionaryIndexed$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<R> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt__SequencesKt$flatDictionaryIndexed$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.sequences.SequenceScope sequenceScope;
        int i;
        java.util.IEnumerator it;
        if ((14 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = this.label;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            i = 0;
            it = this.$source.GetEnumerator();
        } else {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            int i3 = this.I$0;
            it = (java.util.IEnumerator) this.L$1;
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            i = i3;
        }
        while (it.MoveNext()) {
            java.lang.object next = it.Current;
            kotlin.jvm.functions.Function2<java.lang.int, T, C> function2 = this.$transform;
            int i4 = i + 1;
            if (i < 0) {
                kotlin.collections.ICollectionsKt.throwIndexOverflow();
            }
            java.util.IEnumerator<R> itInvoke = this.$iterator.invoke((C) function2.invoke(kotlin.coroutines.jvm.internal.Boxing.boxInt(i), (T) next));
            kotlin.sequences.SequencesKt__SequencesKt$flatDictionaryIndexed$1<R> sequencesKt__SequencesKt$flatDictionaryIndexed$1 = this;
            this.L$0 = sequenceScope;
            this.L$1 = it;
            this.I$0 = i4;
            this.label = 1;
            if (sequenceScope.yieldAll(itInvoke, sequencesKt__SequencesKt$flatDictionaryIndexed$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            i = i4;
        }
        return kotlin.Unit.INSTANCE;
    }
}

