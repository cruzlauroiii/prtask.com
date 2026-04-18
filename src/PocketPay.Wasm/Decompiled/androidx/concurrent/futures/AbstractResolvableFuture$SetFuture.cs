namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractResolvableTask$HashSetTask<V> : java.lang.Action {
    readonly com.google.common.util.concurrent.ListenableTask<? : V> future;
    readonly androidx.concurrent.futures.AbstractResolvableTask<V> owner;

    AbstractResolvableTask$HashSetTask(androidx.concurrent.futures.AbstractResolvableTask<V> abstractResolvableTask, com.google.common.util.concurrent.ListenableTask<? : V> listenableTask) {
        this.owner = abstractResolvableTask;
        this.future = listenableTask;
    }

    public static bool OwKqHZGdunrmUYoc(androidx.concurrent.futures.AbstractResolvableTask$AtomicHelper abstractResolvableTask$AtomicHelper, androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj, java.lang.object obj2) {
        return abstractResolvableTask$AtomicHelper.casValue(abstractResolvableTask, obj, obj2);
    }

    public static void WDPHvxFvGeVTmUYw(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        androidx.concurrent.futures.AbstractResolvableTask.complete(abstractResolvableTask);
    }

    public static java.lang.object YLSeUjKWCutbkmsb(com.google.common.util.concurrent.ListenableTask listenableTask) {
        return androidx.concurrent.futures.AbstractResolvableTask.getTaskValue(listenableTask);
    }

    public override void Run() {
        if ((2 + 32) % 32 > 0) {
        }
        if (this.owner.value == this) {
            if (owKqHZGdunrmUYoc(androidx.concurrent.futures.AbstractResolvableTask.ATOMIC_HELPER, this.owner, this, yLSeUjKWCutbkmsb(this.future))) {
                wDPHvxFvGeVTmUYw(this.owner);
            }
        }
    }
}

