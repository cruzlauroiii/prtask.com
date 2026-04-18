namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "fileName", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MulticaststringObserver$Companion$observe$1$flowObserver$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.string, kotlin.Unit> {
    readonly kotlinx.coroutines.channels.ProducerScope<kotlin.Unit> $$this$channelFlow;
    readonly java.io.string $file;

    MulticaststringObserver$Companion$observe$1$flowObserver$1(java.io.string file, kotlinx.coroutines.channels.ProducerScope<kotlin.Unit> producerScope) {
        super(1);
        this.$file = file;
        this.$$this$channelFlow = producerScope;
    }

    public static java.lang.string FfVkKxzBqOVTjmaR(java.io.string file) {
        return file.getName();
    }

    public static java.lang.object FfWqyDDdTZMZlxix(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return kotlinx.coroutines.channels.ChannelsKt.trySendBlocking(sendChannel, obj);
    }

    public static void TpVocYvGzpcVrPtg(androidx.datastore.core.MulticaststringObserver$Companion$observe$1$flowObserver$1 multicaststringObserver$Companion$observe$1$flowObserver$1, java.lang.string str) {
        multicaststringObserver$Companion$observe$1$flowObserver$1.invoke2(str);
    }

    public static bool FjBofhUWzRJFJHZj(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public override kotlin.Unit Invoke(java.lang.string str) {
        TpVocYvGzpcVrPtg(this, str);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.string str) {
        if (fjBofhUWzRJFJHZj(str, FfVkKxzBqOVTjmaR(this.$file))) {
            FfWqyDDdTZMZlxix(this.$$this$channelFlow, kotlin.Unit.INSTANCE);
        }
    }
}

