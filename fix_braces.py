"""Fix brace corruption in all test files by rebuilding method boundaries."""
import re, os

test_dir = 'tests/PrTask.E2E'
files = [f for f in os.listdir(test_dir) if f.endswith('.cs')]
fixed = 0

for fname in sorted(files):
    path = os.path.join(test_dir, fname)
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # Skip files without test methods
    if '[TestMethod' not in content:
        continue

    # Extract header (everything before first [TestMethod)
    first_test = content.find('[TestMethod')
    if first_test == -1:
        continue

    header = content[:first_test].rstrip()

    # Extract all test method blocks
    # Split at [TestMethod boundaries
    rest = content[first_test:]
    blocks = re.split(r'(?=\[TestMethod)', rest)

    methods = []
    for block in blocks:
        block = block.strip()
        if not block:
            continue

        # Find method signature
        sig_match = re.search(r'public void \w+\(\)', block)
        if not sig_match:
            continue

        # Find attributes before method
        attrs_part = block[:sig_match.start()].strip()
        method_name_match = re.search(r'public void (\w+)\(\)', block)
        method_name = method_name_match.group(1) if method_name_match else "unknown"

        # Find the method body - everything after the signature
        after_sig = block[sig_match.end():].strip()

        # Parse the body with string-aware brace counting
        if not after_sig.startswith('{'):
            # Method body might be merged with next block
            brace_idx = after_sig.find('{')
            if brace_idx == -1:
                continue
            after_sig = after_sig[brace_idx:]

        body_lines = []
        brace_count = 0
        in_string = False
        escape_next = False
        body_end = -1

        for i, ch in enumerate(after_sig):
            if escape_next:
                escape_next = False
                continue
            if ch == '\\' and in_string:
                escape_next = True
                continue
            if ch == '"' and not in_string:
                in_string = True
            elif ch == '"' and in_string:
                in_string = False
            elif ch == '{' and not in_string:
                brace_count += 1
            elif ch == '}' and not in_string:
                brace_count -= 1
                if brace_count == 0:
                    body_end = i
                    break

        if body_end == -1:
            # Could not find matching brace, skip
            print(f"  WARNING: Could not parse braces for {method_name} in {fname}")
            # Try to extract just the assertions
            body_text = after_sig
        else:
            body_text = after_sig[:body_end + 1]

        # Rebuild the method
        method_text = f"    {attrs_part}\n    public void {method_name}()\n    {body_text}"
        methods.append(method_text)

    if not methods:
        continue

    # Rebuild the file
    new_content = header + '\n'
    for method in methods:
        new_content += method + '\n'
    new_content += '}\n'

    if new_content != content:
        with open(path, 'w', encoding='utf-8') as f:
            f.write(new_content)
        fixed += 1
        test_count = new_content.count('[TestMethod')
        print(f"  Fixed {fname} ({test_count} tests)")

print(f"\nFixed {fixed} files")
