namespace WillowMaze.Wasm.Decompiled;

public class TornRecord : Cloneable, Comparable
{
    public static Enum[] B$753e0646;
    private Dictionary<string, object> A;

    private BerTlv A()
    {
        // str: "bt"
        // str: "c"
        // call: int.valueOf
        // call: Type.getField
        // call: Dictionary<string, object>.get
        // call: Exception.getCause
        // call: q.b
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    private BerTlv D()
    {
        // str: "c"
        // str: "ah"
        // call: int.valueOf
        // call: q.b
        // call: Dictionary<string, object>.get
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // call: Exception.getCause
        // call: Type.getField
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public TornRecord Clone()
    {
        // call: Dictionary<string, object>.clone
        // call: object.clone
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public object Clone()
    {
        // call: TornRecord.clone
        return default!;
    }

    public int CompareTo(TornRecord P0)
    {
        // call: DateTime.compareTo
        // call: TornRecord.getDateTime
        return 0;
    }

    public int CompareTo(object P0)
    {
        // call: TornRecord.compareTo
        return 0;
    }

    public BerTlv GetApplicationPAN()
    {
        // str: "c"
        // str: "aU"
        // call: Dictionary<string, object>.get
        // call: Exception.getCause
        // call: Type.getField
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // call: int.valueOf
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public BerTlv GetApplicationPSN()
    {
        // str: "c"
        // str: "aT"
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // call: Exception.getCause
        // call: Type.getField
        // call: Dictionary<string, object>.get
        // call: int.valueOf
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public BerTlv GetDRDOLRelatedData()
    {
        // str: "c"
        // str: "bl"
        // call: Type.getField
        // call: int.valueOf
        // call: Exception.getCause
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // call: Dictionary<string, object>.get
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public BerTlv GetDSSummary1()
    {
        // str: "aD"
        // str: "c"
        // call: Type.getField
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // call: Dictionary<string, object>.get
        // call: int.valueOf
        // call: Exception.getCause
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public Dictionary<string, object> GetDataObjects()
    {
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public DateTime GetDateTime()
    {
        // str: "b"
        // call: BerTlv.getRawBytes
        // call: TornRecord.d
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: ByteArrayWrapper.getBytes
        // call: TornRecord.a
        // call: Exception.getCause
        // type: byte[]
        return default!;
    }

    public BerTlv GetIDSStatus()
    {
        // str: "q"
        // str: "c"
        // call: Dictionary<string, object>.get
        // call: int.valueOf
        // call: q.b
        // call: Type.getField
        // call: Exception.getCause
        // call: Field.get
        // call: Type.getMethod
        // call: Method.invoke
        // call: int.intValue
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        return default!;
    }

    public void SetDataObject(BerTlv P0)
    {
        // call: BerTlv.clone
        // call: int.valueOf
        // call: Dictionary<string, object>.put
        // call: BerTlv.getNTag
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
    }

    public byte[] ToByteArray()
    {
        // call: BerTlv.toByteArray
        // call: MemoryStream.write
        // call: MemoryStream.toByteArray
        // call: Dictionary<string, object>.values
        // call: IEnumerator<object>.hasNext
        // call: ICollection<object>.iterator
        // call: IEnumerator<object>.next
        // call: MemoryStream.<init>
        // field: com.mastercard.terminalsdk.objects.TornRecord.a
        // type: MemoryStream
        return default!;
    }

    public string ToString()
    {
        // call: object.toString
        return string.Empty;
    }

    public BerTlv ToTlv()
    {
        // str: "cm"
        // str: ""
        // str: "b"
        // call: TornRecord.toByteArray
        // call: BerTlv.<init>
        // call: Field.get
        // call: q.b
        // call: Type.getMethod
        // call: Method.invoke
        // call: Exception.getCause
        // call: ByteArrayWrapper.<init>
        // call: Type.getField
        // call: Tag.<init>
        // field: com.mastercard.terminalsdk.emv.Tag$Format.b
        // type: Tag
        // type: BerTlv
        // type: ByteArrayWrapper
        return default!;
    }

}
