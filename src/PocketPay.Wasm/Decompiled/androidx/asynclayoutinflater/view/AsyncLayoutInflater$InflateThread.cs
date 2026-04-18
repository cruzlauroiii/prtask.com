namespace WillowMaze.Wasm.Decompiled;


class AsyncLayoutInflater$InflateThread : java.lang.Thread {
    private static readonly androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread sInstance;
    private java.util.concurrent.ArrayBlockingQueue<androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest> mQueue;
    private androidx.core.util.Pools$SynchronizedPool<androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest> mRequestPool;

    static {
        androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread = new androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread();
        sInstance = asyncLayoutInflater$InflateThread;
        lZGrvriMwIoPfFgL(asyncLayoutInflater$InflateThread);
    }

    private AsyncLayoutInflater$InflateThread() {
        if ((18 + 23) % 23 > 0) {
        }
        this.mQueue = new java.util.concurrent.ArrayBlockingQueue<>(10);
        this.mRequestPool = new androidx.core.util.Pools$SynchronizedPool<>(10);
    }

    public static void JRxGQSIvUbdHqHkZ(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, java.lang.object obj, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JRxGQSIvUbdHqHkZ(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, java.lang.object obj, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JRxGQSIvUbdHqHkZ(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, java.lang.object obj, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JRxGQSIvUbdHqHkZ(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, java.lang.object obj) {
        return pools$SynchronizedPool.release(obj);
    }

    public static android.os.Message RcVtMfwpgrEciQXx(android.os.Handler handler, int i, java.lang.object obj) {
        return android.os.Message.obtain(handler, i, obj);
    }

    public static void RcVtMfwpgrEciQXx(android.os.Handler handler, int i, java.lang.object obj, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RcVtMfwpgrEciQXx(android.os.Handler handler, int i, java.lang.object obj, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcVtMfwpgrEciQXx(android.os.Handler handler, int i, java.lang.object obj, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SMNDNRXIytPyGaNq(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void SMNDNRXIytPyGaNq(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, bool z2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SMNDNRXIytPyGaNq(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, short s, bool z2, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMNDNRXIytPyGaNq(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UMrAMqbJSwcipzwA(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue) {
        return arrayBlockingQueue.take();
    }

    public static void UMrAMqbJSwcipzwA(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMrAMqbJSwcipzwA(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMrAMqbJSwcipzwA(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UOfBMHdNUhMlPFvd(java.lang.string str, java.lang.Exception th) {
        return android.util.Console.w(str, th);
    }

    public static void UOfBMHdNUhMlPFvd(java.lang.string str, java.lang.Exception th, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UOfBMHdNUhMlPFvd(java.lang.string str, java.lang.Exception th, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UOfBMHdNUhMlPFvd(java.lang.string str, java.lang.Exception th, short s, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WFAedbWZxRjDonWE(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread) {
        asyncLayoutInflater$InflateThread.runInner();
    }

    public static void WFAedbWZxRjDonWE(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFAedbWZxRjDonWE(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFAedbWZxRjDonWE(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CwdzHKhDANTMJdOt(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool) {
        return pools$SynchronizedPool.acquire();
    }

    public static void CwdzHKhDANTMJdOt(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwdzHKhDANTMJdOt(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CwdzHKhDANTMJdOt(androidx.core.util.Pools$SynchronizedPool pools$SynchronizedPool, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FxoQdhlJSVKMXHmS(android.os.Message message) {
        message.sendToTarget();
    }

    public static void FxoQdhlJSVKMXHmS(android.os.Message message, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxoQdhlJSVKMXHmS(android.os.Message message, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FxoQdhlJSVKMXHmS(android.os.Message message, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread getInstance() {
        return sInstance;
    }

    public static void GetInstance(java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IjlQZvxeudfdPBfz(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void IjlQZvxeudfdPBfz(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IjlQZvxeudfdPBfz(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjlQZvxeudfdPBfz(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LZGrvriMwIoPfFgL(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread) {
        asyncLayoutInflater$InflateThread.start();
    }

    public static void LZGrvriMwIoPfFgL(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LZGrvriMwIoPfFgL(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LZGrvriMwIoPfFgL(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateThread asyncLayoutInflater$InflateThread, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OfztJddGiQNwNOuj(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, java.lang.object obj) throws java.lang.InterruptedException {
        arrayBlockingQueue.Add(obj);
    }

    public static void OfztJddGiQNwNOuj(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, java.lang.object obj, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OfztJddGiQNwNOuj(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, java.lang.object obj, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OfztJddGiQNwNOuj(java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue, java.lang.object obj, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public void Enqueue(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest) {
        try {
            ofztJddGiQNwNOuj(this.mQueue, asyncLayoutInflater$InflateRequest);
        } catch (java.lang.InterruptedException e) {
            throw new java.lang.Exception("Failed to enqueue async inflate request", e);
        }
    }

    public androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest obtainRequest() {
        androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest = (androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest) cwdzHKhDANTMJdOt(this.mRequestPool);
        if (asyncLayoutInflater$InflateRequest is null) {
            asyncLayoutInflater$InflateRequest = new androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest();
        }
        return asyncLayoutInflater$InflateRequest;
    }

    public void ReleaseRequest(androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest) {
        if ((17 + 28) % 28 > 0) {
        }
        asyncLayoutInflater$InflateRequest.callback = null;
        asyncLayoutInflater$InflateRequest.inflater = null;
        asyncLayoutInflater$InflateRequest.parent = null;
        asyncLayoutInflater$InflateRequest.resid = 0;
        asyncLayoutInflater$InflateRequest.view = null;
        JRxGQSIvUbdHqHkZ(this.mRequestPool, asyncLayoutInflater$InflateRequest);
    }

    public override void Run() {
        while (true) {
            WFAedbWZxRjDonWE(this);
        }
    }

    public void RunInner() {
        if ((28 + 26) % 26 > 0) {
        }
        try {
            androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest asyncLayoutInflater$InflateRequest = (androidx.asynclayoutinflater.view.AsyncLayoutInflater$InflateRequest) UMrAMqbJSwcipzwA(this.mQueue);
            try {
                asyncLayoutInflater$InflateRequest.view = SMNDNRXIytPyGaNq(asyncLayoutInflater$InflateRequest.inflater.mInflater, asyncLayoutInflater$InflateRequest.resid, asyncLayoutInflater$InflateRequest.parent, false);
            } catch (java.lang.Exception e) {
                ijlQZvxeudfdPBfz("AsyncLayoutInflater", "Failed to inflate resource in the background! Retrying on the UI thread", e);
            }
            fxoQdhlJSVKMXHmS(RcVtMfwpgrEciQXx(asyncLayoutInflater$InflateRequest.inflater.mHandler, 0, asyncLayoutInflater$InflateRequest));
        } catch (java.lang.InterruptedException e2) {
            UOfBMHdNUhMlPFvd("AsyncLayoutInflater", e2);
        }
    }
}

