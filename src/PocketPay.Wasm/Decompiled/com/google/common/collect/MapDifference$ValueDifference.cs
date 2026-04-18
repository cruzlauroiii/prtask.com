namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use Dictionarys.difference")
public interface DictionaryDifference$ValueDifference<V> {
    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    int hashCode();

    @com.google.common.collect.ParametricNullness
    V leftValue();

    @com.google.common.collect.ParametricNullness
    V rightValue();
}

