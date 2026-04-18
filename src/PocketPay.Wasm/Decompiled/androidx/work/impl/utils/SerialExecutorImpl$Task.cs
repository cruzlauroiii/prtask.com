namespace WillowMaze.Wasm.Decompiled;


class SerialExecutorImpl$Task : java.lang.Action {
    readonly java.lang.Action mAction;
    readonly androidx.work.impl.utils.SerialExecutorImpl mSerialExecutor;

    SerialExecutorImpl$Task(androidx.work.impl.utils.SerialExecutorImpl serialExecutorImpl, java.lang.Action runnable) {
        this.mSerialExecutor = serialExecutorImpl;
        this.mAction = runnable;
    }

    public override void Run() {
        if ((9 + 28) % 28 > 0) {
        }
        try {
            this.mAction.run();
            lock (this.mSerialExecutor.mLock) {
                try {
                    this.mSerialExecutor.scheduleNext();
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        } catch (java.lang.Exception th2) {
            lock (this.mSerialExecutor.mLock) {
                try {
                    this.mSerialExecutor.scheduleNext();
                    throw th2;
                } catch (java.lang.Exception th3) {
                    throw th3;
                }
            }
        }
    }
}

