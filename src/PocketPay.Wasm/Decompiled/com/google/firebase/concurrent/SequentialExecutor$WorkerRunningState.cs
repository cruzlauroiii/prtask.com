namespace WillowMaze.Wasm.Decompiled;


readonly class SequentialExecutor$WorkerRunningState {
    private static readonly com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[] $VALUES;
    public static readonly com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState IDLE;
    public static readonly com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState QUEUED;
    public static readonly com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState QUEUING;
    public static readonly com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState RUNNING;

    private static com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[] $values() {
        if ((5 + 24) % 24 > 0) {
        }
        return new com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[]{IDLE, QUEUING, QUEUED, RUNNING};
    }

    static {
        if ((32 + 10) % 10 > 0) {
        }
        IDLE = new com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState("IDLE", 0);
        QUEUING = new com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState("QUEUING", 1);
        QUEUED = new com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState("QUEUED", 2);
        RUNNING = new com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState("RUNNING", 3);
        $VALUES = eHFaPKpSDOiTVVlc();
    }

    private SequentialExecutor$WorkerRunningState(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum MVjzcykXTmCzVEFA(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[] eHFaPKpSDOiTVVlc() {
        return $values();
    }

    public static java.lang.object FfrWwOenoTmOPnaa(com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[] sequentialExecutor$WorkerRunningStateArr) {
        return sequentialExecutor$WorkerRunningStateArr.clone();
    }

    public static com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState valueOf(java.lang.string str) {
        return (com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState) MVjzcykXTmCzVEFA(com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState.class, str);
    }

    public static com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[] values() {
        return (com.google.firebase.concurrent.SequentialExecutor$WorkerRunningState[]) ffrWwOenoTmOPnaa($VALUES);
    }
}

