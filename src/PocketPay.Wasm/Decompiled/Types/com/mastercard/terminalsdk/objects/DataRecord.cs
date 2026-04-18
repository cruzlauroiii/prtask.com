namespace WillowMaze.Wasm.Decompiled;

public class DataRecord
{
    public static Enum[] C$753e0646;
    public static Enum[] E$753e0646;
    private List<object> A;

    private byte[] E()
    {
        // call: MemoryStream.<init>
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: BerTlv.toByteArray
        // call: MemoryStream.write
        // call: MemoryStream.toByteArray
        // field: com.mastercard.terminalsdk.objects.DataRecord.a
        // type: MemoryStream
        return default!;
    }

    public void AddContent(BerTlv P0)
    {
        // call: List<object>.add
        // field: com.mastercard.terminalsdk.objects.DataRecord.a
    }

    private object Clone()
    {
        // call: DataRecord.d
        return default!;
    }

    private DataRecord D()
    {
        // call: BerTlv.clone
        // call: DataRecord.addContent
        // call: List<object>.iterator
        // call: DataRecord.<init>
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // field: com.mastercard.terminalsdk.objects.DataRecord.a
        // type: DataRecord
        return default!;
    }

    public List<object> GetContents()
    {
        // field: com.mastercard.terminalsdk.objects.DataRecord.a
        return default!;
    }

    public void Initialise()
    {
        // call: List<object>.<init>
        // field: com.mastercard.terminalsdk.objects.DataRecord.a
        // type: List<object>
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public BerTlv ToTLV()
    {
        // str: "cY"
        // str: ""
        // str: "b"
        // call: Type.getField
        // call: BerTlv.<init>
        // call: Tag.<init>
        // call: DataRecord.e
        // call: q.b
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: Exception.getCause
        // call: ByteArrayWrapper.<init>
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // type: Tag
        // type: BerTlv
        // type: ByteArrayWrapper
        return default!;
    }

}
