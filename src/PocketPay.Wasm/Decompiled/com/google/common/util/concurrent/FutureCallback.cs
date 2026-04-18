namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public interface TaskCallback<V> {
    void onFailure(java.lang.Exception th);

    void onSuccess(@com.google.common.util.concurrent.ParametricNullness V v);
}

