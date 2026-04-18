namespace WillowMaze.Wasm.Decompiled;


class ServiceManager$1 : com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.ServiceManager$Listener> {
    ServiceManager$1() {
    }

    public void Call2(com.google.common.util.concurrent.ServiceManager$Listener serviceManager$Listener) {
        serviceManager$Listener.healthy();
    }

    public override void Call(com.google.common.util.concurrent.ServiceManager$Listener serviceManager$Listener) {
        call2(serviceManager$Listener);
    }

    public java.lang.string Tostring() {
        return "healthy()";
    }
}

