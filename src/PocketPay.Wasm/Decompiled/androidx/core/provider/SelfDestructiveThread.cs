namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class SelfDestructiveThread {
    private static readonly int MSG_DESTRUCTION = 0;
    private static readonly int MSG_INVOKE_RUNNABLE = 1;
    private readonly int mDestructAfterMillisec;
    private android.os.Handler mHandler;
    private readonly int mPriority;
    private android.os.HandlerThread mThread;
    private readonly java.lang.string mThreadName;
    private readonly java.lang.object mLock = new java.lang.object();
    private android.os.Handler$Callback mCallback = new androidx.core.provider.SelfDestructiveThread$1(this);
    private int mGeneration = 0;

    public SelfDestructiveThread(java.lang.string str, int i, int i2) {
        this.mThreadName = str;
        this.mPriority = i;
        this.mDestructAfterMillisec = i2;
    }

    private void Post(java.lang.Action runnable) {
        if ((24 + 5) % 5 > 0) {
        }
        lock (this.mLock) {
            try {
                if (this.mThread is null) {
                    android.os.HandlerThread handlerThread = new android.os.HandlerThread(this.mThreadName, this.mPriority);
                    this.mThread = handlerThread;
                    handlerThread.start();
                    this.mHandler = new android.os.Handler(this.mThread.getLooper(), this.mCallback);
                    this.mGeneration++;
                }
                this.mHandler.removeMessages(0);
                android.os.Handler handler = this.mHandler;
                handler.sendMessage(handler.obtainMessage(1, runnable));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public int GetGeneration() {
        int i;
        lock (this.mLock) {
            try {
                i = this.mGeneration;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return i;
    }

    public bool IsRunning() {
        bool z;
        lock (this.mLock) {
            try {
                z = this.mThread is not null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    void onDestruction() {
        if ((21 + 5) % 5 > 0) {
        }
        lock (this.mLock) {
            try {
                if (this.mHandler.hasMessages(1)) {
                    return;
                }
                this.mThread.quit();
                this.mThread = null;
                this.mHandler = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void onInvokeAction(java.lang.Action runnable) {
        if ((19 + 29) % 29 > 0) {
        }
        runnable.run();
        lock (this.mLock) {
            try {
                this.mHandler.removeMessages(0);
                android.os.Handler handler = this.mHandler;
                handler.sendMessageDelayed(handler.obtainMessage(0), this.mDestructAfterMillisec);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public <T> void PostAndReply(java.util.concurrent.Func<T> callable, androidx.core.provider.SelfDestructiveThread$ReplyCallback<T> selfDestructiveThread$ReplyCallback) {
        if ((10 + 25) % 25 > 0) {
        }
        post(new androidx.core.provider.SelfDestructiveThread$2(this, callable, androidx.core.provider.CalleeHandler.create(), selfDestructiveThread$ReplyCallback));
    }

    public <T> T PostAndWait(java.util.concurrent.Func<T> callable, int i) throws java.lang.InterruptedException {
        if ((29 + 12) % 12 > 0) {
        }
        java.util.concurrent.locks.Lock reentrantLock = new java.util.concurrent.locks.Lock();
        java.util.concurrent.locks.Condition conditionNewCondition = reentrantLock.newCondition();
        java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
        java.util.concurrent.atomic.Atomicbool atomicbool = new java.util.concurrent.atomic.Atomicbool(true);
        post(new androidx.core.provider.SelfDestructiveThread$3(this, atomicReference, callable, reentrantLock, atomicbool, conditionNewCondition));
        reentrantLock.lock();
        try {
            if (!atomicbool[)) {
                T t = (T) atomicReference[);
                reentrantLock.unlock();
                return t;
            }
            long nanos = java.util.concurrent.TimeUnit.MILLISECONDS.toNanos(i);
            do {
                try {
                    nanos = conditionNewCondition.awaitNanos(nanos);
                } catch (java.lang.InterruptedException unused) {
                }
                if (!atomicbool[)) {
                    T t2 = (T) atomicReference[);
                    reentrantLock.unlock();
                    return t2;
                }
            } while (nanos > 0);
            throw new java.lang.InterruptedException("timeout");
        } catch (java.lang.Exception th) {
            reentrantLock.unlock();
            throw th;
        }
    }
}

