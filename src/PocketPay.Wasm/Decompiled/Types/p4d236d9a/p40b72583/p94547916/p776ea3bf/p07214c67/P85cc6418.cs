namespace WillowMaze.Wasm.Decompiled;

public class P85cc6418 : P3fef8ea2
{
    private static int F021321e8;
    public static p85cc6418$p910eef8c F1068a35e;
    public static Parcelable$Creator F26cf1c2a;
    public static Parcelable$Creator F71867d25;
    public static Parcelable$Creator F734e4168;
    private static int F7b592319;
    public static p85cc6418$p910eef8c F910eef8c;
    private readonly string F018f4e93;
    private readonly string F2f7bedc1;
    private readonly string F7d569fa2;
    private readonly p2daf1cb5 Fbf59a3b0;
    private readonly p2daf1cb5 Fd3ed68f7;
    private readonly string Fd897fc1c;

    public static p85cc6418 M1c1e012b(p85cc6418 P0, p2daf1cb5 P1, string P2, string P3, int P4, object P5)
    {
        // call: p85cc6418.copy
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.f2f7bedc1
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd3ed68f7
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd897fc1c
        return default!;
    }

    public p2daf1cb5 Component1()
    {
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd3ed68f7
        return default!;
    }

    public string Component2()
    {
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.f2f7bedc1
        return string.Empty;
    }

    public string Component3()
    {
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd897fc1c
        return string.Empty;
    }

    public p85cc6418 Copy(p2daf1cb5 P0, string P1, string P2)
    {
        // str: "integrationVersion"
        // str: "credentials"
        // call: p85cc6418.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: p85cc6418
        return default!;
    }

    public int DescribeContents()
    {
        // call: p3fef8ea2$pb0da8397.m74099d24
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: Intrinsics.areEqual
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd3ed68f7
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.f2f7bedc1
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd897fc1c
        return false;
    }

    public p2daf1cb5 GetCredentials()
    {
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd3ed68f7
        return default!;
    }

    public string GetIntegrationVersion()
    {
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd897fc1c
        return string.Empty;
    }

    public string GetSellReceiptUuid()
    {
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.f2f7bedc1
        return string.Empty;
    }

    public int HashCode()
    {
        // call: p2daf1cb5.hashCode
        // call: string.hashCode
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd3ed68f7
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd897fc1c
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.f2f7bedc1
        return 0;
    }

    public string ToString()
    {
        // str: ", integrationVersion="
        // str: ", sellReceiptUuid="
        // str: "IntegrationData(credentials="
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.f2f7bedc1
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd3ed68f7
        // field: p4d236d9a.p40b72583.p94547916.p776ea3bf.p07214c67.p85cc6418.fd897fc1c
        // type: StringBuilder
        return string.Empty;
    }

    public void WriteToParcel(Parcel P0, int P1)
    {
        // str: "parcel"
        // call: p85cc6418.getIntegrationVersion
        // call: Parcel.dataPosition
        // call: Parcel.writeString
        // call: Parcel.writeInt
        // call: Parcel.setDataPosition
        // call: p85cc6418.getSellReceiptUuid
        // call: p85cc6418.getCredentials
        // call: Intrinsics.checkNotNullParameter
        // call: Parcel.writeTypedObject
    }

}
