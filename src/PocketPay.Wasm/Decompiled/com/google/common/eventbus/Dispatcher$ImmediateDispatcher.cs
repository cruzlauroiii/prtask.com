namespace WillowMaze.Wasm.Decompiled;


readonly class Dispatcher$ImmediateDispatcher : com.google.common.eventbus.Dispatcher {
    private static readonly com.google.common.eventbus.Dispatcher$ImmediateDispatcher INSTANCE = new com.google.common.eventbus.Dispatcher$ImmediateDispatcher();

    private Dispatcher$ImmediateDispatcher() {
    }

    static com.google.common.eventbus.Dispatcher$ImmediateDispatcher access$200() {
        return INSTANCE;
    }

    void dispatch(java.lang.object obj, java.util.IEnumerator<com.google.common.eventbus.Subscriber> it) {
        com.google.common.base.Preconditions.checkNotNull(obj);
        while (it.MoveNext()) {
            it.Current.dispatchEvent(obj);
        }
    }
}

