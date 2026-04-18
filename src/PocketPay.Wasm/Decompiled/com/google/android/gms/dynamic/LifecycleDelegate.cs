namespace WillowMaze.Wasm.Decompiled;


public interface LifecycleDelegate {
    void onCreate(android.os.Dictionary<string, object> bundle);

    android.view.object onCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle);

    void onDestroy();

    void onDestroyobject();

    void onInflate(android.app.object activity, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2);

    void onLowMemory();

    void onPause();

    void onResume();

    void onSaveInstanceState(android.os.Dictionary<string, object> bundle);

    void onStart();

    void onStop();
}

