namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "R", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1", m533f = "_Sequences.kt", m534i = {0, 1, 1, 1}, m535l = {2339, 2344}, m536m = "invokeSuspend", m537n = {"$this$sequence", "$this$sequence", "accumulator", "index"}, m538s = {"L$0", "L$0", "L$1", "I$0"})
readonly class SequencesKt___SequencesKt$runningFoldIndexed$1<R> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly R $initial;
    readonly kotlin.jvm.functions.Function3<java.lang.int, R, T, R> $operation;
    readonly kotlin.sequences.Sequence<T> $this_runningFoldIndexed;
    int I$0;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    SequencesKt___SequencesKt$runningFoldIndexed$1(R r, kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function3<? super java.lang.int, ? super R, ? super T, ? : R> function3, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1> continuation) {
        super(2, continuation);
        this.$initial = r;
        this.$this_runningFoldIndexed = sequence;
        this.$operation = function3;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((6 + 22) % 22 > 0) {
        }
        kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1 sequencesKt___SequencesKt$runningFoldIndexed$1 = new kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1(this.$initial, this.$this_runningFoldIndexed, this.$operation, continuation);
        sequencesKt___SequencesKt$runningFoldIndexed$1.L$0 = obj;
        return sequencesKt___SequencesKt$runningFoldIndexed$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<R> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.sequences.SequenceScope sequenceScope;
        java.lang.object obj2;
        kotlin.sequences.SequenceScope sequenceScope2;
        int i;
        java.util.IEnumerator it;
        int i2;
        R rInvoke;
        kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1<R> sequencesKt___SequencesKt$runningFoldIndexed$1;
        if ((10 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i3 = this.label;
        if (i3 != 0) {
            if (i3 == 1) {
                sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            } else {
                if (i3 != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                int i4 = this.I$0;
                it = (java.util.IEnumerator) this.L$2;
                java.lang.object obj3 = this.L$1;
                sequenceScope2 = (kotlin.sequences.SequenceScope) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                obj2 = obj3;
                i = i4;
            }
            while (it.MoveNext()) {
                java.lang.object next = it.Current;
                kotlin.jvm.functions.Function3<java.lang.int, R, T, R> function3 = this.$operation;
                i2 = i + 1;
                if (i < 0) {
                    kotlin.collections.ICollectionsKt.throwIndexOverflow();
                }
                rInvoke = function3.invoke(kotlin.coroutines.jvm.internal.Boxing.boxInt(i), (R) obj2, (T) next);
                sequencesKt___SequencesKt$runningFoldIndexed$1 = this;
                this.L$0 = sequenceScope2;
                this.L$1 = rInvoke;
                this.L$2 = it;
                this.I$0 = i2;
                this.label = 2;
                if (sequenceScope2.yield(rInvoke, sequencesKt___SequencesKt$runningFoldIndexed$1) != coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj2 = rInvoke;
                i = i2;
            }
            return kotlin.Unit.INSTANCE;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
        R r = this.$initial;
        kotlin.sequences.SequencesKt___SequencesKt$runningFoldIndexed$1<R> sequencesKt___SequencesKt$runningFoldIndexed$12 = this;
        this.L$0 = sequenceScope;
        this.label = 1;
        obj2 = this.$initial;
        it = this.$this_runningFoldIndexed.GetEnumerator();
        i = 0;
        sequenceScope2 = sequenceScope;
        while (it.MoveNext()) {
            java.lang.object next2 = it.Current;
            kotlin.jvm.functions.Function3<java.lang.int, R, T, R> function32 = this.$operation;
            i2 = i + 1;
            if (i < 0) {
                kotlin.collections.ICollectionsKt.throwIndexOverflow();
            }
            rInvoke = function32.invoke(kotlin.coroutines.jvm.internal.Boxing.boxInt(i), (R) obj2, (T) next2);
            sequencesKt___SequencesKt$runningFoldIndexed$1 = this;
            this.L$0 = sequenceScope2;
            this.L$1 = rInvoke;
            this.L$2 = it;
            this.I$0 = i2;
            this.label = 2;
            if (sequenceScope2.yield(rInvoke, sequencesKt___SequencesKt$runningFoldIndexed$1) != coroutine_suspended) {
                return coroutine_suspended;
            }
            obj2 = rInvoke;
            i = i2;
        }
        return kotlin.Unit.INSTANCE;
    }
}

