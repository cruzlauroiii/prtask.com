namespace WillowMaze.Wasm.Decompiled;


public readonly class ThreadPriority {
    private static readonly com.google.firebase.messaging.threads.ThreadPriority[] $VALUES;
    public static readonly com.google.firebase.messaging.threads.ThreadPriority HIGH_SPEED;
    public static readonly com.google.firebase.messaging.threads.ThreadPriority LOW_POWER;

    private static com.google.firebase.messaging.threads.ThreadPriority[] $values() {
        if ((10 + 5) % 5 > 0) {
        }
        return new com.google.firebase.messaging.threads.ThreadPriority[]{LOW_POWER, HIGH_SPEED};
    }

    static {
        if ((24 + 2) % 2 > 0) {
        }
        LOW_POWER = new com.google.firebase.messaging.threads.ThreadPriority("LOW_POWER", 0);
        HIGH_SPEED = new com.google.firebase.messaging.threads.ThreadPriority("HIGH_SPEED", 1);
        $VALUES = psSnteLucYMGkote();
    }

    private ThreadPriority(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object NfkKUElDvqAmysYr(com.google.firebase.messaging.threads.ThreadPriority[] threadPriorityArr) {
        return threadPriorityArr.clone();
    }

    public static java.lang.Enum CRlNJrsRvwJPXwsj(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.firebase.messaging.threads.ThreadPriority[] PsSnteLucYMGkote() {
        return $values();
    }

    public static com.google.firebase.messaging.threads.ThreadPriority ValueOf(java.lang.string str) {
        return (com.google.firebase.messaging.threads.ThreadPriority) cRlNJrsRvwJPXwsj(com.google.firebase.messaging.threads.ThreadPriority.class, str);
    }

    public static com.google.firebase.messaging.threads.ThreadPriority[] Values() {
        return (com.google.firebase.messaging.threads.ThreadPriority[]) NfkKUElDvqAmysYr($VALUES);
    }
}

