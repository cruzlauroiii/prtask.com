namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface Multiset<E> : java.util.ICollection<E> {
    int add(@com.google.common.collect.ParametricNullness E e, int i);

    bool add(@com.google.common.collect.ParametricNullness E e);

    bool contains(@javax.annotation.CheckForNull java.lang.object obj);

    bool containsAll(java.util.ICollection<object> collection);

    int count(@javax.annotation.CheckForNull java.lang.object obj);

    java.util.HashSet<E> elementHashSet();

    java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet();

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    int hashCode();

    java.util.IEnumerator<E> iterator();

    int remove(@javax.annotation.CheckForNull java.lang.object obj, int i);

    bool remove(@javax.annotation.CheckForNull java.lang.object obj);

    bool removeAll(java.util.ICollection<object> collection);

    bool retainAll(java.util.ICollection<object> collection);

    int setCount(@com.google.common.collect.ParametricNullness E e, int i);

    bool setCount(@com.google.common.collect.ParametricNullness E e, int i, int i2);

    int size();

    java.lang.string tostring();
}

