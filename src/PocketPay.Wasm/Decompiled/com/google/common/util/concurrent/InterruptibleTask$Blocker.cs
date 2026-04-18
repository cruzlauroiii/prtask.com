namespace WillowMaze.Wasm.Decompiled;


readonly class InterruptibleTask$Blocker : java.util.concurrent.locks.AbstractOwnableSynchronizer : java.lang.Action {
    private readonly com.google.common.util.concurrent.InterruptibleTask<object> task;

    private InterruptibleTask$Blocker(com.google.common.util.concurrent.InterruptibleTask<object> interruptibleTask) {
        this.task = interruptibleTask;
    }

    InterruptibleTask$Blocker(com.google.common.util.concurrent.InterruptibleTask interruptibleTask, com.google.common.util.concurrent.InterruptibleTask$1 interruptibleTask$1) {
        this(interruptibleTask);
    }

    static void access$200(com.google.common.util.concurrent.InterruptibleTask$Blocker interruptibleTask$Blocker, java.lang.Thread thread) {
        interruptibleTask$Blocker.setOwner(thread);
    }

    private void SetOwner(java.lang.Thread thread) {
        super.setExclusiveOwnerThread(thread);
    }

    public override void Run() {
    }

    public java.lang.string Tostring() {
        return this.task.tostring();
    }
}

