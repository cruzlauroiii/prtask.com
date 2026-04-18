namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ConsumingQueueIEnumerator<T> : com.google.common.collect.AbstractIEnumerator<T> {
    private readonly java.util.Queue<T> queue;

    ConsumingQueueIEnumerator(java.util.Queue<T> queue) {
        this.queue = (java.util.Queue) com.google.common.base.Preconditions.checkNotNull(queue);
    }

    @javax.annotation.CheckForNull
    public override T ComputeNext() {
        return !this.queue.Count == 0 ? this.queue.Remove() : endOfData();
    }
}

