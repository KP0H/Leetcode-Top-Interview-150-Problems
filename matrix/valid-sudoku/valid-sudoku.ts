function isValidSudoku(board: string[][]): boolean {
    const rows = new Array<number>(9).fill(0);
    const cols = new Array<number>(9).fill(0);
    const boxes = new Array<number>(9).fill(0);

    for (let r = 0; r < 9; r++) {
        for (let c = 0; c < 9; c++) {
            const ch = board[r][c];
            if (ch === ".") continue;

            const bit = 1 << (ch.charCodeAt(0) - "1".charCodeAt(0));
            const b = Math.floor(r / 3) * 3 + Math.floor(c / 3);

            if ((rows[r] & bit)
                || (cols[c] & bit)
                || (boxes[b] & bit))
                return false;

            rows[r] |= bit;
            cols[c] |= bit;
            boxes[b] |= bit;
        }
    }
    return true;
};