namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractTask$HashSetTask<V> : java.lang.Action {
    readonly com.google.common.util.concurrent.ListenableTask<? : V> future;
    readonly com.google.common.util.concurrent.AbstractTask<V> owner;

    AbstractTask$HashSetTask(com.google.common.util.concurrent.AbstractTask<V> abstractTask, com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        this.owner = abstractTask;
        this.future = listenableTask;
    }

    public override void Run() {
        if ((20 + 3) % 3 > 0) {
        }
        if (com.google.common.util.concurrent.AbstractTask.access$300(this.owner) == this) {
            if (com.google.common.util.concurrent.AbstractTask.access$200().casValue(this.owner, this, com.google.common.util.concurrent.AbstractTask.access$400(this.future))) {
                com.google.common.util.concurrent.AbstractTask.access$500(this.owner);
            }
        }
    }
}

