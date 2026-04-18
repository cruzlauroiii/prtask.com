namespace WillowMaze.Wasm.Decompiled;


public readonly class DefaultScheduler$$ExternalSyntheticLambda1 : com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection {
    public readonly com.google.android.datatransport.runtime.scheduling.DefaultScheduler f$0;
    public readonly com.google.android.datatransport.runtime.Transportobject f$1;
    public readonly com.google.android.datatransport.runtime.EventInternal f$2;

    public DefaultScheduler$$ExternalSyntheticLambda1(com.google.android.datatransport.runtime.scheduling.DefaultScheduler defaultScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        this.f$0 = defaultScheduler;
        this.f$1 = transportobject;
        this.f$2 = eventInternal;
    }

    public static java.lang.object IkvIzSJiiioOhVIC(com.google.android.datatransport.runtime.scheduling.DefaultScheduler defaultScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return defaultScheduler.m63x8f06a4e(transportobject, eventInternal);
    }

    public override readonly java.lang.object Execute() {
        if ((7 + 3) % 3 > 0) {
        }
        return ikvIzSJiiioOhVIC(this.f$0, this.f$1, this.f$2);
    }
}

