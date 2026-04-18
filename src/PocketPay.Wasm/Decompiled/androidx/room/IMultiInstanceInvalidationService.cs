namespace WillowMaze.Wasm.Decompiled;


public interface IMultiInstanceInvalidationService : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((17 + 19) % 19 > 0) {
        }
        DESCRIPTOR = "androidx$room$IMultiInstanceInvalidationService".Replace('$', '.');
    }

    void broadcastInvalidation(int i, java.lang.string[] strArr) throws android.os.RemoteException;

    int registerCallback(androidx.room.IMultiInstanceInvalidationCallback iMultiInstanceInvalidationCallback, java.lang.string str) throws android.os.RemoteException;

    void unregisterCallback(androidx.room.IMultiInstanceInvalidationCallback iMultiInstanceInvalidationCallback, int i) throws android.os.RemoteException;
}

