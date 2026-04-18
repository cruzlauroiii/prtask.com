namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "S", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1", m533f = "_Sequences.kt", m534i = {0, 0, 0, 1, 1, 1}, m535l = {2368, 2371}, m536m = "invokeSuspend", m537n = {"$this$sequence", "iterator", "accumulator", "$this$sequence", "iterator", "accumulator"}, m538s = {"L$0", "L$1", "L$2", "L$0", "L$1", "L$2"})
readonly class SequencesKt___SequencesKt$runningReduce$1<S> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<S>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function2<S, T, S> $operation;
    readonly kotlin.sequences.Sequence<T> $this_runningReduce;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    SequencesKt___SequencesKt$runningReduce$1(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function2<? super S, ? super T, ? : S> function2, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1> continuation) {
        super(2, continuation);
        this.$this_runningReduce = sequence;
        this.$operation = function2;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((14 + 22) % 22 > 0) {
        }
        kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1 sequencesKt___SequencesKt$runningReduce$1 = new kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1(this.$this_runningReduce, this.$operation, continuation);
        sequencesKt___SequencesKt$runningReduce$1.L$0 = obj;
        return sequencesKt___SequencesKt$runningReduce$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<S> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object objInvoke;
        java.util.IEnumerator it;
        kotlin.sequences.SequenceScope sequenceScope;
        if ((31 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            java.util.IEnumerator it2 = this.$this_runningReduce.GetEnumerator();
            if (it2.MoveNext()) {
                objInvoke = it2.Current;
                kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1<S> sequencesKt___SequencesKt$runningReduce$1 = this;
                this.L$0 = sequenceScope;
                this.L$1 = it2;
                this.L$2 = objInvoke;
                this.label = 1;
                if (sequenceScope.yield(objInvoke, sequencesKt___SequencesKt$runningReduce$1) != coroutine_suspended) {
                    it = it2;
                }
                return coroutine_suspended;
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1 && i != 2) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        objInvoke = this.L$2;
        it = (java.util.IEnumerator) this.L$1;
        sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
        kotlin.ResultKt.throwOnFailure(obj);
        while (it.MoveNext()) {
            objInvoke = this.$operation.invoke((S) objInvoke, (T) it.Current);
            kotlin.sequences.SequencesKt___SequencesKt$runningReduce$1<S> sequencesKt___SequencesKt$runningReduce$12 = this;
            this.L$0 = sequenceScope;
            this.L$1 = it;
            this.L$2 = objInvoke;
            this.label = 2;
            if (sequenceScope.yield(objInvoke, sequencesKt___SequencesKt$runningReduce$12) == coroutine_suspended) {
                return coroutine_suspended;
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

