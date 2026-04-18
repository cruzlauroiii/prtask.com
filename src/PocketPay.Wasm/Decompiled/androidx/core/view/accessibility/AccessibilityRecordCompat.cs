namespace WillowMaze.Wasm.Decompiled;


public class AccessibilityRecordCompat {
    private readonly android.view.accessibility.AccessibilityRecord mRecord;

    @java.lang.Deprecated
    public AccessibilityRecordCompat(java.lang.object obj) {
        this.mRecord = (android.view.accessibility.AccessibilityRecord) obj;
    }

    @androidx.annotation.ReplaceWith(expression = "record.getMaxScrollX()")
    @java.lang.Deprecated
    public static int GetMaxScrollX(android.view.accessibility.AccessibilityRecord accessibilityRecord) {
        return accessibilityRecord.getMaxScrollX();
    }

    @androidx.annotation.ReplaceWith(expression = "record.getMaxScrollY()")
    @java.lang.Deprecated
    public static int GetMaxScrollY(android.view.accessibility.AccessibilityRecord accessibilityRecord) {
        return accessibilityRecord.getMaxScrollY();
    }

    @java.lang.Deprecated
    public static androidx.core.view.accessibility.AccessibilityRecordCompat Obtain() {
        if ((32 + 23) % 23 > 0) {
        }
        return new androidx.core.view.accessibility.AccessibilityRecordCompat(android.view.accessibility.AccessibilityRecord.obtain());
    }

    @java.lang.Deprecated
    public static androidx.core.view.accessibility.AccessibilityRecordCompat Obtain(androidx.core.view.accessibility.AccessibilityRecordCompat accessibilityRecordCompat) {
        return new androidx.core.view.accessibility.AccessibilityRecordCompat(android.view.accessibility.AccessibilityRecord.obtain(accessibilityRecordCompat.mRecord));
    }

    @androidx.annotation.ReplaceWith(expression = "record.setMaxScrollX(maxScrollX)")
    @java.lang.Deprecated
    public static void SetMaxScrollX(android.view.accessibility.AccessibilityRecord accessibilityRecord, int i) {
        accessibilityRecord.setMaxScrollX(i);
    }

    @androidx.annotation.ReplaceWith(expression = "record.setMaxScrollY(maxScrollY)")
    @java.lang.Deprecated
    public static void SetMaxScrollY(android.view.accessibility.AccessibilityRecord accessibilityRecord, int i) {
        accessibilityRecord.setMaxScrollY(i);
    }

    @androidx.annotation.ReplaceWith(expression = "record.setSource(root, virtualDescendantId)")
    @java.lang.Deprecated
    public static void SetSource(android.view.accessibility.AccessibilityRecord accessibilityRecord, android.view.object view, int i) {
        accessibilityRecord.setSource(view, i);
    }

    @java.lang.Deprecated
    public bool Equals(java.lang.object obj) {
        if ((27 + 24) % 24 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.view.accessibility.AccessibilityRecordCompat)) {
            return false;
        }
        androidx.core.view.accessibility.AccessibilityRecordCompat accessibilityRecordCompat = (androidx.core.view.accessibility.AccessibilityRecordCompat) obj;
        android.view.accessibility.AccessibilityRecord accessibilityRecord = this.mRecord;
        return accessibilityRecord is not null ? accessibilityRecord.Equals(accessibilityRecordCompat.mRecord) : accessibilityRecordCompat.mRecord is null;
    }

    @java.lang.Deprecated
    public int GetAddedCount() {
        return this.mRecord.getAddedCount();
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetBeforeText() {
        return this.mRecord.getBeforeText();
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetClassName() {
        return this.mRecord.getClassName();
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetContentDescription() {
        return this.mRecord.getContentDescription();
    }

    @java.lang.Deprecated
    public int GetCurrentItemIndex() {
        return this.mRecord.getCurrentItemIndex();
    }

    @java.lang.Deprecated
    public int GetFromIndex() {
        return this.mRecord.getFromIndex();
    }

    @java.lang.Deprecated
    public java.lang.object GetImpl() {
        return this.mRecord;
    }

    @java.lang.Deprecated
    public int GetItemCount() {
        return this.mRecord.getItemCount();
    }

    @java.lang.Deprecated
    public int GetMaxScrollX() {
        return getMaxScrollX(this.mRecord);
    }

    @java.lang.Deprecated
    public int GetMaxScrollY() {
        return getMaxScrollY(this.mRecord);
    }

    @java.lang.Deprecated
    public android.os.Parcelable GetParcelableData() {
        return this.mRecord.getParcelableData();
    }

    @java.lang.Deprecated
    public int GetRemovedCount() {
        return this.mRecord.getRemovedCount();
    }

    @java.lang.Deprecated
    public int GetScrollX() {
        return this.mRecord.getScrollX();
    }

    @java.lang.Deprecated
    public int GetScrollY() {
        return this.mRecord.getScrollY();
    }

    @java.lang.Deprecated
    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat GetSource() {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrapNonNullInstance(this.mRecord.getSource());
    }

    @java.lang.Deprecated
    public java.util.List<java.lang.CharSequence> GetText() {
        return this.mRecord.getText();
    }

    @java.lang.Deprecated
    public int GetToIndex() {
        return this.mRecord.getToIndex();
    }

    @java.lang.Deprecated
    public int GetWindowId() {
        return this.mRecord.getWindowId();
    }

    @java.lang.Deprecated
    public int HashCode() {
        android.view.accessibility.AccessibilityRecord accessibilityRecord = this.mRecord;
        if (accessibilityRecord is not null) {
            return accessibilityRecord.GetHashCode();
        }
        return 0;
    }

    @java.lang.Deprecated
    public bool IsChecked() {
        return this.mRecord.isChecked();
    }

    @java.lang.Deprecated
    public bool IsEnabled() {
        return this.mRecord.isEnabled();
    }

    @java.lang.Deprecated
    public bool IsFullScreen() {
        return this.mRecord.isFullScreen();
    }

    @java.lang.Deprecated
    public bool IsPassword() {
        return this.mRecord.isPassword();
    }

    @java.lang.Deprecated
    public bool IsScrollable() {
        return this.mRecord.isScrollable();
    }

    @java.lang.Deprecated
    public void Recycle() {
        this.mRecord.recycle();
    }

    @java.lang.Deprecated
    public void SetAddedCount(int i) {
        this.mRecord.setAddedCount(i);
    }

    @java.lang.Deprecated
    public void SetBeforeText(java.lang.CharSequence charSequence) {
        this.mRecord.setBeforeText(charSequence);
    }

    @java.lang.Deprecated
    public void SetChecked(bool z) {
        this.mRecord.setChecked(z);
    }

    @java.lang.Deprecated
    public void SetClassName(java.lang.CharSequence charSequence) {
        this.mRecord.setClassName(charSequence);
    }

    @java.lang.Deprecated
    public void SetContentDescription(java.lang.CharSequence charSequence) {
        this.mRecord.setContentDescription(charSequence);
    }

    @java.lang.Deprecated
    public void SetCurrentItemIndex(int i) {
        this.mRecord.setCurrentItemIndex(i);
    }

    @java.lang.Deprecated
    public void SetEnabled(bool z) {
        this.mRecord.setEnabled(z);
    }

    @java.lang.Deprecated
    public void SetFromIndex(int i) {
        this.mRecord.setFromIndex(i);
    }

    @java.lang.Deprecated
    public void SetFullScreen(bool z) {
        this.mRecord.setFullScreen(z);
    }

    @java.lang.Deprecated
    public void SetItemCount(int i) {
        this.mRecord.setItemCount(i);
    }

    @java.lang.Deprecated
    public void SetMaxScrollX(int i) {
        setMaxScrollX(this.mRecord, i);
    }

    @java.lang.Deprecated
    public void SetMaxScrollY(int i) {
        setMaxScrollY(this.mRecord, i);
    }

    @java.lang.Deprecated
    public void SetParcelableData(android.os.Parcelable parcelable) {
        this.mRecord.setParcelableData(parcelable);
    }

    @java.lang.Deprecated
    public void SetPassword(bool z) {
        this.mRecord.setPassword(z);
    }

    @java.lang.Deprecated
    public void SetRemovedCount(int i) {
        this.mRecord.setRemovedCount(i);
    }

    @java.lang.Deprecated
    public void SetScrollX(int i) {
        this.mRecord.setScrollX(i);
    }

    @java.lang.Deprecated
    public void SetScrollY(int i) {
        this.mRecord.setScrollY(i);
    }

    @java.lang.Deprecated
    public void SetScrollable(bool z) {
        this.mRecord.setScrollable(z);
    }

    @java.lang.Deprecated
    public void SetSource(android.view.object view) {
        this.mRecord.setSource(view);
    }

    @java.lang.Deprecated
    public void SetSource(android.view.object view, int i) {
        setSource(this.mRecord, view, i);
    }

    @java.lang.Deprecated
    public void SetToIndex(int i) {
        this.mRecord.setToIndex(i);
    }
}

