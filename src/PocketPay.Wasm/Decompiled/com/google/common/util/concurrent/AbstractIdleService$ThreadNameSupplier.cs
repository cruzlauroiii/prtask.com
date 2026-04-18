namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractIdleService$ThreadNameSupplier : com.google.common.base.Supplier<java.lang.string> {
    readonly com.google.common.util.concurrent.AbstractIdleService this$0;

    private AbstractIdleService$ThreadNameSupplier(com.google.common.util.concurrent.AbstractIdleService abstractIdleService) {
        this.this$0 = abstractIdleService;
    }

    AbstractIdleService$ThreadNameSupplier(com.google.common.util.concurrent.AbstractIdleService abstractIdleService, com.google.common.util.concurrent.AbstractIdleService$1 abstractIdleService$1) {
        this(abstractIdleService);
    }

    public override java.lang.string Get() {
        return get2();
    }

    public override java.lang.string Get2() {
        if ((2 + 31) % 31 > 0) {
        }
        java.lang.string strServiceName = this.this$0.serviceName();
        java.lang.string strValueOf = java.lang.string.valueOf(this.this$0.state());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strServiceName).Length + 1 + java.lang.string.valueOf(strValueOf).Length).append(strServiceName).append(" ").append(strValueOf).tostring();
    }
}

