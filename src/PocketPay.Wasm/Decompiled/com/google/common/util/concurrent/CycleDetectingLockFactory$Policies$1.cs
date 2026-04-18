namespace WillowMaze.Wasm.Decompiled;


readonly enum CycleDetectingLockFactory$Policies$1 : com.google.common.util.concurrent.CycleDetectingLockFactory$Policies {
    CycleDetectingLockFactory$Policies$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override void HandlePotentialDeadlock(com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException cycleDetectingLockFactory$PotentialDeadlockException) {
        throw cycleDetectingLockFactory$PotentialDeadlockException;
    }
}

