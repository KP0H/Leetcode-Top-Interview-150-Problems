function fullJustify(words: string[], maxWidth: number): string[] {
    const res: string[] = [];
    let i = 0;

    while (i < words.length) {
        let j = i, lineLen = 0;
        while (j < words.length && lineLen + words[j].length + (j - i) <= maxWidth) {
        lineLen += words[j].length;
        j++;
        }

        const gaps = j - i - 1;
        const lastLine = j === words.length;

        if (lastLine || gaps === 0) {
        const line = words.slice(i, j).join(" ");
        res.push(line + " ".repeat(maxWidth - line.length));
        } else {
        const totalSpaces = maxWidth - lineLen;
        const spaceEach = Math.floor(totalSpaces / gaps);
        const extra = totalSpaces % gaps;

        let line = "";
        for (let k = i; k < j; k++) {
            line += words[k];
            if (k < j - 1) {
            const spaces = spaceEach + (k - i < extra ? 1 : 0);
            line += " ".repeat(spaces);
            }
        }
        res.push(line);
        }

        i = j;
    }

    return res;
};