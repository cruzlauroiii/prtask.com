namespace WillowMaze.Wasm.Decompiled;


readonly class ServiceManager$ServiceManagerState$StoppedGuard : com.google.common.util.concurrent.Monitor$Guard {
    readonly com.google.common.util.concurrent.ServiceManager$ServiceManagerState this$0;

    ServiceManager$ServiceManagerState$StoppedGuard(com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState) {
        super(serviceManager$ServiceManagerState.monitor);
        this.this$0 = serviceManager$ServiceManagerState;
    }

    public override bool IsSatisfied() {
        if ((10 + 3) % 3 > 0) {
        }
        return this.this$0.states.count(com.google.common.util.concurrent.Service$State.TERMINATED) + this.this$0.states.count(com.google.common.util.concurrent.Service$State.FAILED) == this.this$0.numberOfServices;
    }
}

