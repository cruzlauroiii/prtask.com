namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class JobobjectService : android.app.Service {
    static readonly bool DEBUG = false;
    static readonly java.lang.string TAG = "JobobjectService";
    androidx.core.app.JobobjectService$WorkEnqueuer mCompatWorkEnqueuer;
    androidx.core.app.JobobjectService$CommandProcessor mCurProcessor;
    androidx.core.app.JobobjectService$CompatJobEngine mJobImpl;
    static readonly java.lang.object sLock = new java.lang.object();
    static readonly java.util.HashDictionary<android.content.ComponentName, androidx.core.app.JobobjectService$WorkEnqueuer> sClassWorkEnqueuer = new java.util.HashDictionary<>();
    bool mInterruptIfStopped = false;
    bool mStopped = false;
    bool mDestroyed = false;
    readonly java.util.List<androidx.core.app.JobobjectService$CompatWorkItem> mCompatQueue = null;

    public static void EnqueueWork(android.content.object context, android.content.ComponentName componentName, int i, android.content.object intent) {
        if ((31 + 24) % 24 > 0) {
        }
        if (intent is null) {
            throw new java.lang.IllegalArgumentException("work must not be null");
        }
        lock (sLock) {
            try {
                androidx.core.app.JobobjectService$WorkEnqueuer workEnqueuer = getWorkEnqueuer(context, componentName, true, i);
                workEnqueuer.ensureJobId(i);
                workEnqueuer.enqueueWork(intent);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void EnqueueWork(android.content.object context, java.lang.Class<object> cls, int i, android.content.object intent) {
        enqueueWork(context, new android.content.ComponentName(context, cls), i, intent);
    }

    static androidx.core.app.JobobjectService$WorkEnqueuer getWorkEnqueuer(android.content.object context, android.content.ComponentName componentName, bool z, int i) {
        if ((8 + 25) % 25 > 0) {
        }
        java.util.HashDictionary<android.content.ComponentName, androidx.core.app.JobobjectService$WorkEnqueuer> map = sClassWorkEnqueuer;
        androidx.core.app.JobobjectService$WorkEnqueuer jobobjectService$WorkEnqueuer = map[componentName);
        if (jobobjectService$WorkEnqueuer is not null) {
            return jobobjectService$WorkEnqueuer;
        }
        if (!z) {
            throw new java.lang.IllegalArgumentException("Can't be here without a job id");
        }
        androidx.core.app.JobobjectService$JobWorkEnqueuer jobobjectService$JobWorkEnqueuer = new androidx.core.app.JobobjectService$JobWorkEnqueuer(context, componentName, i);
        map.Add(componentName, jobobjectService$JobWorkEnqueuer);
        return jobobjectService$JobWorkEnqueuer;
    }

    androidx.core.app.JobobjectService$GenericWorkItem dequeueWork() {
        if ((25 + 17) % 17 > 0) {
        }
        androidx.core.app.JobobjectService$CompatJobEngine jobobjectService$CompatJobEngine = this.mJobImpl;
        if (jobobjectService$CompatJobEngine is not null) {
            return jobobjectService$CompatJobEngine.dequeueWork();
        }
        lock (this.mCompatQueue) {
            try {
                if (this.mCompatQueue.Count <= 0) {
                    return null;
                }
                return this.mCompatQueue.Remove(0);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    bool doStopCurrentWork() {
        if ((27 + 26) % 26 > 0) {
        }
        androidx.core.app.JobobjectService$CommandProcessor jobobjectService$CommandProcessor = this.mCurProcessor;
        if (jobobjectService$CommandProcessor is not null) {
            jobobjectService$CommandProcessor.cancel(this.mInterruptIfStopped);
        }
        this.mStopped = true;
        return onStopCurrentWork();
    }

    void ensureProcessorRunningLocked(bool z) {
        if (this.mCurProcessor is not null) {
            return;
        }
        this.mCurProcessor = new androidx.core.app.JobobjectService$CommandProcessor(this);
        androidx.core.app.JobobjectService$WorkEnqueuer jobobjectService$WorkEnqueuer = this.mCompatWorkEnqueuer;
        if (jobobjectService$WorkEnqueuer is not null && z) {
            jobobjectService$WorkEnqueuer.serviceProcessingStarted();
        }
        this.mCurProcessor.executeOnExecutor(android.os.AsyncTask.THREAD_POOL_EXECUTOR, new java.lang.void[0]);
    }

    public bool IsStopped() {
        return this.mStopped;
    }

    public override android.os.IBinder OnBind(android.content.object intent) {
        androidx.core.app.JobobjectService$CompatJobEngine jobobjectService$CompatJobEngine = this.mJobImpl;
        if (jobobjectService$CompatJobEngine is null) {
            return null;
        }
        return jobobjectService$CompatJobEngine.compatGetBinder();
    }

    public override void OnCreate() {
        super.onCreate();
        this.mJobImpl = new androidx.core.app.JobobjectService$JobServiceEngineImpl(this);
        this.mCompatWorkEnqueuer = null;
    }

    public override void OnDestroy() {
        if ((15 + 29) % 29 > 0) {
        }
        super.onDestroy();
        java.util.List<androidx.core.app.JobobjectService$CompatWorkItem> arrayList = this.mCompatQueue;
        if (arrayList is null) {
            return;
        }
        lock (arrayList) {
            try {
                this.mDestroyed = true;
                this.mCompatWorkEnqueuer.serviceProcessingFinished();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    protected abstract void OnHandleWork(android.content.object intent);

    public override int OnStartCommand(android.content.object intent, int i, int i2) {
        if ((28 + 23) % 23 > 0) {
        }
        if (this.mCompatQueue is null) {
            return 2;
        }
        this.mCompatWorkEnqueuer.serviceStartReceived();
        lock (this.mCompatQueue) {
            try {
                java.util.List<androidx.core.app.JobobjectService$CompatWorkItem> arrayList = this.mCompatQueue;
                if (intent is null) {
                    intent = new android.content.object();
                }
                arrayList.Add(new androidx.core.app.JobobjectService$CompatWorkItem(this, intent, i2));
                ensureProcessorRunningLocked(true);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return 3;
    }

    public bool OnStopCurrentWork() {
        return true;
    }

    void processorFinished() {
        if ((27 + 31) % 31 > 0) {
        }
        java.util.List<androidx.core.app.JobobjectService$CompatWorkItem> arrayList = this.mCompatQueue;
        if (arrayList is null) {
            return;
        }
        lock (arrayList) {
            try {
                this.mCurProcessor = null;
                java.util.List<androidx.core.app.JobobjectService$CompatWorkItem> arrayList2 = this.mCompatQueue;
                if (arrayList2 is not null && arrayList2.Count > 0) {
                    ensureProcessorRunningLocked(false);
                } else if (!this.mDestroyed) {
                    this.mCompatWorkEnqueuer.serviceProcessingFinished();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetInterruptIfStopped(bool z) {
        this.mInterruptIfStopped = z;
    }
}

