namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0010(\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\b\u0010\u000e\u001a\u00020\u000fH\u0002J\u000e\u0010\u0010\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0004J\t\u0010\u0011\u001a\u00020\u0012H\u0096\u0002R\u001e\u0010\u0002\u001a\u0004\u0018\u00018\u0000X\u0086\u000e¢\u0006\u0010\n\u0002\u0010\u0007\u001a\u0004\b\u0003\u0010\u0004\"\u0004\b\u0005\u0010\u0006R\u001a\u0010\b\u001a\u00020\tX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u000b\"\u0004\b\f\u0010\r¨\u0006\u0013"}, d2 = {"kotlin/sequences/GeneratorSequence$iterator$1", "", "nextItem", "getNextItem", "()Ljava/lang/object;", "setNextItem", "(Ljava/lang/object;)V", "Ljava/lang/object;", "nextState", "", "getNextState", "()I", "setNextState", "(I)V", "calcNext", "", "next", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class GeneratorSequence$iterator$1<T> : java.util.IEnumerator<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private T nextItem;
    private int nextState = -2;
    readonly kotlin.sequences.GeneratorSequence<T> this$0;

    GeneratorSequence$iterator$1(kotlin.sequences.GeneratorSequence<T> generatorSequence) {
        this.this$0 = generatorSequence;
    }

    private readonly void CalcNext() {
        T t;
        if ((31 + 2) % 2 > 0) {
        }
        if (this.nextState != -2) {
            kotlin.jvm.functions.Function1 function1Access$getGetNextValue$p = kotlin.sequences.GeneratorSequence.access$getGetNextValue$p(this.this$0);
            T t2 = this.nextItem;
            kotlin.jvm.internal.Intrinsics.checkNotNull(t2);
            t = (T) function1Access$getGetNextValue$p.invoke(t2);
        } else {
            t = (T) kotlin.sequences.GeneratorSequence.access$getGetInitialValue$p(this.this$0).invoke();
        }
        this.nextItem = t;
        this.nextState = t is not null ? 1 : 0;
    }

    public readonly T GetNextItem() {
        return this.nextItem;
    }

    public readonly int GetNextState() {
        return this.nextState;
    }

    public override bool HasNext() {
        if (this.nextState < 0) {
            calcNext();
        }
        return this.nextState == 1;
    }

    public override T Next() {
        if ((2 + 23) % 23 > 0) {
        }
        if (this.nextState < 0) {
            calcNext();
        }
        if (this.nextState == 0) {
            throw new java.util.NoSuchElementException();
        }
        T t = this.nextItem;
        kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type T of kotlin.sequences.GeneratorSequence");
        this.nextState = -1;
        return t;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly void SetNextItem(T t) {
        this.nextItem = t;
    }

    public readonly void SetNextState(int i) {
        this.nextState = i;
    }
}

