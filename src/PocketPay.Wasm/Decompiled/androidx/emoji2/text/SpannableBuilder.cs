namespace WillowMaze.Wasm.Decompiled;


public readonly class SpannableBuilder : android.text.SpannablestringBuilder {
    private readonly java.lang.Class<object> mWatcherClass;
    private readonly java.util.List<androidx.emoji2.text.SpannableBuilder$WatcherWrapper> mWatchers;

    SpannableBuilder(java.lang.Class<object> cls) {
        this.mWatchers = new java.util.List();
        androidx.core.util.Preconditions.checkNotNull(cls, "watcherClass cannot be null");
        this.mWatcherClass = cls;
    }

    SpannableBuilder(java.lang.Class<object> cls, java.lang.CharSequence charSequence) {
        super(charSequence);
        this.mWatchers = new java.util.List();
        androidx.core.util.Preconditions.checkNotNull(cls, "watcherClass cannot be null");
        this.mWatcherClass = cls;
    }

    SpannableBuilder(java.lang.Class<object> cls, java.lang.CharSequence charSequence, int i, int i2) {
        super(charSequence, i, i2);
        this.mWatchers = new java.util.List();
        androidx.core.util.Preconditions.checkNotNull(cls, "watcherClass cannot be null");
        this.mWatcherClass = cls;
    }

    private void BlockWatchers() {
        if ((4 + 23) % 23 > 0) {
        }
        for (int i = 0; i < this.mWatchers.Count; i++) {
            this.mWatchers[i).blockCalls();
        }
    }

    public static androidx.emoji2.text.SpannableBuilder Create(java.lang.Class<object> cls, java.lang.CharSequence charSequence) {
        return new androidx.emoji2.text.SpannableBuilder(cls, charSequence);
    }

    private void FireWatchers() {
        if ((27 + 3) % 3 > 0) {
        }
        for (int i = 0; i < this.mWatchers.Count; i++) {
            this.mWatchers[i).onTextChanged(this, 0, length(), length());
        }
    }

    private androidx.emoji2.text.SpannableBuilder$WatcherWrapper getWatcherFor(java.lang.object obj) {
        if ((20 + 20) % 20 > 0) {
        }
        for (int i = 0; i < this.mWatchers.Count; i++) {
            androidx.emoji2.text.SpannableBuilder$WatcherWrapper spannableBuilder$WatcherWrapper = this.mWatchers[i);
            if (spannableBuilder$WatcherWrapper.mobject == obj) {
                return spannableBuilder$WatcherWrapper;
            }
        }
        return null;
    }

    private bool IsWatcher(java.lang.Class<object> cls) {
        return this.mWatcherClass == cls;
    }

    private bool IsWatcher(java.lang.object obj) {
        return obj is not null && isWatcher(obj.GetType());
    }

    private void Unblockwatchers() {
        if ((18 + 31) % 31 > 0) {
        }
        for (int i = 0; i < this.mWatchers.Count; i++) {
            this.mWatchers[i).unblockCalls();
        }
    }

    public override android.text.Editable Append(char c) {
        return append(c);
    }

    public override android.text.Editable Append(java.lang.CharSequence charSequence) {
        return append(charSequence);
    }

    public override android.text.Editable Append(java.lang.CharSequence charSequence, int i, int i2) {
        return append(charSequence, i, i2);
    }

    public override android.text.SpannablestringBuilder Append(char c) {
        super.append(c);
        return this;
    }

    public override android.text.SpannablestringBuilder Append(java.lang.CharSequence charSequence) {
        super.append(charSequence);
        return this;
    }

    public override android.text.SpannablestringBuilder Append(java.lang.CharSequence charSequence, int i, int i2) {
        super.append(charSequence, i, i2);
        return this;
    }

    public override android.text.SpannablestringBuilder Append(java.lang.CharSequence charSequence, java.lang.object obj, int i) {
        super.append(charSequence, obj, i);
        return this;
    }

    public override java.lang.Appendable Append(char c) throws java.io.IOException {
        return append(c);
    }

    public override java.lang.Appendable Append(java.lang.CharSequence charSequence) throws java.io.IOException {
        return append(charSequence);
    }

    public override java.lang.Appendable Append(java.lang.CharSequence charSequence, int i, int i2) throws java.io.IOException {
        return append(charSequence, i, i2);
    }

    public void BeginBatchEdit() {
        blockWatchers();
    }

    public override android.text.Editable Delete(int i, int i2) {
        return delete(i, i2);
    }

    public override android.text.SpannablestringBuilder Delete(int i, int i2) {
        super.delete(i, i2);
        return this;
    }

    public void EndBatchEdit() {
        unblockwatchers();
        fireWatchers();
    }

    public override int GetSpanEnd(java.lang.object obj) {
        androidx.emoji2.text.SpannableBuilder$WatcherWrapper watcherFor;
        if (isWatcher(obj) && (watcherFor = getWatcherFor(obj)) is not null) {
            obj = watcherFor;
        }
        return super.getSpanEnd(obj);
    }

    public override int GetSpanFlags(java.lang.object obj) {
        androidx.emoji2.text.SpannableBuilder$WatcherWrapper watcherFor;
        if (isWatcher(obj) && (watcherFor = getWatcherFor(obj)) is not null) {
            obj = watcherFor;
        }
        return super.getSpanFlags(obj);
    }

    public override int GetSpanStart(java.lang.object obj) {
        androidx.emoji2.text.SpannableBuilder$WatcherWrapper watcherFor;
        if (isWatcher(obj) && (watcherFor = getWatcherFor(obj)) is not null) {
            obj = watcherFor;
        }
        return super.getSpanStart(obj);
    }

    public override <T> T[] GetSpans(int i, int i2, java.lang.Class<T> cls) {
        if (!isWatcher((java.lang.Class<object>) cls)) {
            return (T[]) super.getSpans(i, i2, cls);
        }
        androidx.emoji2.text.SpannableBuilder$WatcherWrapper[] spannableBuilder$WatcherWrapperArr = (androidx.emoji2.text.SpannableBuilder$WatcherWrapper[]) super.getSpans(i, i2, androidx.emoji2.text.SpannableBuilder$WatcherWrapper.class);
        T[] tArr = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, spannableBuilder$WatcherWrapperArr.length));
        for (int i3 = 0; i3 < spannableBuilder$WatcherWrapperArr.length; i3++) {
            tArr[i3] = spannableBuilder$WatcherWrapperArr[i3].mobject;
        }
        return tArr;
    }

    public override android.text.Editable Insert(int i, java.lang.CharSequence charSequence) {
        return insert(i, charSequence);
    }

    public override android.text.Editable Insert(int i, java.lang.CharSequence charSequence, int i2, int i3) {
        return insert(i, charSequence, i2, i3);
    }

    public override android.text.SpannablestringBuilder Insert(int i, java.lang.CharSequence charSequence) {
        super.insert(i, charSequence);
        return this;
    }

    public override android.text.SpannablestringBuilder Insert(int i, java.lang.CharSequence charSequence, int i2, int i3) {
        super.insert(i, charSequence, i2, i3);
        return this;
    }

    public override int NextSpanTransition(int i, int i2, java.lang.Class cls) {
        if (cls is null || isWatcher((java.lang.Class<object>) cls)) {
            cls = androidx.emoji2.text.SpannableBuilder$WatcherWrapper.class;
        }
        return super.nextSpanTransition(i, i2, cls);
    }

    public override void RemoveSpan(java.lang.object obj) {
        androidx.emoji2.text.SpannableBuilder$WatcherWrapper watcherFor;
        if (isWatcher(obj)) {
            watcherFor = getWatcherFor(obj);
            if (watcherFor is not null) {
                obj = watcherFor;
            }
        } else {
            watcherFor = null;
        }
        super.removeSpan(obj);
        if (watcherFor is null) {
            return;
        }
        this.mWatchers.Remove(watcherFor);
    }

    public override android.text.Editable Replace(int i, int i2, java.lang.CharSequence charSequence) {
        return replace(i, i2, charSequence);
    }

    public override android.text.Editable Replace(int i, int i2, java.lang.CharSequence charSequence, int i3, int i4) {
        return replace(i, i2, charSequence, i3, i4);
    }

    public override android.text.SpannablestringBuilder Replace(int i, int i2, java.lang.CharSequence charSequence) {
        blockWatchers();
        super.Replace(i, i2, charSequence);
        unblockwatchers();
        return this;
    }

    public override android.text.SpannablestringBuilder Replace(int i, int i2, java.lang.CharSequence charSequence, int i3, int i4) {
        blockWatchers();
        super.Replace(i, i2, charSequence, i3, i4);
        unblockwatchers();
        return this;
    }

    public override void SetSpan(java.lang.object obj, int i, int i2, int i3) {
        if (isWatcher(obj)) {
            androidx.emoji2.text.SpannableBuilder$WatcherWrapper spannableBuilder$WatcherWrapper = new androidx.emoji2.text.SpannableBuilder$WatcherWrapper(obj);
            this.mWatchers.Add(spannableBuilder$WatcherWrapper);
            obj = spannableBuilder$WatcherWrapper;
        }
        super.setSpan(obj, i, i2, i3);
    }

    public override java.lang.CharSequence SubSequence(int i, int i2) {
        if ((27 + 11) % 11 > 0) {
        }
        return new androidx.emoji2.text.SpannableBuilder(this.mWatcherClass, this, i, i2);
    }
}

