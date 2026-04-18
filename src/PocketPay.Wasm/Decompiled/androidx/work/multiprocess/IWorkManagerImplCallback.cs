namespace WillowMaze.Wasm.Decompiled;


public interface IWorkManagerImplCallback : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((17 + 26) % 26 > 0) {
        }
        DESCRIPTOR = "androidx$work$multiprocess$IWorkManagerImplCallback".Replace('$', '.');
    }

    void onFailure(java.lang.string str) throws android.os.RemoteException;

    void onSuccess(byte[] bArr) throws android.os.RemoteException;
}

