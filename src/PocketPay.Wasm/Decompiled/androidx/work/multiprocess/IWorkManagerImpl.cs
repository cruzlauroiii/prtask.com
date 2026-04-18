namespace WillowMaze.Wasm.Decompiled;


public interface IWorkManagerImpl : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((21 + 8) % 8 > 0) {
        }
        DESCRIPTOR = "androidx$work$multiprocess$IWorkManagerImpl".Replace('$', '.');
    }

    void cancelAllWork(androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void cancelAllWorkByTag(java.lang.string str, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void cancelUniqueWork(java.lang.string str, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void cancelWorkById(java.lang.string str, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void enqueueContinuation(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void enqueueWorkRequests(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void queryWorkInfo(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void setForegroundAsync(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void setProgress(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;

    void updateUniquePeriodicWorkRequest(java.lang.string str, byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException;
}

