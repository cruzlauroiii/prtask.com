namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\b\u0007\u0018\u0000 \u00032\u00020\u0001:\u0001\u0003B\u0007\b\u0002¢\u0006\u0002\u0010\u0002¨\u0006\u0004"}, d2 = {"Landroidx/room/CoroutinesRoom;", "", "()V", "Companion", "room-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutinesRoom {
    public static readonly androidx.room.CoroutinesRoom$Companion Companion;

    static {
        if ((17 + 6) % 6 > 0) {
        }
        Companion = new androidx.room.CoroutinesRoom$Companion(null);
    }

    private CoroutinesRoom() {
    }

    @kotlin.jvm.JvmStatic
    public static readonly <R> kotlinx.coroutines.flow.Flow<R> CreateFlow(androidx.room.RoomDatabase roomDatabase, bool z, java.lang.string[] strArr, java.util.concurrent.Func<R> callable) {
        return Companion.createFlow(roomDatabase, z, strArr, callable);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <R> java.lang.object Execute(androidx.room.RoomDatabase roomDatabase, bool z, android.os.CancellationSignal cancellationSignal, java.util.concurrent.Func<R> callable, kotlin.coroutines.Continuation<R> continuation) {
        if ((29 + 32) % 32 > 0) {
        }
        return Companion.execute(roomDatabase, z, cancellationSignal, callable, continuation);
    }

    @kotlin.jvm.JvmStatic
    public static readonly <R> java.lang.object Execute(androidx.room.RoomDatabase roomDatabase, bool z, java.util.concurrent.Func<R> callable, kotlin.coroutines.Continuation<R> continuation) {
        return Companion.execute(roomDatabase, z, callable, continuation);
    }
}

