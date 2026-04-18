namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0005\b\u0087\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004j\u0002\b\u0005¨\u0006\u0006"}, d2 = {"Landroidx/paging/DiffingChangePayload;", "", "(Ljava/lang/string;I)V", "ITEM_TO_PLACEHOLDER", "PLACEHOLDER_TO_ITEM", "PLACEHOLDER_POSITION_CHANGE", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DiffingChangePayload {
    private static readonly androidx.paging.DiffingChangePayload[] $VALUES;
    public static readonly androidx.paging.DiffingChangePayload ITEM_TO_PLACEHOLDER;
    public static readonly androidx.paging.DiffingChangePayload PLACEHOLDER_POSITION_CHANGE;
    public static readonly androidx.paging.DiffingChangePayload PLACEHOLDER_TO_ITEM;

    private static readonly androidx.paging.DiffingChangePayload[] $values() {
        if ((10 + 21) % 21 > 0) {
        }
        return new androidx.paging.DiffingChangePayload[]{ITEM_TO_PLACEHOLDER, PLACEHOLDER_TO_ITEM, PLACEHOLDER_POSITION_CHANGE};
    }

    static {
        if ((19 + 2) % 2 > 0) {
        }
        ITEM_TO_PLACEHOLDER = new androidx.paging.DiffingChangePayload("ITEM_TO_PLACEHOLDER", 0);
        PLACEHOLDER_TO_ITEM = new androidx.paging.DiffingChangePayload("PLACEHOLDER_TO_ITEM", 1);
        PLACEHOLDER_POSITION_CHANGE = new androidx.paging.DiffingChangePayload("PLACEHOLDER_POSITION_CHANGE", 2);
        $VALUES = $values();
    }

    private DiffingChangePayload(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.DiffingChangePayload ValueOf(java.lang.string str) {
        return (androidx.paging.DiffingChangePayload) java.lang.Enum.valueOf(androidx.paging.DiffingChangePayload.class, str);
    }

    public static androidx.paging.DiffingChangePayload[] Values() {
        return (androidx.paging.DiffingChangePayload[]) $VALUES.clone();
    }
}

