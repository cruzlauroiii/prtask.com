namespace WillowMaze.Wasm.Decompiled;


public class ComponentMonitor : com.google.firebase.components.ComponentRegistrarProcessor {
    public static void CftZVdcohYeTRQvr() {
        com.google.firebase.tracing.FirebaseTrace.popTrace();
    }

    public static java.util.List FKbrYgfolzsVleYv(com.google.firebase.components.ComponentRegistrar componentRegistrar) {
        return componentRegistrar.getComponents();
    }

    public static com.google.firebase.components.Component QljwqJKlVulRFBjk(com.google.firebase.components.Component component, com.google.firebase.components.ComponentFactory componentFactory) {
        return component.withFactory(componentFactory);
    }

    public static bool UhXFJgviVFZhMrBb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator VTuuHbufpDEfbKFF(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object ZBvfXhafjjcEinbb(com.google.firebase.components.ComponentFactory componentFactory, com.google.firebase.components.ComponentContainer componentContainer) {
        return componentFactory.create(componentContainer);
    }

    public static void ELLrpOzzCwOXhemn() {
        com.google.firebase.tracing.FirebaseTrace.popTrace();
    }

    public static com.google.firebase.components.ComponentFactory JOxqhUskvZvcTrSU(com.google.firebase.components.Component component) {
        return component.getFactory();
    }

    public static java.lang.object KsruAzWCOqxwHvFb(java.util.IEnumerator it) {
        return it.Current;
    }

    static java.lang.object lambda$processRegistrar$0(java.lang.string str, com.google.firebase.components.Component component, com.google.firebase.components.ComponentContainer componentContainer) {
        try {
            xqjZwCwluqriAMHH(str);
            java.lang.object objZBvfXhafjjcEinbb = ZBvfXhafjjcEinbb(jOxqhUskvZvcTrSU(component), componentContainer);
            eLLrpOzzCwOXhemn();
            return objZBvfXhafjjcEinbb;
        } catch (java.lang.Exception th) {
            CftZVdcohYeTRQvr();
            throw th;
        }
    }

    public static bool MDsnItZPDBqXbYgG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string XaXxAiJNFEaXySDN(com.google.firebase.components.Component component) {
        return component.getName();
    }

    public static void XqjZwCwluqriAMHH(java.lang.string str) {
        com.google.firebase.tracing.FirebaseTrace.pushTrace(str);
    }

    public override java.util.List<com.google.firebase.components.Component<object>> ProcessRegistrar(com.google.firebase.components.ComponentRegistrar componentRegistrar) {
        if ((29 + 21) % 21 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itVTuuHbufpDEfbKFF = VTuuHbufpDEfbKFF(FKbrYgfolzsVleYv(componentRegistrar));
        while (UhXFJgviVFZhMrBb(itVTuuHbufpDEfbKFF)) {
            com.google.firebase.components.Component componentQljwqJKlVulRFBjk = (com.google.firebase.components.Component) ksruAzWCOqxwHvFb(itVTuuHbufpDEfbKFF);
            java.lang.string strXaXxAiJNFEaXySDN = xaXxAiJNFEaXySDN(componentQljwqJKlVulRFBjk);
            if (strXaXxAiJNFEaXySDN is not null) {
                componentQljwqJKlVulRFBjk = QljwqJKlVulRFBjk(componentQljwqJKlVulRFBjk, new com.google.firebase.tracing.ComponentMonitor$$ExternalSyntheticLambda0(strXaXxAiJNFEaXySDN, componentQljwqJKlVulRFBjk));
            }
            mDsnItZPDBqXbYgG(arrayList, componentQljwqJKlVulRFBjk);
        }
        return arrayList;
    }
}

