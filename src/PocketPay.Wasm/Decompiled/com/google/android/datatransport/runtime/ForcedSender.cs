namespace WillowMaze.Wasm.Decompiled;


public readonly class ForcedSender {
    private static readonly java.lang.string LOG_TAG = "ForcedSender";

    private ForcedSender() {
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse JOYqgkVmnjZuITjS(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.Transportobject transportobject, int i) {
        return uploader.logAndUpdateState(transportobject, i);
    }

    public static com.google.android.datatransport.runtime.TransportRuntime NjCxQTZgLIsLsnMi() {
        return com.google.android.datatransport.runtime.TransportRuntime.getInstance();
    }

    public static void ZdLiatKlJytaXrAs(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        com.google.android.datatransport.runtime.logging.Consoleging.m62w(str, str2, obj);
    }

    public static com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader AwyuEPSUFCJGlfSp(com.google.android.datatransport.runtime.TransportRuntime transportRuntime) {
        return transportRuntime.getUploader();
    }

    public static void SendBlocking(com.google.android.datatransport.Transport<object> transport, com.google.android.datatransport.Priority priority) {
        if (!(transport is com.google.android.datatransport.runtime.TransportImpl)) {
            ZdLiatKlJytaXrAs("ForcedSender", "Expected instance of `TransportImpl`, got `%s`.", transport);
        } else {
            JOYqgkVmnjZuITjS(awyuEPSUFCJGlfSp(NjCxQTZgLIsLsnMi()), vBobXKnlwnIphtuG(skjOCllUHKnHnzZe((com.google.android.datatransport.runtime.TransportImpl) transport), priority), 1);
        }
    }

    public static com.google.android.datatransport.runtime.Transportobject SkjOCllUHKnHnzZe(com.google.android.datatransport.runtime.TransportImpl transportImpl) {
        return transportImpl.getTransportobject();
    }

    public static com.google.android.datatransport.runtime.Transportobject VBobXKnlwnIphtuG(com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.Priority priority) {
        return transportobject.withPriority(priority);
    }
}

