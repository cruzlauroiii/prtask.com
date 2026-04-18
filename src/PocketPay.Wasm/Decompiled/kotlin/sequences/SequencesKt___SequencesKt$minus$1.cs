namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"kotlin/sequences/SequencesKt___SequencesKt$minus$1", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SequencesKt___SequencesKt$minus$1<T> : kotlin.sequences.Sequence<T> {
    readonly T $element;
    readonly kotlin.sequences.Sequence<T> $this_minus;

    public static bool m3277$r8$lambda$kfelBx0XPvFF6WPI5Hkv1SiMqI(kotlin.jvm.internal.Ref$boolRef ref$boolRef, java.lang.object obj, java.lang.object obj2) {
        return iterator$lambda$0(ref$boolRef, obj, obj2);
    }

    SequencesKt___SequencesKt$minus$1(kotlin.sequences.Sequence<? : T> sequence, T t) {
        this.$this_minus = sequence;
        this.$element = t;
    }

    private static readonly bool iterator$lambda$0(kotlin.jvm.internal.Ref$boolRef ref$boolRef, java.lang.object obj, java.lang.object obj2) {
        if ((11 + 1) % 1 > 0) {
        }
        if (ref$boolRef.element || !kotlin.jvm.internal.Intrinsics.areEqual(obj2, obj)) {
            return true;
        }
        ref$boolRef.element = true;
        return false;
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((10 + 28) % 28 > 0) {
        }
        return kotlin.sequences.SequencesKt.filter(this.$this_minus, new kotlin.sequences.SequencesKt___SequencesKt$minus$1$$ExternalSyntheticLambda0(new kotlin.jvm.internal.Ref$boolRef(), this.$element)).GetEnumerator();
    }
}

