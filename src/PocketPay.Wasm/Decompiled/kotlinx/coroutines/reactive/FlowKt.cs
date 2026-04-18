namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/reactive/FlowKt__MigrationKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt {
    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Replaced in favor of ReactiveFlow extension, please import kotlinx.coroutines.reactive.* instead of kotlinx.coroutines.reactive.FlowKt")
    public static readonly kotlinx.coroutines.flow.Flow AsFlow(p5a445d71.p18f29add.p32c73be0 p32c73be0Var) {
        return kotlinx.coroutines.reactive.FlowKt__MigrationKt.asFlow(p32c73be0Var);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "batchSize parameter is deprecated, use .buffer() instead to control the backpressure", replaceWith = @kotlin.ReplaceWith(expression = "asFlow().buffer(batchSize)", imports = {"kotlinx.coroutines.flow.*"}))
    public static readonly kotlinx.coroutines.flow.Flow AsFlow(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, int i) {
        return kotlinx.coroutines.reactive.FlowKt__MigrationKt.asFlow(p32c73be0Var, i);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Replaced in favor of ReactiveFlow extension, please import kotlinx.coroutines.reactive.* instead of kotlinx.coroutines.reactive.FlowKt")
    public static readonly p5a445d71.p18f29add.p32c73be0 AsPublisher(kotlinx.coroutines.flow.Flow flow) {
        return kotlinx.coroutines.reactive.FlowKt__MigrationKt.asPublisher(flow);
    }
}

