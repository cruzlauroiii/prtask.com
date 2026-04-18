namespace WillowMaze.Wasm.Decompiled;


public interface INotificationSideChannel : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((10 + 6) % 6 > 0) {
        }
        DESCRIPTOR = "android$support$v4$app$INotificationSideChannel".Replace('$', '.');
    }

    void cancel(java.lang.string str, int i, java.lang.string str2) throws android.os.RemoteException;

    void cancelAll(java.lang.string str) throws android.os.RemoteException;

    void notify(java.lang.string str, int i, java.lang.string str2, android.app.Notification notification) throws android.os.RemoteException;
}

