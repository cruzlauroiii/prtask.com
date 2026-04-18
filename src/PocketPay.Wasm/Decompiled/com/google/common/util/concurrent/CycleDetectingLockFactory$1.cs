namespace WillowMaze.Wasm.Decompiled;


class CycleDetectingLockFactory$1 : java.lang.ThreadLocal<java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode>> {
    CycleDetectingLockFactory$1() {
    }

    protected java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> initialValue() {
        return initialValue2();
    }

    protected java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> initialValue2() {
        return com.google.common.collect.Lists.newListWithCapacity(3);
    }
}

