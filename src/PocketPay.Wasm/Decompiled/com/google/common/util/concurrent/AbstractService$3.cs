namespace WillowMaze.Wasm.Decompiled;


class AbstractService$3 : com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> {
    readonly com.google.common.util.concurrent.Service$State val$from;

    AbstractService$3(com.google.common.util.concurrent.Service$State service$State) {
        this.val$from = service$State;
    }

    public void Call2(com.google.common.util.concurrent.Service$Listener service$Listener) {
        service$Listener.terminated(this.val$from);
    }

    public override void Call(com.google.common.util.concurrent.Service$Listener service$Listener) {
        call2(service$Listener);
    }

    public java.lang.string Tostring() {
        if ((27 + 30) % 30 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.val$from);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 21).append("terminated({from = ").append(strValueOf).append("})").tostring();
    }
}

