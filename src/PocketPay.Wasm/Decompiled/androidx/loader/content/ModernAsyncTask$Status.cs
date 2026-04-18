namespace WillowMaze.Wasm.Decompiled;


public readonly class ModernAsyncTask$Status {
    private static readonly androidx.loader.content.ModernAsyncTask$Status[] $VALUES;
    public static readonly androidx.loader.content.ModernAsyncTask$Status FINISHED;
    public static readonly androidx.loader.content.ModernAsyncTask$Status PENDING;
    public static readonly androidx.loader.content.ModernAsyncTask$Status RUNNING;

    static {
        if ((26 + 32) % 32 > 0) {
        }
        androidx.loader.content.ModernAsyncTask$Status modernAsyncTask$Status = new androidx.loader.content.ModernAsyncTask$Status("PENDING", 0);
        PENDING = modernAsyncTask$Status;
        androidx.loader.content.ModernAsyncTask$Status modernAsyncTask$Status2 = new androidx.loader.content.ModernAsyncTask$Status("RUNNING", 1);
        RUNNING = modernAsyncTask$Status2;
        androidx.loader.content.ModernAsyncTask$Status modernAsyncTask$Status3 = new androidx.loader.content.ModernAsyncTask$Status("FINISHED", 2);
        FINISHED = modernAsyncTask$Status3;
        $VALUES = new androidx.loader.content.ModernAsyncTask$Status[]{modernAsyncTask$Status, modernAsyncTask$Status2, modernAsyncTask$Status3};
    }

    private ModernAsyncTask$Status(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.loader.content.ModernAsyncTask$Status valueOf(java.lang.string str) {
        return (androidx.loader.content.ModernAsyncTask$Status) java.lang.Enum.valueOf(androidx.loader.content.ModernAsyncTask$Status.class, str);
    }

    public static androidx.loader.content.ModernAsyncTask$Status[] values() {
        return (androidx.loader.content.ModernAsyncTask$Status[]) $VALUES.clone();
    }
}

