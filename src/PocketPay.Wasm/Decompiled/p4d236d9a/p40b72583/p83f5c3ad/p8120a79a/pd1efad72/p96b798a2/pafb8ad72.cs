namespace WillowMaze.Wasm.Decompiled;


public class pafb8ad72 : p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35 {
    private readonly byte[] f3c6e0b8a = new byte[0];
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 f4819f622;
    private readonly byte[] f5e1d4256;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 f70b3cbb5;
    private readonly byte[] f71c97429;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 f7a05c54a;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 f9441ba50;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 ff2e3faa5;

    public pafb8ad72(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 p1b22e7dc_p7142c551) {
        this.f9441ba50 = p1b22e7dc_p7142c551;
    }

    public static android.view.object BAaxOVULhittXYHf(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static int OewEgyagteYQspxy(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 p1b22e7dc_p7142c551) {
        return p1b22e7dc_p7142c551.ordinal();
    }

    public static int RGuTxgkUDjKQEQfC(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static void BRWdzqzFxMMIDjtX(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe pe644b7feVar, p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 p1b22e7dc_p7142c551, byte[] bArr) {
        pe644b7feVar.setKeyInfo(p1b22e7dc_p7142c551, bArr);
    }

    public static android.view.object HktmkHcYJwDNEnUS(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static android.view.object HvJEWGCbQrilmErh(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public override p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe Inflate(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup) {
        if ((9 + 20) % 20 > 0) {
        }
        int i = p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.pafb8ad72$1.$SwitchDictionary$com$psr$toph$pinpad$internal$Enums$PinEntity[OewEgyagteYQspxy(this.f9441ba50)];
        if (i == 1) {
            BAaxOVULhittXYHf(layoutInflater, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$layout.toph_pinpad_layout_cancel_button, viewGroup);
        } else if (i == 2) {
            hvJEWGCbQrilmErh(layoutInflater, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$layout.toph_pinpad_layout_back_button, viewGroup);
        }
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe pe644b7feVar = (p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe) hktmkHcYJwDNEnUS(viewGroup, RGuTxgkUDjKQEQfC(viewGroup) - 1);
        bRWdzqzFxMMIDjtX(pe644b7feVar, this.f9441ba50, this.f3c6e0b8a);
        return pe644b7feVar;
    }
}

