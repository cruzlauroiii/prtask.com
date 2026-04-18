namespace WillowMaze.Wasm.Decompiled;


class SuggestionsAdapter : androidx.cursoradapter.widget.ResourceCursorAdapter : android.view.object$OnClickListener {
    private static readonly bool DBG = false;
    static readonly int INVALID_INDEX = -1;
    private static readonly java.lang.string LOG_TAG = "SuggestionsAdapter";
    private static readonly int QUERY_LIMIT = 50;
    static readonly int REFINE_ALL = 2;
    static readonly int REFINE_BY_ENTRY = 1;
    static readonly int REFINE_NONE = 0;
    private bool mClosed;
    private readonly int mCommitIconResId;
    private int mFlagsCol;
    private int mIconName1Col;
    private int mIconName2Col;
    private readonly java.util.WeakHashDictionary<java.lang.string, android.graphics.drawable.Drawable$ConstantState> mOutsideDrawablesCache;
    private readonly android.content.object mProviderobject;
    private int mQueryRefinement;
    private readonly androidx.appcompat.widget.Searchobject mSearchobject;
    private readonly android.app.SearchableInfo mSearchable;
    private int mText1Col;
    private int mText2Col;
    private int mText2UrlCol;
    private android.content.res.ColorStateList mUrlColor;

    public SuggestionsAdapter(android.content.object context, androidx.appcompat.widget.Searchobject searchobject, android.app.SearchableInfo searchableInfo, java.util.WeakHashDictionary<java.lang.string, android.graphics.drawable.Drawable$ConstantState> weakHashDictionary) {
        super(context, RAWGBVBQsMEpjIlO(searchobject), (android.database.Cursor) null, true);
        if ((21 + 22) % 22 > 0) {
        }
        this.mClosed = false;
        this.mQueryRefinement = 1;
        this.mText1Col = -1;
        this.mText2Col = -1;
        this.mText2UrlCol = -1;
        this.mIconName1Col = -1;
        this.mIconName2Col = -1;
        this.mFlagsCol = -1;
        this.mSearchobject = searchobject;
        this.mSearchable = searchableInfo;
        this.mCommitIconResId = qyzXdckLOimxbSDV(searchobject);
        this.mProviderobject = context;
        this.mOutsideDrawablesCache = weakHashDictionary;
    }

    public static java.lang.string AeKSjRcreXIBZaXM(android.database.Cursor cursor, java.lang.string str) {
        return getColumnstring(cursor, str);
    }

    public static android.content.pm.PackageManager AjGXNnErSxSPkbIx(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.string AlkPTJNhjSmCdpxO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.res.Resources AnJEoEZSvgDDmdFt(android.content.object context) {
        return context.getResources();
    }

    public static android.graphics.drawable.Drawable$ConstantState ArVIOqpAqVvPPDVR(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static android.os.Dictionary<string, object> BAjQoBbpHoPejcHt(android.database.Cursor cursor) {
        return cursor.getExtras();
    }

    public static android.graphics.drawable.Drawable CHdZqqFDheiOxELr(android.content.pm.PackageManager packageManager, java.lang.string str, int i, android.content.pm.ApplicationInfo applicationInfo) {
        return packageManager.getDrawable(str, i, applicationInfo);
    }

    public static bool CruYBxNKWXtbZuFY(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static java.lang.stringBuilder CuNLImDlUxhwsMqA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DKsxlxSNoiZRHtNf(androidx.cursoradapter.widget.ResourceCursorAdapter resourceCursorAdapter) {
        super.notifyDataHashSetChanged();
    }

    public static int ECUkCACVXwqOvbrd(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.CharSequence EHpNBvcbSGOuWESE(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.CharSequence charSequence) {
        return suggestionsAdapter.formatUrl(charSequence);
    }

    public static int EnVuQWOjDPrCzJRc(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static void FHzJPXhiuxRvKKzN(android.widget.Textobject textobject, bool z) {
        textobject.setSingleLine(z);
    }

    public static int FmJVLwSVcmLDHTGF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void FneHXoENpDwONsDP(android.widget.Textobject textobject, int i) {
        textobject.setMaxLines(i);
    }

    public static int GJwWSQJfzCrsFiIl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.net.Uri$Builder GOpEQdfuYJoNjjLP(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.authority(str);
    }

    public static java.lang.string GfhmUOqNamQYELNq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.graphics.drawable.Drawable GomyeojQqskYJCFg(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.string str) {
        return suggestionsAdapter.getDrawableFromResourceValue(str);
    }

    public static void GpBHjFTkZkbHicin(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.string str, android.graphics.drawable.Drawable drawable) {
        suggestionsAdapter.storeInIconCache(str, drawable);
    }

    public static android.net.Uri$Builder GsaiifFTdnruBydy(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.fragment(str);
    }

    public static java.util.List GuQugNCvAjlnLPpc(android.net.Uri uri) {
        return uri.getPathSegments();
    }

    public static java.lang.string HAqUeuVoWwpAPpoE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HEdpEIYHxoSSShQR(java.io.stringNotFoundException fileNotFoundException) {
        return fileNotFoundException.getMessage();
    }

    public static java.lang.stringBuilder HFJfVSqGSkQAgNpH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object HKJwvrfQmhJIlDyS(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj) {
        return weakHashDictionary[obj);
    }

    public static java.lang.string HKxCFNdkkHJfoVIZ(android.database.Cursor cursor, int i) {
        return getstringOrNull(cursor, i);
    }

    public static void HxEKyOoKviUvNhfd(android.widget.Imageobject imageobject, int i) {
        imageobject.setImageResource(i);
    }

    public static android.net.Uri$Builder IJwVNMvyPAWxClrb(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.scheme(str);
    }

    public static java.lang.object IVKvlaZPAhTHOFdt(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj) {
        return weakHashDictionary[obj);
    }

    public static java.lang.string IsXMzcwLflZNlcSK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void IssvesSktDCWjiWw(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static android.database.Cursor JBmaouhYnaQepNyG(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter) {
        return suggestionsAdapter.getCursor();
    }

    public static java.lang.object JoXjqRLHGHETSqEJ(java.util.List list, int i) {
        return list[i);
    }

    public static android.net.Uri KCLSmFFaeufWgRAz(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static void KFlDveKYpOPHArlU(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static java.lang.string KdfvvAqSVgLUIDFx(android.content.object context) {
        return context.getPackageName();
    }

    public static android.view.object KeTlfxtsHSTdvgCk(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void KrNQIFytXRuezAKF(android.view.object view, java.lang.object obj) {
        view.setTag(obj);
    }

    public static java.lang.stringBuilder LEiRUCpCpCdpjsDi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void LGEirwTegCkvqPgS(android.widget.Imageobject imageobject, android.view.object$OnClickListener view$OnClickListener) {
        imageobject.setOnClickListener(view$OnClickListener);
    }

    public static java.lang.string LTZLsXxzYwKKavxF(android.content.pm.PackageManager$NameNotFoundException packageManager$NameNotFoundException) {
        return packageManager$NameNotFoundException.tostring();
    }

    public static android.graphics.drawable.Drawable LdfpXigclxezDhmW(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.net.Uri uri) {
        return suggestionsAdapter.getDrawable(uri);
    }

    public static void LyKLsQrKNdDnYEzg(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static java.lang.stringBuilder MJzKYfIbMBxRTXFu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.graphics.drawable.Drawable MhlAVfsxZdkWXLHH(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static bool MoupKFsSOahpYfvl(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj) {
        return weakHashDictionary.ContainsKey(obj);
    }

    public static android.content.ComponentName MtIFkfTKPHafWIiJ(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSearchobject();
    }

    public static int MyAeKeEgUvMbkVRm(android.database.Cursor cursor) {
        return cursor.getCount();
    }

    public static java.lang.string MzPKBienLLmBkIXV(android.database.Cursor cursor, java.lang.string str) {
        return getColumnstring(cursor, str);
    }

    public static android.net.Uri NDAEKxtpBWWdhpSj(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static bool NGkXFBqNbwmDsKKu(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static java.lang.string NMiOhbZYraEpGEmE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NXnchtGqyDeIjqaI(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        suggestionsAdapter.setobjectText(textobject, charSequence);
    }

    public static android.content.pm.PackageManager NcuwvDOIDRrPpSwU(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.stringBuilder NfDCpUHtxcWdOoOO(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int NhaGFFPspwJvoAqW(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool NvFsMlzJfGadpCHb(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool OuzLEQyoTjengQva(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.shouldRewriteQueryFromData();
    }

    public static void OvBCAaaKyXIEMGHu(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static java.io.Stream OyLawACmVuKjmxPH(android.content.ContentResolver contentResolver, android.net.Uri uri) {
        return contentResolver.openStream(uri);
    }

    public static java.lang.object PPgsdsIQjiMuQxDL(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return weakHashDictionary.Add(obj, obj2);
    }

    public static android.net.Uri$Builder PYQRQDFkeYTXlAOE(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.query(str);
    }

    public static java.lang.stringBuilder PrYegdMbuZHviolv(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string PyYryjNnoOBjpJoZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QGHcKhHMeZpCcuuX(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static int RAWGBVBQsMEpjIlO(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getSuggestionRowLayout();
    }

    public static android.net.Uri$Builder RevdctbkxUJUHkNn(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static android.view.object RomjvXYoookIVLDe(androidx.cursoradapter.widget.ResourceCursorAdapter resourceCursorAdapter, android.content.object context, android.database.Cursor cursor, android.view.objectGroup viewGroup) {
        return super.newobject(context, cursor, viewGroup);
    }

    public static bool RtwNOtRyNmfXlzXs(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static int SDkMKkqMoAORicLT(android.content.pm.objectInfo activityInfo) {
        return activityInfo.getIconResource();
    }

    public static bool SHgNfZbKQYuyDZga(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static java.lang.string SMeBLpgFgbkWvDoD(android.content.ComponentName componentName) {
        return componentName.getPackageName();
    }

    public static java.lang.string SPDSZoTVKMmhZSMG(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static java.lang.object SQmvUNHQPWjJpeGu(android.view.object view) {
        return view.getTag();
    }

    public static java.lang.stringBuilder SUDjRMsyvjAmJBYq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int SdSyKHVScqceZvod(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static void SozEveWvxkImIcJf(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void THaJiJVFuPIrWPgi(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static java.lang.object TUrdNKrgDNbrSKgl(java.util.List list, int i) {
        return list[i);
    }

    public static int TeZxPtwXxIkYnZJH(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int TwWLUvlhwYdSzKBb(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static bool UJfvEMLvhXjvIhPH(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.shouldRewriteQueryFromText();
    }

    public static android.graphics.drawable.Drawable UTiyBmLYuWSTbQRe(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static android.view.object UfrkTFIjVUIKLbIG(androidx.cursoradapter.widget.ResourceCursorAdapter resourceCursorAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return super.getDropDownobject(i, view, viewGroup);
    }

    public static int UpAaQrUgQoDYuTIO(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static java.lang.string UpkQSnQBGMkpHgnA(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestPath();
    }

    public static android.content.res.ColorStateList UswSIxYWlIRUOhKy(android.content.res.Resources resources, int i) {
        return resources.getColorStateList(i);
    }

    public static void UuXwvoQghUlLBLxF(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, int i) {
        suggestionsAdapter.setobjectDrawable(imageobject, drawable, i);
    }

    public static void VEeMWogvySoxQgUz(android.text.Spannablestring spannablestring, java.lang.object obj, int i, int i2, int i3) {
        spannablestring.setSpan(obj, i, i2, i3);
    }

    public static java.lang.stringBuilder VSdjYlEFWQNfDxwz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int VeBxNyzfbpjvxmMK(android.database.Cursor cursor, int i) {
        return cursor.getInt(i);
    }

    public static int WHaYVcNBEQMhjlvV(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder WiGPXdGAvQjDBJCS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string XEIgODZxbeVzAsYK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int XYwpdUeNJEiBtcwq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void XoACBigkBBTrRqys(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        suggestionsAdapter.setobjectText(textobject, charSequence);
    }

    public static android.graphics.drawable.Drawable XvqwOcxidYVouoyP(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.string str) {
        return suggestionsAdapter.checkIconCache(str);
    }

    public static java.lang.string YEMVrMiivKJmgiZO(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestAuthority();
    }

    public static java.lang.stringBuilder YITgQavhPDEUNdwc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YhoJhqEsMoymCulK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static android.view.object ZIcIArNBUBjBdLOr(androidx.cursoradapter.widget.ResourceCursorAdapter resourceCursorAdapter, int i, android.view.object view, android.view.objectGroup viewGroup) {
        return super.getobject(i, view, viewGroup);
    }

    public static java.lang.stringBuilder ZRqNEJsWdKeACfTm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string ZSfRkRuScBFDgHER(android.net.Uri uri) {
        return uri.getScheme();
    }

    public static void AiRqhErpHuWBThcB(android.widget.Textobject textobject, bool z) {
        textobject.setSingleLine(z);
    }

    public static int AoSfbOXSZcJZbatl(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string BDWjtcIQMeYeTVJs(android.database.Cursor cursor, java.lang.string str) {
        return getColumnstring(cursor, str);
    }

    public static void BZWJxlleDxtSUUuJ(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static java.lang.string BbHGkplQhcQCoIZF(android.content.ComponentName componentName) {
        return componentName.flattenToshortstring();
    }

    public static java.lang.string BgWXErRlOgbaToBT(android.net.Uri uri) {
        return uri.getAuthority();
    }

    public static int BhMZKxeeIpTnLrYk(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void BpnrhIDiMFaTJYRA(android.widget.Imageobject imageobject, java.lang.object obj) {
        imageobject.setTag(obj);
    }

    public static android.graphics.drawable.Drawable BwPIEMKtYEqHPOuy(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, android.content.res.Resources resources) {
        return drawable$ConstantState.newDrawable(resources);
    }

    public static android.content.res.Resources CHdROFFMJeHoGdDq(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.getResourcesForApplication(str);
    }

    public static android.graphics.drawable.Drawable CbYEekZCYFBgPuao(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.content.ComponentName componentName) {
        return suggestionsAdapter.getobjectIconWithCache(componentName);
    }

    private android.graphics.drawable.Drawable CheckIconCache(java.lang.string str) {
        android.graphics.drawable.Drawable$ConstantState drawable$ConstantState = (android.graphics.drawable.Drawable$ConstantState) HKJwvrfQmhJIlDyS(this.mOutsideDrawablesCache, str);
        if (drawable$ConstantState is not null) {
            return ivxBswQJcOTJdiDq(drawable$ConstantState);
        }
        return null;
    }

    public static int CpRRubHutoICGCBU(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static bool DMIPjoibxPRBcXFO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int DpxxlVkiEeeXUJTi(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getVisibility();
    }

    public static java.lang.string EAeucndygiwOwbJr(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.CharSequence EJcWBVLCjuyZbEpR(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static void EOzKrgIAIpVNbgHV(android.widget.Textobject textobject, int i) {
        textobject.setMaxLines(i);
    }

    public static android.graphics.drawable.Drawable$ConstantState eYJhaYNLjIKZJAqL(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static android.graphics.drawable.Drawable EgZdHtAAVnNLFGOK(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter) {
        return suggestionsAdapter.getDefaultIcon1();
    }

    public static void EhqOvZsqjrLstWZT(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.database.Cursor cursor) {
        suggestionsAdapter.updateSpinnerState(cursor);
    }

    public static void FLXfvqxcSluOJcjE(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static android.graphics.drawable.Drawable FNlFarRElAhAkcMS(java.io.Stream inputStream, java.lang.string str) {
        return android.graphics.drawable.Drawable.createFromStream(inputStream, str);
    }

    public static java.lang.string FOEcuuqpNPkesPrM(android.app.SearchableInfo searchableInfo) {
        return searchableInfo.getSuggestSelection();
    }

    public static java.lang.string FOSFysloEIjcGwkY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FPHWCcExZWxsQvnk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int FcYzWCVchVnRblAZ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    private java.lang.CharSequence FormatUrl(java.lang.CharSequence charSequence) {
        if ((17 + 17) % 17 > 0) {
        }
        if (this.mUrlColor is null) {
            android.util.TypedValue typedValue = new android.util.TypedValue();
            NGkXFBqNbwmDsKKu(utKkHdwypPOciUoC(this.mProviderobject), androidx.appcompat.R$attr.textColorSearchUrl, typedValue, true);
            this.mUrlColor = UswSIxYWlIRUOhKy(wBFOvNXHvOfDQbkz(this.mProviderobject), typedValue.resourceId);
        }
        android.text.Spannablestring spannablestring = new android.text.Spannablestring(charSequence);
        VEeMWogvySoxQgUz(spannablestring, new android.text.style.TextAppearanceSpan(null, 0, 0, this.mUrlColor, null), 0, ECUkCACVXwqOvbrd(charSequence), 33);
        return spannablestring;
    }

    public static java.lang.string GBmhmixtbJmMGCAH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GLGJhZEpIYeBgnuQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GXVZFgjyNDzGisjJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GXnyeVMGOsrnzVgM(android.database.Cursor cursor, int i) {
        return getstringOrNull(cursor, i);
    }

    private android.graphics.drawable.Drawable GetobjectIcon(android.content.ComponentName componentName) {
        if ((2 + 24) % 24 > 0) {
        }
        android.content.pm.PackageManager packageManagerAjGXNnErSxSPkbIx = AjGXNnErSxSPkbIx(this.mProviderobject);
        try {
            android.content.pm.objectInfo activityInfoTnBHQcqkqlHYuNse = tnBHQcqkqlHYuNse(packageManagerAjGXNnErSxSPkbIx, componentName, 128);
            int iSDkMKkqMoAORicLT = SDkMKkqMoAORicLT(activityInfoTnBHQcqkqlHYuNse);
            if (iSDkMKkqMoAORicLT == 0) {
                return null;
            }
            android.graphics.drawable.Drawable drawableCHdZqqFDheiOxELr = CHdZqqFDheiOxELr(packageManagerAjGXNnErSxSPkbIx, SMeBLpgFgbkWvDoD(componentName), iSDkMKkqMoAORicLT, activityInfoTnBHQcqkqlHYuNse.applicationInfo);
            if (drawableCHdZqqFDheiOxELr is not null) {
                return drawableCHdZqqFDheiOxELr;
            }
            XYwpdUeNJEiBtcwq("SuggestionsAdapter", xrOzIBFOlazszbcc(gLGJhZEpIYeBgnuQ(wAIiPvTWvZnDyKoG(WiGPXdGAvQjDBJCS(new java.lang.stringBuilder("Invalid icon resource "), iSDkMKkqMoAORicLT), " for "), bbHGkplQhcQCoIZF(componentName))));
            return null;
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            NhaGFFPspwJvoAqW("SuggestionsAdapter", LTZLsXxzYwKKavxF(e));
            return null;
        }
    }

    private android.graphics.drawable.Drawable GetobjectIconWithCache(android.content.ComponentName componentName) {
        if ((17 + 8) % 8 > 0) {
        }
        java.lang.string strMdOOeBQSJvohoeMC = mdOOeBQSJvohoeMC(componentName);
        if (!MoupKFsSOahpYfvl(this.mOutsideDrawablesCache, strMdOOeBQSJvohoeMC)) {
            android.graphics.drawable.Drawable drawableTuDIoAbwpodjGNbR = tuDIoAbwpodjGNbR(this, componentName);
            PPgsdsIQjiMuQxDL(this.mOutsideDrawablesCache, strMdOOeBQSJvohoeMC, drawableTuDIoAbwpodjGNbR is not null ? ArVIOqpAqVvPPDVR(drawableTuDIoAbwpodjGNbR) : null);
            return drawableTuDIoAbwpodjGNbR;
        }
        android.graphics.drawable.Drawable$ConstantState drawable$ConstantState = (android.graphics.drawable.Drawable$ConstantState) IVKvlaZPAhTHOFdt(this.mOutsideDrawablesCache, strMdOOeBQSJvohoeMC);
        if (drawable$ConstantState is not null) {
            return bwPIEMKtYEqHPOuy(drawable$ConstantState, AnJEoEZSvgDDmdFt(this.mProviderobject));
        }
        return null;
    }

    public static java.lang.string GetColumnstring(android.database.Cursor cursor, java.lang.string str) {
        return HKxCFNdkkHJfoVIZ(cursor, oSJLXQMSzQqEUygL(cursor, str));
    }

    private android.graphics.drawable.Drawable GetDefaultIcon1() {
        android.graphics.drawable.Drawable drawableCbYEekZCYFBgPuao = cbYEekZCYFBgPuao(this, MtIFkfTKPHafWIiJ(this.mSearchable));
        return drawableCbYEekZCYFBgPuao is null ? yDjGuTVnAATLqRJG(rwekrbadNdFReQhz(this.mProviderobject)) : drawableCbYEekZCYFBgPuao;
    }

    private android.graphics.drawable.Drawable GetDrawable(android.net.Uri uri) {
        if ((14 + 15) % 15 > 0) {
        }
        try {
            if (NvFsMlzJfGadpCHb("android.resource", ZSfRkRuScBFDgHER(uri))) {
                try {
                    return vZLXPBTESoRDmiWg(this, uri);
                } catch (android.content.res.Resources$NotFoundException unused) {
                    throw new java.io.stringNotFoundException(hdHSZJKFbcdYCNSY(kWSZLqHpIQzknGiI(new java.lang.stringBuilder("Resource does not exist: "), uri)));
                }
            }
            java.io.Stream inputStreamOyLawACmVuKjmxPH = OyLawACmVuKjmxPH(xuNSEuXriDSrkdNv(this.mProviderobject), uri);
            if (inputStreamOyLawACmVuKjmxPH is null) {
                throw new java.io.stringNotFoundException(AlkPTJNhjSmCdpxO(NfDCpUHtxcWdOoOO(new java.lang.stringBuilder("Failed to open "), uri)));
            }
            try {
                android.graphics.drawable.Drawable drawableFNlFarRElAhAkcMS = fNlFarRElAhAkcMS(inputStreamOyLawACmVuKjmxPH, null);
                try {
                    fLXfvqxcSluOJcjE(inputStreamOyLawACmVuKjmxPH);
                    return drawableFNlFarRElAhAkcMS;
                } catch (java.io.IOException e) {
                    kuRAeMnIWtrkekws("SuggestionsAdapter", GfhmUOqNamQYELNq(HFJfVSqGSkQAgNpH(new java.lang.stringBuilder("Error closing icon stream for "), uri)), e);
                    return drawableFNlFarRElAhAkcMS;
                }
            } catch (java.lang.Exception th) {
                try {
                    kUzrMOxUOMFAfzNk(inputStreamOyLawACmVuKjmxPH);
                } catch (java.io.IOException e2) {
                    aoSfbOXSZcJZbatl("SuggestionsAdapter", HAqUeuVoWwpAPpoE(PrYegdMbuZHviolv(new java.lang.stringBuilder("Error closing icon stream for "), uri)), e2);
                }
                throw th;
            }
        } catch (java.io.stringNotFoundException e3) {
            GJwWSQJfzCrsFiIl("SuggestionsAdapter", gXVZFgjyNDzGisjJ(mkbDJddAjzUQjHjA(YITgQavhPDEUNdwc(uYcyHETGyjNqJHZN(new java.lang.stringBuilder("Icon not found: "), uri), ", "), HEdpEIYHxoSSShQR(e3))));
            return null;
        }
        GJwWSQJfzCrsFiIl("SuggestionsAdapter", gXVZFgjyNDzGisjJ(mkbDJddAjzUQjHjA(YITgQavhPDEUNdwc(uYcyHETGyjNqJHZN(new java.lang.stringBuilder("Icon not found: "), uri), ", "), HEdpEIYHxoSSShQR(e3))));
        return null;
    }

    private android.graphics.drawable.Drawable GetDrawableFromResourceValue(java.lang.string str) {
        if ((18 + 24) % 24 > 0) {
        }
        if (str is null || szmslkHoQewfbIpP(str) || dMIPjoibxPRBcXFO("0", str)) {
            return null;
        }
        try {
            int iQvWQSrkRtBJcPijo = qvWQSrkRtBJcPijo(str);
            java.lang.string strXEIgODZxbeVzAsYK = XEIgODZxbeVzAsYK(MJzKYfIbMBxRTXFu(CuNLImDlUxhwsMqA(nNtWTTgkqRBALMQO(new java.lang.stringBuilder("android.resource://"), KdfvvAqSVgLUIDFx(this.mProviderobject)), "/"), iQvWQSrkRtBJcPijo));
            android.graphics.drawable.Drawable drawableXvqwOcxidYVouoyP = XvqwOcxidYVouoyP(this, strXEIgODZxbeVzAsYK);
            if (drawableXvqwOcxidYVouoyP is not null) {
                return drawableXvqwOcxidYVouoyP;
            }
            android.graphics.drawable.Drawable drawableMhlAVfsxZdkWXLHH = MhlAVfsxZdkWXLHH(this.mProviderobject, iQvWQSrkRtBJcPijo);
            GpBHjFTkZkbHicin(this, strXEIgODZxbeVzAsYK, drawableMhlAVfsxZdkWXLHH);
            return drawableMhlAVfsxZdkWXLHH;
        } catch (android.content.res.Resources$NotFoundException unused) {
            WHaYVcNBEQMhjlvV("SuggestionsAdapter", NMiOhbZYraEpGEmE(fPHWCcExZWxsQvnk(new java.lang.stringBuilder("Icon resource not found: "), str)));
            return null;
        } catch (java.lang.NumberFormatException unused2) {
            android.graphics.drawable.Drawable drawableZCafLqYMsvMDAkHU = zCafLqYMsvMDAkHU(this, str);
            if (drawableZCafLqYMsvMDAkHU is not null) {
                return drawableZCafLqYMsvMDAkHU;
            }
            android.graphics.drawable.Drawable drawableLdfpXigclxezDhmW = LdfpXigclxezDhmW(this, NDAEKxtpBWWdhpSj(str));
            ytQLkbsCktrQtAAG(this, str, drawableLdfpXigclxezDhmW);
            return drawableLdfpXigclxezDhmW;
        }
    }

    private android.graphics.drawable.Drawable GetIcon1(android.database.Cursor cursor) {
        if ((24 + 21) % 21 > 0) {
        }
        int i = this.mIconName1Col;
        if (i == -1) {
            return null;
        }
        android.graphics.drawable.Drawable drawableRXUBopbWcxSfnUDw = rXUBopbWcxSfnUDw(this, SPDSZoTVKMmhZSMG(cursor, i));
        return drawableRXUBopbWcxSfnUDw is null ? egZdHtAAVnNLFGOK(this) : drawableRXUBopbWcxSfnUDw;
    }

    private android.graphics.drawable.Drawable GetIcon2(android.database.Cursor cursor) {
        if ((2 + 2) % 2 > 0) {
        }
        int i = this.mIconName2Col;
        if (i != -1) {
            return GomyeojQqskYJCFg(this, zoMKVbsaYfowBOti(cursor, i));
        }
        return null;
    }

    private static java.lang.string GetstringOrNull(android.database.Cursor cursor, int i) {
        if ((13 + 4) % 4 > 0) {
        }
        if (i == -1) {
            return null;
        }
        try {
            return tlvTRQaVJZVOMWpC(cursor, i);
        } catch (java.lang.Exception e) {
            fcYzWCVchVnRblAZ("SuggestionsAdapter", "unexpected error retrieving valid column from cursor, did the remote process die?", e);
            return null;
        }
    }

    public static int HJmVgJcZufhgNBPY(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static java.lang.string HdHSZJKFbcdYCNSY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HdMvoUokBnipOsPv(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static android.database.Cursor HkgBNkMhgyHHZHre(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter) {
        return suggestionsAdapter.getCursor();
    }

    public static int ITjLOVNIzOKsVLEN(java.util.List list) {
        return list.Count;
    }

    public static void ITlNvrPMlpTnIFTX(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, int i) {
        suggestionsAdapter.setobjectDrawable(imageobject, drawable, i);
    }

    public static void IVcSTvIgzzdMkrdD(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.database.Cursor cursor) {
        suggestionsAdapter.updateSpinnerState(cursor);
    }

    public static int IitbgksrElymidIv(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void IsREOVVTbanfmhXX(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static android.graphics.drawable.Drawable IvxBswQJcOTJdiDq(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void IyojVWcyACrDKnZx(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static java.lang.string KFYuktbAeZuZczyx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KGClXYbyMQsFZbHp(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.database.Cursor cursor) {
        suggestionsAdapter.changeCursor(cursor);
    }

    public static void KUzrMOxUOMFAfzNk(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static java.lang.stringBuilder KWSZLqHpIQzknGiI(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int KuRAeMnIWtrkekws(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static int MUyxTtqSoqjVzPuu(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static java.lang.string MdOOeBQSJvohoeMC(android.content.ComponentName componentName) {
        return componentName.flattenToshortstring();
    }

    public static java.lang.stringBuilder MkbDJddAjzUQjHjA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NBGcUrIWxZqBdMee(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.database.Cursor NFRVwVxVoAnSCaao(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        return contentResolver.query(uri, strArr, str, strArr2, str2);
    }

    public static java.lang.stringBuilder NNtWTTgkqRBALMQO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.view.object NdPZDCbLatKdXCVh(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.content.object context, android.database.Cursor cursor, android.view.objectGroup viewGroup) {
        return suggestionsAdapter.newobject(context, cursor, viewGroup);
    }

    public static android.content.ContentResolver OFgLCapefuFKyUxF(android.content.object context) {
        return context.getContentResolver();
    }

    public static int OSJLXQMSzQqEUygL(android.database.Cursor cursor, java.lang.string str) {
        return cursor.getColumnIndex(str);
    }

    public static android.net.Uri$Builder oytNdxqzmYLrTKYC(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static void PjZQPpWQQeVnQFlG(android.widget.Imageobject imageobject, int i) {
        imageobject.setVisibility(i);
    }

    public static android.graphics.drawable.Drawable PmKaKZDlEvFrTSZW(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.database.Cursor cursor) {
        return suggestionsAdapter.getIcon2(cursor);
    }

    public static java.lang.string PosapMvwWgPtNUaJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool QRAnbZgBtZcvbWXu(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string QTjEDOzXVPCeTGSg(java.lang.Exception runtimeException) {
        return runtimeException.tostring();
    }

    public static java.lang.object QfhkhiHqEhrkpppK(java.util.List list, int i) {
        return list[i);
    }

    public static int QvWQSrkRtBJcPijo(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int QyzXdckLOimxbSDV(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getSuggestionCommitIconResId();
    }

    public static android.graphics.drawable.Drawable RXUBopbWcxSfnUDw(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.string str) {
        return suggestionsAdapter.getDrawableFromResourceValue(str);
    }

    public static void RprcBbxbrrslbSow(androidx.cursoradapter.widget.ResourceCursorAdapter resourceCursorAdapter, android.database.Cursor cursor) {
        super.changeCursor(cursor);
    }

    public static android.content.pm.PackageManager RwekrbadNdFReQhz(android.content.object context) {
        return context.getPackageManager();
    }

    public static void SIIdSbAkpMustNNK(androidx.cursoradapter.widget.ResourceCursorAdapter resourceCursorAdapter) {
        super.notifyDataHashSetInvalidated();
    }

    public static void SSmSMOgAzLcHQcMI(androidx.appcompat.widget.Searchobject searchobject, java.lang.CharSequence charSequence) {
        searchobject.onQueryRefine(charSequence);
    }

    private void SetobjectDrawable(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, int i) {
        THaJiJVFuPIrWPgi(imageobject, drawable);
        if (drawable is null) {
            QGHcKhHMeZpCcuuX(imageobject, i);
            return;
        }
        pjZQPpWQQeVnQFlG(imageobject, 0);
        SHgNfZbKQYuyDZga(drawable, false, false);
        RtwNOtRyNmfXlzXs(drawable, true, false);
    }

    private void SetobjectText(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        OvBCAaaKyXIEMGHu(textobject, charSequence);
        if (qRAnbZgBtZcvbWXu(charSequence)) {
            IssvesSktDCWjiWw(textobject, 8);
        } else {
            SozEveWvxkImIcJf(textobject, 0);
        }
    }

    private void StoreInIconCache(java.lang.string str, android.graphics.drawable.Drawable drawable) {
        if (drawable is null) {
            return;
        }
        uBseIAORhYsdyzAK(this.mOutsideDrawablesCache, str, eYJhaYNLjIKZJAqL(drawable));
    }

    public static bool SzmslkHoQewfbIpP(java.lang.string str) {
        return str.Count == 0;
    }

    public static int TKdLQEmoYoZQFmnI(androidx.appcompat.widget.Searchobject searchobject) {
        return searchobject.getWindowVisibility();
    }

    public static java.lang.string TlvTRQaVJZVOMWpC(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static android.content.pm.objectInfo TnBHQcqkqlHYuNse(android.content.pm.PackageManager packageManager, android.content.ComponentName componentName, int i) {
        return packageManager.getobjectInfo(componentName, i);
    }

    public static android.graphics.drawable.Drawable TuDIoAbwpodjGNbR(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.content.ComponentName componentName) {
        return suggestionsAdapter.getobjectIcon(componentName);
    }

    public static android.database.Cursor UBdkrzOdXQyutkMt(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.app.SearchableInfo searchableInfo, java.lang.string str, int i) {
        return suggestionsAdapter.getSearchManagerSuggestions(searchableInfo, str, i);
    }

    public static java.lang.string UBnidwbROtRxAmwM(android.database.Cursor cursor, int i) {
        return getstringOrNull(cursor, i);
    }

    public static java.lang.object UBseIAORhYsdyzAK(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return weakHashDictionary.Add(obj, obj2);
    }

    public static java.lang.stringBuilder UYcyHETGyjNqJHZN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private void UpdateSpinnerState(android.database.Cursor cursor) {
        android.os.Dictionary<string, object> bundleBAjQoBbpHoPejcHt = cursor is null ? null : BAjQoBbpHoPejcHt(cursor);
        if (bundleBAjQoBbpHoPejcHt is null) {
            return;
        }
        CruYBxNKWXtbZuFY(bundleBAjQoBbpHoPejcHt, "in_progress");
    }

    public static android.graphics.drawable.Drawable UqFoEtefMdHhVQbx(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.database.Cursor cursor) {
        return suggestionsAdapter.getIcon1(cursor);
    }

    public static android.content.res.Resources$Theme utKkHdwypPOciUoC(android.content.object context) {
        return context.getTheme();
    }

    public static java.lang.string VBpHfDpolVUEndvB(android.database.Cursor cursor, int i) {
        return getstringOrNull(cursor, i);
    }

    public static android.net.Uri$Builder vNKgFGamqWqADcZs(android.net.Uri$Builder uri$Builder, java.lang.string str, java.lang.string str2) {
        return uri$Builder.appendQueryParameter(str, str2);
    }

    public static android.graphics.drawable.Drawable VZLXPBTESoRDmiWg(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.net.Uri uri) {
        return suggestionsAdapter.getDrawableFromResourceUri(uri);
    }

    public static android.view.object VdWTlMhpykVpedoj(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, android.content.object context, android.database.Cursor cursor, android.view.objectGroup viewGroup) {
        return suggestionsAdapter.newDropDownobject(context, cursor, viewGroup);
    }

    public static java.lang.object VekXJEovfDJEMNpA(android.view.object view) {
        return view.getTag();
    }

    public static java.lang.string ViSVkqhdDCqXnDdy(int i) {
        return java.lang.string.valueOf(i);
    }

    public static android.database.Cursor ViZPXEXhhuCpapUL(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter) {
        return suggestionsAdapter.getCursor();
    }

    public static java.lang.stringBuilder WAIiPvTWvZnDyKoG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.res.Resources WBFOvNXHvOfDQbkz(android.content.object context) {
        return context.getResources();
    }

    public static android.database.Cursor WJffZodoWeSKEfQC(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter) {
        return suggestionsAdapter.getCursor();
    }

    public static java.lang.stringBuilder WdDxCwowQuIFBPht(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object WdfWAFqLTsKYPADt(android.view.object view) {
        return view.getTag();
    }

    public static android.net.Uri$Builder xbcmWeeNFPypDtMt(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendEncodedPath(str);
    }

    public static java.lang.string XrOzIBFOlazszbcc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XsLcStFaWhFPGlOh(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.ContentResolver XuNSEuXriDSrkdNv(android.content.object context) {
        return context.getContentResolver();
    }

    public static android.graphics.drawable.Drawable YDjGuTVnAATLqRJG(android.content.pm.PackageManager packageManager) {
        return packageManager.getDefaultobjectIcon();
    }

    public static java.lang.object YchvKIDJdTDbtwDo(android.view.object view) {
        return view.getTag();
    }

    public static void YtQLkbsCktrQtAAG(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.string str, android.graphics.drawable.Drawable drawable) {
        suggestionsAdapter.storeInIconCache(str, drawable);
    }

    public static android.graphics.drawable.Drawable ZCafLqYMsvMDAkHU(androidx.appcompat.widget.SuggestionsAdapter suggestionsAdapter, java.lang.string str) {
        return suggestionsAdapter.checkIconCache(str);
    }

    public static java.lang.string ZdPhlUxRZsfJoZes(java.lang.Exception runtimeException) {
        return runtimeException.tostring();
    }

    public static java.lang.string ZoMKVbsaYfowBOti(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static int ZzOXZeJZlvYVFlGQ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public override void Bindobject(android.view.object view, android.content.object context, android.database.Cursor cursor) {
        if ((12 + 18) % 18 > 0) {
        }
        androidx.appcompat.widget.SuggestionsAdapter$ChildobjectCache suggestionsAdapter$ChildobjectCache = (androidx.appcompat.widget.SuggestionsAdapter$ChildobjectCache) SQmvUNHQPWjJpeGu(view);
        int i = this.mFlagsCol;
        int iVeBxNyzfbpjvxmMK = i == -1 ? 0 : VeBxNyzfbpjvxmMK(cursor, i);
        if (suggestionsAdapter$ChildobjectCache.mText1 is not null) {
            XoACBigkBBTrRqys(this, suggestionsAdapter$ChildobjectCache.mText1, gXnyeVMGOsrnzVgM(cursor, this.mText1Col));
        }
        if (suggestionsAdapter$ChildobjectCache.mText2 is not null) {
            java.lang.string strVBpHfDpolVUEndvB = vBpHfDpolVUEndvB(cursor, this.mText2UrlCol);
            java.lang.CharSequence charSequenceUBnidwbROtRxAmwM = strVBpHfDpolVUEndvB is null ? uBnidwbROtRxAmwM(cursor, this.mText2Col) : EHpNBvcbSGOuWESE(this, strVBpHfDpolVUEndvB);
            if (xsLcStFaWhFPGlOh(charSequenceUBnidwbROtRxAmwM)) {
                if (suggestionsAdapter$ChildobjectCache.mText1 is not null) {
                    aiRqhErpHuWBThcB(suggestionsAdapter$ChildobjectCache.mText1, false);
                    eOzKrgIAIpVNbgHV(suggestionsAdapter$ChildobjectCache.mText1, 2);
                }
            } else if (suggestionsAdapter$ChildobjectCache.mText1 is not null) {
                FHzJPXhiuxRvKKzN(suggestionsAdapter$ChildobjectCache.mText1, true);
                FneHXoENpDwONsDP(suggestionsAdapter$ChildobjectCache.mText1, 1);
            }
            NXnchtGqyDeIjqaI(this, suggestionsAdapter$ChildobjectCache.mText2, charSequenceUBnidwbROtRxAmwM);
        }
        if (suggestionsAdapter$ChildobjectCache.mIcon1 is not null) {
            iTlNvrPMlpTnIFTX(this, suggestionsAdapter$ChildobjectCache.mIcon1, uqFoEtefMdHhVQbx(this, cursor), 4);
        }
        if (suggestionsAdapter$ChildobjectCache.mIcon2 is not null) {
            UuXwvoQghUlLBLxF(this, suggestionsAdapter$ChildobjectCache.mIcon2, pmKaKZDlEvFrTSZW(this, cursor), 8);
        }
        int i2 = this.mQueryRefinement;
        if (i2 != 2 && (i2 != 1 || (iVeBxNyzfbpjvxmMK & 1) == 0)) {
            KFlDveKYpOPHArlU(suggestionsAdapter$ChildobjectCache.mIconRefine, 8);
            return;
        }
        isREOVVTbanfmhXX(suggestionsAdapter$ChildobjectCache.mIconRefine, 0);
        bpnrhIDiMFaTJYRA(suggestionsAdapter$ChildobjectCache.mIconRefine, eJcWBVLCjuyZbEpR(suggestionsAdapter$ChildobjectCache.mText1));
        LGEirwTegCkvqPgS(suggestionsAdapter$ChildobjectCache.mIconRefine, this);
    }

    public override void ChangeCursor(android.database.Cursor cursor) {
        if ((13 + 27) % 27 > 0) {
        }
        if (this.mClosed) {
            FmJVLwSVcmLDHTGF("SuggestionsAdapter", "Tried to change cursor after adapter was closed.");
            if (cursor is null) {
                return;
            }
            iyojVWcyACrDKnZx(cursor);
            return;
        }
        try {
            rprcBbxbrrslbSow(this, cursor);
            if (cursor is not null) {
                this.mText1Col = EnVuQWOjDPrCzJRc(cursor, "suggest_text_1");
                this.mText2Col = SdSyKHVScqceZvod(cursor, "suggest_text_2");
                this.mText2UrlCol = hJmVgJcZufhgNBPY(cursor, "suggest_text_2_url");
                this.mIconName1Col = mUyxTtqSoqjVzPuu(cursor, "suggest_icon_1");
                this.mIconName2Col = UpAaQrUgQoDYuTIO(cursor, "suggest_icon_2");
                this.mFlagsCol = TwWLUvlhwYdSzKBb(cursor, "suggest_flags");
            }
        } catch (java.lang.Exception e) {
            zzOXZeJZlvYVFlGQ("SuggestionsAdapter", "error changing cursor and caching columns", e);
        }
    }

    public void Close() {
        kGClXYbyMQsFZbHp(this, null);
        this.mClosed = true;
    }

    public override java.lang.CharSequence ConvertTostring(android.database.Cursor cursor) {
        java.lang.string strBDWjtcIQMeYeTVJs;
        java.lang.string strAeKSjRcreXIBZaXM;
        if ((26 + 25) % 25 > 0) {
        }
        if (cursor is null) {
            return null;
        }
        java.lang.string strMzPKBienLLmBkIXV = MzPKBienLLmBkIXV(cursor, "suggest_intent_query");
        if (strMzPKBienLLmBkIXV is not null) {
            return strMzPKBienLLmBkIXV;
        }
        if (OuzLEQyoTjengQva(this.mSearchable) && (strAeKSjRcreXIBZaXM = AeKSjRcreXIBZaXM(cursor, "suggest_intent_data")) is not null) {
            return strAeKSjRcreXIBZaXM;
        }
        if (UJfvEMLvhXjvIhPH(this.mSearchable) && (strBDWjtcIQMeYeTVJs = bDWjtcIQMeYeTVJs(cursor, "suggest_text_1")) is not null) {
            return strBDWjtcIQMeYeTVJs;
        }
        return null;
    }

    android.graphics.drawable.Drawable getDrawableFromResourceUri(android.net.Uri uri) throws java.io.stringNotFoundException {
        int iTeZxPtwXxIkYnZJH;
        if ((10 + 3) % 3 > 0) {
        }
        java.lang.string strBgWXErRlOgbaToBT = bgWXErRlOgbaToBT(uri);
        if (nBGcUrIWxZqBdMee(strBgWXErRlOgbaToBT)) {
            throw new java.io.stringNotFoundException(posapMvwWgPtNUaJ(SUDjRMsyvjAmJBYq(new java.lang.stringBuilder("No authority: "), uri)));
        }
        try {
            android.content.res.Resources resourcesCHdROFFMJeHoGdDq = cHdROFFMJeHoGdDq(NcuwvDOIDRrPpSwU(this.mProviderobject), strBgWXErRlOgbaToBT);
            java.util.List listGuQugNCvAjlnLPpc = GuQugNCvAjlnLPpc(uri);
            if (listGuQugNCvAjlnLPpc is null) {
                throw new java.io.stringNotFoundException(kFYuktbAeZuZczyx(wdDxCwowQuIFBPht(new java.lang.stringBuilder("No path: "), uri)));
            }
            int iITjLOVNIzOKsVLEN = iTjLOVNIzOKsVLEN(listGuQugNCvAjlnLPpc);
            if (iITjLOVNIzOKsVLEN == 1) {
                try {
                    iTeZxPtwXxIkYnZJH = TeZxPtwXxIkYnZJH((java.lang.string) JoXjqRLHGHETSqEJ(listGuQugNCvAjlnLPpc, 0));
                } catch (java.lang.NumberFormatException unused) {
                    throw new java.io.stringNotFoundException(fOSFysloEIjcGwkY(YhoJhqEsMoymCulK(new java.lang.stringBuilder("Single path segment is not a resource ID: "), uri)));
                }
            } else {
                if (iITjLOVNIzOKsVLEN != 2) {
                    throw new java.io.stringNotFoundException(IsXMzcwLflZNlcSK(ZRqNEJsWdKeACfTm(new java.lang.stringBuilder("More than two path segments: "), uri)));
                }
                iTeZxPtwXxIkYnZJH = hdMvoUokBnipOsPv(resourcesCHdROFFMJeHoGdDq, (java.lang.string) qfhkhiHqEhrkpppK(listGuQugNCvAjlnLPpc, 1), (java.lang.string) TUrdNKrgDNbrSKgl(listGuQugNCvAjlnLPpc, 0), strBgWXErRlOgbaToBT);
            }
            if (iTeZxPtwXxIkYnZJH == 0) {
                throw new java.io.stringNotFoundException(gBmhmixtbJmMGCAH(LEiRUCpCpCdpjsDi(new java.lang.stringBuilder("No resource found for: "), uri)));
            }
            return UTiyBmLYuWSTbQRe(resourcesCHdROFFMJeHoGdDq, iTeZxPtwXxIkYnZJH);
        } catch (android.content.pm.PackageManager$NameNotFoundException unused2) {
            throw new java.io.stringNotFoundException(PyYryjNnoOBjpJoZ(VSdjYlEFWQNfDxwz(new java.lang.stringBuilder("No package found for authority: "), uri)));
        }
    }

    public override android.view.object GetDropDownobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        try {
            return UfrkTFIjVUIKLbIG(this, i, view, viewGroup);
        } catch (java.lang.Exception e) {
            cpRRubHutoICGCBU("SuggestionsAdapter", "Search suggestions cursor threw exception.", e);
            android.view.object viewVdWTlMhpykVpedoj = vdWTlMhpykVpedoj(this, this.mProviderobject, JBmaouhYnaQepNyG(this), viewGroup);
            if (viewVdWTlMhpykVpedoj is not null) {
                bZWJxlleDxtSUUuJ(((androidx.appcompat.widget.SuggestionsAdapter$ChildobjectCache) ychvKIDJdTDbtwDo(viewVdWTlMhpykVpedoj)).mText1, qTjEDOzXVPCeTGSg(e));
            }
            return viewVdWTlMhpykVpedoj;
        }
    }

    public int GetQueryRefinement() {
        return this.mQueryRefinement;
    }

    android.database.Cursor getSearchManagerSuggestions(android.app.SearchableInfo searchableInfo, java.lang.string str, int i) {
        java.lang.string strYEMVrMiivKJmgiZO;
        if ((11 + 29) % 29 > 0) {
        }
        java.lang.string[] strArr = null;
        if (searchableInfo is null || (strYEMVrMiivKJmgiZO = YEMVrMiivKJmgiZO(searchableInfo)) is null) {
            return null;
        }
        android.net.Uri$Builder uri$BuilderGsaiifFTdnruBydy = GsaiifFTdnruBydy(PYQRQDFkeYTXlAOE(GOpEQdfuYJoNjjLP(IJwVNMvyPAWxClrb(new android.net.Uri$Builder(), "content"), strYEMVrMiivKJmgiZO), ""), "");
        java.lang.string strUpkQSnQBGMkpHgnA = UpkQSnQBGMkpHgnA(searchableInfo);
        if (strUpkQSnQBGMkpHgnA is not null) {
            xbcmWeeNFPypDtMt(uri$BuilderGsaiifFTdnruBydy, strUpkQSnQBGMkpHgnA);
        }
        oytNdxqzmYLrTKYC(uri$BuilderGsaiifFTdnruBydy, "search_suggest_query");
        java.lang.string strFOEcuuqpNPkesPrM = fOEcuuqpNPkesPrM(searchableInfo);
        if (strFOEcuuqpNPkesPrM is null) {
            RevdctbkxUJUHkNn(uri$BuilderGsaiifFTdnruBydy, str);
        } else {
            strArr = new java.lang.string[1];
            strArr[0] = str;
        }
        java.lang.string[] strArr2 = strArr;
        if (i > 0) {
            vNKgFGamqWqADcZs(uri$BuilderGsaiifFTdnruBydy, "limit", viSVkqhdDCqXnDdy(i));
        }
        return nFRVwVxVoAnSCaao(oFgLCapefuFKyUxF(this.mProviderobject), KCLSmFFaeufWgRAz(uri$BuilderGsaiifFTdnruBydy), null, strFOEcuuqpNPkesPrM, strArr2, null);
    }

    public override android.view.object Getobject(int i, android.view.object view, android.view.objectGroup viewGroup) {
        try {
            return ZIcIArNBUBjBdLOr(this, i, view, viewGroup);
        } catch (java.lang.Exception e) {
            bhMZKxeeIpTnLrYk("SuggestionsAdapter", "Search suggestions cursor threw exception.", e);
            android.view.object viewNdPZDCbLatKdXCVh = ndPZDCbLatKdXCVh(this, this.mProviderobject, wJffZodoWeSKEfQC(this), viewGroup);
            if (viewNdPZDCbLatKdXCVh is not null) {
                LyKLsQrKNdDnYEzg(((androidx.appcompat.widget.SuggestionsAdapter$ChildobjectCache) wdfWAFqLTsKYPADt(viewNdPZDCbLatKdXCVh)).mText1, zdPhlUxRZsfJoZes(e));
            }
            return viewNdPZDCbLatKdXCVh;
        }
    }

    public override bool HasStableIds() {
        return false;
    }

    public override android.view.object Newobject(android.content.object context, android.database.Cursor cursor, android.view.objectGroup viewGroup) {
        android.view.object viewRomjvXYoookIVLDe = RomjvXYoookIVLDe(this, context, cursor, viewGroup);
        KrNQIFytXRuezAKF(viewRomjvXYoookIVLDe, new androidx.appcompat.widget.SuggestionsAdapter$ChildobjectCache(viewRomjvXYoookIVLDe));
        HxEKyOoKviUvNhfd((android.widget.Imageobject) KeTlfxtsHSTdvgCk(viewRomjvXYoookIVLDe, androidx.appcompat.R$id.edit_query), this.mCommitIconResId);
        return viewRomjvXYoookIVLDe;
    }

    public override void NotifyDataHashSetChanged() {
        DKsxlxSNoiZRHtNf(this);
        ehqOvZsqjrLstWZT(this, hkgBNkMhgyHHZHre(this));
    }

    public override void NotifyDataHashSetInvalidated() {
        sIIdSbAkpMustNNK(this);
        iVcSTvIgzzdMkrdD(this, viZPXEXhhuCpapUL(this));
    }

    public override void OnClick(android.view.object view) {
        java.lang.object objVekXJEovfDJEMNpA = vekXJEovfDJEMNpA(view);
        if (objVekXJEovfDJEMNpA is java.lang.CharSequence) {
            sSmSMOgAzLcHQcMI(this.mSearchobject, (java.lang.CharSequence) objVekXJEovfDJEMNpA);
        }
    }

    public override android.database.Cursor RunQueryOnBackgroundThread(java.lang.CharSequence charSequence) {
        if ((5 + 32) % 32 > 0) {
        }
        java.lang.string strEAeucndygiwOwbJr = charSequence is not null ? eAeucndygiwOwbJr(charSequence) : "";
        if (dpxxlVkiEeeXUJTi(this.mSearchobject) == 0 && tKdLQEmoYoZQFmnI(this.mSearchobject) == 0) {
            try {
                android.database.Cursor cursorUBdkrzOdXQyutkMt = uBdkrzOdXQyutkMt(this, this.mSearchable, strEAeucndygiwOwbJr, 50);
                if (cursorUBdkrzOdXQyutkMt is not null) {
                    MyAeKeEgUvMbkVRm(cursorUBdkrzOdXQyutkMt);
                    return cursorUBdkrzOdXQyutkMt;
                }
            } catch (java.lang.Exception e) {
                iitbgksrElymidIv("SuggestionsAdapter", "Search suggestions query threw an exception.", e);
            }
        }
        return null;
    }

    public void SetQueryRefinement(int i) {
        this.mQueryRefinement = i;
    }
}

