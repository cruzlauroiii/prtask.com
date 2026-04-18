namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "S", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1", m533f = "_Sequences.kt", m534i = {0, 0, 0, 1, 1, 1, 1}, m535l = {2397, 2401}, m536m = "invokeSuspend", m537n = {"$this$sequence", "iterator", "accumulator", "$this$sequence", "iterator", "accumulator", "index"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2", "I$0"})
readonly class SequencesKt___SequencesKt$runningReduceIndexed$1<S> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<S>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function3<java.lang.int, S, T, S> $operation;
    readonly kotlin.sequences.Sequence<T> $this_runningReduceIndexed;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    SequencesKt___SequencesKt$runningReduceIndexed$1(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function3<? super java.lang.int, ? super S, ? super T, ? : S> function3, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1> continuation) {
        super(2, continuation);
        this.$this_runningReduceIndexed = sequence;
        this.$operation = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((4 + 18) % 18 > 0) {
        }
        kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1 sequencesKt___SequencesKt$runningReduceIndexed$1 = new kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1(this.$this_runningReduceIndexed, this.$operation, continuation);
        sequencesKt___SequencesKt$runningReduceIndexed$1.L$0 = obj;
        return sequencesKt___SequencesKt$runningReduceIndexed$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<S> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.sequences.SequenceScope sequenceScope;
        java.util.IEnumerator it;
        java.lang.object next;
        if ((30 + 8) % 8 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        int i2 = 1;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            it = this.$this_runningReduceIndexed.GetEnumerator();
            if (it.MoveNext()) {
                next = it.Current;
                kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1<S> sequencesKt___SequencesKt$runningReduceIndexed$1 = this;
                this.L$0 = sequenceScope;
                this.L$1 = it;
                this.L$2 = next;
                this.label = 1;
                if (sequenceScope.yield(next, sequencesKt___SequencesKt$runningReduceIndexed$1) != coroutine_suspended) {
                }
                return coroutine_suspended;
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i == 1) {
            next = this.L$2;
            it = (java.util.IEnumerator) this.L$1;
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            int i3 = this.I$0;
            java.lang.object obj2 = this.L$2;
            it = (java.util.IEnumerator) this.L$1;
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            i2 = i3;
            next = obj2;
        }
        while (it.MoveNext()) {
            kotlin.jvm.functions.Function3<java.lang.int, S, T, S> function3 = this.$operation;
            int i4 = i2 + 1;
            if (i2 < 0) {
                kotlin.collections.ICollectionsKt.throwIndexOverflow();
            }
            S sInvoke = function3.invoke(kotlin.coroutines.jvm.internal.Boxing.boxInt(i2), (S) next, (T) it.Current);
            kotlin.sequences.SequencesKt___SequencesKt$runningReduceIndexed$1<S> sequencesKt___SequencesKt$runningReduceIndexed$12 = this;
            this.L$0 = sequenceScope;
            this.L$1 = it;
            this.L$2 = sInvoke;
            this.I$0 = i4;
            this.label = 2;
            if (sequenceScope.yield(sInvoke, sequencesKt___SequencesKt$runningReduceIndexed$12) == coroutine_suspended) {
                return coroutine_suspended;
            }
            next = sInvoke;
            i2 = i4;
        }
        return kotlin.Unit.INSTANCE;
    }
}

