function romanToInt(s: string): number {
    const val = (c: string): number => {
        switch (c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: throw new Error(`Unexpected roman char: '${c}'`);
        }
    };

    let total = 0;
    let prev = 0;

    for (let i = s.length - 1; i >= 0; i--) {
        const v = val(s[i]);
        if (v < prev)
            total -= v;
        else
            total += v;
        prev = v;
    }
    
    return total;
};