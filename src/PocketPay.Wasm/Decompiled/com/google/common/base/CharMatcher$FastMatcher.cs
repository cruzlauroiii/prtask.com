namespace WillowMaze.Wasm.Decompiled;


abstract class CharMatch$FastMatch : com.google.common.base.CharMatch {
    CharMatch$FastMatch() {
    }

    public static bool DVEnzHyFnpZFHAfo(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return dVEnzHyFnpZFHAfo(this, ch);
    }

    public override com.google.common.base.CharMatch Negate() {
        return new com.google.common.base.CharMatch$NegatedFastMatch(this);
    }

    public override readonly com.google.common.base.CharMatch Precomputed() {
        return this;
    }
}

