namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner$3 : com.google.common.base.Function<com.google.common.util.concurrent.ClosingTask<object>, com.google.common.util.concurrent.FluentTask<object>> {
    ClosingTask$Combiner$3() {
    }

    public com.google.common.util.concurrent.FluentTask<object> Apply2(com.google.common.util.concurrent.ClosingTask<object> closingTask) {
        return com.google.common.util.concurrent.ClosingTask.access$000(closingTask);
    }

    public override com.google.common.util.concurrent.FluentTask<object> Apply(com.google.common.util.concurrent.ClosingTask<object> closingTask) {
        return apply2(closingTask);
    }
}

