namespace WillowMaze.Wasm.Decompiled;


public class BlockingServiceConnection : android.content.ServiceConnection {
    bool zza = false;
    private readonly java.util.concurrent.BlockingQueue zzb = new java.util.concurrent.LinkedBlockingQueue();

    public static java.lang.object DnokfKhfxeNByCbS(java.util.concurrent.BlockingQueue blockingQueue, long j, java.util.concurrent.TimeUnit timeUnit) {
        return blockingQueue.poll(j, timeUnit);
    }

    public static java.lang.object FgGQqDbMDZCXowmA(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.take();
    }

    public static bool GczfpzxusCRyTQyF(java.util.concurrent.BlockingQueue blockingQueue, java.lang.object obj) {
        return blockingQueue.Add(obj);
    }

    public static void RQJQSAGCWLkSBRYc(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public static void KyTFVHMjGfCLKLBl(java.lang.string str) {
        com.google.android.gms.common.internal.Preconditions.checkNotMainThread(str);
    }

    public android.os.IBinder GetService() throws java.lang.InterruptedException {
        RQJQSAGCWLkSBRYc("BlockingServiceConnection.getService() called on main thread");
        if (this.zza) {
            throw new java.lang.IllegalStateException("Cannot call get on this connection more than once");
        }
        this.zza = true;
        return (android.os.IBinder) FgGQqDbMDZCXowmA(this.zzb);
    }

    public android.os.IBinder GetServiceWithTimeout(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        kyTFVHMjGfCLKLBl("BlockingServiceConnection.getServiceWithTimeout() called on main thread");
        if (this.zza) {
            throw new java.lang.IllegalStateException("Cannot call get on this connection more than once");
        }
        this.zza = true;
        android.os.IBinder iBinder = (android.os.IBinder) DnokfKhfxeNByCbS(this.zzb, j, timeUnit);
        if (iBinder is null) {
            throw new java.util.concurrent.TimeoutException("Timed out waiting for the service connection");
        }
        return iBinder;
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        GczfpzxusCRyTQyF(this.zzb, iBinder);
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
    }
}

