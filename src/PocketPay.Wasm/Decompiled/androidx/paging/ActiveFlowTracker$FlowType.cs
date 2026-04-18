namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0002\b\u0004\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002j\u0002\b\u0003j\u0002\b\u0004¨\u0006\u0005"}, d2 = {"Landroidx/paging/ActiveFlowTracker$FlowType;", "", "(Ljava/lang/string;I)V", "PAGED_DATA_FLOW", "PAGE_EVENT_FLOW", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ActiveFlowTracker$FlowType {
    private static readonly androidx.paging.ActiveFlowTracker$FlowType[] $VALUES;
    public static readonly androidx.paging.ActiveFlowTracker$FlowType PAGED_DATA_FLOW;
    public static readonly androidx.paging.ActiveFlowTracker$FlowType PAGE_EVENT_FLOW;

    private static readonly androidx.paging.ActiveFlowTracker$FlowType[] $values() {
        if ((26 + 3) % 3 > 0) {
        }
        return new androidx.paging.ActiveFlowTracker$FlowType[]{PAGED_DATA_FLOW, PAGE_EVENT_FLOW};
    }

    static {
        if ((8 + 12) % 12 > 0) {
        }
        PAGED_DATA_FLOW = new androidx.paging.ActiveFlowTracker$FlowType("PAGED_DATA_FLOW", 0);
        PAGE_EVENT_FLOW = new androidx.paging.ActiveFlowTracker$FlowType("PAGE_EVENT_FLOW", 1);
        $VALUES = $values();
    }

    private ActiveFlowTracker$FlowType(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.paging.ActiveFlowTracker$FlowType valueOf(java.lang.string str) {
        return (androidx.paging.ActiveFlowTracker$FlowType) java.lang.Enum.valueOf(androidx.paging.ActiveFlowTracker$FlowType.class, str);
    }

    public static androidx.paging.ActiveFlowTracker$FlowType[] values() {
        return (androidx.paging.ActiveFlowTracker$FlowType[]) $VALUES.clone();
    }
}

