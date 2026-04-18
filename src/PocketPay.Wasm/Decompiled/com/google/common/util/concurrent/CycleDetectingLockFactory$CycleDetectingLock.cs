namespace WillowMaze.Wasm.Decompiled;


interface CycleDetectingLockFactory$CycleDetectingLock {
    com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode getLockGraphNode();

    bool isAcquiredByCurrentThread();
}

