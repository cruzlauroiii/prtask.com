namespace WillowMaze.Wasm.Decompiled;

public class P5dd44a36_p64dbe03a_1 : Lambda, Func<object, object, object>
{
    private readonly Ref$LongRef $compressedSize;
    private readonly Ref$BooleanRef $hasZip64Extra;
    private readonly Ref$LongRef $offset;
    private readonly long $requiredZip64ExtraSize;
    private readonly Ref$LongRef $size;
    private readonly pcc81e3f6 $this_readEntry;

    public object Invoke(object P0, object P1)
    {
        // call: System.Numerics.BigInteger.intValue
        // call: p5dd44a36$p64dbe03a$1.invoke
        // call: System.Numerics.BigInteger.longValue
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public void Invoke(int P0, long P1)
    {
        // str: "bad zip: zip64 extra too short"
        // str: "bad zip: zip64 extra repeated"
        // call: pcc81e3f6.readLongLe
        // call: IOException.<init>
        // field: kotlin.jvm.internal.Ref$LongRef.element
        // field: p38cb8f46.pd1efad72.p5dd44a36$p64dbe03a$1.$size
        // field: kotlin.jvm.internal.Ref$BooleanRef.element
        // field: p38cb8f46.pd1efad72.p5dd44a36$p64dbe03a$1.$this_readEntry
        // field: p38cb8f46.pd1efad72.p5dd44a36$p64dbe03a$1.$compressedSize
        // field: p38cb8f46.pd1efad72.p5dd44a36$p64dbe03a$1.$hasZip64Extra
        // field: p38cb8f46.pd1efad72.p5dd44a36$p64dbe03a$1.$offset
        // field: p38cb8f46.pd1efad72.p5dd44a36$p64dbe03a$1.$requiredZip64ExtraSize
        // type: IOException
    }

}
