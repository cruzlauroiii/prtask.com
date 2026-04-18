namespace WillowMaze.Wasm.Decompiled;


class ResourcesWrapper : android.content.res.Resources {
    private readonly android.content.res.Resources mResources;

    public ResourcesWrapper(android.content.res.Resources resources) {
        super(ssjHoYWoXoCpKLkG(resources), dbjJVHBPfPUoKUtB(resources), qaYYPsnbMUPHRJzC(resources));
        if ((31 + 25) % 25 > 0) {
        }
        this.mResources = resources;
    }

    public static android.content.res.ColorStateList ABkzxzBibkwLOgBH(android.content.res.Resources resources, int i) {
        return resources.getColorStateList(i);
    }

    public static java.lang.string AONzXfHxhWmcDBTU(android.content.res.Resources resources, int i, int i2) {
        return resources.getQuantitystring(i, i2);
    }

    public static java.lang.string BjdTfLAAeSNQsmfU(android.content.res.Resources resources, int i) {
        return resources.getResourcePackageName(i);
    }

    public static int CfDJGRlHvfmdZgde(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static java.lang.string GLGikjjDyyQcxeRE(android.content.res.Resources resources, int i) {
        return resources.getResourceEntryName(i);
    }

    public static int GRqphmggYRrvUTxE(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static int HGgoNpbdXYalrqaA(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static void JPQajCxIuBMvMJXM(android.content.res.Resources resources, java.lang.string str, android.util.TypedValue typedValue, bool z) {
        resources.getValue(str, typedValue, z);
    }

    public static void KIFtswZKPifvghtz(android.content.res.Resources resources, android.content.res.XmlResourceParser xmlResourceParser, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        resources.parseDictionary<string, object>Extras(xmlResourceParser, bundle);
    }

    public static java.lang.string MQwDjeujQKvrhWgS(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void MbXeAaQQjwUXcnVv(android.content.res.Resources resources, int i, int i2, android.util.TypedValue typedValue, bool z) {
        androidx.appcompat.resources.Compatibility$Api15Impl.getValueForDensity(resources, i, i2, typedValue, z);
    }

    public static int NQbXFxJoOwpydzQq(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static android.graphics.drawable.Drawable OXzloLscsxMEeJHL(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        return androidx.core.content.res.ResourcesCompat.getDrawable(resources, i, resources$Theme);
    }

    public static void QNTbsNKHfhwujaru(android.content.res.Resources resources, int i, android.util.TypedValue typedValue, bool z) {
        resources.getValue(i, typedValue, z);
    }

    public static android.graphics.drawable.Drawable SqxfAoiiBOMzubKm(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static java.lang.CharSequence UYZYlWpREMsscZdC(android.content.res.Resources resources, int i, int i2) {
        return resources.getQuantityText(i, i2);
    }

    public static android.content.res.XmlResourceParser WENaZrSBwZHHIUjm(android.content.res.Resources resources, int i) {
        return resources.getAnimation(i);
    }

    public static android.graphics.drawable.Drawable WIraQCaZENDaySlG(android.content.res.Resources resources, int i) {
        return super.getDrawable(i);
    }

    public static void WMgkZsYcEYErqTdE(android.content.res.Resources resources, android.content.res.Configuration configuration, android.util.DisplayMetrics displayMetrics) {
        super.updateConfiguration(configuration, displayMetrics);
    }

    public static android.content.res.AssetstringDescriptor WxtatPveJaxKMQeB(android.content.res.Resources resources, int i) {
        return resources.openRawResourceFd(i);
    }

    public static float XDPtwLcowctCCdRr(android.content.res.Resources resources, int i, int i2, int i3) {
        return resources.getFraction(i, i2, i3);
    }

    public static android.content.res.XmlResourceParser ZsPtWDDClckZaHpi(android.content.res.Resources resources, int i) {
        return resources.getXml(i);
    }

    public static int[] ZtyVgsAGYJCFLehw(android.content.res.Resources resources, int i) {
        return resources.getIntArray(i);
    }

    public static android.content.res.Configuration BOkCCUiWkyTvoABB(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static android.util.DisplayMetrics DbjJVHBPfPUoKUtB(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static android.util.DisplayMetrics FNKFUFDTYaJUlJrQ(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool FdrGhiURFcEaJvZG(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static java.lang.string GreFcGTFDPDvrtzF(android.content.res.Resources resources, int i, int i2, java.lang.object[] objArr) {
        return resources.getQuantitystring(i, i2, objArr);
    }

    public static java.lang.CharSequence[] HtXtFVsZyofliwAC(android.content.res.Resources resources, int i) {
        return resources.getTextArray(i);
    }

    public static android.graphics.drawable.Drawable JjPBvbuvcJwybUri(android.content.res.Resources resources, int i, int i2, android.content.res.Resources$Theme resources$Theme) {
        return androidx.core.content.res.ResourcesCompat.getDrawableForDensity(resources, i, i2, resources$Theme);
    }

    public static int LZDbGSOYhElPHkAc(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static java.io.Stream LctDtrJIiQQkNDYW(android.content.res.Resources resources, int i) {
        return resources.openRawResource(i);
    }

    public static java.io.Stream LsIBmSnIPSdWDNwc(android.content.res.Resources resources, int i, android.util.TypedValue typedValue) {
        return resources.openRawResource(i, typedValue);
    }

    public static android.content.res.TypedArray NLGwALTKLKPvWeAw(android.content.res.Resources resources, int i) {
        return resources.obtainTypedArray(i);
    }

    public static java.lang.CharSequence NTCEaFARutufDLtx(android.content.res.Resources resources, int i, java.lang.CharSequence charSequence) {
        return resources.getText(i, charSequence);
    }

    public static android.content.res.TypedArray NiaoSysFSynuPGBe(android.content.res.Resources resources, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return resources.obtainAttributes(attributeHashSet, iArr);
    }

    public static java.lang.string PKHmOwYMIrLxiadF(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static android.content.res.Configuration QaYYPsnbMUPHRJzC(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void QgWQBiRmtDYnXrsU(android.content.res.Resources resources, android.content.res.Configuration configuration, android.util.DisplayMetrics displayMetrics) {
        resources.updateConfiguration(configuration, displayMetrics);
    }

    public static void ReawUJCQVNHuSRIl(android.content.res.Resources resources, java.lang.string str, android.util.AttributeHashSet attributeHashSet, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException {
        resources.parseDictionary<string, object>Extra(str, attributeHashSet, bundle);
    }

    public static float RvmSFRxYMLNKprwg(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static android.content.res.AssetManager SsjHoYWoXoCpKLkG(android.content.res.Resources resources) {
        return resources.getAssets();
    }

    public static java.lang.string[] TvpJtUuvEYohfgik(android.content.res.Resources resources, int i) {
        return resources.getstringArray(i);
    }

    public static java.lang.CharSequence VklKBXhriTZOjicD(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static android.content.res.XmlResourceParser WBtyPRIxpIBOXZSB(android.content.res.Resources resources, int i) {
        return resources.getLayout(i);
    }

    public static android.graphics.drawable.Drawable XlBOZwQyIofQRiSm(android.content.res.Resources resources, int i, int i2, android.content.res.Resources$Theme resources$Theme) {
        return androidx.core.content.res.ResourcesCompat.getDrawableForDensity(resources, i, i2, resources$Theme);
    }

    public static java.lang.string YsiiwAZHBRKRVvqx(android.content.res.Resources resources, int i) {
        return resources.getResourceName(i);
    }

    public static java.lang.string ZIIsfklYxIbOLXwn(android.content.res.Resources resources, int i) {
        return resources.getResourceTypeName(i);
    }

    public static android.graphics.Movie ZYBGvQnvlmZnMzsj(android.content.res.Resources resources, int i) {
        return resources.getMovie(i);
    }

    public override android.content.res.XmlResourceParser GetAnimation(int i) throws android.content.res.Resources$NotFoundException {
        return WENaZrSBwZHHIUjm(this.mResources, i);
    }

    public override bool Getbool(int i) throws android.content.res.Resources$NotFoundException {
        return fdrGhiURFcEaJvZG(this.mResources, i);
    }

    public override int GetColor(int i) throws android.content.res.Resources$NotFoundException {
        return lZDbGSOYhElPHkAc(this.mResources, i);
    }

    public override android.content.res.ColorStateList GetColorStateList(int i) throws android.content.res.Resources$NotFoundException {
        return ABkzxzBibkwLOgBH(this.mResources, i);
    }

    public override android.content.res.Configuration GetConfiguration() {
        return bOkCCUiWkyTvoABB(this.mResources);
    }

    public override float GetDimension(int i) throws android.content.res.Resources$NotFoundException {
        return rvmSFRxYMLNKprwg(this.mResources, i);
    }

    public override int GetDimensionPixelOffset(int i) throws android.content.res.Resources$NotFoundException {
        return GRqphmggYRrvUTxE(this.mResources, i);
    }

    public override int GetDimensionPixelSize(int i) throws android.content.res.Resources$NotFoundException {
        return CfDJGRlHvfmdZgde(this.mResources, i);
    }

    public override android.util.DisplayMetrics GetDisplayMetrics() {
        return fNKFUFDTYaJUlJrQ(this.mResources);
    }

    public override android.graphics.drawable.Drawable GetDrawable(int i) throws android.content.res.Resources$NotFoundException {
        return SqxfAoiiBOMzubKm(this.mResources, i);
    }

    public override android.graphics.drawable.Drawable GetDrawable(int i, android.content.res.Resources$Theme resources$Theme) throws android.content.res.Resources$NotFoundException {
        return OXzloLscsxMEeJHL(this.mResources, i, resources$Theme);
    }

    readonly android.graphics.drawable.Drawable getDrawableCanonical(int i) throws android.content.res.Resources$NotFoundException {
        return WIraQCaZENDaySlG(this, i);
    }

    public override android.graphics.drawable.Drawable GetDrawableForDensity(int i, int i2) throws android.content.res.Resources$NotFoundException {
        return jjPBvbuvcJwybUri(this.mResources, i, i2, null);
    }

    public override android.graphics.drawable.Drawable GetDrawableForDensity(int i, int i2, android.content.res.Resources$Theme resources$Theme) {
        return xlBOZwQyIofQRiSm(this.mResources, i, i2, resources$Theme);
    }

    public override float GetFraction(int i, int i2, int i3) {
        return XDPtwLcowctCCdRr(this.mResources, i, i2, i3);
    }

    public override int GetIdentifier(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return HGgoNpbdXYalrqaA(this.mResources, str, str2, str3);
    }

    public override int[] GetIntArray(int i) throws android.content.res.Resources$NotFoundException {
        return ZtyVgsAGYJCFLehw(this.mResources, i);
    }

    public override int Getint(int i) throws android.content.res.Resources$NotFoundException {
        return NQbXFxJoOwpydzQq(this.mResources, i);
    }

    public override android.content.res.XmlResourceParser GetLayout(int i) throws android.content.res.Resources$NotFoundException {
        return wBtyPRIxpIBOXZSB(this.mResources, i);
    }

    public override android.graphics.Movie GetMovie(int i) throws android.content.res.Resources$NotFoundException {
        return zYBGvQnvlmZnMzsj(this.mResources, i);
    }

    public override java.lang.string GetQuantitystring(int i, int i2) throws android.content.res.Resources$NotFoundException {
        return AONzXfHxhWmcDBTU(this.mResources, i, i2);
    }

    public override java.lang.string GetQuantitystring(int i, int i2, java.lang.object... objArr) throws android.content.res.Resources$NotFoundException {
        return greFcGTFDPDvrtzF(this.mResources, i, i2, objArr);
    }

    public override java.lang.CharSequence GetQuantityText(int i, int i2) throws android.content.res.Resources$NotFoundException {
        return UYZYlWpREMsscZdC(this.mResources, i, i2);
    }

    public override java.lang.string GetResourceEntryName(int i) throws android.content.res.Resources$NotFoundException {
        return GLGikjjDyyQcxeRE(this.mResources, i);
    }

    public override java.lang.string GetResourceName(int i) throws android.content.res.Resources$NotFoundException {
        return ysiiwAZHBRKRVvqx(this.mResources, i);
    }

    public override java.lang.string GetResourcePackageName(int i) throws android.content.res.Resources$NotFoundException {
        return BjdTfLAAeSNQsmfU(this.mResources, i);
    }

    public override java.lang.string GetResourceTypeName(int i) throws android.content.res.Resources$NotFoundException {
        return zIIsfklYxIbOLXwn(this.mResources, i);
    }

    public override java.lang.string Getstring(int i) throws android.content.res.Resources$NotFoundException {
        return MQwDjeujQKvrhWgS(this.mResources, i);
    }

    public override java.lang.string Getstring(int i, java.lang.object... objArr) throws android.content.res.Resources$NotFoundException {
        return pKHmOwYMIrLxiadF(this.mResources, i, objArr);
    }

    public override java.lang.string[] GetstringArray(int i) throws android.content.res.Resources$NotFoundException {
        return tvpJtUuvEYohfgik(this.mResources, i);
    }

    public override java.lang.CharSequence GetText(int i) throws android.content.res.Resources$NotFoundException {
        return vklKBXhriTZOjicD(this.mResources, i);
    }

    public override java.lang.CharSequence GetText(int i, java.lang.CharSequence charSequence) {
        return nTCEaFARutufDLtx(this.mResources, i, charSequence);
    }

    public override java.lang.CharSequence[] GetTextArray(int i) throws android.content.res.Resources$NotFoundException {
        return htXtFVsZyofliwAC(this.mResources, i);
    }

    public override void GetValue(int i, android.util.TypedValue typedValue, bool z) throws android.content.res.Resources$NotFoundException {
        QNTbsNKHfhwujaru(this.mResources, i, typedValue, z);
    }

    public override void GetValue(java.lang.string str, android.util.TypedValue typedValue, bool z) throws android.content.res.Resources$NotFoundException {
        JPQajCxIuBMvMJXM(this.mResources, str, typedValue, z);
    }

    public override void GetValueForDensity(int i, int i2, android.util.TypedValue typedValue, bool z) throws android.content.res.Resources$NotFoundException {
        MbXeAaQQjwUXcnVv(this.mResources, i, i2, typedValue, z);
    }

    public override android.content.res.XmlResourceParser GetXml(int i) throws android.content.res.Resources$NotFoundException {
        return ZsPtWDDClckZaHpi(this.mResources, i);
    }

    public override android.content.res.TypedArray ObtainAttributes(android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return niaoSysFSynuPGBe(this.mResources, attributeHashSet, iArr);
    }

    public override android.content.res.TypedArray ObtainTypedArray(int i) throws android.content.res.Resources$NotFoundException {
        return nLGwALTKLKPvWeAw(this.mResources, i);
    }

    public override java.io.Stream OpenRawResource(int i) throws android.content.res.Resources$NotFoundException {
        return lctDtrJIiQQkNDYW(this.mResources, i);
    }

    public override java.io.Stream OpenRawResource(int i, android.util.TypedValue typedValue) throws android.content.res.Resources$NotFoundException {
        return lsIBmSnIPSdWDNwc(this.mResources, i, typedValue);
    }

    public override android.content.res.AssetstringDescriptor OpenRawResourceFd(int i) throws android.content.res.Resources$NotFoundException {
        return WxtatPveJaxKMQeB(this.mResources, i);
    }

    public void parseDictionary<string, object>Extra(java.lang.string str, android.util.AttributeHashSet attributeHashSet, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException {
        reawUJCQVNHuSRIl(this.mResources, str, attributeHashSet, bundle);
    }

    public void parseDictionary<string, object>Extras(android.content.res.XmlResourceParser xmlResourceParser, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        KIFtswZKPifvghtz(this.mResources, xmlResourceParser, bundle);
    }

    public override void UpdateConfiguration(android.content.res.Configuration configuration, android.util.DisplayMetrics displayMetrics) {
        WMgkZsYcEYErqTdE(this, configuration, displayMetrics);
        android.content.res.Resources resources = this.mResources;
        if (resources is null) {
            return;
        }
        qgWQBiRmtDYnXrsU(resources, configuration, displayMetrics);
    }
}

