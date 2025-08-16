function canConstruct(ransomNote: string, magazine: string): boolean {
    const counts = new Array(26).fill(0);

    for (let i = 0; i < magazine.length; i++) {
        counts[magazine.charCodeAt(i) - 97]++;
    }

    for (let i = 0; i < ransomNote.length; i++) {
        const j = ransomNote.charCodeAt(i) - 97;
        counts[j]--;
        if (counts[j] < 0) {
            return false;
        }
    }

    return true;
};