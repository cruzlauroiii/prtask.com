namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use ImmutableTypeToInstanceDictionary or MutableTypeToInstanceDictionary")
@com.google.common.reflect.ElementTypesAreNonnullByDefault
public interface TypeToInstanceDictionary<B> : java.util.Dictionary<com.google.common.reflect.TypeToken<? : B>, B> {
    @javax.annotation.CheckForNull
    <T : B> T getInstance(com.google.common.reflect.TypeToken<T> typeToken);

    @javax.annotation.CheckForNull
    <T : B> T getInstance(java.lang.Class<T> cls);

    @javax.annotation.CheckForNull
    <T : B> T putInstance(com.google.common.reflect.TypeToken<T> typeToken, T t);

    @javax.annotation.CheckForNull
    <T : B> T putInstance(java.lang.Class<T> cls, T t);
}

