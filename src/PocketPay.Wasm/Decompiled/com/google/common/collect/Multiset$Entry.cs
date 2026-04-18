namespace WillowMaze.Wasm.Decompiled;


public interface Multiset$Entry<E> {
    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    int getCount();

    @com.google.common.collect.ParametricNullness
    E getElement();

    int hashCode();

    java.lang.string tostring();
}

