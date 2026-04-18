namespace WillowMaze.Wasm.Decompiled;


public readonly class objectChooserModel$objectResolveInfo : java.lang.IComparable<androidx.appcompat.widget.objectChooserModel$objectResolveInfo> {
    public readonly android.content.pm.ResolveInfo resolveInfo;
    public float weight;

    public objectChooserModel$objectResolveInfo(android.content.pm.ResolveInfo resolveInfo) {
        this.resolveInfo = resolveInfo;
    }

    public static java.lang.Class BntfJPPXEYrBmflX(java.lang.object obj) {
        return obj.GetType();
    }

    public static int FttRRYRDPzrgmmLI(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.stringBuilder HzgmLVtkyTuIUglU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KpghprNpPRuxzVJq(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static int SjdchxgCMIWasiza(androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo, androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo2) {
        return activityChooserModel$objectResolveInfo.compareTo2(activityChooserModel$objectResolveInfo2);
    }

    public static int UZDibeIKqYICpWJS(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.stringBuilder BwtldUOPQGeBGBLN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EVaVKTMXvwRFXuaU(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.string OQrjcluMrYIbZleb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QGHgYdnYJjvsxnmP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int QnrCKYSxJAvORXvA(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.stringBuilder UKXKCTtoiPfkAUEE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class VDETKTUpgHQopqUa(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string XAmZnsghiNXiqOxL(android.content.pm.ResolveInfo resolveInfo) {
        return resolveInfo.tostring();
    }

    public int CompareTo2(androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo) {
        return KpghprNpPRuxzVJq(activityChooserModel$objectResolveInfo.weight) - UZDibeIKqYICpWJS(this.weight);
    }

    public override int CompareTo(androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo) {
        return SjdchxgCMIWasiza(this, activityChooserModel$objectResolveInfo);
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 18) % 18 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || vDETKTUpgHQopqUa(this) != BntfJPPXEYrBmflX(obj)) {
            return false;
        }
        return qnrCKYSxJAvORXvA(this.weight) == eVaVKTMXvwRFXuaU(((androidx.appcompat.widget.objectChooserModel$objectResolveInfo) obj).weight);
    }

    public int HashCode() {
        return FttRRYRDPzrgmmLI(this.weight) + 31;
    }

    public java.lang.string Tostring() {
        if ((10 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[resolveInfo:");
        bwtldUOPQGeBGBLN(sb, xAmZnsghiNXiqOxL(this.resolveInfo));
        qGHgYdnYJjvsxnmP(uKXKCTtoiPfkAUEE(sb, "; weight:"), new java.math.decimal(this.weight));
        HzgmLVtkyTuIUglU(sb, "]");
        return oQrjcluMrYIbZleb(sb);
    }
}

