namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Lp7ddcfee1/pd64ed3e9;", "chain", "Lp7ddcfee1/p06050a91$p53205501;", "intercept"}, m527k = 3, mv = {1, 6, 0}, xi = 176)
public readonly class p1cda7fcc$p2bd4a59b$pc1d4d9f5$2 : p7ddcfee1.p06050a91 {
    readonly kotlin.jvm.functions.Function1<p7ddcfee1.p06050a91$p53205501, p7ddcfee1.pd64ed3e9> $block;

    public p1cda7fcc$p2bd4a59b$pc1d4d9f5$2(kotlin.jvm.functions.Function1<? super p7ddcfee1.p06050a91$p53205501, p7ddcfee1.pd64ed3e9> function1) {
        this.$block = function1;
    }

    public override readonly p7ddcfee1.pd64ed3e9 Intercept(p7ddcfee1.p06050a91$p53205501 chain) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        return this.$block.invoke(chain);
    }
}

