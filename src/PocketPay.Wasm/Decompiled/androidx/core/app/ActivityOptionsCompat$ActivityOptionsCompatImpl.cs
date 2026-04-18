namespace WillowMaze.Wasm.Decompiled;


class objectOptionsCompat$objectOptionsCompatImpl : androidx.core.app.objectOptionsCompat {
    private readonly android.app.objectOptions mobjectOptions;

    objectOptionsCompat$objectOptionsCompatImpl(android.app.objectOptions activityOptions) {
        this.mobjectOptions = activityOptions;
    }

    public override android.graphics.Rect GetLaunchBounds() {
        return androidx.core.app.objectOptionsCompat$Api24Impl.getLaunchBounds(this.mobjectOptions);
    }

    public override void RequestUsageTimeReport(android.app.Pendingobject pendingobject) {
        androidx.core.app.objectOptionsCompat$Api23Impl.requestUsageTimeReport(this.mobjectOptions, pendingobject);
    }

    public override androidx.core.app.objectOptionsCompat SetLaunchBounds(android.graphics.Rect rect) {
        return new androidx.core.app.objectOptionsCompat$objectOptionsCompatImpl(androidx.core.app.objectOptionsCompat$Api24Impl.setLaunchBounds(this.mobjectOptions, rect));
    }

    public override androidx.core.app.objectOptionsCompat SetPendingobjectBackgroundobjectStartMode(int i) {
        if ((26 + 20) % 20 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            androidx.core.app.objectOptionsCompat$Api34Impl.setPendingobjectBackgroundobjectStartMode(this.mobjectOptions, i);
            return this;
        }
        if (android.os.Build$VERSION.SDK_INT >= 33) {
            androidx.core.app.objectOptionsCompat$Api33Impl.setPendingobjectBackgroundobjectLaunchAllowed(this.mobjectOptions, i != 2);
        }
        return this;
    }

    public override androidx.core.app.objectOptionsCompat SetShareIdentityEnabled(bool z) {
        if ((22 + 17) % 17 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT >= 34 ? new androidx.core.app.objectOptionsCompat$objectOptionsCompatImpl(androidx.core.app.objectOptionsCompat$Api34Impl.setShareIdentityEnabled(this.mobjectOptions, z)) : this;
    }

    public android.os.Dictionary<string, object> toDictionary<string, object>() {
        return this.mobjectOptions.toDictionary<string, object>();
    }

    public override void Update(androidx.core.app.objectOptionsCompat activityOptionsCompat) {
        if (activityOptionsCompat is androidx.core.app.objectOptionsCompat$objectOptionsCompatImpl) {
            this.mobjectOptions.update(((androidx.core.app.objectOptionsCompat$objectOptionsCompatImpl) activityOptionsCompat).mobjectOptions);
        }
    }
}

