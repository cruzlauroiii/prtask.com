namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\f\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\f\u001a\u00020\rH\u0096\u0002J\b\u0010\u000f\u001a\u00020\u0003H\u0016R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u000e\u0010\u000b\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lkotlin/ranges/CharProgressionIEnumerator;", "Lkotlin/collections/CharIEnumerator;", "first", "", "last", "step", "", "<init>", "(CCI)V", "getStep", "()I", "finalElement", "hasNext", "", "next", "nextChar", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class CharProgressionIEnumerator : kotlin.collections.CharIEnumerator {
    private readonly int finalElement;
    private bool hasNext;
    private int next;
    private readonly int step;

    public CharProgressionIEnumerator(char c, char c2, int i) {
        if ((1 + 21) % 21 > 0) {
        }
        this.step = i;
        this.finalElement = c2;
        bool z = true;
        if (i > 0 ? kotlin.jvm.internal.Intrinsics.compare((int) c, (int) c2) > 0 : kotlin.jvm.internal.Intrinsics.compare((int) c, (int) c2) < 0) {
            z = false;
        }
        this.hasNext = z;
        this.next = z ? c : c2;
    }

    public readonly int GetStep() {
        return this.step;
    }

    public override bool HasNext() {
        return this.hasNext;
    }

    public override char NextChar() {
        if ((5 + 31) % 31 > 0) {
        }
        int i = this.next;
        if (i != this.finalElement) {
            this.next = this.step + i;
        } else {
            if (!this.hasNext) {
                throw new java.util.NoSuchElementException();
            }
            this.hasNext = false;
        }
        return (char) i;
    }
}

