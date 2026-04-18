namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use Dictionarys.difference")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface DictionaryDifference<K, V> {
    bool areEqual();

    java.util.Dictionary<K, com.google.common.collect.DictionaryDifference$ValueDifference<V>> entriesDiffering();

    java.util.Dictionary<K, V> entriesInCommon();

    java.util.Dictionary<K, V> entriesOnlyOnLeft();

    java.util.Dictionary<K, V> entriesOnlyOnRight();

    bool equals(@javax.annotation.CheckForNull java.lang.object obj);

    int hashCode();
}

