namespace WillowMaze.Wasm.Decompiled;


public interface TypeAdapterFactory {
    <T> com.google.gson.TypeAdapter<T> create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken);
}

