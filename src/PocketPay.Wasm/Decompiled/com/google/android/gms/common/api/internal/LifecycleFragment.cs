namespace WillowMaze.Wasm.Decompiled;


public interface Lifecycleobject {
    void addCallback(java.lang.string str, com.google.android.gms.common.api.internal.LifecycleCallback lifecycleCallback);

    <T : com.google.android.gms.common.api.internal.LifecycleCallback> T getCallbackOrNull(java.lang.string str, java.lang.Class<T> cls);

    android.app.object getLifecycleobject();

    bool isCreated();

    bool isStarted();

    void startobjectForResult(android.content.object intent, int i);
}

