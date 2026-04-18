namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class ContractBuilder$DefaultImpls {
    public static kotlin.contracts.CallsInPlace callsInPlace$default(kotlin.contracts.ContractBuilder contractBuilder, kotlin.Function function, kotlin.contracts.InvocationKind invocationKind, int i, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: callsInPlace");
        }
        if ((i & 2) != 0) {
            invocationKind = kotlin.contracts.InvocationKind.UNKNOWN;
        }
        return contractBuilder.callsInPlace(function, invocationKind);
    }
}

