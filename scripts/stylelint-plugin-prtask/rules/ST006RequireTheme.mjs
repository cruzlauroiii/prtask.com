import stylelint from "stylelint";

const RuleName = "prtask/require-theme";

const Meta = {
  url: "",
};

const RuleFunction = (PrimaryOption) => {
  return (Root, Result) => {
    const ValidOptions = stylelint.utils.validateOptions(Result, RuleName, {
      actual: PrimaryOption,
    });

    if (!ValidOptions) {
      return;
    }

    const FilePath = Root.source.input.file || "";
    if (!FilePath.includes("Styles")) {
      return;
    }

    let HasThemeColors = false;
    let HasPrefersColorScheme = false;
    let HasDataTheme = false;

    Root.walkDecls((Decl) => {
      if (Decl.prop.startsWith("--color-")) {
        HasThemeColors = true;
      }
    });

    if (!HasThemeColors) {
      return;
    }

    Root.walkAtRules("media", (AtRule) => {
      if (AtRule.params.includes("prefers-color-scheme")) {
        HasPrefersColorScheme = true;
      }
    });

    Root.walkRules((RuleNode) => {
      if (RuleNode.selector.includes("data-theme")) {
        HasDataTheme = true;
      }
    });

    if (!HasPrefersColorScheme) {
      stylelint.utils.report({
        message: "Files defining theme colors (--color-*) must include a prefers-color-scheme media query",
        node: Root,
        result: Result,
        ruleName: RuleName,
      });
    }

    if (!HasDataTheme) {
      stylelint.utils.report({
        message: "Files defining theme colors (--color-*) must include a [data-theme] attribute selector",
        node: Root,
        result: Result,
        ruleName: RuleName,
      });
    }
  };
};

RuleFunction.ruleName = RuleName;
RuleFunction.meta = Meta;

export const ST006 = stylelint.createPlugin(RuleName, RuleFunction);
