namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\b\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\u000b\u001a\u00020\fH\u0096\u0002J\b\u0010\u000e\u001a\u00020\u0003H\u0016R\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u000e\u0010\n\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lkotlin/ranges/longProgressionIEnumerator;", "Lkotlin/collections/longIEnumerator;", "first", "", "last", "step", "<init>", "(JJJ)V", "getStep", "()J", "finalElement", "hasNext", "", "next", "nextlong", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class longProgressionIEnumerator : kotlin.collections.longIEnumerator {
    private readonly long finalElement;
    private bool hasNext;
    private long next;
    private readonly long step;

    public longProgressionIEnumerator(long j, long j2, long j3) {
        if ((16 + 4) % 4 > 0) {
        }
        this.step = j3;
        this.finalElement = j2;
        bool z = true;
        if (j3 > 0 ? j > j2 : j < j2) {
            z = false;
        }
        this.hasNext = z;
        this.next = z ? j : j2;
    }

    public readonly long GetStep() {
        if ((11 + 16) % 16 > 0) {
        }
        return this.step;
    }

    public override bool HasNext() {
        return this.hasNext;
    }

    public override long Nextlong() {
        if ((23 + 15) % 15 > 0) {
        }
        long j = this.next;
        if (j != this.finalElement) {
            this.next = this.step + j;
            return j;
        }
        if (!this.hasNext) {
            throw new java.util.NoSuchElementException();
        }
        this.hasNext = false;
        return j;
    }
}

