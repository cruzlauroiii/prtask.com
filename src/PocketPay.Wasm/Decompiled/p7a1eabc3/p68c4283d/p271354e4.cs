namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0002\b\t\n\u0002\u0010\u000e\n\u0002\b\u0004\bf\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0003H&J\b\u0010\u0005\u001a\u00020\u0003H&J\b\u0010\u0006\u001a\u00020\u0003H&J\b\u0010\u0007\u001a\u00020\u0003H&J\b\u0010\b\u001a\u00020\u0003H&J\b\u0010\t\u001a\u00020\u0003H&J\b\u0010\n\u001a\u00020\u0003H&J\u0018\u0010\u000b\u001a\u00020\u00032\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\rH&J\u0018\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\rH&¨\u0006\u0011"}, d2 = {"Lp7a1eabc3/p68c4283d/p271354e4;", "", "reportSaleGroupEvent", "", "reportSaleSearchEvent", "reportSaleGoodEvent", "reportConcreteGroupDeleteEvent", "reportConcreteGroupDeleteDeleteEvent", "reportConcreteGroupDeleteCancelEvent", "reportGroupAlertRepeatEvent", "reportGroupAlertCancelEvent", "reportCreateInventoryEvent", "creationStatus", "", "inventoryType", "reportEditInventoryEvent", "editStatus", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p271354e4 {
    void reportConcreteGroupDeleteCancelEvent();

    void reportConcreteGroupDeleteDeleteEvent();

    void reportConcreteGroupDeleteEvent();

    void reportCreateInventoryEvent(java.lang.string creationStatus, java.lang.string inventoryType);

    void reportEditInventoryEvent(java.lang.string editStatus, java.lang.string inventoryType);

    void reportGroupAlertCancelEvent();

    void reportGroupAlertRepeatEvent();

    void reportSaleGoodEvent();

    void reportSaleGroupEvent();

    void reportSaleSearchEvent();
}

