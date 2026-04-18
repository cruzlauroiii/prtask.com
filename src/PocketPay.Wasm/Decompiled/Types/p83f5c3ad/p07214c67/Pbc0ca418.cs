namespace WillowMaze.Wasm.Decompiled;

public class Pbc0ca418 : Parcelable
{
    public static Parcelable$Creator F32ff2a16;
    public static Parcelable$Creator F71867d25;
    public static Parcelable$Creator F89f5ab82;
    public static Parcelable$Creator Fe0bd3165;
    public static Parcelable$Creator Fe844e3ba;
    private readonly long F078ba7d3;
    private readonly string F1af03898;
    private readonly long F2069ca79;
    private readonly string F2c2011ba;
    private readonly string F586b3b24;
    private readonly string F7b8de9e0;
    private readonly long F816304e0;
    private readonly string Fca3715df;
    private readonly string Fd1e39477;

    public static pbc0ca418 M1c1e012b(pbc0ca418 P0, long P1, string P2, string P3, int P4, object P5)
    {
        // call: pbc0ca418.copy
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        return default!;
    }

    public long Component1()
    {
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        return 0;
    }

    public string Component2()
    {
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        return string.Empty;
    }

    public string Component3()
    {
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
        return string.Empty;
    }

    public pbc0ca418 Copy(long P0, string P1, string P2)
    {
        // str: "currency"
        // str: "lastPan4Digits"
        // call: Intrinsics.checkNotNullParameter
        // call: pbc0ca418.<init>
        // type: pbc0ca418
        return default!;
    }

    public int DescribeContents()
    {
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: Intrinsics.areEqual
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        return false;
    }

    public long GetBalance()
    {
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        return 0;
    }

    public string GetCurrency()
    {
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        return string.Empty;
    }

    public string GetLastPan4Digits()
    {
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
        return string.Empty;
    }

    public int HashCode()
    {
        // call: string.hashCode
        // call: long.hashCode
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        return 0;
    }

    public string ToString()
    {
        // str: "BalanceResponse(balance="
        // str: ", lastPan4Digits="
        // str: ", currency="
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        // type: StringBuilder
        return string.Empty;
    }

    public void WriteToParcel(Parcel P0, int P1)
    {
        // str: "dest"
        // call: Parcel.writeString
        // call: Intrinsics.checkNotNullParameter
        // call: Parcel.writeLong
        // field: p83f5c3ad.p07214c67.pbc0ca418.f2069ca79
        // field: p83f5c3ad.p07214c67.pbc0ca418.f1af03898
        // field: p83f5c3ad.p07214c67.pbc0ca418.f586b3b24
    }

}
