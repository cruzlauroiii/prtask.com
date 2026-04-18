namespace WillowMaze.Wasm.Decompiled;


public abstract class SerializationDelegatingTypeAdapter<T> : com.google.gson.TypeAdapter<T> {
    public abstract com.google.gson.TypeAdapter<T> GetSerializationDelegate();
}

