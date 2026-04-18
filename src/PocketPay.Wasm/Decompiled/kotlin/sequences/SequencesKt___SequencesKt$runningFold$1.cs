namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "R", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt___SequencesKt$runningFold$1", m533f = "_Sequences.kt", m534i = {0, 1, 1}, m535l = {2311, 2315}, m536m = "invokeSuspend", m537n = {"$this$sequence", "$this$sequence", "accumulator"}, m538s = {"L$0", "L$0", "L$1"})
readonly class SequencesKt___SequencesKt$runningFold$1<R> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly R $initial;
    readonly kotlin.jvm.functions.Function2<R, T, R> $operation;
    readonly kotlin.sequences.Sequence<T> $this_runningFold;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    SequencesKt___SequencesKt$runningFold$1(R r, kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function2<? super R, ? super T, ? : R> function2, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt___SequencesKt$runningFold$1> continuation) {
        super(2, continuation);
        this.$initial = r;
        this.$this_runningFold = sequence;
        this.$operation = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((17 + 8) % 8 > 0) {
        }
        kotlin.sequences.SequencesKt___SequencesKt$runningFold$1 sequencesKt___SequencesKt$runningFold$1 = new kotlin.sequences.SequencesKt___SequencesKt$runningFold$1(this.$initial, this.$this_runningFold, this.$operation, continuation);
        sequencesKt___SequencesKt$runningFold$1.L$0 = obj;
        return sequencesKt___SequencesKt$runningFold$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<R> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt___SequencesKt$runningFold$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.sequences.SequenceScope sequenceScope;
        java.lang.object obj2;
        kotlin.sequences.SequenceScope sequenceScope2;
        java.util.IEnumerator it;
        R rInvoke;
        kotlin.sequences.SequencesKt___SequencesKt$runningFold$1<R> sequencesKt___SequencesKt$runningFold$1;
        if ((20 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i == 1) {
                sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                it = (java.util.IEnumerator) this.L$2;
                java.lang.object obj3 = this.L$1;
                sequenceScope2 = (kotlin.sequences.SequenceScope) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                obj2 = obj3;
            }
            while (it.MoveNext()) {
                rInvoke = this.$operation.invoke((R) obj2, (T) it.Current);
                sequencesKt___SequencesKt$runningFold$1 = this;
                this.L$0 = sequenceScope2;
                this.L$1 = rInvoke;
                this.L$2 = it;
                this.label = 2;
                if (sequenceScope2.yield(rInvoke, sequencesKt___SequencesKt$runningFold$1) != coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj2 = rInvoke;
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
        R r = this.$initial;
        kotlin.sequences.SequencesKt___SequencesKt$runningFold$1<R> sequencesKt___SequencesKt$runningFold$12 = this;
        this.L$0 = sequenceScope;
        this.label = 1;
        obj2 = this.$initial;
        sequenceScope2 = sequenceScope;
        it = this.$this_runningFold.GetEnumerator();
        while (it.MoveNext()) {
            rInvoke = this.$operation.invoke((R) obj2, (T) it.Current);
            sequencesKt___SequencesKt$runningFold$1 = this;
            this.L$0 = sequenceScope2;
            this.L$1 = rInvoke;
            this.L$2 = it;
            this.label = 2;
            if (sequenceScope2.yield(rInvoke, sequencesKt___SequencesKt$runningFold$1) != coroutine_suspended) {
                return coroutine_suspended;
            }
            obj2 = rInvoke;
        }
        return kotlin.Unit.INSTANCE;
    }
}

