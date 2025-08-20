function isValid(s: string): boolean {
    const stack: string[] = [];

    for (const c of s) {
        if (c === '(' || c === '[' || c === '{') {
            stack.push(c);
        } else {
            const last = stack.pop();
            if (
                (c === ')' && last !== '(') ||
                (c === ']' && last !== '[') ||
                (c === '}' && last !== '{')
            ) {
                return false;
            }
        }
    }

    return stack.length === 0;
};