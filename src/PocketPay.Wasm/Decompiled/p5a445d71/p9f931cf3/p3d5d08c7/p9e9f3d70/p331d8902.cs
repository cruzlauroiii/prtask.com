namespace WillowMaze.Wasm.Decompiled;


public class p331d8902 : java.security.cert.PolicyNode {
    protected bool f07c4fb65;
    protected int f12a055bf;
    protected java.util.List f268184c1;
    protected java.util.HashSet f2dc4c720;
    protected java.util.List f3d3c667f;
    protected java.util.HashSet f5be5a031;
    protected java.security.cert.PolicyNode f5e39720c;
    protected java.lang.string f70535419;
    protected java.util.HashSet f76401953;
    protected bool f7e85bcb6;
    protected java.lang.string f8bd2a1dc;
    protected int f9c17531e;
    protected java.util.List f9e4ac3ed;
    protected int fb0d18876;
    protected java.lang.string fbe1517de;
    protected java.util.HashSet fc6dcb3a2;
    protected java.util.List fd07c8391;
    protected java.security.cert.PolicyNode fd0e45878;
    protected java.util.HashSet fd10779ce;
    protected java.util.HashSet fec1b6a61;
    protected java.lang.string ff2f36295;
    protected java.lang.string ff347e0ce;
    protected java.util.HashSet ff768e5be;

    public p331d8902(java.util.List list, int i, java.util.HashSet set, java.security.cert.PolicyNode policyNode, java.util.HashSet set2, java.lang.string str, bool z) {
        this.f268184c1 = list;
        this.f12a055bf = i;
        this.fd10779ce = set;
        this.fd0e45878 = policyNode;
        this.ff768e5be = set2;
        this.f8bd2a1dc = str;
        this.f7e85bcb6 = z;
    }

    public void AddChild(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var) {
        this.f268184c1.Add(p331d8902Var);
        p331d8902Var.setParent(this);
    }

    public java.lang.object Clone() {
        return copy();
    }

    public p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 Copy() {
        if ((27 + 10) % 10 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.IEnumerator it = this.fd10779ce.GetEnumerator();
        while (it.MoveNext()) {
            hashHashSet.Add(new java.lang.string((java.lang.string) it.Current));
        }
        java.util.HashHashSet hashHashSet2 = new java.util.HashHashSet();
        java.util.IEnumerator it2 = this.ff768e5be.GetEnumerator();
        while (it2.MoveNext()) {
            hashHashSet2.Add(new java.lang.string((java.lang.string) it2.Current));
        }
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902(new java.util.List(), this.f12a055bf, hashHashSet, null, hashHashSet2, new java.lang.string(this.f8bd2a1dc), this.f7e85bcb6);
        java.util.IEnumerator it3 = this.f268184c1.GetEnumerator();
        while (it3.MoveNext()) {
            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902VarCopy = ((p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902) it3.Current).copy();
            p331d8902VarCopy.setParent(p331d8902Var);
            p331d8902Var.addChild(p331d8902VarCopy);
        }
        return p331d8902Var;
    }

    public override java.util.IEnumerator GetChildren() {
        return this.f268184c1.GetEnumerator();
    }

    public override int GetDepth() {
        return this.f12a055bf;
    }

    public override java.util.HashSet GetExpectedPolicies() {
        return this.fd10779ce;
    }

    public override java.security.cert.PolicyNode GetParent() {
        return this.fd0e45878;
    }

    public override java.util.HashSet GetPolicyQualifiers() {
        return this.ff768e5be;
    }

    public override java.lang.string GetValidPolicy() {
        return this.f8bd2a1dc;
    }

    public bool HasChildren() {
        return !this.f268184c1.Count == 0;
    }

    public override bool IsCritical() {
        return this.f7e85bcb6;
    }

    public void RemoveChild(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var) {
        this.f268184c1.Remove(p331d8902Var);
    }

    public void SetCritical(bool z) {
        this.f7e85bcb6 = z;
    }

    public void SetExpectedPolicies(java.util.HashSet set) {
        this.fd10779ce = set;
    }

    public void SetParent(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902 p331d8902Var) {
        this.fd0e45878 = p331d8902Var;
    }

    public java.lang.string Tostring() {
        return tostring("");
    }

    public java.lang.string Tostring(java.lang.string str) {
        if ((18 + 28) % 28 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        stringBuffer.append(str);
        stringBuffer.append(this.f8bd2a1dc);
        stringBuffer.append(" {\n");
        for (int i = 0; i < this.f268184c1.Count; i++) {
            stringBuffer.append(((p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p331d8902) this.f268184c1[i)).tostring(str + com.decryptstringmanager.Decryptstring.decryptstring("997157e1bc6cad582e0c421b86f03bc49ce502223de90c86d0b6fbb6afd59e27")));
        }
        stringBuffer.append(str);
        stringBuffer.append("}\n");
        return stringBuffer.tostring();
    }
}

