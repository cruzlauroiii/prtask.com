namespace WillowMaze.Wasm.Decompiled;

public class P14eee5e9
{
    public static pac70412e M147fee21(pe2d63d19 P0, pac70412e P1)
    {
        // str: "path"
        // str: "<this>"
        // call: pac70412e.resolve
        // call: Intrinsics.checkNotNull
        // call: p50ca3499.getSymlinkTarget
        // call: pac70412e.parent
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.metadata
        return default!;
    }

    public static bool M2594778c(pe2d63d19 P0, pac70412e P1)
    {
        // str: "<this>"
        // str: "path"
        // call: pe2d63d19.metadataOrNull
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public static p50ca3499 M3f092694(pe2d63d19 P0, pac70412e P1)
    {
        // str: "<this>"
        // str: "path"
        // str: "no such file: "
        // call: FileNotFoundException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.metadataOrNull
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: FileNotFoundException
        return default!;
    }

    public static object M6e39668f(SequenceScope P0, pe2d63d19 P1, ArrayDeque P2, pac70412e P3, bool P4, bool P5, object P6)
    {
        // str: "symlink cycle at "
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: StringBuilder.append
        // call: ICollection<object>.isEmpty
        // call: p14eee5e9.m147fee21
        // call: StringBuilder.<init>
        // call: ArrayDeque.removeLast
        // call: IllegalStateException.<init>
        // call: ArrayDeque.contains
        // call: ResultKt.throwOnFailure
        // call: StringBuilder.toString
        // call: p14eee5e9$p6e39668f$1.<init>
        // call: p14eee5e9.m6e39668f
        // call: SequenceScope.yield
        // call: ArrayDeque.addLast
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: CollectionsKt.emptyList
        // call: IOException.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: pe2d63d19.listOrNull
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.Z$0
        // field: kotlin.Unit.INSTANCE
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.Z$1
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.L$0
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.L$3
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.fd304ba20
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.fb4a88417
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.L$1
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.L$2
        // field: p38cb8f46.pd1efad72.p14eee5e9$p6e39668f$1.L$4
        // type: StringBuilder
        // type: IOException
        // type: IllegalStateException
        // type: p14eee5e9$p6e39668f$1
        return default!;
    }

    public static Sequence M7313ee2e(pe2d63d19 P0, pac70412e P1, bool P2)
    {
        // str: "dir"
        // str: "<this>"
        // call: SequencesKt.sequence
        // call: Intrinsics.checkNotNullParameter
        // call: p14eee5e9$p7313ee2e$1.<init>
        // type: p14eee5e9$p7313ee2e$1
        return default!;
    }

    public static void M7369d738(pe2d63d19 P0, pac70412e P1, bool P2)
    {
        // str: "<this>"
        // str: "fileOrDirectory"
        // call: Intrinsics.checkNotNullParameter
        // call: pe2d63d19.delete
        // call: IEnumerator<object>.hasNext
        // call: Sequence.iterator
        // call: IEnumerator<object>.next
        // call: SequencesKt.sequence
        // call: p14eee5e9$p7369d738$pfa1c731e$1.<init>
        // type: p14eee5e9$p7369d738$pfa1c731e$1
    }

    public static void M95946db8(pe2d63d19 P0, pac70412e P1, bool P2)
    {
        // str: "<this>"
        // str: "dir"
        // str: " already exist."
        // call: pac70412e.parent
        // call: StringBuilder.toString
        // call: ArrayDeque.<init>
        // call: StringBuilder.append
        // call: IEnumerator<object>.next
        // call: IOException.<init>
        // call: ArrayDeque.iterator
        // call: ArrayDeque.addFirst
        // call: pe2d63d19.exists
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.hasNext
        // call: ArrayDeque.isEmpty
        // call: StringBuilder.<init>
        // call: pe2d63d19.createDirectory
        // type: ArrayDeque
        // type: IOException
        // type: StringBuilder
    }

    public static void Mfebfae7c(pe2d63d19 P0, pac70412e P1, pac70412e P2)
    {
        // str: "source"
        // str: "<this>"
        // str: "target"
        // call: Intrinsics.checkNotNullParameter
        // call: IDisposable.close
        // call: pe2d63d19.sink
        // call: p0af9afa4.m7f2db423
        // call: p08d84bc6.writeAll
        // call: long.valueOf
        // call: pe2d63d19.source
        // call: ExceptionsKt.addSuppressed
        // call: Intrinsics.checkNotNull
        // call: System.Numerics.BigInteger.longValue
    }

}
