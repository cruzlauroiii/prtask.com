namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "R", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt___SequencesKt$zipWithNext$2", m533f = "_Sequences.kt", m534i = {0, 0, 0}, m535l = {2873}, m536m = "invokeSuspend", m537n = {"$this$result", "iterator", "next"}, m538s = {"L$0", "L$1", "L$2"})
readonly class SequencesKt___SequencesKt$zipWithNext$2<R> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.sequences.Sequence<T> $this_zipWithNext;
    readonly kotlin.jvm.functions.Function2<T, T, R> $transform;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    SequencesKt___SequencesKt$zipWithNext$2(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function2<? super T, ? super T, ? : R> function2, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt___SequencesKt$zipWithNext$2> continuation) {
        super(2, continuation);
        this.$this_zipWithNext = sequence;
        this.$transform = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((19 + 15) % 15 > 0) {
        }
        kotlin.sequences.SequencesKt___SequencesKt$zipWithNext$2 sequencesKt___SequencesKt$zipWithNext$2 = new kotlin.sequences.SequencesKt___SequencesKt$zipWithNext$2(this.$this_zipWithNext, this.$transform, continuation);
        sequencesKt___SequencesKt$zipWithNext$2.L$0 = obj;
        return sequencesKt___SequencesKt$zipWithNext$2;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<R> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt___SequencesKt$zipWithNext$2) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.IEnumerator it;
        kotlin.sequences.SequenceScope sequenceScope;
        java.lang.object next;
        if ((10 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.sequences.SequenceScope sequenceScope2 = (kotlin.sequences.SequenceScope) this.L$0;
            java.util.IEnumerator it2 = this.$this_zipWithNext.GetEnumerator();
            if (!it2.MoveNext()) {
                return kotlin.Unit.INSTANCE;
            }
            sequenceScope = sequenceScope2;
            next = it2.Current;
            it = it2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            java.lang.object obj2 = this.L$2;
            it = (java.util.IEnumerator) this.L$1;
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            next = obj2;
        }
        while (it.MoveNext()) {
            java.lang.object next2 = it.Current;
            R rInvoke = this.$transform.invoke((T) next, (T) next2);
            kotlin.sequences.SequencesKt___SequencesKt$zipWithNext$2<R> sequencesKt___SequencesKt$zipWithNext$2 = this;
            this.L$0 = sequenceScope;
            this.L$1 = it;
            this.L$2 = next2;
            this.label = 1;
            if (sequenceScope.yield(rInvoke, sequencesKt___SequencesKt$zipWithNext$2) == coroutine_suspended) {
                return coroutine_suspended;
            }
            next = next2;
        }
        return kotlin.Unit.INSTANCE;
    }
}

