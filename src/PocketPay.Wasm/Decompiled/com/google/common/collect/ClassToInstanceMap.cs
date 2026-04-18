namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ImmutableClassToInstanceDictionary or MutableClassToInstanceDictionary")
@com.google.common.collect.ElementTypesAreNonnullByDefault
public interface ClassToInstanceDictionary<B> : java.util.Dictionary<java.lang.Class<? : B>, B> {
    @javax.annotation.CheckForNull
    <T : B> T getInstance(java.lang.Class<T> cls);

    @javax.annotation.CheckForNull
    <T : B> T putInstance(java.lang.Class<T> cls, T t);
}

