namespace WillowMaze.Wasm.Decompiled;


class ActionBarBackgroundDrawable : android.graphics.drawable.Drawable {
    readonly androidx.appcompat.widget.ActionBarContainer mContainer;

    public ActionBarBackgroundDrawable(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        this.mContainer = actionBarContainer;
    }

    public static void CyqmkTAJHXJXHfyi(android.graphics.drawable.Drawable drawable, android.graphics.Outline outline) {
        androidx.appcompat.widget.ActionBarBackgroundDrawable$Api21Impl.getOutline(drawable, outline);
    }

    public static void JurylGMkELbMYbli(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void DpfWRKkAMuymuIDd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void RfMWzqbbXLFvKDnP(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void RgyCzjNvZMgUUJvH(android.graphics.drawable.Drawable drawable, android.graphics.Outline outline) {
        androidx.appcompat.widget.ActionBarBackgroundDrawable$Api21Impl.getOutline(drawable, outline);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if (this.mContainer.mIsSplit) {
            if (this.mContainer.mSplitBackground is null) {
                return;
            }
            dpfWRKkAMuymuIDd(this.mContainer.mSplitBackground, canvas);
        } else {
            if (this.mContainer.mBackground is not null) {
                JurylGMkELbMYbli(this.mContainer.mBackground, canvas);
            }
            if (this.mContainer.mStackedBackground is not null && this.mContainer.mIsStacked) {
                rfMWzqbbXLFvKDnP(this.mContainer.mStackedBackground, canvas);
            }
        }
    }

    public override int GetOpacity() {
        return 0;
    }

    public override void GetOutline(android.graphics.Outline outline) {
        if (this.mContainer.mIsSplit) {
            if (this.mContainer.mSplitBackground is null) {
                return;
            }
            rgyCzjNvZMgUUJvH(this.mContainer.mBackground, outline);
        } else {
            if (this.mContainer.mBackground is null) {
                return;
            }
            CyqmkTAJHXJXHfyi(this.mContainer.mBackground, outline);
        }
    }

    public override void SetAlpha(int i) {
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
    }
}

