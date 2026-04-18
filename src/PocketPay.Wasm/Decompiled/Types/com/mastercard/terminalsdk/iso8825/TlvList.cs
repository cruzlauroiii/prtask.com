namespace WillowMaze.Wasm.Decompiled;

public class TlvList : Cloneable
{
    private List<object> A;
    private string C;

    public void AddTLVtoList(BerTlv P0)
    {
        // call: IEnumerator<object>.next
        // call: Tag.getNTag
        // call: BerTlv.setRawBytes
        // call: List<object>.iterator
        // call: BerTlv.getTagObject
        // call: BerTlv.getRawBytes
        // call: IEnumerator<object>.hasNext
        // call: List<object>.add
        // field: com.mastercard.terminalsdk.iso8825.TlvList.a
    }

    public TlvList Clone()
    {
        // call: object.clone
        // call: List<object>.size
        // call: List<object>.<init>
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: BerTlv.clone
        // call: List<object>.add
        // field: com.mastercard.terminalsdk.iso8825.TlvList.a
        // type: List<object>
        return default!;
    }

    public object Clone()
    {
        // call: TlvList.clone
        return default!;
    }

    public List<object> GetListOfBerTlv()
    {
        // field: com.mastercard.terminalsdk.iso8825.TlvList.a
        return default!;
    }

    public string GetNameOfList()
    {
        // field: com.mastercard.terminalsdk.iso8825.TlvList.c
        return string.Empty;
    }

    public void RemoveTlvFromList(BerTlv P0)
    {
        // call: List<object>.iterator
        // call: BerTlv.getNTag
        // call: IEnumerator<object>.hasNext
        // call: List<object>.remove
        // call: IEnumerator<object>.next
        // field: com.mastercard.terminalsdk.iso8825.TlvList.a
    }

    public byte[] ToByteArray()
    {
        // call: MemoryStream.<init>
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: BerTlv.toByteArray
        // call: MemoryStream.write
        // call: MemoryStream.toByteArray
        // field: com.mastercard.terminalsdk.iso8825.TlvList.a
        // type: MemoryStream
        return default!;
    }

    public string ToIndentedString(int P0)
    {
        // call: object.toString
        return string.Empty;
    }

    public string ToString()
    {
        // call: TlvList.toIndentedString
        return string.Empty;
    }

    public void UpdateTlv(string P0, string P1)
    {
        // call: List<object>.iterator
        // call: ByteArrayWrapper.<init>
        // call: BerTlv.getTagObject
        // call: BerTlv.setRawBytes
        // call: ByteUtility.hexStringToByteArray
        // call: IEnumerator<object>.hasNext
        // call: Tag.getName
        // call: string.equalsIgnoreCase
        // call: IEnumerator<object>.next
        // field: com.mastercard.terminalsdk.iso8825.TlvList.a
        // type: ByteArrayWrapper
    }

}
