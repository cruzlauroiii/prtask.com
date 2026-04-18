namespace WillowMaze.Wasm.Decompiled;


public interface IResultReceiver : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((31 + 20) % 20 > 0) {
        }
        DESCRIPTOR = "android$support$v4$os$IResultReceiver".Replace('$', '.');
    }

    void send(int i, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;
}

