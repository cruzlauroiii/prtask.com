namespace WillowMaze.Wasm.Decompiled;

public class BerTlv : Cloneable
{
    private ByteArrayWrapper A;
    private Tag B;
    private object C;
    private ByteArrayWrapper D;
    private int E;
    private bool J;

    public BerTlv Clone()
    {
        // call: Tag.clone
        // call: BerTlv.<init>
        // call: ByteArrayWrapper.clone
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.d
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.b
        // type: BerTlv
        return default!;
    }

    public object Clone()
    {
        // call: BerTlv.clone
        return default!;
    }

    public byte[] GetBytes()
    {
        // call: ByteArrayWrapper.getBytes
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.d
        return default!;
    }

    public ByteArrayWrapper GetEncodedLengthBytes()
    {
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.a
        return default!;
    }

    public int GetNTag()
    {
        // call: Tag.getNTag
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.b
        return 0;
    }

    public int GetNumericLength()
    {
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.e
        return 0;
    }

    public ByteArrayWrapper GetRawBytes()
    {
        // call: TLVUtility.formByteArrayFromTlvList
        // call: BerTlv.isConstructed
        // call: ByteArrayWrapper.<init>
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.c
        // field: com.mastercard.terminalsdk.objects.ContentType.TLV
        // type: ByteArrayWrapper
        return default!;
    }

    public byte[] GetTag()
    {
        // call: Tag.getTag
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.b
        return default!;
    }

    public Tag GetTagObject()
    {
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.b
        return default!;
    }

    public object GetValue()
    {
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.c
        return default!;
    }

    public bool IsConstructed()
    {
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.j
        return false;
    }

    public void SetNumericLength(int P0)
    {
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.e
    }

    public void SetRawBytes(ByteArrayWrapper P0)
    {
        // call: ByteUtility.intToBerEncodedFixedLength
        // call: TLVUtility.conditionalTlvParsing
        // call: Tag.getTemplate
        // call: ByteArrayWrapper.getBytes
        // call: ByteArrayWrapper.length
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.d
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.c
        // field: com.mastercard.terminalsdk.objects.ContentType.TLV
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.j
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.b
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.a
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.e
    }

    public byte[] ToByteArray()
    {
        // call: MemoryStream.toByteArray
        // call: MemoryStream.<init>
        // call: Tag.getTag
        // call: MemoryStream.write
        // call: ByteUtility.intToBerEncodedLength
        // call: ByteArrayWrapper.getBytes
        // call: BerTlv.getBytes
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.b
        // field: com.mastercard.terminalsdk.iso8825.BerTlv.e
        // type: MemoryStream
        return default!;
    }

    public string ToHexString()
    {
        // call: BerTlv.toByteArray
        // call: ByteUtility.byteArrayToHexString
        return string.Empty;
    }

    public string ToIndentedString(int P0)
    {
        // call: object.toString
        return string.Empty;
    }

    public string ToString()
    {
        // call: BerTlv.toIndentedString
        return string.Empty;
    }

}
