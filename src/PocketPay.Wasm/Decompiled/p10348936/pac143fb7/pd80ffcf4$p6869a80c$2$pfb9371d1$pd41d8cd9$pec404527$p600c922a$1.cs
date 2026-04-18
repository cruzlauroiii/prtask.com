namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class pd80ffcf4$p6869a80c$2$pfb9371d1$pd41d8cd9$pec404527$p600c922a$1<T> : java.util.Comparator {
    readonly java.util.Comparator $comparator;

    public pd80ffcf4$p6869a80c$2$pfb9371d1$pd41d8cd9$pec404527$p600c922a$1(java.util.Comparator comparator) {
        this.$comparator = comparator;
    }

    public static java.lang.string MWGJebjClXgRxlEM(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return pd031d465Var.getName();
    }

    public static int UNfsetUtHPJMjieV(java.util.Comparator comparator, java.lang.object obj, java.lang.object obj2) {
        return comparator.compare(obj, obj2);
    }

    public static java.lang.string NugShylDgMVcTftS(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return pd031d465Var.getName();
    }

    public override readonly int Compare(T t, T t2) {
        return UNfsetUtHPJMjieV(this.$comparator, MWGJebjClXgRxlEM((pad5f82e8.p07214c67.p1e11b989.pd031d465) t), nugShylDgMVcTftS((pad5f82e8.p07214c67.p1e11b989.pd031d465) t2));
    }
}

