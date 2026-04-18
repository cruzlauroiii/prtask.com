import re, os

test_dir = 'tests/PrTask.E2E'
files = [f for f in os.listdir(test_dir) if f.endswith('.cs')]

pat = re.compile(r'Contains\("((?:[^"\\]|\\.)*)"')

# Step 1: Extract all methods and their assertions
method_asserts = {}
file_of_method = {}

for fname in sorted(files):
    path = os.path.join(test_dir, fname)
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    methods = re.split(r'(?=\[TestMethod)', content)
    for method_block in methods:
        m = re.search(r'public void (\w+)\(\)', method_block)
        if not m:
            continue
        method_name = m.group(1)
        file_of_method[method_name] = fname
        contains = set(pat.findall(method_block))
        method_asserts[method_name] = contains

# Step 2: Find exact duplicates - keep the first, remove the duplicate
exact_dupe_remove = set()
seen_sets = {}
for method_name, asserts in method_asserts.items():
    key = frozenset(asserts) if asserts else None
    if key and key in seen_sets:
        exact_dupe_remove.add(method_name)
    elif key:
        seen_sets[key] = method_name

# Step 3: Find strict subsets - remove the smaller one
subset_remove = set()
methods_list = list(method_asserts.keys())
for i, m1 in enumerate(methods_list):
    if m1 in exact_dupe_remove:
        continue
    s1 = method_asserts[m1]
    if len(s1) < 2:
        continue
    for j, m2 in enumerate(methods_list):
        if i == j or m2 in exact_dupe_remove:
            continue
        s2 = method_asserts[m2]
        if len(s2) <= len(s1):
            continue
        if s1 < s2:  # strict subset
            subset_remove.add(m1)
            break

removable = exact_dupe_remove | subset_remove
print(f"Exact duplicates to remove: {len(exact_dupe_remove)}")
print(f"Subset-redundant to remove: {len(subset_remove)}")
print(f"Total methods to remove: {len(removable)}")

# Step 4: Remove methods from files
files_modified = set()
for fname in sorted(files):
    path = os.path.join(test_dir, fname)
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    # Find methods to remove in this file
    methods_in_file = [m for m in removable if file_of_method.get(m) == fname]
    if not methods_in_file:
        continue

    for method_name in methods_in_file:
        # Build regex to match the full test method block:
        # [TestMethod, TestCategory(...)]
        # [DisplayName(...)]
        # public void MethodName()
        # { ... }
        # We need to match from [TestMethod to the closing } of the method

        # Find the method in content using string search
        method_sig = f"public void {method_name}()"
        idx = content.find(method_sig)
        if idx == -1:
            print(f"  WARNING: Could not find {method_name} in {fname}")
            continue

        # Walk backward to find [TestMethod
        start = idx
        while start > 0:
            # Look for [TestMethod
            prev_line_end = content.rfind('\n', 0, start)
            if prev_line_end == -1:
                break
            line = content[prev_line_end:start].strip()
            if '[TestMethod' in line or '[DisplayName' in line:
                start = prev_line_end
            elif line == '':
                start = prev_line_end
            else:
                break

        # Walk forward to find the closing brace
        brace_count = 0
        end = content.find('{', idx)
        if end == -1:
            print(f"  WARNING: No opening brace for {method_name} in {fname}")
            continue

        # Handle string literals properly
        i = end
        in_string = False
        escape_next = False
        while i < len(content):
            ch = content[i]
            if escape_next:
                escape_next = False
                i += 1
                continue
            if ch == '\\' and in_string:
                escape_next = True
                i += 1
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
                    end = i + 1
                    break
            i += 1

        # Remove the method block (including leading whitespace/newlines)
        # Also remove trailing newline
        while end < len(content) and content[end] in '\r\n':
            end += 1

        content = content[:start] + content[end:]

    # Clean up multiple blank lines
    while '\n\n\n' in content:
        content = content.replace('\n\n\n', '\n\n')

    with open(path, 'w', encoding='utf-8') as f:
        f.write(content)

    files_modified.add(fname)
    remaining = content.count('[TestMethod')
    print(f"  {fname}: removed {len(methods_in_file)} methods, {remaining} remaining")

# Step 5: Check for empty files (only namespace + class declaration)
for fname in sorted(files):
    path = os.path.join(test_dir, fname)
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    test_count = content.count('[TestMethod')
    if test_count == 0:
        print(f"  EMPTY FILE (0 tests): {fname} - deleting")
        os.remove(path)

print(f"\nFiles modified: {len(files_modified)}")
