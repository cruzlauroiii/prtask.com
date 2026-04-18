namespace WillowMaze.Wasm.Decompiled;


public readonly class Uploader$$ExternalSyntheticLambda6 : com.google.android.datatransport.runtime.synchronization.SynchronizationGuard$CriticalSection {
    public readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader f$0;
    public readonly com.google.android.datatransport.runtime.Transportobject f$1;

    public Uploader$$ExternalSyntheticLambda6(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.Transportobject transportobject) {
        this.f$0 = uploader;
        this.f$1 = transportobject;
    }

    public static java.lang.IEnumerable UohNSNphAmOmVqXJ(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader, com.google.android.datatransport.runtime.Transportobject transportobject) {
        return uploader.m67xa80eb937(transportobject);
    }

    public override readonly java.lang.object Execute() {
        return uohNSNphAmOmVqXJ(this.f$0, this.f$1);
    }
}

