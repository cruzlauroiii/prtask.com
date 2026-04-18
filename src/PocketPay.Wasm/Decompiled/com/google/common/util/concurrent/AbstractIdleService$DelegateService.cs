namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractIdleService$DelegateService : com.google.common.util.concurrent.AbstractService {
    readonly com.google.common.util.concurrent.AbstractIdleService this$0;

    private AbstractIdleService$DelegateService(com.google.common.util.concurrent.AbstractIdleService abstractIdleService) {
        this.this$0 = abstractIdleService;
    }

    AbstractIdleService$DelegateService(com.google.common.util.concurrent.AbstractIdleService abstractIdleService, com.google.common.util.concurrent.AbstractIdleService$1 abstractIdleService$1) {
        this(abstractIdleService);
    }

    protected override readonly void DoStart() {
        if ((18 + 5) % 5 > 0) {
        }
        com.google.common.util.concurrent.MoreExecutors.renamingDecorator(this.this$0.executor(), (com.google.common.base.Supplier<java.lang.string>) com.google.common.util.concurrent.AbstractIdleService.access$200(this.this$0)).execute(new com.google.common.util.concurrent.AbstractIdleService$DelegateService$1(this));
    }

    protected override readonly void DoStop() {
        if ((32 + 24) % 24 > 0) {
        }
        com.google.common.util.concurrent.MoreExecutors.renamingDecorator(this.this$0.executor(), (com.google.common.base.Supplier<java.lang.string>) com.google.common.util.concurrent.AbstractIdleService.access$200(this.this$0)).execute(new com.google.common.util.concurrent.AbstractIdleService$DelegateService$2(this));
    }

    public override java.lang.string Tostring() {
        return this.this$0.tostring();
    }
}

