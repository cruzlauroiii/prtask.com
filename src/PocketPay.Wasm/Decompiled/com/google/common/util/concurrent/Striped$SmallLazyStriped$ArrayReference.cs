namespace WillowMaze.Wasm.Decompiled;


readonly class Striped$SmallLazyStriped$ArrayReference<L> : java.lang.ref.WeakReference<L> {
    readonly int index;

    Striped$SmallLazyStriped$ArrayReference(L l, int i, java.lang.ref.ReferenceQueue<L> referenceQueue) {
        super(l, referenceQueue);
        this.index = i;
    }
}

