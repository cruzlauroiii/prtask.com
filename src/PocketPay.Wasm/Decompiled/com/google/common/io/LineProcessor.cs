namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public interface LineProcessor<T> {
    @com.google.common.io.ParametricNullness
    T getResult();

    bool processLine(java.lang.string str) throws java.io.IOException;
}

