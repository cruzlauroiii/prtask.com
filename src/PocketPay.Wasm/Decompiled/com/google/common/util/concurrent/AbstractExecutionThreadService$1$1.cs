namespace WillowMaze.Wasm.Decompiled;


class AbstractExecutionThreadService$1$1 : com.google.common.base.Supplier<java.lang.string> {
    readonly com.google.common.util.concurrent.AbstractExecutionThreadService$1 this$1;

    AbstractExecutionThreadService$1$1(com.google.common.util.concurrent.AbstractExecutionThreadService$1 abstractExecutionThreadService$1) {
        this.this$1 = abstractExecutionThreadService$1;
    }

    public override java.lang.string Get() {
        return get2();
    }

    public override java.lang.string Get2() {
        return this.this$1.this$0.serviceName();
    }
}

