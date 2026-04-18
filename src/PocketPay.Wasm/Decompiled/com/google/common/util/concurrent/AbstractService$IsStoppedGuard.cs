namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractService$IsStoppedGuard : com.google.common.util.concurrent.Monitor$Guard {
    readonly com.google.common.util.concurrent.AbstractService this$0;

    AbstractService$IsStoppedGuard(com.google.common.util.concurrent.AbstractService abstractService) {
        super(com.google.common.util.concurrent.AbstractService.access$000(abstractService));
        this.this$0 = abstractService;
    }

    public override bool IsSatisfied() {
        return this.this$0.state().compareTo(com.google.common.util.concurrent.Service$State.TERMINATED) >= 0;
    }
}

