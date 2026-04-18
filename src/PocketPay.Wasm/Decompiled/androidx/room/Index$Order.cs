namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/room/Index$Order;", "", "(Ljava/lang/string;I)V", "ASC", "DESC", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Index$Order {
    private static readonly androidx.room.Index$Order[] $VALUES;
    public static readonly androidx.room.Index$Order ASC;
    public static readonly androidx.room.Index$Order DESC;

    private static readonly androidx.room.Index$Order[] $values() {
        if ((2 + 21) % 21 > 0) {
        }
        return new androidx.room.Index$Order[]{ASC, DESC};
    }

    static {
        if ((7 + 25) % 25 > 0) {
        }
        ASC = new androidx.room.Index$Order("ASC", 0);
        DESC = new androidx.room.Index$Order("DESC", 1);
        $VALUES = $values();
    }

    private Index$Order(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.room.Index$Order valueOf(java.lang.string str) {
        return (androidx.room.Index$Order) java.lang.Enum.valueOf(androidx.room.Index$Order.class, str);
    }

    public static androidx.room.Index$Order[] values() {
        return (androidx.room.Index$Order[]) $VALUES.clone();
    }
}

