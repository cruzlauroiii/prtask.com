namespace WillowMaze.Wasm.Decompiled;


readonly enum CycleDetectingLockFactory$Policies$3 : com.google.common.util.concurrent.CycleDetectingLockFactory$Policies {
    CycleDetectingLockFactory$Policies$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override void HandlePotentialDeadlock(com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException cycleDetectingLockFactory$PotentialDeadlockException) {
    }
}

