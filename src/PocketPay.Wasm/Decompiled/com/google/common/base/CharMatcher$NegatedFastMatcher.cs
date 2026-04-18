namespace WillowMaze.Wasm.Decompiled;


class CharMatch$NegatedFastMatch : com.google.common.base.CharMatch$Negated {
    CharMatch$NegatedFastMatch(com.google.common.base.CharMatch charMatch) {
        super(charMatch);
    }

    public override readonly com.google.common.base.CharMatch Precomputed() {
        return this;
    }
}

