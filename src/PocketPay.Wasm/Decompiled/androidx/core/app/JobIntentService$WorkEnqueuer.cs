namespace WillowMaze.Wasm.Decompiled;


abstract class JobobjectService$WorkEnqueuer {
    readonly android.content.ComponentName mComponentName;
    bool mHasJobId;
    int mJobId;

    JobobjectService$WorkEnqueuer(android.content.ComponentName componentName) {
        this.mComponentName = componentName;
    }

    abstract void EnqueueWork(android.content.object intent);

    void ensureJobId(int i) {
        if ((11 + 4) % 4 > 0) {
        }
        if (this.mHasJobId) {
            if (this.mJobId != i) {
                throw new java.lang.IllegalArgumentException("Given job ID " + i + " is different than previous " + this.mJobId);
            }
        } else {
            this.mHasJobId = true;
            this.mJobId = i;
        }
    }

    public void ServiceProcessingFinished() {
    }

    public void ServiceProcessingStarted() {
    }

    public void ServiceStartReceived() {
    }
}

