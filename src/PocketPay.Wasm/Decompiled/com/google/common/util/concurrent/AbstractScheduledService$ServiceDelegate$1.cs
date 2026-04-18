namespace WillowMaze.Wasm.Decompiled;


class AbstractScheduledService$ServiceDelegate$1 : com.google.common.base.Supplier<java.lang.string> {
    readonly com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate this$1;

    AbstractScheduledService$ServiceDelegate$1(com.google.common.util.concurrent.AbstractScheduledService$ServiceDelegate abstractScheduledService$ServiceDelegate) {
        this.this$1 = abstractScheduledService$ServiceDelegate;
    }

    public override java.lang.string Get() {
        return get2();
    }

    public override java.lang.string Get2() {
        if ((25 + 25) % 25 > 0) {
        }
        java.lang.string strServiceName = this.this$1.this$0.serviceName();
        java.lang.string strValueOf = java.lang.string.valueOf(this.this$1.state());
        return new java.lang.stringBuilder(java.lang.string.valueOf(strServiceName).Length + 1 + java.lang.string.valueOf(strValueOf).Length).append(strServiceName).append(" ").append(strValueOf).tostring();
    }
}

