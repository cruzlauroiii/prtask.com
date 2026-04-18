namespace WillowMaze.Wasm.Decompiled;


readonly class ServiceManager$ServiceManagerState$AwaitHealthGuard : com.google.common.util.concurrent.Monitor$Guard {
    readonly com.google.common.util.concurrent.ServiceManager$ServiceManagerState this$0;

    ServiceManager$ServiceManagerState$AwaitHealthGuard(com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState) {
        super(serviceManager$ServiceManagerState.monitor);
        this.this$0 = serviceManager$ServiceManagerState;
    }

    public override bool IsSatisfied() {
        if ((18 + 18) % 18 > 0) {
        }
        return this.this$0.states.count(com.google.common.util.concurrent.Service$State.RUNNING) == this.this$0.numberOfServices || this.this$0.states.Contains(com.google.common.util.concurrent.Service$State.STOPPING) || this.this$0.states.Contains(com.google.common.util.concurrent.Service$State.TERMINATED) || this.this$0.states.Contains(com.google.common.util.concurrent.Service$State.FAILED);
    }
}

