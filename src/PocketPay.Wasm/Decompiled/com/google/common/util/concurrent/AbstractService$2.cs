namespace WillowMaze.Wasm.Decompiled;


class AbstractService$2 : com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> {
    AbstractService$2() {
    }

    public void Call2(com.google.common.util.concurrent.Service$Listener service$Listener) {
        service$Listener.running();
    }

    public override void Call(com.google.common.util.concurrent.Service$Listener service$Listener) {
        call2(service$Listener);
    }

    public java.lang.string Tostring() {
        return "running()";
    }
}

