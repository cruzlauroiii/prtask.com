import stylelint from "stylelint";
import { parse as ParseSelector } from "postcss-selector-parser";

const RuleName = "prtask/pascal-case";

const Meta = {
  url: "",
};

const PascalCasePattern = /^[A-Z][a-zA-Z0-9]*$/;

function IsPascalCase(Name) {
  return PascalCasePattern.test(Name);
}

const RuleFunction = (PrimaryOption) => {
  return (Root, Result) => {
    const ValidOptions = stylelint.utils.validateOptions(Result, RuleName, {
      actual: PrimaryOption,
    });

    if (!ValidOptions) {
      return;
    }

    Root.walkRules((RuleNode) => {
      const SelectorString = RuleNode.selector;
      if (!SelectorString) {
        return;
      }

      let Parsed;
      try {
        Parsed = ParseSelector().astSync(SelectorString);
      } catch {
        return;
      }

      Parsed.walk((Node) => {
        if (Node.type === "class") {
          const ClassName = Node.value;
          if (!IsPascalCase(ClassName)) {
            stylelint.utils.report({
              message: `Class selector ".${ClassName}" must use PascalCase`,
              node: RuleNode,
              result: Result,
              ruleName: RuleName,
            });
          }
        }
      });
    });

    Root.walkDecls((Decl) => {
      if (Decl.prop.startsWith("$")) {
        const VarName = Decl.prop.slice(1);
        if (!IsPascalCase(VarName)) {
          stylelint.utils.report({
            message: `SCSS variable "$${VarName}" must use PascalCase`,
            node: Decl,
            result: Result,
            ruleName: RuleName,
          });
        }
      }
    });

    Root.walkAtRules("mixin", (AtRule) => {
      const MixinName = AtRule.params.split("(")[0].trim();
      if (MixinName && !IsPascalCase(MixinName)) {
        stylelint.utils.report({
          message: `Mixin "${MixinName}" must use PascalCase`,
          node: AtRule,
          result: Result,
          ruleName: RuleName,
        });
      }
    });
  };
};

RuleFunction.ruleName = RuleName;
RuleFunction.meta = Meta;

export const ST001 = stylelint.createPlugin(RuleName, RuleFunction);
