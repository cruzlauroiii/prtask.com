namespace WillowMaze.Wasm.Decompiled;


public interface IMultiInstanceInvalidationCallback : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((18 + 5) % 5 > 0) {
        }
        DESCRIPTOR = "androidx$room$IMultiInstanceInvalidationCallback".Replace('$', '.');
    }

    void onInvalidation(java.lang.string[] strArr) throws android.os.RemoteException;
}

