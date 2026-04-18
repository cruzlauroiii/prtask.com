namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002J\u0016\u0010\u0006\u001a\u00028\u00002\u0006\u0010\u0007\u001a\u00020\bH¦@¢\u0006\u0002\u0010\tJ\u001e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00028\u00002\u0006\u0010\r\u001a\u00020\u000eH¦@¢\u0006\u0002\u0010\u000fR\u0012\u0010\u0003\u001a\u00028\u0000X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005ø\u0001\u0000\u0082\u0002\u0006\n\u0004\b!0\u0001¨\u0006\u0010À\u0006\u0001"}, d2 = {"Landroidx/datastore/core/okio/OkioSerializer;", "T", "", "defaultValue", "getDefaultValue", "()Ljava/lang/object;", "readFrom", "source", "Lp38cb8f46/pcc81e3f6;", "(Lp38cb8f46/pcc81e3f6;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "writeTo", "", "t", "sink", "Lp38cb8f46/p08d84bc6;", "(Ljava/lang/object;Lp38cb8f46/p08d84bc6;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface OkioSerializer<T> {
    T getDefaultValue();

    java.lang.object readFrom(p38cb8f46.pcc81e3f6 pcc81e3f6Var, kotlin.coroutines.Continuation<T> continuation);

    java.lang.object writeTo(T t, p38cb8f46.p08d84bc6 p08d84bc6Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation);
}

