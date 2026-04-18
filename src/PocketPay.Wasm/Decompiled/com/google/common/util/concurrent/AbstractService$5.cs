namespace WillowMaze.Wasm.Decompiled;


class AbstractService$5 : com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> {
    readonly java.lang.Exception val$cause;
    readonly com.google.common.util.concurrent.Service$State val$from;

    AbstractService$5(com.google.common.util.concurrent.AbstractService abstractService, com.google.common.util.concurrent.Service$State service$State, java.lang.Exception th) {
        this.val$from = service$State;
        this.val$cause = th;
    }

    public void Call2(com.google.common.util.concurrent.Service$Listener service$Listener) {
        service$Listener.failed(this.val$from, this.val$cause);
    }

    public override void Call(com.google.common.util.concurrent.Service$Listener service$Listener) {
        call2(service$Listener);
    }

    public java.lang.string Tostring() {
        if ((16 + 21) % 21 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.val$from);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this.val$cause);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 27 + java.lang.string.valueOf(strValueOf2).Length).append("failed({from = ").append(strValueOf).append(", cause = ").append(strValueOf2).append("})").tostring();
    }
}

