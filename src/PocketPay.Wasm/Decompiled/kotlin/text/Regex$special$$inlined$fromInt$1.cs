namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class Regex$special$$inlined$fromInt$1 : kotlin.jvm.functions.Function1<kotlin.text.RegexOption, java.lang.bool> {
    readonly int $value;

    public Regex$special$$inlined$fromInt$1(int i) {
        this.$value = i;
    }

    public readonly java.lang.bool Invoke(kotlin.text.RegexOption regexOption) {
        kotlin.text.RegexOption regexOption2 = regexOption;
        return java.lang.bool.valueOf((this.$value & regexOption2.getMask()) == regexOption2.getValue());
    }

    public override java.lang.bool Invoke(kotlin.text.RegexOption regexOption) {
        return invoke(regexOption);
    }
}

