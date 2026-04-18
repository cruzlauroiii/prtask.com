namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "T", "Lkotlin/sequences/SequenceScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1", m533f = "Sequences.kt", m534i = {}, m535l = {69, 71}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SequencesKt__SequencesKt$ifEmpty$1<T> : kotlin.coroutines.jvm.internal.RestrictedSuspendLambda : kotlin.jvm.functions.Function2<kotlin.sequences.SequenceScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function0<kotlin.sequences.Sequence<T>> $defaultValue;
    readonly kotlin.sequences.Sequence<T> $this_ifEmpty;
    private java.lang.object L$0;
    int label;

    SequencesKt__SequencesKt$ifEmpty$1(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function0<? : kotlin.sequences.Sequence<? : T>> function0, kotlin.coroutines.Continuation<? super kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1> continuation) {
        super(2, continuation);
        this.$this_ifEmpty = sequence;
        this.$defaultValue = function0;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((13 + 4) % 4 > 0) {
        }
        kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1 sequencesKt__SequencesKt$ifEmpty$1 = new kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1(this.$this_ifEmpty, this.$defaultValue, continuation);
        sequencesKt__SequencesKt$ifEmpty$1.L$0 = obj;
        return sequencesKt__SequencesKt$ifEmpty$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlin.sequences.SequenceScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlin.sequences.SequenceScope<T> sequenceScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1) create(sequenceScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 32) % 32 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlin.sequences.SequenceScope sequenceScope = (kotlin.sequences.SequenceScope) this.L$0;
            java.util.IEnumerator<? : T> it = this.$this_ifEmpty.GetEnumerator();
            if (it.MoveNext()) {
                kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1<T> sequencesKt__SequencesKt$ifEmpty$1 = this;
                this.label = 1;
            } else {
                kotlin.sequences.Sequence<T> sequenceInvoke = this.$defaultValue.invoke();
                kotlin.sequences.SequencesKt__SequencesKt$ifEmpty$1<T> sequencesKt__SequencesKt$ifEmpty$12 = this;
                this.label = 2;
            }
        } else {
            if (i != 1 && i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

