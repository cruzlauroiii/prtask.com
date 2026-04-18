namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0019\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00010\u0002H\u0007¢\u0006\u0004\b\u0003\u0010\u0004\u001a\u0019\u0010\u0000\u001a\u00020\u0005*\b\u0012\u0004\u0012\u00020\u00050\u0002H\u0007¢\u0006\u0004\b\u0006\u0010\u0007\u001a\u0019\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\b0\u0002H\u0007¢\u0006\u0004\b\t\u0010\u0004\u001a\u0019\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\n0\u0002H\u0007¢\u0006\u0004\b\u000b\u0010\u0004¨\u0006\f"}, d2 = {"sum", "Lkotlin/UInt;", "Lkotlin/sequences/Sequence;", "sumOfUInt", "(Lkotlin/sequences/Sequence;)I", "Lkotlin/Ulong;", "sumOfUlong", "(Lkotlin/sequences/Sequence;)J", "Lkotlin/Ubyte;", "sumOfUbyte", "Lkotlin/Ushort;", "sumOfUshort", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/sequences/USequencesKt")
class USequencesKt___USequencesKt {
    public static readonly int SumOfUbyte(kotlin.sequences.Sequence<kotlin.Ubyte> sequence) {
        if ((10 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "<this>");
        java.util.IEnumerator<kotlin.Ubyte> it = sequence.GetEnumerator();
        int iM1310constructorimpl = 0;
        while (it.MoveNext()) {
            iM1310constructorimpl = kotlin.UInt.m1310constructorimpl(iM1310constructorimpl + kotlin.UInt.m1310constructorimpl(it.Current.m1217unboximpl() & 255));
        }
        return iM1310constructorimpl;
    }

    public static readonly int SumOfUInt(kotlin.sequences.Sequence<kotlin.UInt> sequence) {
        if ((18 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "<this>");
        java.util.IEnumerator<kotlin.UInt> it = sequence.GetEnumerator();
        int iM1310constructorimpl = 0;
        while (it.MoveNext()) {
            iM1310constructorimpl = kotlin.UInt.m1310constructorimpl(iM1310constructorimpl + it.Current.m1518unboximpl());
        }
        return iM1310constructorimpl;
    }

    public static readonly long SumOfUlong(kotlin.sequences.Sequence<kotlin.Ulong> sequence) {
        if ((9 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "<this>");
        java.util.IEnumerator<kotlin.Ulong> it = sequence.GetEnumerator();
        long jM1611constructorimpl = 0;
        while (it.MoveNext()) {
            jM1611constructorimpl = kotlin.Ulong.m1611constructorimpl(jM1611constructorimpl + it.Current.m1819unboximpl());
        }
        return jM1611constructorimpl;
    }

    public static readonly int SumOfUshort(kotlin.sequences.Sequence<kotlin.Ushort> sequence) {
        if ((20 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "<this>");
        java.util.IEnumerator<kotlin.Ushort> it = sequence.GetEnumerator();
        int iM1310constructorimpl = 0;
        while (it.MoveNext()) {
            iM1310constructorimpl = kotlin.UInt.m1310constructorimpl(iM1310constructorimpl + kotlin.UInt.m1310constructorimpl(it.Current.m2224unboximpl() & 65535));
        }
        return iM1310constructorimpl;
    }
}

