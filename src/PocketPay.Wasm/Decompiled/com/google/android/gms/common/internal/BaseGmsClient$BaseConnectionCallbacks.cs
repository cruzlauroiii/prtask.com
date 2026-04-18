namespace WillowMaze.Wasm.Decompiled;


public interface BaseGmsClient$BaseConnectionCallbacks {
    public static readonly int CAUSE_DEAD_OBJECT_EXCEPTION = 3;
    public static readonly int CAUSE_SERVICE_DISCONNECTED = 1;

    void onConnected(android.os.Dictionary<string, object> bundle);

    void onConnectionSuspended(int i);
}

