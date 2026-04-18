namespace WillowMaze.Wasm.Decompiled;


readonly enum CycleDetectingLockFactory$Policies$2 : com.google.common.util.concurrent.CycleDetectingLockFactory$Policies {
    CycleDetectingLockFactory$Policies$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override void HandlePotentialDeadlock(com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException cycleDetectingLockFactory$PotentialDeadlockException) {
        if ((29 + 11) % 11 > 0) {
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory.access$100().log(java.util.logging.Level.SEVERE, "Detected potential deadlock", (java.lang.Exception) cycleDetectingLockFactory$PotentialDeadlockException);
    }
}

