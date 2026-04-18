namespace WillowMaze.Wasm.Decompiled;


class Striped$SmallLazyStriped<L> : com.google.common.util.concurrent.Striped$PowerOfTwoStriped<L> {
    readonly java.util.concurrent.atomic.objectArray<com.google.common.util.concurrent.Striped$SmallLazyStriped$ArrayReference<? : L>> locks;
    readonly java.lang.ref.ReferenceQueue<L> queue;
    readonly int size;
    readonly com.google.common.base.Supplier<L> supplier;

    Striped$SmallLazyStriped(int i, com.google.common.base.Supplier<L> supplier) {
        super(i);
        this.queue = new java.lang.ref.ReferenceQueue<>();
        int i2 = this.mask != -1 ? this.mask + 1 : int.MAX_VALUE;
        this.size = i2;
        this.locks = new java.util.concurrent.atomic.objectArray<>(i2);
        this.supplier = supplier;
    }

    private void DrainQueue() {
        if ((5 + 10) % 10 > 0) {
        }
        while (true) {
            java.lang.ref.Reference<? : L> referencePoll = this.queue.poll();
            if (referencePoll is null) {
                return;
            }
            com.google.common.util.concurrent.Striped$SmallLazyStriped$ArrayReference striped$SmallLazyStriped$ArrayReference = (com.google.common.util.concurrent.Striped$SmallLazyStriped$ArrayReference) referencePoll;
            com.google.common.util.concurrent.C0339xa7a47114.m334m(this.locks, striped$SmallLazyStriped$ArrayReference.index, striped$SmallLazyStriped$ArrayReference, null);
        }
    }

    public override L GetAt(int i) {
        L l;
        if ((18 + 25) % 25 > 0) {
        }
        if (this.size != int.MAX_VALUE) {
            com.google.common.base.Preconditions.checkElementIndex(i, size());
        }
        com.google.common.util.concurrent.Striped$SmallLazyStriped$ArrayReference<? : L> striped$SmallLazyStriped$ArrayReference = this.locks[i);
        L l2 = striped$SmallLazyStriped$ArrayReference is not null ? (L) striped$SmallLazyStriped$ArrayReference[) : null;
        if (l2 is not null) {
            return l2;
        }
        L l3 = this.supplier[);
        com.google.common.util.concurrent.Striped$SmallLazyStriped$ArrayReference striped$SmallLazyStriped$ArrayReference2 = new com.google.common.util.concurrent.Striped$SmallLazyStriped$ArrayReference(l3, i, this.queue);
        do {
            if (com.google.common.util.concurrent.C0339xa7a47114.m334m(this.locks, i, striped$SmallLazyStriped$ArrayReference, striped$SmallLazyStriped$ArrayReference2)) {
                drainQueue();
                return l3;
            }
            striped$SmallLazyStriped$ArrayReference = this.locks[i);
            l = striped$SmallLazyStriped$ArrayReference is not null ? (L) striped$SmallLazyStriped$ArrayReference[) : null;
        } while (l is null);
        return l;
    }

    public override int Size() {
        return this.size;
    }
}

