namespace WillowMaze.Wasm.Decompiled;


public interface Table$Cell<R, C, V> {
    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    @com.google.common.collect.ParametricNullness
    C getColumnKey();

    @com.google.common.collect.ParametricNullness
    R getRowKey();

    @com.google.common.collect.ParametricNullness
    V getValue();

    int hashCode();
}

