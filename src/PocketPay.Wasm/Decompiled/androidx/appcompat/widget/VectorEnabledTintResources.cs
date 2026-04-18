namespace WillowMaze.Wasm.Decompiled;


public class VectorEnabledTintResources : androidx.appcompat.widget.ResourcesWrapper {
    public static readonly int MAX_SDK_WHERE_REQUIRED = 20;
    private static bool sCompatVectorFromResourcesEnabled;
    private readonly java.lang.ref.WeakReference<android.content.object> mobjectRef;

    public VectorEnabledTintResources(android.content.object context, android.content.res.Resources resources) {
        super(resources);
        this.mobjectRef = new java.lang.ref.WeakReference<>(context);
    }

    public static android.graphics.drawable.Drawable AqkQtEXznpTiRMKs(androidx.appcompat.widget.VectorEnabledTintResources vectorEnabledTintResources, int i) {
        return vectorEnabledTintResources.getDrawableCanonical(i);
    }

    public static android.content.res.XmlResourceParser DhMjBGTFWqinbBAZ(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getXml(i);
    }

    public static void DyLkyggEaqfzktpS(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, android.util.TypedValue typedValue, bool z) {
        super.getValue(i, typedValue, z);
    }

    public static java.lang.string ESnzSeoBgSEIAaII(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, java.lang.object[] objArr) {
        return super.getstring(i, objArr);
    }

    public static android.graphics.drawable.Drawable EvynCqFziGvlaFre(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2, android.content.res.Resources$Theme resources$Theme) {
        return super.getDrawableForDensity(i, i2, resources$Theme);
    }

    public static android.content.res.TypedArray FCugiqaFqttfplgt(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return super.obtainAttributes(attributeHashSet, iArr);
    }

    public static android.content.res.Configuration IfslixKtgzomSCII(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper) {
        return super.getConfiguration();
    }

    public static float JVvaHvxAbgojIhAH(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2, int i3) {
        return super.getFraction(i, i2, i3);
    }

    public static java.lang.string[] JalDJiQqHYlDrqsf(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getstringArray(i);
    }

    public static android.graphics.Movie JzMcVUMPFZPqONQj(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getMovie(i);
    }

    public static java.lang.string NEMsSUlZkBkgHeVP(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2, java.lang.object[] objArr) {
        return super.getQuantitystring(i, i2, objArr);
    }

    public static android.content.res.ColorStateList QFFRnCEYGeyaPnZv(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getColorStateList(i);
    }

    public static java.lang.string QsuUgJWrZMUoUyFU(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2) {
        return super.getQuantitystring(i, i2);
    }

    public static android.graphics.drawable.Drawable RNjdFIJGynXwiudd(androidx.appcompat.widget.ResourceManagerInternal resourceManagerInternal, android.content.object context, androidx.appcompat.widget.VectorEnabledTintResources vectorEnabledTintResources, int i) {
        return resourceManagerInternal.onDrawableLoadedFromResources(context, vectorEnabledTintResources, i);
    }

    public static java.lang.object STzBnfetUZIjrAGW(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.string SebxdsAZzisPtpGF(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getResourceName(i);
    }

    public static bool UNjtSHOZkGHIGIdO(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getbool(i);
    }

    public static bool UoZggYhhHjYOIobw() {
        return isCompatVectorFromResourcesEnabled();
    }

    public static java.lang.CharSequence VsmUTEOWIIGOseQv(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getText(i);
    }

    public static int WwfMYqxmaZWURAbi(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getColor(i);
    }

    public static android.graphics.drawable.Drawable XkmeOkWEVJCcjlFX(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, android.content.res.Resources$Theme resources$Theme) {
        return super.getDrawable(i, resources$Theme);
    }

    public static android.content.res.XmlResourceParser YUwEzhZiLMKdPjak(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getLayout(i);
    }

    public static java.lang.string YhiGhyCKyApnzGAA(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getResourceTypeName(i);
    }

    public static int ZzXVRjndIMQoCBIe(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getint(i);
    }

    public static int DLhrKGxfGIUvrYMW(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return super.getIdentifier(str, str2, str3);
    }

    public static android.util.DisplayMetrics DyrISyIOxgitkxWZ(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper) {
        return super.getDisplayMetrics();
    }

    public static float GFAfPmIoogINIsJr(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getDimension(i);
    }

    public static void HHyakLjwvPqrLYWn(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, java.lang.string str, android.util.TypedValue typedValue, bool z) {
        super.getValue(str, typedValue, z);
    }

    public static android.content.res.AssetstringDescriptor HaAhCVgRqkKvIWEY(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.openRawResourceFd(i);
    }

    public static void IUXTAiXqkSVveVfD(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, android.content.res.XmlResourceParser xmlResourceParser, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        super.parseDictionary<string, object>Extras(xmlResourceParser, bundle);
    }

    public static android.content.res.XmlResourceParser IbnhtXeLpQbdPoPz(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getAnimation(i);
    }

    public static bool IsCompatVectorFromResourcesEnabled() {
        return sCompatVectorFromResourcesEnabled;
    }

    public static java.lang.CharSequence KLzBUjqbbalYrnlB(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2) {
        return super.getQuantityText(i, i2);
    }

    public static int[] LcoCXWfqYTXmUNKw(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getIntArray(i);
    }

    public static java.lang.CharSequence LsvKNaHDEcbiPvgP(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, java.lang.CharSequence charSequence) {
        return super.getText(i, charSequence);
    }

    public static java.lang.CharSequence[] LttITmsXPTuvmYDz(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getTextArray(i);
    }

    public static void NIxqkULtWFMbZjlA(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2, android.util.TypedValue typedValue, bool z) {
        super.getValueForDensity(i, i2, typedValue, z);
    }

    public static android.graphics.drawable.Drawable OPzUASTzMDfDmiZq(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, int i2) {
        return super.getDrawableForDensity(i, i2);
    }

    public static java.lang.string PbJejfXlDvDInpEC(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getstring(i);
    }

    public static java.io.Stream RYmbAYqACSYljzVe(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.openRawResource(i);
    }

    public static java.lang.string RkjzGhVFXFPjyTJz(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getResourcePackageName(i);
    }

    public static void SetCompatVectorFromResourcesEnabled(bool z) {
        sCompatVectorFromResourcesEnabled = z;
    }

    public static bool ShouldBeUsed() {
        UoZggYhhHjYOIobw();
        return false;
    }

    public static void UbzdbSbcLUnXpGhd(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, android.content.res.Configuration configuration, android.util.DisplayMetrics displayMetrics) {
        super.updateConfiguration(configuration, displayMetrics);
    }

    public static int UmzuKwovPAFubEMY(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getDimensionPixelSize(i);
    }

    public static androidx.appcompat.widget.ResourceManagerInternal VJGfwpglhlrFcroi() {
        return androidx.appcompat.widget.ResourceManagerInternal[);
    }

    public static int WVcsfmqZWpzTsasi(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getDimensionPixelOffset(i);
    }

    public static java.io.Stream XTrRQTcKQMqwlvUc(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i, android.util.TypedValue typedValue) {
        return super.openRawResource(i, typedValue);
    }

    public static void XnbLixrLqmPuIBaJ(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, java.lang.string str, android.util.AttributeHashSet attributeHashSet, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException {
        super.parseDictionary<string, object>Extra(str, attributeHashSet, bundle);
    }

    public static android.content.res.TypedArray ZDyqKXqKUfTYcpDM(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.obtainTypedArray(i);
    }

    public static java.lang.string ZPHquAFrhJdnAxkl(androidx.appcompat.widget.ResourcesWrapper resourcesWrapper, int i) {
        return super.getResourceEntryName(i);
    }

    public override android.content.res.XmlResourceParser GetAnimation(int i) throws android.content.res.Resources$NotFoundException {
        return ibnhtXeLpQbdPoPz(this, i);
    }

    public override bool Getbool(int i) throws android.content.res.Resources$NotFoundException {
        return UNjtSHOZkGHIGIdO(this, i);
    }

    public override int GetColor(int i) throws android.content.res.Resources$NotFoundException {
        return WwfMYqxmaZWURAbi(this, i);
    }

    public override android.content.res.ColorStateList GetColorStateList(int i) throws android.content.res.Resources$NotFoundException {
        return QFFRnCEYGeyaPnZv(this, i);
    }

    public override android.content.res.Configuration GetConfiguration() {
        return IfslixKtgzomSCII(this);
    }

    public override float GetDimension(int i) throws android.content.res.Resources$NotFoundException {
        return gFAfPmIoogINIsJr(this, i);
    }

    public override int GetDimensionPixelOffset(int i) throws android.content.res.Resources$NotFoundException {
        return wVcsfmqZWpzTsasi(this, i);
    }

    public override int GetDimensionPixelSize(int i) throws android.content.res.Resources$NotFoundException {
        return umzuKwovPAFubEMY(this, i);
    }

    public override android.util.DisplayMetrics GetDisplayMetrics() {
        return dyrISyIOxgitkxWZ(this);
    }

    public override android.graphics.drawable.Drawable GetDrawable(int i) throws android.content.res.Resources$NotFoundException {
        if ((24 + 7) % 7 > 0) {
        }
        android.content.object context = (android.content.object) STzBnfetUZIjrAGW(this.mobjectRef);
        return context is null ? AqkQtEXznpTiRMKs(this, i) : RNjdFIJGynXwiudd(vJGfwpglhlrFcroi(), context, this, i);
    }

    public override android.graphics.drawable.Drawable GetDrawable(int i, android.content.res.Resources$Theme resources$Theme) throws android.content.res.Resources$NotFoundException {
        return XkmeOkWEVJCcjlFX(this, i, resources$Theme);
    }

    public override android.graphics.drawable.Drawable GetDrawableForDensity(int i, int i2) throws android.content.res.Resources$NotFoundException {
        return oPzUASTzMDfDmiZq(this, i, i2);
    }

    public override android.graphics.drawable.Drawable GetDrawableForDensity(int i, int i2, android.content.res.Resources$Theme resources$Theme) {
        return EvynCqFziGvlaFre(this, i, i2, resources$Theme);
    }

    public override float GetFraction(int i, int i2, int i3) {
        return JVvaHvxAbgojIhAH(this, i, i2, i3);
    }

    public override int GetIdentifier(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return dLhrKGxfGIUvrYMW(this, str, str2, str3);
    }

    public override int[] GetIntArray(int i) throws android.content.res.Resources$NotFoundException {
        return lcoCXWfqYTXmUNKw(this, i);
    }

    public override int Getint(int i) throws android.content.res.Resources$NotFoundException {
        return ZzXVRjndIMQoCBIe(this, i);
    }

    public override android.content.res.XmlResourceParser GetLayout(int i) throws android.content.res.Resources$NotFoundException {
        return YUwEzhZiLMKdPjak(this, i);
    }

    public override android.graphics.Movie GetMovie(int i) throws android.content.res.Resources$NotFoundException {
        return JzMcVUMPFZPqONQj(this, i);
    }

    public override java.lang.string GetQuantitystring(int i, int i2) throws android.content.res.Resources$NotFoundException {
        return QsuUgJWrZMUoUyFU(this, i, i2);
    }

    public override java.lang.string GetQuantitystring(int i, int i2, java.lang.object[] objArr) throws android.content.res.Resources$NotFoundException {
        return NEMsSUlZkBkgHeVP(this, i, i2, objArr);
    }

    public override java.lang.CharSequence GetQuantityText(int i, int i2) throws android.content.res.Resources$NotFoundException {
        return kLzBUjqbbalYrnlB(this, i, i2);
    }

    public override java.lang.string GetResourceEntryName(int i) throws android.content.res.Resources$NotFoundException {
        return zPHquAFrhJdnAxkl(this, i);
    }

    public override java.lang.string GetResourceName(int i) throws android.content.res.Resources$NotFoundException {
        return SebxdsAZzisPtpGF(this, i);
    }

    public override java.lang.string GetResourcePackageName(int i) throws android.content.res.Resources$NotFoundException {
        return rkjzGhVFXFPjyTJz(this, i);
    }

    public override java.lang.string GetResourceTypeName(int i) throws android.content.res.Resources$NotFoundException {
        return YhiGhyCKyApnzGAA(this, i);
    }

    public override java.lang.string Getstring(int i) throws android.content.res.Resources$NotFoundException {
        return pbJejfXlDvDInpEC(this, i);
    }

    public override java.lang.string Getstring(int i, java.lang.object[] objArr) throws android.content.res.Resources$NotFoundException {
        return ESnzSeoBgSEIAaII(this, i, objArr);
    }

    public override java.lang.string[] GetstringArray(int i) throws android.content.res.Resources$NotFoundException {
        return JalDJiQqHYlDrqsf(this, i);
    }

    public override java.lang.CharSequence GetText(int i) throws android.content.res.Resources$NotFoundException {
        return VsmUTEOWIIGOseQv(this, i);
    }

    public override java.lang.CharSequence GetText(int i, java.lang.CharSequence charSequence) {
        return lsvKNaHDEcbiPvgP(this, i, charSequence);
    }

    public override java.lang.CharSequence[] GetTextArray(int i) throws android.content.res.Resources$NotFoundException {
        return lttITmsXPTuvmYDz(this, i);
    }

    public override void GetValue(int i, android.util.TypedValue typedValue, bool z) throws android.content.res.Resources$NotFoundException {
        DyLkyggEaqfzktpS(this, i, typedValue, z);
    }

    public override void GetValue(java.lang.string str, android.util.TypedValue typedValue, bool z) throws android.content.res.Resources$NotFoundException {
        hHyakLjwvPqrLYWn(this, str, typedValue, z);
    }

    public override void GetValueForDensity(int i, int i2, android.util.TypedValue typedValue, bool z) throws android.content.res.Resources$NotFoundException {
        nIxqkULtWFMbZjlA(this, i, i2, typedValue, z);
    }

    public override android.content.res.XmlResourceParser GetXml(int i) throws android.content.res.Resources$NotFoundException {
        return DhMjBGTFWqinbBAZ(this, i);
    }

    public override android.content.res.TypedArray ObtainAttributes(android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return FCugiqaFqttfplgt(this, attributeHashSet, iArr);
    }

    public override android.content.res.TypedArray ObtainTypedArray(int i) throws android.content.res.Resources$NotFoundException {
        return zDyqKXqKUfTYcpDM(this, i);
    }

    public override java.io.Stream OpenRawResource(int i) throws android.content.res.Resources$NotFoundException {
        return rYmbAYqACSYljzVe(this, i);
    }

    public override java.io.Stream OpenRawResource(int i, android.util.TypedValue typedValue) throws android.content.res.Resources$NotFoundException {
        return xTrRQTcKQMqwlvUc(this, i, typedValue);
    }

    public override android.content.res.AssetstringDescriptor OpenRawResourceFd(int i) throws android.content.res.Resources$NotFoundException {
        return haAhCVgRqkKvIWEY(this, i);
    }

    public void parseDictionary<string, object>Extra(java.lang.string str, android.util.AttributeHashSet attributeHashSet, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException {
        xnbLixrLqmPuIBaJ(this, str, attributeHashSet, bundle);
    }

    public void parseDictionary<string, object>Extras(android.content.res.XmlResourceParser xmlResourceParser, android.os.Dictionary<string, object> bundle) throws org.xmlpull.v1.XmlPullParserException, java.io.IOException {
        iUXTAiXqkSVveVfD(this, xmlResourceParser, bundle);
    }

    public override void UpdateConfiguration(android.content.res.Configuration configuration, android.util.DisplayMetrics displayMetrics) {
        ubzdbSbcLUnXpGhd(this, configuration, displayMetrics);
    }
}

