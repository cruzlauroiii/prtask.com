namespace WillowMaze.Wasm.Decompiled;


readonly class PausableScheduledTaskSchedulerImpl : com.google.firebase.concurrent.DelegatingScheduledTaskScheduler : com.google.firebase.concurrent.PausableScheduledTaskScheduler {
    private readonly com.google.firebase.concurrent.PausableTaskScheduler delegate;

    PausableScheduledTaskSchedulerImpl(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        super(pausableTaskScheduler, scheduledTaskScheduler);
        this.delegate = pausableTaskScheduler;
    }

    public static void IzUExpWRhhfXpVIe(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler) {
        pausableTaskScheduler.pause();
    }

    public static void IzUExpWRhhfXpVIe(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IzUExpWRhhfXpVIe(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzUExpWRhhfXpVIe(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BPtZWWBtyocKirzL(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler) {
        pausableTaskScheduler.resume();
    }

    public static void BPtZWWBtyocKirzL(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPtZWWBtyocKirzL(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BPtZWWBtyocKirzL(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSlZWNNVxboMwNcF(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CSlZWNNVxboMwNcF(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CSlZWNNVxboMwNcF(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CSlZWNNVxboMwNcF(com.google.firebase.concurrent.PausableTaskScheduler pausableTaskScheduler) {
        return pausableTaskScheduler.isPaused();
    }

    public override bool IsPaused() {
        return cSlZWNNVxboMwNcF(this.delegate);
    }

    public override void Pause() {
        IzUExpWRhhfXpVIe(this.delegate);
    }

    public override void Resume() {
        bPtZWWBtyocKirzL(this.delegate);
    }

    public override java.util.concurrent.ScheduledTask<object> ScheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.util.concurrent.ScheduledTask<object> ScheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException();
    }
}

