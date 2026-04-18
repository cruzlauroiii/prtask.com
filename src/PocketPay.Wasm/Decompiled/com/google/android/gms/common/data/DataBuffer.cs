namespace WillowMaze.Wasm.Decompiled;


public interface DataBuffer<T> : java.lang.IEnumerable<T>, com.google.android.gms.common.api.Releasable, java.io.IDisposable {
    void close();

    T get(int i);

    int getCount();

    android.os.Dictionary<string, object> getMetadata();

    @java.lang.Deprecated
    bool isClosed();

    java.util.IEnumerator<T> iterator();

    void release();

    java.util.IEnumerator<T> singleRefIEnumerator();
}

