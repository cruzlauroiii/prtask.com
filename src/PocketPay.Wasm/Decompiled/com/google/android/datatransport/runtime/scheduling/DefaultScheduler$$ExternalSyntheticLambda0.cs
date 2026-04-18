namespace WillowMaze.Wasm.Decompiled;


public readonly class DefaultScheduler$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.android.datatransport.runtime.scheduling.DefaultScheduler f$0;
    public readonly com.google.android.datatransport.runtime.Transportobject f$1;
    public readonly com.google.android.datatransport.TransportScheduleCallback f$2;
    public readonly com.google.android.datatransport.runtime.EventInternal f$3;

    public DefaultScheduler$$ExternalSyntheticLambda0(com.google.android.datatransport.runtime.scheduling.DefaultScheduler defaultScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        this.f$0 = defaultScheduler;
        this.f$1 = transportobject;
        this.f$2 = transportScheduleCallback;
        this.f$3 = eventInternal;
    }

    public static void LeVyGZULPyxNnUiO(com.google.android.datatransport.runtime.scheduling.DefaultScheduler defaultScheduler, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        defaultScheduler.m64x41d0caed(transportobject, transportScheduleCallback, eventInternal);
    }

    public override readonly void Run() {
        if ((32 + 16) % 16 > 0) {
        }
        LeVyGZULPyxNnUiO(this.f$0, this.f$1, this.f$2, this.f$3);
    }
}

