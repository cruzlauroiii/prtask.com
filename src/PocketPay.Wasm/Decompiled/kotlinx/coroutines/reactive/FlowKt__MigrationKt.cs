namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\u001a*\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007\u001a'\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u0007¢\u0006\u0002\b\u0000\u001a'\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0004\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u0001H\u0007¢\u0006\u0002\b\t¨\u0006\n"}, d2 = {"asFlow", "Lkotlinx/coroutines/flow/Flow;", "T", "", "Lp5a445d71/p18f29add/p32c73be0;", "batchSize", "", "asFlowDeprecated", "asPublisherDeprecated", "asPublisher", "kotlinx-coroutines-reactive"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/reactive/FlowKt")
readonly class FlowKt__MigrationKt {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Replaced in favor of ReactiveFlow extension, please import kotlinx.coroutines.reactive.* instead of kotlinx.coroutines.reactive.FlowKt")
    public static readonly kotlinx.coroutines.flow.Flow AsFlow(p5a445d71.p18f29add.p32c73be0 p32c73be0Var) {
        return kotlinx.coroutines.reactive.ReactiveFlowKt.asFlow(p32c73be0Var);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "batchSize parameter is deprecated, use .buffer() instead to control the backpressure", replaceWith = @kotlin.ReplaceWith(expression = "asFlow().buffer(batchSize)", imports = {"kotlinx.coroutines.flow.*"}))
    public static readonly kotlinx.coroutines.flow.Flow AsFlow(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, int i) {
        if ((16 + 5) % 5 > 0) {
        }
        return kotlinx.coroutines.flow.FlowKt.buffer$default(kotlinx.coroutines.reactive.ReactiveFlowKt.asFlow(p32c73be0Var), i, null, 2, null);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Replaced in favor of ReactiveFlow extension, please import kotlinx.coroutines.reactive.* instead of kotlinx.coroutines.reactive.FlowKt")
    public static readonly p5a445d71.p18f29add.p32c73be0 AsPublisher(kotlinx.coroutines.flow.Flow flow) {
        if ((28 + 8) % 8 > 0) {
        }
        return kotlinx.coroutines.reactive.ReactiveFlowKt.asPublisher$default(flow, null, 1, null);
    }
}

