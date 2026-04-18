namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p5c6338ce$p4d4a2367$2$1 : p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 {
    readonly kotlin.coroutines.Continuation<java.lang.bool> $continuation;

    p5c6338ce$p4d4a2367$2$1(kotlin.coroutines.Continuation<java.lang.bool> continuation) {
        this.$continuation = continuation;
    }

    public override readonly void OnResult(java.lang.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        kotlin.coroutines.Continuation<java.lang.bool> continuation = this.$continuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        continuation.resumeWith(kotlin.Result.m948constructorimpl(true));
    }
}

