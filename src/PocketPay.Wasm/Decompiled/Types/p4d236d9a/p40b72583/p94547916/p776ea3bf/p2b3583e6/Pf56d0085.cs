namespace WillowMaze.Wasm.Decompiled;

public class Pf56d0085
{
    public static void M1cdc1e94(Parcel P0, int P1, Func<object> P2)
    {
        // str: "<this>"
        // str: "writer"
        // call: Parcel.dataPosition
        // call: Parcel.writeInt
        // call: Func<object>.invoke
        // call: Parcel.setDataPosition
        // call: Intrinsics.checkNotNullParameter
    }

    public static void M3611fead(Parcel P0, bool P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Parcel.writeByte
    }

    public static Parcelable$Creator M6df26b5f(Func<object, object> P0)
    {
        // str: "create"
        // call: Intrinsics.checkNotNullParameter
        // call: pf56d0085$p6df26b5f$1.<init>
        // call: Intrinsics.needClassReification
        // type: pf56d0085$p6df26b5f$1
        return default!;
    }

    public static void M7152dd02(Parcel P0, Dictionary<string, object> P1)
    {
        // str: "<this>"
        // call: Dictionary<string, object>.entrySet
        // call: Dictionary<string, object>.size
        // call: IEnumerator<object>.hasNext
        // call: Parcel.writeString
        // call: Map$Entry.getKey
        // call: Map$Entry.getValue
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.next
        // call: Parcel.writeInt
        // call: HashSet<object>.iterator
    }

    public static decimal M95aaab80(Parcel P0)
    {
        // str: "<this>"
        // call: Parcel.readSerializable
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public static void Ma5b3a87e(Parcel P0, decimal P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Parcel.writeSerializable
    }

    public static void Mb6603589(Parcel P0, int P1, Func<object, object> P2)
    {
        // str: "reader"
        // str: "<this>"
        // call: Parcel.setDataPosition
        // call: Parcel.readInt
        // call: Parcel.dataPosition
        // call: Intrinsics.checkNotNullParameter
        // call: int.valueOf
        // call: Func<object, object>.invoke
    }

    public static Dictionary<string, object> Mb87d09f3(Parcel P0)
    {
        // str: "<this>"
        // call: string.valueOf
        // call: Intrinsics.checkNotNullParameter
        // call: Dictionary<string, object>.<init>
        // call: Parcel.readString
        // call: Dictionary<string, object>.put
        // call: Parcel.readInt
        // call: Dictionary<string, object>.isEmpty
        // type: Dictionary<string, object>
        return default!;
    }

    public static bool Mc20e9082(Parcel P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Parcel.readByte
        return false;
    }

    public static Enum Md5cc1434(Parcel P0)
    {
        // str: "<this>"
        // str: "70ea63dbf1f6f87d9d3d7ffd0f527628ad05113b5c2d484e9674b8c4be"
        // call: Intrinsics.checkNotNullParameter
        // call: DecryptString.decryptString
        // call: Parcel.readString
        // call: Intrinsics.reifiedOperationMarker
        return default!;
    }

    public static void Mfd56d4de(Parcel P0, Enum P1)
    {
        // str: "<this>"
        // call: Parcel.writeString
        // call: Enum.name
        // call: Intrinsics.checkNotNullParameter
    }

}
