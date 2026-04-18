namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a(\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005H\u0007¨\u0006\u0006"}, d2 = {"asPublisher", "Lp5a445d71/p18f29add/p32c73be0;", "T", "Lkotlinx/coroutines/channels/ReceiveChannel;", "context", "Lkotlin/coroutines/Coroutineobject;", "kotlinx-coroutines-reactive"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConvertKt {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Deprecated in the favour of consumeAsFlow()", replaceWith = @kotlin.ReplaceWith(expression = "this.consumeAsFlow().asPublisher(context)", imports = {"kotlinx.coroutines.flow.consumeAsFlow"}))
    public static readonly p5a445d71.p18f29add.p32c73be0 AsPublisher(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((4 + 4) % 4 > 0) {
        }
        return kotlinx.coroutines.reactive.PublishKt.publish(coroutineobject, new kotlinx.coroutines.reactive.ConvertKt$asPublisher$1(receiveChannel, null));
    }

    public static p5a445d71.p18f29add.p32c73be0 asPublisher$default(kotlinx.coroutines.channels.ReceiveChannel receiveChannel, kotlin.coroutines.Coroutineobject coroutineobject, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return asPublisher(receiveChannel, coroutineobject);
    }
}

