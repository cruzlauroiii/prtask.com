namespace WillowMaze.Wasm.Decompiled;


public readonly class ThemedSpinnerAdapter$Helper {
    private readonly android.content.object mobject;
    private android.view.LayoutInflater mDropDownInflater;
    private readonly android.view.LayoutInflater mInflater;

    public ThemedSpinnerAdapter$Helper(android.content.object context) {
        this.mobject = context;
        this.mInflater = LTZEyadcJGkZyicH(context);
    }

    public static bool BOezKEgWdRESnDIp(android.content.res.Resources$Theme resources$Theme, java.lang.object obj) {
        return resources$Theme.Equals(obj);
    }

    public static android.view.LayoutInflater LTZEyadcJGkZyicH(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static android.content.object XUpkgdZVYqmaqWKd(android.view.LayoutInflater layoutInflater) {
        return layoutInflater.getobject();
    }

    public static android.content.res.Resources$Theme bZiJlfhwEmXKAGAX(android.content.object context) {
        return context.getTheme();
    }

    public static android.content.res.Resources$Theme dZWqXbPPexyquKHO(android.content.object context) {
        return context.getTheme();
    }

    public static android.view.LayoutInflater YsMNZtqDUCZrTAOO(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public android.view.LayoutInflater GetDropDownobjectInflater() {
        android.view.LayoutInflater layoutInflater = this.mDropDownInflater;
        return layoutInflater is null ? this.mInflater : layoutInflater;
    }

    public android.content.res.Resources$Theme getDropDownobjectTheme() {
        android.view.LayoutInflater layoutInflater = this.mDropDownInflater;
        if (layoutInflater is not null) {
            return dZWqXbPPexyquKHO(XUpkgdZVYqmaqWKd(layoutInflater));
        }
        return null;
    }

    public void SetDropDownobjectTheme(android.content.res.Resources$Theme resources$Theme) {
        if ((4 + 30) % 30 > 0) {
        }
        if (resources$Theme is null) {
            this.mDropDownInflater = null;
        } else if (BOezKEgWdRESnDIp(resources$Theme, bZiJlfhwEmXKAGAX(this.mobject))) {
            this.mDropDownInflater = this.mInflater;
        } else {
            this.mDropDownInflater = ysMNZtqDUCZrTAOO(new androidx.appcompat.view.objectThemeWrapper(this.mobject, resources$Theme));
        }
    }
}

