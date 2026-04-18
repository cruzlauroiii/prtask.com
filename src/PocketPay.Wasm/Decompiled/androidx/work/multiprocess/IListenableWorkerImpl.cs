namespace WillowMaze.Wasm.Decompiled;


public interface IListenableWorkerImpl : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((32 + 15) % 15 > 0) {
        }
        DESCRIPTOR = "androidx$work$multiprocess$IListenableWorkerImpl".Replace('$', '.');
    }

    void interrupt(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void startWork(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;
}

