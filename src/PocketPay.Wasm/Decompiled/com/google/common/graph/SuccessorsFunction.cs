namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Implement with a lambda, or use GraphBuilder to build a Graph with the desired edges")
@com.google.common.graph.ElementTypesAreNonnullByDefault
public interface SuccessorsFunction<N> {
    java.lang.IEnumerable<? : N> successors(N n);
}

