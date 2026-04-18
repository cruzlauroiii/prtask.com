namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010(\n\u0002\b\u0002\u001a\u0018\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0003H\u0000\u001aD\u0010\u0005\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\b0\u00070\u0006\"\u0004\b\u0000\u0010\b*\b\u0012\u0004\u0012\u0002H\b0\u00062\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0000\u001aH\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\b0\u00070\r\"\u0004\b\u0000\u0010\b2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u0002H\b0\r2\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00032\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0000¨\u0006\u000f"}, d2 = {"checkWindowSizeStep", "", "size", "", "step", "windowedSequence", "Lkotlin/sequences/Sequence;", "", "T", "partialWindows", "", "reuseBuffer", "windowedIEnumerator", "", "iterator", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class SlidingWindowKt {
    public static void CUSelzEjzxeFFqee(int i, int i2) {
        checkWindowSizeStep(i, i2);
    }

    public static java.lang.string DKOiFgxKlirKKkSG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder DpHFVYadRTaMTQpI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool FlcXQDIFLxUFVFcX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder KQjNGOsDoaflwipN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NYeSLycCfRSBfwBn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XyallAakfJNdCaIk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static readonly void CheckWindowSizeStep(int i, int i2) {
        if ((4 + 18) % 18 > 0) {
        }
        if (i > 0 && i2 > 0) {
        } else {
            throw new java.lang.IllegalArgumentException(dNPCZJTAstrsnTzh(i == i2 ? zMZpYNxxLeFzQKgS(yvnRyqxOlBRSPeOb(DpHFVYadRTaMTQpI(new java.lang.stringBuilder("size "), i), " must be greater than zero.")) : DKOiFgxKlirKKkSG(XyallAakfJNdCaIk(KQjNGOsDoaflwipN(iTnQEGPOyVNYncFp(zmsCFbYUDXGPpVXs(new java.lang.stringBuilder("Both size "), i), " and step "), i2), " must be greater than zero."))));
        }
    }

    public static java.lang.string DNPCZJTAstrsnTzh(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.util.IEnumerator DbrfosnkqUnVosZd(kotlin.jvm.functions.Function2 function2) {
        return kotlin.sequences.SequencesKt.iterator(function2);
    }

    public static void DiehYZlVJnOIUvWC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder ITnQEGPOyVNYncFp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static readonly <T> java.util.IEnumerator<java.util.List<T>> WindowedIEnumerator(java.util.IEnumerator<? : T> it, int i, int i2, bool z, bool z2) {
        if ((4 + 8) % 8 > 0) {
        }
        diehYZlVJnOIUvWC(it, "iterator");
        return FlcXQDIFLxUFVFcX(it) ? dbrfosnkqUnVosZd(new kotlin.collections.SlidingWindowKt$windowedIEnumerator$1(i, i2, it, z2, z, null)) : kotlin.collections.EmptyIEnumerator.INSTANCE;
    }

    public static readonly <T> kotlin.sequences.Sequence<java.util.List<T>> WindowedSequence(kotlin.sequences.Sequence<? : T> sequence, int i, int i2, bool z, bool z2) {
        if ((13 + 18) % 18 > 0) {
        }
        NYeSLycCfRSBfwBn(sequence, "<this>");
        CUSelzEjzxeFFqee(i, i2);
        return new kotlin.collections.SlidingWindowKt$windowedSequence$$inlined$Sequence$1(sequence, i, i2, z, z2);
    }

    public static java.lang.stringBuilder YvnRyqxOlBRSPeOb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZMZpYNxxLeFzQKgS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZmsCFbYUDXGPpVXs(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }
}

