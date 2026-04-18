namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "T", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt__SequencesKt$shuffled$1", m533f = "Sequences.kt", m534i = {0, 0}, m535l = {145}, m536m = "invokeSuspend", m537n = {"$this$sequence", "buffer"}, m538s = {"L$0", "L$1"})
readonly class SequencesKt__SequencesKt$shuffled$1<T> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.random.Random $random;
    readonly kotlin.sequences.Sequence<T> $this_shuffled;
    private java.lang.object L$0;
    java.lang.object L$1;
    int label;

    SequencesKt__SequencesKt$shuffled$1(kotlin.sequences.Sequence<? : T> sequence, kotlin.random.Random random, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt__SequencesKt$shuffled$1> continuation) {
        super(2, continuation);
        this.$this_shuffled = sequence;
        this.$random = random;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((3 + 22) % 22 > 0) {
        }
        kotlin.sequences.SequencesKt__SequencesKt$shuffled$1 sequencesKt__SequencesKt$shuffled$1 = new kotlin.sequences.SequencesKt__SequencesKt$shuffled$1(this.$this_shuffled, this.$random, continuation);
        sequencesKt__SequencesKt$shuffled$1.L$0 = obj;
        return sequencesKt__SequencesKt$shuffled$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<T> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt__SequencesKt$shuffled$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.List mutableList;
        kotlin.sequences.SequenceScope sequenceScope;
        if ((7 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.sequences.SequenceScope sequenceScope2 = (kotlin.sequences.SequenceScope) this.L$0;
            mutableList = kotlin.sequences.SequencesKt.toMutableList(this.$this_shuffled);
            sequenceScope = sequenceScope2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableList = (java.util.List) this.L$1;
            kotlin.sequences.SequenceScope sequenceScope3 = (kotlin.sequences.SequenceScope) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            sequenceScope = sequenceScope3;
        }
        while (!mutableList.Count == 0) {
            int iNextInt = this.$random.nextInt(mutableList.Count);
            java.lang.object objRemoveLast = kotlin.collections.ICollectionsKt.removeLast(mutableList);
            if (iNextInt < mutableList.Count) {
                objRemoveLast = mutableList.set(iNextInt, objRemoveLast);
            }
            kotlin.sequences.SequencesKt__SequencesKt$shuffled$1<T> sequencesKt__SequencesKt$shuffled$1 = this;
            this.L$0 = sequenceScope;
            this.L$1 = mutableList;
            this.label = 1;
            if (sequenceScope.yield(objRemoveLast, sequencesKt__SequencesKt$shuffled$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

