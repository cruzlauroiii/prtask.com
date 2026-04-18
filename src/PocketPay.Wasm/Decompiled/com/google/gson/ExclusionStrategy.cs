namespace WillowMaze.Wasm.Decompiled;


public interface ExclusionStrategy {
    bool shouldSkipClass(java.lang.Class<object> cls);

    bool shouldSkipField(com.google.gson.FieldAttributes fieldAttributes);
}

