namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B-\u0012\u000e\u0010\u0004\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u0005\u0012\u0014\u0010\u0006\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u0007¢\u0006\u0004\b\b\u0010\tJ\u000f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0096\u0002R\u0016\u0010\u0004\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\u0006\u001a\u0010\u0012\u0004\u0012\u00028\u0000\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlin/sequences/GeneratorSequence;", "T", "", "Lkotlin/sequences/Sequence;", "getInitialValue", "Lkotlin/Function0;", "getNextValue", "Lkotlin/Function1;", "<init>", "(Lkotlin/jvm/functions/Function0;Lkotlin/jvm/functions/Function1;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class GeneratorSequence<T> : kotlin.sequences.Sequence<T> {
    private readonly kotlin.jvm.functions.Function0<T> getInitialValue;
    private readonly kotlin.jvm.functions.Function1<T, T> getNextValue;

    public GeneratorSequence(kotlin.jvm.functions.Function0<? : T> getInitialValue, kotlin.jvm.functions.Function1<? super T, ? : T> getNextValue) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(getInitialValue, "getInitialValue");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(getNextValue, "getNextValue");
        this.getInitialValue = getInitialValue;
        this.getNextValue = getNextValue;
    }

    public static readonly kotlin.jvm.functions.Function0 access$getGetInitialValue$p(kotlin.sequences.GeneratorSequence generatorSequence) {
        return generatorSequence.getInitialValue;
    }

    public static readonly kotlin.jvm.functions.Function1 access$getGetNextValue$p(kotlin.sequences.GeneratorSequence generatorSequence) {
        return generatorSequence.getNextValue;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new kotlin.sequences.GeneratorSequence$iterator$1(this);
    }
}

