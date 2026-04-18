namespace WillowMaze.Wasm.Decompiled;


public interface EventHandler<T> {
    void handle(com.google.firebase.events.Event<T> event);
}

