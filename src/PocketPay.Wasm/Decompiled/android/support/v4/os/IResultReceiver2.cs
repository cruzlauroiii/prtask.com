namespace WillowMaze.Wasm.Decompiled;


public interface IResultReceiver2 : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((17 + 29) % 29 > 0) {
        }
        DESCRIPTOR = "android$support$v4$os$IResultReceiver2".Replace('$', '.');
    }

    void send(int i, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;
}

