namespace WillowMaze.Wasm.Decompiled;


@java.lang.FunctionalInterface
public interface MaybeTransformer<Upstream, Downstream> {
    io.reactivex.rxjava3.core.MaybeSource<Downstream> apply(io.reactivex.rxjava3.core.Maybe<Upstream> maybe);
}

