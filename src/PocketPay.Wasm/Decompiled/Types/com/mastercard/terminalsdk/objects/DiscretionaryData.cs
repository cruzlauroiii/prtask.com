namespace WillowMaze.Wasm.Decompiled;

public class DiscretionaryData
{
    public static Enum[] A$753e0646;
    public static Enum[] B$753e0646;
    public static Enum[] C$753e0646;
    public static Enum[] D$753e0646;
    public static Enum[] E$753e0646;
    private TornRecord G;
    private List<object> H;
    private ErrorIndication J;

    private byte[] D()
    {
        // call: MemoryStream.<init>
        // call: ErrorIndication.toTLV
        // call: BerTlv.toByteArray
        // call: MemoryStream.write
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: TornRecord.toTlv
        // call: MemoryStream.toByteArray
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.j
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.h
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.g
        // type: MemoryStream
        return default!;
    }

    private DiscretionaryData A()
    {
        // call: DiscretionaryData.<init>
        // call: DiscretionaryData.addContent
        // call: DiscretionaryData.setErrorIndication
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: List<object>.iterator
        // call: ErrorIndication.e
        // call: BerTlv.clone
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.j
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.h
        // type: DiscretionaryData
        return default!;
    }

    public void AddContent(BerTlv P0)
    {
        // call: List<object>.add
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.h
    }

    private object Clone()
    {
        // call: DiscretionaryData.a
        return default!;
    }

    public List<object> GetAdditionalInformation()
    {
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.h
        return default!;
    }

    public ErrorIndication GetErrorIndication()
    {
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.j
        return default!;
    }

    public TornRecord GetTornRecord()
    {
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.g
        return default!;
    }

    public void Initialise()
    {
        // call: List<object>.<init>
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.h
        // type: List<object>
    }

    public void SetErrorIndication(ErrorIndication P0)
    {
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.j
    }

    public void SetTornRecord(TornRecord P0)
    {
        // field: com.mastercard.terminalsdk.objects.DiscretionaryData.g
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public BerTlv ToTLV()
    {
        // str: "a"
        // str: ""
        // str: "b"
        // call: BerTlv.<init>
        // call: q.b
        // call: ByteArrayWrapper.<init>
        // call: Type.getField
        // call: DiscretionaryData.d
        // call: Exception.getCause
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: Tag.<init>
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // type: BerTlv
        // type: ByteArrayWrapper
        // type: Tag
        return default!;
    }

}
