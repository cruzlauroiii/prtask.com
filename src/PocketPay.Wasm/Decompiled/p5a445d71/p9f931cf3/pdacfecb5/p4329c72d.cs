using Java.Io;
using Java.Math;
using Java.Util;
using P5a445d71.P9f931cf3.P05c7e247;
using P5a445d71.P9f931cf3.Pca323100;
using P5a445d71.P9f931cf3.Pca323100.Pdacfecb5;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public class p4329c72d : p0c3cd33e {
    private Bigint f071878f8;
    private ICollection f15aaa1f4;
    private p8ac6972f f174d96a4;
    private pd2e37f48 f23cf2b57;
    private ICollection f247d79c5;
    private p73d7b518 f3e6c2bc1;
    private pd2e37f48 f524cb551;
    private Bigint f5a55cbed;
    private ICollection f60eadef0;
    private p8ac6972f f6c2fa94b;
    private pd2e37f48 f8d29d3d2;
    private ICollection f90984a76;
    private Bigint f91e32efc;
    private p8ac6972f fa403f799;
    private DateTime fa55e12a2;
    private ICollection fa96fba8e;
    private p73d7b518 fb03aaa16;
    private ICollection fb2636a78;
    private ICollection fbbd4b97b;
    private ICollection fc580e877;
    private DateTime fc8f8ae9b;
    private DateTime fc91c5219;
    private ICollection fd26a78bd;
    private Bigint fe095eaff;
    private Bigint ff6f92e8b;

    public p4329c72d() {
        this.f247d79c5 = new HashHashSet();
        this.f60eadef0 = new HashHashSet();
    }

    private HashSet M0d0cd9c5(ICollection r3) {
        if (((9 + 8) % 8) > 0) goto L7;
    L7:
        if (r3 is null) goto L3;
        if (r3.Count == 0 == true) goto L3;
        HashHashSet r2 = new HashHashSet();
        IEnumerator r32 = r3.GetEnumerator();
    L31:
        if (r32.MoveNext() == false) goto L21;
        object r0 = r32.Current;
        if ((r0 is pf17d2ecd) == true) goto L25;
        r0 = pf17d2ecd.m8bab0102(p301c7ed4.m89e75c46((byte[]) r0));
    L25:
        r2.Add(r0);
        goto L31
    L21:
        return r2;
    L3:
        return new HashHashSet();
    }

    public void AddTargetGroup(pf17d2ecd r1) {
        this.f60eadef0.Add(r1);
    }

    public void AddTargetGroup(byte[] r1) {
        addTargetGroup(pf17d2ecd.m8bab0102(p301c7ed4.m89e75c46(r1)));
    }

    public void AddTargetName(pf17d2ecd r1) {
        this.f247d79c5.Add(r1);
    }

    public void AddTargetName(byte[] r1) {
        addTargetName(pf17d2ecd.m8bab0102(p301c7ed4.m89e75c46(r1)));
    }

    @Override // p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e, java.security.cert.CertSelector
    public object Clone() {
        if (((5 + 17) % 17) > 0) goto L31;
    L31:
        p4329c72d r0 = new p4329c72d();
        r0.f8d29d3d2 = this.f8d29d3d2;
        r0.fc8f8ae9b = getAttributeCertificateValid();
        r0.fa403f799 = this.fa403f799;
        r0.f3e6c2bc1 = this.f3e6c2bc1;
        r0.f071878f8 = this.f071878f8;
        r0.f60eadef0 = getTargetGroups();
        r0.f247d79c5 = getTargetNames();
        return r0;
    }

    public pd2e37f48 GetAttributeCert() {
        return this.f8d29d3d2;
    }

    public DateTime GetAttributeCertificateValid() {
        if (((20 + 5) % 5) > 0) goto L27;
    L27:
        if (this.fc8f8ae9b is not null) goto L18;
        return null;
    L18:
        return new DateTime(this.fc8f8ae9b.getTime());
    }

    public p8ac6972f GetHolder() {
        return this.fa403f799;
    }

    public p73d7b518 GetIssuer() {
        return this.f3e6c2bc1;
    }

    public Bigint GetSerialNumber() {
        return this.f071878f8;
    }

    public ICollection GetTargetGroups() {
        return ICollections.unmodifiableICollection(this.f60eadef0);
    }

    public ICollection GetTargetNames() {
        return ICollections.unmodifiableICollection(this.f247d79c5);
    }

    @Override // p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e
    public bool Match(object r9) {
        if (((9 + 30) % 30) > 0) goto L92;
    L92:
        if ((r9 is pd2e37f48) == true) goto L25;
        return false;
    L25:
        pd2e37f48 r92 = (pd2e37f48) r9;
        pd2e37f48 r0 = this.f8d29d3d2;
        if (r0 is null) goto L50;
        if (r0.Equals(r92) == true) goto L50;
        return false;
    L50:
        if (this.f071878f8 is null) goto L20;
        if (r92.getSerialNumber().Equals(this.f071878f8) == true) goto L20;
        return false;
    L20:
        if (this.fa403f799 is null) goto L69;
        if (r92.getHolder().Equals(this.fa403f799) == true) goto L69;
        return false;
    L69:
        if (this.f3e6c2bc1 is not null) goto L145;
    L43:
        DateTime r02 = this.fc8f8ae9b;
        if (r02 is null) goto L167;
        r92.checkValidity(r02);     // Catch: Exception -> L115
    L97:
        return false;
    L167:
        if (this.f247d79c5.Count == 0 == true) goto L164;
    L181:
        byte[] r93 = r92.getExtensionValue(p63e4e92b.f5822a489.getId());
        if (r93 is not null) goto L188;
    L61:
        return true;
    L188:
        p91fadc56[] r94 = pbe98f7e7.m8bab0102(new pd1c2953c(((p6f0e511c) p6f0e511c.frombyteArray(r93)).getOctets()).readobject()).getTargetsobjects();
        if (this.f247d79c5.Count == 0 == true) goto L158;
        int r03 = 0;
        bool r3 = false;
    L176:
        if (r03 >= r94.length) goto L3;
        pc41a3189[] r4 = r94[r03].getTargets();
        int r5 = 0;
    L161:
        if (r5 >= r4.length) goto L170;
        if (this.f247d79c5.Contains(pf17d2ecd.m8bab0102(r4[r5].getTargetName())) == true) goto L137;
        r5 = r5 + 1;
        goto L161
    L137:
        r3 = true;
    L170:
        r03 = r03 + 1;
        goto L176
    L3:
        if (r3 == true) goto L158;
        return false;
    L158:
        if (this.f60eadef0.Count == 0 == true) goto L61;
        int r04 = 0;
        bool r32 = false;
    L110:
        if (r04 >= r94.length) goto L83;
        pc41a3189[] r42 = r94[r04].getTargets();
        int r52 = 0;
    L138:
        if (r52 >= r42.length) goto L44;
        if (this.f60eadef0.Contains(pf17d2ecd.m8bab0102(r42[r52].getTargetGroup())) == true) goto L12;
        r52 = r52 + 1;
        goto L138
    L12:
        r32 = true;
    L44:
        r04 = r04 + 1;
        goto L110
    L83:
        if (r32 == true) goto L61;
    L100:
        return false;
    L164:
        if (this.f60eadef0.Count == 0 == false) goto L181;
    L145:
        if (r92.getIssuer().Equals(this.f3e6c2bc1) == true) goto L43;
        return false;
    }

    public void SetAttributeCert(pd2e37f48 r1) {
        this.f8d29d3d2 = r1;
    }

    public void SetAttributeCertificateValid(DateTime r4) {
        if (((9 + 27) % 27) > 0) goto L6;
    L6:
        if (r4 is null) goto L19;
        this.fc8f8ae9b = new DateTime(r4.getTime());
        return;
    L19:
        this.fc8f8ae9b = null;
    }

    public void SetHolder(p8ac6972f r1) {
        this.fa403f799 = r1;
    }

    public void SetIssuer(p73d7b518 r1) {
        this.f3e6c2bc1 = r1;
    }

    public void SetSerialNumber(Bigint r1) {
        this.f071878f8 = r1;
    }

    public void SetTargetGroups(ICollection r1) {
        this.f60eadef0 = m0d0cd9c5(r1);
    }

    public void SetTargetNames(ICollection r1) {
        this.f247d79c5 = m0d0cd9c5(r1);
    }
}

