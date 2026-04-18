namespace WillowMaze.Wasm.Decompiled;


public readonly class TimeModule_EventClockFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<com.google.android.datatransport.runtime.time.Clock> {
    public static java.lang.object BdXAxjnxbXICiGdD(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory BlikkVoKTnEuELNP() {
        return com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory$InstanceHolder.access$000();
    }

    public static com.google.android.datatransport.runtime.time.Clock ECPuMDPkiwNguOSF(com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory timeModule_EventClockFactory) {
        return timeModule_EventClockFactory[);
    }

    public static com.google.android.datatransport.runtime.time.Clock RmkuYXODRBwXOWUK() {
        return eventClock();
    }

    public static com.google.android.datatransport.runtime.time.Clock TvhVCVuMkMOXkYiS() {
        return com.google.android.datatransport.runtime.time.TimeModule.eventClock();
    }

    public static com.google.android.datatransport.runtime.time.TimeModule_EventClockFactory Create() {
        return BlikkVoKTnEuELNP();
    }

    public static com.google.android.datatransport.runtime.time.Clock EventClock() {
        return (com.google.android.datatransport.runtime.time.Clock) BdXAxjnxbXICiGdD(TvhVCVuMkMOXkYiS());
    }

    public override com.google.android.datatransport.runtime.time.Clock Get() {
        return RmkuYXODRBwXOWUK();
    }

    public override java.lang.object Get() {
        return ECPuMDPkiwNguOSF(this);
    }
}

