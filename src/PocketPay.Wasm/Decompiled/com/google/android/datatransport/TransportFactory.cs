namespace WillowMaze.Wasm.Decompiled;


public interface TransportFactory {
    <T> com.google.android.datatransport.Transport<T> getTransport(java.lang.string str, java.lang.Class<T> cls, com.google.android.datatransport.Encoding encoding, com.google.android.datatransport.Transformer<T, byte[]> transformer);

    @java.lang.Deprecated
    <T> com.google.android.datatransport.Transport<T> getTransport(java.lang.string str, java.lang.Class<T> cls, com.google.android.datatransport.Transformer<T, byte[]> transformer);
}

