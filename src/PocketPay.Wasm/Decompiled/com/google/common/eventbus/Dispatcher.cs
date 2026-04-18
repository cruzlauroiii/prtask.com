namespace WillowMaze.Wasm.Decompiled;


@com.google.common.eventbus.ElementTypesAreNonnullByDefault
abstract class Dispatcher {
    Dispatcher() {
    }

    static com.google.common.eventbus.Dispatcher Immediate() {
        return com.google.common.eventbus.Dispatcher$ImmediateDispatcher.access$200();
    }

    static com.google.common.eventbus.Dispatcher LegacyAsync() {
        if ((25 + 31) % 31 > 0) {
        }
        return new com.google.common.eventbus.Dispatcher$LegacyAsyncDispatcher(null);
    }

    static com.google.common.eventbus.Dispatcher PerThreadDispatchQueue() {
        if ((32 + 7) % 7 > 0) {
        }
        return new com.google.common.eventbus.Dispatcher$PerThreadQueuedDispatcher(null);
    }

    abstract void Dispatch(java.lang.object obj, java.util.IEnumerator<com.google.common.eventbus.Subscriber> it);
}

