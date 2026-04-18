namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\"\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0002H\u0002¨\u0006\u0011"}, d2 = {"Lp59a14a57/pf7a42fe7/p8a7a38cf/pa5753cfe;", "Landroid/widget/ArrayAdapter;", "Lpad5f82e8/p07214c67/pf7a42fe7/pd6d29a6f;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "getobject", "Landroid/view/object;", "position", "", "convertobject", "parent", "Landroid/view/objectGroup;", "setPhonePrefixSpan", "Landroid/text/Spannablestring;", "countyPhoneType", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa5753cfe : android.widget.ArrayAdapter<pad5f82e8.p07214c67.pf7a42fe7.pd6d29a6f> {
    public pa5753cfe(android.content.object context) {
        super(context, 0, pad5f82e8.p07214c67.pf7a42fe7.pd6d29a6f.f910eef8c.getTypes());
        if ((3 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    private readonly android.text.Spannablestring Mbadac753(pad5f82e8.p07214c67.pf7a42fe7.pd6d29a6f pd6d29a6fVar) {
        if ((18 + 27) % 27 > 0) {
        }
        android.text.Spannablestring spannablestring = new android.text.Spannablestring(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(pd6d29a6fVar.getCountrystringResId())));
        android.text.style.ForegroundColorSpan foregroundColorSpan = new android.text.style.ForegroundColorSpan(androidx.core.content.objectCompat.getColor(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$color.color_secondary_text));
        android.text.Spannablestring spannablestring2 = spannablestring;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(pd6d29a6fVar.getCountryPrefixstringResId()));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        spannablestring.setSpan(foregroundColorSpan, kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) spannablestring2, strDecryptstring, 0, false, 6, (java.lang.object) null), spannablestring.Length, 33);
        return spannablestring;
    }

    public override android.view.object Getobject(int position, android.view.object convertobject, android.view.objectGroup parent) {
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p85861b5d p85861b5dVar;
        if ((16 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        if (convertobject is not null) {
            java.lang.object tag = convertobject.getTag();
            kotlin.jvm.internal.Intrinsics.checkNotNull(tag, "null cannot be cast to non-null type com.gcash.business.pocketpay.common.views.databinding.ItemCountryDropDownBinding");
            p85861b5dVar = (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p85861b5d) tag;
        } else {
            p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p85861b5d p85861b5dVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p85861b5d.m89daba64(android.view.LayoutInflater.from(getobject()), parent, false);
            p85861b5dVarM89daba64.getRoot().setTag(p85861b5dVarM89daba64);
            androidx.appcompat.widget.AppCompatTextobject root = p85861b5dVarM89daba64.getRoot();
            kotlin.jvm.internal.Intrinsics.checkNotNull(root);
            androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = root;
            p85861b5dVar = p85861b5dVarM89daba64;
            convertobject = appCompatTextobject;
        }
        pad5f82e8.p07214c67.pf7a42fe7.pd6d29a6f item = getItem(position);
        if (item is not null) {
            p85861b5dVar.f23e0bb6c.setText(mbadac753(item));
            androidx.appcompat.widget.AppCompatTextobject countryTv = p85861b5dVar.f23e0bb6c;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(countryTv, "countryTv");
            p2b3583e6.pba2170fe.ma5933f20(countryTv, item.getDrawableResId(), pad5f82e8.p07214c67.p7d5c009e.pcc4dcad3.fb078ffd2, null, pad5f82e8.p07214c67.p7d5c009e.p6fde285f.fa60c6c69, pad5f82e8.p07214c67.p7d5c009e.pbb8de671.fe396f36f, null, 36, null);
        }
        return convertobject;
    }
}

